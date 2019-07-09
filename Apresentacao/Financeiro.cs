using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Persistencia;
using Servico;


namespace Apresentacao
{
    public partial class Financeiro : Form
    {
        ConsultaServico consultaServico = new ConsultaServico();
        ExameServico exameServico = new ExameServico();

        public Financeiro()
        {
            InitializeComponent();
            RefreshDataGridView();
          
        }

        private void RefreshDataGridView()
        {
            dgvConsultas.DataSource = consultaServico.TodasAsConsultas();
        }



        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsultas_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.ColumnIndex == 1 && e.RowIndex ==1)
            {
                e.CellStyle.BackColor = Color.Green;
            }
        }

        private void pagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = consultaServico.Situacao("Pago");
            FormataConsulta();
           

        }

        private void FormataConsulta()
        {
            dgvConsultas.Columns["Pet"].Visible = false;
            dgvConsultas.Columns["Veterinario"].Visible = false;
            dgvConsultas.Columns["Cliente"].Visible = false;
            dgvConsultas.Columns["Hora"].Visible = false;
            dgvConsultas.Columns["Observacoes"].Visible = false;
            dgvConsultas.Columns["Situacao"].Visible = false;
            dgvConsultas.Columns["VencimentoPagamento"].Visible = false;

        }
        private void FormataConsultaNPaga()
        {
            dgvConsultas.Columns["Pet"].Visible = false;
            dgvConsultas.Columns["Veterinario"].Visible = false;
            dgvConsultas.Columns["Cliente"].Visible = false;
            dgvConsultas.Columns["Hora"].Visible = false;
            dgvConsultas.Columns["Observacoes"].Visible = false;
            dgvConsultas.Columns["Situacao"].Visible = false;
            dgvConsultas.Columns["Pagamento"].Visible = false;
            dgvConsultas.Columns["VencimentoPagamento"].Visible = true;


        }


        private void FormataExames()
        {
            dgvConsultas.Columns["Pet"].Visible = false;
            dgvConsultas.Columns["Veterinario"].Visible = false;
            dgvConsultas.Columns["Cliente"].Visible = false;
            dgvConsultas.Columns["Horario"].Visible = false;
            dgvConsultas.Columns["Observacao"].Visible = false;
            dgvConsultas.Columns["Situacao"].Visible = false;
            dgvConsultas.Columns["VencimentoPagamento"].Visible = false;
            dgvConsultas.Columns["Descricao"].Visible = false;

        }

        private void FormataExamesNPagos()
        {
            dgvConsultas.Columns["Pet"].Visible = false;
            dgvConsultas.Columns["Veterinario"].Visible = false;
            dgvConsultas.Columns["Cliente"].Visible = false;
            dgvConsultas.Columns["Horario"].Visible = false;
            dgvConsultas.Columns["Observacao"].Visible = false;
            dgvConsultas.Columns["Situacao"].Visible = false;
            dgvConsultas.Columns["Pagamento"].Visible = false;
            dgvConsultas.Columns["Descricao"].Visible = false;

        }

        private void emDébitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = consultaServico.Situacao("Devendo");
            FormataConsultaNPaga();
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = exameServico.Situacao("Pago");
            FormataExames();

        }

        private void emDébitoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = exameServico.Situacao("Devendo");
            FormataExamesNPagos();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta escolha = new EscolhaConsulta();

            escolha.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
            this.Hide();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
            this.Hide();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            EscolhaExame exame = new EscolhaExame();
            exame.Show();
            this.Hide();
        }

        private void buttonFinanceiro_Click(object sender, EventArgs e)
        {

            Financeiro financeiro = new Financeiro();
            financeiro.Show();
            this.Hide();
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
