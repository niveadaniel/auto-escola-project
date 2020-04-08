Public Class LOGIN

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        opcoes.Items.Add("Instrutor")
        opcoes.Items.Add("Usuário")
        opcoes.SelectedText = "Selecione"

        conecta_banco()
    End Sub


    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        If (opcoes.SelectedItem = "Instrutor") Then
            sql = "select * from tb_instrutor"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                If (rs.Fields(1).Value = txt_usuario.Text And rs.Fields(11).Value = txt_senha.Text) Then
                    cod_instrutor = txt_usuario.Text
                    nome_instrutor = rs.Fields(2).Value
                    txt_opcao = 1
                    pag_inicial_instrutor.Show()
                    Me.Finalize()
                    Me.Close()
                    Exit Sub
                End If
                rs.MoveNext()
            Loop
            MsgBox("Código ou senha incorretos, por favor tente novamente")
            txt_usuario.Clear()
            txt_senha.Clear()
            txt_usuario.Focus()
        ElseIf (opcoes.SelectedItem = "Usuário") Then
            sql = "select * from tb_usuario"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                If (rs.Fields(2).Value = txt_usuario.Text And rs.Fields(3).Value = txt_senha.Text) Then
                    usuario = rs.Fields(1).Value
                    pag_inicial_usuario.Show()
                    txt_opcao = 2
                    Me.Finalize()
                    Me.Close()
                    Exit Sub
                End If
                rs.MoveNext()
            Loop
            MsgBox("Usuário ou senha incorreto, por favor tente novamente")
            txt_usuario.Clear()
            txt_senha.Clear()
            txt_usuario.Focus()
        Else
            MsgBox("Por favor selecione uma opção para logar")
        End If

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        CADUSUARIO.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class