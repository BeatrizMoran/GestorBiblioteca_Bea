Imports GestionBiblioteca.DTOs

Public Class InformacionUsuarioForm

    Public tipoPagina As String
    Dim mostrado As Boolean = False
    Public datosUsuario As UsuarioDTO
    Public datosLibro As LibroDTO

    Private Sub InformacionUsuarioForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True

        Select Case tipoPagina
            Case "usuario"
                tlpUsuario.Visible = True
                tlpLibro.Visible = False
                tlpPrestamo.Visible = False

                pbImagen.Image = Image.FromFile("images\usuarioInfo.png")
                InicializarDatosUsuarios()

            Case "libro"
                tlpLibro.Visible = True
                tlpUsuario.Visible = False
                tlpPrestamo.Visible = False

                pbImagen.Image = Image.FromFile("images\libroInfo.png")
                InicializarDatosLibros()

            Case "prestamo"
                tlpPrestamo.Visible = True
                tlpLibro.Visible = False
                tlpUsuario.Visible = False
                InicializarDatosPrestamo()

                pbImagen.Image = Image.FromFile("images\prestamoInfo.png")
        End Select

    End Sub

    Private Sub InicializarDatosUsuarios()
        Dim nombreCompleto = datosUsuario.Nombre + " " + datosUsuario.Apellido1 + " " + datosUsuario.Apellido2
        lTitulo.Text = "Nombre: "
        lTitulo2.Text = nombreCompleto
        lId.Text = datosUsuario.Id
        lTelefono.Text = datosUsuario.Telefono
    End Sub

    Private Sub InicializarDatosLibros()
        ' Configuración de etiquetas y texto
        gbDatos.Text = "Datos del Libro"
        lTitulo.Text = "Titulo: "
        lTitulo2.Text = datosLibro.Titulo
        lId.Text = datosLibro.Id.ToString()
        lEscritor.Text = datosLibro.Escritor
        lAnyoPublicacion.Text = datosLibro.AnyoEdicion
        rtbSinopsis.Text = datosLibro.Sinopsis

    End Sub


    Private Sub InicializarDatosPrestamo()
        gbDatos.Text = "Datos del Prestamo"
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs)
        CType(Me.MdiParent, Form1).VolverAtras()
    End Sub

    Private Sub InformacionUsuarioForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then

            Const MAX_FONTSIZE As Integer = 13

            ' Calcular el tamaño proporcional de la fuente basado en ancho y alto
            Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width
            Dim proporciónAlto As Double = Me.Height / Me.MinimumSize.Height
            Dim proporciónPromedio As Double = (proporciónAncho + proporciónAlto) / 2
            ' Determinar el tamaño de la fuente dentro de los límites
            Dim fontSize As Integer = Math.Min(proporciónPromedio * 8, MAX_FONTSIZE)


            For Each control In tlpPrincipal.Controls
                control.Font = New Font("Microsoft Sans Serif", fontSize)
            Next
        End If
    End Sub

    Private Sub InformacionUsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bSalir.BackColor = Color.LightGray
        bBorrar.BackColor = Color.FromArgb(212, 132, 131)
        bBorrar.ForeColor = Color.White
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        Try
            Select Case tipoPagina
                Case "usuario"

                    UsuariosForm.BorrarUsuario(datosUsuario.Id)
                    CType(Me.MdiParent, Form1).AbrirUsuariosForm("gestion")
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al intentar borrar: " & ex.Message)
        End Try
    End Sub
End Class