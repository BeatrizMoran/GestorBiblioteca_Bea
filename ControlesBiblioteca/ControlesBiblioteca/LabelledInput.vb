Public Class LabelledInput
    Private _Titulo As String = "Título"
    Private _Placeholder As String = "Escribe aquí"
    Private _TituloColor As Color = Color.Black
    Private _TextboxBackColor As Color = Color.White
    Private _TextboxForeColor As Color = Color.Black


    ' Propiedad pública para el título
    Public Property Titulo As String
        Get
            Return lTitulo.Text
        End Get
        Set(value As String)
            _Titulo = value
            lTitulo.Text = value
        End Set
    End Property

    ' Propiedad pública para cambiar el color del texto del título
    Public Property TituloColor As Color
        Get
            Return _TituloColor
        End Get
        Set(value As Color)
            _TituloColor = value
            lTitulo.ForeColor = value
        End Set
    End Property

    ' Propiedad pública para el placeholder
    Public Property Placeholder As String
        Get
            Return _Placeholder
        End Get
        Set(value As String)
            _Placeholder = value
            UpdatePlaceholder()
        End Set
    End Property

    ' Propiedad pública para cambiar el color de fondo del TextBox
    Public Property TextboxBackColor As Color
        Get
            Return _TextboxBackColor
        End Get
        Set(value As Color)
            _TextboxBackColor = value
            tbCampo.BackColor = value
        End Set
    End Property

    ' Constructor
    Public Sub New()
        InitializeComponent()
        UpdatePlaceholder()

        ' Configurar eventos para manejar el placeholder
        AddHandler tbCampo.GotFocus, AddressOf RemovePlaceholder
        AddHandler tbCampo.LostFocus, AddressOf RestorePlaceholder
    End Sub

    ' Actualizar el placeholder
    Private Sub UpdatePlaceholder()
        If String.IsNullOrEmpty(tbCampo.Text) Then
            tbCampo.Text = _Placeholder
            tbCampo.ForeColor = Color.Gray
        End If
    End Sub

    ' Eliminar el placeholder cuando el control obtiene el foco
    Private Sub RemovePlaceholder(sender As Object, e As EventArgs)
        If tbCampo.Text = _Placeholder Then
            tbCampo.Text = ""
            tbCampo.ForeColor = Color.Black
        End If
    End Sub

    ' Restaurar el placeholder si el TextBox está vacío al perder el foco
    Private Sub RestorePlaceholder(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(tbCampo.Text) Then
            tbCampo.Text = _Placeholder
            tbCampo.ForeColor = Color.Gray
        End If
    End Sub

    Public Property TextboxForeColor As Color
        Get
            Return _TextboxForeColor
        End Get
        Set(value As Color)
            _TextboxForeColor = value
            tbCampo.ForeColor = value
        End Set
    End Property
End Class
