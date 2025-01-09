Public Class DashboardForm

    Dim mostrado As Boolean = False
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tlpPrincipal.Paint

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DashboardForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            AjustarFuente()
        End If
    End Sub

    Private Sub AjustarFuente()
        Dim proporciónAncho As Double = Me.Width / Me.MinimumSize.Width
        For Each control In tlpPrincipal.Controls
            control.Font = New Font("Microsoft Sans Serif", proporciónAncho * 8)
        Next
    End Sub

    Private Sub pDashboard_MouseEnter(sender As Object, e As EventArgs) Handles pDashboard.MouseEnter, lDashboard.MouseEnter, pcDashboard.MouseEnter
        pDashboard.BackColor = Color.LightBlue ' Cambiar color de fondo al pasar el ratón
    End Sub

    ' Evento cuando el ratón sale del panel
    Private Sub pDashboard_MouseLeave(sender As Object, e As EventArgs) Handles pDashboard.MouseLeave, lDashboard.MouseLeave, pcDashboard.MouseLeave
        pDashboard.BackColor = Color.LightGray ' Restaurar el color de fondo cuando el ratón sale
    End Sub

    ' Evento cuando el panel es clickeado (como un botón)
    Private Sub pDashboard_Click(sender As Object, e As EventArgs) Handles pDashboard.Click
        MessageBox.Show("Has seleccionado una opción del dashboard")
    End Sub



    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        MessageBox.Show("Has seleccionado una opción del dashboard")

    End Sub

    Private Sub pDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles pDashboard.MouseClick, lDashboard.MouseClick, pcDashboard.MouseClick
        ' Este evento se activa cuando se hace clic en el panel.
        MessageBox.Show("Has hecho clic en el panel.")
    End Sub


End Class