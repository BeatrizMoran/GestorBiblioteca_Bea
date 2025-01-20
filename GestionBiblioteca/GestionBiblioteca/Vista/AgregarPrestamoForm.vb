Imports System.ComponentModel
Imports GestionBiblioteca.DTOs

Public Class AgregarPrestamoForm
    Dim controladorLibro As New LibroController
    Dim controladorUsuario As New UsuarioController
    Dim controladorPrestamo As New PrestamoController

    Public opcion As String
    Public datosPrestamo As PrestamoDTO
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click

    End Sub

    Private Sub AgregarPrestamoForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If opcion = "editar" Then
            'liEstado.InputText = datosPrestamo.Estado
        End If
    End Sub

    Private Sub AgregarPrestamoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            For Each control As Control In tlpFormulario.Controls

                AddHandler control.Enter, AddressOf RestaurarColores

            Next
            dtpFechaFin.Enabled = False
            Dim fechaInicio As DateTime = dtpFechaInicio.Value

            ' Sumar un mes a la fecha de inicio
            Dim fechaFin As DateTime = fechaInicio.AddMonths(1)

            ' Asignar la nueva fecha al DateTimePicker de Fecha de Fin
            dtpFechaFin.Value = fechaFin



            Dim listaLibros As List(Of LibroDTO) = controladorLibro.ObtenerLibros()
            Dim listaUsuarios As List(Of UsuarioDTO) = controladorUsuario.ObtenerUsuariosParaVista()


            cbLibros.Items.Clear()

            cbLibros.Items.Add(New KeyValuePair(Of Integer, String)(-1, "Seleccione un libro"))

            For Each libro In listaLibros
                cbLibros.Items.Add(New KeyValuePair(Of Integer, String)(libro.Id, libro.Titulo))
            Next

            cbLibros.DisplayMember = "Value"
            cbLibros.ValueMember = "Key"

           

            'usuarios:
            cbUsuarios.Items.Clear()

            cbUsuarios.Items.Add(New KeyValuePair(Of Integer, String)(-1, "Seleccione un Usuario"))

            For Each usuario In listaUsuarios
                cbUsuarios.Items.Add(New KeyValuePair(Of Integer, String)(usuario.Id, usuario.Nombre))
            Next

            cbUsuarios.DisplayMember = "Value"
            cbUsuarios.ValueMember = "Key"

        Catch ex As Exception
            MessageBox.Show("Erro al cargar los libros: " & ex.Message)
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
            ' Validar campos
            ValidarFormulario()

            ' Obtener el ID del libro seleccionado
            Dim libroId As Integer = CType(cbLibros.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim usuarioId As Integer = CType(cbUsuarios.SelectedItem, KeyValuePair(Of Integer, String)).Key





            Dim fechaInicio As String = dtpFechaInicio.Value.ToString("dd/MM/yyyy")
            Dim fechaFin As String = dtpFechaFin.Value.ToString("dd/MM/yyyy")

            ' Llamar al controlador para crear el préstamo
            MessageBox.Show(libroId)
            controladorPrestamo.CrearPrestamo(libroId, usuarioId, fechaInicio, fechaFin, False)

            ' Confirmar éxito
            MessageBox.Show("Préstamo agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Cerrar el formulario actual
            'Me.Close()

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

        If dtpFechaInicio.Value.Date < DateTime.Now.Date Then
            errores.Add("La fecha de inicio no puede ser anterior a hoy.")
            CambiarColorError(dtpFechaInicio)
        End If

        If dtpFechaFin.Value.Date <= dtpFechaInicio.Value.Date Then
            errores.Add("La fecha de fin debe ser posterior a la fecha de inicio.")
            CambiarColorError(dtpFechaFin)

        End If

        If errores.Any() Then
            Throw New Exception(String.Join(Environment.NewLine, errores))
        End If
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        ' Obtener la fecha seleccionada en el DateTimePicker de Fecha de Inicio
        Dim fechaInicio As DateTime = dtpFechaInicio.Value

        ' Sumar un mes a la fecha de inicio
        Dim fechaFin As DateTime = fechaInicio.AddMonths(1)

        ' Asignar la nueva fecha al DateTimePicker de Fecha de Fin
        dtpFechaFin.Value = fechaFin
    End Sub
End Class