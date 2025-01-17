Public Class PrestamoController

    Public Function ObtenerPrestamos() As List(Of PrestamoDTO)
        Try
            Dim prestamos As List(Of PrestamoDTO) = Prestamo.ObtenerPrestamos()

            Return prestamos
        Catch ex As Exception
            Throw New Exception("Error al intentar obtener los prestamos: " & ex.Message)
        End Try
    End Function
End Class
