Public Class CADINSTRUTOR
    Private Sub CADINSTRUTOR_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        gerar_dados_instrutor()
        btn_editar.Hide()
        btn_save.Show()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If (txt_senha_instrutor.Text <> txt_repetir_senha.Text) Then
                MsgBox("Senhas não coincidem, por favor digite novamente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                txt_senha_instrutor.Clear()
                txt_repetir_senha.Clear()
                txt_senha_instrutor.Focus()

            ElseIf (txt_cpf_instrutor.Text = "" Or txt_cod_instrutor.Text = "" Or txt_nome.Text = "" Or
                    txt_rg_instrutor.Text = "" Or txt_cep_instrutor.Text = "" Or txt_nasc.Text = "" Or
                    txt_senha_instrutor.Text = "" Or txt_repetir_senha.Text = "" Or txt_endereco_instrutor.Text = "" Or
                    txt_bairro_instrutor.Text = "" Or txt_cidade_instrutor.Text = "" Or txt_uf_instrutor.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = "insert into tb_instrutor values ('" & txt_cpf_instrutor.Text & "', " &
                                                    "'" & txt_cod_instrutor.Text & "', " &
                                                    "'" & txt_nome.Text & "', " &
                                                    "'" & txt_nasc.Text & "', " &
                                                    "'" & txt_rg_instrutor.Text & "', " &
                                                    "'" & txt_cep_instrutor.Text & "', " &
                                                    "'" & txt_endereco_instrutor.Text & "', " &
                                                    "'" & txt_complemento.Text & "', " &
                                                    "'" & txt_bairro_instrutor.Text & "', " &
                                                    "'" & txt_cidade_instrutor.Text & "', " &
                                                    "'" & txt_uf_instrutor.Text & "', " &
                                                    "'" & txt_senha_instrutor.Text & "', " &
                                                    "'" & diretorio & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_instrutor()
                gerar_dados_instrutor()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName 'diretório da imagem
                PictureBox1.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_cep_instrutor_LostFocus(sender As Object, e As EventArgs) Handles txt_cep_instrutor.LostFocus
        Try
            sql = "select * from tb_cep where cep ='" & txt_cep_instrutor.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco_instrutor.Text = rs.Fields(1).Value
                txt_bairro_instrutor.Text = rs.Fields(3).Value
                txt_cidade_instrutor.Text = rs.Fields(2).Value
                txt_uf_instrutor.Text = rs.Fields(4).Value
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
                If .CurrentRow.Cells(3).Selected = True Then
                    btn_save.Hide()
                    btn_editar.Show()
                    TabControl1.SelectTab(0)
                    aux = .CurrentRow.Cells(2).Value.ToString
                    sql = "select * from tb_instrutor where cpf_instrutor = '" & aux & "'"
                    rs = db.Execute(sql)
                    txt_cpf_instrutor.Text = rs.Fields(0).Value
                    txt_cod_instrutor.Text = rs.Fields(1).Value
                    txt_nome.Text = rs.Fields(2).Value
                    txt_nasc.Text = rs.Fields(3).Value
                    txt_rg_instrutor.Text = rs.Fields(4).Value
                    txt_cep_instrutor.Text = rs.Fields(5).Value
                    txt_endereco_instrutor.Text = rs.Fields(6).Value
                    txt_complemento.Text = rs.Fields(7).Value
                    txt_bairro_instrutor.Text = rs.Fields(8).Value
                    txt_cidade_instrutor.Text = rs.Fields(9).Value
                    txt_uf_instrutor.Text = rs.Fields(10).Value
                    txt_senha_instrutor.Text = rs.Fields(11).Value
                    txt_repetir_senha.Text = txt_senha_instrutor.Text
                    img_foto.Load(rs.Fields(12).Value)

                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(2).Value.ToString
                    resp = MsgBox("Deseja realmente exlcuir o" + vbNewLine &
                                "CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_instrutor where cpf_instrutor = '" & aux & "'"
                        rs = db.Execute(sql)
                        gerar_dados_instrutor()
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
            If (txt_senha_instrutor.Text <> txt_repetir_senha.Text) Then
                MsgBox("Senhas não coincidem, por favor digite novamente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                txt_senha_instrutor.Clear()
                txt_repetir_senha.Clear()
                txt_senha_instrutor.Focus()

            ElseIf (txt_cpf_instrutor.Text = "" Or txt_cod_instrutor.Text = "" Or txt_nome.Text = "" Or
                    txt_rg_instrutor.Text = "" Or txt_cep_instrutor.Text = "" Or txt_nasc.Text = "" Or
                    txt_senha_instrutor.Text = "" Or txt_repetir_senha.Text = "" Or txt_endereco_instrutor.Text = "" Or
                    txt_bairro_instrutor.Text = "" Or txt_cidade_instrutor.Text = "" Or txt_uf_instrutor.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = "update tb_instrutor set cpf_instrutor = '" & txt_cpf_instrutor.Text & "'," &
                                                                "cod_instrutor = '" & txt_cod_instrutor.Text & "'," &
                                                                "nome_instrutor = '" & txt_nome.Text & "'," &
                                                                "data_nasc_instrutor = '" & txt_nasc.Text & "'," &
                                                                "rg_instrutor = '" & txt_rg_instrutor.Text & "'," &
                                                                "cep_instrutor = '" & txt_cep_instrutor.Text & "'," &
                                                                "endereco_instrutor = '" & txt_endereco_instrutor.Text & "'," &
                                                                "comp_instrutor = '" & txt_complemento.Text & "'," &
                                                                "bairro_instrutor = '" & txt_bairro_instrutor.Text & "'," &
                                                                "cidade_instrutor = '" & txt_cidade_instrutor.Text & "'," &
                                                                "uf_instrutor = '" & txt_uf_instrutor.Text & "'," &
                                                                "senha_instrutor = '" & txt_senha_instrutor.Text & "'," &
                                                                "img_instrutor = '" & diretorio & "' where cpf_instrutor = '" & txt_cpf_instrutor.Text & "'"


                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_instrutor()
                gerar_dados_instrutor()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class