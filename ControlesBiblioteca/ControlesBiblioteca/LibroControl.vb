Public Class LibroControl
    Private _titulo As String
    Private _escritor As String
    Private _anyoEdicion As Integer
    Private _estado As String


    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            lTitulo.Text = value
        End Set
    End Property

    Public Property Escritor As String
        Get
            Return _escritor
        End Get
        Set(value As String)
            lEscritor.Text = value
        End Set
    End Property

    Public Property AnyoEdicion As Integer
        Get
            Return _anyoEdicion
        End Get
        Set(value As Integer)
            lAnyo.Text = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
            lEstado.Text = value
        End Set
    End Property



    ' Evento que se dispara cuando cambia el estado del CheckBox
    Public Event ClickEditar()
    Public Event ClickInformacion()
    Public Event ClickBorrar()
    Public Event ClickCambiarEstado()

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        RaiseEvent ClickEditar()
    End Sub

    Private Sub bInfo_Click(sender As Object, e As EventArgs) Handles bInfo.Click
        RaiseEvent ClickInformacion()
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        RaiseEvent ClickBorrar()
    End Sub

    Private Sub LibroControl_MouseEnter(sender As Object, e As EventArgs) Handles tlpControlLibro.MouseEnter, MyBase.MouseEnter, lTitulo.MouseEnter, lEstado.MouseEnter, lEscritor.MouseEnter, lAnyo.MouseEnter
        tlpControlLibro.BackColor = Color.LightGray
    End Sub

    Private Sub LibroControl_MouseLeave(sender As Object, e As EventArgs) Handles tlpControlLibro.MouseLeave, MyBase.MouseLeave, lTitulo.MouseLeave, lEstado.MouseLeave, lEscritor.MouseLeave, lAnyo.MouseLeave
        tlpControlLibro.BackColor = Color.White
    End Sub

End Class
