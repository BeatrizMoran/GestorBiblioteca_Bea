Public Class LibroControl
    Private _titulo As String
    Private _escritor As String
    Private _anyoEdicion As Integer

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

    Public Event ClickEditar()

    Public Event ClickInformacion()

    Public Event ClickBorrar()

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        RaiseEvent ClickEditar()
    End Sub

    Private Sub bInfo_Click(sender As Object, e As EventArgs) Handles bInfo.Click
        RaiseEvent ClickInformacion()

    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        RaiseEvent ClickBorrar()

    End Sub

    Public Sub ActualizarFuente(fuente As Font)
        Me.Font = fuente
        ' Cambiar la fuente de los subcontroles
        lTitulo.Font = fuente
        lEscritor.Font = fuente
        lAnyo.Font = fuente
        bEditar.Font = fuente
        bInfo.Font = fuente
        bBorrar.Font = fuente

        ' Ajustar el tamaño del control basado en el tamaño de la fuente
        Me.Height = CInt(fuente.Size * 5) ' Ajusta según el diseño
        Me.Width = CInt(fuente.Size * 15) ' Ajusta según el diseño
    End Sub
End Class
