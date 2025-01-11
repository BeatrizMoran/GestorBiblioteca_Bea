Public Class DashboardForm

    Dim mostrado As Boolean = False
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tlpPrincipal.Paint

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarPaneles(tlpPrincipal)


        pcDashboard.BackColor = Color.FromArgb(243, 235, 116) ' Color RGB personalizado
        pcDashboardLibros.BackColor = Color.FromArgb(60, 187, 219) ' Color RGB personalizado


    End Sub

    Private Sub ConfigurarPaneles(contenedor As Control)
        ' Recorremos todos los controles dentro del contenedor
        For Each control As Control In contenedor.Controls
            ' Verificamos si el control es de tipo Panel
            If TypeOf control Is Panel Then
                ' Configuramos el Padding del Panel
                control.Padding = New Padding(10) ' Ajusta el valor de Padding según lo desees

                ' Configuramos el Margin del Panel
                control.Margin = New Padding(10) ' Ajusta el valor de Margin según lo desees
            End If
        Next
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

    Private Sub pDashboard_MouseEnter(sender As Object, e As EventArgs) Handles pDashboard.MouseEnter, lDashboardUsuarios.MouseEnter, pcDashboard.MouseEnter
        pDashboard.BackColor = Color.LightBlue
        lDashboardUsuarios.BackColor = Color.LightBlue
    End Sub

    Private Sub pDashboard_MouseLeave(sender As Object, e As EventArgs) Handles pDashboard.MouseLeave, lDashboardUsuarios.MouseLeave, pcDashboard.MouseLeave
        pDashboard.BackColor = Color.White ' Restaurar el color de fondo cuando el ratón sale
        lDashboardUsuarios.BackColor = Color.White ' Restaurar el color de fondo cuando el ratón sale

    End Sub





    Private Sub pDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles pDashboard.MouseClick, lDashboardUsuarios.MouseClick, pcDashboard.MouseClick
        ' Este evento se activa cuando se hace clic en el panel.
        MessageBox.Show("Has hecho clic en el panel.")
        'CType(Me.MdiParent, Form1).AbrirUsuariosForm()

    End Sub



    ' Evento Paint para dibujar el borde personalizado
    Private Sub pDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pDashboard.Paint
        DibujarBorde(pDashboard, e) ' Llamamos a la función para pDashboard1
    End Sub

    Private Sub pDashboardLibros_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardLibros.Paint
        DibujarBorde(pDashboardLibros, e) ' Llamamos a la función para pDashboard2
    End Sub

    Private Sub pDashboardAutores_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardAutores.Paint
        DibujarBorde(pDashboardAutores, e) ' Llamamos a la función para pDashboard3
    End Sub

    Private Sub pDashboardPrestamos_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardPrestamos.Paint
        DibujarBorde(pDashboardPrestamos, e) ' Llamamos a la función para pDashboard4
    End Sub

    Private Sub pDashboardCategorias_Paint(sender As Object, e As PaintEventArgs) Handles pDashboardCategorias.Paint
        DibujarBorde(pDashboardCategorias, e) ' Llamamos a la función para pDashboard5
    End Sub

    Private Sub DibujarBorde(panel As Panel, e As PaintEventArgs)
        ' Definir el color del borde (morado) y el ancho del borde
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