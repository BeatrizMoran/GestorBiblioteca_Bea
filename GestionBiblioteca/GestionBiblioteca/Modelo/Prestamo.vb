Imports System.Data.SQLite
Imports System.Globalization

Public Class Prestamo


    Property Id As Integer
    Property IdLibro As Integer
    Property IdUsuario As Integer
    Property FechaInicio As String
    Property FechaFin As String
    Property Disponible As Boolean

    Public Sub New(idLibro As Integer, idUsuario As Integer, fechaInicio As Date, fechaFin As Date, disponible As Boolean)
        Me.IdLibro = idLibro
        Me.IdUsuario = idUsuario
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.Disponible = disponible
    End Sub



    Public Shared Function BuscarPrestamo(id As Integer) As PrestamoDTO
        Try
            Dim conn As New SQLiteConnection(My.Settings.conexion)
            conn.Open()

            Dim prestamo As PrestamoDTO
            Dim Cmd As New SQLiteCommand("SELECT 
                                     p.ID,
                                     p.Fecha_Inicio,
                                     p.Fecha_Fin,
                                     p.Disponible AS Estado,
                                     l.Titulo AS LibroTitulo,
                                     CONCAT(u.Nombre, ' ', u.Apellido_1) AS UsuarioNombre
                                   FROM 
                                     Prestamos p
                                   JOIN 
                                     Libros l ON p.ID_Libro = l.ID
                                   JOIN 
                                     Usuarios u ON p.ID_Usuario = u.ID
                                   WHERE p.ID = @Id", conn)


            Cmd.Parameters.Add("@Id", DbType.Int32).Value = id

            Dim lector As SQLiteDataReader = Cmd.ExecuteReader()

            If lector.Read() Then
                Dim estado

                If lector("Estado") = True Then
                    estado = "Disponible"
                Else
                    estado = "En prestamo"
                End If
                prestamo = New PrestamoDTO With {
                .Id = Convert.ToInt32(lector("ID")),
                .LibroTitulo = lector("LibroTitulo").ToString(),
                .UsuarioNombre = lector("UsuarioNombre").ToString(),
                .FechaInicio = DateTime.Parse(lector("Fecha_Inicio").ToString()),
                .FechaFin = DateTime.Parse(lector("Fecha_Fin").ToString()),
                .Estado = estado
                }

            End If
            ' Cerrar el lector y la conexión después de usarlos
            lector.Close()
            conn.Close()


            Return prestamo
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw New Exception("Error al buscar el prestamo: " & ex.Message)

        End Try
    End Function

    Public Sub CrearPrestamo()
        Try
            ' Verificar si el libro está en préstamo antes de crear el préstamo
            If LibroEnPrestamo(IdLibro) Then
                Throw New Exception("El libro seleccionado ya está en préstamo.")
            End If

            ' Crear el préstamo si no hay conflictos
            Dim Cmd As New SQLiteCommand

            ' Consulta de inserción para crear el préstamo
            Dim Sql As String = "INSERT INTO Prestamos (Id_Libro, Id_Usuario, Fecha_Inicio, Fecha_Fin, Disponible)
                             VALUES (@LibroId, @UsuarioId, @FechaInicio, @FechaFin, @Estado)"

            Cmd.CommandText = Sql
            Cmd.Parameters.Add("@LibroId", DbType.Int32).Value = IdLibro
            Cmd.Parameters.Add("@UsuarioId", DbType.Int32).Value = IdUsuario
            Cmd.Parameters.Add("@FechaInicio", DbType.String).Value = FechaInicio
            Cmd.Parameters.Add("@FechaFin", DbType.String).Value = FechaFin
            Cmd.Parameters.Add("@Estado", DbType.Boolean).Value = Disponible

            ' Ejecutar la consulta
            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        Catch ex As Exception
            ' Manejar errores
            Throw New Exception("Error al crear el préstamo: " & ex.Message)
        End Try
    End Sub

    Public Shared Function LibroEnPrestamo(libroId As Integer) As Boolean
        Try
            ' Abrir la conexión con la base de datos usando Using para liberar recursos automáticamente
            Using conn As New SQLiteConnection(My.Settings.conexion)
                conn.Open()

                ' Crear el comando con la consulta
                Dim Cmd As New SQLiteCommand("SELECT COUNT(*) AS Total FROM Prestamos 
                                          WHERE Id_Libro = @LibroId AND Disponible = 0", conn)

                ' Agregar parámetros
                Cmd.Parameters.Add("@LibroId", DbType.Int32).Value = libroId

                ' Ejecutar el comando y procesar el resultado
                Using lector As SQLiteDataReader = Cmd.ExecuteReader()
                    If lector.Read() Then
                        ' Leer el valor de la columna "Total"
                        Dim resultado As Integer = Convert.ToInt32(lector("Total"))
                        Return resultado > 0 ' Devuelve True si el libro está en préstamo
                    Else
                        Return False ' No hay filas, el libro no está en préstamo
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar errores y lanzar excepción personalizada
            Throw New Exception("Error al verificar si el libro está en préstamo: " & ex.Message)
        End Try
    End Function

    Public Shared Function FiltrarPrestamos(filtrarActivos As Boolean, filtrarDisponibles As Boolean) As List(Of PrestamoDTO)
        Try


            ' Construir la consulta base
            Dim query As String = "SELECT 
                                     p.ID,
                                     p.Fecha_Inicio,
                                     p.Fecha_Fin,
                                     p.Disponible AS Estado,
                                     l.Titulo AS LibroTitulo,
                                     CONCAT(u.Nombre, ' ', u.Apellido_1) AS UsuarioNombre
                                   FROM 
                                     Prestamos p
                                   JOIN 
                                     Libros l ON p.ID_Libro = l.ID
                                   JOIN 
                                     Usuarios u ON p.ID_Usuario = u.ID WHERE 1=1"


            If filtrarActivos AndAlso filtrarDisponibles Then
                ' Si ambos están seleccionados, no añadir filtro de disponibilidad
            Else
                If filtrarActivos Then
                    query &= " AND Disponible = 0" ' 0: en préstamo
                End If

                If filtrarDisponibles Then
                    query &= " AND Disponible = 1" ' 1: disponible
                End If
            End If
            Dim Cmd As New SQLiteCommand(query)




            Dim dt As DataTable = SQLLite.GetDataTable(My.Settings.conexion, Cmd)

            Dim prestamos As New List(Of PrestamoDTO)

            For Each row As DataRow In dt.Rows
                Dim prestamo As New PrestamoDTO With {
                .Id = Convert.ToInt32(row("Id")),
                .LibroTitulo = row("LibroTitulo").ToString(),
                .UsuarioNombre = row("UsuarioNombre").ToString(),
                .Estado = Convert.ToBoolean(row("Estado")),
                .FechaFin = row("Fecha_Fin").ToString()
            }
                prestamos.Add(prestamo)
            Next


            Return prestamos

        Catch ex As Exception
            Throw New Exception("Error al obtener los préstamos: " & ex.Message)
        End Try
    End Function


    Public Sub ActualizarPrestamo()
        Try
            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "UPDATE Prestamos SET Id_Libro = @Id_Libro, Id_Usuario = @Id_Usuario, Fecha_Inicio = @FechaInicio, Fecha_Fin = @FechaFin, Disponible = @Disponible WHERE Id = @Id"

            Cmd.CommandText = Sql

            Cmd.Parameters.AddWithValue("@Id_Libro", IdLibro)
            Cmd.Parameters.AddWithValue("@Id_Usuario", IdUsuario)
            Cmd.Parameters.Add("@FechaInicio", DbType.String).Value = FechaInicio
            Cmd.Parameters.Add("@FechaFin", DbType.String).Value = FechaFin
            Cmd.Parameters.AddWithValue("@Disponible", If(Disponible, 1, 0))
            Cmd.Parameters.AddWithValue("@Id", Id)

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)
        Catch ex As Exception
            Throw New Exception("Error al actualizar el préstamo: " & ex.Message)
        End Try
    End Sub


    Public Shared Sub BorrarPrestamo(id As Integer)
        Try
            Dim cmd As New SQLiteCommand
            Dim Sql As String = "DELETE FROM Prestamos where Id=@Id"
            cmd.CommandText = Sql

            cmd.Parameters.Add("@Id", DbType.Int32).Value = id

            SQLLite.Ejecuta(My.Settings.conexion, cmd)
        Catch ex As Exception
            Throw New Exception("Error al borrar el prestamo: " & ex.Message)
        End Try
    End Sub
End Class
