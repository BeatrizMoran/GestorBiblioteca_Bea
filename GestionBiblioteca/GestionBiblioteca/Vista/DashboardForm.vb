Imports ControlesBiblioteca

Public Class DashboardForm


    Dim mostrado As Boolean = False
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tlpPrincipal.Paint

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        bdUsuarios.ColorFondoImagen = Color.FromArgb(243, 235, 116)
        bdLibros.ColorFondoImagen = Color.FromArgb(60, 187, 219)




    End Sub

    Private Sub BlockDashboard1_ClickarBlock() Handles BlockDashboard1.ClickarBlock
        MessageBox.Show("Hola")
    End Sub

    Private Sub BlockDashboard2_ClickarBlock() Handles bdUsuarios.ClickarBlock

    End Sub
End Class