using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;
using System.Data.SqlClient;
using Modelo;
using Persistencia;

namespace Apresentacao
{
    public partial class Cliente : Form
    {
        private ClienteServico clienteServico = new ClienteServico();
        

      

        public Cliente()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
            this.Hide();
        }

        private void RefreshDataGridView()
        {
            dgvClientes.DataSource = clienteServico.TodosOsClientes();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clienteServico.Buscar(Convert.ToString(txbPesquisa.Text));
        }


        public void Popular(string ID, string nome, string email, string cpf, string tel1, string tel2, string endereco, string cidade, string bairro, string uf, string num)
        {
            Modelo.Cliente cliente = new Modelo.Cliente()
            {
                ClienteID = Convert.ToInt64(ID),
                Nome = nome,
                Email = email,
                Cpf = cpf,
                Telefone1 = tel1,
                Telefone2 = tel2,
                Endereco = endereco,
                Bairro = bairro,
                Cidade = cidade,
                Uf = uf,
                Numero = Convert.ToInt32(num)


            };
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvClientes.CurrentRow.Index;
            txbNome.Text = Convert.ToString(dgvClientes["Nome", cont].Value);
            txbCpf.Text = Convert.ToString(dgvClientes["Cpf", cont].Value);
            txbEmail.Text = Convert.ToString(dgvClientes["Email", cont].Value);
            txbEndereco.Text = Convert.ToString(dgvClientes["Endereco", cont].Value);
            txbBairro.Text = Convert.ToString(dgvClientes["Bairro", cont].Value);
            txbCidade.Text = Convert.ToString(dgvClientes["Cidade", cont].Value);
            txbUf.Text = Convert.ToString(dgvClientes["Uf", cont].Value);
            txbNum.Text = Convert.ToString(dgvClientes["Numero", cont].Value);
            txbTel1.Text = Convert.ToString(dgvClientes["Telefone1", cont].Value);
            txbTel2.Text = Convert.ToString(dgvClientes["Telefone2", cont].Value);
            txbId.Text = Convert.ToString(dgvClientes["ClienteID", cont].Value);
            Popular(txbId.Text, txbNome.Text, txbEmail.Text, txbCpf.Text, txbTel1.Text, txbTel2.Text, txbEndereco.Text, txbCidade.Text, txbBairro.Text, txbUf.Text, txbNum.Text);
            btnAtt.Visible = true;
            btnExcluir.Visible = true;
            gpbAtt.Visible = true;
            lblInfo.Visible = true;
            btnHist.Visible = true;




        }        

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Habilita();

        } 

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            long idSelecionado = Convert.ToInt64(dgvClientes.CurrentCell.Value);
            clienteServico.Excluir(idSelecionado);
            MessageBox.Show("Cliente removido com sucesso!");
            RefreshDataGridView();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }


        private void GravarCliente()
        {
            clienteServico.Atualizar(
                new Modelo.Cliente()
                {
                    ClienteID = (txbId.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbId.Text),
                    Nome = txbNome.Text,
                    Cpf = txbCpf.Text,
                    Endereco = txbEndereco.Text,
                    Numero = Convert.ToInt32(txbNum.Text),
                    Bairro = txbBairro.Text,
                    Cidade = txbCidade.Text,
                    Uf = txbUf.Text,
                    Telefone1 = txbTel1.Text,
                    Telefone2 = txbTel2.Text,
                    Email = txbEmail.Text,

                });
        }

        private void LimparCampos()
        {

            txbId.Text = string.Empty;
            txbNome.Clear();
            txbCpf.Clear();
            txbEndereco.Clear();
            txbNum.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbUf.Clear();
            txbTel2.Clear();
            txbTel1.Clear();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txbEmail.Text) == false)
            {
                MessageBox.Show("Email com formato incorreto!", "ef3.Cinco");
            }
            else
            {
                GravarCliente();
                RefreshDataGridView();
                LimparCampos();
                MessageBox.Show("Cliente alterado com sucesso!");
                Desabilita();
            }
            
        }

        private void Habilita()
        {
            lblAtt.Visible = true;
            txbNome.Enabled = true;
            txbCpf.Enabled = true;
            txbEndereco.Enabled = true;
            txbNum.Enabled = true;
            txbBairro.Enabled = true;
            txbCidade.Enabled = true;
            txbUf.Enabled = true;
            txbTel2.Enabled = true;
            txbTel1.Enabled = true;
            btnSalvar.Visible = true;
            txbEmail.Enabled = true; 

        }

        private void Desabilita()
        {
            lblAtt.Visible = false;
            txbNome.Enabled = false;
            txbCpf.Enabled = false;
            txbEndereco.Enabled = false;
            txbNum.Enabled = false;
            txbBairro.Enabled = false;
            txbCidade.Enabled = false;
            txbUf.Enabled = false;
            txbTel2.Enabled = false;
            txbTel1.Enabled = false;
            btnSalvar.Visible = false;
            btnAtt.Visible = false;
            gpbAtt.Visible = false;
            txbEmail.Enabled = false;


        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void gpbAtt_Enter(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            HistoricoCliente hist = new HistoricoCliente(nome);
            hist.Show();


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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
