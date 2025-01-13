Public Class UsuariosForm

    Dim mostrado As Boolean = False
    Dim FONTSIZE = 8
    Dim controlador As New UsuarioController
    Dim fuenteActual As Font

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCrearUsuario.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

        CargarUsuarios()
    End Sub

    Public Sub CargarUsuarios()
        Try
            Dim usuarios As List(Of Usuario) = UsuarioController.ObtenerUsuariosParaVista()

            dgvUsuarios.Rows.Clear()
            dgvUsuarios.Columns.Clear()

            dgvUsuarios.Columns.Add("Id", "ID")
            dgvUsuarios.Columns.Add("Nombre", "Nombre")
            dgvUsuarios.Columns.Add("Apellido_1", "Apellido 1")
            dgvUsuarios.Columns.Add("Apellido_2", "Apellido 2")
            dgvUsuarios.Columns.Add("Telefono", "Teléfono")

            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255)
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

            ' Actualizar la tabla para reflejar los cambios
            dgvUsuarios.EnableHeadersVisualStyles = False

            ' Crear una columna de botones para las acciones (editar, ver, borrar)
            Dim colEditar As New DataGridViewButtonColumn()
            colEditar.Name = "Editar"
            colEditar.HeaderText = "Editar"
            colEditar.Text = "Editar"
            colEditar.UseColumnTextForButtonValue = True ' Hace que todos los botones muestren el texto "Editar"
            dgvUsuarios.Columns.Add(colEditar)

            Dim colVer As New DataGridViewButtonColumn()
            colVer.Name = "Ver"
            colVer.HeaderText = "Ver"
            colVer.Text = "Ver Info"
            colVer.UseColumnTextForButtonValue = True
            dgvUsuarios.Columns.Add(colVer)

            Dim colBorrar As New DataGridViewButtonColumn()
            colBorrar.Name = "Borrar"
            colBorrar.HeaderText = "Borrar"
            colBorrar.Text = "Borrar"
            colBorrar.UseColumnTextForButtonValue = True
            dgvUsuarios.Columns.Add(colBorrar)

            dgvUsuarios.AllowUserToAddRows = False

            ' Verificar si la lista de usuarios tiene elementos
            If usuarios.Count > 0 Then
                For Each usuario As Usuario In usuarios
                    If usuario IsNot Nothing Then
                        dgvUsuarios.Rows.Add(usuario.id, usuario.nombre, usuario.apellido1, usuario.apellido2, usuario.telefono)
                    End If
                Next
            Else
                MessageBox.Show("No hay usuarios disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            dgvUsuarios.Dock = DockStyle.Fill

            ' Ajustar las columnas para repartir proporcionalmente el espacio disponible
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Ajustar las filas para ocupar el espacio adecuado, manteniendo el contenido visible
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            For Each column As DataGridViewColumn In dgvUsuarios.Columns
                column.DefaultCellStyle.Padding = New Padding(5)
            Next

            ' Establecer el modo de edición del DataGridView
            dgvUsuarios.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

        Catch ex As Exception
            MessageBox.Show("Error al cargar los usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        ' Asegurarse de que no se haya hecho clic en el encabezado (Fila 0)
        If e.RowIndex >= 0 Then
            If dgvUsuarios.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim id As Integer = Convert.ToInt32(dgvUsuarios.Rows(e.RowIndex).Cells("Id").Value)
                EditarUsuario(id)
            ElseIf dgvUsuarios.Columns(e.ColumnIndex).Name = "Ver" Then
                Dim id As Integer = Convert.ToInt32(dgvUsuarios.Rows(e.RowIndex).Cells("Id").Value)
                VerInformacion(id)
            ElseIf dgvUsuarios.Columns(e.ColumnIndex).Name = "Borrar" Then
                Dim id As Integer = Convert.ToInt32(dgvUsuarios.Rows(e.RowIndex).Cells("Id").Value)
                BorrarUsuario(id)
            End If
        End If
    End Sub

    Private Sub EditarUsuario(id As Integer)
        MessageBox.Show("Editar usuario con ID: " & id.ToString())
        CType(Me.MdiParent, Form1).AbrirUsuariosForm("editar", id)

    End Sub

    Private Sub VerInformacion(id As Integer)
        MessageBox.Show("Ver información del usuario con ID: " & id.ToString())
    End Sub

    Private Sub BorrarUsuario(id As Integer)
        Try
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer borrar el usuario con id: " & id.ToString(), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then
                controlador.BorrarUsuario(id)


                CargarUsuarios()

                ' Restaurar el tamaño de la fuente a su valor anterior
                dgvUsuarios.DefaultCellStyle.Font = fuenteActual
                MessageBox.Show("Usuario borrado correctamente ", "Usuario borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub UsuariosForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            Const MAX_FONTSIZE As Integer = 13

            Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width
            Dim fontSize As Integer = Math.Min(proporciónAncho * 8, MAX_FONTSIZE)


            For Each control In tlpGestionUsuarios.Controls
                fuenteActual = New Font("Microsoft Sans Serif", fontSize)

                control.Font = fuenteActual
            Next

            For Each column As DataGridViewColumn In dgvUsuarios.Columns
                column.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", fontSize, FontStyle.Regular)
            Next

            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", fontSize, FontStyle.Bold)

            dgvUsuarios.Invalidate()
            dgvUsuarios.Refresh()
        End If
    End Sub


    Private Sub UsuariosForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
    End Sub

    Private Sub bCrearUsuario_Click(sender As Object, e As EventArgs) Handles bCrearUsuario.Click
        CType(Me.MdiParent, Form1).AbrirUsuariosForm("crear")

    End Sub
End Class