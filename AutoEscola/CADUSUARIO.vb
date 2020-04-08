Public Class CADUSUARIO


    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If (txt_senha.Text <> txt_repetir_senha.Text) Then
                MsgBox("Senhas não coincidem, por favor digite novamente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                txt_senha.Clear()
                txt_repetir_senha.Clear()
                txt_senha.Focus()

            ElseIf (txt_cpf.Text = "" Or txt_senha.Text = "" Or txt_repetir_senha.Text = "" Or
                    txt_usuario.Text = "" Or txt_nome.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = "insert into tb_usuario values ('" & txt_cpf.Text & "', " &
                                                    "'" & txt_nome.Text & "', " &
                                                    "'" & txt_usuario.Text & "', " &
                                                    "'" & txt_senha.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_instrutor()
                Me.Finalize()
                LOGIN.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub CADUSUARIO_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        LOGIN.Show()
        Me.Finalize()
        Me.Close()
    End Sub
End Class