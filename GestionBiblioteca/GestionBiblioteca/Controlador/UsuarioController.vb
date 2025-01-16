Imports System.Data.SQLite
Imports GestionBiblioteca.DTOs

Public Class UsuarioController
    Public Shared Function ObtenerUsuariosParaVista() As List(Of UsuarioDTO)
        ' Llamamos al método del modelo que obtiene la lista de usuarios

        Dim usuarios As List(Of Usuario) = New List(Of Usuario)
        Dim usuariosDTO As New List(Of UsuarioDTO)


        usuarios = Usuario.ObtenerUsuarios

        For Each usuario In usuarios
            usuariosDTO.Add(New UsuarioDTO With {
                .Id = usuario.id,
                .Nombre = usuario.nombre,
                .Apellido1 = usuario.apellido1,
                .Apellido2 = usuario.apellido2,
                .Telefono = usuario.telefono
            })
        Next

        Return usuariosDTO
    End Function

    Public Sub BorrarUsuario(id As Integer)
        Try
            Usuario.BorrarUsuario(id)

        Catch ex As Exception
            Throw New Exception("Error al borrar el usuario: " & ex.Message)
        End Try
    End Sub

    Public Sub CrearUsuario(Nombre As String, apellido_1 As String, apellido_2 As String, Telefono As Integer)
        Try
            Dim usuario As Usuario = New Usuario(Nombre, apellido_1, apellido_2, Telefono)

            Usuario.CrearUsuario(usuario)

        Catch ex As Exception
            Throw New Exception("Error al crear el usuario: " & ex.Message)
        End Try
    End Sub

    Public Function BuscarUsuario(id As Integer)
        Try
            Dim usuario As New Usuario
            usuario.id = id

            usuario = Usuario.BuscarUsuario(usuario)

            Dim usuarioDTO As New UsuarioDTO

            usuarioDTO = (New UsuarioDTO With {
                .Id = usuario.id,
                .Nombre = usuario.nombre,
                .Apellido1 = usuario.apellido1,
                .Apellido2 = usuario.apellido2,
                .Telefono = usuario.telefono
            })

            Return usuarioDTO

        Catch ex As Exception
            Throw New Exception("Error al buscar el usuario: " & ex.Message)
        End Try
    End Function

    Public Sub ActualizarUsuario(id As Integer, Nombre As String, apellido_1 As String, apellido_2 As String, Telefono As Integer)
        Try
            Dim usuario As Usuario = New Usuario(Nombre, apellido_1, apellido_2, Telefono)
            usuario.id = id

            Usuario.ActualizarUsuario(usuario)

        Catch ex As Exception
            Throw New Exception("Error al crear el usuario: " & ex.Message)
        End Try
    End Sub
End Class
