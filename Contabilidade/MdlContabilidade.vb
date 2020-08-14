Module MdlContabilidade
    Public db As ADODB.Connection
    Public rs, rsAux As ADODB.Recordset
    Public conexao = Application.StartupPath & "\bancos\DbContabilidade.mdb"
    Public drag As Boolean
    Public mousex, mousey As Integer
    Public resp, sql, aux, aux2, aux3 As String
    Sub ConectaBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & conexao)
        Catch ex As Exception
            MsgBox("Conexão mal sucedida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub
End Module
