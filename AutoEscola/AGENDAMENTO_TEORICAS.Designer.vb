<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agendamento_teoricas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_instrutor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cpf_aluno = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_data_inicio = New System.Windows.Forms.DateTimePicker()
        Me.txt_data_fim = New System.Windows.Forms.DateTimePicker()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.txt_horario = New System.Windows.Forms.ComboBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_nome_instrutor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AULAS TEÓRICAS"
        '
        'txt_cod_instrutor
        '
        Me.txt_cod_instrutor.Location = New System.Drawing.Point(93, 163)
        Me.txt_cod_instrutor.Name = "txt_cod_instrutor"
        Me.txt_cod_instrutor.Size = New System.Drawing.Size(133, 20)
        Me.txt_cod_instrutor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CÓDIGO DO INSTRUTOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ALUNO"
        '
        'txt_cpf_aluno
        '
        Me.txt_cpf_aluno.Location = New System.Drawing.Point(432, 163)
        Me.txt_cpf_aluno.Mask = "999,999,999-99"
        Me.txt_cpf_aluno.Name = "txt_cpf_aluno"
        Me.txt_cpf_aluno.Size = New System.Drawing.Size(133, 20)
        Me.txt_cpf_aluno.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DATA  INÍCIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DATA  FIM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "HORÁRIO"
        '
        'txt_data_inicio
        '
        Me.txt_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_inicio.Location = New System.Drawing.Point(93, 228)
        Me.txt_data_inicio.Name = "txt_data_inicio"
        Me.txt_data_inicio.Size = New System.Drawing.Size(135, 20)
        Me.txt_data_inicio.TabIndex = 19
        Me.txt_data_inicio.Value = New Date(2019, 11, 21, 0, 0, 0, 0)
        '
        'txt_data_fim
        '
        Me.txt_data_fim.AllowDrop = True
        Me.txt_data_fim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_fim.Location = New System.Drawing.Point(275, 228)
        Me.txt_data_fim.Name = "txt_data_fim"
        Me.txt_data_fim.Size = New System.Drawing.Size(133, 20)
        Me.txt_data_fim.TabIndex = 20
        Me.txt_data_fim.Value = New Date(2019, 11, 21, 0, 0, 0, 0)
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(275, 309)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(112, 29)
        Me.btn_cadastrar.TabIndex = 21
        Me.btn_cadastrar.Text = "SALVAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'txt_horario
        '
        Me.txt_horario.FormattingEnabled = True
        Me.txt_horario.Location = New System.Drawing.Point(96, 309)
        Me.txt_horario.Name = "txt_horario"
        Me.txt_horario.Size = New System.Drawing.Size(132, 21)
        Me.txt_horario.TabIndex = 22
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(601, 383)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 30)
        Me.btn_voltar.TabIndex = 23
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'txt_nome_instrutor
        '
        Me.txt_nome_instrutor.Location = New System.Drawing.Point(275, 163)
        Me.txt_nome_instrutor.Name = "txt_nome_instrutor"
        Me.txt_nome_instrutor.Size = New System.Drawing.Size(137, 20)
        Me.txt_nome_instrutor.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "NOME INSTRUTOR"
        '
        'btn_editar
        '
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(411, 309)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(112, 29)
        Me.btn_editar.TabIndex = 26
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'agendamento_teoricas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_nome_instrutor)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.txt_horario)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_data_fim)
        Me.Controls.Add(Me.txt_data_inicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cpf_aluno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod_instrutor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "agendamento_teoricas"
        Me.Text = "AGENDAMENTO AULAS TEÓRICAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod_instrutor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cpf_aluno As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_data_inicio As DateTimePicker
    Friend WithEvents txt_data_fim As DateTimePicker
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents txt_horario As ComboBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_nome_instrutor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_editar As Button
End Class
