Module Module1
    Public db As New ADODB.Connection 'Variável Banco
    Public rs As New ADODB.Recordset 'Variável Tabela
    Public sql, aux, resp, diretorio, instrutor, usuario, cod_instrutor, nome_instrutor As String 'Query letiura e escrita na tabela
    Public conexao = Application.StartupPath & "\banco\autoescola_db.accdb"
    Public cod, limite, x, txt_opcao As Integer
    Public txt_valor_pago_decimal, txt_valor_total_decimal As Decimal
    Public editar, editar_praticas As Boolean

    Sub conecta_banco()
        Try
            'String de Conexão com Access
            db = CreateObject("ADODB.Connection")
            'db.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & conexao) .mdb
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & conexao)
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub gerar_dados_aluno()
        sql = "select * from tb_aluno order by nome_aluno asc"
        rs = db.Execute(sql)
        With CADALUNO.dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub limpar_cadastro_aluno()
        With CADALUNO
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_rg.Clear()
            .txt_nasc.Clear()
            .txt_cep.Clear()
            .txt_endereco.Clear()
            .txt_comp.Clear()
            .txt_bairro.Clear()
            .txt_cidade.Clear()
            .txt_uf.Clear()
            .img_foto.Load(Application.StartupPath & "\fotos\foto_branco.png")
            .txt_nome.Focus()
        End With
    End Sub


    Sub gerar_dados_instrutor()
        sql = "select * from tb_instrutor order by nome_instrutor asc"
        rs = db.Execute(sql)
        With CADINSTRUTOR.dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(2).Value, rs.Fields(1).Value, rs.Fields(0).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub gerar_dados_agenda_teorica()
        With LOGIN
            instrutor = cod_instrutor
            If (txt_opcao = 1) Then

                sql = "select * from tb_aula_teorica where cod_instrutor ='" & instrutor & "'"
                rs = db.Execute(sql)
            Else
                sql = "select * from tb_aula_teorica"
                rs = db.Execute(sql)
            End If
        End With

        With AGENDA_TEORICAS.dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub gerar_dados_agenda_pratica()
        With LOGIN
            instrutor = cod_instrutor
            If (txt_opcao = 1) Then
                sql = "select * from tb_aula_pratica where cod_instrutor ='" & instrutor & "'"
                rs = db.Execute(sql)
            Else
                sql = "select * from tb_aula_pratica"
                rs = db.Execute(sql)
            End If
        End With
        With AGENDA_PRATICAS.dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub gerar_dados_pagamento()
        sql = "select * from tb_pagamento"
        rs = db.Execute(sql)
        With PAGAMENTO.dvg_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub limpar_cadastro_instrutor()
        With CADINSTRUTOR
            .txt_cpf_instrutor.Clear()
            .txt_cod_instrutor.Clear()
            .txt_nome.Clear()
            .txt_rg_instrutor.Clear()
            .txt_nasc.Clear()
            .txt_cep_instrutor.Clear()
            .txt_endereco_instrutor.Clear()
            .txt_complemento.Clear()
            .txt_bairro_instrutor.Clear()
            .txt_cidade_instrutor.Clear()
            .txt_uf_instrutor.Clear()
            .txt_senha_instrutor.Clear()
            .img_foto.Load(Application.StartupPath & "\fotos\foto_branco.png")
            .txt_nome.Focus()
        End With
    End Sub

    Sub limpar_cadastro_teoricas()
        With agendamento_teoricas
            .txt_cpf_aluno.Clear()
            .txt_cod_instrutor.Clear()
            .txt_nome_instrutor.Clear()
            .txt_cod_instrutor.Focus()
        End With
    End Sub

    Sub limpar_cadastro_praticas()
        With AGENDAMENTO_PRATICAS
            .txt_cpf_aluno.Clear()
            .txt_cod_instrutor.Clear()
            .txt_nome_instrutor.Clear()
            .txt_cod_instrutor.Focus()
        End With
    End Sub

End Module
