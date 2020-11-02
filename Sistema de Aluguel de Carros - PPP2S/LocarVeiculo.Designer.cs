namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    partial class LocarVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.tBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxRetirada = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.Label();
            this.txtAdicionais = new System.Windows.Forms.Label();
            this.cBoxPlano = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxEndereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cBoxDesconto = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cBoxPagamento = new System.Windows.Forms.ComboBox();
            this.cBoxJuros = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnLocar = new System.Windows.Forms.Button();
            this.txtNumDiarias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Locação de Veículo";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFechar.Location = new System.Drawing.Point(764, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 23);
            this.btnFechar.TabIndex = 28;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tBoxCpf
            // 
            this.tBoxCpf.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxCpf.Location = new System.Drawing.Point(212, 166);
            this.tBoxCpf.Mask = "000.000.000-00";
            this.tBoxCpf.Name = "tBoxCpf";
            this.tBoxCpf.Size = new System.Drawing.Size(100, 20);
            this.tBoxCpf.TabIndex = 39;
            // 
            // tBoxRg
            // 
            this.tBoxRg.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxRg.Location = new System.Drawing.Point(212, 135);
            this.tBoxRg.Mask = "00.000.000-0";
            this.tBoxRg.Name = "tBoxRg";
            this.tBoxRg.Size = new System.Drawing.Size(100, 20);
            this.tBoxRg.TabIndex = 38;
            // 
            // tBoxNome
            // 
            this.tBoxNome.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxNome.Location = new System.Drawing.Point(212, 106);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(243, 20);
            this.tBoxNome.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(167, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(176, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(69, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(317, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Dados do Cliente";
            // 
            // tBoxRetirada
            // 
            this.tBoxRetirada.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxRetirada.Location = new System.Drawing.Point(212, 477);
            this.tBoxRetirada.Mask = "00/00/0000";
            this.tBoxRetirada.Name = "tBoxRetirada";
            this.tBoxRetirada.Size = new System.Drawing.Size(121, 20);
            this.tBoxRetirada.TabIndex = 42;
            this.tBoxRetirada.ValidatingType = typeof(System.DateTime);
            this.tBoxRetirada.TextChanged += new System.EventHandler(this.tBoxRetirada_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(62, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Data de retirada";
            // 
            // tBoxDevolucao
            // 
            this.tBoxDevolucao.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxDevolucao.Location = new System.Drawing.Point(212, 506);
            this.tBoxDevolucao.Mask = "00/00/0000";
            this.tBoxDevolucao.Name = "tBoxDevolucao";
            this.tBoxDevolucao.Size = new System.Drawing.Size(121, 20);
            this.tBoxDevolucao.TabIndex = 44;
            this.tBoxDevolucao.ValidatingType = typeof(System.DateTime);
            this.tBoxDevolucao.TextChanged += new System.EventHandler(this.tBoxDevolucao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(44, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Data de devolução";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(317, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Dados da locação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(139, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Modelo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(170, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Cor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(154, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Placa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(453, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Adicionais:";
            // 
            // txtModelo
            // 
            this.txtModelo.AutoSize = true;
            this.txtModelo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtModelo.Location = new System.Drawing.Point(212, 291);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(126, 20);
            this.txtModelo.TabIndex = 50;
            this.txtModelo.Text = "nome do carro";
            // 
            // txtCor
            // 
            this.txtCor.AutoSize = true;
            this.txtCor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCor.Location = new System.Drawing.Point(212, 311);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(33, 20);
            this.txtCor.TabIndex = 51;
            this.txtCor.Text = "cor";
            // 
            // txtPlaca
            // 
            this.txtPlaca.AutoSize = true;
            this.txtPlaca.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPlaca.Location = new System.Drawing.Point(212, 331);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(52, 20);
            this.txtPlaca.TabIndex = 52;
            this.txtPlaca.Text = "placa";
            // 
            // txtAdicionais
            // 
            this.txtAdicionais.AutoSize = true;
            this.txtAdicionais.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAdicionais.Location = new System.Drawing.Point(551, 291);
            this.txtAdicionais.Name = "txtAdicionais";
            this.txtAdicionais.Size = new System.Drawing.Size(91, 20);
            this.txtAdicionais.TabIndex = 53;
            this.txtAdicionais.Text = "adicionais";
            // 
            // cBoxPlano
            // 
            this.cBoxPlano.BackColor = System.Drawing.Color.DarkGray;
            this.cBoxPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPlano.FormattingEnabled = true;
            this.cBoxPlano.Items.AddRange(new object[] {
            "Km Controlada",
            "Km Livre"});
            this.cBoxPlano.Location = new System.Drawing.Point(212, 532);
            this.cBoxPlano.Name = "cBoxPlano";
            this.cBoxPlano.Size = new System.Drawing.Size(121, 21);
            this.cBoxPlano.TabIndex = 55;
            this.cBoxPlano.Text = "Km Controlada";
            this.cBoxPlano.SelectedIndexChanged += new System.EventHandler(this.cBoxPlano_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(152, 533);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Plano";
            // 
            // tBoxEndereco
            // 
            this.tBoxEndereco.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxEndereco.Location = new System.Drawing.Point(212, 192);
            this.tBoxEndereco.Name = "tBoxEndereco";
            this.tBoxEndereco.Size = new System.Drawing.Size(243, 20);
            this.tBoxEndereco.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(123, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "Endereço";
            // 
            // tBoxTelefone
            // 
            this.tBoxTelefone.BackColor = System.Drawing.Color.DarkGray;
            this.tBoxTelefone.Location = new System.Drawing.Point(212, 220);
            this.tBoxTelefone.Mask = "(00)00000-0000";
            this.tBoxTelefone.Name = "tBoxTelefone";
            this.tBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.tBoxTelefone.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(126, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 58;
            this.label15.Text = "Telefone";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.AutoSize = true;
            this.txtValorDiaria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDiaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtValorDiaria.Location = new System.Drawing.Point(205, 611);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(49, 20);
            this.txtValorDiaria.TabIndex = 61;
            this.txtValorDiaria.Text = "valor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(70, 611);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 20);
            this.label17.TabIndex = 60;
            this.label17.Text = "Valor da diária:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtValorTotal.Location = new System.Drawing.Point(205, 680);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(49, 20);
            this.txtValorTotal.TabIndex = 63;
            this.txtValorTotal.Text = "valor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(103, 680);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 20);
            this.label18.TabIndex = 62;
            this.label18.Text = "Valor total:";
            // 
            // cBoxDesconto
            // 
            this.cBoxDesconto.BackColor = System.Drawing.Color.DarkGray;
            this.cBoxDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxDesconto.FormattingEnabled = true;
            this.cBoxDesconto.Items.AddRange(new object[] {
            "0%",
            "2%",
            "3%",
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "40%",
            "50%"});
            this.cBoxDesconto.Location = new System.Drawing.Point(558, 613);
            this.cBoxDesconto.Name = "cBoxDesconto";
            this.cBoxDesconto.Size = new System.Drawing.Size(121, 21);
            this.cBoxDesconto.TabIndex = 65;
            this.cBoxDesconto.Text = "0%";
            this.cBoxDesconto.SelectedIndexChanged += new System.EventHandler(this.cBoxDesconto_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(467, 614);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 64;
            this.label16.Text = "Desconto";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(300, 574);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(202, 20);
            this.label19.TabIndex = 66;
            this.label19.Text = "Dados do Pagamento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(23, 656);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 20);
            this.label20.TabIndex = 67;
            this.label20.Text = "Forma de pagamento";
            // 
            // cBoxPagamento
            // 
            this.cBoxPagamento.BackColor = System.Drawing.Color.DarkGray;
            this.cBoxPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPagamento.FormattingEnabled = true;
            this.cBoxPagamento.Items.AddRange(new object[] {
            "À vista (na retirada do veículo)",
            "Crédito(À vista)",
            "Crédito(2 parcelas)",
            "Crédito(3 parcelas)",
            "Crédito(4 parcelas)",
            "Crédito(5 parcelas)",
            "Crédito(6 parcelas)",
            "Crédito(7 parcelas)",
            "Crédito(8 parcelas)",
            "Crédito(9 parcelas)",
            "Crédito(10 parcelas)",
            "Crédito(11 parcelas)",
            "Crédito(12 parcelas)",
            ""});
            this.cBoxPagamento.Location = new System.Drawing.Point(212, 656);
            this.cBoxPagamento.Name = "cBoxPagamento";
            this.cBoxPagamento.Size = new System.Drawing.Size(121, 21);
            this.cBoxPagamento.TabIndex = 68;
            this.cBoxPagamento.Text = "À vista (na retirada do veículo)";
            this.cBoxPagamento.SelectedIndexChanged += new System.EventHandler(this.cBoxPagamento_SelectedIndexChanged);
            // 
            // cBoxJuros
            // 
            this.cBoxJuros.BackColor = System.Drawing.Color.DarkGray;
            this.cBoxJuros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxJuros.FormattingEnabled = true;
            this.cBoxJuros.Items.AddRange(new object[] {
            "0%",
            "0.5%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cBoxJuros.Location = new System.Drawing.Point(558, 655);
            this.cBoxJuros.Name = "cBoxJuros";
            this.cBoxJuros.Size = new System.Drawing.Size(121, 21);
            this.cBoxJuros.TabIndex = 70;
            this.cBoxJuros.Text = "2%";
            this.cBoxJuros.SelectedIndexChanged += new System.EventHandler(this.cBoxJuros_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(501, 656);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 20);
            this.label21.TabIndex = 69;
            this.label21.Text = "Juros";
            // 
            // btnLocar
            // 
            this.btnLocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLocar.Location = new System.Drawing.Point(355, 728);
            this.btnLocar.Name = "btnLocar";
            this.btnLocar.Size = new System.Drawing.Size(100, 52);
            this.btnLocar.TabIndex = 71;
            this.btnLocar.Text = "Locar";
            this.btnLocar.UseVisualStyleBackColor = false;
            this.btnLocar.Click += new System.EventHandler(this.btnLocar_Click);
            // 
            // txtNumDiarias
            // 
            this.txtNumDiarias.AutoSize = true;
            this.txtNumDiarias.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDiarias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNumDiarias.Location = new System.Drawing.Point(554, 504);
            this.txtNumDiarias.Name = "txtNumDiarias";
            this.txtNumDiarias.Size = new System.Drawing.Size(66, 20);
            this.txtNumDiarias.TabIndex = 72;
            this.txtNumDiarias.Text = "Diárias";
            // 
            // LocarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 792);
            this.Controls.Add(this.txtNumDiarias);
            this.Controls.Add(this.btnLocar);
            this.Controls.Add(this.cBoxJuros);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cBoxPagamento);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cBoxDesconto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tBoxTelefone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tBoxEndereco);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cBoxPlano);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAdicionais);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxDevolucao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxRetirada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxCpf);
            this.Controls.Add(this.tBoxRg);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MaskedTextBox tBoxCpf;
        private System.Windows.Forms.MaskedTextBox tBoxRg;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tBoxRetirada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox tBoxDevolucao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtModelo;
        private System.Windows.Forms.Label txtCor;
        private System.Windows.Forms.Label txtPlaca;
        private System.Windows.Forms.Label txtAdicionais;
        private System.Windows.Forms.ComboBox cBoxPlano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxEndereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox tBoxTelefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtValorDiaria;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtValorTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cBoxDesconto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cBoxPagamento;
        private System.Windows.Forms.ComboBox cBoxJuros;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLocar;
        private System.Windows.Forms.Label txtNumDiarias;
    }
}