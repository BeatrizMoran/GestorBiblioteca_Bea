<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabelledInput
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
        Me.tlpControl = New System.Windows.Forms.TableLayoutPanel()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.tbCampo = New System.Windows.Forms.TextBox()
        Me.tlpControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpControl
        '
        Me.tlpControl.ColumnCount = 1
        Me.tlpControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControl.Controls.Add(Me.lTitulo, 0, 0)
        Me.tlpControl.Controls.Add(Me.tbCampo, 0, 1)
        Me.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControl.Location = New System.Drawing.Point(0, 0)
        Me.tlpControl.Name = "tlpControl"
        Me.tlpControl.RowCount = 2
        Me.tlpControl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControl.Size = New System.Drawing.Size(188, 47)
        Me.tlpControl.TabIndex = 0
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(182, 13)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "Titulo"
        '
        'tbCampo
        '
        Me.tbCampo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCampo.Location = New System.Drawing.Point(3, 16)
        Me.tbCampo.Name = "tbCampo"
        Me.tbCampo.Size = New System.Drawing.Size(182, 20)
        Me.tbCampo.TabIndex = 1
        '
        'LabelledInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpControl)
        Me.Name = "LabelledInput"
        Me.Size = New System.Drawing.Size(188, 47)
        Me.tlpControl.ResumeLayout(False)
        Me.tlpControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpControl As TableLayoutPanel
    Friend WithEvents lTitulo As Label
    Friend WithEvents tbCampo As TextBox
End Class
