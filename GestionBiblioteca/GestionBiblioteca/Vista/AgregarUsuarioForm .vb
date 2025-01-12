Public Class AgregarUsuarioForm

    Dim controlador As New UsuarioController
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Hide()
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Try
            controlador.CrearUsuario(liNombre.InputText, liApellido1.InputText, liApellido2.InputText, liTelefono.InputText)
            MessageBox.Show("Usuario creado correctamente", "Usuario Crado", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Form1.AbrirUsuariosForm("gestion")


            ' Cerramos el formulario actual (AgregarUsuarioForm)
            Me.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class