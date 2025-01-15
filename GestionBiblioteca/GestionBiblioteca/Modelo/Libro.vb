Imports System.Data.SQLite
Imports GestionBiblioteca.DTOs

Public Class Libro


    Property id As Integer
    Property titulo As String
    Property escritor As String

    Property anyoEdicion As Integer

    Property sinopsis As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, titulo As String, escritor As String, anyoEdicion As Integer, sinopsis As String)
        Me.id = id
        Me.titulo = titulo
        Me.escritor = escritor
        Me.anyoEdicion = anyoEdicion
        Me.sinopsis = sinopsis
    End Sub

    Public Shared Function ObtenerLibros() As Dictionary(Of Integer, Libro)
        ' Crear el diccionario para almacenar los libros
        Dim libros As New Dictionary(Of Integer, Libro)

        Try
            Dim Sql As String = "SELECT * FROM Libros"

            Dim Cmd As New SQLiteCommand(Sql)

            ' Abrir la conexión manualmente
            Using conexion As New SQLiteConnection(My.Settings.conexion)
                conexion.Open()
                Cmd.Connection = conexion

                Using lector As SQLiteDataReader = Cmd.ExecuteReader()
                    ' Leer los resultados
                    While lector.Read()
                        Dim libro As New Libro With {
                            .id = lector.GetInt32(0),
                            .titulo = lector.GetString(1),
                            .escritor = lector.GetString(2),
                            .anyoEdicion = lector.GetInt32(3),
                            .sinopsis = lector.GetString(4)
                        }
                        libros.Add(libro.id, libro)
                    End While
                End Using
            End Using

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
            Using conexion As New SQLiteConnection(My.Settings.conexion),
                  cmd As New SQLiteCommand(consulta, conexion)

                cmd.Parameters.Add("@id", DbType.Int32).Value = id

                ' Abrir la conexión
                conexion.Open()

                ' Ejecutar la consulta y leer los datos
                Using lector As SQLiteDataReader = cmd.ExecuteReader()
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
                End Using
            End Using

            Return libroDTO
        Catch ex As SQLiteException
            Throw New Exception("Error en la consulta SQL: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error al buscar libro: " & ex.Message)
        End Try
    End Function









End Class
