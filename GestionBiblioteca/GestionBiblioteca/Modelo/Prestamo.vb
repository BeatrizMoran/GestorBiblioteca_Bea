Imports System.Data.SQLite

Public Class Prestamo
    Property Id As Integer
    Property IdLibro As Integer
    Property IdUsuario As Integer
    Property FechaInicio As Date
    Property FechaFin As Date
    Property Disponible As Boolean

    Public Shared Function ObtenerPrestamos() As List(Of PrestamoDTO)
        Try
            Dim prestamos As New List(Of PrestamoDTO)
            Dim consulta As String = " SELECT 
                                        p.ID,
                                        p.Fecha_Inicio,
                                        p.Fecha_Fin,
                                        p.Disponible AS Estado,
                                        l.Titulo AS TituloLibro,
                                        CONCAT(u.Nombre, ' ', u.Apellido_1) AS NombreUsuario
                                    FROM 
                                        Prestamos p
                                    JOIN 
                                        Libros l ON p.ID_Libro = l.ID
                                    JOIN 
                                        Usuarios u ON p.ID_Usuario = u.ID"

            Dim Cmd As New SQLiteCommand
            Cmd.CommandText = consulta
            Dim datos As DataTable = SQLLite.GetDataTable(My.Settings.conexion, Cmd)

            ' Recorrer las filas del DataTable
            For Each fila As DataRow In datos.Rows
                ' Crear un objeto PrestamoDTO y asignar los valores desde la fila
                Dim prestamo As New PrestamoDTO With {
                .Id = Convert.ToInt32(fila("ID")),
                .LibroTitulo = fila("TituloLibro").ToString(),
                .UsuarioNombre = fila("NombreUsuario").ToString(),
                .FechaInicio = DateTime.Parse(fila("Fecha_Inicio").ToString()),
                .FechaFin = DateTime.Parse(fila("Fecha_Fin").ToString()),
                .Estado = Convert.ToBoolean(fila("Estado"))
                 }

                ' Agregar el préstamo a la lista
                prestamos.Add(prestamo)
            Next

            Return prestamos

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw New Exception("Error al oobtener los prestamos: " & ex.Message)
        End Try
    End Function

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

End Class
