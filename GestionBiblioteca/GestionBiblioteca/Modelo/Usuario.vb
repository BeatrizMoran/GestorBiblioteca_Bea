Imports System.Data.SQLite

Public Class Usuario

    Property id As Integer
    Property nombre As String
    Property apellido1 As String
    Property apellido2 As String
    Property telefono As Integer

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As Integer)
        Me.id = id
        Me.nombre = nombre
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
        Me.telefono = telefono
    End Sub

    ' Método para obtener la lista de usuarios desde la base de datos
    Public Shared Function ObtenerUsuarios() As List(Of Usuario)
        Dim usuarios As New List(Of Usuario)
        Dim consulta As String = "SELECT Id, Nombre, Apellido_1, Apellido_2, Telefono FROM Usuarios"

        Try
            Dim cmd As New SQLiteCommand(consulta)
            Dim tabla As DataTable = SQLLite.GetDataTable(My.Settings.conexion, cmd)

            For Each fila As DataRow In tabla.Rows
                Dim usuario As New Usuario With {
                    .id = Convert.ToInt32(fila("Id")),
                    .nombre = fila("Nombre").ToString(),
                    .apellido1 = fila("Apellido_1").ToString(),
                    .apellido2 = fila("Apellido_2").ToString(),
                    .telefono = Convert.ToInt32(fila("Telefono"))
                }
                usuarios.Add(usuario)
            Next
        Catch ex As Exception
            Throw New Exception("Error al obtener los usuarios: " & ex.Message)
        End Try

        Return usuarios
    End Function

    Public Shared Function BorrarUsuario(id As Integer)
        Try
            Dim Cmd As New SQLiteCommand
            Dim Sql As String = “DELETE FROM Usuarios WHERE (ID=@Id)"
            Cmd.CommandText = Sql
            Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id
            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        Catch ex As Exception
            Throw New Exception("Error al intentar borrar usuario: " & ex.Message)
        End Try

    End Function

End Class
