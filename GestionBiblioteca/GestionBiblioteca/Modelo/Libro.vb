Imports System.Data.SQLite

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







End Class
