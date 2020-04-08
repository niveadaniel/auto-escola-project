Public Class pag_inicial_usuario
    Private Sub btn_cad_aluno_Click(sender As Object, e As EventArgs) Handles btn_cad_aluno.Click
        CADALUNO.Show()
        Me.Close()
    End Sub

    Private Sub btn_cad_instrutor_Click(sender As Object, e As EventArgs) Handles btn_cad_instrutor.Click
        CADINSTRUTOR.Show()
        Me.Close()
    End Sub

    Private Sub btn_agendamento_teoricas_Click(sender As Object, e As EventArgs) Handles btn_agendamento_teoricas.Click
        agendamento_teoricas.Show()
        Me.Close()
    End Sub

    Private Sub btn_agendamento_praticas_Click(sender As Object, e As EventArgs) Handles btn_agendamento_praticas.Click
        AGENDAMENTO_PRATICAS.Show()
        Me.Close()
    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub pag_inicial_usuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        With LOGIN
            nome.Text = usuario
        End With
        editar = False
        editar_praticas = False
    End Sub

    Private Sub btn_agenda_praticas_Click(sender As Object, e As EventArgs) Handles btn_agenda_praticas.Click
        AGENDA_PRATICAS.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub btn_agenda_teoricas_Click(sender As Object, e As EventArgs) Handles btn_agenda_teoricas.Click
        AGENDA_TEORICAS.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub btn_pagamentos_Click(sender As Object, e As EventArgs) Handles btn_pagamentos.Click
        PAGAMENTO.Show()
        Me.Finalize()
        Me.Close()
    End Sub
End Class