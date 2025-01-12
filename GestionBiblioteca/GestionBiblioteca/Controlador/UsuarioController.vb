Imports System.Data.SQLite

Public Class UsuarioController
    Public Shared Function ObtenerUsuariosParaVista() As List(Of Usuario)
        ' Llamamos al método del modelo que obtiene la lista de usuarios
        Return Usuario.ObtenerUsuarios()
    End Function

    Public Function BorrarUsuario(id As Integer)
        Try
            Usuario.BorrarUsuario(id)

        Catch ex As Exception
            Throw New Exception("Error al borrar el usuario: " & ex.Message)
        End Try
    End Function

    Public Function CrearUsuario(Nombre As String, apellido_1 As String, apellido_2 As String, Telefono As Integer)
        Try
            Dim usuario As Usuario = New Usuario(Nombre, apellido_1, apellido_2, Telefono)

            Usuario.CrearUsuario(usuario)

        Catch ex As Exception
            Throw New Exception("Error al crear el usuario: " & ex.Message)
        End Try
    End Function
End Class
