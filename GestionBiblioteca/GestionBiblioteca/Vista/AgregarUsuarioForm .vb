Imports ControlesBiblioteca

Public Class AgregarUsuarioForm

    Dim mostrado = False
    Dim controlador As New UsuarioController
    Public opcion As String
    Public usuarioId As String

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Hide()
        CType(Me.MdiParent, Form1).VolverAtras()
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Try
            ValidarDatos()

            If opcion = "crear" Then
                controlador.CrearUsuario(liNombre.InputText, liApellido1.InputText, liApellido2.InputText, liTelefono.InputText)
                MessageBox.Show("Usuario creado correctamente", "Usuario Crado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                controlador.ActualizarUsuario(usuarioId, liNombre.InputText, liApellido1.InputText, liApellido2.InputText, liTelefono.InputText)
                MessageBox.Show("Usuario actualizado correctamente", "Usuario Crado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If





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
                CambiarColorError(campo)

                errores &= "El campo: " & campo.Titulo & " es obligatorio" & vbCrLf
            End If

            If campo.Titulo = "Telefono" Then
                If Not campo.InputText.All(AddressOf Char.IsDigit) Then
                    CambiarColorError(campo)

                    errores &= "El campo: " & campo.Titulo & " no tiene un formato adecuado" & vbCrLf
                ElseIf campo.InputText.Count > 9 OrElse campo.InputText.Count < 9 Then
                    errores &= "El campo: " & campo.Titulo & " tiene que tener 9 digitos" & vbCrLf
                    CambiarColorError(campo)
                End If
            Else
                If campo.InputText.Any(AddressOf Char.IsDigit) Then
                    CambiarColorError(campo)

                    errores &= "El campo: " & campo.Titulo & " no puede contener números" & vbCrLf
                End If

                If String.IsNullOrEmpty(campo.InputText) Then
                    CambiarColorError(campo)
                    errores &= "El campo: " & campo.Titulo & " es obligatorio" & vbCrLf
                End If
            End If
        Next


        If Not String.IsNullOrEmpty(errores) Then
            Throw New Exception(errores)
        End If
    End Sub


    Private Sub CambiarColorError(campo As LabelledInput)
        campo.TituloColor = Color.Red
        campo.TextboxBackColor = Color.Red
        campo.TextboxForeColor = Color.White
    End Sub


    Private Sub AgregarUsuarioForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CType(Me.MdiParent, Form1).OcultarMostrarBotonVolver()

        mostrado = True
        If opcion = "editar" Then
            gbCrearUsuario.Text = "Editar Usuario"
            Dim usuario As New UsuarioDTO
            usuario = controlador.BuscarUsuario(usuarioId)

            liNombre.InputText = usuario.nombre
            liApellido1.InputText = usuario.apellido1
            liApellido2.InputText = usuario.apellido2
            liTelefono.InputText = usuario.telefono
        End If

    End Sub



    Private Sub tlpFormulario_Paint(sender As Object, e As PaintEventArgs) Handles tlpPrincipal.Paint
        bAceptar.BackColor = Color.FromArgb(0, 123, 255)
        bAceptar.ForeColor = Color.White

        bCancelar.BackColor = Color.LightGray


    End Sub

    Private Sub AgregarUsuarioForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            Const MAX_FONTSIZE As Integer = 13

            Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width
            Dim fontSize As Integer = Math.Min(proporciónAncho * 8, MAX_FONTSIZE)


            For Each control In tlpPrincipal.Controls

                control.Font = New Font("Microsoft Sans Serif", fontSize)
            Next


        End If
    End Sub


End Class