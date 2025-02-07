Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class AgregarLibroForm
    Dim mostrado As Boolean = False
    Dim controlador As New LibroController
    Public accion As String
    Public datosLibro As LibroDTO
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        CType(Me.MdiParent, Form1).VolverAtras()
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Try
            ValidarDatos()

            If accion = "crear" Then
                controlador.CrearLibro(liTitulo.InputText, liEscritor.InputText, liAnyoEdicion.InputText, rtbSinopsis.Text)
                MessageBox.Show("Libro creado correctamente", "Libro Crado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                controlador.ActualizarLibro(datosLibro.Id, liTitulo.InputText, liEscritor.InputText, liAnyoEdicion.InputText, rtbSinopsis.Text)
                MessageBox.Show("Libro actualizado correctamente", "Libro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            Form1.AbrirLibrosForm("gestion")


            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ValidarDatos()
        Dim campos As New List(Of LabelledInput)
        Dim errores As String = ""

        For Each inputText In tlpFormulario.Controls
            If TypeOf inputText Is LabelledInput Then
                campos.Add(inputText)
            End If
        Next

        For Each campo In campos
            Dim input = campo.InputText.Trim()

            If String.IsNullOrEmpty(input) OrElse input = campo.Placeholder Then
                CambiarColorError(campo)
                errores &= $"El campo '{campo.Titulo}' es obligatorio." & vbCrLf
                Continue For ' Pasar al siguiente campo después de registrar el error
            End If

            Select Case campo.Titulo
                Case "Escritor"
                    If Not input.All(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)) Then
                        CambiarColorError(campo)
                        errores &= $"El campo '{campo.Titulo}' solo puede contener letras y espacios." & vbCrLf
                    End If

                Case "Año Edicion"
                    If Not input.All(AddressOf Char.IsDigit) Then
                        CambiarColorError(campo)
                        errores &= $"El campo '{campo.Titulo}' no puede tener valores alfanumericos." & vbCrLf
                    ElseIf input.Length <> 4 Then
                        ' Luego, verificar que tenga exactamente cuatro dígitos
                        CambiarColorError(campo)
                        errores &= $"El campo '{campo.Titulo}' no tiene un formato adecuado (ejemplo: 2011)." & vbCrLf
                    ElseIf Convert.ToInt32(input) < 1450 OrElse Convert.ToInt32(input) > DateTime.Now.Year Then
                        CambiarColorError(campo)
                        errores &= $"El campo '{campo.Titulo}' debe estar entre 1450 y {DateTime.Now.Year}." & vbCrLf
                    End If
            End Select
        Next

        If String.IsNullOrWhiteSpace(rtbSinopsis.Text) Then
            errores &= "El campo 'Sinopsis' es obligatorio." & vbCrLf
        End If

        If Not String.IsNullOrEmpty(errores) Then
            Throw New Exception(errores)
        End If
    End Sub


    Private Sub CambiarColorError(campo As LabelledInput)
        campo.TituloColor = Color.Red
        campo.TextboxBackColor = Color.Red
        campo.TextboxForeColor = Color.White
    End Sub



    Private Sub AgregarLibroForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
        If accion = "editar" Then
            gbCrearEditarLibro.Text = "Editar Libro"
            liTitulo.InputText = datosLibro.Titulo
            liEscritor.InputText = datosLibro.Escritor
            liAnyoEdicion.InputText = datosLibro.AnyoEdicion
            rtbSinopsis.Text = datosLibro.Sinopsis
        End If
    End Sub

    Private Sub AgregarLibroForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            ModuloUtilidades.AjustarFuente(formulario:=Me, tamanoMaximoLetra:=13, tlPanel:=tlpPrincipal)
        End If
    End Sub
End Class