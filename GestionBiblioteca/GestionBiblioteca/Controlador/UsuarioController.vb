Imports System.Data.SQLite

Public Class UsuarioController
    Public Shared Function ObtenerUsuariosParaVista() As List(Of Usuario)
        ' Llamamos al método del modelo que obtiene la lista de usuarios
        Return Usuario.ObtenerUsuarios()
    End Function
End Class
