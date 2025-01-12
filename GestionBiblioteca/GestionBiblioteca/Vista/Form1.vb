Public Class Form1

    Public dashboard As New DashboardForm
    Public gestionUsuarios As New UsuariosForm
    Dim crearUsuario As New AgregarUsuarioForm
    Dim formularioActual As Form = dashboard

    ' Pila para almacenar el historial de formularios
    Private formHistory As New Stack(Of Form)

    Dim mostrado As Boolean = False

    Const FONTSIZE As Double = 8

    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dashboard.MdiParent = Me
        dashboard.Dock = DockStyle.Fill
        dashboard.Show()

        TableLayoutPanel1.BackColor = Color.FromArgb(0, 123, 255)
        msNavbar.BackColor = Color.FromArgb(0, 123, 255)
        bTituloLogo.BackColor = Color.FromArgb(0, 123, 255)

        msNavbar.Items(0).Font = New Font("Arial", 10, FontStyle.Bold)
        For Each item As ToolStripMenuItem In msNavbar.Items
            item.Font = New Font("Arial", 10, FontStyle.Bold)
        Next

        AjustarMenuItems()
        msNavbar.Padding = New Padding(0, 30, 0, 0)

        AddHandler dashboard.bdUsuarios.ClickarBlock, Sub()
                                                          AbrirUsuariosForm("gestion")
                                                      End Sub
        AddHandler gestionUsuarios.bCrearUsuario.Click, Sub()
                                                            AbrirUsuariosForm("crear")
                                                        End Sub
    End Sub

    Private Sub AjustarMenuItems()
        Dim itemCount As Integer = msNavbar.Items.Count
        Dim availableHeight As Integer = Me.ClientSize.Height
        Dim itemHeight As Integer = availableHeight \ itemCount

        For Each item As ToolStripMenuItem In msNavbar.Items
            item.AutoSize = False
            item.Size = New Size(msNavbar.Width, itemHeight)
        Next
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            AjustarFuenteYImagenes()
        End If
    End Sub

    Private Sub AjustarFuenteYImagenes()
        Dim proporcionAncho As Double = Me.Width / Me.MinimumSize.Width
        Dim tamanoFuente As Integer = Math.Min(proporcionAncho * FONTSIZE, 14)

        ' Ajustar la fuente en el menú
        For Each item As ToolStripMenuItem In msNavbar.Items
            item.Font = New Font("Arial", tamanoFuente)
        Next

        ' Ajustar la fuente de los controles en el formulario de Dashboard
        For Each control In dashboard.tlpPrincipal.Controls
            control.Font = New Font("Microsoft Sans Serif", proporcionAncho * FONTSIZE)
        Next

        ' Ajustar la fuente de los controles en el formulario de Gestión de Usuarios
        For Each control In gestionUsuarios.tlpGestionUsuarios.Controls
            control.Font = New Font("Microsoft Sans Serif", proporcionAncho * FONTSIZE)
        Next

        ' Cambiar la fuente de todas las celdas del DataGridView
        For Each column As DataGridViewColumn In gestionUsuarios.dgvUsuarios.Columns
            column.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", proporcionAncho * FONTSIZE)
        Next

        ' Asegurarse de que los cambios se reflejen correctamente en el DataGridView
        gestionUsuarios.dgvUsuarios.Invalidate()
        gestionUsuarios.dgvUsuarios.Refresh()
    End Sub

    Private Sub AbrirUsuariosForm(pagina As String)
        ' Guardar el formulario activo en el historial
        If formularioActual IsNot Nothing Then
            Console.WriteLine("Página anterior: " & formularioActual.Name)
            formHistory.Push(formularioActual)
        End If

        Dim nuevoFormulario As Form = Nothing
        Select Case pagina
            Case "gestion"
                If gestionUsuarios Is Nothing OrElse gestionUsuarios.IsDisposed Then
                    gestionUsuarios = New UsuariosForm()
                End If
                nuevoFormulario = gestionUsuarios

            Case "crear"
                If crearUsuario Is Nothing OrElse crearUsuario.IsDisposed Then
                    crearUsuario = New AgregarUsuarioForm()
                End If
                nuevoFormulario = crearUsuario

            Case Else
                MessageBox.Show("Página no reconocida.")
                Return
        End Select

        ' Configurar y mostrar el nuevo formulario
        If nuevoFormulario IsNot Nothing Then
            If ActiveMdiChild IsNot nuevoFormulario Then
                nuevoFormulario.MdiParent = Me
                nuevoFormulario.Dock = DockStyle.Fill
                nuevoFormulario.Show()
                Me.ActivateMdiChild(nuevoFormulario)
                formularioActual = nuevoFormulario
                Console.WriteLine("Formulario activo: " & formularioActual.Name)
            End If
        End If

        ' Mostrar historial de formularios
        MostrarHistorial()
    End Sub

    ' Mostrar el historial de formularios en consola
    Private Sub MostrarHistorial()
        Dim historialComoTexto As String = "Formularios en el historial:" & Environment.NewLine
        For Each formulario In formHistory
            historialComoTexto &= formulario.Name & Environment.NewLine
        Next
        Console.WriteLine(historialComoTexto)
    End Sub

    Private Sub VolverAtras()
        If formHistory.Count > 0 Then
            If formularioActual IsNot Nothing Then
                formularioActual.Hide()
            End If

            ' Recuperar el formulario anterior de la pila
            Dim previousForm As Form = formHistory.Pop()
            If previousForm IsNot Nothing AndAlso Not previousForm.IsDisposed Then
                previousForm.MdiParent = Me
                previousForm.Dock = DockStyle.Fill
                previousForm.Show()
                formularioActual = previousForm
                Me.ActivateMdiChild(previousForm)
                Console.WriteLine("Volviendo al formulario: " & formularioActual.Name)
            End If
        Else
            Console.WriteLine("No hay formularios en el historial.")
        End If
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        VolverAtras()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AbrirUsuariosForm("gestion")
    End Sub

    ' Evento para cancelar y volver atrás desde el formulario de creación de usuario
    Private Sub crearUsuario_bCancelar_Click(sender As Object, e As EventArgs)
        VolverAtras()
    End Sub

End Class
