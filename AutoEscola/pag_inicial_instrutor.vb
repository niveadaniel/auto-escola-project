Public Class pag_inicial_instrutor
    Private Sub btn_agenda_teoricas_Click(sender As Object, e As EventArgs) Handles btn_agenda_teoricas.Click
        AGENDA_TEORICAS.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub btn_agenda_praticas_Click(sender As Object, e As EventArgs) Handles btn_agenda_praticas.Click
        AGENDA_PRATICAS.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub pag_inicial_instrutor_Load(sender As Object, e As EventArgs) Handles Me.Load
        With LOGIN
            nome.Text = nome_instrutor
        End With
    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        LOGIN.Show()
        Me.Finalize()
        Me.Close()
    End Sub
End Class