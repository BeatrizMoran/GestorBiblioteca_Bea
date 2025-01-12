Public Class BlockDashboard

    Private _Titulo As String
    Private _Imagen As Image
    Private _ColorFondoImagen As Color
    Private _BorderColor As Color = Color.FromArgb(155, 68, 243)
    Private _BorderWidth As Integer = 2
    Private _BackColorHover As Color = Color.FromArgb(60, 187, 219)
    Private _BackColorNormal As Color = Color.White


    Public Property Titulo As String
        Get
            Return lTitulo.Text
        End Get
        Set(value As String)
            lTitulo.Text = value
        End Set
    End Property

    Public Property Imagen As Image
        Get
            Return pbImagen.Image
        End Get
        Set(value As Image)
            pbImagen.Image = value
        End Set
    End Property

    Public Property ColorFondoImagen As Color
        Get
            Return pbImagen.BackColor
        End Get
        Set(value As Color)
            pbImagen.BackColor = value
        End Set
    End Property

    ' Propiedad para configurar el color del borde
    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            _BorderColor = value
            Me.Invalidate() ' Redibujar el control al cambiar el color del borde
        End Set
    End Property

    Public Property BorderWidth As Integer
        Get
            Return _BorderWidth
        End Get
        Set(value As Integer)
            _BorderWidth = value
            Me.Invalidate()
        End Set
    End Property

    ' Constructor
    Public Sub New()
        InitializeComponent()
        ' Configuración inicial
        Me.Padding = New Padding(10)
        Me.Margin = New Padding(10)


    End Sub

    ' Evento OnPaint para dibujar el borde personalizado
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Calcular el área del borde
        Dim rect As New Rectangle(_BorderWidth \ 2, _BorderWidth \ 2, Me.ClientSize.Width - _BorderWidth, Me.ClientSize.Height - _BorderWidth)

        ' Dibujar el borde con suavizado
        Using pen As New Pen(_BorderColor, _BorderWidth)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Public Event ClickarBlock()





    Private Sub BlockDashboard_Click(sender As Object, e As EventArgs) Handles MyBase.Click, lTitulo.Click, pbImagen.Click
        RaiseEvent ClickarBlock()
    End Sub

    Private Sub BlockDashboard_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, lTitulo.MouseEnter, pbImagen.MouseEnter
        Me.BackColor = _BackColorHover
        lTitulo.BackColor = _BackColorHover

    End Sub

    Private Sub BlockDashboard_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = _BackColorNormal
        lTitulo.BackColor = _BackColorNormal

    End Sub
End Class
