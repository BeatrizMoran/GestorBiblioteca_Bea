Public Class DashboardForm

    Dim mostrado As Boolean = False
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tlpPrincipal.Paint

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarPaneles(tlpPrincipal)


        pcDashboard.BackColor = Color.FromArgb(243, 235, 116)
        pcDashboardLibros.BackColor = Color.FromArgb(60, 187, 219)


    End Sub

    Private Sub ConfigurarPaneles(contenedor As Control)
        For Each control As Control In contenedor.Controls
            If TypeOf control Is Panel Then
                control.Padding = New Padding(10)

                control.Margin = New Padding(10)
            End If
        Next
    End Sub




    Private Sub pDashboard_MouseEnter(sender As Object, e As EventArgs) Handles pDashboard.MouseEnter, lDashboardUsuarios.MouseEnter, pcDashboard.MouseEnter
        pDashboard.BackColor = Color.LightBlue
        lDashboardUsuarios.BackColor = Color.LightBlue
    End Sub

    Private Sub pDashboard_MouseLeave(sender As Object, e As EventArgs) Handles pDashboard.MouseLeave, lDashboardUsuarios.MouseLeave, pcDashboard.MouseLeave
        pDashboard.BackColor = Color.White
        lDashboardUsuarios.BackColor = Color.White

    End Sub





    Private Sub pDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles pDashboard.MouseClick, lDashboardUsuarios.MouseClick, pcDashboard.MouseClick


    End Sub



    ' Evento Paint para dibujar el borde personalizado
    Private Sub pDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pDashboard.Paint
        DibujarBorde(pDashboard, e)
    End Sub

    Private Sub pDashboardLibros_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardLibros.Paint
        DibujarBorde(pDashboardLibros, e)
    End Sub

    Private Sub pDashboardAutores_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardAutores.Paint
        DibujarBorde(pDashboardAutores, e)
    End Sub

    Private Sub pDashboardPrestamos_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardPrestamos.Paint
        DibujarBorde(pDashboardPrestamos, e)
    End Sub

    Private Sub pDashboardCategorias_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardCategorias.Paint
        DibujarBorde(pDashboardCategorias, e)
    End Sub

    Private Sub DibujarBorde(panel As Panel, e As PaintEventArgs)
        Dim borderColor As Color = Color.Purple
        Dim borderWidth As Integer = 2

        ' Dibujar un rectángulo alrededor del borde del panel
        ' Usamos ClientSize para evitar que el borde se dibuje fuera del panel
        Dim rect As New Rectangle(0, 0, panel.ClientSize.Width - 1, panel.ClientSize.Height - 1)
        Using pen As New Pen(borderColor, borderWidth)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub


End Class