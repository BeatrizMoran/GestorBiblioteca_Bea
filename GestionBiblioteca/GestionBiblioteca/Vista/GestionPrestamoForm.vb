Public Class GestionPrestamoForm
    Private Sub GestionPrestamoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPrestamos()
    End Sub

    Dim controlador As New PrestamoController
    ' Variables para paginación
    Private paginaActual As Integer = 1
    Private tamañoPagina As Integer = 10
    Private totalPaginas As Integer = 1

    Private fuenteActual As Font = New Font("Microsoft Sans Serif", 8) ' Tamaño inicial predeterminado



    Public Sub CargarPrestamos()
        Try


            Dim prestamos As List(Of PrestamoDTO) = controlador.ObtenerPrestamos()

            totalPaginas = Math.Ceiling(prestamos.Count / tamañoPagina)
            ' Filtrar los usuarios según la página actual
            Dim prestamosPagina = prestamos.Skip((paginaActual - 1) * tamañoPagina).Take(tamañoPagina).ToList()



            dgvPrestamos.Rows.Clear()
            dgvPrestamos.Columns.Clear()

            dgvPrestamos.Columns.Add("Id", "ID")
            dgvPrestamos.Columns("id").Visible = False

            dgvPrestamos.Columns.Add("Libro", "Libro")
            dgvPrestamos.Columns.Add("NombreUsuario", "Usuario")
            dgvPrestamos.Columns.Add("Estado", "Estado")

            dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255)
            dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

            dgvPrestamos.EnableHeadersVisualStyles = False

            ' Crear una columna de botones para las acciones (editar, ver, borrar)
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


            Dim estado = ""
            If prestamos.Count > 0 Then
                For Each prestamo As PrestamoDTO In prestamosPagina
                    If prestamo.Estado Then
                        estado = "Disponible"
                    Else
                        estado = "En prestamo"
                    End If
                    dgvPrestamos.Rows.Add(prestamo.Id, prestamo.LibroTitulo, prestamo.UsuarioNombre, estado)

                Next
            Else
                MessageBox.Show("No hay prestamos disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            For Each control As Control In tlpGestionPrestamos.Controls
                control.Font = fuenteActual
            Next


            ' Mostrar el estado de la paginación
            lblPaginacion.Text = $"Página {paginaActual} de {totalPaginas}"

            dgvPrestamos.Dock = DockStyle.Fill

            ' Ajustar las columnas para repartir proporcionalmente el espacio disponible
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Ajustar las filas para ocupar el espacio adecuado, manteniendo el contenido visible
            dgvPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells


            For Each column As DataGridViewColumn In dgvPrestamos.Columns
                column.DefaultCellStyle.Padding = New Padding(5)
            Next
            For Each column As DataGridViewColumn In dgvPrestamos.Columns
                column.DefaultCellStyle.Font = fuenteActual
            Next


            ' Establecer el modo de edición del DataGridView
            dgvPrestamos.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2



        Catch ex As Exception
            MessageBox.Show("Error al cargar los prestamos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click
        If paginaActual > 1 Then
            paginaActual -= 1
            CargarPrestamos()
        End If
    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click
        If paginaActual < totalPaginas Then
            paginaActual += 1
            CargarPrestamos()
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
            ElseIf dgvPrestamos.Columns(e.ColumnIndex).Name = "Borrar" Then
                Dim id As Integer = Convert.ToInt32(dgvPrestamos.Rows(e.RowIndex).Cells("Id").Value)
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

End Class