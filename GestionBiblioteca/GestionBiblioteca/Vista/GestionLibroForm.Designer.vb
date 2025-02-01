<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionLibroForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLibroForm))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTitulo = New System.Windows.Forms.TableLayoutPanel()
        Me.lGestionLibros = New System.Windows.Forms.Label()
        Me.bCrearLibro = New System.Windows.Forms.Button()
        Me.tlpLibros = New System.Windows.Forms.TableLayoutPanel()
        Me.panelLibros = New System.Windows.Forms.Panel()
        Me.tlpPrincipal.SuspendLayout()
        Me.tlpTitulo.SuspendLayout()
        Me.tlpLibros.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 1
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Controls.Add(Me.tlpLibros, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.tlpTitulo, 0, 0)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 2
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(574, 363)
        Me.tlpPrincipal.TabIndex = 0
        '
        'tlpTitulo
        '
        Me.tlpTitulo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tlpTitulo.ColumnCount = 2
        Me.tlpTitulo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTitulo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTitulo.Controls.Add(Me.lGestionLibros, 0, 0)
        Me.tlpTitulo.Controls.Add(Me.bCrearLibro, 1, 0)
        Me.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTitulo.Location = New System.Drawing.Point(3, 3)
        Me.tlpTitulo.Name = "tlpTitulo"
        Me.tlpTitulo.RowCount = 1
        Me.tlpTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTitulo.Size = New System.Drawing.Size(568, 59)
        Me.tlpTitulo.TabIndex = 2
        '
        'lGestionLibros
        '
        Me.lGestionLibros.AutoSize = True
        Me.lGestionLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lGestionLibros.Location = New System.Drawing.Point(3, 0)
        Me.lGestionLibros.Name = "lGestionLibros"
        Me.lGestionLibros.Size = New System.Drawing.Size(278, 59)
        Me.lGestionLibros.TabIndex = 0
        Me.lGestionLibros.Text = "Gestion de Libros"
        Me.lGestionLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bCrearLibro
        '
        Me.bCrearLibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.bCrearLibro.Image = CType(resources.GetObject("bCrearLibro.Image"), System.Drawing.Image)
        Me.bCrearLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCrearLibro.Location = New System.Drawing.Point(377, 3)
        Me.bCrearLibro.Name = "bCrearLibro"
        Me.bCrearLibro.Padding = New System.Windows.Forms.Padding(5)
        Me.bCrearLibro.Size = New System.Drawing.Size(97, 53)
        Me.bCrearLibro.TabIndex = 1
        Me.bCrearLibro.Text = "Añadir"
        Me.bCrearLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCrearLibro.UseVisualStyleBackColor = True
        '
        'tlpLibros
        '
        Me.tlpLibros.ColumnCount = 3
        Me.tlpLibros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpLibros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibros.Controls.Add(Me.panelLibros, 1, 1)
        Me.tlpLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLibros.Location = New System.Drawing.Point(3, 83)
        Me.tlpLibros.Name = "tlpLibros"
        Me.tlpLibros.RowCount = 3
        Me.tlpLibros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpLibros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibros.Size = New System.Drawing.Size(568, 277)
        Me.tlpLibros.TabIndex = 4
        '
        'panelLibros
        '
        Me.panelLibros.AutoScroll = True
        Me.panelLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLibros.Location = New System.Drawing.Point(59, 30)
        Me.panelLibros.Name = "panelLibros"
        Me.panelLibros.Size = New System.Drawing.Size(448, 215)
        Me.panelLibros.TabIndex = 2
        '
        'GestionLibroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 363)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(574, 363)
        Me.Name = "GestionLibroForm"
        Me.Text = "<"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpTitulo.ResumeLayout(False)
        Me.tlpTitulo.PerformLayout()
        Me.tlpLibros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents tlpLibros As TableLayoutPanel
    Friend WithEvents panelLibros As Panel
    Friend WithEvents tlpTitulo As TableLayoutPanel
    Friend WithEvents lGestionLibros As Label
    Friend WithEvents bCrearLibro As Button
End Class
