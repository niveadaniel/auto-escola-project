Public Class PAGAMENTO
    Private Sub PAGAMENTO_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        txt_forma_pagamento.Items.Clear()
        txt_forma_pagamento.Items.Add("À vista")
        txt_forma_pagamento.Items.Add("Cartão de crédito - 2x")
        txt_forma_pagamento.Items.Add("Cartão de crédito - 3x")
        txt_forma_pagamento.Items.Add("Cartão de crédito - 4x")
        txt_forma_pagamento.Items.Add("Cartão de crédito - 5x")
        txt_forma_pagamento.SelectedText = "Selecione"
        gerar_dados_pagamento()

    End Sub

    Private Sub txt_valor_pago_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_pago.TextChanged


        If (txt_valor_total.Text <> "" And txt_valor_pago.Text <> "") Then
            txt_valor_pago_decimal = Convert.ToDecimal(txt_valor_pago.Text)
            txt_valor_total_decimal = Convert.ToDecimal(txt_valor_total.Text)
            txt_valor_restante.Text = txt_valor_total_decimal - txt_valor_pago_decimal
        Else
            txt_valor_restante.Text = txt_valor_total.Text
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try

            If (txt_cpf_aluno.Text = "" Or txt_forma_pagamento.Text = "" Or txt_valor_total.Text = "" Or
                txt_categoria.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_pagamento values ('" & txt_cpf_aluno.Text & "', " &
                                                    "'" & txt_nome_aluno.Text & "', " &
                                                    "'" & txt_forma_pagamento.Text & "', " &
                                                    "'" & txt_valor_total.Text & "', " &
                                                    "'" & txt_valor_pago.Text & "', " &
                                                    "'" & txt_categoria.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_aluno()
                gerar_dados_aluno()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_nome_aluno_GotFocus(sender As Object, e As EventArgs) Handles txt_nome_aluno.GotFocus
        Try
            sql = "select * from tb_aluno where cpf_aluno ='" & txt_cpf_aluno.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome_aluno.Text = rs.Fields(1).Value
            Else
                txt_cpf_aluno.Focus()
                MsgBox("Aluno não cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        pag_inicial_usuario.Show()
        Me.Close()
        Me.Finalize()
    End Sub

    Private Sub txt_valor_restante_GotFocus(sender As Object, e As EventArgs) Handles txt_valor_restante.GotFocus
        If (txt_valor_pago.Text = "") Then
            txt_valor_restante.Text = txt_valor_total.Text
        End If
    End Sub
End Class