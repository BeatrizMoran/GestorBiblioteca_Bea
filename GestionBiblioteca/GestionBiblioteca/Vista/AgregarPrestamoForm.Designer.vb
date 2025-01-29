<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPrestamoForm
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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.gbCrearUsuario = New System.Windows.Forms.GroupBox()
        Me.tlpFormulario = New System.Windows.Forms.TableLayoutPanel()
        Me.lLibro = New System.Windows.Forms.Label()
        Me.cbLibros = New System.Windows.Forms.ComboBox()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.lFechaInicio = New System.Windows.Forms.Label()
        Me.lFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.pEstado = New System.Windows.Forms.Panel()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.lEstado = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        Me.gbCrearUsuario.SuspendLayout()
        Me.tlpFormulario.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.pEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 3
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.Controls.Add(Me.gbCrearUsuario, 1, 1)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tlpPrincipal.TabIndex = 1
        '
        'gbCrearUsuario
        '
        Me.gbCrearUsuario.Controls.Add(Me.tlpFormulario)
        Me.gbCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbCrearUsuario.Location = New System.Drawing.Point(123, 48)
        Me.gbCrearUsuario.Name = "gbCrearUsuario"
        Me.gbCrearUsuario.Size = New System.Drawing.Size(554, 354)
        Me.gbCrearUsuario.TabIndex = 8
        Me.gbCrearUsuario.TabStop = False
        Me.gbCrearUsuario.Text = "Crear Nuevo Prestamo"
        '
        'tlpFormulario
        '
        Me.tlpFormulario.ColumnCount = 3
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFormulario.Controls.Add(Me.lLibro, 1, 1)
        Me.tlpFormulario.Controls.Add(Me.cbLibros, 1, 2)
        Me.tlpFormulario.Controls.Add(Me.lUsuario, 1, 3)
        Me.tlpFormulario.Controls.Add(Me.cbUsuarios, 1, 4)
        Me.tlpFormulario.Controls.Add(Me.tlpBotones, 1, 10)
        Me.tlpFormulario.Controls.Add(Me.lFechaInicio, 1, 5)
        Me.tlpFormulario.Controls.Add(Me.lFechaFin, 1, 7)
        Me.tlpFormulario.Controls.Add(Me.dtpFechaInicio, 1, 6)
        Me.tlpFormulario.Controls.Add(Me.dtpFechaFin, 1, 8)
        Me.tlpFormulario.Controls.Add(Me.pEstado, 1, 9)
        Me.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFormulario.Location = New System.Drawing.Point(3, 16)
        Me.tlpFormulario.Name = "tlpFormulario"
        Me.tlpFormulario.RowCount = 12
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.6849318!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.6849318!))
        Me.tlpFormulario.Size = New System.Drawing.Size(548, 335)
        Me.tlpFormulario.TabIndex = 12
        '
        'lLibro
        '
        Me.lLibro.AutoSize = True
        Me.lLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lLibro.Location = New System.Drawing.Point(57, 1)
        Me.lLibro.Name = "lLibro"
        Me.lLibro.Size = New System.Drawing.Size(432, 25)
        Me.lLibro.TabIndex = 20
        Me.lLibro.Text = "Libro:"
        Me.lLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbLibros
        '
        Me.cbLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbLibros.FormattingEnabled = True
        Me.cbLibros.Location = New System.Drawing.Point(57, 29)
        Me.cbLibros.Name = "cbLibros"
        Me.cbLibros.Size = New System.Drawing.Size(432, 21)
        Me.cbLibros.TabIndex = 18
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lUsuario.Location = New System.Drawing.Point(57, 51)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(432, 25)
        Me.lUsuario.TabIndex = 21
        Me.lUsuario.Text = "Usuario: "
        Me.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUsuarios
        '
        Me.cbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(57, 79)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(432, 21)
        Me.cbUsuarios.TabIndex = 19
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 2
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.Controls.Add(Me.bAceptar, 0, 0)
        Me.tlpBotones.Controls.Add(Me.bCancelar, 1, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(57, 310)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(432, 19)
        Me.tlpBotones.TabIndex = 12
        '
        'bAceptar
        '
        Me.bAceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAceptar.Location = New System.Drawing.Point(3, 3)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(210, 13)
        Me.bAceptar.TabIndex = 0
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bCancelar.Location = New System.Drawing.Point(219, 3)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(210, 13)
        Me.bCancelar.TabIndex = 1
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'lFechaInicio
        '
        Me.lFechaInicio.AutoSize = True
        Me.lFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaInicio.Location = New System.Drawing.Point(57, 101)
        Me.lFechaInicio.Name = "lFechaInicio"
        Me.lFechaInicio.Size = New System.Drawing.Size(432, 25)
        Me.lFechaInicio.TabIndex = 22
        Me.lFechaInicio.Text = "Fecha Inicio:"
        Me.lFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lFechaFin
        '
        Me.lFechaFin.AutoSize = True
        Me.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaFin.Location = New System.Drawing.Point(57, 151)
        Me.lFechaFin.Name = "lFechaFin"
        Me.lFechaFin.Size = New System.Drawing.Size(432, 25)
        Me.lFechaFin.TabIndex = 23
        Me.lFechaFin.Text = "Fecha Fin: "
        Me.lFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFechaInicio.Location = New System.Drawing.Point(57, 129)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(432, 20)
        Me.dtpFechaInicio.TabIndex = 24
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFechaFin.Location = New System.Drawing.Point(57, 179)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(432, 20)
        Me.dtpFechaFin.TabIndex = 25
        '
        'pEstado
        '
        Me.pEstado.Controls.Add(Me.cbEstado)
        Me.pEstado.Controls.Add(Me.lEstado)
        Me.pEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEstado.Location = New System.Drawing.Point(57, 204)
        Me.pEstado.Name = "pEstado"
        Me.pEstado.Size = New System.Drawing.Size(432, 100)
        Me.pEstado.TabIndex = 26
        '
        'cbEstado
        '
        Me.cbEstado.DisplayMember = "Disponible"
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(0, 26)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbEstado.TabIndex = 28
        Me.cbEstado.Text = "-- Estado --"
        Me.cbEstado.ValueMember = "1"
        '
        'lEstado
        '
        Me.lEstado.AutoSize = True
        Me.lEstado.BackColor = System.Drawing.SystemColors.Control
        Me.lEstado.Location = New System.Drawing.Point(3, 7)
        Me.lEstado.Name = "lEstado"
        Me.lEstado.Size = New System.Drawing.Size(40, 13)
        Me.lEstado.TabIndex = 29
        Me.lEstado.Text = "Estado"
        '
        'AgregarPrestamoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarPrestamoForm"
        Me.Text = "AgregarPrestamoForm"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.gbCrearUsuario.ResumeLayout(False)
        Me.tlpFormulario.ResumeLayout(False)
        Me.tlpFormulario.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.pEstado.ResumeLayout(False)
        Me.pEstado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents gbCrearUsuario As GroupBox
    Friend WithEvents tlpFormulario As TableLayoutPanel
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents lLibro As Label
    Friend WithEvents cbLibros As ComboBox
    Friend WithEvents lUsuario As Label
    Friend WithEvents cbUsuarios As ComboBox
    Friend WithEvents lFechaInicio As Label
    Friend WithEvents lFechaFin As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents pEstado As Panel
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents lEstado As Label
End Class
