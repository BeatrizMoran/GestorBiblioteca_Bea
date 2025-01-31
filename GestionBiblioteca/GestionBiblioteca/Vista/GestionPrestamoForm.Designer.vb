<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionPrestamoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionPrestamoForm))
        Me.tlpTabla = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpGestionPrestamos = New System.Windows.Forms.TableLayoutPanel()
        Me.bCrearPrestamo = New System.Windows.Forms.Button()
        Me.lGestionPrestamos = New System.Windows.Forms.Label()
        Me.dgvPrestamos = New System.Windows.Forms.DataGridView()
        Me.tlpPaginacion = New System.Windows.Forms.TableLayoutPanel()
        Me.bAnterior = New System.Windows.Forms.Button()
        Me.bSiguiente = New System.Windows.Forms.Button()
        Me.lblPaginacion = New System.Windows.Forms.Label()
        Me.tlpFiltro = New System.Windows.Forms.TableLayoutPanel()
        Me.chbDisponibles = New System.Windows.Forms.CheckBox()
        Me.chbActivos = New System.Windows.Forms.CheckBox()
        Me.tlpTabla.SuspendLayout()
        Me.tlpGestionPrestamos.SuspendLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPaginacion.SuspendLayout()
        Me.tlpFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpTabla
        '
        Me.tlpTabla.ColumnCount = 3
        Me.tlpTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.Controls.Add(Me.tlpGestionPrestamos, 0, 0)
        Me.tlpTabla.Controls.Add(Me.dgvPrestamos, 1, 3)
        Me.tlpTabla.Controls.Add(Me.tlpPaginacion, 1, 4)
        Me.tlpTabla.Controls.Add(Me.tlpFiltro, 1, 2)
        Me.tlpTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTabla.Location = New System.Drawing.Point(0, 0)
        Me.tlpTabla.Name = "tlpTabla"
        Me.tlpTabla.RowCount = 6
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpTabla.Size = New System.Drawing.Size(800, 450)
        Me.tlpTabla.TabIndex = 4
        '
        'tlpGestionPrestamos
        '
        Me.tlpGestionPrestamos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tlpGestionPrestamos.ColumnCount = 2
        Me.tlpTabla.SetColumnSpan(Me.tlpGestionPrestamos, 3)
        Me.tlpGestionPrestamos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpGestionPrestamos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpGestionPrestamos.Controls.Add(Me.bCrearPrestamo, 1, 0)
        Me.tlpGestionPrestamos.Controls.Add(Me.lGestionPrestamos, 0, 0)
        Me.tlpGestionPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpGestionPrestamos.Location = New System.Drawing.Point(3, 3)
        Me.tlpGestionPrestamos.Name = "tlpGestionPrestamos"
        Me.tlpGestionPrestamos.RowCount = 1
        Me.tlpGestionPrestamos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGestionPrestamos.Size = New System.Drawing.Size(794, 59)
        Me.tlpGestionPrestamos.TabIndex = 4
        '
        'bCrearPrestamo
        '
        Me.bCrearPrestamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.bCrearPrestamo.Image = CType(resources.GetObject("bCrearPrestamo.Image"), System.Drawing.Image)
        Me.bCrearPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCrearPrestamo.Location = New System.Drawing.Point(547, 3)
        Me.bCrearPrestamo.Name = "bCrearPrestamo"
        Me.bCrearPrestamo.Padding = New System.Windows.Forms.Padding(5)
        Me.bCrearPrestamo.Size = New System.Drawing.Size(97, 53)
        Me.bCrearPrestamo.TabIndex = 0
        Me.bCrearPrestamo.Text = "Añadir"
        Me.bCrearPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCrearPrestamo.UseVisualStyleBackColor = True
        '
        'lGestionPrestamos
        '
        Me.lGestionPrestamos.AutoSize = True
        Me.lGestionPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lGestionPrestamos.Location = New System.Drawing.Point(3, 0)
        Me.lGestionPrestamos.Name = "lGestionPrestamos"
        Me.lGestionPrestamos.Size = New System.Drawing.Size(391, 59)
        Me.lGestionPrestamos.TabIndex = 1
        Me.lGestionPrestamos.Text = "Gestion de prestamos"
        Me.lGestionPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPrestamos.Location = New System.Drawing.Point(83, 146)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.Size = New System.Drawing.Size(634, 222)
        Me.dgvPrestamos.TabIndex = 2
        '
        'tlpPaginacion
        '
        Me.tlpPaginacion.ColumnCount = 4
        Me.tlpPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPaginacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPaginacion.Controls.Add(Me.bAnterior, 1, 0)
        Me.tlpPaginacion.Controls.Add(Me.bSiguiente, 3, 0)
        Me.tlpPaginacion.Controls.Add(Me.lblPaginacion, 2, 0)
        Me.tlpPaginacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPaginacion.Location = New System.Drawing.Point(83, 374)
        Me.tlpPaginacion.Name = "tlpPaginacion"
        Me.tlpPaginacion.RowCount = 1
        Me.tlpPaginacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPaginacion.Size = New System.Drawing.Size(634, 44)
        Me.tlpPaginacion.TabIndex = 3
        '
        'bAnterior
        '
        Me.bAnterior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bAnterior.Location = New System.Drawing.Point(430, 3)
        Me.bAnterior.Name = "bAnterior"
        Me.bAnterior.Size = New System.Drawing.Size(75, 38)
        Me.bAnterior.TabIndex = 0
        Me.bAnterior.Text = "Anterior"
        Me.bAnterior.UseVisualStyleBackColor = True
        '
        'bSiguiente
        '
        Me.bSiguiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSiguiente.Location = New System.Drawing.Point(556, 3)
        Me.bSiguiente.Name = "bSiguiente"
        Me.bSiguiente.Size = New System.Drawing.Size(75, 38)
        Me.bSiguiente.TabIndex = 1
        Me.bSiguiente.Text = "Siguiente"
        Me.bSiguiente.UseVisualStyleBackColor = True
        '
        'lblPaginacion
        '
        Me.lblPaginacion.AutoSize = True
        Me.lblPaginacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPaginacion.Location = New System.Drawing.Point(511, 0)
        Me.lblPaginacion.Name = "lblPaginacion"
        Me.lblPaginacion.Size = New System.Drawing.Size(39, 44)
        Me.lblPaginacion.TabIndex = 2
        Me.lblPaginacion.Text = "Label2"
        Me.lblPaginacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpFiltro
        '
        Me.tlpFiltro.ColumnCount = 1
        Me.tlpFiltro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFiltro.Controls.Add(Me.chbDisponibles, 0, 0)
        Me.tlpFiltro.Controls.Add(Me.chbActivos, 0, 1)
        Me.tlpFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFiltro.Location = New System.Drawing.Point(83, 96)
        Me.tlpFiltro.Name = "tlpFiltro"
        Me.tlpFiltro.RowCount = 2
        Me.tlpFiltro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFiltro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFiltro.Size = New System.Drawing.Size(634, 44)
        Me.tlpFiltro.TabIndex = 5
        '
        'chbDisponibles
        '
        Me.chbDisponibles.AutoSize = True
        Me.chbDisponibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbDisponibles.Location = New System.Drawing.Point(3, 3)
        Me.chbDisponibles.Name = "chbDisponibles"
        Me.chbDisponibles.Size = New System.Drawing.Size(628, 16)
        Me.chbDisponibles.TabIndex = 0
        Me.chbDisponibles.Text = "Ver Prestamos devueltos"
        Me.chbDisponibles.UseVisualStyleBackColor = True
        '
        'chbActivos
        '
        Me.chbActivos.AutoSize = True
        Me.chbActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbActivos.Location = New System.Drawing.Point(3, 25)
        Me.chbActivos.Name = "chbActivos"
        Me.chbActivos.Size = New System.Drawing.Size(628, 16)
        Me.chbActivos.TabIndex = 1
        Me.chbActivos.Text = "Ver prestamos activos"
        Me.chbActivos.UseVisualStyleBackColor = True
        '
        'GestionPrestamoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpTabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionPrestamoForm"
        Me.Text = "GestionPrestamoForm"
        Me.tlpTabla.ResumeLayout(False)
        Me.tlpGestionPrestamos.ResumeLayout(False)
        Me.tlpGestionPrestamos.PerformLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPaginacion.ResumeLayout(False)
        Me.tlpPaginacion.PerformLayout()
        Me.tlpFiltro.ResumeLayout(False)
        Me.tlpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpTabla As TableLayoutPanel
    Friend WithEvents tlpGestionPrestamos As TableLayoutPanel
    Friend WithEvents bCrearPrestamo As Button
    Friend WithEvents lGestionPrestamos As Label
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents tlpPaginacion As TableLayoutPanel
    Friend WithEvents bAnterior As Button
    Friend WithEvents bSiguiente As Button
    Friend WithEvents lblPaginacion As Label
    Friend WithEvents tlpFiltro As TableLayoutPanel
    Friend WithEvents chbDisponibles As CheckBox
    Friend WithEvents chbActivos As CheckBox
End Class
