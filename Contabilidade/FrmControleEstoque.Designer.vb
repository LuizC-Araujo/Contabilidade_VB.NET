<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControleEstoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.TxtIdProduto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbProduto = New System.Windows.Forms.ComboBox()
        Me.CbDebito = New System.Windows.Forms.CheckBox()
        Me.CbCredito = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtFrete = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbOperacao = New System.Windows.Forms.ComboBox()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtValorUnitario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLote = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.DateTimePicker()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.PnlTop.Size = New System.Drawing.Size(568, 28)
        Me.PnlTop.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(239, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ESTOQUE"
        '
        'PicClose
        '
        Me.PicClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicClose.Image = Global.Contabilidade.My.Resources.Resources.cancelar
        Me.PicClose.Location = New System.Drawing.Point(540, 7)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(16, 16)
        Me.PicClose.TabIndex = 0
        Me.PicClose.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Produto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPesquisar)
        Me.GroupBox1.Controls.Add(Me.TxtIdProduto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CmbFornecedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbProduto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 106)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Produto"
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.searchIcon
        Me.BtnPesquisar.FlatAppearance.BorderSize = 0
        Me.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisar.Location = New System.Drawing.Point(203, 24)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(16, 16)
        Me.BtnPesquisar.TabIndex = 11
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'TxtIdProduto
        '
        Me.TxtIdProduto.Location = New System.Drawing.Point(127, 22)
        Me.TxtIdProduto.Name = "TxtIdProduto"
        Me.TxtIdProduto.Size = New System.Drawing.Size(70, 20)
        Me.TxtIdProduto.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Código do Produto"
        '
        'CmbFornecedor
        '
        Me.CmbFornecedor.FormattingEnabled = True
        Me.CmbFornecedor.Location = New System.Drawing.Point(92, 60)
        Me.CmbFornecedor.Name = "CmbFornecedor"
        Me.CmbFornecedor.Size = New System.Drawing.Size(121, 21)
        Me.CmbFornecedor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fornecedor"
        '
        'CmbProduto
        '
        Me.CmbProduto.FormattingEnabled = True
        Me.CmbProduto.Location = New System.Drawing.Point(270, 60)
        Me.CmbProduto.Name = "CmbProduto"
        Me.CmbProduto.Size = New System.Drawing.Size(121, 21)
        Me.CmbProduto.TabIndex = 4
        '
        'CbDebito
        '
        Me.CbDebito.AutoSize = True
        Me.CbDebito.Location = New System.Drawing.Point(60, 37)
        Me.CbDebito.Name = "CbDebito"
        Me.CbDebito.Size = New System.Drawing.Size(57, 17)
        Me.CbDebito.TabIndex = 5
        Me.CbDebito.Text = "Débito"
        Me.CbDebito.UseVisualStyleBackColor = True
        '
        'CbCredito
        '
        Me.CbCredito.AutoSize = True
        Me.CbCredito.Location = New System.Drawing.Point(132, 37)
        Me.CbCredito.Name = "CbCredito"
        Me.CbCredito.Size = New System.Drawing.Size(59, 17)
        Me.CbCredito.TabIndex = 6
        Me.CbCredito.Text = "Crédito"
        Me.CbCredito.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtFrete)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CmbOperacao)
        Me.GroupBox2.Controls.Add(Me.CbCredito)
        Me.GroupBox2.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CbDebito)
        Me.GroupBox2.Controls.Add(Me.TxtValorUnitario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtLote)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtQuantidade)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 141)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações de Entrada e Saída"
        '
        'TxtFrete
        '
        Me.TxtFrete.Location = New System.Drawing.Point(142, 94)
        Me.TxtFrete.Name = "TxtFrete"
        Me.TxtFrete.Size = New System.Drawing.Size(100, 20)
        Me.TxtFrete.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Frete"
        '
        'CmbOperacao
        '
        Me.CmbOperacao.FormattingEnabled = True
        Me.CmbOperacao.Location = New System.Drawing.Point(205, 35)
        Me.CmbOperacao.Name = "CmbOperacao"
        Me.CmbOperacao.Size = New System.Drawing.Size(121, 21)
        Me.CmbOperacao.TabIndex = 8
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.Location = New System.Drawing.Point(360, 94)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorTotal.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Operação"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(357, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Valor Total"
        '
        'TxtValorUnitario
        '
        Me.TxtValorUnitario.Location = New System.Drawing.Point(250, 94)
        Me.TxtValorUnitario.Name = "TxtValorUnitario"
        Me.TxtValorUnitario.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorUnitario.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Valor Unitário"
        '
        'TxtLote
        '
        Me.TxtLote.Location = New System.Drawing.Point(337, 36)
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.Size = New System.Drawing.Size(100, 20)
        Me.TxtLote.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Lote"
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.Location = New System.Drawing.Point(34, 94)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.TxtQuantidade.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantidade"
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(315, 47)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(213, 20)
        Me.TxtData.TabIndex = 8
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.cancelar2
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(302, 342)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(128, 37)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.salvar
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Location = New System.Drawing.Point(168, 342)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(128, 37)
        Me.BtnSalvar.TabIndex = 9
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'FrmControleEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 390)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.TxtData)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmControleEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PicClose As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIdProduto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbFornecedor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbProduto As ComboBox
    Friend WithEvents CbDebito As CheckBox
    Friend WithEvents CbCredito As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbOperacao As ComboBox
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtValorUnitario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtData As DateTimePicker
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents TxtFrete As TextBox
    Friend WithEvents Label10 As Label
End Class
