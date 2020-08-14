<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlLeft = New System.Windows.Forms.Panel()
        Me.PnlPositionActive = New System.Windows.Forms.Panel()
        Me.OnlMiddle = New System.Windows.Forms.Panel()
        Me.TabConfiguracao = New System.Windows.Forms.TabPage()
        Me.GrpPlanoContas = New System.Windows.Forms.GroupBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.LblNivelEstoque = New System.Windows.Forms.Label()
        Me.TxtEstoque = New System.Windows.Forms.MaskedTextBox()
        Me.TxtAtivo = New System.Windows.Forms.MaskedTextBox()
        Me.LbpPatLiquido = New System.Windows.Forms.Label()
        Me.TxtPatLiquido = New System.Windows.Forms.MaskedTextBox()
        Me.LblDisponivel = New System.Windows.Forms.Label()
        Me.TxtDisponivel = New System.Windows.Forms.MaskedTextBox()
        Me.LblDespesa = New System.Windows.Forms.Label()
        Me.LblPassivo = New System.Windows.Forms.Label()
        Me.LblReceita = New System.Windows.Forms.Label()
        Me.LblAtivo = New System.Windows.Forms.Label()
        Me.TxtDespesa = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPassivo = New System.Windows.Forms.MaskedTextBox()
        Me.TxtReceita = New System.Windows.Forms.MaskedTextBox()
        Me.GrpMask = New System.Windows.Forms.GroupBox()
        Me.TxtMascara = New System.Windows.Forms.MaskedTextBox()
        Me.GrpCodNome = New System.Windows.Forms.GroupBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.TabPlanoContas = New System.Windows.Forms.TabControl()
        Me.TabControleCadastroContas = New System.Windows.Forms.TabControl()
        Me.TabCadastroContas = New System.Windows.Forms.TabPage()
        Me.CmbNome = New System.Windows.Forms.ComboBox()
        Me.TxtCodConta = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.DgvContas = New System.Windows.Forms.DataGridView()
        Me.TabControleCadastroFornecedor = New System.Windows.Forms.TabControl()
        Me.TabCadastroFornecedor = New System.Windows.Forms.TabPage()
        Me.TxtPesquisarFornecedor = New System.Windows.Forms.TextBox()
        Me.LblPesquisarFornecedor = New System.Windows.Forms.Label()
        Me.GrpContato = New System.Windows.Forms.GroupBox()
        Me.TxtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.GrpEndereco = New System.Windows.Forms.GroupBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.LblCidade = New System.Windows.Forms.Label()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.LblBairro = New System.Windows.Forms.Label()
        Me.TxtComp = New System.Windows.Forms.TextBox()
        Me.LblComp = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.TxtCep = New System.Windows.Forms.MaskedTextBox()
        Me.LblEndereco = New System.Windows.Forms.Label()
        Me.LblCEP = New System.Windows.Forms.Label()
        Me.GrpInfo = New System.Windows.Forms.GroupBox()
        Me.TxtAtividade = New System.Windows.Forms.TextBox()
        Me.LblAtividade = New System.Windows.Forms.Label()
        Me.TxtFantasia = New System.Windows.Forms.TextBox()
        Me.LblFantasia = New System.Windows.Forms.Label()
        Me.TxtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.LblNomeFornecedor = New System.Windows.Forms.Label()
        Me.TxtIdFornecedor = New System.Windows.Forms.TextBox()
        Me.LblIdFornecedor = New System.Windows.Forms.Label()
        Me.TabControleCadastroProdutos = New System.Windows.Forms.TabControl()
        Me.TabCadastroProduto = New System.Windows.Forms.TabPage()
        Me.TxtPesquisarProduto = New System.Windows.Forms.TextBox()
        Me.LblPesquisarProduto = New System.Windows.Forms.Label()
        Me.GrpFornecedor = New System.Windows.Forms.GroupBox()
        Me.CmbFornecedor = New System.Windows.Forms.ComboBox()
        Me.TxtIdFornecedorProduto = New System.Windows.Forms.TextBox()
        Me.LblNomeFornecedorProduto = New System.Windows.Forms.Label()
        Me.LblIdFornecedorProduto = New System.Windows.Forms.Label()
        Me.GrpInfoProdutos = New System.Windows.Forms.GroupBox()
        Me.TxtDimensao = New System.Windows.Forms.TextBox()
        Me.LblDimensao = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.LblPeso = New System.Windows.Forms.Label()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.LblProduto = New System.Windows.Forms.Label()
        Me.TxtIdProduto = New System.Windows.Forms.TextBox()
        Me.LblIdProduto = New System.Windows.Forms.Label()
        Me.TabControleCadastroUsuarios = New System.Windows.Forms.TabControl()
        Me.TabCadastroUsuarios = New System.Windows.Forms.TabPage()
        Me.LblPesquisarUsuario = New System.Windows.Forms.Label()
        Me.GrpSenha = New System.Windows.Forms.GroupBox()
        Me.CbVisualizar = New System.Windows.Forms.CheckBox()
        Me.TxtRSenha = New System.Windows.Forms.TextBox()
        Me.LblRSenha = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.GrpInfoUsuario = New System.Windows.Forms.GroupBox()
        Me.TxtEmailUsuario = New System.Windows.Forms.TextBox()
        Me.LblEmailUsuario = New System.Windows.Forms.Label()
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.TxtCpfUsuario = New System.Windows.Forms.MaskedTextBox()
        Me.TxtNomeUsuario = New System.Windows.Forms.TextBox()
        Me.LblNomeUsuario = New System.Windows.Forms.Label()
        Me.LblCpfUsuario = New System.Windows.Forms.Label()
        Me.TxtPesquisarUsuario = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtClassificacaoProduto = New System.Windows.Forms.MaskedTextBox()
        Me.CmbPlanoContasProduto = New System.Windows.Forms.ComboBox()
        Me.CmbPlanoDeContas = New System.Windows.Forms.ComboBox()
        Me.TxtPlanoDeContasPesquisa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddConta = New System.Windows.Forms.Button()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnPesquisarFornecedor = New System.Windows.Forms.Button()
        Me.BtnPesquisarUsuario = New System.Windows.Forms.Button()
        Me.BtnPesquisarProduto = New System.Windows.Forms.Button()
        Me.BtnPlanoDeContasPesquisa = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCadastrarUsuarios = New System.Windows.Forms.Button()
        Me.BtnCadastrarProdutos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCadastroEmpresa = New System.Windows.Forms.Button()
        Me.BtnCadastroContas = New System.Windows.Forms.Button()
        Me.BtnPlanoContas = New System.Windows.Forms.Button()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.PnlTop.SuspendLayout()
        Me.PnlLeft.SuspendLayout()
        Me.OnlMiddle.SuspendLayout()
        Me.TabConfiguracao.SuspendLayout()
        Me.GrpPlanoContas.SuspendLayout()
        Me.GrpMask.SuspendLayout()
        Me.GrpCodNome.SuspendLayout()
        Me.TabPlanoContas.SuspendLayout()
        Me.TabControleCadastroContas.SuspendLayout()
        Me.TabCadastroContas.SuspendLayout()
        CType(Me.DgvContas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControleCadastroFornecedor.SuspendLayout()
        Me.TabCadastroFornecedor.SuspendLayout()
        Me.GrpContato.SuspendLayout()
        Me.GrpEndereco.SuspendLayout()
        Me.GrpInfo.SuspendLayout()
        Me.TabControleCadastroProdutos.SuspendLayout()
        Me.TabCadastroProduto.SuspendLayout()
        Me.GrpFornecedor.SuspendLayout()
        Me.GrpInfoProdutos.SuspendLayout()
        Me.TabControleCadastroUsuarios.SuspendLayout()
        Me.TabCadastroUsuarios.SuspendLayout()
        Me.GrpSenha.SuspendLayout()
        Me.GrpInfoUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.PicClose)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(799, 28)
        Me.PnlTop.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(337, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU PRINCIPAL"
        '
        'PnlLeft
        '
        Me.PnlLeft.BackColor = System.Drawing.Color.LightGray
        Me.PnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLeft.Controls.Add(Me.PnlPositionActive)
        Me.PnlLeft.Controls.Add(Me.BtnCadastrarUsuarios)
        Me.PnlLeft.Controls.Add(Me.BtnCadastrarProdutos)
        Me.PnlLeft.Controls.Add(Me.PictureBox1)
        Me.PnlLeft.Controls.Add(Me.BtnCadastroEmpresa)
        Me.PnlLeft.Controls.Add(Me.BtnCadastroContas)
        Me.PnlLeft.Controls.Add(Me.BtnPlanoContas)
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.Location = New System.Drawing.Point(0, 28)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Size = New System.Drawing.Size(145, 422)
        Me.PnlLeft.TabIndex = 2
        '
        'PnlPositionActive
        '
        Me.PnlPositionActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PnlPositionActive.Location = New System.Drawing.Point(136, 6)
        Me.PnlPositionActive.Name = "PnlPositionActive"
        Me.PnlPositionActive.Size = New System.Drawing.Size(8, 48)
        Me.PnlPositionActive.TabIndex = 3
        Me.PnlPositionActive.Visible = False
        '
        'OnlMiddle
        '
        Me.OnlMiddle.Controls.Add(Me.BtnCancelar)
        Me.OnlMiddle.Controls.Add(Me.BtnSalvar)
        Me.OnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OnlMiddle.Location = New System.Drawing.Point(145, 28)
        Me.OnlMiddle.Name = "OnlMiddle"
        Me.OnlMiddle.Size = New System.Drawing.Size(654, 422)
        Me.OnlMiddle.TabIndex = 3
        '
        'TabConfiguracao
        '
        Me.TabConfiguracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabConfiguracao.Controls.Add(Me.CmbPlanoDeContas)
        Me.TabConfiguracao.Controls.Add(Me.GrpPlanoContas)
        Me.TabConfiguracao.Controls.Add(Me.BtnPlanoDeContasPesquisa)
        Me.TabConfiguracao.Controls.Add(Me.GrpMask)
        Me.TabConfiguracao.Controls.Add(Me.TxtPlanoDeContasPesquisa)
        Me.TabConfiguracao.Controls.Add(Me.GrpCodNome)
        Me.TabConfiguracao.Controls.Add(Me.Label2)
        Me.TabConfiguracao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabConfiguracao.Location = New System.Drawing.Point(4, 29)
        Me.TabConfiguracao.Name = "TabConfiguracao"
        Me.TabConfiguracao.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConfiguracao.Size = New System.Drawing.Size(647, 343)
        Me.TabConfiguracao.TabIndex = 0
        Me.TabConfiguracao.Text = "Configuração e Definição"
        Me.TabConfiguracao.UseVisualStyleBackColor = True
        '
        'GrpPlanoContas
        '
        Me.GrpPlanoContas.Controls.Add(Me.BtnEditar)
        Me.GrpPlanoContas.Controls.Add(Me.LblNivelEstoque)
        Me.GrpPlanoContas.Controls.Add(Me.TxtEstoque)
        Me.GrpPlanoContas.Controls.Add(Me.TxtAtivo)
        Me.GrpPlanoContas.Controls.Add(Me.LbpPatLiquido)
        Me.GrpPlanoContas.Controls.Add(Me.TxtPatLiquido)
        Me.GrpPlanoContas.Controls.Add(Me.LblDisponivel)
        Me.GrpPlanoContas.Controls.Add(Me.TxtDisponivel)
        Me.GrpPlanoContas.Controls.Add(Me.LblDespesa)
        Me.GrpPlanoContas.Controls.Add(Me.LblPassivo)
        Me.GrpPlanoContas.Controls.Add(Me.LblReceita)
        Me.GrpPlanoContas.Controls.Add(Me.LblAtivo)
        Me.GrpPlanoContas.Controls.Add(Me.TxtDespesa)
        Me.GrpPlanoContas.Controls.Add(Me.TxtPassivo)
        Me.GrpPlanoContas.Controls.Add(Me.TxtReceita)
        Me.GrpPlanoContas.Location = New System.Drawing.Point(20, 187)
        Me.GrpPlanoContas.Name = "GrpPlanoContas"
        Me.GrpPlanoContas.Size = New System.Drawing.Size(606, 144)
        Me.GrpPlanoContas.TabIndex = 2
        Me.GrpPlanoContas.TabStop = False
        Me.GrpPlanoContas.Text = "Plano de Contas"
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(540, 115)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(66, 27)
        Me.BtnEditar.TabIndex = 15
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'LblNivelEstoque
        '
        Me.LblNivelEstoque.AutoSize = True
        Me.LblNivelEstoque.Location = New System.Drawing.Point(336, 83)
        Me.LblNivelEstoque.Name = "LblNivelEstoque"
        Me.LblNivelEstoque.Size = New System.Drawing.Size(99, 18)
        Me.LblNivelEstoque.TabIndex = 14
        Me.LblNivelEstoque.Text = "Nível Estoque"
        '
        'TxtEstoque
        '
        Me.TxtEstoque.Location = New System.Drawing.Point(437, 79)
        Me.TxtEstoque.Mask = "0-0-00-00-00"
        Me.TxtEstoque.Name = "TxtEstoque"
        Me.TxtEstoque.Size = New System.Drawing.Size(97, 24)
        Me.TxtEstoque.TabIndex = 8
        Me.TxtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAtivo
        '
        Me.TxtAtivo.Location = New System.Drawing.Point(172, 25)
        Me.TxtAtivo.Mask = "0-0-00-00-00"
        Me.TxtAtivo.Name = "TxtAtivo"
        Me.TxtAtivo.Size = New System.Drawing.Size(97, 24)
        Me.TxtAtivo.TabIndex = 3
        Me.TxtAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbpPatLiquido
        '
        Me.LbpPatLiquido.AutoSize = True
        Me.LbpPatLiquido.Location = New System.Drawing.Point(49, 109)
        Me.LbpPatLiquido.Name = "LbpPatLiquido"
        Me.LbpPatLiquido.Size = New System.Drawing.Size(121, 18)
        Me.LbpPatLiquido.TabIndex = 12
        Me.LbpPatLiquido.Text = "Nível Pat. Líquido"
        '
        'TxtPatLiquido
        '
        Me.TxtPatLiquido.Location = New System.Drawing.Point(172, 106)
        Me.TxtPatLiquido.Mask = "0-0-00-00-00"
        Me.TxtPatLiquido.Name = "TxtPatLiquido"
        Me.TxtPatLiquido.Size = New System.Drawing.Size(97, 24)
        Me.TxtPatLiquido.TabIndex = 9
        Me.TxtPatLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDisponivel
        '
        Me.LblDisponivel.AutoSize = True
        Me.LblDisponivel.Location = New System.Drawing.Point(58, 82)
        Me.LblDisponivel.Name = "LblDisponivel"
        Me.LblDisponivel.Size = New System.Drawing.Size(112, 18)
        Me.LblDisponivel.TabIndex = 10
        Me.LblDisponivel.Text = "Nível Disponível"
        '
        'TxtDisponivel
        '
        Me.TxtDisponivel.Location = New System.Drawing.Point(172, 79)
        Me.TxtDisponivel.Mask = "0-0-00-00-00"
        Me.TxtDisponivel.Name = "TxtDisponivel"
        Me.TxtDisponivel.Size = New System.Drawing.Size(97, 24)
        Me.TxtDisponivel.TabIndex = 7
        Me.TxtDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDespesa
        '
        Me.LblDespesa.AutoSize = True
        Me.LblDespesa.Location = New System.Drawing.Point(332, 55)
        Me.LblDespesa.Name = "LblDespesa"
        Me.LblDespesa.Size = New System.Drawing.Size(103, 18)
        Me.LblDespesa.TabIndex = 8
        Me.LblDespesa.Text = "Nível Despesa"
        '
        'LblPassivo
        '
        Me.LblPassivo.AutoSize = True
        Me.LblPassivo.Location = New System.Drawing.Point(338, 28)
        Me.LblPassivo.Name = "LblPassivo"
        Me.LblPassivo.Size = New System.Drawing.Size(97, 18)
        Me.LblPassivo.TabIndex = 7
        Me.LblPassivo.Text = "Nível Passivo"
        '
        'LblReceita
        '
        Me.LblReceita.AutoSize = True
        Me.LblReceita.Location = New System.Drawing.Point(76, 55)
        Me.LblReceita.Name = "LblReceita"
        Me.LblReceita.Size = New System.Drawing.Size(94, 18)
        Me.LblReceita.TabIndex = 6
        Me.LblReceita.Text = "Nível Receita"
        '
        'LblAtivo
        '
        Me.LblAtivo.AutoSize = True
        Me.LblAtivo.Location = New System.Drawing.Point(94, 28)
        Me.LblAtivo.Name = "LblAtivo"
        Me.LblAtivo.Size = New System.Drawing.Size(76, 18)
        Me.LblAtivo.TabIndex = 5
        Me.LblAtivo.Text = "Nível Ativo"
        '
        'TxtDespesa
        '
        Me.TxtDespesa.Location = New System.Drawing.Point(437, 52)
        Me.TxtDespesa.Mask = "0-0-00-00-00"
        Me.TxtDespesa.Name = "TxtDespesa"
        Me.TxtDespesa.Size = New System.Drawing.Size(97, 24)
        Me.TxtDespesa.TabIndex = 6
        Me.TxtDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassivo
        '
        Me.TxtPassivo.Location = New System.Drawing.Point(437, 25)
        Me.TxtPassivo.Mask = "0-0-00-00-00"
        Me.TxtPassivo.Name = "TxtPassivo"
        Me.TxtPassivo.Size = New System.Drawing.Size(97, 24)
        Me.TxtPassivo.TabIndex = 4
        Me.TxtPassivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtReceita
        '
        Me.TxtReceita.Location = New System.Drawing.Point(172, 52)
        Me.TxtReceita.Mask = "0-0-00-00-00"
        Me.TxtReceita.Name = "TxtReceita"
        Me.TxtReceita.Size = New System.Drawing.Size(97, 24)
        Me.TxtReceita.TabIndex = 5
        Me.TxtReceita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GrpMask
        '
        Me.GrpMask.Controls.Add(Me.TxtMascara)
        Me.GrpMask.Location = New System.Drawing.Point(20, 117)
        Me.GrpMask.Name = "GrpMask"
        Me.GrpMask.Size = New System.Drawing.Size(606, 69)
        Me.GrpMask.TabIndex = 1
        Me.GrpMask.TabStop = False
        Me.GrpMask.Text = "Máscara"
        '
        'TxtMascara
        '
        Me.TxtMascara.Location = New System.Drawing.Point(31, 28)
        Me.TxtMascara.Mask = "0-0-00-00-00"
        Me.TxtMascara.Name = "TxtMascara"
        Me.TxtMascara.Size = New System.Drawing.Size(97, 24)
        Me.TxtMascara.TabIndex = 2
        Me.TxtMascara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GrpCodNome
        '
        Me.GrpCodNome.Controls.Add(Me.TxtNome)
        Me.GrpCodNome.Controls.Add(Me.TxtCod)
        Me.GrpCodNome.Location = New System.Drawing.Point(20, 42)
        Me.GrpCodNome.Name = "GrpCodNome"
        Me.GrpCodNome.Size = New System.Drawing.Size(606, 69)
        Me.GrpCodNome.TabIndex = 0
        Me.GrpCodNome.TabStop = False
        Me.GrpCodNome.Text = "Código/Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(171, 28)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(413, 24)
        Me.TxtNome.TabIndex = 1
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(31, 28)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(134, 24)
        Me.TxtCod.TabIndex = 0
        '
        'TabPlanoContas
        '
        Me.TabPlanoContas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPlanoContas.Controls.Add(Me.TabConfiguracao)
        Me.TabPlanoContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPlanoContas.ItemSize = New System.Drawing.Size(190, 25)
        Me.TabPlanoContas.Location = New System.Drawing.Point(145, 28)
        Me.TabPlanoContas.Name = "TabPlanoContas"
        Me.TabPlanoContas.Padding = New System.Drawing.Point(100, 4)
        Me.TabPlanoContas.SelectedIndex = 0
        Me.TabPlanoContas.Size = New System.Drawing.Size(655, 376)
        Me.TabPlanoContas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabPlanoContas.TabIndex = 0
        '
        'TabControleCadastroContas
        '
        Me.TabControleCadastroContas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControleCadastroContas.Controls.Add(Me.TabCadastroContas)
        Me.TabControleCadastroContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControleCadastroContas.ItemSize = New System.Drawing.Size(150, 25)
        Me.TabControleCadastroContas.Location = New System.Drawing.Point(145, 27)
        Me.TabControleCadastroContas.Name = "TabControleCadastroContas"
        Me.TabControleCadastroContas.Padding = New System.Drawing.Point(100, 4)
        Me.TabControleCadastroContas.SelectedIndex = 0
        Me.TabControleCadastroContas.Size = New System.Drawing.Size(655, 423)
        Me.TabControleCadastroContas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControleCadastroContas.TabIndex = 4
        '
        'TabCadastroContas
        '
        Me.TabCadastroContas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabCadastroContas.Controls.Add(Me.CmbNome)
        Me.TabCadastroContas.Controls.Add(Me.BtnAddConta)
        Me.TabCadastroContas.Controls.Add(Me.BtnPesquisar)
        Me.TabCadastroContas.Controls.Add(Me.TxtCodConta)
        Me.TabCadastroContas.Controls.Add(Me.Lbl)
        Me.TabCadastroContas.Controls.Add(Me.DgvContas)
        Me.TabCadastroContas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabCadastroContas.Location = New System.Drawing.Point(4, 29)
        Me.TabCadastroContas.Name = "TabCadastroContas"
        Me.TabCadastroContas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastroContas.Size = New System.Drawing.Size(647, 390)
        Me.TabCadastroContas.TabIndex = 0
        Me.TabCadastroContas.Text = "Cadastro de Contas"
        Me.TabCadastroContas.UseVisualStyleBackColor = True
        '
        'CmbNome
        '
        Me.CmbNome.FormattingEnabled = True
        Me.CmbNome.Location = New System.Drawing.Point(223, 38)
        Me.CmbNome.Name = "CmbNome"
        Me.CmbNome.Size = New System.Drawing.Size(419, 26)
        Me.CmbNome.TabIndex = 6
        '
        'TxtCodConta
        '
        Me.TxtCodConta.Location = New System.Drawing.Point(127, 39)
        Me.TxtCodConta.Name = "TxtCodConta"
        Me.TxtCodConta.Size = New System.Drawing.Size(70, 24)
        Me.TxtCodConta.TabIndex = 2
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(7, 42)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(118, 18)
        Me.Lbl.TabIndex = 1
        Me.Lbl.Text = "Plano de Contas"
        '
        'DgvContas
        '
        Me.DgvContas.AllowUserToAddRows = False
        Me.DgvContas.AllowUserToDeleteRows = False
        Me.DgvContas.AllowUserToResizeColumns = False
        Me.DgvContas.AllowUserToResizeRows = False
        Me.DgvContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvContas.Location = New System.Drawing.Point(3, 72)
        Me.DgvContas.Name = "DgvContas"
        Me.DgvContas.Size = New System.Drawing.Size(639, 313)
        Me.DgvContas.TabIndex = 0
        '
        'TabControleCadastroFornecedor
        '
        Me.TabControleCadastroFornecedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControleCadastroFornecedor.Controls.Add(Me.TabCadastroFornecedor)
        Me.TabControleCadastroFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControleCadastroFornecedor.ItemSize = New System.Drawing.Size(190, 25)
        Me.TabControleCadastroFornecedor.Location = New System.Drawing.Point(145, 27)
        Me.TabControleCadastroFornecedor.Name = "TabControleCadastroFornecedor"
        Me.TabControleCadastroFornecedor.Padding = New System.Drawing.Point(100, 4)
        Me.TabControleCadastroFornecedor.SelectedIndex = 0
        Me.TabControleCadastroFornecedor.Size = New System.Drawing.Size(655, 376)
        Me.TabControleCadastroFornecedor.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControleCadastroFornecedor.TabIndex = 5
        '
        'TabCadastroFornecedor
        '
        Me.TabCadastroFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabCadastroFornecedor.Controls.Add(Me.TxtPesquisarFornecedor)
        Me.TabCadastroFornecedor.Controls.Add(Me.BtnPesquisarFornecedor)
        Me.TabCadastroFornecedor.Controls.Add(Me.LblPesquisarFornecedor)
        Me.TabCadastroFornecedor.Controls.Add(Me.GrpContato)
        Me.TabCadastroFornecedor.Controls.Add(Me.GrpEndereco)
        Me.TabCadastroFornecedor.Controls.Add(Me.GrpInfo)
        Me.TabCadastroFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabCadastroFornecedor.Location = New System.Drawing.Point(4, 29)
        Me.TabCadastroFornecedor.Name = "TabCadastroFornecedor"
        Me.TabCadastroFornecedor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastroFornecedor.Size = New System.Drawing.Size(647, 343)
        Me.TabCadastroFornecedor.TabIndex = 0
        Me.TabCadastroFornecedor.Text = "Cadastro de Fornecedor"
        Me.TabCadastroFornecedor.UseVisualStyleBackColor = True
        '
        'TxtPesquisarFornecedor
        '
        Me.TxtPesquisarFornecedor.Location = New System.Drawing.Point(415, 5)
        Me.TxtPesquisarFornecedor.Name = "TxtPesquisarFornecedor"
        Me.TxtPesquisarFornecedor.Size = New System.Drawing.Size(182, 24)
        Me.TxtPesquisarFornecedor.TabIndex = 9
        '
        'LblPesquisarFornecedor
        '
        Me.LblPesquisarFornecedor.AutoSize = True
        Me.LblPesquisarFornecedor.Location = New System.Drawing.Point(187, 7)
        Me.LblPesquisarFornecedor.Name = "LblPesquisarFornecedor"
        Me.LblPesquisarFornecedor.Size = New System.Drawing.Size(222, 18)
        Me.LblPesquisarFornecedor.TabIndex = 8
        Me.LblPesquisarFornecedor.Text = "IdFornecedor ou Nome/Fantasia"
        '
        'GrpContato
        '
        Me.GrpContato.Controls.Add(Me.TxtTelefone)
        Me.GrpContato.Controls.Add(Me.LblTelefone)
        Me.GrpContato.Controls.Add(Me.TxtEmail)
        Me.GrpContato.Controls.Add(Me.LblEmail)
        Me.GrpContato.Location = New System.Drawing.Point(20, 274)
        Me.GrpContato.Name = "GrpContato"
        Me.GrpContato.Size = New System.Drawing.Size(606, 62)
        Me.GrpContato.TabIndex = 8
        Me.GrpContato.TabStop = False
        Me.GrpContato.Text = "Contatos"
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Location = New System.Drawing.Point(85, 26)
        Me.TxtTelefone.Mask = "(00) 0000-0000"
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(100, 24)
        Me.TxtTelefone.TabIndex = 6
        Me.TxtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.Location = New System.Drawing.Point(19, 29)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(65, 18)
        Me.LblTelefone.TabIndex = 7
        Me.LblTelefone.Text = "Telefone"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(256, 26)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(335, 24)
        Me.TxtEmail.TabIndex = 3
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(204, 29)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(50, 18)
        Me.LblEmail.TabIndex = 2
        Me.LblEmail.Text = "E-mail"
        '
        'GrpEndereco
        '
        Me.GrpEndereco.Controls.Add(Me.TxtEstado)
        Me.GrpEndereco.Controls.Add(Me.LblEstado)
        Me.GrpEndereco.Controls.Add(Me.TxtCidade)
        Me.GrpEndereco.Controls.Add(Me.LblCidade)
        Me.GrpEndereco.Controls.Add(Me.TxtBairro)
        Me.GrpEndereco.Controls.Add(Me.LblBairro)
        Me.GrpEndereco.Controls.Add(Me.TxtComp)
        Me.GrpEndereco.Controls.Add(Me.LblComp)
        Me.GrpEndereco.Controls.Add(Me.TxtEndereco)
        Me.GrpEndereco.Controls.Add(Me.TxtCep)
        Me.GrpEndereco.Controls.Add(Me.LblEndereco)
        Me.GrpEndereco.Controls.Add(Me.LblCEP)
        Me.GrpEndereco.Location = New System.Drawing.Point(20, 128)
        Me.GrpEndereco.Name = "GrpEndereco"
        Me.GrpEndereco.Size = New System.Drawing.Size(606, 144)
        Me.GrpEndereco.TabIndex = 2
        Me.GrpEndereco.TabStop = False
        Me.GrpEndereco.Text = "Endereço"
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(547, 88)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(44, 24)
        Me.TxtEstado.TabIndex = 17
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(490, 91)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(55, 18)
        Me.LblEstado.TabIndex = 16
        Me.LblEstado.Text = "Estado"
        '
        'TxtCidade
        '
        Me.TxtCidade.Location = New System.Drawing.Point(309, 88)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(175, 24)
        Me.TxtCidade.TabIndex = 15
        '
        'LblCidade
        '
        Me.LblCidade.AutoSize = True
        Me.LblCidade.Location = New System.Drawing.Point(253, 91)
        Me.LblCidade.Name = "LblCidade"
        Me.LblCidade.Size = New System.Drawing.Size(54, 18)
        Me.LblCidade.TabIndex = 14
        Me.LblCidade.Text = "Cidade"
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(69, 88)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(178, 24)
        Me.TxtBairro.TabIndex = 13
        '
        'LblBairro
        '
        Me.LblBairro.AutoSize = True
        Me.LblBairro.Location = New System.Drawing.Point(19, 91)
        Me.LblBairro.Name = "LblBairro"
        Me.LblBairro.Size = New System.Drawing.Size(48, 18)
        Me.LblBairro.TabIndex = 12
        Me.LblBairro.Text = "Bairro"
        '
        'TxtComp
        '
        Me.TxtComp.Location = New System.Drawing.Point(451, 57)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(140, 24)
        Me.TxtComp.TabIndex = 11
        '
        'LblComp
        '
        Me.LblComp.AutoSize = True
        Me.LblComp.Location = New System.Drawing.Point(400, 60)
        Me.LblComp.Name = "LblComp"
        Me.LblComp.Size = New System.Drawing.Size(49, 18)
        Me.LblComp.TabIndex = 10
        Me.LblComp.Text = "Comp"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(92, 57)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(302, 24)
        Me.TxtEndereco.TabIndex = 9
        '
        'TxtCep
        '
        Me.TxtCep.Location = New System.Drawing.Point(60, 27)
        Me.TxtCep.Mask = "00000-000"
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(80, 24)
        Me.TxtCep.TabIndex = 1
        Me.TxtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblEndereco
        '
        Me.LblEndereco.AutoSize = True
        Me.LblEndereco.Location = New System.Drawing.Point(19, 60)
        Me.LblEndereco.Name = "LblEndereco"
        Me.LblEndereco.Size = New System.Drawing.Size(72, 18)
        Me.LblEndereco.TabIndex = 8
        Me.LblEndereco.Text = "Endereço"
        '
        'LblCEP
        '
        Me.LblCEP.AutoSize = True
        Me.LblCEP.Location = New System.Drawing.Point(19, 30)
        Me.LblCEP.Name = "LblCEP"
        Me.LblCEP.Size = New System.Drawing.Size(39, 18)
        Me.LblCEP.TabIndex = 5
        Me.LblCEP.Text = "CEP"
        '
        'GrpInfo
        '
        Me.GrpInfo.Controls.Add(Me.TxtAtividade)
        Me.GrpInfo.Controls.Add(Me.LblAtividade)
        Me.GrpInfo.Controls.Add(Me.TxtFantasia)
        Me.GrpInfo.Controls.Add(Me.LblFantasia)
        Me.GrpInfo.Controls.Add(Me.TxtNomeFornecedor)
        Me.GrpInfo.Controls.Add(Me.LblNomeFornecedor)
        Me.GrpInfo.Controls.Add(Me.TxtIdFornecedor)
        Me.GrpInfo.Controls.Add(Me.LblIdFornecedor)
        Me.GrpInfo.Location = New System.Drawing.Point(20, 27)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(606, 98)
        Me.GrpInfo.TabIndex = 0
        Me.GrpInfo.TabStop = False
        Me.GrpInfo.Text = "Informações"
        '
        'TxtAtividade
        '
        Me.TxtAtividade.Location = New System.Drawing.Point(448, 60)
        Me.TxtAtividade.Name = "TxtAtividade"
        Me.TxtAtividade.Size = New System.Drawing.Size(143, 24)
        Me.TxtAtividade.TabIndex = 7
        '
        'LblAtividade
        '
        Me.LblAtividade.AutoSize = True
        Me.LblAtividade.Location = New System.Drawing.Point(380, 63)
        Me.LblAtividade.Name = "LblAtividade"
        Me.LblAtividade.Size = New System.Drawing.Size(66, 18)
        Me.LblAtividade.TabIndex = 6
        Me.LblAtividade.Text = "Atividade"
        '
        'TxtFantasia
        '
        Me.TxtFantasia.Location = New System.Drawing.Point(130, 60)
        Me.TxtFantasia.Name = "TxtFantasia"
        Me.TxtFantasia.Size = New System.Drawing.Size(241, 24)
        Me.TxtFantasia.TabIndex = 5
        '
        'LblFantasia
        '
        Me.LblFantasia.AutoSize = True
        Me.LblFantasia.Location = New System.Drawing.Point(19, 63)
        Me.LblFantasia.Name = "LblFantasia"
        Me.LblFantasia.Size = New System.Drawing.Size(109, 18)
        Me.LblFantasia.TabIndex = 4
        Me.LblFantasia.Text = "Nome Fantasia"
        '
        'TxtNomeFornecedor
        '
        Me.TxtNomeFornecedor.Location = New System.Drawing.Point(233, 28)
        Me.TxtNomeFornecedor.Name = "TxtNomeFornecedor"
        Me.TxtNomeFornecedor.Size = New System.Drawing.Size(358, 24)
        Me.TxtNomeFornecedor.TabIndex = 3
        '
        'LblNomeFornecedor
        '
        Me.LblNomeFornecedor.AutoSize = True
        Me.LblNomeFornecedor.Location = New System.Drawing.Point(182, 31)
        Me.LblNomeFornecedor.Name = "LblNomeFornecedor"
        Me.LblNomeFornecedor.Size = New System.Drawing.Size(49, 18)
        Me.LblNomeFornecedor.TabIndex = 2
        Me.LblNomeFornecedor.Text = "Nome"
        '
        'TxtIdFornecedor
        '
        Me.TxtIdFornecedor.Location = New System.Drawing.Point(118, 28)
        Me.TxtIdFornecedor.Name = "TxtIdFornecedor"
        Me.TxtIdFornecedor.Size = New System.Drawing.Size(53, 24)
        Me.TxtIdFornecedor.TabIndex = 1
        '
        'LblIdFornecedor
        '
        Me.LblIdFornecedor.AutoSize = True
        Me.LblIdFornecedor.Location = New System.Drawing.Point(19, 31)
        Me.LblIdFornecedor.Name = "LblIdFornecedor"
        Me.LblIdFornecedor.Size = New System.Drawing.Size(96, 18)
        Me.LblIdFornecedor.TabIndex = 0
        Me.LblIdFornecedor.Text = "IdFornecedor"
        '
        'TabControleCadastroProdutos
        '
        Me.TabControleCadastroProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControleCadastroProdutos.Controls.Add(Me.TabCadastroProduto)
        Me.TabControleCadastroProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControleCadastroProdutos.ItemSize = New System.Drawing.Size(150, 25)
        Me.TabControleCadastroProdutos.Location = New System.Drawing.Point(145, 27)
        Me.TabControleCadastroProdutos.Name = "TabControleCadastroProdutos"
        Me.TabControleCadastroProdutos.Padding = New System.Drawing.Point(100, 4)
        Me.TabControleCadastroProdutos.SelectedIndex = 0
        Me.TabControleCadastroProdutos.Size = New System.Drawing.Size(655, 376)
        Me.TabControleCadastroProdutos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControleCadastroProdutos.TabIndex = 6
        '
        'TabCadastroProduto
        '
        Me.TabCadastroProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabCadastroProduto.Controls.Add(Me.GroupBox1)
        Me.TabCadastroProduto.Controls.Add(Me.TxtPesquisarProduto)
        Me.TabCadastroProduto.Controls.Add(Me.BtnPesquisarProduto)
        Me.TabCadastroProduto.Controls.Add(Me.LblPesquisarProduto)
        Me.TabCadastroProduto.Controls.Add(Me.GrpFornecedor)
        Me.TabCadastroProduto.Controls.Add(Me.GrpInfoProdutos)
        Me.TabCadastroProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabCadastroProduto.Location = New System.Drawing.Point(4, 29)
        Me.TabCadastroProduto.Name = "TabCadastroProduto"
        Me.TabCadastroProduto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastroProduto.Size = New System.Drawing.Size(647, 343)
        Me.TabCadastroProduto.TabIndex = 0
        Me.TabCadastroProduto.Text = "Cadastro de Produto"
        Me.TabCadastroProduto.UseVisualStyleBackColor = True
        '
        'TxtPesquisarProduto
        '
        Me.TxtPesquisarProduto.Location = New System.Drawing.Point(169, 17)
        Me.TxtPesquisarProduto.Name = "TxtPesquisarProduto"
        Me.TxtPesquisarProduto.Size = New System.Drawing.Size(182, 24)
        Me.TxtPesquisarProduto.TabIndex = 12
        '
        'LblPesquisarProduto
        '
        Me.LblPesquisarProduto.AutoSize = True
        Me.LblPesquisarProduto.Location = New System.Drawing.Point(17, 20)
        Me.LblPesquisarProduto.Name = "LblPesquisarProduto"
        Me.LblPesquisarProduto.Size = New System.Drawing.Size(150, 18)
        Me.LblPesquisarProduto.TabIndex = 10
        Me.LblPesquisarProduto.Text = "IdProduto ou Produto"
        '
        'GrpFornecedor
        '
        Me.GrpFornecedor.Controls.Add(Me.CmbFornecedor)
        Me.GrpFornecedor.Controls.Add(Me.TxtIdFornecedorProduto)
        Me.GrpFornecedor.Controls.Add(Me.LblNomeFornecedorProduto)
        Me.GrpFornecedor.Controls.Add(Me.LblIdFornecedorProduto)
        Me.GrpFornecedor.Location = New System.Drawing.Point(20, 152)
        Me.GrpFornecedor.Name = "GrpFornecedor"
        Me.GrpFornecedor.Size = New System.Drawing.Size(606, 67)
        Me.GrpFornecedor.TabIndex = 2
        Me.GrpFornecedor.TabStop = False
        Me.GrpFornecedor.Text = "Fornecedor"
        '
        'CmbFornecedor
        '
        Me.CmbFornecedor.FormattingEnabled = True
        Me.CmbFornecedor.Location = New System.Drawing.Point(235, 27)
        Me.CmbFornecedor.Name = "CmbFornecedor"
        Me.CmbFornecedor.Size = New System.Drawing.Size(356, 26)
        Me.CmbFornecedor.TabIndex = 9
        '
        'TxtIdFornecedorProduto
        '
        Me.TxtIdFornecedorProduto.Location = New System.Drawing.Point(118, 28)
        Me.TxtIdFornecedorProduto.Name = "TxtIdFornecedorProduto"
        Me.TxtIdFornecedorProduto.Size = New System.Drawing.Size(53, 24)
        Me.TxtIdFornecedorProduto.TabIndex = 8
        '
        'LblNomeFornecedorProduto
        '
        Me.LblNomeFornecedorProduto.AutoSize = True
        Me.LblNomeFornecedorProduto.Location = New System.Drawing.Point(183, 31)
        Me.LblNomeFornecedorProduto.Name = "LblNomeFornecedorProduto"
        Me.LblNomeFornecedorProduto.Size = New System.Drawing.Size(49, 18)
        Me.LblNomeFornecedorProduto.TabIndex = 8
        Me.LblNomeFornecedorProduto.Text = "Nome"
        '
        'LblIdFornecedorProduto
        '
        Me.LblIdFornecedorProduto.AutoSize = True
        Me.LblIdFornecedorProduto.Location = New System.Drawing.Point(19, 31)
        Me.LblIdFornecedorProduto.Name = "LblIdFornecedorProduto"
        Me.LblIdFornecedorProduto.Size = New System.Drawing.Size(96, 18)
        Me.LblIdFornecedorProduto.TabIndex = 1
        Me.LblIdFornecedorProduto.Text = "IdFornecedor"
        '
        'GrpInfoProdutos
        '
        Me.GrpInfoProdutos.Controls.Add(Me.TxtDimensao)
        Me.GrpInfoProdutos.Controls.Add(Me.LblDimensao)
        Me.GrpInfoProdutos.Controls.Add(Me.TxtPeso)
        Me.GrpInfoProdutos.Controls.Add(Me.LblPeso)
        Me.GrpInfoProdutos.Controls.Add(Me.TxtProduto)
        Me.GrpInfoProdutos.Controls.Add(Me.LblProduto)
        Me.GrpInfoProdutos.Controls.Add(Me.TxtIdProduto)
        Me.GrpInfoProdutos.Controls.Add(Me.LblIdProduto)
        Me.GrpInfoProdutos.Location = New System.Drawing.Point(20, 51)
        Me.GrpInfoProdutos.Name = "GrpInfoProdutos"
        Me.GrpInfoProdutos.Size = New System.Drawing.Size(606, 98)
        Me.GrpInfoProdutos.TabIndex = 0
        Me.GrpInfoProdutos.TabStop = False
        Me.GrpInfoProdutos.Text = "Informações Produto"
        '
        'TxtDimensao
        '
        Me.TxtDimensao.Location = New System.Drawing.Point(245, 60)
        Me.TxtDimensao.Name = "TxtDimensao"
        Me.TxtDimensao.Size = New System.Drawing.Size(89, 24)
        Me.TxtDimensao.TabIndex = 7
        '
        'LblDimensao
        '
        Me.LblDimensao.AutoSize = True
        Me.LblDimensao.Location = New System.Drawing.Point(155, 63)
        Me.LblDimensao.Name = "LblDimensao"
        Me.LblDimensao.Size = New System.Drawing.Size(84, 18)
        Me.LblDimensao.TabIndex = 6
        Me.LblDimensao.Text = "Dimensões"
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(61, 59)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(84, 24)
        Me.TxtPeso.TabIndex = 5
        '
        'LblPeso
        '
        Me.LblPeso.AutoSize = True
        Me.LblPeso.Location = New System.Drawing.Point(19, 63)
        Me.LblPeso.Name = "LblPeso"
        Me.LblPeso.Size = New System.Drawing.Size(43, 18)
        Me.LblPeso.TabIndex = 4
        Me.LblPeso.Text = "Peso"
        '
        'TxtProduto
        '
        Me.TxtProduto.Location = New System.Drawing.Point(217, 28)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(374, 24)
        Me.TxtProduto.TabIndex = 3
        '
        'LblProduto
        '
        Me.LblProduto.AutoSize = True
        Me.LblProduto.Location = New System.Drawing.Point(155, 31)
        Me.LblProduto.Name = "LblProduto"
        Me.LblProduto.Size = New System.Drawing.Size(61, 18)
        Me.LblProduto.TabIndex = 2
        Me.LblProduto.Text = "Produto"
        '
        'TxtIdProduto
        '
        Me.TxtIdProduto.Location = New System.Drawing.Point(92, 28)
        Me.TxtIdProduto.Name = "TxtIdProduto"
        Me.TxtIdProduto.Size = New System.Drawing.Size(53, 24)
        Me.TxtIdProduto.TabIndex = 1
        '
        'LblIdProduto
        '
        Me.LblIdProduto.AutoSize = True
        Me.LblIdProduto.Location = New System.Drawing.Point(19, 31)
        Me.LblIdProduto.Name = "LblIdProduto"
        Me.LblIdProduto.Size = New System.Drawing.Size(72, 18)
        Me.LblIdProduto.TabIndex = 0
        Me.LblIdProduto.Text = "IdProduto"
        '
        'TabControleCadastroUsuarios
        '
        Me.TabControleCadastroUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControleCadastroUsuarios.Controls.Add(Me.TabCadastroUsuarios)
        Me.TabControleCadastroUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControleCadastroUsuarios.ItemSize = New System.Drawing.Size(170, 25)
        Me.TabControleCadastroUsuarios.Location = New System.Drawing.Point(145, 27)
        Me.TabControleCadastroUsuarios.Name = "TabControleCadastroUsuarios"
        Me.TabControleCadastroUsuarios.Padding = New System.Drawing.Point(100, 4)
        Me.TabControleCadastroUsuarios.SelectedIndex = 0
        Me.TabControleCadastroUsuarios.Size = New System.Drawing.Size(655, 376)
        Me.TabControleCadastroUsuarios.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControleCadastroUsuarios.TabIndex = 7
        '
        'TabCadastroUsuarios
        '
        Me.TabCadastroUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabCadastroUsuarios.Controls.Add(Me.TxtPesquisarUsuario)
        Me.TabCadastroUsuarios.Controls.Add(Me.BtnPesquisarUsuario)
        Me.TabCadastroUsuarios.Controls.Add(Me.LblPesquisarUsuario)
        Me.TabCadastroUsuarios.Controls.Add(Me.GrpSenha)
        Me.TabCadastroUsuarios.Controls.Add(Me.GrpInfoUsuario)
        Me.TabCadastroUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabCadastroUsuarios.Location = New System.Drawing.Point(4, 29)
        Me.TabCadastroUsuarios.Name = "TabCadastroUsuarios"
        Me.TabCadastroUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastroUsuarios.Size = New System.Drawing.Size(647, 343)
        Me.TabCadastroUsuarios.TabIndex = 0
        Me.TabCadastroUsuarios.Text = "Cadastro de Usuários"
        Me.TabCadastroUsuarios.UseVisualStyleBackColor = True
        '
        'LblPesquisarUsuario
        '
        Me.LblPesquisarUsuario.AutoSize = True
        Me.LblPesquisarUsuario.Location = New System.Drawing.Point(17, 11)
        Me.LblPesquisarUsuario.Name = "LblPesquisarUsuario"
        Me.LblPesquisarUsuario.Size = New System.Drawing.Size(38, 18)
        Me.LblPesquisarUsuario.TabIndex = 13
        Me.LblPesquisarUsuario.Text = "CPF"
        '
        'GrpSenha
        '
        Me.GrpSenha.Controls.Add(Me.CbVisualizar)
        Me.GrpSenha.Controls.Add(Me.TxtRSenha)
        Me.GrpSenha.Controls.Add(Me.LblRSenha)
        Me.GrpSenha.Controls.Add(Me.TxtSenha)
        Me.GrpSenha.Controls.Add(Me.LblSenha)
        Me.GrpSenha.Location = New System.Drawing.Point(20, 188)
        Me.GrpSenha.Name = "GrpSenha"
        Me.GrpSenha.Size = New System.Drawing.Size(606, 84)
        Me.GrpSenha.TabIndex = 2
        Me.GrpSenha.TabStop = False
        Me.GrpSenha.Text = "Senha"
        '
        'CbVisualizar
        '
        Me.CbVisualizar.AutoSize = True
        Me.CbVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVisualizar.Location = New System.Drawing.Point(468, 35)
        Me.CbVisualizar.Name = "CbVisualizar"
        Me.CbVisualizar.Size = New System.Drawing.Size(127, 20)
        Me.CbVisualizar.TabIndex = 7
        Me.CbVisualizar.Text = "Visualizar Senha"
        Me.CbVisualizar.UseVisualStyleBackColor = True
        '
        'TxtRSenha
        '
        Me.TxtRSenha.Location = New System.Drawing.Point(316, 33)
        Me.TxtRSenha.Name = "TxtRSenha"
        Me.TxtRSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtRSenha.Size = New System.Drawing.Size(139, 24)
        Me.TxtRSenha.TabIndex = 6
        '
        'LblRSenha
        '
        Me.LblRSenha.AutoSize = True
        Me.LblRSenha.Location = New System.Drawing.Point(213, 36)
        Me.LblRSenha.Name = "LblRSenha"
        Me.LblRSenha.Size = New System.Drawing.Size(101, 18)
        Me.LblRSenha.TabIndex = 6
        Me.LblRSenha.Text = "Repetir Senha"
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(64, 33)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(139, 24)
        Me.TxtSenha.TabIndex = 5
        '
        'LblSenha
        '
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Location = New System.Drawing.Point(13, 36)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(50, 18)
        Me.LblSenha.TabIndex = 4
        Me.LblSenha.Text = "Senha"
        '
        'GrpInfoUsuario
        '
        Me.GrpInfoUsuario.Controls.Add(Me.TxtEmailUsuario)
        Me.GrpInfoUsuario.Controls.Add(Me.LblEmailUsuario)
        Me.GrpInfoUsuario.Controls.Add(Me.CmbCargo)
        Me.GrpInfoUsuario.Controls.Add(Me.LblCargo)
        Me.GrpInfoUsuario.Controls.Add(Me.TxtCpfUsuario)
        Me.GrpInfoUsuario.Controls.Add(Me.TxtNomeUsuario)
        Me.GrpInfoUsuario.Controls.Add(Me.LblNomeUsuario)
        Me.GrpInfoUsuario.Controls.Add(Me.LblCpfUsuario)
        Me.GrpInfoUsuario.Location = New System.Drawing.Point(20, 45)
        Me.GrpInfoUsuario.Name = "GrpInfoUsuario"
        Me.GrpInfoUsuario.Size = New System.Drawing.Size(606, 123)
        Me.GrpInfoUsuario.TabIndex = 0
        Me.GrpInfoUsuario.TabStop = False
        Me.GrpInfoUsuario.Text = "Informações Usuário"
        '
        'TxtEmailUsuario
        '
        Me.TxtEmailUsuario.Location = New System.Drawing.Point(235, 69)
        Me.TxtEmailUsuario.Name = "TxtEmailUsuario"
        Me.TxtEmailUsuario.Size = New System.Drawing.Size(356, 24)
        Me.TxtEmailUsuario.TabIndex = 4
        '
        'LblEmailUsuario
        '
        Me.LblEmailUsuario.AutoSize = True
        Me.LblEmailUsuario.Location = New System.Drawing.Point(184, 72)
        Me.LblEmailUsuario.Name = "LblEmailUsuario"
        Me.LblEmailUsuario.Size = New System.Drawing.Size(50, 18)
        Me.LblEmailUsuario.TabIndex = 10
        Me.LblEmailUsuario.Text = "E-mail"
        '
        'CmbCargo
        '
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(61, 68)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(111, 26)
        Me.CmbCargo.TabIndex = 3
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Location = New System.Drawing.Point(9, 72)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(49, 18)
        Me.LblCargo.TabIndex = 9
        Me.LblCargo.Text = "Cargo"
        '
        'TxtCpfUsuario
        '
        Me.TxtCpfUsuario.Location = New System.Drawing.Point(61, 37)
        Me.TxtCpfUsuario.Mask = "000,000,000-00"
        Me.TxtCpfUsuario.Name = "TxtCpfUsuario"
        Me.TxtCpfUsuario.Size = New System.Drawing.Size(111, 24)
        Me.TxtCpfUsuario.TabIndex = 1
        '
        'TxtNomeUsuario
        '
        Me.TxtNomeUsuario.Location = New System.Drawing.Point(235, 37)
        Me.TxtNomeUsuario.Name = "TxtNomeUsuario"
        Me.TxtNomeUsuario.Size = New System.Drawing.Size(356, 24)
        Me.TxtNomeUsuario.TabIndex = 2
        '
        'LblNomeUsuario
        '
        Me.LblNomeUsuario.AutoSize = True
        Me.LblNomeUsuario.Location = New System.Drawing.Point(184, 40)
        Me.LblNomeUsuario.Name = "LblNomeUsuario"
        Me.LblNomeUsuario.Size = New System.Drawing.Size(49, 18)
        Me.LblNomeUsuario.TabIndex = 2
        Me.LblNomeUsuario.Text = "Nome"
        '
        'LblCpfUsuario
        '
        Me.LblCpfUsuario.AutoSize = True
        Me.LblCpfUsuario.Location = New System.Drawing.Point(19, 40)
        Me.LblCpfUsuario.Name = "LblCpfUsuario"
        Me.LblCpfUsuario.Size = New System.Drawing.Size(38, 18)
        Me.LblCpfUsuario.TabIndex = 0
        Me.LblCpfUsuario.Text = "CPF"
        '
        'TxtPesquisarUsuario
        '
        Me.TxtPesquisarUsuario.Location = New System.Drawing.Point(61, 8)
        Me.TxtPesquisarUsuario.Mask = "000,000,000-00"
        Me.TxtPesquisarUsuario.Name = "TxtPesquisarUsuario"
        Me.TxtPesquisarUsuario.Size = New System.Drawing.Size(111, 24)
        Me.TxtPesquisarUsuario.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbPlanoContasProduto)
        Me.GroupBox1.Controls.Add(Me.TxtClassificacaoProduto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 67)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plano de Contas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Classificação"
        '
        'TxtClassificacaoProduto
        '
        Me.TxtClassificacaoProduto.Location = New System.Drawing.Point(493, 29)
        Me.TxtClassificacaoProduto.Mask = "0-0-00-00-00"
        Me.TxtClassificacaoProduto.Name = "TxtClassificacaoProduto"
        Me.TxtClassificacaoProduto.Size = New System.Drawing.Size(98, 24)
        Me.TxtClassificacaoProduto.TabIndex = 2
        Me.TxtClassificacaoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbPlanoContasProduto
        '
        Me.CmbPlanoContasProduto.FormattingEnabled = True
        Me.CmbPlanoContasProduto.Location = New System.Drawing.Point(12, 28)
        Me.CmbPlanoContasProduto.Name = "CmbPlanoContasProduto"
        Me.CmbPlanoContasProduto.Size = New System.Drawing.Size(376, 26)
        Me.CmbPlanoContasProduto.TabIndex = 3
        '
        'CmbPlanoDeContas
        '
        Me.CmbPlanoDeContas.FormattingEnabled = True
        Me.CmbPlanoDeContas.Location = New System.Drawing.Point(266, 10)
        Me.CmbPlanoDeContas.Name = "CmbPlanoDeContas"
        Me.CmbPlanoDeContas.Size = New System.Drawing.Size(338, 26)
        Me.CmbPlanoDeContas.TabIndex = 19
        '
        'TxtPlanoDeContasPesquisa
        '
        Me.TxtPlanoDeContasPesquisa.Location = New System.Drawing.Point(170, 11)
        Me.TxtPlanoDeContasPesquisa.Name = "TxtPlanoDeContasPesquisa"
        Me.TxtPlanoDeContasPesquisa.Size = New System.Drawing.Size(70, 24)
        Me.TxtPlanoDeContasPesquisa.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Plano de Contas"
        '
        'BtnAddConta
        '
        Me.BtnAddConta.FlatAppearance.BorderSize = 0
        Me.BtnAddConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddConta.Image = Global.Contabilidade.My.Resources.Resources.addIcon
        Me.BtnAddConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddConta.Location = New System.Drawing.Point(10, 3)
        Me.BtnAddConta.Name = "BtnAddConta"
        Me.BtnAddConta.Size = New System.Drawing.Size(153, 34)
        Me.BtnAddConta.TabIndex = 5
        Me.BtnAddConta.Text = "Adicionar Conta"
        Me.BtnAddConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddConta.UseVisualStyleBackColor = True
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.searchIcon
        Me.BtnPesquisar.FlatAppearance.BorderSize = 0
        Me.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisar.Location = New System.Drawing.Point(201, 43)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(16, 16)
        Me.BtnPesquisar.TabIndex = 4
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'BtnPesquisarFornecedor
        '
        Me.BtnPesquisarFornecedor.BackgroundImage = Global.Contabilidade.My.Resources.Resources.searchIcon
        Me.BtnPesquisarFornecedor.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarFornecedor.Location = New System.Drawing.Point(610, 7)
        Me.BtnPesquisarFornecedor.Name = "BtnPesquisarFornecedor"
        Me.BtnPesquisarFornecedor.Size = New System.Drawing.Size(16, 16)
        Me.BtnPesquisarFornecedor.TabIndex = 9
        Me.BtnPesquisarFornecedor.UseVisualStyleBackColor = True
        '
        'BtnPesquisarUsuario
        '
        Me.BtnPesquisarUsuario.BackgroundImage = Global.Contabilidade.My.Resources.Resources.searchIcon
        Me.BtnPesquisarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarUsuario.Location = New System.Drawing.Point(178, 12)
        Me.BtnPesquisarUsuario.Name = "BtnPesquisarUsuario"
        Me.BtnPesquisarUsuario.Size = New System.Drawing.Size(16, 16)
        Me.BtnPesquisarUsuario.TabIndex = 14
        Me.BtnPesquisarUsuario.UseVisualStyleBackColor = True
        '
        'BtnPesquisarProduto
        '
        Me.BtnPesquisarProduto.BackgroundImage = Global.Contabilidade.My.Resources.Resources.searchIcon
        Me.BtnPesquisarProduto.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarProduto.Location = New System.Drawing.Point(364, 21)
        Me.BtnPesquisarProduto.Name = "BtnPesquisarProduto"
        Me.BtnPesquisarProduto.Size = New System.Drawing.Size(16, 16)
        Me.BtnPesquisarProduto.TabIndex = 11
        Me.BtnPesquisarProduto.UseVisualStyleBackColor = True
        '
        'BtnPlanoDeContasPesquisa
        '
        Me.BtnPlanoDeContasPesquisa.BackgroundImage = Global.Contabilidade.My.Resources.Resources.searchIcon
        Me.BtnPlanoDeContasPesquisa.FlatAppearance.BorderSize = 0
        Me.BtnPlanoDeContasPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlanoDeContasPesquisa.Location = New System.Drawing.Point(244, 15)
        Me.BtnPlanoDeContasPesquisa.Name = "BtnPlanoDeContasPesquisa"
        Me.BtnPlanoDeContasPesquisa.Size = New System.Drawing.Size(16, 16)
        Me.BtnPlanoDeContasPesquisa.TabIndex = 18
        Me.BtnPlanoDeContasPesquisa.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.cancelar2
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(493, 378)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(128, 37)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.salvar
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Location = New System.Drawing.Point(359, 378)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(128, 37)
        Me.BtnSalvar.TabIndex = 0
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCadastrarUsuarios
        '
        Me.BtnCadastrarUsuarios.BackgroundImage = Global.Contabilidade.My.Resources.Resources.adduse
        Me.BtnCadastrarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCadastrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarUsuarios.Location = New System.Drawing.Point(5, 222)
        Me.BtnCadastrarUsuarios.Name = "BtnCadastrarUsuarios"
        Me.BtnCadastrarUsuarios.Size = New System.Drawing.Size(139, 48)
        Me.BtnCadastrarUsuarios.TabIndex = 6
        Me.BtnCadastrarUsuarios.Text = "Cadastro de    Usuários  "
        Me.BtnCadastrarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastrarUsuarios.UseVisualStyleBackColor = True
        '
        'BtnCadastrarProdutos
        '
        Me.BtnCadastrarProdutos.BackgroundImage = Global.Contabilidade.My.Resources.Resources.prudtos1
        Me.BtnCadastrarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCadastrarProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarProdutos.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarProdutos.Location = New System.Drawing.Point(3, 168)
        Me.BtnCadastrarProdutos.Name = "BtnCadastrarProdutos"
        Me.BtnCadastrarProdutos.Size = New System.Drawing.Size(139, 48)
        Me.BtnCadastrarProdutos.TabIndex = 5
        Me.BtnCadastrarProdutos.Text = "Cadastro de    Produtos  "
        Me.BtnCadastrarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastrarProdutos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Contabilidade.My.Resources.Resources.logoABL2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(11, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 71)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BtnCadastroEmpresa
        '
        Me.BtnCadastroEmpresa.BackgroundImage = Global.Contabilidade.My.Resources.Resources.empresa
        Me.BtnCadastroEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCadastroEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastroEmpresa.FlatAppearance.BorderSize = 0
        Me.BtnCadastroEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastroEmpresa.Location = New System.Drawing.Point(3, 114)
        Me.BtnCadastroEmpresa.Name = "BtnCadastroEmpresa"
        Me.BtnCadastroEmpresa.Size = New System.Drawing.Size(139, 48)
        Me.BtnCadastroEmpresa.TabIndex = 3
        Me.BtnCadastroEmpresa.Text = "Cadastro de    Fornecedor  "
        Me.BtnCadastroEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastroEmpresa.UseVisualStyleBackColor = True
        '
        'BtnCadastroContas
        '
        Me.BtnCadastroContas.BackgroundImage = Global.Contabilidade.My.Resources.Resources.addPlanodeContas
        Me.BtnCadastroContas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCadastroContas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastroContas.FlatAppearance.BorderSize = 0
        Me.BtnCadastroContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastroContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastroContas.Location = New System.Drawing.Point(3, 60)
        Me.BtnCadastroContas.Name = "BtnCadastroContas"
        Me.BtnCadastroContas.Size = New System.Drawing.Size(139, 48)
        Me.BtnCadastroContas.TabIndex = 2
        Me.BtnCadastroContas.Text = "Cadastro de  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contas  "
        Me.BtnCadastroContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastroContas.UseVisualStyleBackColor = True
        '
        'BtnPlanoContas
        '
        Me.BtnPlanoContas.BackgroundImage = Global.Contabilidade.My.Resources.Resources.addPlanodeContas2
        Me.BtnPlanoContas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPlanoContas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlanoContas.FlatAppearance.BorderSize = 0
        Me.BtnPlanoContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlanoContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlanoContas.Location = New System.Drawing.Point(3, 6)
        Me.BtnPlanoContas.Name = "BtnPlanoContas"
        Me.BtnPlanoContas.Size = New System.Drawing.Size(139, 48)
        Me.BtnPlanoContas.TabIndex = 1
        Me.BtnPlanoContas.Text = "Plano de  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contas  "
        Me.BtnPlanoContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPlanoContas.UseVisualStyleBackColor = True
        '
        'PicClose
        '
        Me.PicClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicClose.Image = Global.Contabilidade.My.Resources.Resources.cancelar
        Me.PicClose.Location = New System.Drawing.Point(772, 6)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(16, 16)
        Me.PicClose.TabIndex = 0
        Me.PicClose.TabStop = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 450)
        Me.Controls.Add(Me.TabControleCadastroContas)
        Me.Controls.Add(Me.TabControleCadastroFornecedor)
        Me.Controls.Add(Me.TabControleCadastroUsuarios)
        Me.Controls.Add(Me.TabControleCadastroProdutos)
        Me.Controls.Add(Me.TabPlanoContas)
        Me.Controls.Add(Me.OnlMiddle)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.PnlLeft.ResumeLayout(False)
        Me.OnlMiddle.ResumeLayout(False)
        Me.TabConfiguracao.ResumeLayout(False)
        Me.TabConfiguracao.PerformLayout()
        Me.GrpPlanoContas.ResumeLayout(False)
        Me.GrpPlanoContas.PerformLayout()
        Me.GrpMask.ResumeLayout(False)
        Me.GrpMask.PerformLayout()
        Me.GrpCodNome.ResumeLayout(False)
        Me.GrpCodNome.PerformLayout()
        Me.TabPlanoContas.ResumeLayout(False)
        Me.TabControleCadastroContas.ResumeLayout(False)
        Me.TabCadastroContas.ResumeLayout(False)
        Me.TabCadastroContas.PerformLayout()
        CType(Me.DgvContas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControleCadastroFornecedor.ResumeLayout(False)
        Me.TabCadastroFornecedor.ResumeLayout(False)
        Me.TabCadastroFornecedor.PerformLayout()
        Me.GrpContato.ResumeLayout(False)
        Me.GrpContato.PerformLayout()
        Me.GrpEndereco.ResumeLayout(False)
        Me.GrpEndereco.PerformLayout()
        Me.GrpInfo.ResumeLayout(False)
        Me.GrpInfo.PerformLayout()
        Me.TabControleCadastroProdutos.ResumeLayout(False)
        Me.TabCadastroProduto.ResumeLayout(False)
        Me.TabCadastroProduto.PerformLayout()
        Me.GrpFornecedor.ResumeLayout(False)
        Me.GrpFornecedor.PerformLayout()
        Me.GrpInfoProdutos.ResumeLayout(False)
        Me.GrpInfoProdutos.PerformLayout()
        Me.TabControleCadastroUsuarios.ResumeLayout(False)
        Me.TabCadastroUsuarios.ResumeLayout(False)
        Me.TabCadastroUsuarios.PerformLayout()
        Me.GrpSenha.ResumeLayout(False)
        Me.GrpSenha.PerformLayout()
        Me.GrpInfoUsuario.ResumeLayout(False)
        Me.GrpInfoUsuario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PicClose As PictureBox
    Friend WithEvents PnlLeft As Panel
    Friend WithEvents BtnCadastroEmpresa As Button
    Friend WithEvents BtnCadastroContas As Button
    Friend WithEvents BtnPlanoContas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OnlMiddle As Panel
    Friend WithEvents TabConfiguracao As TabPage
    Friend WithEvents GrpPlanoContas As GroupBox
    Friend WithEvents LblDisponivel As Label
    Friend WithEvents TxtDisponivel As MaskedTextBox
    Friend WithEvents LblDespesa As Label
    Friend WithEvents LblPassivo As Label
    Friend WithEvents LblReceita As Label
    Friend WithEvents LblAtivo As Label
    Friend WithEvents TxtDespesa As MaskedTextBox
    Friend WithEvents TxtPassivo As MaskedTextBox
    Friend WithEvents TxtReceita As MaskedTextBox
    Friend WithEvents TxtAtivo As MaskedTextBox
    Friend WithEvents GrpMask As GroupBox
    Friend WithEvents TxtMascara As MaskedTextBox
    Friend WithEvents GrpCodNome As GroupBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents TabPlanoContas As TabControl
    Friend WithEvents LbpPatLiquido As Label
    Friend WithEvents TxtPatLiquido As MaskedTextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents TabControleCadastroContas As TabControl
    Friend WithEvents TabCadastroContas As TabPage
    Friend WithEvents DgvContas As DataGridView
    Friend WithEvents BtnAddConta As Button
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents TxtCodConta As TextBox
    Friend WithEvents Lbl As Label
    Friend WithEvents BtnCadastrarProdutos As Button
    Friend WithEvents TabControleCadastroFornecedor As TabControl
    Friend WithEvents TabCadastroFornecedor As TabPage
    Friend WithEvents GrpEndereco As GroupBox
    Friend WithEvents TxtCep As MaskedTextBox
    Friend WithEvents LblCEP As Label
    Friend WithEvents TxtComp As TextBox
    Friend WithEvents LblComp As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents LblEndereco As Label
    Friend WithEvents GrpInfo As GroupBox
    Friend WithEvents TxtAtividade As TextBox
    Friend WithEvents LblAtividade As Label
    Friend WithEvents TxtFantasia As TextBox
    Friend WithEvents LblFantasia As Label
    Friend WithEvents TxtNomeFornecedor As TextBox
    Friend WithEvents LblNomeFornecedor As Label
    Friend WithEvents TxtIdFornecedor As TextBox
    Friend WithEvents LblIdFornecedor As Label
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents LblCidade As Label
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents LblBairro As Label
    Friend WithEvents GrpContato As GroupBox
    Friend WithEvents TxtTelefone As MaskedTextBox
    Friend WithEvents LblTelefone As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TabControleCadastroProdutos As TabControl
    Friend WithEvents TabCadastroProduto As TabPage
    Friend WithEvents GrpFornecedor As GroupBox
    Friend WithEvents GrpInfoProdutos As GroupBox
    Friend WithEvents TxtDimensao As TextBox
    Friend WithEvents LblDimensao As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents LblPeso As Label
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents LblProduto As Label
    Friend WithEvents TxtIdProduto As TextBox
    Friend WithEvents LblIdProduto As Label
    Friend WithEvents PnlPositionActive As Panel
    Friend WithEvents CmbFornecedor As ComboBox
    Friend WithEvents TxtIdFornecedorProduto As TextBox
    Friend WithEvents LblNomeFornecedorProduto As Label
    Friend WithEvents LblIdFornecedorProduto As Label
    Friend WithEvents BtnCadastrarUsuarios As Button
    Friend WithEvents TabControleCadastroUsuarios As TabControl
    Friend WithEvents TabCadastroUsuarios As TabPage
    Friend WithEvents GrpSenha As GroupBox
    Friend WithEvents CbVisualizar As CheckBox
    Friend WithEvents TxtRSenha As TextBox
    Friend WithEvents LblRSenha As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents LblSenha As Label
    Friend WithEvents GrpInfoUsuario As GroupBox
    Friend WithEvents TxtEmailUsuario As TextBox
    Friend WithEvents LblEmailUsuario As Label
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents LblCargo As Label
    Friend WithEvents TxtCpfUsuario As MaskedTextBox
    Friend WithEvents TxtNomeUsuario As TextBox
    Friend WithEvents LblNomeUsuario As Label
    Friend WithEvents LblCpfUsuario As Label
    Friend WithEvents LblNivelEstoque As Label
    Friend WithEvents TxtEstoque As MaskedTextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents CmbNome As ComboBox
    Friend WithEvents TxtPesquisarFornecedor As TextBox
    Friend WithEvents BtnPesquisarFornecedor As Button
    Friend WithEvents LblPesquisarFornecedor As Label
    Friend WithEvents TxtPesquisarProduto As TextBox
    Friend WithEvents BtnPesquisarProduto As Button
    Friend WithEvents LblPesquisarProduto As Label
    Friend WithEvents BtnPesquisarUsuario As Button
    Friend WithEvents LblPesquisarUsuario As Label
    Friend WithEvents TxtPesquisarUsuario As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtClassificacaoProduto As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbPlanoContasProduto As ComboBox
    Friend WithEvents CmbPlanoDeContas As ComboBox
    Friend WithEvents BtnPlanoDeContasPesquisa As Button
    Friend WithEvents TxtPlanoDeContasPesquisa As TextBox
    Friend WithEvents Label2 As Label
End Class
