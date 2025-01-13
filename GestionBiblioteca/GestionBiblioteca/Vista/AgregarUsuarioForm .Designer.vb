<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarUsuarioForm
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
        Me.tlpFormulario = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.lTexto = New System.Windows.Forms.Label()
        Me.liTelefono = New ControlesBiblioteca.LabelledInput()
        Me.liApellido2 = New ControlesBiblioteca.LabelledInput()
        Me.liApellido1 = New ControlesBiblioteca.LabelledInput()
        Me.liNombre = New ControlesBiblioteca.LabelledInput()
        Me.tlpFormulario.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFormulario
        '
        Me.tlpFormulario.ColumnCount = 1
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFormulario.Controls.Add(Me.liTelefono, 0, 4)
        Me.tlpFormulario.Controls.Add(Me.liApellido2, 0, 3)
        Me.tlpFormulario.Controls.Add(Me.liApellido1, 0, 2)
        Me.tlpFormulario.Controls.Add(Me.tlpBotones, 0, 5)
        Me.tlpFormulario.Controls.Add(Me.liNombre, 0, 1)
        Me.tlpFormulario.Controls.Add(Me.lTexto, 0, 0)
        Me.tlpFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFormulario.Location = New System.Drawing.Point(0, 0)
        Me.tlpFormulario.Name = "tlpFormulario"
        Me.tlpFormulario.RowCount = 6
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFormulario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFormulario.Size = New System.Drawing.Size(800, 450)
        Me.tlpFormulario.TabIndex = 0
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 2
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.Controls.Add(Me.bAceptar, 0, 0)
        Me.tlpBotones.Controls.Add(Me.bCancelar, 1, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpBotones.Location = New System.Drawing.Point(3, 364)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(794, 83)
        Me.tlpBotones.TabIndex = 2
        '
        'bAceptar
        '
        Me.bAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bAceptar.Location = New System.Drawing.Point(3, 3)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(391, 77)
        Me.bAceptar.TabIndex = 0
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(400, 3)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(391, 77)
        Me.bCancelar.TabIndex = 1
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'lTexto
        '
        Me.lTexto.AutoSize = True
        Me.lTexto.Location = New System.Drawing.Point(3, 0)
        Me.lTexto.Name = "lTexto"
        Me.lTexto.Size = New System.Drawing.Size(137, 13)
        Me.lTexto.TabIndex = 3
        Me.lTexto.Text = "CREAR NUEVO USUARIO"
        '
        'liTelefono
        '
        Me.liTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liTelefono.InputText = "Escribe aquí"
        Me.liTelefono.Location = New System.Drawing.Point(3, 277)
        Me.liTelefono.Name = "liTelefono"
        Me.liTelefono.Placeholder = "Escribe aquí"
        Me.liTelefono.Size = New System.Drawing.Size(794, 81)
        Me.liTelefono.TabIndex = 6
        Me.liTelefono.TextboxBackColor = System.Drawing.Color.White
        Me.liTelefono.TextboxForeColor = System.Drawing.Color.Black
        Me.liTelefono.Titulo = "Telefono"
        Me.liTelefono.TituloColor = System.Drawing.Color.Black
        '
        'liApellido2
        '
        Me.liApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liApellido2.InputText = "Escribe aquí"
        Me.liApellido2.Location = New System.Drawing.Point(3, 190)
        Me.liApellido2.Name = "liApellido2"
        Me.liApellido2.Placeholder = "Escribe aquí"
        Me.liApellido2.Size = New System.Drawing.Size(794, 81)
        Me.liApellido2.TabIndex = 5
        Me.liApellido2.TextboxBackColor = System.Drawing.Color.White
        Me.liApellido2.TextboxForeColor = System.Drawing.Color.Black
        Me.liApellido2.Titulo = "Apellido2"
        Me.liApellido2.TituloColor = System.Drawing.Color.Black
        '
        'liApellido1
        '
        Me.liApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liApellido1.InputText = "Escribe aquí"
        Me.liApellido1.Location = New System.Drawing.Point(3, 103)
        Me.liApellido1.Name = "liApellido1"
        Me.liApellido1.Placeholder = "Escribe aquí"
        Me.liApellido1.Size = New System.Drawing.Size(794, 81)
        Me.liApellido1.TabIndex = 4
        Me.liApellido1.TextboxBackColor = System.Drawing.Color.White
        Me.liApellido1.TextboxForeColor = System.Drawing.Color.Black
        Me.liApellido1.Titulo = "Apellido1"
        Me.liApellido1.TituloColor = System.Drawing.Color.Black
        '
        'liNombre
        '
        Me.liNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liNombre.InputText = "Escribe aquí"
        Me.liNombre.Location = New System.Drawing.Point(3, 16)
        Me.liNombre.Name = "liNombre"
        Me.liNombre.Placeholder = "Escribe aquí"
        Me.liNombre.Size = New System.Drawing.Size(794, 81)
        Me.liNombre.TabIndex = 0
        Me.liNombre.TextboxBackColor = System.Drawing.Color.White
        Me.liNombre.TextboxForeColor = System.Drawing.Color.Black
        Me.liNombre.Titulo = "Nombre"
        Me.liNombre.TituloColor = System.Drawing.Color.Black
        '
        'AgregarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpFormulario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarUsuarioForm"
        Me.Text = "AgregarUsuarioForm"
        Me.tlpFormulario.ResumeLayout(False)
        Me.tlpFormulario.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFormulario As TableLayoutPanel
    Friend WithEvents liTelefono As ControlesBiblioteca.LabelledInput
    Friend WithEvents liApellido2 As ControlesBiblioteca.LabelledInput
    Friend WithEvents liApellido1 As ControlesBiblioteca.LabelledInput
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents liNombre As ControlesBiblioteca.LabelledInput
    Friend WithEvents lTexto As Label
End Class
