Module Module1
    Public con As Odbc.OdbcConnection
    Public Sub vbConnection()
        Try
            con = New Odbc.OdbcConnection("dsn=test")
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
