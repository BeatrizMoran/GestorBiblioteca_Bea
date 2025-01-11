Imports System.Data.SQLite
Public Module SQLLite
    Public Function Conectar(ByVal BBDD As String) As SQLiteConnection
        Try
            Dim Cnn As SQLiteConnection = New SQLiteConnection(BBDD)
            Cnn.Open()
            Return Cnn
        Catch ex As Exception
            Throw New Exception("No se logro realizar la conexión debido: " & ex.Message)
        End Try
    End Function

    Public Function GetDataReader(ByVal BBDD As String, ByVal Cmd As SQLiteCommand) As SQLiteDataReader
        Try
            Using Cnx As SQLiteConnection = Conectar(BBDD)
                Cmd.Connection = Cnx
                Return Cmd.ExecuteReader() ' Deja que el lector maneje el ciclo de vida
            End Using ' La conexión se cerrará automáticamente aquí
        Catch ex As Exception
            Throw New Exception("No se logró realizar la consulta por: " & ex.Message)
        End Try
    End Function

    Public Function GetDataTable(ByVal BBDD As String, ByVal Cmd As SQLiteCommand) As DataTable
        Try
            Using Cnx As SQLiteConnection = Conectar(BBDD)
                Cmd.Connection = Cnx
                Dim ds As New DataSet
                ds.Tables.Add("datos")
                Using da As New SQLiteDataAdapter(Cmd)
                    da.Fill(ds, "datos")
                End Using ' El adaptador se cierra automáticamente aquí
                Return ds.Tables(0)
            End Using ' La conexión se cerrará automáticamente aquí
        Catch ex As Exception
            Throw New Exception("No se logró realizar la consulta por: " & ex.Message)
        End Try
    End Function


    Public Sub Ejecuta(ByVal BBDD As String, ByVal Cmd As SQLiteCommand)
        Try
            Using Cnx As SQLiteConnection = Conectar(BBDD)
                Cmd.Connection = Cnx
                Cmd.ExecuteNonQuery()
            End Using ' La conexión se cerrará automáticamente aquí
        Catch ex As Exception
            Throw New Exception("No se logró realizar la consulta por: " & ex.Message)
        End Try
    End Sub
End Module
