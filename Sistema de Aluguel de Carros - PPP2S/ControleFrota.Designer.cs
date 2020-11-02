namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    partial class ControleFrota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleFrota));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdcionarVeiculo = new System.Windows.Forms.Button();
            this.btnLocarVeiculo = new System.Windows.Forms.Button();
            this.TabelaFrota = new System.Windows.Forms.DataGridView();
            this.btnRemoverVeiculo = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.txtLogadoComo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAbaTI = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnAbaClientes = new System.Windows.Forms.Button();
            this.btnControleFuncionarios = new System.Windows.Forms.Button();
            this.btnAbaControleFrota = new System.Windows.Forms.Button();
            this.btnAbaInicio = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFrota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFechar.Location = new System.Drawing.Point(914, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdcionarVeiculo
            // 
            this.btnAdcionarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdcionarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcionarVeiculo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionarVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdcionarVeiculo.Location = new System.Drawing.Point(831, 129);
            this.btnAdcionarVeiculo.Name = "btnAdcionarVeiculo";
            this.btnAdcionarVeiculo.Size = new System.Drawing.Size(107, 43);
            this.btnAdcionarVeiculo.TabIndex = 9;
            this.btnAdcionarVeiculo.Text = "Adicionar veículo";
            this.btnAdcionarVeiculo.UseVisualStyleBackColor = false;
            this.btnAdcionarVeiculo.Click += new System.EventHandler(this.btnAdcionarVeiculo_Click);
            // 
            // btnLocarVeiculo
            // 
            this.btnLocarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLocarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocarVeiculo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocarVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLocarVeiculo.Location = new System.Drawing.Point(492, 129);
            this.btnLocarVeiculo.Name = "btnLocarVeiculo";
            this.btnLocarVeiculo.Size = new System.Drawing.Size(107, 43);
            this.btnLocarVeiculo.TabIndex = 10;
            this.btnLocarVeiculo.Text = "Locar veículo";
            this.btnLocarVeiculo.UseVisualStyleBackColor = false;
            this.btnLocarVeiculo.Click += new System.EventHandler(this.btnLocarVeiculo_Click);
            // 
            // TabelaFrota
            // 
            this.TabelaFrota.AllowUserToAddRows = false;
            this.TabelaFrota.AllowUserToDeleteRows = false;
            this.TabelaFrota.AllowUserToResizeColumns = false;
            this.TabelaFrota.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.TabelaFrota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaFrota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TabelaFrota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaFrota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaFrota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TabelaFrota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Placa,
            this.Ano,
            this.Cor,
            this.Categoria,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaFrota.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaFrota.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TabelaFrota.Location = new System.Drawing.Point(12, 178);
            this.TabelaFrota.Name = "TabelaFrota";
            this.TabelaFrota.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            this.TabelaFrota.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaFrota.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TabelaFrota.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelaFrota.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TabelaFrota.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TabelaFrota.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TabelaFrota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaFrota.Size = new System.Drawing.Size(926, 373);
            this.TabelaFrota.TabIndex = 0;
            // 
            // btnRemoverVeiculo
            // 
            this.btnRemoverVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRemoverVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverVeiculo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemoverVeiculo.Location = new System.Drawing.Point(718, 129);
            this.btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            this.btnRemoverVeiculo.Size = new System.Drawing.Size(107, 43);
            this.btnRemoverVeiculo.TabIndex = 18;
            this.btnRemoverVeiculo.Text = "Remover veículo";
            this.btnRemoverVeiculo.UseVisualStyleBackColor = false;
            this.btnRemoverVeiculo.Click += new System.EventHandler(this.btnRemoverVeiculo_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDetalhes.Location = new System.Drawing.Point(605, 129);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(107, 43);
            this.btnDetalhes.TabIndex = 19;
            this.btnDetalhes.Text = "Detalhes do veículo";
            this.btnDetalhes.UseVisualStyleBackColor = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // txtLogadoComo
            // 
            this.txtLogadoComo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogadoComo.AutoSize = true;
            this.txtLogadoComo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogadoComo.ForeColor = System.Drawing.Color.White;
            this.txtLogadoComo.Location = new System.Drawing.Point(9, 575);
            this.txtLogadoComo.Name = "txtLogadoComo";
            this.txtLogadoComo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogadoComo.Size = new System.Drawing.Size(38, 16);
            this.txtLogadoComo.TabIndex = 31;
            this.txtLogadoComo.Text = "login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 11);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(12, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(926, 11);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btnAbaTI
            // 
            this.btnAbaTI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbaTI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbaTI.BackgroundImage")));
            this.btnAbaTI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbaTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaTI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbaTI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAbaTI.Location = new System.Drawing.Point(637, 12);
            this.btnAbaTI.Name = "btnAbaTI";
            this.btnAbaTI.Size = new System.Drawing.Size(119, 94);
            this.btnAbaTI.TabIndex = 41;
            this.btnAbaTI.UseVisualStyleBackColor = false;
            this.btnAbaTI.Click += new System.EventHandler(this.btnAbaTI_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFinanceiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.BackgroundImage")));
            this.btnFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFinanceiro.Location = new System.Drawing.Point(512, 12);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(119, 94);
            this.btnFinanceiro.TabIndex = 40;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnAbaClientes
            // 
            this.btnAbaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbaClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbaClientes.BackgroundImage")));
            this.btnAbaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAbaClientes.Location = new System.Drawing.Point(387, 12);
            this.btnAbaClientes.Name = "btnAbaClientes";
            this.btnAbaClientes.Size = new System.Drawing.Size(119, 94);
            this.btnAbaClientes.TabIndex = 39;
            this.btnAbaClientes.UseVisualStyleBackColor = false;
            this.btnAbaClientes.Click += new System.EventHandler(this.btnAbaClientes_Click);
            // 
            // btnControleFuncionarios
            // 
            this.btnControleFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnControleFuncionarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControleFuncionarios.BackgroundImage")));
            this.btnControleFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnControleFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleFuncionarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnControleFuncionarios.Location = new System.Drawing.Point(262, 12);
            this.btnControleFuncionarios.Name = "btnControleFuncionarios";
            this.btnControleFuncionarios.Size = new System.Drawing.Size(119, 94);
            this.btnControleFuncionarios.TabIndex = 38;
            this.btnControleFuncionarios.UseVisualStyleBackColor = false;
            this.btnControleFuncionarios.Click += new System.EventHandler(this.btnControleFuncionarios_Click);
            // 
            // btnAbaControleFrota
            // 
            this.btnAbaControleFrota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbaControleFrota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbaControleFrota.BackgroundImage")));
            this.btnAbaControleFrota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbaControleFrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaControleFrota.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbaControleFrota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAbaControleFrota.Location = new System.Drawing.Point(137, 12);
            this.btnAbaControleFrota.Name = "btnAbaControleFrota";
            this.btnAbaControleFrota.Size = new System.Drawing.Size(119, 94);
            this.btnAbaControleFrota.TabIndex = 37;
            this.btnAbaControleFrota.UseVisualStyleBackColor = false;
            this.btnAbaControleFrota.Click += new System.EventHandler(this.btnAbaControleFrota_Click);
            // 
            // btnAbaInicio
            // 
            this.btnAbaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbaInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbaInicio.BackgroundImage")));
            this.btnAbaInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAbaInicio.Location = new System.Drawing.Point(12, 12);
            this.btnAbaInicio.Name = "btnAbaInicio";
            this.btnAbaInicio.Size = new System.Drawing.Size(119, 94);
            this.btnAbaInicio.TabIndex = 36;
            this.btnAbaInicio.UseVisualStyleBackColor = false;
            this.btnAbaInicio.Click += new System.EventHandler(this.btnAbaInicio_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 50;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ControleFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.btnAbaTI);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnAbaClientes);
            this.Controls.Add(this.btnControleFuncionarios);
            this.Controls.Add(this.btnAbaControleFrota);
            this.Controls.Add(this.btnAbaInicio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLogadoComo);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnRemoverVeiculo);
            this.Controls.Add(this.TabelaFrota);
            this.Controls.Add(this.btnLocarVeiculo);
            this.Controls.Add(this.btnAdcionarVeiculo);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleFrota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleFrota";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFrota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdcionarVeiculo;
        private System.Windows.Forms.Button btnLocarVeiculo;
        private System.Windows.Forms.DataGridView TabelaFrota;
        private System.Windows.Forms.Button btnRemoverVeiculo;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Label txtLogadoComo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAbaTI;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnAbaClientes;
        private System.Windows.Forms.Button btnControleFuncionarios;
        private System.Windows.Forms.Button btnAbaControleFrota;
        private System.Windows.Forms.Button btnAbaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}