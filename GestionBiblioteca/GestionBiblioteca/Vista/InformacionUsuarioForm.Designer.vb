<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformacionUsuarioForm
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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.tlpInformacion = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lId = New System.Windows.Forms.Label()
        Me.lTituloID = New System.Windows.Forms.Label()
        Me.lTitulo2 = New System.Windows.Forms.Label()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.tlpUsuario = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lTituloTelefono = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.tlpLibro = New System.Windows.Forms.TableLayoutPanel()
        Me.lTituloSinopsis = New System.Windows.Forms.Label()
        Me.lAnyoPublicacion = New System.Windows.Forms.Label()
        Me.lTituloAnyo = New System.Windows.Forms.Label()
        Me.lEscritor = New System.Windows.Forms.Label()
        Me.lTituloEscritor = New System.Windows.Forms.Label()
        Me.tlpPrestamo = New System.Windows.Forms.TableLayoutPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rtbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.tlpPrincipal.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.tlpInformacion.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpUsuario.SuspendLayout()
        Me.tlpLibro.SuspendLayout()
        Me.tlpPrestamo.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 3
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.Controls.Add(Me.gbDatos, 1, 1)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(774, 540)
        Me.tlpPrincipal.TabIndex = 0
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.tlpInformacion)
        Me.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDatos.Location = New System.Drawing.Point(119, 57)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(535, 426)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos del Usuario"
        '
        'tlpInformacion
        '
        Me.tlpInformacion.ColumnCount = 3
        Me.tlpInformacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpInformacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpInformacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpInformacion.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.tlpInformacion.Controls.Add(Me.tlpUsuario, 1, 3)
        Me.tlpInformacion.Controls.Add(Me.tlpLibro, 1, 4)
        Me.tlpInformacion.Controls.Add(Me.tlpPrestamo, 1, 5)
        Me.tlpInformacion.Controls.Add(Me.TableLayoutPanel5, 1, 7)
        Me.tlpInformacion.Controls.Add(Me.Panel1, 1, 2)
        Me.tlpInformacion.Controls.Add(Me.Panel2, 1, 6)
        Me.tlpInformacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInformacion.Location = New System.Drawing.Point(3, 16)
        Me.tlpInformacion.Name = "tlpInformacion"
        Me.tlpInformacion.RowCount = 9
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.Size = New System.Drawing.Size(529, 407)
        Me.tlpInformacion.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lId, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lTituloID, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lTitulo2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lTitulo, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pbImagen, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(55, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(417, 51)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lId
        '
        Me.lId.AutoSize = True
        Me.lId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lId.Location = New System.Drawing.Point(167, 34)
        Me.lId.Margin = New System.Windows.Forms.Padding(8)
        Me.lId.Name = "lId"
        Me.lId.Size = New System.Drawing.Size(242, 13)
        Me.lId.TabIndex = 7
        Me.lId.Text = "Label6"
        Me.lId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloID
        '
        Me.lTituloID.AutoSize = True
        Me.lTituloID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloID.Location = New System.Drawing.Point(118, 34)
        Me.lTituloID.Margin = New System.Windows.Forms.Padding(8)
        Me.lTituloID.Name = "lTituloID"
        Me.lTituloID.Size = New System.Drawing.Size(33, 13)
        Me.lTituloID.TabIndex = 6
        Me.lTituloID.Text = "ID: "
        Me.lTituloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTitulo2
        '
        Me.lTitulo2.AutoSize = True
        Me.lTitulo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo2.Location = New System.Drawing.Point(167, 5)
        Me.lTitulo2.Margin = New System.Windows.Forms.Padding(8)
        Me.lTitulo2.Name = "lTitulo2"
        Me.lTitulo2.Size = New System.Drawing.Size(242, 13)
        Me.lTitulo2.TabIndex = 5
        Me.lTitulo2.Text = "Label4"
        Me.lTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo.Location = New System.Drawing.Point(118, 5)
        Me.lTitulo.Margin = New System.Windows.Forms.Padding(8)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(33, 13)
        Me.lTitulo.TabIndex = 4
        Me.lTitulo.Text = "Titulo"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.SystemColors.Control
        Me.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImagen.Location = New System.Drawing.Point(3, 3)
        Me.pbImagen.Name = "pbImagen"
        Me.TableLayoutPanel2.SetRowSpan(Me.pbImagen, 4)
        Me.pbImagen.Size = New System.Drawing.Size(104, 46)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'tlpUsuario
        '
        Me.tlpUsuario.ColumnCount = 3
        Me.tlpUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpUsuario.Controls.Add(Me.Label5, 2, 1)
        Me.tlpUsuario.Controls.Add(Me.Label3, 1, 1)
        Me.tlpUsuario.Controls.Add(Me.lTituloTelefono, 1, 0)
        Me.tlpUsuario.Controls.Add(Me.lTelefono, 2, 0)
        Me.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUsuario.Location = New System.Drawing.Point(55, 98)
        Me.tlpUsuario.Name = "tlpUsuario"
        Me.tlpUsuario.RowCount = 2
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUsuario.Size = New System.Drawing.Size(417, 75)
        Me.tlpUsuario.TabIndex = 1
        Me.tlpUsuario.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(113, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(42, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloTelefono
        '
        Me.lTituloTelefono.AutoSize = True
        Me.lTituloTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloTelefono.Location = New System.Drawing.Point(42, 8)
        Me.lTituloTelefono.Margin = New System.Windows.Forms.Padding(8)
        Me.lTituloTelefono.Name = "lTituloTelefono"
        Me.lTituloTelefono.Size = New System.Drawing.Size(55, 21)
        Me.lTituloTelefono.TabIndex = 0
        Me.lTituloTelefono.Text = "Telefono: "
        Me.lTituloTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTelefono.Location = New System.Drawing.Point(113, 8)
        Me.lTelefono.Margin = New System.Windows.Forms.Padding(8)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(296, 21)
        Me.lTelefono.TabIndex = 1
        Me.lTelefono.Text = "xxxxxxxxx"
        Me.lTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpLibro
        '
        Me.tlpLibro.ColumnCount = 3
        Me.tlpLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLibro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpLibro.Controls.Add(Me.lTituloSinopsis, 1, 2)
        Me.tlpLibro.Controls.Add(Me.lAnyoPublicacion, 2, 1)
        Me.tlpLibro.Controls.Add(Me.lTituloAnyo, 1, 1)
        Me.tlpLibro.Controls.Add(Me.lEscritor, 2, 0)
        Me.tlpLibro.Controls.Add(Me.lTituloEscritor, 1, 0)
        Me.tlpLibro.Controls.Add(Me.rtbSinopsis, 2, 2)
        Me.tlpLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLibro.Location = New System.Drawing.Point(55, 179)
        Me.tlpLibro.Name = "tlpLibro"
        Me.tlpLibro.RowCount = 3
        Me.tlpLibro.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLibro.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLibro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLibro.Size = New System.Drawing.Size(417, 75)
        Me.tlpLibro.TabIndex = 2
        Me.tlpLibro.Visible = False
        '
        'lTituloSinopsis
        '
        Me.lTituloSinopsis.AutoSize = True
        Me.lTituloSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloSinopsis.Location = New System.Drawing.Point(36, 26)
        Me.lTituloSinopsis.Name = "lTituloSinopsis"
        Me.lTituloSinopsis.Size = New System.Drawing.Size(78, 49)
        Me.lTituloSinopsis.TabIndex = 5
        Me.lTituloSinopsis.Text = "Sinopsis"
        Me.lTituloSinopsis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lAnyoPublicacion
        '
        Me.lAnyoPublicacion.AutoSize = True
        Me.lAnyoPublicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lAnyoPublicacion.Location = New System.Drawing.Point(120, 13)
        Me.lAnyoPublicacion.Name = "lAnyoPublicacion"
        Me.lAnyoPublicacion.Size = New System.Drawing.Size(294, 13)
        Me.lAnyoPublicacion.TabIndex = 4
        Me.lAnyoPublicacion.Text = "Label10"
        Me.lAnyoPublicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloAnyo
        '
        Me.lTituloAnyo.AutoSize = True
        Me.lTituloAnyo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloAnyo.Location = New System.Drawing.Point(36, 13)
        Me.lTituloAnyo.Name = "lTituloAnyo"
        Me.lTituloAnyo.Size = New System.Drawing.Size(78, 13)
        Me.lTituloAnyo.TabIndex = 3
        Me.lTituloAnyo.Text = "Año de edicion"
        Me.lTituloAnyo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lEscritor
        '
        Me.lEscritor.AutoSize = True
        Me.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEscritor.Location = New System.Drawing.Point(120, 0)
        Me.lEscritor.Name = "lEscritor"
        Me.lEscritor.Size = New System.Drawing.Size(294, 13)
        Me.lEscritor.TabIndex = 2
        Me.lEscritor.Text = "Label8"
        Me.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloEscritor
        '
        Me.lTituloEscritor.AutoSize = True
        Me.lTituloEscritor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloEscritor.Location = New System.Drawing.Point(36, 0)
        Me.lTituloEscritor.Name = "lTituloEscritor"
        Me.lTituloEscritor.Size = New System.Drawing.Size(78, 13)
        Me.lTituloEscritor.TabIndex = 1
        Me.lTituloEscritor.Text = "Escritor"
        Me.lTituloEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpPrestamo
        '
        Me.tlpPrestamo.ColumnCount = 3
        Me.tlpPrestamo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrestamo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrestamo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpPrestamo.Controls.Add(Me.Label22, 2, 4)
        Me.tlpPrestamo.Controls.Add(Me.Label21, 1, 4)
        Me.tlpPrestamo.Controls.Add(Me.Label20, 2, 3)
        Me.tlpPrestamo.Controls.Add(Me.Label19, 1, 3)
        Me.tlpPrestamo.Controls.Add(Me.Label18, 2, 2)
        Me.tlpPrestamo.Controls.Add(Me.Label17, 1, 2)
        Me.tlpPrestamo.Controls.Add(Me.Label16, 2, 1)
        Me.tlpPrestamo.Controls.Add(Me.Label15, 1, 1)
        Me.tlpPrestamo.Controls.Add(Me.Label14, 2, 0)
        Me.tlpPrestamo.Controls.Add(Me.Label13, 1, 0)
        Me.tlpPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrestamo.Location = New System.Drawing.Point(55, 260)
        Me.tlpPrestamo.Name = "tlpPrestamo"
        Me.tlpPrestamo.RowCount = 5
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.Size = New System.Drawing.Size(417, 75)
        Me.tlpPrestamo.TabIndex = 3
        Me.tlpPrestamo.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(90, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Label22"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(39, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Label21"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(90, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Label20"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(39, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(90, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Label18"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(39, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Label17"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(90, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(39, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Label15"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(90, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Label13"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.bBorrar, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.bSalir, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(55, 360)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(417, 22)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'bBorrar
        '
        Me.bBorrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bBorrar.Location = New System.Drawing.Point(211, 3)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(203, 16)
        Me.bBorrar.TabIndex = 1
        Me.bBorrar.Text = "Borrar"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSalir.Location = New System.Drawing.Point(3, 3)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(202, 16)
        Me.bSalir.TabIndex = 0
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(55, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 13)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(55, 341)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 13)
        Me.Panel2.TabIndex = 6
        '
        'rtbSinopsis
        '
        Me.rtbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSinopsis.Location = New System.Drawing.Point(120, 29)
        Me.rtbSinopsis.Name = "rtbSinopsis"
        Me.rtbSinopsis.Size = New System.Drawing.Size(294, 43)
        Me.rtbSinopsis.TabIndex = 6
        Me.rtbSinopsis.Text = ""
        '
        'InformacionUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 540)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InformacionUsuarioForm"
        Me.Text = "InformacionUsuarioForm"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.tlpInformacion.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpUsuario.ResumeLayout(False)
        Me.tlpUsuario.PerformLayout()
        Me.tlpLibro.ResumeLayout(False)
        Me.tlpLibro.PerformLayout()
        Me.tlpPrestamo.ResumeLayout(False)
        Me.tlpPrestamo.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents tlpInformacion As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lId As Label
    Friend WithEvents lTituloID As Label
    Friend WithEvents lTitulo2 As Label
    Friend WithEvents lTitulo As Label
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents tlpUsuario As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lTituloTelefono As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents tlpLibro As TableLayoutPanel
    Friend WithEvents lTituloSinopsis As Label
    Friend WithEvents lAnyoPublicacion As Label
    Friend WithEvents lTituloAnyo As Label
    Friend WithEvents lEscritor As Label
    Friend WithEvents lTituloEscritor As Label
    Friend WithEvents tlpPrestamo As TableLayoutPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents bBorrar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rtbSinopsis As RichTextBox
End Class
