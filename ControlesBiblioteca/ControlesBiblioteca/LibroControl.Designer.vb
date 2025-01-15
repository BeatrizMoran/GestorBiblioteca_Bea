<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibroControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibroControl))
        Me.tlpControlLibro = New System.Windows.Forms.TableLayoutPanel()
        Me.lAnyo = New System.Windows.Forms.Label()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.lEscritor = New System.Windows.Forms.Label()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.bInfo = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.tlpControlLibro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpControlLibro
        '
        Me.tlpControlLibro.ColumnCount = 7
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpControlLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpControlLibro.Controls.Add(Me.lAnyo, 3, 0)
        Me.tlpControlLibro.Controls.Add(Me.lTitulo, 1, 0)
        Me.tlpControlLibro.Controls.Add(Me.lEscritor, 2, 0)
        Me.tlpControlLibro.Controls.Add(Me.bEditar, 4, 0)
        Me.tlpControlLibro.Controls.Add(Me.bInfo, 5, 0)
        Me.tlpControlLibro.Controls.Add(Me.bBorrar, 6, 0)
        Me.tlpControlLibro.Controls.Add(Me.CheckBox1, 0, 0)
        Me.tlpControlLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControlLibro.Location = New System.Drawing.Point(0, 0)
        Me.tlpControlLibro.Name = "tlpControlLibro"
        Me.tlpControlLibro.RowCount = 1
        Me.tlpControlLibro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControlLibro.Size = New System.Drawing.Size(261, 41)
        Me.tlpControlLibro.TabIndex = 0
        '
        'lAnyo
        '
        Me.lAnyo.AutoSize = True
        Me.lAnyo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lAnyo.Location = New System.Drawing.Point(133, 0)
        Me.lAnyo.Name = "lAnyo"
        Me.lAnyo.Size = New System.Drawing.Size(46, 41)
        Me.lAnyo.TabIndex = 3
        Me.lAnyo.Text = "Año"
        Me.lAnyo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo.Location = New System.Drawing.Point(29, 0)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(46, 41)
        Me.lTitulo.TabIndex = 1
        Me.lTitulo.Text = "Titulo"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lEscritor
        '
        Me.lEscritor.AutoSize = True
        Me.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEscritor.Location = New System.Drawing.Point(81, 0)
        Me.lEscritor.Name = "lEscritor"
        Me.lEscritor.Size = New System.Drawing.Size(46, 41)
        Me.lEscritor.TabIndex = 2
        Me.lEscritor.Text = "Escritor"
        Me.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bEditar
        '
        Me.bEditar.BackgroundImage = CType(resources.GetObject("bEditar.BackgroundImage"), System.Drawing.Image)
        Me.bEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bEditar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bEditar.Location = New System.Drawing.Point(185, 3)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(20, 35)
        Me.bEditar.TabIndex = 4
        Me.bEditar.UseVisualStyleBackColor = True
        '
        'bInfo
        '
        Me.bInfo.BackgroundImage = CType(resources.GetObject("bInfo.BackgroundImage"), System.Drawing.Image)
        Me.bInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bInfo.Location = New System.Drawing.Point(211, 3)
        Me.bInfo.Name = "bInfo"
        Me.bInfo.Size = New System.Drawing.Size(20, 35)
        Me.bInfo.TabIndex = 5
        Me.bInfo.UseVisualStyleBackColor = True
        '
        'bBorrar
        '
        Me.bBorrar.BackgroundImage = CType(resources.GetObject("bBorrar.BackgroundImage"), System.Drawing.Image)
        Me.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bBorrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bBorrar.Location = New System.Drawing.Point(237, 3)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(21, 35)
        Me.bBorrar.TabIndex = 6
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(20, 35)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LibroControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tlpControlLibro)
        Me.Name = "LibroControl"
        Me.Size = New System.Drawing.Size(261, 41)
        Me.tlpControlLibro.ResumeLayout(False)
        Me.tlpControlLibro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpControlLibro As TableLayoutPanel
    Friend WithEvents bBorrar As Button
    Friend WithEvents lAnyo As Label
    Friend WithEvents lTitulo As Label
    Friend WithEvents lEscritor As Label
    Friend WithEvents bEditar As Button
    Friend WithEvents bInfo As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
