Public Class PrestamoController

    Public Function ObtenerPrestamos() As List(Of PrestamoDTO)
        Try
            Dim prestamos As List(Of PrestamoDTO) = Prestamo.ObtenerPrestamos()

            Return prestamos
        Catch ex As Exception
            Throw New Exception("Error al intentar obtener los prestamos: " & ex.Message)
        End Try
    End Function

    Public Function BuscarPrestamo(id As Integer) As PrestamoDTO
        Try
            Dim datosPrestamo As PrestamoDTO = Prestamo.BuscarPrestamo(id)

            Return datosPrestamo
        Catch ex As Exception
            Throw New Exception("Error al intentar buscar el prestamo: " & ex.Message)

        End Try

    End Function

    Public Sub ActualizarPrestamo(id As Integer)
        Try
            '  Prestamo.ActualizarPrestamo()
        Catch ex As Exception
            Throw New Exception("Error al intentar actualizar el prestamo: " & ex.Message)

        End Try

    End Sub
End Class
