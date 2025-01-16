<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLibroForm
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
        Me.gbCrearEditarLibro = New System.Windows.Forms.GroupBox()
        Me.tlpFormulario = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.liEscritor = New ControlesBiblioteca.LabelledInput()
        Me.liAnyoEdicion = New ControlesBiblioteca.LabelledInput()
        Me.liTitulo = New ControlesBiblioteca.LabelledInput()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rtbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.lSinopsis = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        Me.gbCrearEditarLibro.SuspendLayout()
        Me.tlpFormulario.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 3
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.Controls.Add(Me.gbCrearEditarLibro, 1, 1)
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
        'gbCrearEditarLibro
        '
        Me.gbCrearEditarLibro.Controls.Add(Me.tlpFormulario)
        Me.gbCrearEditarLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbCrearEditarLibro.Location = New System.Drawing.Point(123, 48)
        Me.gbCrearEditarLibro.Name = "gbCrearEditarLibro"
        Me.gbCrearEditarLibro.Size = New System.Drawing.Size(554, 354)
        Me.gbCrearEditarLibro.TabIndex = 8
        Me.gbCrearEditarLibro.TabStop = False
        Me.gbCrearEditarLibro.Text = "Crear Nuevo Libro"
        '
        'tlpFormulario
        '
        Me.tlpFormulario.ColumnCount = 3
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpFormulario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFormulario.Controls.Add(Me.tlpBotones, 1, 5)
        Me.tlpFormulario.Controls.Add(Me.liEscritor, 1, 2)
        Me.tlpFormulario.Controls.Add(Me.liAnyoEdicion, 1, 3)
        Me.tlpFormulario.Controls.Add(Me.liTitulo, 1, 1)
        Me.tlpFormulario.Controls.Add(Me.TableLayoutPanel1, 1, 4)
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
        'liEscritor
        '
        Me.liEscritor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liEscritor.InputText = "Escribe aquí"
        Me.liEscritor.Location = New System.Drawing.Point(57, 96)
        Me.liEscritor.Name = "liEscritor"
        Me.liEscritor.Placeholder = "Escribe aquí"
        Me.liEscritor.Size = New System.Drawing.Size(432, 54)
        Me.liEscritor.TabIndex = 9
        Me.liEscritor.TextboxBackColor = System.Drawing.Color.White
        Me.liEscritor.TextboxForeColor = System.Drawing.Color.Black
        Me.liEscritor.Titulo = "Escritor"
        Me.liEscritor.TituloColor = System.Drawing.Color.Black
        '
        'liAnyoEdicion
        '
        Me.liAnyoEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liAnyoEdicion.InputText = "Escribe aquí"
        Me.liAnyoEdicion.Location = New System.Drawing.Point(57, 156)
        Me.liAnyoEdicion.Name = "liAnyoEdicion"
        Me.liAnyoEdicion.Placeholder = "Escribe aquí"
        Me.liAnyoEdicion.Size = New System.Drawing.Size(432, 54)
        Me.liAnyoEdicion.TabIndex = 10
        Me.liAnyoEdicion.TextboxBackColor = System.Drawing.Color.White
        Me.liAnyoEdicion.TextboxForeColor = System.Drawing.Color.Black
        Me.liAnyoEdicion.Titulo = "Año Edicion"
        Me.liAnyoEdicion.TituloColor = System.Drawing.Color.Black
        '
        'liTitulo
        '
        Me.liTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.liTitulo.InputText = "Escribe aquí"
        Me.liTitulo.Location = New System.Drawing.Point(57, 36)
        Me.liTitulo.Name = "liTitulo"
        Me.liTitulo.Placeholder = "Escribe aquí"
        Me.liTitulo.Size = New System.Drawing.Size(432, 54)
        Me.liTitulo.TabIndex = 7
        Me.liTitulo.TextboxBackColor = System.Drawing.Color.White
        Me.liTitulo.TextboxForeColor = System.Drawing.Color.Black
        Me.liTitulo.Titulo = "Titulo"
        Me.liTitulo.TituloColor = System.Drawing.Color.Black
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rtbSinopsis, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lSinopsis, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(57, 216)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(432, 54)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'rtbSinopsis
        '
        Me.rtbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSinopsis.Location = New System.Drawing.Point(3, 30)
        Me.rtbSinopsis.Name = "rtbSinopsis"
        Me.rtbSinopsis.Size = New System.Drawing.Size(426, 21)
        Me.rtbSinopsis.TabIndex = 15
        Me.rtbSinopsis.Text = ""
        '
        'lSinopsis
        '
        Me.lSinopsis.AutoSize = True
        Me.lSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lSinopsis.Location = New System.Drawing.Point(3, 0)
        Me.lSinopsis.Name = "lSinopsis"
        Me.lSinopsis.Size = New System.Drawing.Size(426, 27)
        Me.lSinopsis.TabIndex = 16
        Me.lSinopsis.Text = "Sinopsis"
        Me.lSinopsis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AgregarLibroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarLibroForm"
        Me.Text = "AgregarLibroForm"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.gbCrearEditarLibro.ResumeLayout(False)
        Me.tlpFormulario.ResumeLayout(False)
        Me.tlpBotones.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents gbCrearEditarLibro As GroupBox
    Friend WithEvents tlpFormulario As TableLayoutPanel
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bAceptar As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents liEscritor As ControlesBiblioteca.LabelledInput
    Friend WithEvents liAnyoEdicion As ControlesBiblioteca.LabelledInput
    Friend WithEvents liTitulo As ControlesBiblioteca.LabelledInput
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rtbSinopsis As RichTextBox
    Friend WithEvents lSinopsis As Label
End Class
