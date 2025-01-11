Public Class Form1

    Public dashboard As New DashboardForm

    Public gestionUsuarios As New UsuariosForm

    'para poder volver a la pagina anterior
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

        TableLayoutPanel1.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado
        msNavbar.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado
        bTituloLogo.BackColor = Color.FromArgb(0, 123, 255) ' Color RGB personalizado

        msNavbar.Items(0).Font = New Font("Arial", 10, FontStyle.Bold) ' Cambiar el tamaño y estilo según desees

        ' Si deseas cambiar el tamaño de la letra de todos los elementos del MenuStrip
        For Each item As ToolStripMenuItem In msNavbar.Items
            item.Font = New Font("Arial", 10, FontStyle.Bold) ' Cambiar el tamaño y estilo para todos
        Next


        AjustarMenuItems()
        msNavbar.Padding = New Padding(0, 30, 0, 0)


        AddHandler dashboard.bdUsuarios.ClickarBlock, AddressOf AbrirUsuariosForm

    End Sub

    Private Sub AjustarMenuItems()
        ' Obtener la cantidad de elementos en el MenuStrip
        Dim itemCount As Integer = msNavbar.Items.Count

        ' Calcular la altura disponible y asignar tamaño a cada elemento
        Dim availableHeight As Integer = Me.ClientSize.Height
        Dim itemHeight As Integer = availableHeight \ itemCount ' Dividir espacio entre los elementos

        For Each item As ToolStripMenuItem In msNavbar.Items
            item.AutoSize = False ' Desactivar el tamaño automático
            item.Size = New Size(msNavbar.Width, itemHeight) ' Ajustar tamaño personalizado
        Next
    End Sub



    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            AjustarFuenteYImagenes()
        End If
    End Sub

    Private Sub AjustarFuenteYImagenes()
        ' Calculamos la proporción del ancho del formulario en relación con su tamaño mínimo
        Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width
        Dim tamanoFuente As Integer = Math.Min(proporciónAncho * FONTSIZE, 14)

        'barra navegacion

        For Each item As ToolStripMenuItem In msNavbar.Items
            item.Font = New Font("Arial", tamanoFuente)
        Next


        ' Iteramos sobre los controles dentro del contenedor de botones (en este caso, tlpPrincipal)
        For Each control In dashboard.tlpPrincipal.Controls
            control.Font = New Font("Microsoft Sans Serif", proporciónAncho * FONTSIZE)


        Next

        For Each control In gestionUsuarios.tlpGestionUsuarios.Controls
            control.Font = New Font("Microsoft Sans Serif", proporciónAncho * FONTSIZE)


        Next



        ' Cambiar la fuente de todas las celdas
        For Each column As DataGridViewColumn In gestionUsuarios.dgvUsuarios.Columns
            column.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", proporciónAncho * FONTSIZE)
        Next

        ' Cambiar la fuente de los encabezados de columna
        ' gestionUsuarios.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", proporciónAncho * FONTSIZE, FontStyle.Bold)

        ' Asegurarse de que los cambios se reflejen correctamente
        gestionUsuarios.dgvUsuarios.Invalidate()
        gestionUsuarios.dgvUsuarios.Refresh()


    End Sub




    Private Sub AbrirUsuariosForm()


        ' Guardar el formulario actual en el historial
        If ActiveMdiChild IsNot Nothing Then
            formHistory.Push(ActiveMdiChild)
        End If



        ' Abrir el nuevo formulario
        Dim usuariosForm As New UsuariosForm
        usuariosForm.MdiParent = Me
        usuariosForm.Dock = DockStyle.Fill
        usuariosForm.Show()
    End Sub


    Private Sub VolverAtras()
        ' Verificar si hay formularios en el historial
        If formHistory.Count > 0 Then
            ' Cerrar el formulario actual
            Dim currentForm As Form = ActiveMdiChild
            If currentForm IsNot Nothing Then
                currentForm.Close()
            End If

            ' Recuperar el formulario anterior de la pila y mostrarlo
            Dim previousForm As Form = formHistory.Pop()
            previousForm.Show()
        Else
        End If
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        VolverAtras()
    End Sub
End Class
