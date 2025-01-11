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
        Me.pDashboard = New System.Windows.Forms.Panel()
        Me.tlpDashboardUsuarios = New System.Windows.Forms.TableLayoutPanel()
        Me.pcDashboard = New System.Windows.Forms.PictureBox()
        Me.lDashboardUsuarios = New System.Windows.Forms.Label()
        Me.pDashboardLibros = New System.Windows.Forms.Panel()
        Me.tlpDashboardLibros = New System.Windows.Forms.TableLayoutPanel()
        Me.pcDashboardLibros = New System.Windows.Forms.PictureBox()
        Me.lDashboardLibros = New System.Windows.Forms.Label()
        Me.pDashboardAutores = New System.Windows.Forms.Panel()
        Me.tlpAutores = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lDashboardAutores = New System.Windows.Forms.Label()
        Me.pDashboardPrestamos = New System.Windows.Forms.Panel()
        Me.tlpPrestamos = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lDashboardPrestamos = New System.Windows.Forms.Label()
        Me.pDashboardCategorias = New System.Windows.Forms.Panel()
        Me.tlpCategorias = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        Me.pPanelAdministracion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDashboard.SuspendLayout()
        Me.tlpDashboardUsuarios.SuspendLayout()
        CType(Me.pcDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDashboardLibros.SuspendLayout()
        Me.tlpDashboardLibros.SuspendLayout()
        CType(Me.pcDashboardLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDashboardAutores.SuspendLayout()
        Me.tlpAutores.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDashboardPrestamos.SuspendLayout()
        Me.tlpPrestamos.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDashboardCategorias.SuspendLayout()
        Me.tlpCategorias.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpPrincipal.Controls.Add(Me.pDashboard, 1, 2)
        Me.tlpPrincipal.Controls.Add(Me.pDashboardLibros, 2, 2)
        Me.tlpPrincipal.Controls.Add(Me.pDashboardAutores, 1, 3)
        Me.tlpPrincipal.Controls.Add(Me.pDashboardPrestamos, 2, 3)
        Me.tlpPrincipal.Controls.Add(Me.pDashboardCategorias, 1, 4)
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
        Me.tlpPrincipal.Size = New System.Drawing.Size(500, 322)
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
        Me.pPanelAdministracion.Size = New System.Drawing.Size(494, 39)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(494, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 23)
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
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Panel de Administracion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pDashboard
        '
        Me.pDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.pDashboard.Controls.Add(Me.tlpDashboardUsuarios)
        Me.pDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDashboard.Location = New System.Drawing.Point(128, 93)
        Me.pDashboard.Name = "pDashboard"
        Me.pDashboard.Size = New System.Drawing.Size(119, 39)
        Me.pDashboard.TabIndex = 7
        '
        'tlpDashboardUsuarios
        '
        Me.tlpDashboardUsuarios.ColumnCount = 2
        Me.tlpDashboardUsuarios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpDashboardUsuarios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpDashboardUsuarios.Controls.Add(Me.pcDashboard, 0, 0)
        Me.tlpDashboardUsuarios.Controls.Add(Me.lDashboardUsuarios, 1, 0)
        Me.tlpDashboardUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDashboardUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tlpDashboardUsuarios.Name = "tlpDashboardUsuarios"
        Me.tlpDashboardUsuarios.RowCount = 1
        Me.tlpDashboardUsuarios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDashboardUsuarios.Size = New System.Drawing.Size(119, 39)
        Me.tlpDashboardUsuarios.TabIndex = 0
        '
        'pcDashboard
        '
        Me.pcDashboard.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pcDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcDashboard.Image = CType(resources.GetObject("pcDashboard.Image"), System.Drawing.Image)
        Me.pcDashboard.Location = New System.Drawing.Point(3, 3)
        Me.pcDashboard.Name = "pcDashboard"
        Me.pcDashboard.Size = New System.Drawing.Size(41, 33)
        Me.pcDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcDashboard.TabIndex = 0
        Me.pcDashboard.TabStop = False
        '
        'lDashboardUsuarios
        '
        Me.lDashboardUsuarios.AutoSize = True
        Me.lDashboardUsuarios.BackColor = System.Drawing.Color.White
        Me.lDashboardUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lDashboardUsuarios.Location = New System.Drawing.Point(50, 0)
        Me.lDashboardUsuarios.Name = "lDashboardUsuarios"
        Me.lDashboardUsuarios.Size = New System.Drawing.Size(66, 39)
        Me.lDashboardUsuarios.TabIndex = 1
        Me.lDashboardUsuarios.Text = "Usuarios"
        Me.lDashboardUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pDashboardLibros
        '
        Me.pDashboardLibros.Controls.Add(Me.tlpDashboardLibros)
        Me.pDashboardLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDashboardLibros.Location = New System.Drawing.Point(253, 93)
        Me.pDashboardLibros.Name = "pDashboardLibros"
        Me.pDashboardLibros.Size = New System.Drawing.Size(119, 39)
        Me.pDashboardLibros.TabIndex = 8
        '
        'tlpDashboardLibros
        '
        Me.tlpDashboardLibros.ColumnCount = 2
        Me.tlpDashboardLibros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpDashboardLibros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpDashboardLibros.Controls.Add(Me.pcDashboardLibros, 0, 0)
        Me.tlpDashboardLibros.Controls.Add(Me.lDashboardLibros, 1, 0)
        Me.tlpDashboardLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDashboardLibros.Location = New System.Drawing.Point(0, 0)
        Me.tlpDashboardLibros.Name = "tlpDashboardLibros"
        Me.tlpDashboardLibros.RowCount = 1
        Me.tlpDashboardLibros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDashboardLibros.Size = New System.Drawing.Size(119, 39)
        Me.tlpDashboardLibros.TabIndex = 0
        '
        'pcDashboardLibros
        '
        Me.pcDashboardLibros.BackColor = System.Drawing.Color.DarkGray
        Me.pcDashboardLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcDashboardLibros.Image = CType(resources.GetObject("pcDashboardLibros.Image"), System.Drawing.Image)
        Me.pcDashboardLibros.Location = New System.Drawing.Point(3, 3)
        Me.pcDashboardLibros.Name = "pcDashboardLibros"
        Me.pcDashboardLibros.Padding = New System.Windows.Forms.Padding(10)
        Me.pcDashboardLibros.Size = New System.Drawing.Size(41, 33)
        Me.pcDashboardLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcDashboardLibros.TabIndex = 0
        Me.pcDashboardLibros.TabStop = False
        '
        'lDashboardLibros
        '
        Me.lDashboardLibros.AutoSize = True
        Me.lDashboardLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lDashboardLibros.Location = New System.Drawing.Point(50, 0)
        Me.lDashboardLibros.Name = "lDashboardLibros"
        Me.lDashboardLibros.Size = New System.Drawing.Size(66, 39)
        Me.lDashboardLibros.TabIndex = 1
        Me.lDashboardLibros.Text = "Libros"
        Me.lDashboardLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pDashboardAutores
        '
        Me.pDashboardAutores.Controls.Add(Me.tlpAutores)
        Me.pDashboardAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDashboardAutores.Location = New System.Drawing.Point(128, 138)
        Me.pDashboardAutores.Name = "pDashboardAutores"
        Me.pDashboardAutores.Size = New System.Drawing.Size(119, 39)
        Me.pDashboardAutores.TabIndex = 9
        '
        'tlpAutores
        '
        Me.tlpAutores.ColumnCount = 2
        Me.tlpAutores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpAutores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpAutores.Controls.Add(Me.PictureBox2, 0, 0)
        Me.tlpAutores.Controls.Add(Me.lDashboardAutores, 1, 0)
        Me.tlpAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAutores.Location = New System.Drawing.Point(0, 0)
        Me.tlpAutores.Name = "tlpAutores"
        Me.tlpAutores.RowCount = 1
        Me.tlpAutores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAutores.Size = New System.Drawing.Size(119, 39)
        Me.tlpAutores.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.PictureBox2.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'lDashboardAutores
        '
        Me.lDashboardAutores.AutoSize = True
        Me.lDashboardAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lDashboardAutores.Location = New System.Drawing.Point(50, 0)
        Me.lDashboardAutores.Name = "lDashboardAutores"
        Me.lDashboardAutores.Size = New System.Drawing.Size(66, 39)
        Me.lDashboardAutores.TabIndex = 1
        Me.lDashboardAutores.Text = "Autores"
        Me.lDashboardAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pDashboardPrestamos
        '
        Me.pDashboardPrestamos.Controls.Add(Me.tlpPrestamos)
        Me.pDashboardPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDashboardPrestamos.Location = New System.Drawing.Point(253, 138)
        Me.pDashboardPrestamos.Name = "pDashboardPrestamos"
        Me.pDashboardPrestamos.Size = New System.Drawing.Size(119, 39)
        Me.pDashboardPrestamos.TabIndex = 10
        '
        'tlpPrestamos
        '
        Me.tlpPrestamos.ColumnCount = 2
        Me.tlpPrestamos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPrestamos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpPrestamos.Controls.Add(Me.PictureBox3, 0, 0)
        Me.tlpPrestamos.Controls.Add(Me.lDashboardPrestamos, 1, 0)
        Me.tlpPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrestamos.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrestamos.Name = "tlpPrestamos"
        Me.tlpPrestamos.RowCount = 1
        Me.tlpPrestamos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrestamos.Size = New System.Drawing.Size(119, 39)
        Me.tlpPrestamos.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'lDashboardPrestamos
        '
        Me.lDashboardPrestamos.AutoSize = True
        Me.lDashboardPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lDashboardPrestamos.Location = New System.Drawing.Point(50, 0)
        Me.lDashboardPrestamos.Name = "lDashboardPrestamos"
        Me.lDashboardPrestamos.Size = New System.Drawing.Size(66, 39)
        Me.lDashboardPrestamos.TabIndex = 1
        Me.lDashboardPrestamos.Text = "Prestamos"
        Me.lDashboardPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pDashboardCategorias
        '
        Me.tlpPrincipal.SetColumnSpan(Me.pDashboardCategorias, 2)
        Me.pDashboardCategorias.Controls.Add(Me.tlpCategorias)
        Me.pDashboardCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDashboardCategorias.Location = New System.Drawing.Point(128, 183)
        Me.pDashboardCategorias.Name = "pDashboardCategorias"
        Me.pDashboardCategorias.Size = New System.Drawing.Size(244, 39)
        Me.pDashboardCategorias.TabIndex = 11
        '
        'tlpCategorias
        '
        Me.tlpCategorias.ColumnCount = 4
        Me.tlpCategorias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCategorias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCategorias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCategorias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCategorias.Controls.Add(Me.PictureBox4, 1, 0)
        Me.tlpCategorias.Controls.Add(Me.Label4, 2, 0)
        Me.tlpCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCategorias.Location = New System.Drawing.Point(0, 0)
        Me.tlpCategorias.Name = "tlpCategorias"
        Me.tlpCategorias.RowCount = 1
        Me.tlpCategorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCategorias.Size = New System.Drawing.Size(244, 39)
        Me.tlpCategorias.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(64, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(55, 33)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(125, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 39)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Categorias"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 322)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(500, 322)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.pPanelAdministracion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDashboard.ResumeLayout(False)
        Me.tlpDashboardUsuarios.ResumeLayout(False)
        Me.tlpDashboardUsuarios.PerformLayout()
        CType(Me.pcDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDashboardLibros.ResumeLayout(False)
        Me.tlpDashboardLibros.ResumeLayout(False)
        Me.tlpDashboardLibros.PerformLayout()
        CType(Me.pcDashboardLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDashboardAutores.ResumeLayout(False)
        Me.tlpAutores.ResumeLayout(False)
        Me.tlpAutores.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDashboardPrestamos.ResumeLayout(False)
        Me.tlpPrestamos.ResumeLayout(False)
        Me.tlpPrestamos.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDashboardCategorias.ResumeLayout(False)
        Me.tlpCategorias.ResumeLayout(False)
        Me.tlpCategorias.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents pPanelAdministracion As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pDashboard As Panel
    Friend WithEvents tlpDashboardUsuarios As TableLayoutPanel
    Friend WithEvents pcDashboard As PictureBox
    Friend WithEvents lDashboardUsuarios As Label
    Friend WithEvents pDashboardLibros As Panel
    Friend WithEvents tlpDashboardLibros As TableLayoutPanel
    Friend WithEvents pcDashboardLibros As PictureBox
    Friend WithEvents lDashboardLibros As Label
    Friend WithEvents pDashboardAutores As Panel
    Friend WithEvents pDashboardPrestamos As Panel
    Friend WithEvents pDashboardCategorias As Panel
    Friend WithEvents tlpAutores As TableLayoutPanel
    Friend WithEvents tlpPrestamos As TableLayoutPanel
    Friend WithEvents tlpCategorias As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lDashboardAutores As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lDashboardPrestamos As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
End Class
