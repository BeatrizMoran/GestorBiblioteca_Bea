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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelledInput1 = New ControlesBiblioteca.LabelledInput()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.lTexto = New System.Windows.Forms.Label()
        Me.LabelledInput2 = New ControlesBiblioteca.LabelledInput()
        Me.LabelledInput3 = New ControlesBiblioteca.LabelledInput()
        Me.LabelledInput4 = New ControlesBiblioteca.LabelledInput()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelledInput4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelledInput3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelledInput2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpBotones, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelledInput1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lTexto, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelledInput1
        '
        Me.LabelledInput1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelledInput1.Location = New System.Drawing.Point(3, 16)
        Me.LabelledInput1.Name = "LabelledInput1"
        Me.LabelledInput1.Placeholder = "Escribe aquí"
        Me.LabelledInput1.Size = New System.Drawing.Size(794, 81)
        Me.LabelledInput1.TabIndex = 0
        Me.LabelledInput1.TextboxBackColor = System.Drawing.Color.White
        Me.LabelledInput1.TextboxForeColor = System.Drawing.Color.Black
        Me.LabelledInput1.Titulo = "Titulo"
        Me.LabelledInput1.TituloColor = System.Drawing.Color.Black
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
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(400, 3)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(391, 77)
        Me.bCancelar.TabIndex = 1
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
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
        'lTexto
        '
        Me.lTexto.AutoSize = True
        Me.lTexto.Location = New System.Drawing.Point(3, 0)
        Me.lTexto.Name = "lTexto"
        Me.lTexto.Size = New System.Drawing.Size(137, 13)
        Me.lTexto.TabIndex = 3
        Me.lTexto.Text = "CREAR NUEVO USUARIO"
        '
        'LabelledInput2
        '
        Me.LabelledInput2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelledInput2.Location = New System.Drawing.Point(3, 103)
        Me.LabelledInput2.Name = "LabelledInput2"
        Me.LabelledInput2.Placeholder = "Escribe aquí"
        Me.LabelledInput2.Size = New System.Drawing.Size(794, 81)
        Me.LabelledInput2.TabIndex = 4
        Me.LabelledInput2.TextboxBackColor = System.Drawing.Color.White
        Me.LabelledInput2.TextboxForeColor = System.Drawing.Color.Black
        Me.LabelledInput2.Titulo = "Titulo"
        Me.LabelledInput2.TituloColor = System.Drawing.Color.Black
        '
        'LabelledInput3
        '
        Me.LabelledInput3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelledInput3.Location = New System.Drawing.Point(3, 190)
        Me.LabelledInput3.Name = "LabelledInput3"
        Me.LabelledInput3.Placeholder = "Escribe aquí"
        Me.LabelledInput3.Size = New System.Drawing.Size(794, 81)
        Me.LabelledInput3.TabIndex = 5
        Me.LabelledInput3.TextboxBackColor = System.Drawing.Color.White
        Me.LabelledInput3.TextboxForeColor = System.Drawing.Color.Black
        Me.LabelledInput3.Titulo = "Titulo"
        Me.LabelledInput3.TituloColor = System.Drawing.Color.Black
        '
        'LabelledInput4
        '
        Me.LabelledInput4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelledInput4.Location = New System.Drawing.Point(3, 277)
        Me.LabelledInput4.Name = "LabelledInput4"
        Me.LabelledInput4.Placeholder = "Escribe aquí"
        Me.LabelledInput4.Size = New System.Drawing.Size(794, 81)
        Me.LabelledInput4.TabIndex = 6
        Me.LabelledInput4.TextboxBackColor = System.Drawing.Color.White
        Me.LabelledInput4.TextboxForeColor = System.Drawing.Color.Black
        Me.LabelledInput4.Titulo = "Titulo"
        Me.LabelledInput4.TituloColor = System.Drawing.Color.Black
        '
        'AgregarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarUsuarioForm"
        Me.Text = "AgregarUsuarioForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelledInput4 As ControlesBiblioteca.LabelledInput
    Friend WithEvents LabelledInput3 As ControlesBiblioteca.LabelledInput
    Friend WithEvents LabelledInput2 As ControlesBiblioteca.LabelledInput
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents LabelledInput1 As ControlesBiblioteca.LabelledInput
    Friend WithEvents lTexto As Label
End Class
