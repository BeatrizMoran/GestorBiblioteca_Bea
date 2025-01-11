<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosForm))
        Me.tlpGestionUsuarios = New System.Windows.Forms.TableLayoutPanel()
        Me.bCrearUsuario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpTabla = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.tlpGestionUsuarios.SuspendLayout()
        Me.tlpTabla.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpGestionUsuarios
        '
        Me.tlpGestionUsuarios.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tlpGestionUsuarios.ColumnCount = 2
        Me.tlpGestionUsuarios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpGestionUsuarios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpGestionUsuarios.Controls.Add(Me.bCrearUsuario, 1, 0)
        Me.tlpGestionUsuarios.Controls.Add(Me.Label1, 0, 0)
        Me.tlpGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpGestionUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tlpGestionUsuarios.Name = "tlpGestionUsuarios"
        Me.tlpGestionUsuarios.RowCount = 1
        Me.tlpGestionUsuarios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGestionUsuarios.Size = New System.Drawing.Size(574, 59)
        Me.tlpGestionUsuarios.TabIndex = 2
        '
        'bCrearUsuario
        '
        Me.bCrearUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.bCrearUsuario.Image = CType(resources.GetObject("bCrearUsuario.Image"), System.Drawing.Image)
        Me.bCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCrearUsuario.Location = New System.Drawing.Point(382, 3)
        Me.bCrearUsuario.Name = "bCrearUsuario"
        Me.bCrearUsuario.Padding = New System.Windows.Forms.Padding(5)
        Me.bCrearUsuario.Size = New System.Drawing.Size(97, 53)
        Me.bCrearUsuario.TabIndex = 0
        Me.bCrearUsuario.Text = "Añadir"
        Me.bCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCrearUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestion de usuarios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTabla
        '
        Me.tlpTabla.ColumnCount = 3
        Me.tlpTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.Controls.Add(Me.dgvUsuarios, 1, 1)
        Me.tlpTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTabla.Location = New System.Drawing.Point(0, 59)
        Me.tlpTabla.Name = "tlpTabla"
        Me.tlpTabla.RowCount = 3
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.Size = New System.Drawing.Size(574, 304)
        Me.tlpTabla.TabIndex = 3
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Location = New System.Drawing.Point(60, 33)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(453, 237)
        Me.dgvUsuarios.TabIndex = 2
        '
        'UsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 363)
        Me.Controls.Add(Me.tlpTabla)
        Me.Controls.Add(Me.tlpGestionUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(574, 363)
        Me.Name = "UsuariosForm"
        Me.Text = "UsuariosForm"
        Me.tlpGestionUsuarios.ResumeLayout(False)
        Me.tlpGestionUsuarios.PerformLayout()
        Me.tlpTabla.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpGestionUsuarios As TableLayoutPanel
    Friend WithEvents bCrearUsuario As Button
    Friend WithEvents tlpTabla As TableLayoutPanel
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label1 As Label
End Class
