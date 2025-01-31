Imports System.Data.SQLite
Imports System.Globalization

Public Class GestionPrestamoForm
    Private Sub GestionPrestamoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarVista()
    End Sub

    Dim controlador As New PrestamoController
    ' Variables para paginación
    Private paginaActual As Integer = 1
    Private tamañoPagina As Integer = 10
    Private totalPaginas As Integer = 1

    Private fuenteActual As Font = New Font("Microsoft Sans Serif", 8) ' Tamaño inicial predeterminado



    Private Sub CargarYActualizarPrestamos(filtrarActivos As Boolean, filtrarDisponibles As Boolean)
        Try
            ' Obtener los préstamos del controlador con los filtros activos y disponibles
            Dim prestamos As List(Of PrestamoDTO) = controlador.FiltrarPrestamos(filtrarActivos, filtrarDisponibles)

            ' Paginación
            totalPaginas = Math.Ceiling(prestamos.Count / tamañoPagina)
            Dim prestamosPagina = prestamos.Skip((paginaActual - 1) * tamañoPagina).Take(tamañoPagina).ToList()

            ' Limpiar la tabla
            dgvPrestamos.Rows.Clear()
            dgvPrestamos.Columns.Clear()

            ' Crear las columnas de la tabla
            dgvPrestamos.Columns.Add("Id", "ID")
            'ocultar columna id
            dgvPrestamos.Columns("id").Visible = False

            dgvPrestamos.Columns.Add("Libro", "Libro")
            dgvPrestamos.Columns.Add("NombreUsuario", "Usuario")
            dgvPrestamos.Columns.Add("Estado", "Estado")

            dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255)
            dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvPrestamos.EnableHeadersVisualStyles = False

            ' Crear las columnas de botones para las acciones (editar, ver, borrar)
            Dim colEditar As New DataGridViewButtonColumn()
            colEditar.Name = "Editar"
            colEditar.HeaderText = ""
            colEditar.Text = "Editar"
            colEditar.UseColumnTextForButtonValue = True ' Hace que todos los botones muestren el texto "Editar"
            dgvPrestamos.Columns.Add(colEditar)

            Dim colVer As New DataGridViewButtonColumn()
            colVer.Name = "Ver"
            colVer.HeaderText = ""
            colVer.Text = "Ver Info"
            colVer.UseColumnTextForButtonValue = True
            dgvPrestamos.Columns.Add(colVer)

            Dim colBorrar As New DataGridViewButtonColumn()
            colBorrar.Name = "Borrar"
            colBorrar.HeaderText = ""
            colBorrar.Text = "Borrar"
            colBorrar.UseColumnTextForButtonValue = True
            dgvPrestamos.Columns.Add(colBorrar)

            dgvPrestamos.AllowUserToAddRows = False


            ' Agregar los datos de los préstamos filtrados
            Dim estado As String = ""
            If prestamos.Count > 0 Then

                For Each prestamo As PrestamoDTO In prestamosPagina
                    Dim fechaFin As DateTime = DateTime.ParseExact(prestamo.FechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture)

                    If prestamo.Estado Then
                        estado = "Devuelto"
                    ElseIf prestamo.Estado = False AndAlso fechaFin < DateAndTime.Now Then
                        estado = "Vencido"
                    Else
                        estado = "En prestamo"

                    End If
                    Dim rowIndex As Integer = dgvPrestamos.Rows.Add(prestamo.Id, prestamo.LibroTitulo, prestamo.UsuarioNombre, estado)
                    Dim estadoCell As DataGridViewCell = dgvPrestamos.Rows(rowIndex).Cells("Estado") ' Acceso a la celda Estado



                    If estado = "Vencido" Then
                        estadoCell.Style.ForeColor = Color.Red ' Rojo para En préstamo vencido
                    ElseIf estado = "En prestamo" Then
                        estadoCell.Style.ForeColor = Color.Orange ' Naranja para En préstamo no vencido
                    Else
                        estadoCell.Style.ForeColor = Color.Green ' Verde para Disponible
                    End If

                Next
            Else
                MessageBox.Show("No hay prestamos disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Ajustar la paginación
            lblPaginacion.Text = $"Página {paginaActual} de {totalPaginas}"

            ' Ajustar el DataGridView
            dgvPrestamos.Dock = DockStyle.Fill
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            ' Ajustar las celdas
            For Each column As DataGridViewColumn In dgvPrestamos.Columns
                column.DefaultCellStyle.Padding = New Padding(5)
                column.DefaultCellStyle.Font = fuenteActual
            Next

            ' Establecer el modo de edición
            dgvPrestamos.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

        Catch ex As Exception
            MessageBox.Show("Error al cargar los prestamos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click
        If paginaActual > 1 Then
            paginaActual -= 1
            ActualizarVista()
        End If
    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click
        If paginaActual < totalPaginas Then
            paginaActual += 1
            ActualizarVista()
        End If
    End Sub

    Private Sub dgvPrestamos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestamos.CellClick
        ' Asegurarse de que no se haya hecho clic en el encabezado (Fila 0)
        If e.RowIndex >= 0 Then
            If dgvPrestamos.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id As Integer = Convert.ToInt32(dgvPrestamos.Rows(e.RowIndex).Cells("Id").Value)
                EditarPrestamo(id)
            ElseIf dgvPrestamos.Columns(e.ColumnIndex).Name = "Ver" Then
                Dim id As Integer = Convert.ToInt32(dgvPrestamos.Rows(e.RowIndex).Cells("Id").Value)
                VerInformacion(id)
            ElseIf dgvPrestamos.Columns(e.ColumnIndex).Name = "Borrar" Then
                Dim id As Integer = Convert.ToInt32(dgvPrestamos.Rows(e.RowIndex).Cells("Id").Value)
                BorrarPrestamo(id)
            End If
        End If
    End Sub

    Private Sub EditarPrestamo(id As Integer)
        Try
            Dim datosPrestamo As PrestamoDTO = controlador.BuscarPrestamo(id)

            CType(Me.MdiParent, Form1).AbrirPaginaPrestamos("editar", datosPrestamo)
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar el préstamo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub VerInformacion(id As Integer)
        Try
            Dim prestamo As PrestamoDTO = controlador.BuscarPrestamo(id)
            CType(Me.MdiParent, Form1).AbrirPaginaInformacion("prestamo", Nothing, Nothing, prestamo)
        Catch ex As Exception
            MessageBox.Show("Error al consultar el préstamo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BorrarPrestamo(id)
        Try
            Dim respuesta As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar el prestamo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then
                controlador.BorrarPrestamo(id)
                MessageBox.Show("Prestamo borrado correctamente", "Prestamo borrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ActualizarVista()
            End If


        Catch ex As Exception
            MessageBox.Show("Error al intentar borrar el préstamo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub bCrearPrestamo_Click(sender As Object, e As EventArgs) Handles bCrearPrestamo.Click
        Try
            CType(Me.MdiParent, Form1).AbrirPaginaPrestamos("crear")
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar el préstamo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chbActivos_CheckedChanged(sender As Object, e As EventArgs) Handles chbActivos.CheckedChanged, chbDisponibles.CheckedChanged
        ActualizarVista()

    End Sub

    ' Función que se llama para actualizar la vista
    Public Sub ActualizarVista()
        Dim filtrarActivos As Boolean = chbActivos.Checked
        Dim filtrarDisponibles As Boolean = chbDisponibles.Checked

        CargarYActualizarPrestamos(filtrarActivos, filtrarDisponibles)
    End Sub

    Private Sub GestionPrestamoForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CType(Me.MdiParent, Form1).OcultarMostrarBotonVolver()

    End Sub
End Class