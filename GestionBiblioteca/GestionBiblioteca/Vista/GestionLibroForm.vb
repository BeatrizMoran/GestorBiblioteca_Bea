Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class GestionLibroForm
    Dim mostrado As Boolean = False

    Dim controlador As New LibroController


    Private Sub GestionLibroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCrearLibro.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

    End Sub



    Public Function CargarLibros()
        Try
            Dim layout As New TableLayoutPanel()

            Dim libros As List(Of LibroDTO) = controlador.ObtenerLibros()

            panelLibros.Controls.Clear()

            Layout.Dock = DockStyle.Top ' Para evitar que ocupe todo el espacio vertical
            Layout.AutoSize = True
            Layout.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Layout.ColumnCount = 1 ' Número de columnas

            ' Ajustar el estilo de las columnas para que ocupen tamaños uniformes
            For i As Integer = 0 To Layout.ColumnCount - 1
                Layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F)) ' Dividir espacio en columnas iguales
            Next

            ' Ajustar el estilo de las filas para que se adapten automáticamente al contenido
            Dim rowCount As Integer = Math.Ceiling(libros.Count / Layout.ColumnCount)
            For i As Integer = 0 To rowCount - 1
                Layout.RowStyles.Add(New RowStyle(SizeType.AutoSize)) ' Tamaño ajustado automáticamente
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
                If libroDTO.Disponible = True Then
                    libroControl.Estado = "Disponible"
                Else
                    libroControl.Estado = "En prestamo"
                End If
                libroControl.Dock = DockStyle.Fill

                ' Deshabilitar el evento temporalmente antes de actualizar el estado

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
                If col >= Layout.ColumnCount Then
                    col = 0
                    row += 1
                End If
            Next

            ' Agregar el TableLayoutPanel al panel principal
            panelLibros.Controls.Add(Layout)

        Catch ex As Exception
            ' Manejo de errores en caso de que algo falle al cargar los libros
            MessageBox.Show("Error al cargar los libros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Sub LibroControl_ClickEditar(id As Integer)
        Dim datosLibro As LibroDTO = controlador.BuscarLibro(id)
        CType(Me.MdiParent, Form1).AbrirLibrosForm("editar", datosLibro)
    End Sub

    ' Manejo del evento Ver
    Private Sub LibroControl_ClickInformacion(id As Integer)
        Dim libro As LibroDTO = controlador.BuscarLibro(id)
        CType(Me.MdiParent, Form1).AbrirPaginaInformacion("libro", Nothing, libro)
    End Sub

    ' Manejo del evento Borrar
    Public Sub LibroControl_ClickBorrar(id As Integer)
        Try
            Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar el libro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then
                Dim prestamosAsociados As Integer = controlador.ContarPrestamosAsociados(id)
                If prestamosAsociados = 0 Then
                    controlador.BorrarLibro(id)
                    MessageBox.Show("Libro borrado correctamente", "Libro borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarLibros()
                Else
                    MessageBox.Show("No se puede borrar el libro. Existen " & prestamosAsociados.ToString() &
                       " préstamo(s) asociados a este libro. Por favor, revise o gestione esos préstamos antes de borrar.",
                       "Eliminación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al borrar el libro: " & ex.Message)
        End Try
    End Sub

    Private Sub GestionLibroForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CType(Me.MdiParent, Form1).OcultarMostrarBotonVolver()

        mostrado = True
    End Sub

    Private Sub GestionLibroForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            ModuloUtilidades.AjustarFuente(formulario:=Me, tamanoMaximoLetra:=13, tlPanel:=tlpPrincipal)




        End If
    End Sub

    Private Sub bCrearLibro_Click(sender As Object, e As EventArgs) Handles bCrearLibro.Click
        CType(Me.MdiParent, Form1).AbrirLibrosForm("crear")
    End Sub
End Class