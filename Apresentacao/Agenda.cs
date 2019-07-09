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
using Servico;
using Persistencia;
namespace Apresentacao
{
    public partial class Agenda : Form
    {
        ConsultaServico consultaServico = new ConsultaServico();
        ExameServico exameServico = new ExameServico();
       

        public Agenda()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscolhaConsulta consulta = new EscolhaConsulta();
            consulta.Show();
            this.Hide();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            EscolhaExame exame = new EscolhaExame();
            exame.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            financeiro.Show();
            this.Hide();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

       

        private void mcAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void FormataCamposConsulta()
        {
            dgvAgenda.Columns["ConsultaID"].Visible = false;
            dgvAgenda.Columns["Observacoes"].Visible = false;
            dgvAgenda.Columns["Situacao"].Visible = false;
            dgvAgenda.Columns["Valor"].Visible = false;
            dgvAgenda.Columns["Pagamento"].Visible = false;
            dgvAgenda.Columns["vencimentoPagamento"].Visible = false;
        }

        private void FormataCamposExame()
        {
            dgvAgenda.Columns["ExameID"].Visible = false;
            dgvAgenda.Columns["Observacao"].Visible = false;
            dgvAgenda.Columns["Valor"].Visible = false;
            dgvAgenda.Columns["Pagamento"].Visible = false;
            dgvAgenda.Columns["vencimentoPagamento"].Visible = false;
            dgvAgenda.Columns["Veterinario"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = consultaServico.BuscarPorData(mcAgenda.SelectionStart, mcAgenda.SelectionEnd);
            FormataCamposConsulta();

        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = exameServico.BuscarPorData(mcAgenda.SelectionStart, mcAgenda.SelectionEnd);
            FormataCamposExame();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = consultaServico.BuscarPorData(mcAgenda.SelectionStart, mcAgenda.SelectionEnd);
        }
    }
}
