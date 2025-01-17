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
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.liApellido1 = New ControlesBiblioteca.LabelledInput()
        Me.liEstado = New ControlesBiblioteca.LabelledInput()
        Me.liApellido2 = New ControlesBiblioteca.LabelledInput()
        Me.liNombre = New ControlesBiblioteca.LabelledInput()
        Me.tlpPrincipal.SuspendLayout()
        Me.gbCrearUsuario.SuspendLayout()
        Me.tlpFormulario.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
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
        Me.tlpFormulario.Controls.Add(Me.tlpBotones, 1, 5)
        Me.tlpFormulario.Controls.Add(Me.liApellido1, 1, 2)
        Me.tlpFormulario.Controls.Add(Me.liEstado, 1, 4)
        Me.tlpFormulario.Controls.Add(Me.liApellido2, 1, 3)
        Me.tlpFormulario.Controls.Add(Me.liNombre, 1, 1)
        Me.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFormulario.Location = New System.Drawing.Point(3, 16)
        Me.tlpFormulario.Name = "tlpFormulario"
        Me.tlpFormulario.RowCount = 7
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFormulario.Size = New System.Drawing.Size(548, 335)
        Me.tlpFormulario.TabIndex = 12
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 2
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.Controls.Add(Me.bAceptar, 0, 0)
        Me.tlpBotones.Controls.Add(Me.bCancelar, 1, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(57, 276)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(432, 20)
        Me.tlpBotones.TabIndex = 12
        '
        'bAceptar
        '
        Me.bAceptar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAceptar.Location = New System.Drawing.Point(3, 3)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(210, 14)
        Me.bAceptar.TabIndex = 0
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bCancelar.Location = New System.Drawing.Point(219, 3)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(210, 14)
        Me.bCancelar.TabIndex = 1
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'liApellido1
        '
        Me.liApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liApellido1.InputText = "Escribe aquí"
        Me.liApellido1.Location = New System.Drawing.Point(57, 96)
        Me.liApellido1.Name = "liApellido1"
        Me.liApellido1.Placeholder = "Escribe aquí"
        Me.liApellido1.Size = New System.Drawing.Size(432, 54)
        Me.liApellido1.TabIndex = 9
        Me.liApellido1.TextboxBackColor = System.Drawing.Color.White
        Me.liApellido1.TextboxForeColor = System.Drawing.Color.Black
        Me.liApellido1.Titulo = "Apellido1"
        Me.liApellido1.TituloColor = System.Drawing.Color.Black
        '
        'liEstado
        '
        Me.liEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liEstado.InputText = "Escribe aquí"
        Me.liEstado.Location = New System.Drawing.Point(57, 216)
        Me.liEstado.Name = "liEstado"
        Me.liEstado.Placeholder = "Escribe aquí"
        Me.liEstado.Size = New System.Drawing.Size(432, 54)
        Me.liEstado.TabIndex = 11
        Me.liEstado.TextboxBackColor = System.Drawing.Color.White
        Me.liEstado.TextboxForeColor = System.Drawing.Color.Black
        Me.liEstado.Titulo = "Estado"
        Me.liEstado.TituloColor = System.Drawing.Color.Black
        '
        'liApellido2
        '
        Me.liApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liApellido2.InputText = "Escribe aquí"
        Me.liApellido2.Location = New System.Drawing.Point(57, 156)
        Me.liApellido2.Name = "liApellido2"
        Me.liApellido2.Placeholder = "Escribe aquí"
        Me.liApellido2.Size = New System.Drawing.Size(432, 54)
        Me.liApellido2.TabIndex = 10
        Me.liApellido2.TextboxBackColor = System.Drawing.Color.White
        Me.liApellido2.TextboxForeColor = System.Drawing.Color.Black
        Me.liApellido2.Titulo = "Apellido2"
        Me.liApellido2.TituloColor = System.Drawing.Color.Black
        '
        'liNombre
        '
        Me.liNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liNombre.InputText = "Escribe aquí"
        Me.liNombre.Location = New System.Drawing.Point(57, 36)
        Me.liNombre.Name = "liNombre"
        Me.liNombre.Placeholder = "Escribe aquí"
        Me.liNombre.Size = New System.Drawing.Size(432, 54)
        Me.liNombre.TabIndex = 7
        Me.liNombre.TextboxBackColor = System.Drawing.Color.White
        Me.liNombre.TextboxForeColor = System.Drawing.Color.Black
        Me.liNombre.Titulo = "Nombre"
        Me.liNombre.TituloColor = System.Drawing.Color.Black
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
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents gbCrearUsuario As GroupBox
    Friend WithEvents tlpFormulario As TableLayoutPanel
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents liApellido1 As ControlesBiblioteca.LabelledInput
    Friend WithEvents liEstado As ControlesBiblioteca.LabelledInput
    Friend WithEvents liApellido2 As ControlesBiblioteca.LabelledInput
    Friend WithEvents liNombre As ControlesBiblioteca.LabelledInput
End Class
