Public Class FrmControleEstoque
    Dim n, n1, n2, qtdebanco As Integer
    Dim qtdeSaldo As Integer
    Dim qtdeValorUnitario, qtdeValorTotal As Double
    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        sql = "SELECT * FROM TBPRODUTOS WHERE IDPRODUTO = " & TxtIdProduto.Text & ""
        rs = db.Execute(sql)
        If rs.EOF Then
            MsgBox("Código de produto não encontrado!")
        Else
            CmbFornecedor.Text = rs.Fields(5).Value
            CmbProduto.Text = rs.Fields(1).Value
            CmbFornecedor.Enabled = False
            CmbProduto.Enabled = False
        End If


    End Sub

    Private Sub FrmControleEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        Inicio()
    End Sub

    Private Sub Inicio()
        sql = "SELECT * FROM TBFORNECEDORES"
        rs = db.Execute(sql)
        CmbFornecedor.Items.Clear()
        Do While rs.EOF = False
            CmbFornecedor.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop

        sql = "SELECT * FROM TBPRODUTOS"
        rs = db.Execute(sql)
        CmbProduto.Items.Clear()
        Do While rs.EOF = False
            CmbProduto.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop

        TxtIdProduto.Text = ""
        TxtLote.Text = ""
        TxtQuantidade.Text = ""
        TxtValorTotal.Text = ""
        TxtValorUnitario.Text = ""

        CmbOperacao.Items.Add("")
    End Sub

    Private Sub CbDebito_CheckedChanged(sender As Object, e As EventArgs) Handles CbDebito.CheckedChanged
        If CbDebito.CheckState = 1 Then
            CbCredito.CheckState = 0
            CmbOperacao.Items.Clear()
            CmbOperacao.Items.Add("COMPRA")
            CmbOperacao.Items.Add("DEVOLUÇÃO DE COMPRA")
            CmbOperacao.Items.Add("ESTOQUE INICIAL")
            sql = "SELECT * FROM TBPEPS WHERE PRODUTO = '" & CmbProduto.Text & "'"
            rs = db.Execute(sql)
            Dim n As Integer
            n = 1
            If rs.EOF = False Then
                Do While rs.EOF = False
                    n += 1
                    rs.MoveNext()
                Loop
                TxtLote.Text = n
            End If
        End If
    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub CbCredito_CheckedChanged(sender As Object, e As EventArgs) Handles CbCredito.CheckedChanged
        If CbCredito.CheckState = 1 Then
            CbDebito.CheckState = 0
            CmbOperacao.Items.Clear()
            CmbOperacao.Items.Add("VENDA")
            CmbOperacao.Items.Add("DEVOLUÇÃO DE VENDA")
        End If
    End Sub

    Private Sub CmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduto.SelectedIndexChanged
        sql = "SELECT * FROM TBPRODUTOS WHERE PRODUTO = '" & CmbProduto.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            CmbFornecedor.Text = rs.Fields(5).Value
            TxtIdProduto.Text = rs.Fields(0).Value
        End If
    End Sub



    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click


        If CbDebito.CheckState = 1 Then
            sql = "INSERT INTO TBCONTROLEESTOQUE (DATA, OPERAÇÃO, FORNECEDOR, IDPRODUTO, PRODUTO, LOTE, QUANTIDADE, FRETE, VALORUNITARIO, VALORTOTAL, DEBITO, CREDITO) " &
            "VALUES ('" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "', '" & CmbOperacao.Text & "', '" & CmbFornecedor.Text & "'," &
            "'" & TxtIdProduto.Text & "','" & CmbProduto.Text & "', " & TxtLote.Text & ", " & TxtQuantidade.Text & ", '" & TxtFrete.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "', '" & FormatCurrency(TxtValorTotal.Text) & "', '" & CbDebito.CheckState & "', '" & CbCredito.CheckState & "')"
            db.Execute(sql)
            Dim n, n1, n2 As Integer
            n = TxtValorUnitario.Text
            n1 = TxtFrete.Text
            n2 = TxtQuantidade.Text
            qtdeSaldo = n2
            qtdeValorTotal = n * n2 + n1
            qtdeValorUnitario = qtdeValorTotal / qtdeSaldo
            sql = "INSERT INTO TBPEPS (PRODUTO, DATA, OPERACAO, QTDEENTRADA, VALORUNIENTRADA, VALORTOTENTRADA, QTDESALDO, VALORUNISALDO, VALORTOTSALDO) " &
                "VALUES ('" & CmbProduto.Text & "', '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "','" & CmbOperacao.Text & "', '" & TxtQuantidade.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "','" & FormatCurrency(TxtValorTotal.Text) & "', '" & qtdeSaldo & "', '" & qtdeValorUnitario & "', '" & qtdeValorTotal & "')"
            db.Execute(sql)
            sql = "INSERT INTO TBUEPS (PRODUTO, DATA, OPERACAO, QTDEENTRADA, VALORUNIENTRADA, VALORTOTENTRADA, QTDESALDO, VALORUNISALDO, VALORTOTSALDO) " &
                "VALUES ('" & CmbProduto.Text & "', '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "','" & CmbOperacao.Text & "', '" & TxtQuantidade.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "','" & FormatCurrency(TxtValorTotal.Text) & "', '" & qtdeSaldo & "', '" & qtdeValorUnitario & "', '" & qtdeValorTotal & "')"
            db.Execute(sql)
            sql = "INSERT INTO TBPONDERADA (PRODUTO, DATA, OPERACAO, QTDEENTRADA, VALORUNIENTRADA, VALORTOTENTRADA, QTDESALDO, VALORUNISALDO, VALORTOTSALDO) " &
                "VALUES ('" & CmbProduto.Text & "', '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "','" & CmbOperacao.Text & "', '" & TxtQuantidade.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "','" & FormatCurrency(TxtValorTotal.Text) & "', '" & qtdeSaldo & "', '" & qtdeValorUnitario & "', '" & qtdeValorTotal & "')"
            db.Execute(sql)
            MsgBox("Cadastrado!")
        End If
        If CbCredito.CheckState = 1 Then
            sql = "INSERT INTO TBCONTROLEESTOQUE (DATA, OPERAÇÃO, FORNECEDOR, IDPRODUTO, PRODUTO, LOTE, QUANTIDADE, FRETE, VALORUNITARIO, VALORTOTAL, DEBITO, CREDITO) " &
            "VALUES ('" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "', '" & CmbOperacao.Text & "', '" & CmbFornecedor.Text & "'," &
            "'" & TxtIdProduto.Text & "','" & CmbProduto.Text & "', " & TxtLote.Text & ", " & TxtQuantidade.Text & ", '" & TxtFrete.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "', '" & FormatCurrency(TxtValorTotal.Text) & "', '" & CbDebito.CheckState & "', '" & CbCredito.CheckState & "')"
            db.Execute(sql)
            If CmbOperacao.Text = "VENDA" Then

                n = TxtValorUnitario.Text
                n1 = TxtFrete.Text
                n2 = TxtQuantidade.Text

                sql = "select * from tbpeps where produto = '" & CmbProduto.Text & "' order by codigo asc"
                rs = db.Execute(sql)
                qtdebanco = rs.Fields(4).Value
                If qtdebanco > n2 Then
                    qtdebanco -= n2
                Else
                    n2 -= qtdebanco
                    qtdebanco = 0

                End If
            End If

            qtdeValorUnitario = qtdeValorTotal / qtdeSaldo
            sql = "INSERT INTO TBPEPS (PRODUTO, DATA, OPERACAO, QTDEENTRADA, VALORUNIENTRADA, VALORTOTENTRADA, QTDESALDO, VALORUNISALDO, VALORTOTSALDO) " &
                "VALUES ('" & CmbProduto.Text & "', '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "','" & CmbOperacao.Text & "', '" & TxtQuantidade.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "','" & FormatCurrency(TxtValorTotal.Text) & "', '" & qtdeSaldo & "', '" & qtdeValorUnitario & "', '" & qtdeValorTotal & "')"
            db.Execute(sql)
            sql = "INSERT INTO TBUEPS (PRODUTO, DATA, OPERACAO, QTDEENTRADA, VALORUNIENTRADA, VALORTOTENTRADA, QTDESALDO, VALORUNISALDO, VALORTOTSALDO) " &
                "VALUES ('" & CmbProduto.Text & "', '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "','" & CmbOperacao.Text & "', '" & TxtQuantidade.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "','" & FormatCurrency(TxtValorTotal.Text) & "', '" & qtdeSaldo & "', '" & qtdeValorUnitario & "', '" & qtdeValorTotal & "')"
            db.Execute(sql)
            sql = "INSERT INTO TBPONDERADA (PRODUTO, DATA, OPERACAO, QTDEENTRADA, VALORUNIENTRADA, VALORTOTENTRADA, QTDESALDO, VALORUNISALDO, VALORTOTSALDO) " &
                "VALUES ('" & CmbProduto.Text & "', '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "','" & CmbOperacao.Text & "', '" & TxtQuantidade.Text & "', '" & FormatCurrency(TxtValorUnitario.Text) & "','" & FormatCurrency(TxtValorTotal.Text) & "', '" & qtdeSaldo & "', '" & qtdeValorUnitario & "', '" & qtdeValorTotal & "')"
            db.Execute(sql)
            MsgBox("Cadastrado!")
        End If

    End Sub

    Private Sub TxtValorUnitario_TextChanged(sender As Object, e As EventArgs) Handles TxtValorUnitario.TextChanged
        Dim n, n1, n2, total As Integer
        If TxtQuantidade.Text <> "" And TxtFrete.Text <> "" And TxtValorUnitario.Text <> "" Then
            n = TxtFrete.Text
            n1 = TxtQuantidade.Text
            n2 = TxtValorUnitario.Text
            total = (n1 * n2) + n
            TxtValorTotal.Text = total
        End If
    End Sub
End Class