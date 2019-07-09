using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta consulta = new EscolhaConsulta();
            consulta.Show();
            
        }

        private void buttonFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            financeiro.Show();
            this.Hide();


        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            EscolhaExame exame = new EscolhaExame();
            exame.Show();
            
        }
    }
}
