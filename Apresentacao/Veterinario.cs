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
    public partial class Veterinario : Form
    {
        private VeterinarioServico vetServico = new VeterinarioServico();

        public Veterinario()
        {
            InitializeComponent();
            RefreshDataGridView();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroVeterinario cadVet = new CadastroVeterinario();
            cadVet.Show();
            this.Hide();
        }

        private void RefreshDataGridView()
        {
            dgvConsulta.DataSource = vetServico.TodosOsVeterinarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            long idSelecionado = Convert.ToInt64(dgvConsulta.CurrentCell.Value);
            vetServico.Excluir(idSelecionado);
            MessageBox.Show("Veterinario removido com sucesso!");
            RefreshDataGridView();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            
                dgvConsulta.DataSource = vetServico.Buscar(Convert.ToString(txbPesquisa.Text));
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Veterinario_Load(object sender, EventArgs e)
        {

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Habilita();
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

        private void dgvConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvConsulta.CurrentRow.Index;
            txbNome.Text = Convert.ToString(dgvConsulta["Nome", cont].Value);
            txbCpf.Text = Convert.ToString(dgvConsulta["Cpf", cont].Value);
            txbEmail.Text = Convert.ToString(dgvConsulta["Email", cont].Value);
            txbEndereco.Text = Convert.ToString(dgvConsulta["Endereco", cont].Value);
            txbBairro.Text = Convert.ToString(dgvConsulta["Bairro", cont].Value);
            txbCidade.Text = Convert.ToString(dgvConsulta["Cidade", cont].Value);
            txbUf.Text = Convert.ToString(dgvConsulta["Uf", cont].Value);
            txbNum.Text = Convert.ToString(dgvConsulta["Numero", cont].Value);
            txbTel1.Text = Convert.ToString(dgvConsulta["Telefone1", cont].Value);
            txbTel2.Text = Convert.ToString(dgvConsulta["Telefone2", cont].Value);
            txbId.Text = Convert.ToString(dgvConsulta["VeterinarioID", cont].Value);
            Popular(txbId.Text, txbNome.Text, txbEmail.Text, txbCpf.Text, txbTel1.Text, txbTel2.Text, txbEndereco.Text, txbCidade.Text, txbBairro.Text, txbUf.Text, txbNum.Text);
            btnAtt.Visible = true;
            btnExcluir.Visible = true;
            gpbAtt.Visible = true;
            lblInfo.Visible = true;
        }

        public void Popular(string ID, string nome, string email, string cpf, string tel1, string tel2, string endereco, string cidade, string bairro, string uf, string num)
        {
            Modelo.Veterinario vet = new Modelo.Veterinario()
            {
                VeterinarioID = Convert.ToInt64(ID),
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txbEmail.Text) == false)
            {
                MessageBox.Show("Email com formato incorreto!", "ef3.Cinco");
            }
            else
            {
                AtualizarVeterinario();
                RefreshDataGridView();
                LimparCampos();
                MessageBox.Show("Veterinario alterado com sucesso!");
                Desabilita();
            }
        }

        private void AtualizarVeterinario()
        {
            vetServico.Atualizar(
                new Modelo.Veterinario()
                {
                    VeterinarioID = (txbId.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbId.Text),
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

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta escolha = new EscolhaConsulta();

            escolha.Show();
            this.Hide();
        }

        private void buttonFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            financeiro.Show();
            this.Hide();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            EscolhaExame exame = new EscolhaExame();
            exame.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }
    }
}
