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
    public partial class MarcarConsulta : Form
    {

        ConsultaServico consulta = new ConsultaServico();
        VeterinarioServico vet = new VeterinarioServico();


        public MarcarConsulta()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gravar()
        {



            consulta.Gravar(
                new Modelo.Consulta()
                {
                    Pet = txbPet.Text,
                    Veterinario = txbVet.Text,
                    Cliente = txbCliente.Text,
                    Data = dtpData.Value.Date,
                    Hora = txbHora.Text,
                    VencimentoPagamento = DateTime.Now.Date,



        });
        }

        private void LimparCampos()
        {
            txbPet.Clear();
            txbVet.Clear();
            txbCliente.Clear();

           

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            Gravar();
            LimparCampos();
            MessageBox.Show("Consulta marcada com sucesso!");
            this.Hide();
            Consulta consulta = new Consulta();
            consulta.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
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

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
            this.Hide();

        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta escolha = new EscolhaConsulta();

            escolha.Show();
            this.Hide();
        }

        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }
    }
}
