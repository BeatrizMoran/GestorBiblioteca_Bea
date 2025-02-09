<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.pPanelAdministracion = New System.Windows.Forms.Panel()
        Me.tlpPanelAdmin = New System.Windows.Forms.TableLayoutPanel()
        Me.pbPanelAdmin = New System.Windows.Forms.PictureBox()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.bdUsuarios = New ControlesBiblioteca.BlockDashboard()
        Me.bdLibros = New ControlesBiblioteca.BlockDashboard()
        Me.bdPrestamos = New ControlesBiblioteca.BlockDashboard()
        Me.tlpPrincipal.SuspendLayout()
        Me.pPanelAdministracion.SuspendLayout()
        Me.tlpPanelAdmin.SuspendLayout()
        CType(Me.pbPanelAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 4
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipal.Controls.Add(Me.pPanelAdministracion, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.bdUsuarios, 1, 2)
        Me.tlpPrincipal.Controls.Add(Me.bdLibros, 2, 2)
        Me.tlpPrincipal.Controls.Add(Me.bdPrestamos, 1, 3)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 5
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.56311!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35922!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35922!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35922!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35922!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(546, 417)
        Me.tlpPrincipal.TabIndex = 0
        '
        'pPanelAdministracion
        '
        Me.pPanelAdministracion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.pPanelAdministracion.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tlpPrincipal.SetColumnSpan(Me.pPanelAdministracion, 4)
        Me.pPanelAdministracion.Controls.Add(Me.tlpPanelAdmin)
        Me.pPanelAdministracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPanelAdministracion.Location = New System.Drawing.Point(3, 3)
        Me.pPanelAdministracion.Name = "pPanelAdministracion"
        Me.pPanelAdministracion.Size = New System.Drawing.Size(540, 54)
        Me.pPanelAdministracion.TabIndex = 6
        '
        'tlpPanelAdmin
        '
        Me.tlpPanelAdmin.ColumnCount = 2
        Me.tlpPanelAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPanelAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPanelAdmin.Controls.Add(Me.pbPanelAdmin, 0, 0)
        Me.tlpPanelAdmin.Controls.Add(Me.lTitulo, 1, 0)
        Me.tlpPanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPanelAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tlpPanelAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPanelAdmin.Name = "tlpPanelAdmin"
        Me.tlpPanelAdmin.Padding = New System.Windows.Forms.Padding(5)
        Me.tlpPanelAdmin.RowCount = 1
        Me.tlpPanelAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPanelAdmin.Size = New System.Drawing.Size(540, 54)
        Me.tlpPanelAdmin.TabIndex = 0
        '
        'pbPanelAdmin
        '
        Me.pbPanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPanelAdmin.Image = CType(resources.GetObject("pbPanelAdmin.Image"), System.Drawing.Image)
        Me.pbPanelAdmin.InitialImage = CType(resources.GetObject("pbPanelAdmin.InitialImage"), System.Drawing.Image)
        Me.pbPanelAdmin.Location = New System.Drawing.Point(8, 8)
        Me.pbPanelAdmin.Name = "pbPanelAdmin"
        Me.pbPanelAdmin.Size = New System.Drawing.Size(100, 38)
        Me.pbPanelAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPanelAdmin.TabIndex = 0
        Me.pbPanelAdmin.TabStop = False
        '
        'lTitulo
        '
        Me.lTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Location = New System.Drawing.Point(114, 5)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(120, 44)
        Me.lTitulo.TabIndex = 1
        Me.lTitulo.Text = "Panel de Administracion"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bdUsuarios
        '
        Me.bdUsuarios.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bdUsuarios.BorderWidth = 2
        Me.bdUsuarios.ColorFondoImagen = System.Drawing.Color.Salmon
        Me.bdUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bdUsuarios.Imagen = CType(resources.GetObject("bdUsuarios.Imagen"), System.Drawing.Image)
        Me.bdUsuarios.Location = New System.Drawing.Point(146, 159)
        Me.bdUsuarios.Margin = New System.Windows.Forms.Padding(10)
        Me.bdUsuarios.Name = "bdUsuarios"
        Me.bdUsuarios.Padding = New System.Windows.Forms.Padding(10)
        Me.bdUsuarios.Size = New System.Drawing.Size(116, 69)
        Me.bdUsuarios.TabIndex = 12
        Me.bdUsuarios.Titulo = "Usuarios"
        '
        'bdLibros
        '
        Me.bdLibros.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bdLibros.BorderWidth = 2
        Me.bdLibros.ColorFondoImagen = System.Drawing.Color.DarkGray
        Me.bdLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bdLibros.Imagen = CType(resources.GetObject("bdLibros.Imagen"), System.Drawing.Image)
        Me.bdLibros.Location = New System.Drawing.Point(282, 159)
        Me.bdLibros.Margin = New System.Windows.Forms.Padding(10)
        Me.bdLibros.Name = "bdLibros"
        Me.bdLibros.Padding = New System.Windows.Forms.Padding(10)
        Me.bdLibros.Size = New System.Drawing.Size(116, 69)
        Me.bdLibros.TabIndex = 13
        Me.bdLibros.Titulo = "Libros"
        '
        'bdPrestamos
        '
        Me.bdPrestamos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bdPrestamos.BorderWidth = 2
        Me.bdPrestamos.ColorFondoImagen = System.Drawing.Color.DarkGray
        Me.tlpPrincipal.SetColumnSpan(Me.bdPrestamos, 2)
        Me.bdPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bdPrestamos.Imagen = CType(resources.GetObject("bdPrestamos.Imagen"), System.Drawing.Image)
        Me.bdPrestamos.Location = New System.Drawing.Point(146, 248)
        Me.bdPrestamos.Margin = New System.Windows.Forms.Padding(10)
        Me.bdPrestamos.Name = "bdPrestamos"
        Me.bdPrestamos.Padding = New System.Windows.Forms.Padding(10)
        Me.bdPrestamos.Size = New System.Drawing.Size(252, 69)
        Me.bdPrestamos.TabIndex = 15
        Me.bdPrestamos.Titulo = "Prestamos"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 417)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(546, 417)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.pPanelAdministracion.ResumeLayout(False)
        Me.tlpPanelAdmin.ResumeLayout(False)
        Me.tlpPanelAdmin.PerformLayout()
        CType(Me.pbPanelAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents pPanelAdministracion As Panel
    Friend WithEvents tlpPanelAdmin As TableLayoutPanel
    Friend WithEvents pbPanelAdmin As PictureBox
    Friend WithEvents lTitulo As Label
    Friend WithEvents bdUsuarios As ControlesBiblioteca.BlockDashboard
    Friend WithEvents bdLibros As ControlesBiblioteca.BlockDashboard
    Friend WithEvents bdPrestamos As ControlesBiblioteca.BlockDashboard
End Class
