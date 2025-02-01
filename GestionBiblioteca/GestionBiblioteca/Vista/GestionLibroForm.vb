Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class GestionLibroForm
    Dim mostrado As Boolean = False
    Private fuenteActual As Font = New Font("Microsoft Sans Serif", 8) ' Tamaño inicial predeterminado

    Dim controlador As New LibroController


    Private Sub GestionLibroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCrearLibro.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado




    End Sub

    Private Sub CambiarEstadoLibro(id As Integer, disponible As Boolean)
        Try
            If disponible Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que quieres marcar como NO disponible el libro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If respuesta = DialogResult.Yes Then
                    controlador.ActualizarEstadoLibro(id, False)

                End If
                'Else
                '    Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que quieres marcar como DISPONIBLE el libro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                '    If respuesta = DialogResult.Yes Then
                '        controlador.ActualizarEstadoLibro(id, True)

                '    End If
            End If
            MessageBox.Show("Estado actualizado correctamente", "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarLibros()
        Catch ex As Exception

        End Try

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
            Dim esCargando As Boolean = True

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

                AddHandler libroControl.ClickCambiarEstado, Sub()
                                                                If Not esCargando Then
                                                                    CambiarEstadoLibro(libroDTO.Id, libroDTO.Disponible)
                                                                End If
                                                            End Sub

                ' Aquí actualizamos el estado sin disparar el evento
                libroControl.Disponible = libroDTO.Disponible ' Esto no dispara el evento

                ' Agregar el control a la posición correspondiente en la cuadrícula
                Layout.Controls.Add(libroControl, col, row)

                ' Actualizar las posiciones de fila y columna
                col += 1
                If col >= Layout.ColumnCount Then
                    col = 0
                    row += 1
                End If
            Next

            esCargando = False
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
                controlador.BorrarLibro(id)
                MessageBox.Show("Libro borrado correctamente", "Libro borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarLibros()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al borra el libro: " & ex.Message)
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

    Private Sub bCrearLibro_Click(sender As Object, e As EventArgs)
        CType(Me.MdiParent, Form1).AbrirLibrosForm("crear")
    End Sub
End Class