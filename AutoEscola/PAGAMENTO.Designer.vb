<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGAMENTO
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_valor_restante = New System.Windows.Forms.MaskedTextBox()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_forma_pagamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_valor_pago = New System.Windows.Forms.MaskedTextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txt_valor_total = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf_aluno = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome_aluno = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dvg_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dvg_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(737, 347)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_valor_restante)
        Me.TabPage1.Controls.Add(Me.txt_categoria)
        Me.TabPage1.Controls.Add(Me.btn_voltar)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_forma_pagamento)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_valor_pago)
        Me.TabPage1.Controls.Add(Me.label)
        Me.TabPage1.Controls.Add(Me.txt_valor_total)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_cpf_aluno)
        Me.TabPage1.Controls.Add(Me.txt_nome_aluno)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO DE PAGAMENTO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "VALOR RESTANTE"
        '
        'txt_valor_restante
        '
        Me.txt_valor_restante.Location = New System.Drawing.Point(453, 168)
        Me.txt_valor_restante.Name = "txt_valor_restante"
        Me.txt_valor_restante.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor_restante.TabIndex = 17
        '
        'txt_categoria
        '
        Me.txt_categoria.Location = New System.Drawing.Point(456, 79)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.Size = New System.Drawing.Size(97, 20)
        Me.txt_categoria.TabIndex = 16
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(480, 247)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(122, 27)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(324, 247)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(122, 27)
        Me.btn_cadastrar.TabIndex = 14
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FORMA DE PAGAMENTO"
        '
        'txt_forma_pagamento
        '
        Me.txt_forma_pagamento.FormattingEnabled = True
        Me.txt_forma_pagamento.Location = New System.Drawing.Point(110, 247)
        Me.txt_forma_pagamento.Name = "txt_forma_pagamento"
        Me.txt_forma_pagamento.Size = New System.Drawing.Size(146, 21)
        Me.txt_forma_pagamento.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CATEGORIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ENTRADA"
        '
        'txt_valor_pago
        '
        Me.txt_valor_pago.Location = New System.Drawing.Point(295, 168)
        Me.txt_valor_pago.Name = "txt_valor_pago"
        Me.txt_valor_pago.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor_pago.TabIndex = 6
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(107, 152)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(81, 13)
        Me.label.TabIndex = 5
        Me.label.Text = "VALOR TOTAL"
        '
        'txt_valor_total
        '
        Me.txt_valor_total.Location = New System.Drawing.Point(110, 168)
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor_total.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOME ALUNO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CPF ALUNO"
        '
        'txt_cpf_aluno
        '
        Me.txt_cpf_aluno.Location = New System.Drawing.Point(110, 80)
        Me.txt_cpf_aluno.Mask = "999,999,999-99"
        Me.txt_cpf_aluno.Name = "txt_cpf_aluno"
        Me.txt_cpf_aluno.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf_aluno.TabIndex = 1
        '
        'txt_nome_aluno
        '
        Me.txt_nome_aluno.Location = New System.Drawing.Point(266, 80)
        Me.txt_nome_aluno.Name = "txt_nome_aluno"
        Me.txt_nome_aluno.Size = New System.Drawing.Size(129, 20)
        Me.txt_nome_aluno.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dvg_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(729, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PAGAMENTOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dvg_dados
        '
        Me.dvg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dvg_dados.Location = New System.Drawing.Point(-20, -3)
        Me.dvg_dados.Name = "dvg_dados"
        Me.dvg_dados.Size = New System.Drawing.Size(768, 355)
        Me.dvg_dados.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "CPF"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "FORMA DE PAGAMENTO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "VALOR TOTAL"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "VALOR PAGO"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "CATEGORIA"
        Me.Column6.Name = "Column6"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PAGAMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PAGAMENTO"
        Me.Text = "PAGAMENTOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dvg_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents label As Label
    Friend WithEvents txt_valor_total As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf_aluno As MaskedTextBox
    Friend WithEvents txt_nome_aluno As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_valor_pago As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_forma_pagamento As ComboBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_categoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_valor_restante As MaskedTextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents dvg_dados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
