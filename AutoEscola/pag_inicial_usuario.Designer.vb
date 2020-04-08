<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pag_inicial_usuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cad_aluno = New System.Windows.Forms.Button()
        Me.btn_cad_instrutor = New System.Windows.Forms.Button()
        Me.btn_agendamento_praticas = New System.Windows.Forms.Button()
        Me.btn_agendamento_teoricas = New System.Windows.Forms.Button()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.nome = New System.Windows.Forms.Label()
        Me.btn_agenda_teoricas = New System.Windows.Forms.Button()
        Me.btn_agenda_praticas = New System.Windows.Forms.Button()
        Me.btn_pagamentos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bem Vindo(a),"
        '
        'btn_cad_aluno
        '
        Me.btn_cad_aluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_aluno.Location = New System.Drawing.Point(78, 173)
        Me.btn_cad_aluno.Name = "btn_cad_aluno"
        Me.btn_cad_aluno.Size = New System.Drawing.Size(166, 65)
        Me.btn_cad_aluno.TabIndex = 2
        Me.btn_cad_aluno.Text = "Cadastro de aluno"
        Me.btn_cad_aluno.UseVisualStyleBackColor = True
        '
        'btn_cad_instrutor
        '
        Me.btn_cad_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_instrutor.Location = New System.Drawing.Point(284, 173)
        Me.btn_cad_instrutor.Name = "btn_cad_instrutor"
        Me.btn_cad_instrutor.Size = New System.Drawing.Size(168, 65)
        Me.btn_cad_instrutor.TabIndex = 3
        Me.btn_cad_instrutor.Text = "Cadastro de instrutor"
        Me.btn_cad_instrutor.UseVisualStyleBackColor = True
        '
        'btn_agendamento_praticas
        '
        Me.btn_agendamento_praticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendamento_praticas.Location = New System.Drawing.Point(505, 173)
        Me.btn_agendamento_praticas.Name = "btn_agendamento_praticas"
        Me.btn_agendamento_praticas.Size = New System.Drawing.Size(166, 65)
        Me.btn_agendamento_praticas.TabIndex = 4
        Me.btn_agendamento_praticas.Text = "Agendamento de aulas práticas"
        Me.btn_agendamento_praticas.UseVisualStyleBackColor = True
        '
        'btn_agendamento_teoricas
        '
        Me.btn_agendamento_teoricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendamento_teoricas.Location = New System.Drawing.Point(78, 283)
        Me.btn_agendamento_teoricas.Name = "btn_agendamento_teoricas"
        Me.btn_agendamento_teoricas.Size = New System.Drawing.Size(166, 65)
        Me.btn_agendamento_teoricas.TabIndex = 5
        Me.btn_agendamento_teoricas.Text = "Agendamento de aulas teóricas"
        Me.btn_agendamento_teoricas.UseVisualStyleBackColor = True
        '
        'btn_deslogar
        '
        Me.btn_deslogar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deslogar.Location = New System.Drawing.Point(505, 373)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(168, 65)
        Me.btn_deslogar.TabIndex = 6
        Me.btn_deslogar.Text = "Deslogar"
        Me.btn_deslogar.UseVisualStyleBackColor = True
        '
        'nome
        '
        Me.nome.AutoSize = True
        Me.nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome.Location = New System.Drawing.Point(339, 63)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(113, 37)
        Me.nome.TabIndex = 7
        Me.nome.Text = "Label2"
        '
        'btn_agenda_teoricas
        '
        Me.btn_agenda_teoricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agenda_teoricas.Location = New System.Drawing.Point(505, 283)
        Me.btn_agenda_teoricas.Name = "btn_agenda_teoricas"
        Me.btn_agenda_teoricas.Size = New System.Drawing.Size(166, 65)
        Me.btn_agenda_teoricas.TabIndex = 8
        Me.btn_agenda_teoricas.Text = "Agenda aulas teóricas"
        Me.btn_agenda_teoricas.UseVisualStyleBackColor = True
        '
        'btn_agenda_praticas
        '
        Me.btn_agenda_praticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agenda_praticas.Location = New System.Drawing.Point(284, 283)
        Me.btn_agenda_praticas.Name = "btn_agenda_praticas"
        Me.btn_agenda_praticas.Size = New System.Drawing.Size(166, 65)
        Me.btn_agenda_praticas.TabIndex = 9
        Me.btn_agenda_praticas.Text = "Agenda aulas práticas"
        Me.btn_agenda_praticas.UseVisualStyleBackColor = True
        '
        'btn_pagamentos
        '
        Me.btn_pagamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pagamentos.Location = New System.Drawing.Point(284, 373)
        Me.btn_pagamentos.Name = "btn_pagamentos"
        Me.btn_pagamentos.Size = New System.Drawing.Size(166, 65)
        Me.btn_pagamentos.TabIndex = 10
        Me.btn_pagamentos.Text = "Pagamentos"
        Me.btn_pagamentos.UseVisualStyleBackColor = True
        '
        'pag_inicial_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_pagamentos)
        Me.Controls.Add(Me.btn_agenda_praticas)
        Me.Controls.Add(Me.btn_agenda_teoricas)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.btn_agendamento_teoricas)
        Me.Controls.Add(Me.btn_agendamento_praticas)
        Me.Controls.Add(Me.btn_cad_instrutor)
        Me.Controls.Add(Me.btn_cad_aluno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pag_inicial_usuario"
        Me.Text = "MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cad_aluno As Button
    Friend WithEvents btn_cad_instrutor As Button
    Friend WithEvents btn_agendamento_praticas As Button
    Friend WithEvents btn_agendamento_teoricas As Button
    Friend WithEvents btn_deslogar As Button
    Friend WithEvents nome As Label
    Friend WithEvents btn_agenda_teoricas As Button
    Friend WithEvents btn_agenda_praticas As Button
    Friend WithEvents btn_pagamentos As Button
End Class
