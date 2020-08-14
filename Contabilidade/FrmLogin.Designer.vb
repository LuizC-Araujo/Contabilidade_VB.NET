<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.TxtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.PnlLeft = New System.Windows.Forms.Panel()
        Me.PnlRight = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LblCpf = New System.Windows.Forms.Label()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCpf
        '
        Me.TxtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtCpf.Location = New System.Drawing.Point(175, 127)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(95, 22)
        Me.TxtCpf.TabIndex = 1
        '
        'TxtSenha
        '
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtSenha.Location = New System.Drawing.Point(175, 180)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(95, 22)
        Me.TxtSenha.TabIndex = 2
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.PicClose)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(330, 28)
        Me.PnlTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(138, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'PicClose
        '
        Me.PicClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicClose.Image = Global.Contabilidade.My.Resources.Resources.cancelar
        Me.PicClose.Location = New System.Drawing.Point(301, 6)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(16, 16)
        Me.PicClose.TabIndex = 0
        Me.PicClose.TabStop = False
        '
        'PnlLeft
        '
        Me.PnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.Location = New System.Drawing.Point(0, 28)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Size = New System.Drawing.Size(3, 300)
        Me.PnlLeft.TabIndex = 11
        '
        'PnlRight
        '
        Me.PnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlRight.Location = New System.Drawing.Point(327, 28)
        Me.PnlRight.Name = "PnlRight"
        Me.PnlRight.Size = New System.Drawing.Size(3, 300)
        Me.PnlRight.TabIndex = 12
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Contabilidade.My.Resources.Resources.logoABL
        Me.PictureBox3.Location = New System.Drawing.Point(111, 52)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 61)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Contabilidade.My.Resources.Resources.prateleira
        Me.PictureBox2.Location = New System.Drawing.Point(35, 214)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(260, 32)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Global.Contabilidade.My.Resources.Resources.panel2
        Me.Panel6.Controls.Add(Me.LblSenha)
        Me.Panel6.Location = New System.Drawing.Point(64, 175)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(113, 34)
        Me.Panel6.TabIndex = 5
        '
        'LblSenha
        '
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSenha.Location = New System.Drawing.Point(27, 6)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(61, 20)
        Me.LblSenha.TabIndex = 5
        Me.LblSenha.Text = "Senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Contabilidade.My.Resources.Resources.prateleira
        Me.PictureBox1.Location = New System.Drawing.Point(35, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 32)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.BackgroundImage = Global.Contabilidade.My.Resources.Resources.entrar
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Location = New System.Drawing.Point(80, 252)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(174, 46)
        Me.BtnEntrar.TabIndex = 3
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.Contabilidade.My.Resources.Resources.panel
        Me.Panel5.Controls.Add(Me.LblCpf)
        Me.Panel5.Location = New System.Drawing.Point(64, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(113, 34)
        Me.Panel5.TabIndex = 4
        '
        'LblCpf
        '
        Me.LblCpf.AutoSize = True
        Me.LblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCpf.Location = New System.Drawing.Point(34, 7)
        Me.LblCpf.Name = "LblCpf"
        Me.LblCpf.Size = New System.Drawing.Size(43, 20)
        Me.LblCpf.TabIndex = 5
        Me.LblCpf.Text = "CPF"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 328)
        Me.Controls.Add(Me.PnlRight)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblCpf As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblSenha As Label
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents TxtSenha As MaskedTextBox
    Friend WithEvents PicClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PnlLeft As Panel
    Friend WithEvents PnlRight As Panel
    Friend WithEvents Label1 As Label
End Class
