Public Class UsuariosForm
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCrearUsuario.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Try
            ' Obtener los datos desde el controlador (una lista de usuarios)
            Dim usuarios As List(Of Usuario) = UsuarioController.ObtenerUsuariosParaVista()

            ' Limpiar cualquier contenido previo del DataGridView
            dgvUsuarios.Rows.Clear()
            dgvUsuarios.Columns.Clear()

            ' Agregar columnas manualmente
            dgvUsuarios.Columns.Add("Id", "ID")
            dgvUsuarios.Columns.Add("Nombre", "Nombre")
            dgvUsuarios.Columns.Add("Apellido_1", "Apellido 1")
            dgvUsuarios.Columns.Add("Apellido_2", "Apellido 2")
            dgvUsuarios.Columns.Add("Telefono", "Teléfono")

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

            ' Rellenar el DataGridView con los datos de la lista de usuarios
            For Each usuario As Usuario In usuarios
                ' Agregar una fila con los datos del usuario
                dgvUsuarios.Rows.Add(usuario.id, usuario.nombre, usuario.apellido1, usuario.apellido2, usuario.telefono)
            Next

            ' Establecer el modo de edición del DataGridView (importante para que funcione con botones)
            dgvUsuarios.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

        Catch ex As Exception
            MessageBox.Show("Error al cargar los usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Asegurarse de que el evento esté conectado correctamente
    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        ' Asegurarse de que no se haya hecho clic en el encabezado (Fila 0)
        If e.RowIndex >= 0 Then
            ' Verificar qué botón ha sido clicado (Editar, Ver, Borrar)
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

    ' Acción para editar el usuario
    Private Sub EditarUsuario(id As Integer)
        MessageBox.Show("Editar usuario con ID: " & id.ToString())
    End Sub

    ' Acción para ver información del usuario
    Private Sub VerInformacion(id As Integer)
        MessageBox.Show("Ver información del usuario con ID: " & id.ToString())
    End Sub

    ' Acción para borrar el usuario
    Private Sub BorrarUsuario(id As Integer)
        MessageBox.Show("Borrar usuario con ID: " & id.ToString())
    End Sub

    Private Sub tlpGestionUsuarios_Paint(sender As Object, e As PaintEventArgs)

    End Sub

End Class