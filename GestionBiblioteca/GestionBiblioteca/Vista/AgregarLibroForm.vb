Public Class AgregarLibroForm
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        CType(Me.MdiParent, Form1).VolverAtras()
    End Sub
End Class