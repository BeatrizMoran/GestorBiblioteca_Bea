Imports ControlesBiblioteca

Public Class AgregarUsuarioForm

    Dim controlador As New UsuarioController
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Hide()
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Try
            ValidarDatos()

            controlador.CrearUsuario(liNombre.InputText, liApellido1.InputText, liApellido2.InputText, liTelefono.InputText)
            MessageBox.Show("Usuario creado correctamente", "Usuario Crado", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Form1.AbrirUsuariosForm("gestion")


            ' Cerramos el formulario actual (AgregarUsuarioForm)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ValidarDatos()
        Dim campos As List(Of LabelledInput) = New List(Of LabelledInput)
        Dim errores As String = ""

        For Each inputText In tlpFormulario.Controls
            If TypeOf inputText Is LabelledInput Then
                campos.Add(inputText)
            End If
        Next

        For Each campo In campos
            If campo.InputText = campo.Placeholder Then
                campo.TituloColor = Color.Red
                campo.TextboxBackColor = Color.Red
                errores &= "El campo: " & campo.Titulo & " es obligatorio" & vbCrLf
            End If

            If campo.Titulo = "Telefono" Then
                If Not campo.InputText.All(AddressOf Char.IsDigit) Then
                    campo.TituloColor = Color.Red
                    campo.TextboxBackColor = Color.Red
                    errores &= "El campo: " & campo.Titulo & " no tiene un formato adecuado" & vbCrLf
                End If
            Else
                If campo.InputText.Any(AddressOf Char.IsDigit) Then
                    campo.TituloColor = Color.Red
                    campo.TextboxBackColor = Color.Red
                    errores &= "El campo: " & campo.Titulo & " no puede contener números" & vbCrLf
                End If

                If String.IsNullOrEmpty(campo.InputText) Then
                    campo.TituloColor = Color.Red
                    campo.TextboxBackColor = Color.Red
                    errores &= "El campo: " & campo.Titulo & " es obligatorio" & vbCrLf
                End If
            End If
        Next


        If Not String.IsNullOrEmpty(errores) Then
            Throw New Exception(errores)
        End If
    End Sub


    Private Sub liNombre_Load(sender As Object, e As EventArgs)

    End Sub
End Class