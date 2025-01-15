Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class GestionLibroForm
    Dim mostrado As Boolean = False
    Private fuenteActual As Font = New Font("Microsoft Sans Serif", 8) ' Tamaño inicial predeterminado

    Dim controlador As New LibroController
    Private Sub GestionLibroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCrearLibro.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

    End Sub

    Public Function CargarLibros()
        Try
            ' Obtener la lista de DTOs desde el controlador
            Dim libros As List(Of LibroDTO) = controlador.ObtenerLibros()

            ' Limpiar el panel antes de cargar los nuevos controles
            panelLibros.Controls.Clear()

            ' Configurar el TableLayoutPanel para organizar los controles en filas y columnas
            Dim layout As New TableLayoutPanel()
            layout.Dock = DockStyle.Top ' Para evitar que ocupe todo el espacio vertical
            layout.AutoSize = True
            layout.AutoSizeMode = AutoSizeMode.GrowAndShrink
            layout.ColumnCount = 2 ' Número de columnas

            ' Ajustar el estilo de las columnas para que ocupen tamaños uniformes
            For i As Integer = 0 To layout.ColumnCount - 1
                layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F)) ' Dividir espacio en columnas iguales
            Next

            ' Ajustar el estilo de las filas para que se adapten automáticamente al contenido
            Dim rowCount As Integer = Math.Ceiling(libros.Count / layout.ColumnCount)
            For i As Integer = 0 To rowCount - 1
                layout.RowStyles.Add(New RowStyle(SizeType.AutoSize)) ' Tamaño ajustado automáticamente
            Next

            ' Crear controles para cada libro y configurarlos con los datos del DTO
            Dim row As Integer = 0
            Dim col As Integer = 0
            For Each libroDTO In libros
                ' Crear una instancia del control para cada libro
                Dim libroControl As New LibroControl()

                ' Configurar el control con los datos del DTO
                libroControl.Titulo = libroDTO.Titulo
                libroControl.Escritor = libroDTO.Escritor
                libroControl.AnyoEdicion = libroDTO.AnyoEdicion
                libroControl.Dock = DockStyle.Fill



                ' Agregar eventos para los botones de acción
                AddHandler libroControl.ClickEditar, Sub()
                                                         LibroControl_ClickEditar(libroDTO.Id)
                                                     End Sub

                AddHandler libroControl.ClickInformacion, Sub()
                                                              LibroControl_ClickInformacion(libroDTO.Id)
                                                          End Sub

                AddHandler libroControl.ClickBorrar, Sub()
                                                         LibroControl_ClickBorrar(libroDTO.Id)
                                                     End Sub

                ' Agregar el control a la posición correspondiente en la cuadrícula
                layout.Controls.Add(libroControl, col, row)

                ' Actualizar las posiciones de fila y columna
                col += 1
                If col >= layout.ColumnCount Then
                    col = 0
                    row += 1
                End If
            Next

            ' Agregar el TableLayoutPanel al panel principal
            panelLibros.Controls.Add(layout)
        Catch ex As Exception
            ' Manejo de errores en caso de que algo falle al cargar los libros
            MessageBox.Show("Error al cargar los libros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Sub LibroControl_ClickEditar(id As Integer)
        MessageBox.Show("Editar libro con id: " & id)
    End Sub

    ' Manejo del evento Ver
    Private Sub LibroControl_ClickInformacion(id As Integer)

    End Sub

    ' Manejo del evento Borrar
    Private Sub LibroControl_ClickBorrar(id As Integer)

    End Sub

    Private Sub GestionLibroForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CType(Me.MdiParent, Form1).OcultarMostrarBotonVolver()

        mostrado = True
    End Sub

    Private Sub GestionLibroForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            Const MAX_FONTSIZE As Integer = 10
            Const MIN_FONTSIZE As Integer = 8 ' Tamaño mínimo de fuente para evitar fuentes demasiado pequeñas

            ' Calcular el tamaño proporcional de la fuente basado en ancho y alto
            Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width
            Dim proporciónAlto As Double = Me.Height / Me.MinimumSize.Height
            Dim proporciónPromedio As Double = (proporciónAncho + proporciónAlto) / 2

            ' Determinar el tamaño de la fuente dentro de los límites
            Dim fontSize As Integer = Math.Max(Math.Min(CInt(proporciónPromedio * MIN_FONTSIZE), MAX_FONTSIZE), MIN_FONTSIZE)

            ' Actualizar la variable global con la nueva fuente
            fuenteActual = New Font("Microsoft Sans Serif", fontSize)

            ' Actualizar las fuentes de los controles en el TableLayoutPanel
            For Each control As Control In tlpLibros.Controls
                control.Font = fuenteActual
            Next

            For Each control As Control In tlpTitulo.Controls
                control.Font = fuenteActual
            Next



        End If
    End Sub


End Class