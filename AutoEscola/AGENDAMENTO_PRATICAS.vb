Public Class AGENDAMENTO_PRATICAS
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        pag_inicial_usuario.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub AGENDAMENTO_PRATICAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        txt_data_fim.Value = txt_data_inicio.Value.AddDays(14)
        If (editar_praticas = True) Then
            btn_editar.Show()
            btn_cadastrar.Hide()
        Else
            btn_editar.Hide()
            btn_cadastrar.Show()
        End If

    End Sub

    Private Sub txt_data_inicio_ValueChanged(sender As Object, e As EventArgs) Handles txt_data_inicio.ValueChanged
        txt_horario.Items.Clear()
        txt_horario.Items.Add("7h-9h")
        txt_horario.Items.Add("9h-11h")
        txt_horario.Items.Add("11h-13h")
        txt_horario.Items.Add("14h-16h")
        txt_horario.Items.Add("16h-18h")
        'txt_horario.SelectedIndex = 0

        txt_data_fim.Value = txt_data_inicio.Value.AddDays(14)
        conecta_banco()

        x = 0
        Do While (x < txt_horario.Items.Count)
            sql = "select * from tb_aula_pratica"
            rs = db.Execute(sql)
            Do While rs.EOF = False And x < txt_horario.Items.Count
                If (txt_data_inicio.Value <= rs.Fields(4).Value And rs.Fields(5).Value = txt_horario.Items(x) And
                    rs.Fields(0).Value = txt_cod_instrutor.Text) Then
                    txt_horario.Items.Remove(txt_horario.Items(x))
                End If
                rs.MoveNext()
            Loop
            x = x + 1
        Loop
    End Sub



    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If (txt_cod_instrutor.Text = "" Or txt_cpf_aluno.Text.Length < 14 Or txt_data_inicio.Text = "" Or
                txt_data_fim.Text = "" Or txt_horario.Text = "" Or txt_carro.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_aula_pratica values ('" & txt_cod_instrutor.Text & "', " &
                                                    "'" & txt_cpf_aluno.Text & "', " &
                                                    "'" & txt_carro.Text & "', " &
                                                    "'" & txt_data_inicio.Text & "', " &
                                                    "'" & txt_data_fim.Text & "', " &
                                                    "'" & txt_horario.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_praticas()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_nome_instrutor_GotFocus(sender As Object, e As EventArgs) Handles txt_nome_instrutor.GotFocus
        Try
            sql = "select * from tb_instrutor where cod_instrutor ='" & txt_cod_instrutor.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome_instrutor.Text = rs.Fields(2).Value
            Else
                txt_cod_instrutor.Focus()
                MsgBox("Instrutor não cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    Private Sub txt_horario_SelectedValueChanged(sender As Object, e As EventArgs) Handles txt_horario.SelectedValueChanged
        txt_carro.Items.Clear()
        txt_carro.Items.Add("ABC-0022")
        txt_carro.Items.Add("DGS-5643")
        txt_carro.Items.Add("FDS-7844")
        txt_carro.Items.Add("JGK-9662")
        txt_carro.Items.Add("NAF-1374")
        txt_carro.Items.Add("ASD-5790")
        txt_carro.Items.Add("LVI-5522")
        'txt_carro.SelectedIndex = 0

        conecta_banco()

        x = 0

        Do While (x < txt_carro.Items.Count)
            sql = "select * from tb_aula_pratica"
            rs = db.Execute(sql)
            Do While rs.EOF = False And x < txt_carro.Items.Count
                If (txt_data_inicio.Value <= rs.Fields(4).Value And rs.Fields(2).Value = txt_carro.Items(x) And
                    rs.Fields(5).Value = txt_horario.Text) Then
                    txt_carro.Items.Remove(txt_carro.Items(x))
                End If
                rs.MoveNext()
            Loop
            x = x + 1
        Loop
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            If (txt_cod_instrutor.Text = "" Or txt_cpf_aluno.Text.Length < 14 Or txt_data_inicio.Text = "" Or
                txt_data_fim.Text = "" Or txt_horario.Text = "" Or txt_carro.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "update tb_aula_pratica set cod_instrutor = '" & txt_cod_instrutor.Text & "'," &
                                                                "carro = '" & txt_carro.Text & "'," &
                                                                "data_inicio = '" & txt_data_inicio.Text & "'," &
                                                                "data_fim = '" & txt_data_fim.Text & "'," &
                                                                "horario = '" & txt_horario.Text & "' where aluno = '" & txt_cpf_aluno.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_praticas()
                AGENDA_PRATICAS.Show()
                Me.Finalize()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class