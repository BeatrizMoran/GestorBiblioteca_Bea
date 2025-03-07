﻿Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class Form1

    Public dashboard As New DashboardForm
    Private gestionLibros As New GestionLibroForm
    Public gestionUsuarios As New UsuariosForm
    Public crearLibro As New AgregarLibroForm
    Dim informacionFOrm As New InformacionUsuarioForm
    Dim gestionPrestamos As New GestionPrestamoForm
    Dim crearPrestamo As New AgregarPrestamoForm

    Dim crearUsuario As New AgregarUsuarioForm
    Dim formularioActual As Form = dashboard
    ' Pila para almacenar el historial de formularios
    Public formHistory As New Stack(Of Form)

    Dim mostrado As Boolean = False

    Const FONTSIZE As Double = 8

    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bTituloLogo.FlatAppearance.BorderSize = 0


        dashboard.MdiParent = Me
        dashboard.Dock = DockStyle.Fill
        dashboard.Show()

        tlpNavbar.BackColor = Color.FromArgb(0, 123, 255)
        msNavbar.BackColor = Color.FromArgb(0, 123, 255)
        bTituloLogo.BackColor = Color.FromArgb(0, 123, 255)

        msNavbar.Items(0).Font = New Font("Arial", 10, FontStyle.Bold)
        For Each item As ToolStripMenuItem In msNavbar.Items
            item.Font = New Font("Arial", 10, FontStyle.Bold)
        Next

        AjustarMenuItems()
        msNavbar.Padding = New Padding(0, 30, 0, 0)


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
            AjustarFuente(formulario:=Me, tamanoMaximoLetra:=18, menuStrip:=msNavbar, tlPanel:=dashboard.tlpPrincipal)

        End If
    End Sub


    Public Sub OcultarMostrarBotonVolver()
        If formHistory.Count = 0 Then
            bVolver.Visible = False
        Else
            bVolver.Visible = True
        End If
    End Sub

    Public Sub AbrirUsuariosForm(pagina As String, Optional id As Integer = Nothing)
        ' Guardar el formulario activo en el historial
        If formularioActual IsNot Nothing Then
            Console.WriteLine("Página anterior: " & formularioActual.Name)
            formularioActual.Hide()
            formHistory.Push(formularioActual)
        End If

        Dim nuevoFormulario As Form = Nothing
        Select Case pagina
            Case "gestion"
                If gestionUsuarios Is Nothing OrElse gestionUsuarios.IsDisposed Then
                    gestionUsuarios = New UsuariosForm()
                Else
                    gestionUsuarios.CargarUsuarios() ' Recarga los usuarios si ya está abierto
                End If
                nuevoFormulario = gestionUsuarios

            Case "crear"
                If crearUsuario Is Nothing OrElse crearUsuario.IsDisposed Then
                    crearUsuario = New AgregarUsuarioForm()

                End If
                crearUsuario.opcion = "crear"

                nuevoFormulario = crearUsuario
            Case "editar"
                If crearUsuario Is Nothing OrElse crearUsuario.IsDisposed Then
                    crearUsuario = New AgregarUsuarioForm()

                End If
                crearUsuario.opcion = "editar"
                crearUsuario.usuarioId = id


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

    Public Sub AbrirLibrosForm(pagina As String, Optional libro As LibroDTO = Nothing)
        ' Guardar el formulario activo en el historial
        If formularioActual IsNot Nothing Then
            Console.WriteLine("Página anterior: " & formularioActual.Name)
            formularioActual.Hide()
            formHistory.Push(formularioActual)
        End If

        Dim nuevoFormulario As Form = Nothing

        Select Case pagina
            Case "gestion"
                If gestionLibros Is Nothing OrElse gestionLibros.IsDisposed Then
                    gestionLibros = New GestionLibroForm()
                Else
                    gestionLibros.CargarLibros() ' Recarga los libros si ya está abierto
                End If
                nuevoFormulario = gestionLibros
            Case "crear"
                If crearLibro Is Nothing OrElse crearLibro.IsDisposed Then
                    crearLibro = New AgregarLibroForm()

                End If
                crearLibro.accion = "crear"
                nuevoFormulario = crearLibro
            Case "editar"
                If crearLibro Is Nothing OrElse crearLibro.IsDisposed Then
                    crearLibro = New AgregarLibroForm()

                End If
                crearLibro.accion = "editar"
                crearLibro.datosLibro = libro
                nuevoFormulario = crearLibro
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
    Public Sub AbrirPaginaInformacion(pagina As String, Optional usuario As UsuarioDTO = Nothing, Optional libro As LibroDTO = Nothing, Optional prestamo As PrestamoDTO = Nothing)
        ' Guardar el formulario activo en el historial
        If formularioActual IsNot Nothing Then
            Console.WriteLine("Página anterior: " & formularioActual.Name)
            formularioActual.Hide()
            formHistory.Push(formularioActual)
        End If

        Dim nuevoFormulario As Form = Nothing

        Select Case pagina
            Case "usuario"
                If informacionFOrm Is Nothing OrElse informacionFOrm.IsDisposed Then
                    informacionFOrm = New InformacionUsuarioForm()

                End If
                informacionFOrm.tipoPagina = pagina
                informacionFOrm.datosUsuario = usuario
            Case "libro"
                If informacionFOrm Is Nothing OrElse informacionFOrm.IsDisposed Then
                    informacionFOrm = New InformacionUsuarioForm()

                End If
                informacionFOrm.tipoPagina = pagina
                informacionFOrm.datosLibro = libro
            Case "prestamo"
                If informacionFOrm Is Nothing OrElse informacionFOrm.IsDisposed Then
                    informacionFOrm = New InformacionUsuarioForm()

                End If
                informacionFOrm.tipoPagina = pagina
                informacionFOrm.datosPrestamo = prestamo
        End Select
        nuevoFormulario = informacionFOrm



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

    Public Sub AbrirPaginaPrestamos(pagina As String, Optional prestamo As PrestamoDTO = Nothing)
        ' Guardar el formulario activo en el historial
        If formularioActual IsNot Nothing Then
            Console.WriteLine("Página anterior: " & formularioActual.Name)
            formularioActual.Hide()
            formHistory.Push(formularioActual)
        End If

        Dim nuevoFormulario As Form = Nothing



        Select Case pagina
            Case "gestion"
                If gestionPrestamos Is Nothing OrElse gestionPrestamos.IsDisposed Then
                    gestionPrestamos = New GestionPrestamoForm()
                Else
                    gestionPrestamos.ActualizarVista()
                End If
                nuevoFormulario = gestionPrestamos
            Case "crear"
                If crearPrestamo Is Nothing OrElse crearPrestamo.IsDisposed Then
                    crearPrestamo = New AgregarPrestamoForm()

                End If
                crearPrestamo.opcion = pagina
                nuevoFormulario = crearPrestamo


            Case "editar"
                If crearPrestamo Is Nothing OrElse crearPrestamo.IsDisposed Then
                    crearPrestamo = New AgregarPrestamoForm()

                End If


                crearPrestamo.opcion = pagina
                crearPrestamo.datosPrestamo = prestamo

                nuevoFormulario = crearPrestamo

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

    Public Sub VolverAtras()
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

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        ' Ocultar el formulario actual y guardarlo en el historial
        If formularioActual IsNot Nothing Then
            Console.WriteLine("Formulario actual ocultado: " & formularioActual.Name)
            formularioActual.Hide()
            formHistory.Push(formularioActual)
        End If

        ' Crear o reutilizar el formulario de Dashboard
        If dashboard Is Nothing OrElse dashboard.IsDisposed Then
            dashboard = New DashboardForm()
        End If

        ' Mostrar el formulario Dashboard
        formularioActual = dashboard
        formularioActual.MdiParent = Me
        formularioActual.Dock = DockStyle.Fill
        formularioActual.Show()
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        AbrirLibrosForm("gestion")
    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        AbrirPaginaPrestamos("gestion")
    End Sub


End Class
