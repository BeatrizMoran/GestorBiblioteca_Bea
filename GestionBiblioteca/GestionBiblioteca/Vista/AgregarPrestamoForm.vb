Imports System.ComponentModel
Imports System.Globalization
Imports ControlesBiblioteca
Imports GestionBiblioteca.DTOs

Public Class AgregarPrestamoForm
    Dim mostrado As Boolean = False
    Dim controladorLibro As New LibroController
    Dim controladorUsuario As New UsuarioController
    Dim controladorPrestamo As New PrestamoController

    Public opcion As String
    Public datosPrestamo As PrestamoDTO
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        CType(Me.MdiParent, Form1).VolverAtras()
    End Sub

    Private Sub AgregarPrestamoForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
        RestaurarControles()
        pEstado.Visible = False

        InicializarDatosCombo()
        If opcion = "editar" Then
            gbCrearUsuario.Text = "Editar prestamo"
            pEstado.Visible = True
            InicializarDatosPrestamo()
            Dim opc As String = CType(cbEstado.SelectedItem, KeyValuePair(Of Boolean, String)).Value
            'si un libro ya ha sido devuelton o dejar cambiar estado
            If opc = "Devuelto" Then
                cbEstado.Enabled = False
            Else
                cbEstado.Enabled = True
            End If
        End If
    End Sub

    Private Sub RestaurarControles()
        ' Limpiar y restaurar los controles a su estado inicial
        cbLibros.Items.Clear()
        cbUsuarios.Items.Clear()
        cbEstado.Items.Clear()

        cbLibros.Items.Add(New KeyValuePair(Of Integer, String)(-1, "Seleccione un libro"))
        cbUsuarios.Items.Add(New KeyValuePair(Of Integer, String)(-1, "Seleccione un Usuario"))
        cbEstado.Items.Add(New KeyValuePair(Of Boolean, String)(True, "Devuelto"))
        cbEstado.Items.Add(New KeyValuePair(Of Boolean, String)(False, "En prestamo"))

        cbLibros.SelectedIndex = 0
        cbUsuarios.SelectedIndex = 0
        cbEstado.SelectedIndex = -1

        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now.AddMonths(1)

        pEstado.Visible = False
    End Sub


    Private Sub InicializarDatosPrestamo()
        For Each item As KeyValuePair(Of Integer, String) In cbLibros.Items
            If item.Value = datosPrestamo.LibroTitulo Then
                cbLibros.SelectedItem = item
                Exit For
            End If
        Next
        For Each item As KeyValuePair(Of Integer, String) In cbUsuarios.Items
            If item.Value = datosPrestamo.UsuarioNombre Then
                cbUsuarios.SelectedItem = item
                Exit For
            End If
        Next

        dtpFechaInicio.Value = DateTime.ParseExact(datosPrestamo.FechaInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        dtpFechaFin.Value = DateTime.ParseExact(datosPrestamo.FechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture)

        For Each item As KeyValuePair(Of Boolean, String) In cbEstado.Items
            If item.Key = datosPrestamo.Estado Then
                cbEstado.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    Private Sub AgregarPrestamoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTADO
        cbEstado.DisplayMember = "Value"
        cbEstado.ValueMember = "Key"
        cbEstado.Items.Add(New KeyValuePair(Of Boolean, String)(True, "Devuelto"))
        cbEstado.Items.Add(New KeyValuePair(Of Boolean, String)(False, "En prestamo"))
    End Sub

    Private Sub InicializarDatosCombo()
        Try
            For Each control As Control In tlpFormulario.Controls
                AddHandler control.Enter, AddressOf RestaurarColores
            Next
            dtpFechaFin.Enabled = False
            Dim fechaInicio As DateTime = dtpFechaInicio.Value

            ' Sumar un mes a la fecha de inicio
            Dim fechaFin As DateTime = fechaInicio.AddMonths(1)
            dtpFechaFin.Value = fechaFin

            Dim listaLibros As List(Of LibroDTO) = controladorLibro.ObtenerLibros()
            Dim listaUsuarios As List(Of UsuarioDTO) = controladorUsuario.ObtenerUsuariosParaVista()



            For Each libro In listaLibros
                cbLibros.Items.Add(New KeyValuePair(Of Integer, String)(libro.Id, libro.Titulo))
            Next

            cbLibros.DisplayMember = "Value"
            cbLibros.ValueMember = "Key"



            Dim nombre = ""

            For Each usuario In listaUsuarios
                nombre = usuario.Nombre & " " & usuario.Apellido1
                cbUsuarios.Items.Add(New KeyValuePair(Of Integer, String)(usuario.Id, nombre))
            Next

            cbUsuarios.DisplayMember = "Value"
            cbUsuarios.ValueMember = "Key"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub RestaurarColores(sender As Object, e As EventArgs)
        ' Cambiamos los colores del control clickeado
        Dim control As Control = CType(sender, Control)
        control.BackColor = Color.White
        control.ForeColor = Color.Black
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Try
            ValidarFormulario()

            Dim libroId As Integer = CType(cbLibros.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim usuarioId As Integer = CType(cbUsuarios.SelectedItem, KeyValuePair(Of Integer, String)).Key

            Dim fechaInicio As String = dtpFechaInicio.Value.ToString("dd/MM/yyyy")
            Dim fechaFin As String = dtpFechaFin.Value.ToString("dd/MM/yyyy")

            Dim estado As Boolean = CType(cbEstado.SelectedItem, KeyValuePair(Of Boolean, String)).Key

            If opcion = "editar" Then
                MessageBox.Show(estado)
                controladorPrestamo.ActualizarPrestamo(datosPrestamo.Id, libroId, usuarioId, fechaInicio, fechaFin, estado)
                MessageBox.Show("Préstamo Actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                controladorPrestamo.CrearPrestamo(libroId, usuarioId, fechaInicio, fechaFin, False)
                MessageBox.Show("Préstamo agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CType(Me.MdiParent, Form1).AbrirPaginaPrestamos("gestion")
            Me.Close()

        Catch ex As Exception
            ' Mostrar el mensaje de error
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CambiarColorError(campo As Control)
        campo.BackColor = Color.Red
        campo.ForeColor = Color.White
    End Sub

    Private Sub ValidarFormulario()
        Dim errores As New List(Of String)

        If cbLibros.SelectedItem Is Nothing OrElse CType(cbLibros.SelectedItem, KeyValuePair(Of Integer, String)).Key = -1 Then
            errores.Add("Debe seleccionar un libro.")
            CambiarColorError(cbLibros)
        End If

        If cbUsuarios.SelectedItem Is Nothing OrElse CType(cbUsuarios.SelectedItem, KeyValuePair(Of Integer, String)).Key = -1 Then
            errores.Add("Debe seleccionar un usuario.")
            CambiarColorError(cbUsuarios)
        End If

        If opcion IsNot "editar" Then
            If dtpFechaInicio.Value.Date < DateTime.Now.Date Then
                errores.Add("La fecha de inicio no puede ser anterior a hoy.")
                CambiarColorError(dtpFechaInicio)
            End If

            If dtpFechaFin.Value.Date <= dtpFechaInicio.Value.Date Then
                errores.Add("La fecha de fin debe ser posterior a la fecha de inicio.")
                CambiarColorError(dtpFechaFin)
            End If
        End If

        If errores.Any() Then
            Throw New Exception(String.Join(Environment.NewLine, errores))
        End If
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        Dim fechaInicio As DateTime = dtpFechaInicio.Value
        Dim fechaFin As DateTime = fechaInicio.AddMonths(1)
        dtpFechaFin.Value = fechaFin
    End Sub

    Private Sub AgregarPrestamoForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If mostrado Then
            ModuloUtilidades.AjustarFuente(formulario:=Me, tamanoMaximoLetra:=13, tlPanel:=tlpPrincipal)
        End If
    End Sub
End Class
