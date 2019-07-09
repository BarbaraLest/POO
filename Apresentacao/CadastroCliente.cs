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
    public partial class CadastroCliente : Form
    {
        private ClienteServico clienteServico = new ClienteServico();

        public string cliCpf;

        public CadastroCliente()
        {
            InitializeComponent();
             


         }

       
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
                
        }
        

        private void GravarCliente()
        {
            clienteServico.Gravar(
                new Modelo.Cliente()
                {
                    ClienteID = (txbID.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbID.Text),
                    Nome = txbNome.Text,
                    Cpf = txbCpf.Text,
                    Email = txbEmail.Text,
                    Endereco = txbEndereco.Text,
                    Numero = Convert.ToInt32(txbNum.Text),
                    Bairro = txbBairro.Text,
                    Cidade = txbCidade.Text,
                    Uf = txbUf.Text,
                    Telefone1 = txbTel1.Text,
                    Telefone2 = txbTel2.Text,
                    


                });
        }

        private void LimparCampos()
        {

            txbID.Text = string.Empty;
            txbNome.Clear();
            txbCpf.Clear();
            txbEndereco.Clear();
            txbNum.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbUf.Clear();
            txbTel2.Clear();
            txbTel1.Clear();
            txbEmail.Clear();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (ValidarEmail(txbEmail.Text) == false)
            {
                MessageBox.Show("Email com formato incorreto!", "ef3.Cinco");
            }
            else
            {
                GravarCliente();
                MessageBox.Show("Cliente cadastrado com sucesso");
                //LimparCampos();

            }

           
            

        }

        private void popularControles(Cliente cliente)
        {
         //   txbID.Text = cliente.ClienteID
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliCpf = txbCpf.Text;
            CadastroPet cadPet = new CadastroPet(cliCpf);
            cadPet.Show();
            this.Hide();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }

        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txbTel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

            EscolhaConsulta consulta = new EscolhaConsulta();
            consulta.Show();
            this.Hide();

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {

            Agenda agenda = new Agenda();
            agenda.Show();
            this.Hide();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {

            Financeiro financeiro = new Financeiro();
            financeiro.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExames_Click(object sender, EventArgs e)
        {

            EscolhaExame exame = new EscolhaExame();
            exame.Show();
            this.Hide();

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.Hide();
            cli.Show();
        }
    }
    
}
