Public Class agendamento_teoricas
    Private Sub agendamento_teoricas_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_data_fim.Value = txt_data_inicio.Value.AddDays(9)
        conecta_banco()
        If (editar = True) Then
            btn_editar.Show()
            btn_cadastrar.Hide()
        Else
            btn_editar.Hide()
            btn_cadastrar.Show()
        End If

    End Sub

    Private Sub txt_data_inicio_ValueChanged(sender As Object, e As EventArgs) Handles txt_data_inicio.ValueChanged
        txt_horario.Items.Clear()
        txt_horario.Items.Add("7h-12h")
        txt_horario.Items.Add("13h-18h")
        txt_horario.Items.Add("19h-23h")

        txt_data_fim.Value = txt_data_inicio.Value.AddDays(9)

        conecta_banco()
        sql = "select * from tb_aula_teorica"
        rs = db.Execute(sql)
        x = 0

        Do While (x < txt_horario.Items.Count)
            limite = 0
            Do While rs.EOF = False And x < txt_horario.Items.Count
                If (txt_data_inicio.Value <= rs.Fields(2).Value And rs.Fields(3).Value = txt_horario.Items(x) And
                    txt_cod_instrutor.Text = rs.Fields(0).Value) Then
                    limite = limite + 1
                End If
                rs.MoveNext()
            Loop
            If (limite >= 3) Then
                txt_horario.Items.Remove(txt_horario.Items(x))
            End If
            x = x + 1
        Loop
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If (txt_cod_instrutor.Text = "" Or txt_cpf_aluno.Text = "" Or txt_data_inicio.Text = "" Or
                txt_data_fim.Text = "" Or txt_horario.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_aula_teorica values ('" & txt_cod_instrutor.Text & "', " &
                                                    "'" & txt_data_inicio.Text & "', " &
                                                    "'" & txt_data_fim.Text & "', " &
                                                    "'" & txt_horario.Text & "', " &
                                                    "'" & txt_cpf_aluno.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_teoricas()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        pag_inicial_usuario.Show()
        Me.Finalize()
        Me.Close()
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

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            If (txt_cod_instrutor.Text = "" Or txt_cpf_aluno.Text = "" Or txt_data_inicio.Text = "" Or
                txt_data_fim.Text = "" Or txt_horario.Text = "") Then
                MsgBox("Alguns itens obrigatórios não foram preenchidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "update tb_aula_teorica set cod_instrutor = '" & txt_cod_instrutor.Text & "'," &
                                                                "data_inicio = '" & txt_data_inicio.Text & "'," &
                                                                "data_fim = '" & txt_data_fim.Text & "'," &
                                                                "horario = '" & txt_horario.Text & "' where aluno = '" & txt_cpf_aluno.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_teoricas()
                AGENDA_TEORICAS.Show()
                Me.Finalize()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class