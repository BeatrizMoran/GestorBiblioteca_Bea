Imports DTOs
Imports GestionBiblioteca.DTOs

Public Class LibroController
    Public Function ObtenerLibros() As List(Of LibroDTO)
        Try
            Dim librosModelo = Libro.ObtenerLibros() ' Modelo devuelve un Dictionary(Of Integer, Libro)
            Dim librosDTO As New List(Of LibroDTO)

            ' Convertir cada libro del modelo en un DTO
            For Each libro In librosModelo.Values
                librosDTO.Add(New LibroDTO With {
                    .Id = libro.id,
                    .Titulo = libro.titulo,
                    .Escritor = libro.escritor,
                    .AnyoEdicion = libro.anyoEdicion,
                    .Sinopsis = libro.sinopsis
                })
            Next

            Return librosDTO
        Catch ex As Exception
            Throw New Exception("Error al obtener libros: " & ex.Message)
        End Try
    End Function

    Public Sub BorrarLibro(id As Integer)
        Try
            Libro.BorrarLibro(id)
        Catch ex As Exception
            Throw New Exception("Error al borrar libros: " & ex.Message)

        End Try
    End Sub

    Public Function BuscarLibro(id As Integer)
        Try
            Dim libroDto As LibroDTO = Libro.BuscarLibro(id)



            Return libroDto
        Catch ex As Exception
            Throw New Exception("Error al buscar el libro: " & ex.Message)

        End Try

    End Function
End Class
