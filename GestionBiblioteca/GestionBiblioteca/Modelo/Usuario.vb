Imports System.Data.SQLite

Public Class Usuario

    Property id As Integer
    Property nombre As String
    Property apellido1 As String
    Property apellido2 As String
    Property telefono As Integer

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, apellido1 As String, apellido2 As String, telefono As Integer)
        Me.nombre = nombre
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
        Me.telefono = telefono
    End Sub



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

    Public Shared Sub CrearUsuario(usuario As Usuario)
        Try
            Dim Cmd As New SQLiteCommand

            ' Consulta de inserción sin el campo ID (ya que es autoincremental)
            Dim Sql As String = "INSERT INTO Usuarios (Nombre, Apellido_1, Apellido_2, Telefono) " &
                                "VALUES (@Nombre, @Apellido_1, @Apellido_2, @Telefono)"

            Cmd.CommandText = Sql

            Cmd.Parameters.Add("@Nombre", DbType.String).Value = usuario.nombre
            Cmd.Parameters.Add("@Apellido_1", DbType.String).Value = usuario.apellido1
            Cmd.Parameters.Add("@Apellido_2", DbType.String).Value = usuario.apellido2
            Cmd.Parameters.Add("@Telefono", DbType.Int32).Value = usuario.telefono


            SQLLite.Ejecuta(My.Settings.conexion, Cmd)
        Catch ex As Exception
            Throw New Exception("Error al intentar crear el usuario: " & ex.Message)
        End Try
    End Sub

    Public Shared Sub ActualizarUsuario(usuario As Usuario)
        Try
            Dim Cmd As New SQLiteCommand

            Dim Sql As String = "UPDATE Usuarios SET Nombre = @Nombre, Apellido_1 = @Apellido_1, Apellido_2 = @Apellido_2, Telefono = @Telefono WHERE Id = @Id"

            Cmd.CommandText = Sql

            Cmd.Parameters.Add("@Nombre", DbType.String).Value = usuario.nombre
            Cmd.Parameters.Add("@Apellido_1", DbType.String).Value = usuario.apellido1
            Cmd.Parameters.Add("@Apellido_2", DbType.String).Value = usuario.apellido2
            Cmd.Parameters.Add("@Telefono", DbType.Int32).Value = usuario.telefono
            Cmd.Parameters.Add("@Id", DbType.Int32).Value = usuario.id

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)
        Catch ex As Exception
            Throw New Exception("Error al intentar actualizar el usuario: " & ex.Message)
        End Try
    End Sub


    Public Shared Function BuscarUsuario(usuario As Usuario) As Usuario
        Try
            ' Crear y abrir la conexión manualmente
            Dim conn As New SQLiteConnection(My.Settings.conexion)
            conn.Open()

            Dim Cmd As New SQLiteCommand("SELECT * FROM Usuarios WHERE Id=@Id", conn)
            Cmd.Parameters.Add("@Id", DbType.Int32).Value = usuario.id

            ' Ejecutar el comando con la conexión abierta
            Dim lector As SQLiteDataReader = Cmd.ExecuteReader()

            If lector.Read() Then
                usuario.id = Convert.ToInt32(lector("Id"))
                usuario.nombre = lector("Nombre").ToString()
                usuario.apellido1 = lector("Apellido_1").ToString()
                usuario.apellido2 = lector("Apellido_2").ToString()
                usuario.telefono = Convert.ToInt32(lector("Telefono"))
            Else
                usuario = Nothing
            End If

            ' Cerrar el lector y la conexión después de usarlos
            lector.Close()
            conn.Close()

            Return usuario

        Catch ex As Exception
            Throw New Exception("Error al intentar buscar el usuario: " & ex.Message)
        End Try
    End Function




End Class
