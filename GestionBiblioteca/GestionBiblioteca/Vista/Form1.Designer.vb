<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bTituloLogo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.msNavbar = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.msNavbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bTituloLogo
        '
        Me.bTituloLogo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bTituloLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bTituloLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTituloLogo.Image = CType(resources.GetObject("bTituloLogo.Image"), System.Drawing.Image)
        Me.bTituloLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTituloLogo.Location = New System.Drawing.Point(40, 3)
        Me.bTituloLogo.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.bTituloLogo.Name = "bTituloLogo"
        Me.bTituloLogo.Size = New System.Drawing.Size(153, 77)
        Me.bTituloLogo.TabIndex = 7
        Me.bTituloLogo.Text = "BIBLIOMUNDO"
        Me.bTituloLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bTituloLogo.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.bTituloLogo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.msNavbar, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 416)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'msNavbar
        '
        Me.msNavbar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.msNavbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.msNavbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.PrestamosToolStripMenuItem})
        Me.msNavbar.Location = New System.Drawing.Point(0, 93)
        Me.msNavbar.MinimumSize = New System.Drawing.Size(196, 0)
        Me.msNavbar.Name = "msNavbar"
        Me.msNavbar.Size = New System.Drawing.Size(196, 323)
        Me.msNavbar.TabIndex = 8
        Me.msNavbar.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Image = CType(resources.GetObject("LibrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.LibrosToolStripMenuItem.Text = "Libros"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.Image = CType(resources.GetObject("PrestamosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bVolver)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(196, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 48)
        Me.Panel1.TabIndex = 9
        '
        'bVolver
        '
        Me.bVolver.BackColor = System.Drawing.Color.White
        Me.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bVolver.Image = CType(resources.GetObject("bVolver.Image"), System.Drawing.Image)
        Me.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bVolver.Location = New System.Drawing.Point(0, 0)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(99, 45)
        Me.bVolver.TabIndex = 0
        Me.bVolver.Text = "Volver"
        Me.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bVolver.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 4)
        Me.Panel2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 416)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(699, 455)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.msNavbar.ResumeLayout(False)
        Me.msNavbar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bTituloLogo As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents msNavbar As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bVolver As Button
    Friend WithEvents Panel2 As Panel
End Class
