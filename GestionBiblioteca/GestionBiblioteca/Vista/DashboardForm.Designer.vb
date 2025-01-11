<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.pPanelAdministracion = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlockDashboard1 = New ControlesBiblioteca.BlockDashboard()
        Me.bdUsuarios = New ControlesBiblioteca.BlockDashboard()
        Me.bdLibros = New ControlesBiblioteca.BlockDashboard()
        Me.bdAutores = New ControlesBiblioteca.BlockDashboard()
        Me.bdPrestamos = New ControlesBiblioteca.BlockDashboard()
        Me.tlpPrincipal.SuspendLayout()
        Me.pPanelAdministracion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpPrincipal.Controls.Add(Me.BlockDashboard1, 1, 4)
        Me.tlpPrincipal.Controls.Add(Me.bdUsuarios, 1, 2)
        Me.tlpPrincipal.Controls.Add(Me.bdLibros, 2, 2)
        Me.tlpPrincipal.Controls.Add(Me.bdAutores, 1, 3)
        Me.tlpPrincipal.Controls.Add(Me.bdPrestamos, 2, 3)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 7
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(546, 417)
        Me.tlpPrincipal.TabIndex = 0
        '
        'pPanelAdministracion
        '
        Me.pPanelAdministracion.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.pPanelAdministracion.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tlpPrincipal.SetColumnSpan(Me.pPanelAdministracion, 4)
        Me.pPanelAdministracion.Controls.Add(Me.TableLayoutPanel1)
        Me.pPanelAdministracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPanelAdministracion.Location = New System.Drawing.Point(3, 3)
        Me.pPanelAdministracion.Name = "pPanelAdministracion"
        Me.pPanelAdministracion.Size = New System.Drawing.Size(540, 53)
        Me.pPanelAdministracion.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(540, 53)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Panel de Administracion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BlockDashboard1
        '
        Me.BlockDashboard1.BackColor = System.Drawing.Color.White
        Me.BlockDashboard1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BlockDashboard1.BorderWidth = 2
        Me.BlockDashboard1.ColorFondoImagen = System.Drawing.Color.RosyBrown
        Me.tlpPrincipal.SetColumnSpan(Me.BlockDashboard1, 2)
        Me.BlockDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlockDashboard1.Imagen = CType(resources.GetObject("BlockDashboard1.Imagen"), System.Drawing.Image)
        Me.BlockDashboard1.Location = New System.Drawing.Point(146, 246)
        Me.BlockDashboard1.Margin = New System.Windows.Forms.Padding(10)
        Me.BlockDashboard1.Name = "BlockDashboard1"
        Me.BlockDashboard1.Padding = New System.Windows.Forms.Padding(10)
        Me.BlockDashboard1.Size = New System.Drawing.Size(252, 39)
        Me.BlockDashboard1.TabIndex = 11
        Me.BlockDashboard1.Titulo = "Titulo"
        '
        'bdUsuarios
        '
        Me.bdUsuarios.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bdUsuarios.BorderWidth = 2
        Me.bdUsuarios.ColorFondoImagen = System.Drawing.Color.Salmon
        Me.bdUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bdUsuarios.Imagen = CType(resources.GetObject("bdUsuarios.Imagen"), System.Drawing.Image)
        Me.bdUsuarios.Location = New System.Drawing.Point(146, 128)
        Me.bdUsuarios.Margin = New System.Windows.Forms.Padding(10)
        Me.bdUsuarios.Name = "bdUsuarios"
        Me.bdUsuarios.Padding = New System.Windows.Forms.Padding(10)
        Me.bdUsuarios.Size = New System.Drawing.Size(116, 39)
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
        Me.bdLibros.Location = New System.Drawing.Point(282, 128)
        Me.bdLibros.Margin = New System.Windows.Forms.Padding(10)
        Me.bdLibros.Name = "bdLibros"
        Me.bdLibros.Padding = New System.Windows.Forms.Padding(10)
        Me.bdLibros.Size = New System.Drawing.Size(116, 39)
        Me.bdLibros.TabIndex = 13
        Me.bdLibros.Titulo = "Libros"
        '
        'bdAutores
        '
        Me.bdAutores.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bdAutores.BorderWidth = 2
        Me.bdAutores.ColorFondoImagen = System.Drawing.Color.DarkGray
        Me.bdAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bdAutores.Imagen = CType(resources.GetObject("bdAutores.Imagen"), System.Drawing.Image)
        Me.bdAutores.Location = New System.Drawing.Point(146, 187)
        Me.bdAutores.Margin = New System.Windows.Forms.Padding(10)
        Me.bdAutores.Name = "bdAutores"
        Me.bdAutores.Padding = New System.Windows.Forms.Padding(10)
        Me.bdAutores.Size = New System.Drawing.Size(116, 39)
        Me.bdAutores.TabIndex = 14
        Me.bdAutores.Titulo = "Autores"
        '
        'bdPrestamos
        '
        Me.bdPrestamos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bdPrestamos.BorderWidth = 2
        Me.bdPrestamos.ColorFondoImagen = System.Drawing.Color.DarkGray
        Me.bdPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bdPrestamos.Imagen = CType(resources.GetObject("bdPrestamos.Imagen"), System.Drawing.Image)
        Me.bdPrestamos.Location = New System.Drawing.Point(282, 187)
        Me.bdPrestamos.Margin = New System.Windows.Forms.Padding(10)
        Me.bdPrestamos.Name = "bdPrestamos"
        Me.bdPrestamos.Padding = New System.Windows.Forms.Padding(10)
        Me.bdPrestamos.Size = New System.Drawing.Size(116, 39)
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents pPanelAdministracion As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BlockDashboard1 As ControlesBiblioteca.BlockDashboard
    Friend WithEvents bdUsuarios As ControlesBiblioteca.BlockDashboard
    Friend WithEvents bdLibros As ControlesBiblioteca.BlockDashboard
    Friend WithEvents bdAutores As ControlesBiblioteca.BlockDashboard
    Friend WithEvents bdPrestamos As ControlesBiblioteca.BlockDashboard
End Class
