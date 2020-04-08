<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pag_inicial_instrutor
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
        Me.btn_agenda_teoricas = New System.Windows.Forms.Button()
        Me.btn_agenda_praticas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.Label()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_agenda_teoricas
        '
        Me.btn_agenda_teoricas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agenda_teoricas.Location = New System.Drawing.Point(416, 229)
        Me.btn_agenda_teoricas.Name = "btn_agenda_teoricas"
        Me.btn_agenda_teoricas.Size = New System.Drawing.Size(166, 65)
        Me.btn_agenda_teoricas.TabIndex = 9
        Me.btn_agenda_teoricas.Text = "Agenda aulas teóricas"
        Me.btn_agenda_teoricas.UseVisualStyleBackColor = True
        '
        'btn_agenda_praticas
        '
        Me.btn_agenda_praticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agenda_praticas.Location = New System.Drawing.Point(197, 229)
        Me.btn_agenda_praticas.Name = "btn_agenda_praticas"
        Me.btn_agenda_praticas.Size = New System.Drawing.Size(166, 65)
        Me.btn_agenda_praticas.TabIndex = 8
        Me.btn_agenda_praticas.Text = "Agenda aulas práticas"
        Me.btn_agenda_praticas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Bem Vindo(a),"
        '
        'nome
        '
        Me.nome.AutoSize = True
        Me.nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome.Location = New System.Drawing.Point(409, 78)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(113, 37)
        Me.nome.TabIndex = 11
        Me.nome.Text = "Label2"
        '
        'btn_deslogar
        '
        Me.btn_deslogar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deslogar.Location = New System.Drawing.Point(306, 325)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(168, 65)
        Me.btn_deslogar.TabIndex = 12
        Me.btn_deslogar.Text = "Deslogar"
        Me.btn_deslogar.UseVisualStyleBackColor = True
        '
        'pag_inicial_instrutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_agenda_teoricas)
        Me.Controls.Add(Me.btn_agenda_praticas)
        Me.Name = "pag_inicial_instrutor"
        Me.Text = "MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_agenda_teoricas As Button
    Friend WithEvents btn_agenda_praticas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nome As Label
    Friend WithEvents btn_deslogar As Button
End Class
