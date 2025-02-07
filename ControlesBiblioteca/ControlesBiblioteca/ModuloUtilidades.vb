Public Module ModuloUtilidades
    Private Const FONTSIZE As Integer = 12 ' Tamaño base de fuente

    Public Sub AjustarFuente(formulario As Form, tamanoMaximoLetra As Integer, Optional menuStrip As MenuStrip = Nothing, Optional tlPanel As TableLayoutPanel = Nothing, Optional tabla As DataGridView = Nothing)
        ' Ajustar el tamaño proporcional de la fuente basado en el ancho y alto
        Dim proporcionAncho As Double = formulario.Width / formulario.MinimumSize.Width
        Dim proporcionAlto As Double = formulario.Height / formulario.MinimumSize.Height
        Dim proporcionPromedio As Double = (proporcionAncho + proporcionAlto) / 2

        ' Determinar el tamaño de la fuente dentro de los límites
        Dim tamanoFuente As Integer = Math.Min(proporcionPromedio * FONTSIZE, tamanoMaximoLetra)



        ' Actualizar la fuente para los controles en el formulario si se proporciona un TableLayoutPanel
        If tlPanel IsNot Nothing Then
            For Each control As Control In tlPanel.Controls
                control.Font = New Font("Microsoft Sans Serif", tamanoFuente)
            Next
        End If

        If menuStrip IsNot Nothing Then
            For Each item As ToolStripItem In menuStrip.Items
                item.Font = New Font("Microsoft Sans Serif", tamanoFuente)
            Next
        End If

        ' Si se proporciona un DataGridView, actualizar sus fuentes
        If tabla IsNot Nothing Then
            ' Actualizar las fuentes de las columnas y encabezados
            For Each column As DataGridViewColumn In tabla.Columns
                column.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", tamanoFuente)
            Next

            tabla.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", tamanoFuente, FontStyle.Bold)

            ' Forzar la actualización visual del DataGridView
            tabla.Invalidate()
            tabla.Refresh()
        End If
    End Sub


End Module
