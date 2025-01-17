Public Class AgregarPrestamoForm

    Public opcion As String
    Public datosPrestamo As PrestamoDTO
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click

    End Sub

    Private Sub AgregarPrestamoForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If opcion = "editar" Then
            liEstado.InputText = datosPrestamo.Estado
        End If
    End Sub
End Class