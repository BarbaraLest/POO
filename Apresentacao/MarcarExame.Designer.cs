namespace Apresentacao
{
    partial class MarcarExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcarExame));
            this.gbpDetalhes = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.txbHora = new System.Windows.Forms.TextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbPet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbpDetalhes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpDetalhes
            // 
            this.gbpDetalhes.Controls.Add(this.cbTipo);
            this.gbpDetalhes.Controls.Add(this.label2);
            this.gbpDetalhes.Controls.Add(this.label10);
            this.gbpDetalhes.Controls.Add(this.btnMarcar);
            this.gbpDetalhes.Controls.Add(this.txbHora);
            this.gbpDetalhes.Controls.Add(this.txbCliente);
            this.gbpDetalhes.Controls.Add(this.txbPet);
            this.gbpDetalhes.Controls.Add(this.label5);
            this.gbpDetalhes.Controls.Add(this.label1);
            this.gbpDetalhes.Controls.Add(this.dtpData);
            this.gbpDetalhes.Controls.Add(this.label4);
            this.gbpDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbpDetalhes.Location = new System.Drawing.Point(96, 115);
            this.gbpDetalhes.Name = "gbpDetalhes";
            this.gbpDetalhes.Size = new System.Drawing.Size(821, 438);
            this.gbpDetalhes.TabIndex = 37;
            this.gbpDetalhes.TabStop = false;
            this.gbpDetalhes.Enter += new System.EventHandler(this.gbpDetalhes_Enter);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Exame de sangue",
            "Raio X",
            "Radiografia"});
            this.cbTipo.Location = new System.Drawing.Point(140, 246);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(345, 24);
            this.cbTipo.TabIndex = 4;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 42;
            this.label10.Text = "Horário:";
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(336, 327);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(183, 53);
            this.btnMarcar.TabIndex = 5;
            this.btnMarcar.Text = "Marcar Exame";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // txbHora
            // 
            this.txbHora.Location = new System.Drawing.Point(568, 32);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(197, 22);
            this.txbHora.TabIndex = 1;
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(140, 113);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(347, 22);
            this.txbCliente.TabIndex = 2;
            // 
            // txbPet
            // 
            this.txbPet.Location = new System.Drawing.Point(140, 186);
            this.txbPet.Name = "txbPet";
            this.txbPet.Size = new System.Drawing.Size(347, 22);
            this.txbPet.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 183);
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
            this.dtpData.Location = new System.Drawing.Point(154, 32);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(394, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 40);
            this.label11.TabIndex = 23;
            this.label11.Text = "Novo Exame";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.gbpDetalhes);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 648);
            this.panel3.TabIndex = 16;
            // 
            // MarcarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 648);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarcarExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcar Exame";
            this.gbpDetalhes.ResumeLayout(false);
            this.gbpDetalhes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbpDetalhes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.TextBox txbPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
    }
}