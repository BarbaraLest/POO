namespace Apresentacao
{
    partial class AcompanhamentoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcompanhamentoConsulta));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblVet = new System.Windows.Forms.Label();
            this.txbPesVet = new System.Windows.Forms.TextBox();
            this.dgvVet = new System.Windows.Forms.DataGridView();
            this.gpbObs = new System.Windows.Forms.GroupBox();
            this.txbObs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbPagemento = new System.Windows.Forms.GroupBox();
            this.txbCaixa = new System.Windows.Forms.TextBox();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbReceitas = new System.Windows.Forms.GroupBox();
            this.btnCadastrarReceita = new System.Windows.Forms.Button();
            this.txbReceitaID = new System.Windows.Forms.TextBox();
            this.cbReceita = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbpDetalhes = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbHora = new System.Windows.Forms.TextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbPet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbVet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExames = new System.Windows.Forms.Button();
            this.btnVeterinario = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.buttonAgenda = new System.Windows.Forms.Button();
            this.buttonFinanceiro = new System.Windows.Forms.Button();
            this.buttonPet = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).BeginInit();
            this.gpbObs.SuspendLayout();
            this.gpbPagemento.SuspendLayout();
            this.gpbReceitas.SuspendLayout();
            this.gbpDetalhes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txbId);
            this.panel3.Controls.Add(this.btnPesquisar);
            this.panel3.Controls.Add(this.lblVet);
            this.panel3.Controls.Add(this.txbPesVet);
            this.panel3.Controls.Add(this.dgvVet);
            this.panel3.Controls.Add(this.gpbObs);
            this.panel3.Controls.Add(this.BtnAtualizar);
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Controls.Add(this.gpbPagemento);
            this.panel3.Controls.Add(this.gpbReceitas);
            this.panel3.Controls.Add(this.gbpDetalhes);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1705, 1004);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(58, 91);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 22);
            this.txbId.TabIndex = 49;
            this.txbId.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(779, 136);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 35);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.Location = new System.Drawing.Point(55, 142);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(120, 23);
            this.lblVet.TabIndex = 44;
            this.lblVet.Text = "Veterinario:";
            // 
            // txbPesVet
            // 
            this.txbPesVet.Location = new System.Drawing.Point(194, 142);
            this.txbPesVet.Name = "txbPesVet";
            this.txbPesVet.Size = new System.Drawing.Size(560, 22);
            this.txbPesVet.TabIndex = 0;
            this.txbPesVet.TextChanged += new System.EventHandler(this.txbPesVet_TextChanged);
            // 
            // dgvVet
            // 
            this.dgvVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVet.Location = new System.Drawing.Point(194, 205);
            this.dgvVet.Name = "dgvVet";
            this.dgvVet.RowTemplate.Height = 24;
            this.dgvVet.Size = new System.Drawing.Size(560, 97);
            this.dgvVet.TabIndex = 2;
            this.dgvVet.Visible = false;
            this.dgvVet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVet_CellContentClick);
            this.dgvVet.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVet_CellContentDoubleClick);
            // 
            // gpbObs
            // 
            this.gpbObs.Controls.Add(this.txbObs);
            this.gpbObs.Controls.Add(this.label3);
            this.gpbObs.Location = new System.Drawing.Point(59, 673);
            this.gpbObs.Name = "gpbObs";
            this.gpbObs.Size = new System.Drawing.Size(795, 289);
            this.gpbObs.TabIndex = 44;
            this.gpbObs.TabStop = false;
            this.gpbObs.Visible = false;
            // 
            // txbObs
            // 
            this.txbObs.Enabled = false;
            this.txbObs.Location = new System.Drawing.Point(125, 21);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(636, 249);
            this.txbObs.TabIndex = 0;
            this.txbObs.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Descrição:";
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(1357, 779);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(193, 66);
            this.BtnAtualizar.TabIndex = 4;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Visible = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1078, 779);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(193, 66);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbPagemento
            // 
            this.gpbPagemento.Controls.Add(this.txbCaixa);
            this.gpbPagemento.Controls.Add(this.dtpPagamento);
            this.gpbPagemento.Controls.Add(this.cbSituacao);
            this.gpbPagemento.Controls.Add(this.dtpVencimento);
            this.gpbPagemento.Controls.Add(this.label9);
            this.gpbPagemento.Controls.Add(this.label8);
            this.gpbPagemento.Controls.Add(this.txbValor);
            this.gpbPagemento.Controls.Add(this.label7);
            this.gpbPagemento.Controls.Add(this.label6);
            this.gpbPagemento.Location = new System.Drawing.Point(947, 522);
            this.gpbPagemento.Name = "gpbPagemento";
            this.gpbPagemento.Size = new System.Drawing.Size(725, 180);
            this.gpbPagemento.TabIndex = 40;
            this.gpbPagemento.TabStop = false;
            this.gpbPagemento.Text = "Pagamento:";
            this.gpbPagemento.Visible = false;
            // 
            // txbCaixa
            // 
            this.txbCaixa.Enabled = false;
            this.txbCaixa.Location = new System.Drawing.Point(224, 29);
            this.txbCaixa.Name = "txbCaixa";
            this.txbCaixa.Size = new System.Drawing.Size(100, 22);
            this.txbCaixa.TabIndex = 1;
            this.txbCaixa.Visible = false;
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Enabled = false;
            this.dtpPagamento.Location = new System.Drawing.Point(259, 141);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(281, 22);
            this.dtpPagamento.TabIndex = 3;
            // 
            // cbSituacao
            // 
            this.cbSituacao.Enabled = false;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Pago",
            "Devendo"});
            this.cbSituacao.Location = new System.Drawing.Point(512, 31);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(121, 24);
            this.cbSituacao.TabIndex = 1;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Enabled = false;
            this.dtpVencimento.Location = new System.Drawing.Point(172, 89);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(295, 22);
            this.dtpVencimento.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Situação:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Data do pagamento:";
            // 
            // txbValor
            // 
            this.txbValor.Enabled = false;
            this.txbValor.Location = new System.Drawing.Point(87, 34);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 22);
            this.txbValor.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Valor:";
            // 
            // gpbReceitas
            // 
            this.gpbReceitas.Controls.Add(this.btnCadastrarReceita);
            this.gpbReceitas.Controls.Add(this.txbReceitaID);
            this.gpbReceitas.Controls.Add(this.cbReceita);
            this.gpbReceitas.Controls.Add(this.label12);
            this.gpbReceitas.Location = new System.Drawing.Point(947, 142);
            this.gpbReceitas.Name = "gpbReceitas";
            this.gpbReceitas.Size = new System.Drawing.Size(725, 285);
            this.gpbReceitas.TabIndex = 39;
            this.gpbReceitas.TabStop = false;
            this.gpbReceitas.Text = "Receitas:";
            // 
            // btnCadastrarReceita
            // 
            this.btnCadastrarReceita.Enabled = false;
            this.btnCadastrarReceita.Location = new System.Drawing.Point(565, 224);
            this.btnCadastrarReceita.Name = "btnCadastrarReceita";
            this.btnCadastrarReceita.Size = new System.Drawing.Size(150, 45);
            this.btnCadastrarReceita.TabIndex = 1;
            this.btnCadastrarReceita.Text = "Registrar Receita";
            this.btnCadastrarReceita.UseVisualStyleBackColor = true;
            this.btnCadastrarReceita.Click += new System.EventHandler(this.btnAtivarReceita_Click);
            // 
            // txbReceitaID
            // 
            this.txbReceitaID.Enabled = false;
            this.txbReceitaID.Location = new System.Drawing.Point(38, 216);
            this.txbReceitaID.Name = "txbReceitaID";
            this.txbReceitaID.Size = new System.Drawing.Size(100, 22);
            this.txbReceitaID.TabIndex = 53;
            this.txbReceitaID.Visible = false;
            // 
            // cbReceita
            // 
            this.cbReceita.Enabled = false;
            this.cbReceita.Location = new System.Drawing.Point(192, 47);
            this.cbReceita.Name = "cbReceita";
            this.cbReceita.Size = new System.Drawing.Size(523, 171);
            this.cbReceita.TabIndex = 0;
            this.cbReceita.Text = "";
            this.cbReceita.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 23);
            this.label12.TabIndex = 44;
            this.label12.Text = "Medicamentos:";
            this.label12.Visible = false;
            // 
            // gbpDetalhes
            // 
            this.gbpDetalhes.Controls.Add(this.label10);
            this.gbpDetalhes.Controls.Add(this.txbHora);
            this.gbpDetalhes.Controls.Add(this.txbCliente);
            this.gbpDetalhes.Controls.Add(this.txbPet);
            this.gbpDetalhes.Controls.Add(this.label5);
            this.gbpDetalhes.Controls.Add(this.label1);
            this.gbpDetalhes.Controls.Add(this.dtpData);
            this.gbpDetalhes.Controls.Add(this.label2);
            this.gbpDetalhes.Controls.Add(this.txbVet);
            this.gbpDetalhes.Controls.Add(this.label4);
            this.gbpDetalhes.Location = new System.Drawing.Point(59, 342);
            this.gbpDetalhes.Name = "gbpDetalhes";
            this.gbpDetalhes.Size = new System.Drawing.Size(795, 289);
            this.gbpDetalhes.TabIndex = 37;
            this.gbpDetalhes.TabStop = false;
            this.gbpDetalhes.Text = "Detalhes:";
            this.gbpDetalhes.Visible = false;
            this.gbpDetalhes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 42;
            this.label10.Text = "Horário:";
            // 
            // txbHora
            // 
            this.txbHora.Enabled = false;
            this.txbHora.Location = new System.Drawing.Point(626, 32);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(144, 22);
            this.txbHora.TabIndex = 1;
            // 
            // txbCliente
            // 
            this.txbCliente.Enabled = false;
            this.txbCliente.Location = new System.Drawing.Point(172, 160);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(347, 22);
            this.txbCliente.TabIndex = 3;
            // 
            // txbPet
            // 
            this.txbPet.Enabled = false;
            this.txbPet.Location = new System.Drawing.Point(172, 216);
            this.txbPet.Name = "txbPet";
            this.txbPet.Size = new System.Drawing.Size(347, 22);
            this.txbPet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Pet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(154, 32);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(304, 22);
            this.dtpData.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Veterinario:";
            // 
            // txbVet
            // 
            this.txbVet.Enabled = false;
            this.txbVet.Location = new System.Drawing.Point(172, 97);
            this.txbVet.Name = "txbVet";
            this.txbVet.Size = new System.Drawing.Size(347, 22);
            this.txbVet.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(648, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 40);
            this.label11.TabIndex = 23;
            this.label11.Text = "Resumo da Consulta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnExames);
            this.panel1.Controls.Add(this.btnVeterinario);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.buttonConsultas);
            this.panel1.Controls.Add(this.buttonAgenda);
            this.panel1.Controls.Add(this.buttonFinanceiro);
            this.panel1.Controls.Add(this.buttonPet);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 1004);
            this.panel1.TabIndex = 11;
            // 
            // btnExames
            // 
            this.btnExames.FlatAppearance.BorderSize = 0;
            this.btnExames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExames.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExames.ForeColor = System.Drawing.Color.White;
            this.btnExames.Image = ((System.Drawing.Image)(resources.GetObject("btnExames.Image")));
            this.btnExames.Location = new System.Drawing.Point(9, 462);
            this.btnExames.Name = "btnExames";
            this.btnExames.Size = new System.Drawing.Size(210, 54);
            this.btnExames.TabIndex = 6;
            this.btnExames.Text = "Exames";
            this.btnExames.UseVisualStyleBackColor = true;
            this.btnExames.Click += new System.EventHandler(this.btnExames_Click);
            // 
            // btnVeterinario
            // 
            this.btnVeterinario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVeterinario.BackgroundImage")));
            this.btnVeterinario.FlatAppearance.BorderSize = 0;
            this.btnVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeterinario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeterinario.ForeColor = System.Drawing.Color.White;
            this.btnVeterinario.Location = new System.Drawing.Point(12, 282);
            this.btnVeterinario.Name = "btnVeterinario";
            this.btnVeterinario.Size = new System.Drawing.Size(210, 54);
            this.btnVeterinario.TabIndex = 3;
            this.btnVeterinario.Text = "Veterinario";
            this.btnVeterinario.UseVisualStyleBackColor = true;
            this.btnVeterinario.Click += new System.EventHandler(this.btnVeterinario_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(9, 102);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(210, 54);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(0, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 54);
            this.panel4.TabIndex = 5;
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConsultas.BackgroundImage")));
            this.buttonConsultas.FlatAppearance.BorderSize = 0;
            this.buttonConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultas.ForeColor = System.Drawing.Color.White;
            this.buttonConsultas.Location = new System.Drawing.Point(9, 402);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Size = new System.Drawing.Size(210, 54);
            this.buttonConsultas.TabIndex = 5;
            this.buttonConsultas.Text = "Consultas";
            this.buttonConsultas.UseVisualStyleBackColor = true;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // buttonAgenda
            // 
            this.buttonAgenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgenda.BackgroundImage")));
            this.buttonAgenda.FlatAppearance.BorderSize = 0;
            this.buttonAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgenda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgenda.ForeColor = System.Drawing.Color.White;
            this.buttonAgenda.Location = new System.Drawing.Point(12, 342);
            this.buttonAgenda.Name = "buttonAgenda";
            this.buttonAgenda.Size = new System.Drawing.Size(210, 54);
            this.buttonAgenda.TabIndex = 4;
            this.buttonAgenda.Text = "Agenda";
            this.buttonAgenda.UseVisualStyleBackColor = true;
            this.buttonAgenda.Click += new System.EventHandler(this.buttonAgenda_Click);
            // 
            // buttonFinanceiro
            // 
            this.buttonFinanceiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFinanceiro.BackgroundImage")));
            this.buttonFinanceiro.FlatAppearance.BorderSize = 0;
            this.buttonFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinanceiro.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinanceiro.ForeColor = System.Drawing.Color.White;
            this.buttonFinanceiro.Location = new System.Drawing.Point(9, 522);
            this.buttonFinanceiro.Name = "buttonFinanceiro";
            this.buttonFinanceiro.Size = new System.Drawing.Size(210, 54);
            this.buttonFinanceiro.TabIndex = 7;
            this.buttonFinanceiro.Text = "Financeiro";
            this.buttonFinanceiro.UseVisualStyleBackColor = true;
            this.buttonFinanceiro.Click += new System.EventHandler(this.buttonFinanceiro_Click);
            // 
            // buttonPet
            // 
            this.buttonPet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPet.BackgroundImage")));
            this.buttonPet.FlatAppearance.BorderSize = 0;
            this.buttonPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPet.ForeColor = System.Drawing.Color.White;
            this.buttonPet.Location = new System.Drawing.Point(12, 222);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(210, 54);
            this.buttonPet.TabIndex = 2;
            this.buttonPet.Text = "Pets";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(12, 162);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(210, 54);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // AcompanhamentoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1004);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcompanhamentoConsulta";
            this.Text = "Acompanhamento da Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).EndInit();
            this.gpbObs.ResumeLayout(false);
            this.gpbObs.PerformLayout();
            this.gpbPagemento.ResumeLayout(false);
            this.gpbPagemento.PerformLayout();
            this.gpbReceitas.ResumeLayout(false);
            this.gpbReceitas.PerformLayout();
            this.gbpDetalhes.ResumeLayout(false);
            this.gbpDetalhes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVeterinario;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonConsultas;
        private System.Windows.Forms.Button buttonAgenda;
        private System.Windows.Forms.Button buttonFinanceiro;
        private System.Windows.Forms.Button buttonPet;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txbObs;
        private System.Windows.Forms.TextBox txbVet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbpDetalhes;
        private System.Windows.Forms.TextBox txbPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbPagemento;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbReceitas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.GroupBox gpbObs;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.TextBox txbPesVet;
        private System.Windows.Forms.DataGridView dgvVet;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.Button btnExames;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox cbReceita;
        private System.Windows.Forms.TextBox txbReceitaID;
        private System.Windows.Forms.Button btnCadastrarReceita;
        private System.Windows.Forms.TextBox txbCaixa;
    }
}