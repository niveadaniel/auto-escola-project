<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGENDAMENTO_PRATICAS
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nome_instrutor = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_horario = New System.Windows.Forms.ComboBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.txt_data_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cpf_aluno = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod_instrutor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_data_fim = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_carro = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "NOME INSTRUTOR"
        '
        'txt_nome_instrutor
        '
        Me.txt_nome_instrutor.Location = New System.Drawing.Point(334, 185)
        Me.txt_nome_instrutor.Name = "txt_nome_instrutor"
        Me.txt_nome_instrutor.Size = New System.Drawing.Size(137, 20)
        Me.txt_nome_instrutor.TabIndex = 39
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(491, 397)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 30)
        Me.btn_voltar.TabIndex = 38
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'txt_horario
        '
        Me.txt_horario.FormattingEnabled = True
        Me.txt_horario.Location = New System.Drawing.Point(492, 253)
        Me.txt_horario.Name = "txt_horario"
        Me.txt_horario.Size = New System.Drawing.Size(132, 21)
        Me.txt_horario.TabIndex = 37
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(354, 326)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(112, 29)
        Me.btn_cadastrar.TabIndex = 36
        Me.btn_cadastrar.Text = "SALVAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'txt_data_inicio
        '
        Me.txt_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_inicio.Location = New System.Drawing.Point(152, 250)
        Me.txt_data_inicio.Name = "txt_data_inicio"
        Me.txt_data_inicio.Size = New System.Drawing.Size(135, 20)
        Me.txt_data_inicio.TabIndex = 34
        Me.txt_data_inicio.Value = New Date(2019, 11, 21, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "HORÁRIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "DATA  INÍCIO"
        '
        'txt_cpf_aluno
        '
        Me.txt_cpf_aluno.Location = New System.Drawing.Point(491, 185)
        Me.txt_cpf_aluno.Mask = "999,999,999-99"
        Me.txt_cpf_aluno.Name = "txt_cpf_aluno"
        Me.txt_cpf_aluno.Size = New System.Drawing.Size(133, 20)
        Me.txt_cpf_aluno.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ALUNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "CÓDIGO DO INSTRUTOR"
        '
        'txt_cod_instrutor
        '
        Me.txt_cod_instrutor.Location = New System.Drawing.Point(152, 185)
        Me.txt_cod_instrutor.Name = "txt_cod_instrutor"
        Me.txt_cod_instrutor.Size = New System.Drawing.Size(135, 20)
        Me.txt_cod_instrutor.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 31)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "AULAS PRÁTICAS"
        '
        'txt_data_fim
        '
        Me.txt_data_fim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_fim.Location = New System.Drawing.Point(331, 250)
        Me.txt_data_fim.Name = "txt_data_fim"
        Me.txt_data_fim.Size = New System.Drawing.Size(135, 20)
        Me.txt_data_fim.TabIndex = 42
        Me.txt_data_fim.Value = New Date(2019, 11, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "DATA  FIM"
        '
        'txt_carro
        '
        Me.txt_carro.FormattingEnabled = True
        Me.txt_carro.Location = New System.Drawing.Point(152, 326)
        Me.txt_carro.Name = "txt_carro"
        Me.txt_carro.Size = New System.Drawing.Size(130, 21)
        Me.txt_carro.TabIndex = 43
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(152, 308)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(45, 13)
        Me.label6.TabIndex = 44
        Me.label6.Text = "CARRO"
        '
        'btn_editar
        '
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(495, 326)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(112, 29)
        Me.btn_editar.TabIndex = 45
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'AGENDAMENTO_PRATICAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txt_carro)
        Me.Controls.Add(Me.txt_data_fim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_nome_instrutor)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.txt_horario)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_data_inicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cpf_aluno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod_instrutor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AGENDAMENTO_PRATICAS"
        Me.Text = "AGENDAMENTO DE AULAS PRÁTICAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nome_instrutor As TextBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_horario As ComboBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents txt_data_inicio As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cpf_aluno As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cod_instrutor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_data_fim As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_carro As ComboBox
    Friend WithEvents label6 As Label
    Friend WithEvents btn_editar As Button
End Class
