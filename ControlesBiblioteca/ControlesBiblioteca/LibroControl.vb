Public Class LibroControl
    Private _titulo As String
    Private _escritor As String
    Private _anyoEdicion As Integer
    Private _estado As String
    Private _disponible As Boolean


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

    Public Property Disponible As Boolean
        Get
            Return _disponible
        End Get
        Set(value As Boolean)
            If _disponible <> value Then
                _disponible = value
                cbDisponible.Checked = value ' Actualizar el estado del CheckBox
                ' Solo disparamos el evento si realmente cambia el estado
                RaiseEvent ClickCambiarEstado()
            End If
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

    ' Este evento se dispara cuando el CheckBox cambia
    Private Sub cbDisponible_CheckedChanged(sender As Object, e As EventArgs) Handles cbDisponible.CheckedChanged
        ' Solo actualizamos la propiedad _disponible si el estado del CheckBox cambia
        _disponible = cbDisponible.Checked
        ' Disparar el evento de cambio de estado
        RaiseEvent ClickCambiarEstado()
    End Sub

    ' Método para actualizar la fuente de los subcontroles
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
