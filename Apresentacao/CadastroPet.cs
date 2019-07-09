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
    public partial class CadastroPet : Form
    {
        private PetServico petServico = new PetServico();

        public string cliCpf { get; set; }

        public CadastroPet(string cliCpf)
        {
            this.cliCpf = cliCpf;
            InitializeComponent();
           


            if(this.cliCpf != null)
            {
                txbCpf.Text = Convert.ToString(this.cliCpf);
            }

            
        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAgenda_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
            this.Hide();
        }

        private void buttonFinanceiro_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void GravarPet()
        {
            petServico.Gravar(
                 new Modelo.Pet()
                 {

                     Nome = txbNome.Text,
                     Raça = txbRaca.Text,
                     Idade = Convert.ToInt32(txbIdade.Text),
                     Cor = txbCor.Text,
                     ClienteCpf = txbCpf.Text,
                     Peso = Convert.ToDouble(txbPeso.Text),
                     Altura = Convert.ToDouble(txbAltura.Text),
                     Observacoes = txbObs.Text,
                     Tipo = cmbTipo.Text,
                    
                     

                 });
        }

        private void LimparCampos()
        {
            txbNome.Clear();
            txbRaca.Clear();
            txbIdade.Clear();
            txbCor.Clear();
            txbPeso.Clear();
            txbAltura.Clear();
            txbObs.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            GravarPet();
            LimparCampos();
            MessageBox.Show("Pet cadastrado com sucesso!");
            this.Hide();
            Pet pet = new Pet();
            pet.Show();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
