﻿Public Class AGENDA_PRATICAS
    Private Sub AGENDA_PRATICAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        gerar_dados_agenda_pratica()
        With LOGIN
            instrutor = cod_instrutor
            If (txt_opcao = 1) Then
                dgv_dados.Columns(7).Visible = False
                dgv_dados.Columns(6).Visible = False
            Else
                dgv_dados.Columns(7).Visible = True
                dgv_dados.Columns(6).Visible = True
            End If
        End With
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        With LOGIN
            If (txt_opcao = 1) Then
                pag_inicial_instrutor.Show()
                Me.Finalize()
                Me.Close()
            Else
                pag_inicial_usuario.Show()
                Me.Finalize()
                Me.Close()
            End If
        End With
    End Sub

    Private Sub dvg_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(6).Selected = True Then
                    aux = .CurrentRow.Cells(4).Value.ToString
                    sql = "select * from tb_aula_pratica where aluno = '" & aux & "'"
                    rs = db.Execute(sql)
                    With AGENDAMENTO_PRATICAS
                        .txt_carro.Items.Clear()
                        .txt_horario.Items.Clear()
                        .txt_cod_instrutor.Text = rs.Fields(0).Value
                        .txt_cpf_aluno.Text = rs.Fields(1).Value
                        .txt_carro.Text = rs.Fields(2).Value
                        .txt_data_inicio.Text = rs.Fields(3).Value
                        .txt_data_fim.Text = rs.Fields(4).Value
                        .txt_horario.Text = rs.Fields(5).Value
                    End With
                    editar_praticas = True
                    AGENDAMENTO_PRATICAS.Show()
                    Me.Finalize()
                    Me.Close()
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux = .CurrentRow.Cells(4).Value.ToString
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                                "CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_aula_pratica where aluno = '" & aux & "'"
                        rs = db.Execute(sql)
                        gerar_dados_agenda_pratica()
                    End If
                Else
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            Exit Sub
            MsgBox("Erro ao executar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class