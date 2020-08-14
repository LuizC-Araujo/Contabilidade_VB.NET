Public Class FrmCadastroContas
    Private Sub FrmCadastroContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()

        LblPlanoContas.Text = aux
        LoadContas()
    End Sub

    Private Sub LoadContas()
        Dim a, contRows As Integer
        contRows = -1
        DgvContas.ColumnCount = 2

        DgvContas.Columns(0).Name = "Chamada"
        DgvContas.Columns(0).HeaderText = "Chamada"
        DgvContas.Columns(0).DataPropertyName = "Chamada"
        'DgvContas.Columns(0).Width = 35



        DgvContas.Columns(1).Name = "Descrição"
        DgvContas.Columns(1).HeaderText = "Descrição"
        DgvContas.Columns(1).DataPropertyName = "Descrição"



        sql = "SELECT * FROM TBCONTROLEPLANODECONTAS WHERE PLANOCONTAS = '" & LblPlanoContas.Text & "' ORDER BY CLASSIFICACAOINTERNA ASC"
        rs = db.Execute(sql)
        With Me.DgvContas
            .Rows.Clear()
            While rs.EOF = False
                .Rows.Add(rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            End While

        End With
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

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        sql = "INSERT INTO TBCONTROLEPLANODECONTAS (PLANOCONTAS, CHAMADA, CLASSIFICACAOINTERNA, DESCRICAOCONTA)" &
                      "VALUES ('" & LblPlanoContas.Text & "', " & TxtChamada.Text & ", '" & TxtClassificacao.Text & "', '" & TxtDescricao.Text & "')"
        db.Execute(sql)

        MsgBox("Conta cadastrada com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        LimparContas()
        LoadContas()
    End Sub

    Private Sub LimparContas()
        TxtChamada.Text = ""
        TxtClassificacao.Text = ""
        TxtDescricao.Text = ""
        TxtChamada.Select()
    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContas.CellContentClick

    End Sub
End Class