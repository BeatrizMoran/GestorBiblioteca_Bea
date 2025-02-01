Imports GestionBiblioteca.DTOs

Public Class InformacionUsuarioForm

    Public tipoPagina As String
    Dim mostrado As Boolean = False
    Public datosUsuario As UsuarioDTO
    Public datosLibro As LibroDTO
    Public datosPrestamo As PrestamoDTO
    Dim controladorUsuario As New UsuarioController

    Private Sub InformacionUsuarioForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        rtbSinopsis.Height = 100
        mostrado = True

        Select Case tipoPagina
            Case "usuario"
                tlpUsuario.Visible = True
                tlpLibro.Visible = False
                tlpPrestamo.Visible = False

                pbImagen.Image = Image.FromFile("images\usuarioInfo.png")
                tlpInformacion.RowStyles(5).SizeType = SizeType.AutoSize

                InicializarDatosUsuarios()
                'restaurar fila prestamos'
                RestaurarAlturaFila(5)
                'restaurar fila libros'
                RestaurarAlturaFila(4)

                AjustarFila(3, 150)


            Case "libro"
                tlpLibro.Visible = True
                tlpUsuario.Visible = False
                tlpPrestamo.Visible = False

                pbImagen.Image = Image.FromFile("images\libroInfo.png")

                InicializarDatosLibros()
                'restaurar fila prestamos'
                RestaurarAlturaFila(5)
                'restaurar fila usuarioa'

                RestaurarAlturaFila(3)


                AjustarFila(4, 200)


            Case "prestamo"
                tlpPrestamo.Visible = True
                tlpLibro.Visible = False
                tlpUsuario.Visible = False
                InicializarDatosPrestamo()

                'fila 6 indice 5
                AjustarFila(5, 200)
                'restaurar fila libros'
                RestaurarAlturaFila(4)
                'restaurar fila usuarioa'

                RestaurarAlturaFila(3)


                pbImagen.Image = Image.FromFile("images\prestamoInfo.png")
        End Select

    End Sub
    Private Sub AjustarFila(indexFila As Integer, altura As Integer)
        tlpInformacion.RowStyles(indexFila).Height = altura
        tlpInformacion.RowStyles(indexFila).SizeType = SizeType.Absolute
    End Sub

    Private Sub RestaurarAlturaFila(indexFila)
        tlpInformacion.RowStyles(indexFila).SizeType = SizeType.AutoSize
    End Sub


    Private Sub InicializarDatosUsuarios()
        'obtener numero prestamos y ultimo prestamo:
        Dim datos As Dictionary(Of String, Object) = controladorUsuario.ObtenerInformacionPrestamo(datosUsuario.Id)

        gbDatos.Text = "Datos del Usuario"

        Dim nombreCompleto = datosUsuario.Nombre + " " + datosUsuario.Apellido1 + " " + datosUsuario.Apellido2
        lTitulo.Text = "Nombre: "
        lTitulo2.Text = nombreCompleto
        lId.Text = datosUsuario.Id
        lTelefono.Text = datosUsuario.Telefono
        lNumeroTotalPrestamos.Text = datos("TotalPrestamos").ToString()
        lUltimoLibroPrestamo.Text = datos("UltimoLibroPrestado").ToString()

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
        'estado prestamo:
        Dim estado = ""
        If datosPrestamo.Estado Then
            estado = "Devuelto"
        ElseIf datosPrestamo.Estado = False AndAlso datosPrestamo.FechaFin < DateTime.Now Then
            estado = "Vencido"
        Else
            estado = "En prestamo"
        End If
        gbDatos.Text = "Datos del Prestamo"
        lTitulo.Text = "Prestamo"
        lTitulo2.Text = ""
        lId.Text = datosPrestamo.Id
        lTituloLibro.Text = datosPrestamo.LibroTitulo
        lNombreUsuario.Text = datosPrestamo.UsuarioNombre
        lFechaInicio.Text = datosPrestamo.FechaInicio
        lFechaFin.Text = datosPrestamo.FechaFin
        lEstadoPrestamo.Text = estado

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
        rtbSinopsis.Height = 100

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

                Case "libro"
                    GestionLibroForm.LibroControl_ClickBorrar(datosLibro.Id)
                    CType(Me.MdiParent, Form1).AbrirLibrosForm("gestion")
                Case "prestamo"
                    GestionPrestamoForm.BorrarPrestamo(datosPrestamo.Id)
                    CType(Me.MdiParent, Form1).AbrirPaginaPrestamos("gestion")


            End Select
            Dim formHistory = CType(Me.MdiParent, Form1).formHistory

            ' Verifica si el Stack tiene elementos
            If formHistory.Count > 0 Then
                ' Crea un stack temporal para reordenar los formularios
                Dim tempStack As New Stack(Of Form)

                ' Desapila hasta encontrar la página actual
                While formHistory.Count > 0
                    Dim topForm As Form = formHistory.Pop()

                    ' Si no es la página actual, guárdalo en el stack temporal
                    If topForm IsNot Me Then
                        tempStack.Push(topForm)
                    Else
                        ' Si es la página actual, la omitimos (es decir, no la volvemos a apilar)
                        Exit While
                    End If
                End While

                ' Vuelve a apilar los formularios desde el stack temporal al original
                While tempStack.Count > 0
                    formHistory.Push(tempStack.Pop())
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar borrar: " & ex.Message)
        End Try
    End Sub

    Private Sub bSalir_Click_1(sender As Object, e As EventArgs) Handles bSalir.Click
        CType(Me.MdiParent, Form1).VolverAtras()
    End Sub


End Class