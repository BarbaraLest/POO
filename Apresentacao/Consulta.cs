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
    public partial class Consulta : Form
    {
        ConsultaServico consultaServico = new ConsultaServico();
        public Consulta()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvConsultas.DataSource = consultaServico.TodasAsConsultas();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta consulta = new EscolhaConsulta();
            consulta.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MarcarConsulta cadconsulta = new MarcarConsulta();
            cadconsulta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcompanhamentoConsulta acompanhamento = new AcompanhamentoConsulta();
            acompanhamento.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = consultaServico.BuscarPet(Convert.ToString(txbPesquisa.Text));
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

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
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

        private void btnExcuir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
