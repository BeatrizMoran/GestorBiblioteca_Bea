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
        Me.tlpHead = New System.Windows.Forms.TableLayoutPanel()
        Me.lId = New System.Windows.Forms.Label()
        Me.lTituloID = New System.Windows.Forms.Label()
        Me.lTitulo2 = New System.Windows.Forms.Label()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.tlpUsuario = New System.Windows.Forms.TableLayoutPanel()
        Me.lNumeroTotalPrestamos = New System.Windows.Forms.Label()
        Me.lNumeroPrestamos = New System.Windows.Forms.Label()
        Me.lTituloTelefono = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.lUltimoPrestamo = New System.Windows.Forms.Label()
        Me.rtbLibrosEnPrestamoActivo = New System.Windows.Forms.RichTextBox()
        Me.tlpLibro = New System.Windows.Forms.TableLayoutPanel()
        Me.lTituloSinopsis = New System.Windows.Forms.Label()
        Me.lAnyoPublicacion = New System.Windows.Forms.Label()
        Me.lTituloAnyo = New System.Windows.Forms.Label()
        Me.lEscritor = New System.Windows.Forms.Label()
        Me.lTituloEscritor = New System.Windows.Forms.Label()
        Me.rtbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.tlpPrestamo = New System.Windows.Forms.TableLayoutPanel()
        Me.lEstadoPrestamo = New System.Windows.Forms.Label()
        Me.lEstado = New System.Windows.Forms.Label()
        Me.lFechaFin = New System.Windows.Forms.Label()
        Me.lFechaDevolucion = New System.Windows.Forms.Label()
        Me.lFechaInicio = New System.Windows.Forms.Label()
        Me.lFechaInicioPrestamo = New System.Windows.Forms.Label()
        Me.lNombreUsuario = New System.Windows.Forms.Label()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.lTituloLibro = New System.Windows.Forms.Label()
        Me.lLibro = New System.Windows.Forms.Label()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.pSeparador1 = New System.Windows.Forms.Panel()
        Me.pSeparador2 = New System.Windows.Forms.Panel()
        Me.tlpPrincipal.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.tlpInformacion.SuspendLayout()
        Me.tlpHead.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpUsuario.SuspendLayout()
        Me.tlpLibro.SuspendLayout()
        Me.tlpPrestamo.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
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
        Me.tlpPrincipal.Size = New System.Drawing.Size(802, 616)
        Me.tlpPrincipal.TabIndex = 0
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.tlpInformacion)
        Me.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDatos.Location = New System.Drawing.Point(123, 64)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(555, 486)
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
        Me.tlpInformacion.Controls.Add(Me.tlpHead, 1, 1)
        Me.tlpInformacion.Controls.Add(Me.tlpUsuario, 1, 3)
        Me.tlpInformacion.Controls.Add(Me.tlpLibro, 1, 4)
        Me.tlpInformacion.Controls.Add(Me.tlpPrestamo, 1, 5)
        Me.tlpInformacion.Controls.Add(Me.tlpBotones, 1, 7)
        Me.tlpInformacion.Controls.Add(Me.pSeparador1, 1, 2)
        Me.tlpInformacion.Controls.Add(Me.pSeparador2, 1, 6)
        Me.tlpInformacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInformacion.Location = New System.Drawing.Point(3, 16)
        Me.tlpInformacion.Name = "tlpInformacion"
        Me.tlpInformacion.RowCount = 9
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29411!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706!))
        Me.tlpInformacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.tlpInformacion.Size = New System.Drawing.Size(549, 467)
        Me.tlpInformacion.TabIndex = 5
        '
        'tlpHead
        '
        Me.tlpHead.ColumnCount = 3
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpHead.Controls.Add(Me.lId, 2, 2)
        Me.tlpHead.Controls.Add(Me.lTituloID, 1, 2)
        Me.tlpHead.Controls.Add(Me.lTitulo2, 2, 1)
        Me.tlpHead.Controls.Add(Me.lTitulo, 1, 1)
        Me.tlpHead.Controls.Add(Me.pbImagen, 0, 0)
        Me.tlpHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHead.Location = New System.Drawing.Point(57, 29)
        Me.tlpHead.Name = "tlpHead"
        Me.tlpHead.RowCount = 4
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHead.Size = New System.Drawing.Size(433, 73)
        Me.tlpHead.TabIndex = 0
        '
        'lId
        '
        Me.lId.AutoSize = True
        Me.lId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lId.Location = New System.Drawing.Point(172, 44)
        Me.lId.Margin = New System.Windows.Forms.Padding(8)
        Me.lId.Name = "lId"
        Me.lId.Size = New System.Drawing.Size(253, 13)
        Me.lId.TabIndex = 7
        Me.lId.Text = "Label6"
        Me.lId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloID
        '
        Me.lTituloID.AutoSize = True
        Me.lTituloID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloID.Location = New System.Drawing.Point(123, 44)
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
        Me.lTitulo2.Location = New System.Drawing.Point(172, 15)
        Me.lTitulo2.Margin = New System.Windows.Forms.Padding(8)
        Me.lTitulo2.Name = "lTitulo2"
        Me.lTitulo2.Size = New System.Drawing.Size(253, 13)
        Me.lTitulo2.TabIndex = 5
        Me.lTitulo2.Text = "Label4"
        Me.lTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo.Location = New System.Drawing.Point(123, 15)
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
        Me.tlpHead.SetRowSpan(Me.pbImagen, 4)
        Me.pbImagen.Size = New System.Drawing.Size(109, 67)
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
        Me.tlpUsuario.Controls.Add(Me.lNumeroTotalPrestamos, 2, 1)
        Me.tlpUsuario.Controls.Add(Me.lNumeroPrestamos, 1, 1)
        Me.tlpUsuario.Controls.Add(Me.lTituloTelefono, 1, 0)
        Me.tlpUsuario.Controls.Add(Me.lTelefono, 2, 0)
        Me.tlpUsuario.Controls.Add(Me.lUltimoPrestamo, 1, 2)
        Me.tlpUsuario.Controls.Add(Me.rtbLibrosEnPrestamoActivo, 1, 3)
        Me.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUsuario.Location = New System.Drawing.Point(57, 134)
        Me.tlpUsuario.Name = "tlpUsuario"
        Me.tlpUsuario.RowCount = 4
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUsuario.Size = New System.Drawing.Size(433, 75)
        Me.tlpUsuario.TabIndex = 1
        Me.tlpUsuario.Visible = False
        '
        'lNumeroTotalPrestamos
        '
        Me.lNumeroTotalPrestamos.AutoSize = True
        Me.lNumeroTotalPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNumeroTotalPrestamos.Location = New System.Drawing.Point(200, 26)
        Me.lNumeroTotalPrestamos.Margin = New System.Windows.Forms.Padding(8)
        Me.lNumeroTotalPrestamos.Name = "lNumeroTotalPrestamos"
        Me.lNumeroTotalPrestamos.Size = New System.Drawing.Size(225, 2)
        Me.lNumeroTotalPrestamos.TabIndex = 3
        Me.lNumeroTotalPrestamos.Text = "Label5"
        Me.lNumeroTotalPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lNumeroPrestamos
        '
        Me.lNumeroPrestamos.AutoSize = True
        Me.lNumeroPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNumeroPrestamos.Location = New System.Drawing.Point(34, 26)
        Me.lNumeroPrestamos.Margin = New System.Windows.Forms.Padding(8)
        Me.lNumeroPrestamos.Name = "lNumeroPrestamos"
        Me.lNumeroPrestamos.Size = New System.Drawing.Size(150, 2)
        Me.lNumeroPrestamos.TabIndex = 2
        Me.lNumeroPrestamos.Text = "Numero total de prestamos: "
        Me.lNumeroPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloTelefono
        '
        Me.lTituloTelefono.AutoSize = True
        Me.lTituloTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloTelefono.Location = New System.Drawing.Point(34, 8)
        Me.lTituloTelefono.Margin = New System.Windows.Forms.Padding(8)
        Me.lTituloTelefono.Name = "lTituloTelefono"
        Me.lTituloTelefono.Size = New System.Drawing.Size(150, 2)
        Me.lTituloTelefono.TabIndex = 0
        Me.lTituloTelefono.Text = "Telefono: "
        Me.lTituloTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTelefono.Location = New System.Drawing.Point(200, 8)
        Me.lTelefono.Margin = New System.Windows.Forms.Padding(8)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(225, 2)
        Me.lTelefono.TabIndex = 1
        Me.lTelefono.Text = "xxxxxxxxx"
        Me.lTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lUltimoPrestamo
        '
        Me.lUltimoPrestamo.AutoSize = True
        Me.lUltimoPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lUltimoPrestamo.Location = New System.Drawing.Point(29, 36)
        Me.lUltimoPrestamo.Name = "lUltimoPrestamo"
        Me.lUltimoPrestamo.Size = New System.Drawing.Size(160, 18)
        Me.lUltimoPrestamo.TabIndex = 4
        Me.lUltimoPrestamo.Text = "Libros actualmente en prestamo:"
        Me.lUltimoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtbLibrosEnPrestamoActivo
        '
        Me.tlpUsuario.SetColumnSpan(Me.rtbLibrosEnPrestamoActivo, 2)
        Me.rtbLibrosEnPrestamoActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbLibrosEnPrestamoActivo.Location = New System.Drawing.Point(29, 57)
        Me.rtbLibrosEnPrestamoActivo.Name = "rtbLibrosEnPrestamoActivo"
        Me.rtbLibrosEnPrestamoActivo.Size = New System.Drawing.Size(401, 15)
        Me.rtbLibrosEnPrestamoActivo.TabIndex = 6
        Me.rtbLibrosEnPrestamoActivo.Text = ""
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
        Me.tlpLibro.Location = New System.Drawing.Point(57, 215)
        Me.tlpLibro.Name = "tlpLibro"
        Me.tlpLibro.RowCount = 3
        Me.tlpLibro.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLibro.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLibro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLibro.Size = New System.Drawing.Size(433, 75)
        Me.tlpLibro.TabIndex = 2
        Me.tlpLibro.Visible = False
        '
        'lTituloSinopsis
        '
        Me.lTituloSinopsis.AutoSize = True
        Me.lTituloSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloSinopsis.Location = New System.Drawing.Point(37, 26)
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
        Me.lAnyoPublicacion.Location = New System.Drawing.Point(121, 13)
        Me.lAnyoPublicacion.Name = "lAnyoPublicacion"
        Me.lAnyoPublicacion.Size = New System.Drawing.Size(309, 13)
        Me.lAnyoPublicacion.TabIndex = 4
        Me.lAnyoPublicacion.Text = "Label10"
        Me.lAnyoPublicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloAnyo
        '
        Me.lTituloAnyo.AutoSize = True
        Me.lTituloAnyo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloAnyo.Location = New System.Drawing.Point(37, 13)
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
        Me.lEscritor.Location = New System.Drawing.Point(121, 0)
        Me.lEscritor.Name = "lEscritor"
        Me.lEscritor.Size = New System.Drawing.Size(309, 13)
        Me.lEscritor.TabIndex = 2
        Me.lEscritor.Text = "Label8"
        Me.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloEscritor
        '
        Me.lTituloEscritor.AutoSize = True
        Me.lTituloEscritor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloEscritor.Location = New System.Drawing.Point(37, 0)
        Me.lTituloEscritor.Name = "lTituloEscritor"
        Me.lTituloEscritor.Size = New System.Drawing.Size(78, 13)
        Me.lTituloEscritor.TabIndex = 1
        Me.lTituloEscritor.Text = "Escritor"
        Me.lTituloEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtbSinopsis
        '
        Me.rtbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSinopsis.Enabled = False
        Me.rtbSinopsis.Location = New System.Drawing.Point(121, 29)
        Me.rtbSinopsis.Name = "rtbSinopsis"
        Me.rtbSinopsis.Size = New System.Drawing.Size(309, 43)
        Me.rtbSinopsis.TabIndex = 6
        Me.rtbSinopsis.Text = ""
        '
        'tlpPrestamo
        '
        Me.tlpPrestamo.ColumnCount = 3
        Me.tlpPrestamo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrestamo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPrestamo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpPrestamo.Controls.Add(Me.lEstadoPrestamo, 2, 4)
        Me.tlpPrestamo.Controls.Add(Me.lEstado, 1, 4)
        Me.tlpPrestamo.Controls.Add(Me.lFechaFin, 2, 3)
        Me.tlpPrestamo.Controls.Add(Me.lFechaDevolucion, 1, 3)
        Me.tlpPrestamo.Controls.Add(Me.lFechaInicio, 2, 2)
        Me.tlpPrestamo.Controls.Add(Me.lFechaInicioPrestamo, 1, 2)
        Me.tlpPrestamo.Controls.Add(Me.lNombreUsuario, 2, 1)
        Me.tlpPrestamo.Controls.Add(Me.lUsuario, 1, 1)
        Me.tlpPrestamo.Controls.Add(Me.lTituloLibro, 2, 0)
        Me.tlpPrestamo.Controls.Add(Me.lLibro, 1, 0)
        Me.tlpPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrestamo.Location = New System.Drawing.Point(57, 296)
        Me.tlpPrestamo.Name = "tlpPrestamo"
        Me.tlpPrestamo.RowCount = 5
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrestamo.Size = New System.Drawing.Size(433, 75)
        Me.tlpPrestamo.TabIndex = 3
        Me.tlpPrestamo.Visible = False
        '
        'lEstadoPrestamo
        '
        Me.lEstadoPrestamo.AutoSize = True
        Me.lEstadoPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEstadoPrestamo.Location = New System.Drawing.Point(165, 60)
        Me.lEstadoPrestamo.Name = "lEstadoPrestamo"
        Me.lEstadoPrestamo.Size = New System.Drawing.Size(265, 15)
        Me.lEstadoPrestamo.TabIndex = 10
        Me.lEstadoPrestamo.Text = "Label22"
        Me.lEstadoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lEstado
        '
        Me.lEstado.AutoSize = True
        Me.lEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEstado.Location = New System.Drawing.Point(33, 60)
        Me.lEstado.Name = "lEstado"
        Me.lEstado.Size = New System.Drawing.Size(126, 15)
        Me.lEstado.TabIndex = 9
        Me.lEstado.Text = "Estado"
        Me.lEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lFechaFin
        '
        Me.lFechaFin.AutoSize = True
        Me.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaFin.Location = New System.Drawing.Point(165, 45)
        Me.lFechaFin.Name = "lFechaFin"
        Me.lFechaFin.Size = New System.Drawing.Size(265, 15)
        Me.lFechaFin.TabIndex = 8
        Me.lFechaFin.Text = "Label20"
        Me.lFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lFechaDevolucion
        '
        Me.lFechaDevolucion.AutoSize = True
        Me.lFechaDevolucion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaDevolucion.Location = New System.Drawing.Point(33, 45)
        Me.lFechaDevolucion.Name = "lFechaDevolucion"
        Me.lFechaDevolucion.Size = New System.Drawing.Size(126, 15)
        Me.lFechaDevolucion.TabIndex = 7
        Me.lFechaDevolucion.Text = "Fecha Fin de Devolucion"
        Me.lFechaDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lFechaInicio
        '
        Me.lFechaInicio.AutoSize = True
        Me.lFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaInicio.Location = New System.Drawing.Point(165, 30)
        Me.lFechaInicio.Name = "lFechaInicio"
        Me.lFechaInicio.Size = New System.Drawing.Size(265, 15)
        Me.lFechaInicio.TabIndex = 6
        Me.lFechaInicio.Text = "Label18"
        Me.lFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lFechaInicioPrestamo
        '
        Me.lFechaInicioPrestamo.AutoSize = True
        Me.lFechaInicioPrestamo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaInicioPrestamo.Location = New System.Drawing.Point(33, 30)
        Me.lFechaInicioPrestamo.Name = "lFechaInicioPrestamo"
        Me.lFechaInicioPrestamo.Size = New System.Drawing.Size(126, 15)
        Me.lFechaInicioPrestamo.TabIndex = 5
        Me.lFechaInicioPrestamo.Text = "Fecha Inicio Prestamo"
        Me.lFechaInicioPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lNombreUsuario
        '
        Me.lNombreUsuario.AutoSize = True
        Me.lNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombreUsuario.Location = New System.Drawing.Point(165, 15)
        Me.lNombreUsuario.Name = "lNombreUsuario"
        Me.lNombreUsuario.Size = New System.Drawing.Size(265, 15)
        Me.lNombreUsuario.TabIndex = 4
        Me.lNombreUsuario.Text = "Label16"
        Me.lNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lUsuario.Location = New System.Drawing.Point(33, 15)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(126, 15)
        Me.lUsuario.TabIndex = 3
        Me.lUsuario.Text = "Usuario"
        Me.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTituloLibro
        '
        Me.lTituloLibro.AutoSize = True
        Me.lTituloLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloLibro.Location = New System.Drawing.Point(165, 0)
        Me.lTituloLibro.Name = "lTituloLibro"
        Me.lTituloLibro.Size = New System.Drawing.Size(265, 15)
        Me.lTituloLibro.TabIndex = 2
        Me.lTituloLibro.Text = "Label14"
        Me.lTituloLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lLibro
        '
        Me.lLibro.AutoSize = True
        Me.lLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lLibro.Location = New System.Drawing.Point(33, 0)
        Me.lLibro.Name = "lLibro"
        Me.lLibro.Size = New System.Drawing.Size(126, 15)
        Me.lLibro.TabIndex = 1
        Me.lLibro.Text = "Libro"
        Me.lLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 2
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.Controls.Add(Me.bBorrar, 1, 0)
        Me.tlpBotones.Controls.Add(Me.bSalir, 0, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(57, 403)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(433, 33)
        Me.tlpBotones.TabIndex = 4
        '
        'bBorrar
        '
        Me.bBorrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bBorrar.Location = New System.Drawing.Point(219, 3)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(211, 27)
        Me.bBorrar.TabIndex = 1
        Me.bBorrar.Text = "Borrar"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSalir.Location = New System.Drawing.Point(3, 3)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(210, 27)
        Me.bSalir.TabIndex = 0
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'pSeparador1
        '
        Me.pSeparador1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pSeparador1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSeparador1.Location = New System.Drawing.Point(57, 108)
        Me.pSeparador1.Name = "pSeparador1"
        Me.pSeparador1.Size = New System.Drawing.Size(433, 13)
        Me.pSeparador1.TabIndex = 5
        '
        'pSeparador2
        '
        Me.pSeparador2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pSeparador2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pSeparador2.Location = New System.Drawing.Point(57, 384)
        Me.pSeparador2.Name = "pSeparador2"
        Me.pSeparador2.Size = New System.Drawing.Size(433, 13)
        Me.pSeparador2.TabIndex = 6
        '
        'InformacionUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 616)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(802, 616)
        Me.Name = "InformacionUsuarioForm"
        Me.Text = "InformacionUsuarioForm"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.tlpInformacion.ResumeLayout(False)
        Me.tlpHead.ResumeLayout(False)
        Me.tlpHead.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpUsuario.ResumeLayout(False)
        Me.tlpUsuario.PerformLayout()
        Me.tlpLibro.ResumeLayout(False)
        Me.tlpLibro.PerformLayout()
        Me.tlpPrestamo.ResumeLayout(False)
        Me.tlpPrestamo.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents tlpInformacion As TableLayoutPanel
    Friend WithEvents tlpHead As TableLayoutPanel
    Friend WithEvents lId As Label
    Friend WithEvents lTituloID As Label
    Friend WithEvents lTitulo2 As Label
    Friend WithEvents lTitulo As Label
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents tlpUsuario As TableLayoutPanel
    Friend WithEvents lNumeroTotalPrestamos As Label
    Friend WithEvents lNumeroPrestamos As Label
    Friend WithEvents lTituloTelefono As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents tlpLibro As TableLayoutPanel
    Friend WithEvents lTituloSinopsis As Label
    Friend WithEvents lAnyoPublicacion As Label
    Friend WithEvents lTituloAnyo As Label
    Friend WithEvents lEscritor As Label
    Friend WithEvents lTituloEscritor As Label
    Friend WithEvents tlpPrestamo As TableLayoutPanel
    Friend WithEvents lEstadoPrestamo As Label
    Friend WithEvents lEstado As Label
    Friend WithEvents lFechaFin As Label
    Friend WithEvents lFechaDevolucion As Label
    Friend WithEvents lFechaInicio As Label
    Friend WithEvents lFechaInicioPrestamo As Label
    Friend WithEvents lNombreUsuario As Label
    Friend WithEvents lUsuario As Label
    Friend WithEvents lTituloLibro As Label
    Friend WithEvents lLibro As Label
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bBorrar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents pSeparador1 As Panel
    Friend WithEvents pSeparador2 As Panel
    Friend WithEvents rtbSinopsis As RichTextBox
    Friend WithEvents lUltimoPrestamo As Label
    Friend WithEvents rtbLibrosEnPrestamoActivo As RichTextBox
End Class
