Imports System.Data.SQLite
Imports System.Globalization

Public Class Prestamo

    Property Id As Integer
    Property IdLibro As Integer
    Property IdUsuario As Integer
    Property FechaInicio As String
    Property FechaFin As String

    Public Sub New(idLibro As Integer, idUsuario As Integer, fechaInicio As Date, fechaFin As Date)
        Me.IdLibro = idLibro
        Me.IdUsuario = idUsuario
        Me.FechaInicio = fechaInicio.ToString("yyyy-MM-dd")
        Me.FechaFin = fechaFin.ToString("yyyy-MM-dd")
    End Sub

    Public Shared Function BuscarPrestamo(id As Integer) As PrestamoDTO
        Try

            Dim prestamo As New PrestamoDTO
            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "SELECT 
                                    p.ID,
                                    p.Fecha_Inicio,
                                    p.Fecha_Fin,
                                    l.Disponible AS Estado,
                                    l.Titulo AS LibroTitulo,
                                    CONCAT(u.Nombre, ' ', u.Apellido_1) AS UsuarioNombre
                                    FROM 
                                    Prestamos p
                                    JOIN 
                                    Libros l ON p.ID_Libro = l.ID
                                    JOIN 
                                    Usuarios u ON p.ID_Usuario = u.ID
                                    WHERE p.ID = @Id"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add("@Id", DbType.Int32).Value = id

            Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)

            If lector.Read() Then

                prestamo = New PrestamoDTO With {
                            .Id = Convert.ToInt32(lector("ID")),
                            .LibroTitulo = lector("LibroTitulo").ToString(),
                            .UsuarioNombre = lector("UsuarioNombre").ToString(),
                            .FechaInicio = DateTime.Parse(lector("Fecha_Inicio").ToString()),
                            .FechaFin = DateTime.Parse(lector("Fecha_Fin").ToString()),
                            .Estado = Convert.ToBoolean(lector("Estado"))
                        }
                Console.WriteLine("prestamo estado: " & prestamo.Estado)
            End If

                Return prestamo
        Catch ex As Exception
            Throw New Exception("Error al buscar el préstamo: " & ex.Message)
        End Try
    End Function

    Public Sub CrearPrestamo()
        Try
            ' Verificar si el libro está en préstamo antes de crear el préstamo
            If LibroEnPrestamo(IdLibro) Then
                Throw New Exception("El libro seleccionado ya está en préstamo.")
            End If


            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "
                    INSERT INTO Prestamos (Id_Libro, Id_Usuario, Fecha_Inicio, Fecha_Fin)
                    VALUES (@LibroId, @UsuarioId, @FechaInicio, @FechaFin)"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add("@LibroId", DbType.Int32).Value = IdLibro
            Cmd.Parameters.Add("@UsuarioId", DbType.Int32).Value = IdUsuario
            Cmd.Parameters.Add("@FechaInicio", DbType.String).Value = FechaInicio
            Cmd.Parameters.Add("@FechaFin", DbType.String).Value = FechaFin

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)
            ACtualizarDisponibiladLibro(IdLibro)
        Catch ex As Exception
            Throw New Exception("Error al crear el préstamo: " & ex.Message)
        End Try
    End Sub

    Private Sub ACtualizarDisponibiladLibro(libroId As Integer)
        Try
            Dim cmd As New SQLiteCommand
            Dim Sql As String = "UPDATE Libros SET Disponible = 0 WHERE ID = @LibroId"

            cmd.CommandText = Sql
            cmd.Parameters.Add("@LibroId", DbType.Int32).Value = IdLibro
            SQLLite.Ejecuta(My.Settings.conexion, cmd)



        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function LibroEnPrestamo(libroId As Integer) As Boolean
        Try

            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "SELECT * FROM Libros 
                    WHERE ID = @LibroId and Disponible = 0"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add("@LibroId", DbType.Int32).Value = libroId

            Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)


            If lector.Read() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error al verificar si el libro está en préstamo: " & ex.Message)
        End Try
    End Function

    Public Shared Function FiltrarPrestamos(filtrarActivos As Boolean, filtrarDisponibles As Boolean) As List(Of PrestamoDTO)
        Try
            Dim query As String = "SELECT 
                                     p.ID,
                                     p.Fecha_Inicio,
                                     p.Fecha_Fin,
                                     l.Disponible AS Estado,
                                     l.Titulo AS LibroTitulo,
                                     CONCAT(u.Nombre, ' ', u.Apellido_1) AS UsuarioNombre
                                   FROM 
                                     Prestamos p
                                   JOIN 
                                     Libros l ON p.ID_Libro = l.ID
                                   JOIN 
                                     Usuarios u ON p.ID_Usuario = u.ID WHERE 1=1"

            If filtrarActivos AndAlso filtrarDisponibles Then
                ' No añadir filtro si ambos están seleccionados
            Else
                If filtrarActivos Then
                    query &= " AND l.Disponible = 0" ' Libros en préstamo
                End If

                If filtrarDisponibles Then
                    query &= " AND l.Disponible = 1" ' Libros disponibles
                End If
            End If

            Dim Cmd As New SQLiteCommand(query)
            Dim dt As DataTable = SQLLite.GetDataTable(My.Settings.conexion, Cmd)

            Dim prestamos As New List(Of PrestamoDTO)

            For Each row As DataRow In dt.Rows
                Dim estado As Boolean = Convert.ToBoolean(row("Estado"))
                Dim prestamo As New PrestamoDTO With {
                    .Id = Convert.ToInt32(row("ID")),
                    .LibroTitulo = row("LibroTitulo").ToString(),
                    .UsuarioNombre = row("UsuarioNombre").ToString(),
                    .Estado = estado,
                    .FechaInicio = DateTime.Parse(row("Fecha_Inicio").ToString()),
                    .FechaFin = DateTime.Parse(row("Fecha_Fin").ToString())
                }
                prestamos.Add(prestamo)
            Next

            Return prestamos
        Catch ex As Exception
            Throw New Exception("Error al filtrar los préstamos: " & ex.Message)
        End Try
    End Function

    Public Sub ActualizarPrestamo()
        Try

            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "
                    UPDATE Prestamos 
                    SET Id_Libro = @Id_Libro, Id_Usuario = @Id_Usuario, Fecha_Inicio = @FechaInicio, Fecha_Fin = @FechaFin 
                    WHERE ID = @Id"
            Cmd.CommandText = Sql



            Cmd.Parameters.AddWithValue("@Id_Libro", IdLibro)
            Cmd.Parameters.AddWithValue("@Id_Usuario", IdUsuario)
            Cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio)
            Cmd.Parameters.AddWithValue("@FechaFin", FechaFin)

            Cmd.Parameters.AddWithValue("@Id", Id)

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        Catch ex As Exception
            Throw New Exception("Error al actualizar el préstamo: " & ex.Message)
        End Try
    End Sub

    Public Shared Sub BorrarPrestamo(id As Integer)
        Try
            ' Obtener el Id_Libro 
            Dim ObtenerLibroCmd As New SQLiteCommand
            Dim consulta As String = "SELECT Id_Libro FROM Prestamos WHERE ID = @Id"
            ObtenerLibroCmd.CommandText = consulta
            ObtenerLibroCmd.Parameters.Add("@Id", DbType.Int32).Value = id
            Dim lector As SQLiteDataReader = SQLLite.GetDataReader(My.Settings.conexion, ObtenerLibroCmd)

            Dim IdLibro As Integer? = Nothing

            If lector.Read() Then
                IdLibro = Convert.ToInt32(lector("Id_Libro"))
            End If

            lector.Close()

            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "
                    DELETE FROM Prestamos WHERE ID = @Id"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add("@Id", DbType.Int32).Value = id
            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

            Dim ActualizarLibroCmd As New SQLiteCommand
            Dim consultaUpdate As String = "UPDATE Libros SET Disponible = 1 WHERE ID = @IdLibro"
            ActualizarLibroCmd.CommandText = consultaUpdate
            ActualizarLibroCmd.Parameters.Add("@IdLibro", DbType.Int32).Value = IdLibro

            SQLLite.Ejecuta(My.Settings.conexion, ActualizarLibroCmd)

        Catch ex As Exception
            Throw New Exception("Error al borrar el préstamo: " & ex.Message)
        End Try
    End Sub
End Class
