Public Class FrmMenu

    Dim PC, CC, CP, CF, CU As Boolean
    Dim n As Integer
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()
        Inicio()
    End Sub

    Private Sub Inicio()
        TabPlanoContas.Visible = False
        TabControleCadastroContas.Visible = False
        TabControleCadastroFornecedor.Visible = False
        TabControleCadastroProdutos.Visible = False
        TabControleCadastroUsuarios.Visible = False
        BtnSalvar.Visible = False
        BtnCancelar.Visible = False

        PC = False
        CC = False
        CP = False
        CF = False
        CU = False

        PnlPositionActive.Visible = False
    End Sub
    Private Sub BtnPlanoContas_Click(sender As Object, e As EventArgs) Handles BtnPlanoContas.Click
        PnlPositionActive.Visible = True
        TabPlanoContas.Visible = True
        TabControleCadastroContas.Visible = False
        TabControleCadastroFornecedor.Visible = False
        TabControleCadastroProdutos.Visible = False
        TabControleCadastroUsuarios.Visible = False
        BtnSalvar.Visible = True
        BtnCancelar.Visible = True

        PnlPositionActive.Height = BtnPlanoContas.Height
        PnlPositionActive.Top = BtnPlanoContas.Top

        PC = True
        CC = False
        CP = False
        CF = False
        CU = False

        n = 0
        sql = "SELECT * FROM TBPLANODECONTAS"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtCod.Text = n + 1
        TxtCod.Enabled = False
        TxtNome.Enabled = True
        TxtMascara.Enabled = True
        TxtAtivo.Enabled = True
        TxtPassivo.Enabled = True
        TxtReceita.Enabled = True
        TxtDespesa.Enabled = True
        TxtDisponivel.Enabled = True
        TxtEstoque.Enabled = True
        TxtPatLiquido.Enabled = True
        TxtNome.Text = ""
        TxtMascara.Text = ""
        TxtAtivo.Text = ""
        TxtPassivo.Text = ""
        TxtReceita.Text = ""
        TxtDespesa.Text = ""
        TxtDisponivel.Text = ""
        TxtEstoque.Text = ""
        TxtPatLiquido.Text = ""
        TxtPlanoDeContasPesquisa.Text = ""
        CmbPlanoDeContas.Text = ""
        TxtNome.Select()
        BtnEditar.Visible = False

        CmbPlanoDeContas.Items.Clear()
        sql = "SELECT NOME FROM TBPLANODECONTAS"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbPlanoDeContas.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        Loop

    End Sub

    Private Sub Atualizar()
        sql = "SELECT * FROM TBPLANODECONTAS WHERE NOME = '" & CmbPlanoDeContas.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            TxtCod.Text = rs.Fields(0).Value
            TxtNome.Text = rs.Fields(1).Value
            TxtMascara.Text = rs.Fields(2).Value
            TxtAtivo.Text = rs.Fields(3).Value
            TxtPassivo.Text = rs.Fields(4).Value
            TxtReceita.Text = rs.Fields(5).Value
            TxtDespesa.Text = rs.Fields(6).Value
            TxtDisponivel.Text = rs.Fields(7).Value
            TxtEstoque.Text = rs.Fields(8).Value
            TxtPatLiquido.Text = rs.Fields(9).Value

            TxtCod.Enabled = False
            TxtNome.Enabled = False
            TxtMascara.Enabled = False
            TxtAtivo.Enabled = False
            TxtPassivo.Enabled = False
            TxtReceita.Enabled = False
            TxtDespesa.Enabled = False
            TxtDisponivel.Enabled = False
            TxtEstoque.Enabled = False
            TxtPatLiquido.Enabled = False
            BtnEditar.Visible = True
        Else
        End If
    End Sub
    Private Sub BtnCadastroContas_Click(sender As Object, e As EventArgs) Handles BtnCadastroContas.Click
        PnlPositionActive.Visible = True
        TabPlanoContas.Visible = False
        TabControleCadastroContas.Visible = True
        TabControleCadastroFornecedor.Visible = False
        TabControleCadastroProdutos.Visible = False
        TabControleCadastroUsuarios.Visible = False
        BtnSalvar.Visible = False
        BtnCancelar.Visible = False


        PnlPositionActive.Height = BtnCadastroContas.Height
        PnlPositionActive.Top = BtnCadastroContas.Top

        PC = False
        CC = True
        CP = False
        CF = False
        CU = False

        CmbNome.Items.Clear()
        sql = "SELECT * FROM TBPLANODECONTAS"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbNome.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnCadastroEmpresa_Click(sender As Object, e As EventArgs) Handles BtnCadastroEmpresa.Click
        PnlPositionActive.Visible = True
        TabPlanoContas.Visible = False
        TabControleCadastroContas.Visible = False
        TabControleCadastroFornecedor.Visible = True
        TabControleCadastroProdutos.Visible = False
        TabControleCadastroUsuarios.Visible = False
        BtnSalvar.Visible = True
        BtnCancelar.Visible = True


        PnlPositionActive.Height = BtnCadastroEmpresa.Height
        PnlPositionActive.Top = BtnCadastroEmpresa.Top

        PC = False
        CC = False
        CP = False
        CF = True
        CU = False
        LimparFornecedor()
    End Sub

    Private Sub BtnCadastrarProdutos_Click(sender As Object, e As EventArgs) Handles BtnCadastrarProdutos.Click
        LimparProdutos()
        PnlPositionActive.Visible = True
        TabPlanoContas.Visible = False
        TabControleCadastroContas.Visible = False
        TabControleCadastroFornecedor.Visible = False
        TabControleCadastroProdutos.Visible = True
        TabControleCadastroUsuarios.Visible = False
        BtnSalvar.Visible = True
        BtnCancelar.Visible = True


        PnlPositionActive.Height = BtnCadastrarProdutos.Height
        PnlPositionActive.Top = BtnCadastrarProdutos.Top

        PC = False
        CC = False
        CP = True
        CF = False
        CU = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Inicio()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        TxtMascara.Enabled = True
        TxtAtivo.Enabled = True
        TxtPassivo.Enabled = True
        TxtReceita.Enabled = True
        TxtDespesa.Enabled = True
        TxtDisponivel.Enabled = True
        TxtEstoque.Enabled = True
        TxtPatLiquido.Enabled = True
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        Try
            If TxtCodConta.Text <> "" Then
                sql = "SELECT * FROM TBPLANODECONTAS WHERE CODIGO = " & TxtCodConta.Text & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    CmbNome.Text = rs.Fields(1).Value
                    LoadContas()
                Else
                    MsgBox("Código não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            Else
                MsgBox("O campo está vazio!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbNome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNome.SelectedIndexChanged
        sql = "SELECT * FROM TBPLANODECONTAS WHERE NOME = '" & CmbNome.Text & "'"
        rs = db.Execute(sql)
        TxtCodConta.Text = rs.Fields(0).Value
        LoadContas()
    End Sub

    Private Sub TxtCep_TextChanged(sender As Object, e As EventArgs) Handles TxtCep.TextChanged
        Try
            If TxtCep.MaskCompleted Then
                sql = "select * from tbCep where CEP = '" & TxtCep.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    'TxtCep.Enabled = False
                    TxtEndereco.Text = rs.Fields(1).Value
                    TxtEndereco.Enabled = False
                    TxtCidade.Text = rs.Fields(2).Value
                    TxtBairro.Enabled = False
                    TxtBairro.Text = rs.Fields(3).Value
                    TxtCidade.Enabled = False
                    TxtEstado.Text = rs.Fields(4).Value
                    TxtEstado.Enabled = False
                Else
                    resp = MsgBox("CEP NÃO CADASTRADO NA BASE!, Deseja cadastrar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
                    If resp = vbYes Then
                        'PnlCadastroClientes.Visible = False
                    Else
                        TxtCep.Clear()
                        TxtEndereco.Clear()
                        TxtCidade.Clear()
                        TxtBairro.Clear()
                        TxtEstado.Clear()
                        TxtEndereco.Enabled = True
                        TxtCidade.Enabled = True
                        TxtBairro.Enabled = True
                        TxtEstado.Enabled = True
                        TxtCep.Select()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnPesquisarFornecedor_Click(sender As Object, e As EventArgs) Handles BtnPesquisarFornecedor.Click
        If TxtPesquisarFornecedor.Text <> "" Then
            If IsNumeric(TxtPesquisarFornecedor.Text) = True Then
                sql = "SELECT * FROM TBFORNECEDORES WHERE IDFORNECEDOR = " & TxtPesquisarFornecedor.Text & ""
                rsAux = db.Execute(sql)
            Else
                sql = "SELECT * FROM TBFORNECEDORES WHERE NOME = '" & TxtPesquisarFornecedor.Text & "' OR NOMEFANTASIA = '" & TxtPesquisarFornecedor.Text & "'"
                rsAux = db.Execute(sql)
            End If
            If rsAux.EOF Then
                MsgBox("Fornecedor não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                TxtIdFornecedor.Text = rsAux.Fields(0).Value
                TxtNomeFornecedor.Text = rsAux.Fields(1).Value
                TxtFantasia.Text = rsAux.Fields(2).Value
                TxtAtividade.Text = rsAux.Fields(3).Value
                TxtCep.Text = rsAux.Fields(4).Value
                TxtEndereco.Text = rsAux.Fields(5).Value
                TxtComp.Text = rsAux.Fields(6).Value
                TxtBairro.Text = rsAux.Fields(7).Value
                TxtCidade.Text = rsAux.Fields(8).Value
                TxtEstado.Text = rsAux.Fields(9).Value
                TxtTelefone.Text = rsAux.Fields(10).Value
                TxtEmail.Text = rsAux.Fields(11).Value

                TxtIdFornecedor.Enabled = False
                TxtNomeFornecedor.Enabled = False
                TxtFantasia.Enabled = False
                TxtAtividade.Enabled = False
                TxtCep.Enabled = False
                TxtEndereco.Enabled = False
                TxtComp.Enabled = False
                TxtBairro.Enabled = False
                TxtCidade.Enabled = False
                TxtEstado.Enabled = False
                TxtTelefone.Enabled = False
                TxtEmail.Enabled = False
            End If
        Else
            MsgBox("O campo está vazio!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
    End Sub

    Private Sub TxtPesquisarFornecedor_DoubleClick(sender As Object, e As EventArgs) Handles TxtPesquisarFornecedor.DoubleClick
        LimparFornecedor()
    End Sub

    Private Sub LimparFornecedor()
        TxtIdFornecedor.Enabled = True
        TxtNomeFornecedor.Enabled = True
        TxtFantasia.Enabled = True
        TxtAtividade.Enabled = True
        TxtCep.Enabled = True
        TxtEndereco.Enabled = True
        TxtComp.Enabled = True
        TxtBairro.Enabled = True
        TxtCidade.Enabled = True
        TxtEstado.Enabled = True
        TxtTelefone.Enabled = True
        TxtEmail.Enabled = True

        TxtIdFornecedor.Text = ""
        TxtNomeFornecedor.Text = ""
        TxtFantasia.Text = ""
        TxtAtividade.Text = ""
        TxtCep.Text = ""
        TxtEndereco.Text = ""
        TxtComp.Text = ""
        TxtBairro.Text = ""
        TxtCidade.Text = ""
        TxtEstado.Text = ""
        TxtTelefone.Text = ""
        TxtEmail.Text = ""
        TxtPesquisarFornecedor.Text = ""

        n = 0
        sql = "SELECT * FROM TBFORNECEDORES"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtIdFornecedor.Text = n + 1
        TxtIdFornecedor.Enabled = False
    End Sub

    Private Sub BtnPesquisarProduto_Click(sender As Object, e As EventArgs) Handles BtnPesquisarProduto.Click
        Try
            If TxtPesquisarProduto.Text <> "" Then
                If IsNumeric(TxtPesquisarProduto.Text) = True Then
                    sql = "SELECT * FROM TBPRODUTOS WHERE IDPRODUTO = " & TxtPesquisarProduto.Text & ""
                    rsAux = db.Execute(sql)
                Else
                    sql = "SELECT * FROM TBPRODUTOS WHERE PRODUTO = '" & TxtPesquisarProduto.Text & "'"
                    rsAux = db.Execute(sql)
                End If
                If rsAux.EOF Then
                    MsgBox("Produto não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    TxtIdProduto.Text = rsAux.Fields(0).Value
                    TxtProduto.Text = rsAux.Fields(1).Value
                    TxtPeso.Text = rsAux.Fields(2).Value
                    TxtDimensao.Text = rsAux.Fields(3).Value
                    TxtIdFornecedorProduto.Text = rsAux.Fields(4).Value
                    CmbFornecedor.Text = rsAux.Fields(5).Value
                    TxtClassificacaoProduto.Text = rs.Fields(6).Value
                    CmbPlanoContasProduto.Text = rs.Fields(7).Value

                    TxtIdProduto.Enabled = False
                    TxtProduto.Enabled = False
                    TxtPeso.Enabled = False
                    TxtDimensao.Enabled = False
                    TxtIdFornecedorProduto.Enabled = False
                    CmbFornecedor.Enabled = False
                    TxtClassificacaoProduto.Enabled = False
                    CmbPlanoContasProduto.Enabled = False
                End If
            Else
                MsgBox("O campo está vazio!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimparProdutos()
        TxtIdProduto.Text = ""
        TxtProduto.Text = ""
        TxtPeso.Text = ""
        TxtDimensao.Text = ""
        TxtIdFornecedorProduto.Text = ""
        CmbFornecedor.Text = ""

        TxtIdProduto.Enabled = True
        TxtProduto.Enabled = True
        TxtPeso.Enabled = True
        TxtDimensao.Enabled = True
        TxtIdFornecedorProduto.Enabled = True
        CmbFornecedor.Enabled = True

        n = 0
        sql = "SELECT * FROM TBPRODUTOS"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtIdProduto.Text = n + 1
        TxtIdProduto.Enabled = False

        CmbFornecedor.Items.Clear()
        sql = "SELECT * FROM TBFORNECEDORES"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbFornecedor.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
        n += 1
        If n < 10 Then
            aux = "0" & n.ToString
        Else
            If n < 100 Then
                aux = n.ToString
            End If
        End If
        aux2 = "ESTOQUE"
        sql = "SELECT CLASSIFICACAOINTERNA FROM TBCONTROLEPLANODECONTAS WHERE DESCRICAOCONTA = '" & aux2 & "'"
        rs = db.Execute(sql)
        aux2 = rs.Fields(0).Value
        aux3 = aux2.Substring(0, 7)
        TxtClassificacaoProduto.Text = "'" & aux3 & "'" & aux & "'"
        TxtClassificacaoProduto.Enabled = False

        CmbPlanoContasProduto.Items.Clear()
        sql = "SELECT * FROM TBPLANODECONTAS"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbPlanoContasProduto.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
        TxtPesquisarProduto.Text = ""
        TxtProduto.Select()
    End Sub

    Private Sub TxtPesquisarProduto_DoubleClick(sender As Object, e As EventArgs) Handles TxtPesquisarProduto.DoubleClick
        LimparProdutos()
    End Sub

    Private Sub BtnCadastrarUsuarios_Click(sender As Object, e As EventArgs) Handles BtnCadastrarUsuarios.Click
        PnlPositionActive.Visible = True
        TabPlanoContas.Visible = False
        TabControleCadastroContas.Visible = False
        TabControleCadastroFornecedor.Visible = False
        TabControleCadastroProdutos.Visible = False
        TabControleCadastroUsuarios.Visible = True
        BtnSalvar.Visible = True
        BtnCancelar.Visible = True

        PnlPositionActive.Height = BtnCadastrarUsuarios.Height
        PnlPositionActive.Top = BtnCadastrarUsuarios.Top

        PC = False
        CC = False
        CP = False
        CF = False
        CU = True

        LimparUsuarios()
    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            FrmLogin.Show()
        End If
    End Sub

    Private Sub BtnPesquisarUsuario_Click(sender As Object, e As EventArgs) Handles BtnPesquisarUsuario.Click
        Try
            If TxtCpfUsuario.MaskCompleted = True Then
                sql = "SELECT * FROM TBUSUARIOS WHERE CPF = '" & TxtPesquisarUsuario.Text & "'"
                rsAux = db.Execute(sql)
                If rsAux.EOF Then
                    MsgBox("Usuário não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    TxtCpfUsuario.Text = rsAux.Fields(0).Value
                    TxtNomeUsuario.Text = rsAux.Fields(1).Value
                    TxtEmailUsuario.Text = rsAux.Fields(2).Value
                    CmbCargo.Text = rsAux.Fields(4).Value

                    TxtCpfUsuario.Enabled = False
                    TxtNomeUsuario.Enabled = False
                    TxtEmailUsuario.Enabled = False
                    CmbCargo.Enabled = False
                End If
            Else
                MsgBox("O campo não está completo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPesquisarUsuario_DoubleClick(sender As Object, e As EventArgs) Handles TxtPesquisarUsuario.DoubleClick
        LimparUsuarios()
    End Sub

    Private Sub BtnAddConta_Click(sender As Object, e As EventArgs) Handles BtnAddConta.Click
        If TxtCodConta.Text = "" Or CmbNome.Text = "" Then
            MsgBox("Escolha um plano de contas!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            aux = CmbNome.Text
            FrmCadastroContas.Show()
        End If
    End Sub

    Private Sub BtnPlanoDeContasPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPlanoDeContasPesquisa.Click
        Try
            If TxtPlanoDeContasPesquisa.Text <> "" Then
                sql = "SELECT * FROM TBPLANODECONTAS WHERE CODIGO = " & TxtPlanoDeContasPesquisa.Text & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    CmbPlanoDeContas.Text = rs.Fields(1).Value
                    Atualizar()
                Else
                    MsgBox("Código não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            Else
                MsgBox("O campo está vazio!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbPlanoDeContas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPlanoDeContas.SelectedIndexChanged
        Atualizar()
    End Sub

    Private Sub ArredondarLados()
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        'Me.BackColor = Color.Red
        Me.WindowState = WindowState.Normal
    End Sub

    Private Sub DgvContas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContas.CellContentClick

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If PC Then
            If TxtNome.Text = "" Or TxtMascara.Text = "_-_-__-__-__" Or TxtAtivo.Text = "_-_-__-__-__" Or TxtPassivo.Text = "_-_-__-__-__" Or TxtReceita.Text = "_-_-__-__-__" Or TxtDespesa.Text = "_-_-__-__-__" Or TxtDisponivel.Text = "_-_-__-__-__" Or TxtEstoque.Text = "_-_-__-__-__" Or TxtPatLiquido.Text = "_-_-__-__-__" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            sql = "SELECT * FROM TBPLANODECONTAS WHERE CODIGO = " & TxtCod.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "UPDATE TBPLANODECONTAS SET NOME = '" & TxtNome.Text & "'," &
                      "CLASSIFICACAOINTERNA = '" & TxtMascara.Text & "'," &
                      "ATIVO = '" & TxtAtivo.Text & "', PASSIVO = '" & TxtPassivo.Text & "'," &
                      "RECEITA = '" & TxtReceita.Text & "', DESPESA = '" & TxtDespesa.Text & "'," &
                      "DISPONÍVEL = '" & TxtDisponivel.Text & "', ESTOQUE = '" & TxtEstoque.Text & "'," &
                      "PATRIMONIOLIQUIDO = '" & TxtPatLiquido.Text & "'" &
                      "WHERE CODIGO = " & TxtCod.Text & ""
                db.Execute(sql)
                MsgBox("Atualizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Atualizar()
            Else
                sql = "INSERT INTO TBPLANODECONTAS (CODIGO, NOME, CLASSIFICACAOINTERNA, ATIVO, PASSIVO, " &
                  "RECEITA, DESPESA, DISPONÍVEL, ESTOQUE, PATRIMONIOLIQUIDO) " &
                  "VALUES ('" & TxtCod.Text & "'," &
                          "'" & TxtNome.Text & "'," &
                          "'" & TxtMascara.Text & "'," &
                          "'" & TxtAtivo.Text & "'," &
                          "'" & TxtPassivo.Text & "'," &
                          "'" & TxtReceita.Text & "'," &
                          "'" & TxtDespesa.Text & "'," &
                          "'" & TxtDisponivel.Text & "'," &
                          "'" & TxtEstoque.Text & "'," &
                          "'" & TxtPatLiquido.Text & "')"
                db.Execute(UCase(sql))
            End If
            aux = "ATIVO"
            sql = "SELECT DESCRICAOCONTA FROM TBCONTROLEPLANODECONTAS WHERE DESCRICAOCONTA = '" & aux & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                n = 7
                aux = "ATIVO"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                     "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtAtivo.Text & "', '" & aux & "')"
                db.Execute(sql)
                n = 14
                aux = "PASSIVO"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                    "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtPassivo.Text & "', '" & aux & "')"
                db.Execute(sql)
                n = 21
                aux = "RECEITA"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                    "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtReceita.Text & "', '" & aux & "')"
                db.Execute(sql)
                n = 28
                aux = "DESPESAS"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                      "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtDespesa.Text & "', '" & aux & "')"
                db.Execute(sql)
                n = 35
                aux = "DISPONÍVEL"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                      "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtDisponivel.Text & "', '" & aux & "')"
                db.Execute(sql)
                n = 42
                aux = "ESTOQUE"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                      "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtEstoque.Text & "', '" & aux & "')"
                db.Execute(sql)
                n = 49
                aux = "PATRIMÔNIO LÍQUIDO"
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                      "VALUES ('" & TxtNome.Text & "', " & n & ", '" & TxtPatLiquido.Text & "', '" & aux & "')"
                db.Execute(sql)
                MsgBox("Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                aux = "ATIVO"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtAtivo.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                aux = "PASSIVO"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtPassivo.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                aux = "RECEITA"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtReceita.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                aux = "DESPESAS"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtDespesa.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                aux = "DISPONÍVEL"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtDisponivel.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                aux = "ESTOQUE"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtEstoque.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                aux = "PATRIMÔNIO LÍQUIDO"
                sql = "UPDATE TBCONTROLEPLANODECONTAS SET CLASSIFICACAOINTERNA = '" & TxtPatLiquido.Text & "' WHERE DESCRICAOCONTA = '" & aux & "'"
                db.Execute(sql)
                MsgBox("Atualizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If


        ElseIf CC Then
        ElseIf CP Then
            If CmbPlanoContasProduto.Text = "" Or TxtIdProduto.Text = "" Or TxtProduto.Text = "" Or TxtPeso.Text = "" Or TxtDimensao.Text = "" Or TxtIdFornecedorProduto.Text = "" Or CmbFornecedor.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            sql = "SELECT * FROM TBPRODUTOS WHERE IDPRODUTO = " & TxtIdProduto.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "UPDATE TBPRODUTOS SET PRODUTO = '" & TxtProduto.Text & "', PESO = '" & TxtPeso.Text & "', DIMENSOES = '" & TxtDimensao.Text & "', " &
                      "IDFORNECEDOR = '" & TxtIdFornecedorProduto.Text & "', FORNECEDOR = '" & CmbFornecedor.Text & "'" &
                      "WHERE IDPRODUTO = " & TxtIdProduto.Text & ""
                db.Execute(sql)
                MsgBox("Produto Atualizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparProdutos()
            Else
                sql = "INSERT INTO TBPRODUTOS VALUES ('" & TxtIdProduto.Text & "'," &
                                                    "'" & TxtProduto.Text & "'," &
                                                    "'" & TxtPeso.Text & "'," &
                                                    "'" & TxtDimensao.Text & "'," &
                                                    "'" & TxtIdFornecedorProduto.Text & "'," &
                                                    "'" & CmbFornecedor.Text & "', " &
                                                    "'" & TxtClassificacaoProduto.Text & "', " &
                                                    "'" & CmbPlanoContasProduto.Text & "')"
                db.Execute(UCase(sql))
                n = 200
                sql = "SELECT * FROM TBPRODUTOS"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    n += 1
                    rs.MoveNext()
                Loop
                n += 1
                sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                      "VALUES ('" & CmbPlanoContasProduto.Text & "', " & n & ", '" & TxtClassificacaoProduto.Text & "', '" & TxtProduto.Text & "')"
                db.Execute(sql)

                MsgBox("Produto cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparProdutos()
            End If
        ElseIf CF Then
            If TxtIdFornecedor.Text = "" Or TxtNomeFornecedor.Text = "" Or TxtFantasia.Text = "" Or TxtAtividade.Text = "" Or TxtCep.MaskCompleted = False Or TxtTelefone.Text = "" Or TxtEmail.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            sql = "SELECT * FROM TBFORNECEDORES WHERE IDFORNECEDOR = " & TxtIdFornecedor.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "UPDATE TBFORNECEDORES SET NOME = '" & TxtNomeFornecedor.Text & "', NOMEFANTASIA = '" & TxtFantasia.Text & "'," &
                      "ATIIDADE = '" & TxtAtividade.Text & "', CEP = '" & TxtCep.Text & "', ENDERECO = '" & TxtEndereco.Text & "'," &
                      "COMPLEMENTO = '" & TxtComp.Text & "', BAIRRO = '" & TxtBairro.Text & "', CIDADE = '" & TxtCidade.Text & "'," &
                      "ESTADO = '" & TxtEstado.Text & "', TELEFONE = '" & TxtTelefone.Text & "', EMAIL = '" & TxtEmail.Text & "'" &
                      "WHERE IDFORNECEDOR = " & TxtIdFornecedor.Text & ""
                db.Execute(sql)
                MsgBox("Fornecedor Atualizado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "INSERT INTO TBFORNECEDORES (IDFORNECEDOR, NOME, NOMEFANTASIA, ATIVIDADE, CEP, ENDERECO, COMPLEMENTO, BAIRRO, CIDADE, " &
                "ESTADO, TELEFONE, EMAIL)" &
                "VALUES ('" & TxtIdFornecedor.Text & "', '" & TxtNomeFornecedor.Text & "', '" & TxtFantasia.Text & "', '" & TxtAtividade.Text & "'," &
                "'" & TxtCep.Text & "', '" & TxtEndereco.Text & "', '" & TxtComp.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "'," &
                "'" & TxtEstado.Text & "', '" & TxtTelefone.Text & "', '" & TxtEmail.Text & "')"
                db.Execute(sql)
                MsgBox("Fornecedor cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        ElseIf CU Then
            If TxtCpfUsuario.MaskCompleted = False Or TxtNomeUsuario.Text = "" Or CmbCargo.Text = "" Or TxtEmailUsuario.Text = "" Or TxtSenha.Text = "" Or TxtRSenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                If TxtRSenha.Text <> TxtSenha.Text Then
                    MsgBox("As senhas não coincidem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                End If
            End If
            sql = "SELECT * FROM TBUSUARIOS WHERE CPF = '" & TxtCpfUsuario.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "UPDATE TBUSUARIOS SET NOME = '" & TxtNomeUsuario.Text & "', EMAIL = '" & TxtEmailUsuario.Text & "'," &
                      "SENHA = '" & TxtSenha.Text & "', CARGO = '" & CmbCargo.Text & "'" &
                      "WHERE CPF = '" & TxtCpfUsuario.Text & "'"
                db.Execute(sql)
                MsgBox("Usuário Atualizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparUsuarios()
            Else
                sql = "INSERT INTO TBUSUARIOS VALUES ('" & TxtCpfUsuario.Text & "','" & TxtNomeUsuario.Text & "'," &
                      "'" & TxtEmailUsuario.Text & "', '" & TxtSenha.Text & "', '" & CmbCargo.Text & "')"
                db.Execute(sql)
                MsgBox("Usuário Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparUsuarios()
            End If
        End If
    End Sub
    Private Sub CbVisualizar_CheckedChanged(sender As Object, e As EventArgs) Handles CbVisualizar.CheckedChanged
        Try
            If CbVisualizar.Checked Then
                TxtSenha.PasswordChar = ""
                TxtRSenha.PasswordChar = ""
            Else
                TxtSenha.PasswordChar = "•"
                TxtRSenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub LimparUsuarios()
        TxtCpfUsuario.Enabled = True
        TxtNomeUsuario.Enabled = True
        TxtEmailUsuario.Enabled = True
        TxtSenha.Enabled = True
        TxtRSenha.Enabled = True
        CmbCargo.Enabled = True

        TxtCpfUsuario.Text = ""
        TxtNomeUsuario.Text = ""
        TxtEmailUsuario.Text = ""
        TxtSenha.Text = ""
        TxtRSenha.Text = ""
        CmbCargo.Text = ""

        CmbCargo.Items.Clear()
        CmbCargo.Items.Add("DIRETOR")
        CmbCargo.Items.Add("SUPORTE")
        CmbCargo.Items.Add("ESTOQUE")

        TxtPesquisarUsuario.Text = ""
        TxtCpfUsuario.Select()
    End Sub

    Private Sub LoadContas()
        Dim a, contRows As Integer
        contRows = -1
        DgvContas.ColumnCount = 4

        DgvContas.Columns(0).Name = "Chamada"
        DgvContas.Columns(0).HeaderText = "Chamada"
        DgvContas.Columns(0).DataPropertyName = "Chamada"
        'DgvContas.Columns(0).Width = 35

        DgvContas.Columns(1).Name = "Classificação"
        DgvContas.Columns(1).HeaderText = "Classificação"
        DgvContas.Columns(1).DataPropertyName = "Classificação"

        DgvContas.Columns(2).Name = "Descrição"
        DgvContas.Columns(2).HeaderText = "Descrição"
        DgvContas.Columns(2).DataPropertyName = "Descrição"

        DgvContas.Columns(3).Name = "Valor"
        DgvContas.Columns(3).HeaderText = "Valor"
        DgvContas.Columns(3).DataPropertyName = "Valor"

        sql = "SELECT * FROM TBCONTROLEPLANODECONTAS WHERE PLANOCONTAS = '" & CmbNome.Text & "' ORDER BY CLASSIFICACAOINTERNA ASC"
        rs = db.Execute(sql)
        With Me.DgvContas
            .Rows.Clear()
            While rs.EOF = False
                .Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            End While

        End With
    End Sub
End Class