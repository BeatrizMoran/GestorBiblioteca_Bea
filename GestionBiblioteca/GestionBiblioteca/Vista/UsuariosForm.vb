﻿Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class UsuariosForm

    Dim mostrado As Boolean = False
    Dim FONTSIZE = 8
    Dim controlador As New UsuarioController
    Private fuenteActual As Font = New Font("Microsoft Sans Serif", 8) ' Tamaño inicial predeterminado

    ' Variables para paginación
    Private paginaActual As Integer = 1
    Private tamañoPagina As Integer = 10
    Private totalPaginas As Integer = 1

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCrearUsuario.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

        CargarUsuarios()
    End Sub

    Public Sub CargarUsuarios()
        Try
            Dim usuarios As List(Of UsuarioDTO) = controlador.ObtenerUsuariosParaVista()
            ' Calcular el número total de páginas
            totalPaginas = Math.Ceiling(usuarios.Count / tamañoPagina)
            ' Filtrar los usuarios según la página actual
            Dim usuariosPagina = usuarios.Skip((paginaActual - 1) * tamañoPagina).Take(tamañoPagina).ToList()



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
            colEditar.HeaderText = ""
            colEditar.Text = "Editar"
            colEditar.UseColumnTextForButtonValue = True ' Hace que todos los botones muestren el texto "Editar"
            dgvUsuarios.Columns.Add(colEditar)

            Dim colVer As New DataGridViewButtonColumn()
            colVer.Name = "Ver"
            colVer.HeaderText = ""
            colVer.Text = "Ver Info"
            colVer.UseColumnTextForButtonValue = True
            dgvUsuarios.Columns.Add(colVer)

            Dim colBorrar As New DataGridViewButtonColumn()
            colBorrar.Name = "Borrar"
            colBorrar.HeaderText = ""
            colBorrar.Text = "Borrar"
            colBorrar.UseColumnTextForButtonValue = True
            dgvUsuarios.Columns.Add(colBorrar)

            dgvUsuarios.AllowUserToAddRows = False

            ' Verificar si la lista de usuarios tiene elementos
            If usuarios.Count > 0 Then
                ' Agregar usuarios de la página actual al DataGridView
                For Each usuario As UsuarioDTO In usuariosPagina
                    dgvUsuarios.Rows.Add(usuario.Id, usuario.Nombre, usuario.Apellido1, usuario.Apellido2, usuario.Telefono)

                Next
            Else
                MessageBox.Show("No hay usuarios disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            For Each control As Control In tlpGestionUsuarios.Controls
                control.Font = fuenteActual
            Next


            ' Mostrar el estado de la paginación
            lblPaginacion.Text = $"Página {paginaActual} de {totalPaginas}"

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

            ModuloUtilidades.AjustarFuente(formulario:=Me, tamanoMaximoLetra:=13, tlPanel:=tlpGestionUsuarios, tabla:=dgvUsuarios)



        Catch ex As Exception
            MessageBox.Show("Error al cargar los usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click
        If paginaActual > 1 Then
            paginaActual -= 1
            CargarUsuarios()
        End If
    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click
        If paginaActual < totalPaginas Then
            paginaActual += 1
            CargarUsuarios()
        End If
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        ' Asegurarse de que no se haya hecho clic en el encabezado (Fila 0)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex > 0 Then
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
        CType(Me.MdiParent, Form1).AbrirUsuariosForm("editar", id)

    End Sub

    Private Sub VerInformacion(id As Integer)
        Dim usuario As UsuarioDTO = controlador.BuscarUsuario(id)
        CType(Me.MdiParent, Form1).AbrirPaginaInformacion("usuario", usuario)
    End Sub

    Public Sub BorrarUsuario(id As Integer)
        Try
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer borrar el usuario? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then
                Dim prestamoActivo As Dictionary(Of String, Object) = controlador.ObtenerInformacionPrestamo(id)
                If Convert.ToInt32(prestamoActivo("TotalPrestamos")) = 0 Then

                    controlador.BorrarUsuario(id)

                    ' Restaurar el tamaño de la fuente a su valor anterior
                    dgvUsuarios.DefaultCellStyle.Font = fuenteActual
                    MessageBox.Show("Usuario borrado correctamente ", "Usuario borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarUsuarios()
                Else
                    MessageBox.Show("No se puede borrar el usuario. Existen préstamo(s) activos asociados a este usuario. Por favor, revise o gestione esos préstamos antes de borrar.",
                                           "Eliminación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub UsuariosForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            ModuloUtilidades.AjustarFuente(formulario:=Me, tamanoMaximoLetra:=13, tlPanel:=tlpTabla, tabla:=dgvUsuarios)
        End If
    End Sub



    Private Sub UsuariosForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CType(Me.MdiParent, Form1).OcultarMostrarBotonVolver()
        mostrado = True
    End Sub

    Private Sub bCrearUsuario_Click(sender As Object, e As EventArgs) Handles bCrearUsuario.Click
        CType(Me.MdiParent, Form1).AbrirUsuariosForm("crear")

    End Sub
End Class