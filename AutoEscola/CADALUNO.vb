Public Class CADALUNO
    Private Sub CADALUNO_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        gerar_dados_aluno()
        btn_editar.Hide()
        btn_save.Show()
    End Sub


    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName 'diretório da imagem
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If (txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_rg.Text = "" Or txt_cep.Text = "" Or
                txt_nasc.Text = "" Or txt_endereco.Text = "" Or txt_bairro.Text = "" Or
                txt_cidade.Text = "" Or txt_uf.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_aluno values ('" & txt_cpf.Text & "', " &
                                                    "'" & txt_nome.Text & "', " &
                                                    "'" & txt_nasc.Text & "', " &
                                                    "'" & txt_rg.Text & "', " &
                                                    "'" & txt_cep.Text & "', " &
                                                    "'" & txt_endereco.Text & "', " &
                                                    "'" & txt_comp.Text & "', " &
                                                    "'" & txt_bairro.Text & "', " &
                                                    "'" & txt_cidade.Text & "', " &
                                                    "'" & txt_uf.Text & "', " &
                                                    "'" & diretorio & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_aluno()
                gerar_dados_aluno()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "select * from tb_cep where cep ='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_comp.Focus()
            Else
                MsgBox("CEP não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        pag_inicial_usuario.Show()
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

        Try
            With dgv_dados
                If .CurrentRow.Cells(2).Selected = True Then
                    btn_editar.Show()
                    btn_save.Hide()
                    TabControl1.SelectTab(0)
                    aux = .CurrentRow.Cells(0).Value.ToString
                    sql = "select * from tb_aluno where cpf_aluno = '" & aux & "'"
                    rs = db.Execute(sql)
                    txt_cpf.Text = rs.Fields(0).Value
                    txt_nome.Text = rs.Fields(1).Value
                    txt_nasc.Text = rs.Fields(2).Value
                    txt_rg.Text = rs.Fields(3).Value
                    txt_cep.Text = rs.Fields(4).Value
                    txt_endereco.Text = rs.Fields(5).Value
                    txt_comp.Text = rs.Fields(6).Value
                    txt_bairro.Text = rs.Fields(7).Value
                    txt_cidade.Text = rs.Fields(8).Value
                    txt_uf.Text = rs.Fields(9).Value
                    img_foto.Load(rs.Fields(10).Value)

                ElseIf .CurrentRow.Cells(3).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value.ToString
                    resp = MsgBox("Deseja realmente exlcuir o" + vbNewLine &
                                "CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_aluno where cpf_aluno = '" & aux & "'"
                        rs = db.Execute(sql)
                        gerar_dados_aluno()
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

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            If (txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_rg.Text = "" Or txt_cep.Text = "" Or
                txt_nasc.Text = "" Or txt_endereco.Text = "" Or txt_bairro.Text = "" Or
                txt_cidade.Text = "" Or txt_uf.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "update tb_aluno set cpf_aluno = '" & txt_cpf.Text & "'," &
                                                                "nome_aluno = '" & txt_nome.Text & "'," &
                                                                "data_nasc_aluno = '" & txt_nasc.Text & "'," &
                                                                "rg_aluno = '" & txt_rg.Text & "'," &
                                                                "cep_aluno = '" & txt_cep.Text & "'," &
                                                                "endereco_aluno = '" & txt_endereco.Text & "'," &
                                                                "comp_aluno = '" & txt_comp.Text & "'," &
                                                                "bairro_aluno = '" & txt_bairro.Text & "'," &
                                                                "cidade_aluno = '" & txt_cidade.Text & "'," &
                                                                "uf_aluno = '" & txt_uf.Text & "'," &
                                                                "img_aluno = '" & diretorio & "' where cpf_aluno = '" & txt_cpf.Text & "'"


                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_aluno()
                gerar_dados_aluno()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class


