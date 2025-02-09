Imports ControlesBiblioteca

Public Class DashboardForm


    Dim mostrado As Boolean = False


    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bdUsuarios.ColorFondoImagen = Color.FromArgb(243, 235, 116)
        bdLibros.ColorFondoImagen = Color.FromArgb(68, 195, 140)
        bdPrestamos.ColorFondoImagen = Color.FromArgb(132, 148, 219)

    End Sub



    Private Sub BlockDashboard2_ClickarBlock() Handles bdUsuarios.ClickarBlock
        CType(Me.MdiParent, Form1).AbrirUsuariosForm("gestion")
    End Sub




    Private Sub bdLibros_ClickarBlock() Handles bdLibros.ClickarBlock
        CType(Me.MdiParent, Form1).AbrirLibrosForm("gestion")

    End Sub

    Private Sub DashboardForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        CType(Me.MdiParent, Form1).OcultarMostrarBotonVolver()
    End Sub

    Private Sub bdPrestamos_ClickarBlock() Handles bdPrestamos.ClickarBlock
        CType(Me.MdiParent, Form1).AbrirPaginaPrestamos("gestion")

    End Sub


End Class