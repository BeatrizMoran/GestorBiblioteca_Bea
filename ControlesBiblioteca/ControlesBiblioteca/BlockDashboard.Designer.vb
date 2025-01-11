<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpBlock = New System.Windows.Forms.TableLayoutPanel()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.tlpBlock.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpBlock
        '
        Me.tlpBlock.ColumnCount = 2
        Me.tlpBlock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpBlock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpBlock.Controls.Add(Me.pbImagen, 0, 0)
        Me.tlpBlock.Controls.Add(Me.lTitulo, 1, 0)
        Me.tlpBlock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBlock.Location = New System.Drawing.Point(0, 0)
        Me.tlpBlock.Name = "tlpBlock"
        Me.tlpBlock.RowCount = 1
        Me.tlpBlock.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBlock.Size = New System.Drawing.Size(314, 126)
        Me.tlpBlock.TabIndex = 0
        '
        'pbImagen
        '
        Me.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImagen.Location = New System.Drawing.Point(3, 3)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(119, 120)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.BackColor = System.Drawing.Color.White
        Me.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo.Location = New System.Drawing.Point(128, 0)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(183, 126)
        Me.lTitulo.TabIndex = 1
        Me.lTitulo.Text = "Titulo"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BlockDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpBlock)
        Me.Name = "BlockDashboard"
        Me.Size = New System.Drawing.Size(314, 126)
        Me.tlpBlock.ResumeLayout(False)
        Me.tlpBlock.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpBlock As TableLayoutPanel
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lTitulo As Label
End Class
