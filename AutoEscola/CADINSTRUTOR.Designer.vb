<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CADINSTRUTOR
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_nasc = New System.Windows.Forms.MaskedTextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_repetir_senha = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.NOME = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_senha_instrutor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cod_instrutor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_uf_instrutor = New System.Windows.Forms.TextBox()
        Me.txt_rg_instrutor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cidade_instrutor = New System.Windows.Forms.TextBox()
        Me.txt_cpf_instrutor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_bairro_instrutor = New System.Windows.Forms.TextBox()
        Me.txt_cep_instrutor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_endereco_instrutor = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CADASTRO DE INSTRUTOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(56, 114)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(237, 20)
        Me.txt_name.TabIndex = 4
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(307, 114)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(121, 20)
        Me.txt_cpf.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DATA NASCIMENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "RG"
        '
        'txt_data_nasc
        '
        Me.txt_data_nasc.Location = New System.Drawing.Point(56, 184)
        Me.txt_data_nasc.Name = "txt_data_nasc"
        Me.txt_data_nasc.Size = New System.Drawing.Size(213, 20)
        Me.txt_data_nasc.TabIndex = 8
        '
        'txt_rg
        '
        Me.txt_rg.Location = New System.Drawing.Point(310, 184)
        Me.txt_rg.Mask = "9999999-9"
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(118, 20)
        Me.txt_rg.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(490, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "UF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "CIDADE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "BAIRRO"
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(493, 331)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(44, 20)
        Me.txt_uf.TabIndex = 31
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(270, 332)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(191, 20)
        Me.txt_cidade.TabIndex = 30
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(56, 332)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(184, 20)
        Me.txt_bairro.TabIndex = 29
        '
        'txt_comp
        '
        Me.txt_comp.Location = New System.Drawing.Point(493, 260)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(100, 20)
        Me.txt_comp.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(490, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "COMPLEMENTO"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(192, 260)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(275, 20)
        Me.txt_endereco.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "ENDEREÇO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(56, 260)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(110, 20)
        Me.txt_cep.TabIndex = 23
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(788, 364)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_editar)
        Me.TabPage1.Controls.Add(Me.btn_voltar)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.txt_nasc)
        Me.TabPage1.Controls.Add(Me.btn_save)
        Me.TabPage1.Controls.Add(Me.txt_repetir_senha)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.NOME)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.txt_senha_instrutor)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txt_cod_instrutor)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txt_uf_instrutor)
        Me.TabPage1.Controls.Add(Me.txt_rg_instrutor)
        Me.TabPage1.Controls.Add(Me.txt_cidade_instrutor)
        Me.TabPage1.Controls.Add(Me.txt_cpf_instrutor)
        Me.TabPage1.Controls.Add(Me.txt_bairro_instrutor)
        Me.TabPage1.Controls.Add(Me.txt_cep_instrutor)
        Me.TabPage1.Controls.Add(Me.txt_complemento)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txt_endereco_instrutor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(780, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(688, 6)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 23)
        Me.btn_voltar.TabIndex = 36
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(360, 276)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "REPETIR SENHA"
        '
        'txt_nasc
        '
        Me.txt_nasc.Location = New System.Drawing.Point(49, 125)
        Me.txt_nasc.Mask = "00/00/0000"
        Me.txt_nasc.Name = "txt_nasc"
        Me.txt_nasc.Size = New System.Drawing.Size(136, 20)
        Me.txt_nasc.TabIndex = 25
        Me.txt_nasc.ValidatingType = GetType(Date)
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(598, 277)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(142, 36)
        Me.btn_save.TabIndex = 24
        Me.btn_save.Text = "SALVAR"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_repetir_senha
        '
        Me.txt_repetir_senha.Location = New System.Drawing.Point(361, 293)
        Me.txt_repetir_senha.Name = "txt_repetir_senha"
        Me.txt_repetir_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repetir_senha.Size = New System.Drawing.Size(128, 20)
        Me.txt_repetir_senha.TabIndex = 34
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(49, 60)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(292, 20)
        Me.txt_nome.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(256, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(258, 24)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "CADASTRO DE INSTRUTOR"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(196, 276)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "SENHA"
        '
        'NOME
        '
        Me.NOME.AutoSize = True
        Me.NOME.Location = New System.Drawing.Point(43, 44)
        Me.NOME.Name = "NOME"
        Me.NOME.Size = New System.Drawing.Size(39, 13)
        Me.NOME.TabIndex = 2
        Me.NOME.Text = "NOME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutoEscola.My.Resources.Resources.foto_branco
        Me.PictureBox1.Location = New System.Drawing.Point(609, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'txt_senha_instrutor
        '
        Me.txt_senha_instrutor.Location = New System.Drawing.Point(199, 292)
        Me.txt_senha_instrutor.Name = "txt_senha_instrutor"
        Me.txt_senha_instrutor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_instrutor.Size = New System.Drawing.Size(122, 20)
        Me.txt_senha_instrutor.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(360, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "CPF"
        '
        'txt_cod_instrutor
        '
        Me.txt_cod_instrutor.Location = New System.Drawing.Point(49, 293)
        Me.txt_cod_instrutor.Name = "txt_cod_instrutor"
        Me.txt_cod_instrutor.Size = New System.Drawing.Size(110, 20)
        Me.txt_cod_instrutor.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(471, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "UF"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(49, 276)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "CÓDIGO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "DATA NASCIMENTO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(257, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "CIDADE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(43, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "BAIRRO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(360, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "RG"
        '
        'txt_uf_instrutor
        '
        Me.txt_uf_instrutor.Location = New System.Drawing.Point(474, 235)
        Me.txt_uf_instrutor.Name = "txt_uf_instrutor"
        Me.txt_uf_instrutor.Size = New System.Drawing.Size(44, 20)
        Me.txt_uf_instrutor.TabIndex = 19
        '
        'txt_rg_instrutor
        '
        Me.txt_rg_instrutor.Location = New System.Drawing.Point(363, 125)
        Me.txt_rg_instrutor.Mask = "9999999-9"
        Me.txt_rg_instrutor.Name = "txt_rg_instrutor"
        Me.txt_rg_instrutor.Size = New System.Drawing.Size(99, 20)
        Me.txt_rg_instrutor.TabIndex = 9
        '
        'txt_cidade_instrutor
        '
        Me.txt_cidade_instrutor.Location = New System.Drawing.Point(260, 236)
        Me.txt_cidade_instrutor.Name = "txt_cidade_instrutor"
        Me.txt_cidade_instrutor.Size = New System.Drawing.Size(191, 20)
        Me.txt_cidade_instrutor.TabIndex = 18
        '
        'txt_cpf_instrutor
        '
        Me.txt_cpf_instrutor.Location = New System.Drawing.Point(361, 62)
        Me.txt_cpf_instrutor.Mask = "999,999,999-99"
        Me.txt_cpf_instrutor.Name = "txt_cpf_instrutor"
        Me.txt_cpf_instrutor.Size = New System.Drawing.Size(99, 20)
        Me.txt_cpf_instrutor.TabIndex = 10
        '
        'txt_bairro_instrutor
        '
        Me.txt_bairro_instrutor.Location = New System.Drawing.Point(46, 236)
        Me.txt_bairro_instrutor.Name = "txt_bairro_instrutor"
        Me.txt_bairro_instrutor.Size = New System.Drawing.Size(184, 20)
        Me.txt_bairro_instrutor.TabIndex = 17
        '
        'txt_cep_instrutor
        '
        Me.txt_cep_instrutor.Location = New System.Drawing.Point(46, 176)
        Me.txt_cep_instrutor.Mask = "99999-999"
        Me.txt_cep_instrutor.Name = "txt_cep_instrutor"
        Me.txt_cep_instrutor.Size = New System.Drawing.Size(110, 20)
        Me.txt_cep_instrutor.TabIndex = 11
        '
        'txt_complemento
        '
        Me.txt_complemento.Location = New System.Drawing.Point(474, 176)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(100, 20)
        Me.txt_complemento.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(43, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "CEP"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(471, 161)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "COMPLEMENTO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(179, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "ENDEREÇO"
        '
        'txt_endereco_instrutor
        '
        Me.txt_endereco_instrutor.Location = New System.Drawing.Point(182, 176)
        Me.txt_endereco_instrutor.Name = "txt_endereco_instrutor"
        Me.txt_endereco_instrutor.Size = New System.Drawing.Size(275, 20)
        Me.txt_endereco_instrutor.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(780, 338)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INSTRUTORES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column1, Me.Column4, Me.Column5})
        Me.dgv_dados.Location = New System.Drawing.Point(3, 12)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(768, 326)
        Me.dgv_dados.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CÓDIGO"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "CPF"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "EDITAR"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 57
        '
        'Column5
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "EXLCUIR"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 57
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'img_foto
        '
        Me.img_foto.Image = Global.AutoEscola.My.Resources.Resources.foto_branco
        Me.img_foto.Location = New System.Drawing.Point(568, 98)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(135, 139)
        Me.img_foto.TabIndex = 36
        Me.img_foto.TabStop = False
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(598, 226)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(142, 36)
        Me.btn_editar.TabIndex = 37
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'CADINSTRUTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.txt_comp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_rg)
        Me.Controls.Add(Me.txt_data_nasc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CADINSTRUTOR"
        Me.Text = "CADASTRO DE INSTRUTOR"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_data_nasc As DateTimePicker
    Friend WithEvents txt_rg As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents txt_comp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents NOME As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_uf_instrutor As TextBox
    Friend WithEvents txt_rg_instrutor As MaskedTextBox
    Friend WithEvents txt_cidade_instrutor As TextBox
    Friend WithEvents txt_cpf_instrutor As MaskedTextBox
    Friend WithEvents txt_bairro_instrutor As TextBox
    Friend WithEvents txt_cep_instrutor As MaskedTextBox
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_endereco_instrutor As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents txt_nasc As MaskedTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_senha_instrutor As TextBox
    Friend WithEvents txt_cod_instrutor As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_repetir_senha As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents btn_editar As Button
End Class
