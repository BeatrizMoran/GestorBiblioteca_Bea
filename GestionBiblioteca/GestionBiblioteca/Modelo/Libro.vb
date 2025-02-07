Imports System.Data.SQLite
Imports GestionBiblioteca.DTOs

Public Class Libro


    Property id As Integer
    Property titulo As String
    Property escritor As String

    Property anyoEdicion As Integer

    Property sinopsis As String

    Property disponible As Boolean

    Public Sub New()
    End Sub

    Public Sub New(titulo As String, escritor As String, anyoEdicion As Integer, sinopsis As String)
        Me.titulo = titulo
        Me.escritor = escritor
        Me.anyoEdicion = anyoEdicion
        Me.sinopsis = sinopsis
    End Sub

    Public Shared Function ObtenerLibros() As Dictionary(Of Integer, Libro)
        ' Crear el diccionario para almacenar los libros
        Dim libros As New Dictionary(Of Integer, Libro)

        Try
            Dim Sql As String = "SELECT * FROM Libros ORDER BY id DESC"

            Dim Cmd As New SQLiteCommand(Sql)


            Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)
            While lector.Read()
                Dim libro As New Libro With {
                            .id = lector.GetInt32(0),
                            .titulo = lector.GetString(1),
                            .escritor = lector.GetString(2),
                            .anyoEdicion = lector.GetInt32(3),
                            .sinopsis = lector.GetString(4),
                            .disponible = lector.GetBoolean(5)
                        }
                        libros.Add(libro.id, libro)
                    End While

            lector.Close()
        Catch ex As Exception
            Throw New Exception("Error al obtener los libros: " & ex.Message)
        End Try

        Return libros
    End Function

    Public Shared Sub BorrarLibro(id As Integer)
        Try

            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "DELETE FROM Libros WHERE (Id=@Id)"
            Cmd.CommandText = Sql
            Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id
            SQLLite.Ejecuta(My.Settings.conexion, Cmd)


        Catch ex As Exception
            Throw New Exception("Error al borrar el libro: " & ex.Message)
        End Try
    End Sub

    Public Shared Function BuscarLibro(id As Integer) As LibroDTO
        Try
            Dim libroDTO As New LibroDTO()

            Dim consulta As String = "SELECT * FROM Libros WHERE Id = @id"
            Dim cmd As New SQLiteCommand(consulta)

            cmd.Parameters.Add("@id", DbType.Int32).Value = id

            Dim lector = SQLLite.GetDataReader(My.Settings.conexion, cmd)
            If lector.Read() Then
                        ' Asignar valores al objeto libroDTO
                        libroDTO.Id = Convert.ToInt32(lector("Id"))
                        libroDTO.Titulo = lector("Titulo").ToString()
                        libroDTO.Escritor = lector("Escritor").ToString()
                        libroDTO.AnyoEdicion = Convert.ToInt32(lector("Ano_Edicion"))
                        libroDTO.Sinopsis = lector("Sinopsis").ToString()
                    Else
                        Throw New Exception("No se encontró un libro con el ID especificado.")
                    End If

            lector.Close()

            Return libroDTO
        Catch ex As SQLiteException
            Throw New Exception("Error en la consulta SQL: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error al buscar libro: " & ex.Message)
        End Try
    End Function

    Public Shared Sub CrearLibro(libro As Libro)
        Try
            Dim Cmd As New SQLiteCommand
            Dim consulta As String = "INSERT INTO Libros (Titulo, Escritor, Ano_Edicion, Sinopsis) VALUES (@Titulo, @Escritor, @AnyoEdicion, @Sinopsis)"
            Cmd.CommandText = consulta
            Cmd.Parameters.Add("@Titulo", DbType.String).Value = libro.titulo
            Cmd.Parameters.Add("@Escritor", DbType.String).Value = libro.escritor
            Cmd.Parameters.Add("@AnyoEdicion", DbType.Int32).Value = libro.anyoEdicion
            Cmd.Parameters.Add("@Sinopsis", DbType.String).Value = libro.sinopsis

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        Catch ex As Exception
            Throw New Exception("Error al insertar el libro: " & ex.Message)
        End Try
    End Sub
    Public Shared Sub ActualizarLibro(libro As Libro)
        Try
            Dim Cmd As New SQLiteCommand
            Dim consulta As String = "UPDATE Libros SET Titulo = @Titulo, Escritor = @Escritor, Ano_Edicion = @AnyoEdicion, Sinopsis = @Sinopsis WHERE Id=@Id"
            Cmd.CommandText = consulta
            Console.WriteLine(libro.titulo)
            Cmd.Parameters.Add("@Titulo", DbType.String).Value = libro.titulo
            Cmd.Parameters.Add("@Escritor", DbType.String).Value = libro.escritor
            Cmd.Parameters.Add("@AnyoEdicion", DbType.Int32).Value = libro.anyoEdicion
            Cmd.Parameters.Add("@Sinopsis", DbType.String).Value = libro.sinopsis
            Cmd.Parameters.Add("@Id", DbType.Int32).Value = libro.id

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        Catch ex As Exception
            Throw New Exception("Error al actualizar el libro: " & ex.Message)
        End Try
    End Sub

    Public Shared Sub ActualizarEstadoLibro(id As Integer, estado As Boolean)
        Try
            Dim Cmd As New SQLiteCommand
            Dim consulta As String = "UPDATE Libros SET Disponible = @Estado WHERE Id=@Id"
            Cmd.CommandText = consulta

            Cmd.Parameters.Add("@Estado", DbType.Int32).Value = If(estado, 1, 0)
            Cmd.Parameters.Add("@Id", DbType.Int32).Value = id

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        Catch ex As Exception
            Throw New Exception("Error al actualizar el estado: " & ex.Message)
        End Try
    End Sub
    Public Shared Function ContarPrestamosAsociados(id As Integer) As Integer
        Try
            Dim cantidadPrestamos As Integer
            Dim Cmd As New SQLiteCommand
            Dim consulta As String = "SELECT COUNT(*) as TotalPrestamos FROM Prestamos WHERE id_libro = @id"
            Cmd.CommandText = consulta

            Cmd.Parameters.Add("@id", DbType.Int32).Value = id

            Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)
            If lector.Read() Then
                cantidadPrestamos = If(IsDBNull(lector("TotalPrestamos")), 0, Convert.ToInt32(lector("TotalPrestamos")))
            End If
            lector.Close()
            Return cantidadPrestamos

        Catch ex As Exception
            Throw New Exception("Error al contar prestamos: " & ex.Message)
        End Try
    End Function










End Class
