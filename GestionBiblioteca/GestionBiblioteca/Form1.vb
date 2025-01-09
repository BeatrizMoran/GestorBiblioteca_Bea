Public Class Form1

    Public dashboard As New DashboardForm

    Dim mostrado As Boolean = False
    Const FONTSIZE As Double = 8
    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dashboard.MdiParent = Me
        dashboard.Dock = DockStyle.Fill
        dashboard.Show()

        TableLayoutPanel1.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado
        msNavbar.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado
        bTituloLogo.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

        msNavbar.Items(0).Font = New Font("Arial", 10, FontStyle.Bold) ' Cambiar el tamaño y estilo según desees

        ' Si deseas cambiar el tamaño de la letra de todos los elementos del MenuStrip
        For Each item As ToolStripMenuItem In msNavbar.Items
            item.Font = New Font("Arial", 10, FontStyle.Bold) ' Cambiar el tamaño y estilo para todos
        Next


        AjustarMenuItems()


    End Sub

    Private Sub AjustarMenuItems()
        ' Obtener la cantidad de elementos en el MenuStrip
        Dim itemCount As Integer = msNavbar.Items.Count

        ' Calcular la altura disponible y asignar tamaño a cada elemento
        Dim availableHeight As Integer = Me.ClientSize.Height
        Dim itemHeight As Integer = availableHeight \ itemCount ' Dividir espacio entre los elementos

        For Each item As ToolStripMenuItem In msNavbar.Items
            item.AutoSize = False ' Desactivar el tamaño automático
            item.Size = New Size(msNavbar.Width, itemHeight) ' Ajustar tamaño personalizado
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles bTituloLogo.Click
        ' Código adicional si es necesario
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            AjustarFuenteYImagenes()
        End If
    End Sub

    Private Sub AjustarFuenteYImagenes()
        ' Calculamos la proporción del ancho del formulario en relación con su tamaño mínimo
        Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width

        ' Iteramos sobre los controles dentro del contenedor de botones (en este caso, tlpPrincipal)
        For Each control In dashboard.tlpPrincipal.Controls
            control.Font = New Font("Microsoft Sans Serif", proporciónAncho * FONTSIZE)

            If TypeOf control Is Button Then
                Dim boton As Button = DirectCast(control, Button)

                ' Ajustamos el tamaño de la fuente del botón proporcionalmente al tamaño de Form1
                boton.Font = New Font("Microsoft Sans Serif", proporciónAncho * FONTSIZE)

                ' Si el botón tiene una imagen, la ajustamos también
                If boton.Image IsNot Nothing Then
                    ' Redimensionamos la imagen manteniendo la relación de aspecto con una interpolación de alta calidad
                    boton.Image = RedimensionarImagenAltaCalidad(boton.Image, boton.Width, boton.Height)
                End If
            End If
        Next
    End Sub

    ' Función que redimensiona la imagen manteniendo la relación de aspecto con alta calidad
    Private Function RedimensionarImagenAltaCalidad(imagenOriginal As Image, nuevoAncho As Integer, nuevaAltura As Integer) As Image
        ' Calculamos la relación de aspecto de la imagen original
        Dim ratio As Double = imagenOriginal.Width / imagenOriginal.Height

        ' Calculamos el ancho y alto proporcionalmente, manteniendo la relación de aspecto
        Dim anchoRedimensionado As Integer
        Dim alturaRedimensionada As Integer

        ' Comprobamos si el ancho redimensionado o la altura es el que limita la imagen
        If nuevoAncho / nuevaAltura > ratio Then
            ' Si el nuevo ancho es más grande en relación a la altura, ajustamos la altura
            alturaRedimensionada = nuevaAltura
            anchoRedimensionado = CInt(alturaRedimensionada * ratio)
        Else
            ' Si el nuevo alto es más grande en relación al ancho, ajustamos el ancho
            anchoRedimensionado = nuevoAncho
            alturaRedimensionada = CInt(anchoRedimensionado / ratio)
        End If

        ' Creamos un nuevo Bitmap con las nuevas dimensiones
        Dim imagenRedimensionada As New Bitmap(anchoRedimensionado, alturaRedimensionada)

        ' Usamos un objeto Graphics para dibujar la imagen con una interpolación de alta calidad
        Using g As Graphics = Graphics.FromImage(imagenRedimensionada)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(imagenOriginal, 0, 0, anchoRedimensionado, alturaRedimensionada)
        End Using

        Return imagenRedimensionada
    End Function



End Class
