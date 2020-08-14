<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroContas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblPlanoContas = New System.Windows.Forms.Label()
        Me.LblChamada = New System.Windows.Forms.Label()
        Me.TxtChamada = New System.Windows.Forms.TextBox()
        Me.LblClassificacao = New System.Windows.Forms.Label()
        Me.TxtClassificacao = New System.Windows.Forms.MaskedTextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.LblDescricao = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.DgvContas = New System.Windows.Forms.DataGridView()
        Me.PnlTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvContas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlTop.Size = New System.Drawing.Size(665, 28)
        Me.PnlTop.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(241, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CADASTRAR CONTAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblPlanoContas)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plano de Contas"
        '
        'LblPlanoContas
        '
        Me.LblPlanoContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlanoContas.Location = New System.Drawing.Point(6, 22)
        Me.LblPlanoContas.Name = "LblPlanoContas"
        Me.LblPlanoContas.Size = New System.Drawing.Size(277, 23)
        Me.LblPlanoContas.TabIndex = 0
        Me.LblPlanoContas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblChamada
        '
        Me.LblChamada.AutoSize = True
        Me.LblChamada.Location = New System.Drawing.Point(59, 115)
        Me.LblChamada.Name = "LblChamada"
        Me.LblChamada.Size = New System.Drawing.Size(52, 13)
        Me.LblChamada.TabIndex = 5
        Me.LblChamada.Text = "Chamada"
        '
        'TxtChamada
        '
        Me.TxtChamada.Location = New System.Drawing.Point(59, 131)
        Me.TxtChamada.Name = "TxtChamada"
        Me.TxtChamada.Size = New System.Drawing.Size(100, 20)
        Me.TxtChamada.TabIndex = 6
        '
        'LblClassificacao
        '
        Me.LblClassificacao.AutoSize = True
        Me.LblClassificacao.Location = New System.Drawing.Point(178, 115)
        Me.LblClassificacao.Name = "LblClassificacao"
        Me.LblClassificacao.Size = New System.Drawing.Size(69, 13)
        Me.LblClassificacao.TabIndex = 7
        Me.LblClassificacao.Text = "Classificação"
        '
        'TxtClassificacao
        '
        Me.TxtClassificacao.Location = New System.Drawing.Point(181, 131)
        Me.TxtClassificacao.Mask = "0-0-00-00-00"
        Me.TxtClassificacao.Name = "TxtClassificacao"
        Me.TxtClassificacao.Size = New System.Drawing.Size(100, 20)
        Me.TxtClassificacao.TabIndex = 8
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(59, 180)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(221, 20)
        Me.TxtDescricao.TabIndex = 10
        '
        'LblDescricao
        '
        Me.LblDescricao.AutoSize = True
        Me.LblDescricao.Location = New System.Drawing.Point(59, 164)
        Me.LblDescricao.Name = "LblDescricao"
        Me.LblDescricao.Size = New System.Drawing.Size(101, 13)
        Me.LblDescricao.TabIndex = 9
        Me.LblDescricao.Text = "Descrição da Conta"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.cancelar2
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(176, 227)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(128, 37)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.salvar
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Location = New System.Drawing.Point(42, 227)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(128, 37)
        Me.BtnSalvar.TabIndex = 11
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'PicClose
        '
        Me.PicClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicClose.Image = Global.Contabilidade.My.Resources.Resources.cancelar
        Me.PicClose.Location = New System.Drawing.Point(636, 6)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(16, 16)
        Me.PicClose.TabIndex = 0
        Me.PicClose.TabStop = False
        '
        'DgvContas
        '
        Me.DgvContas.AllowUserToAddRows = False
        Me.DgvContas.AllowUserToDeleteRows = False
        Me.DgvContas.AllowUserToResizeColumns = False
        Me.DgvContas.AllowUserToResizeRows = False
        Me.DgvContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContas.Location = New System.Drawing.Point(337, 44)
        Me.DgvContas.Name = "DgvContas"
        Me.DgvContas.Size = New System.Drawing.Size(316, 220)
        Me.DgvContas.TabIndex = 13
        '
        'FrmCadastroContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 280)
        Me.Controls.Add(Me.DgvContas)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.LblDescricao)
        Me.Controls.Add(Me.TxtClassificacao)
        Me.Controls.Add(Me.LblClassificacao)
        Me.Controls.Add(Me.TxtChamada)
        Me.Controls.Add(Me.LblChamada)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadastroContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadastroContas"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvContas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PicClose As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblPlanoContas As Label
    Friend WithEvents LblChamada As Label
    Friend WithEvents TxtChamada As TextBox
    Friend WithEvents LblClassificacao As Label
    Friend WithEvents TxtClassificacao As MaskedTextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents LblDescricao As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents DgvContas As DataGridView
End Class
