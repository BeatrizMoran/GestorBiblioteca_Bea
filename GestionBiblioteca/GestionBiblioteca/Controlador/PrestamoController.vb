Public Class PrestamoController



    Public Function BuscarPrestamo(id As Integer) As PrestamoDTO
        Try
            Dim datosPrestamo As PrestamoDTO = Prestamo.BuscarPrestamo(id)

            Return datosPrestamo
        Catch ex As Exception
            Throw New Exception("Error al intentar buscar el prestamo: " & ex.Message)

        End Try

    End Function

    Public Sub CrearPrestamo(idLibro As Integer, idUsuario As Integer, fechaInicio As Date, fechaFIn As Date, disponible As Boolean)
        Try
            Dim prestamo As Prestamo = New Prestamo(idLibro, idUsuario, fechaInicio, fechaFIn, disponible)
            prestamo.CrearPrestamo()
        Catch ex As Exception
            Throw New Exception("Error al intentar crear el prestamo: " & ex.Message)
        End Try

    End Sub

    Public Sub ActualizarPrestamo(idPrestamo As Integer, idLibro As Integer, idUsuario As Integer, fechaInicio As Date, fechaFIn As Date, disponible As Boolean)
        Try
            Dim prestamo As Prestamo = New Prestamo(idLibro, idUsuario, fechaInicio, fechaFIn, disponible)
            prestamo.Id = idPrestamo
            prestamo.ActualizarPrestamo()
        Catch ex As Exception
            Throw New Exception("Error al intentar actualizar el prestamo: " & ex.Message)

        End Try

    End Sub
    Public Function FiltrarPrestamos(filtrarActivos As Boolean, filtrarDisponibles As Boolean) As List(Of PrestamoDTO)
        Return Prestamo.FiltrarPrestamos(filtrarActivos, filtrarDisponibles)
    End Function

End Class
