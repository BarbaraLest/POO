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
    public partial class Pet : Form
    {
        private PetServico petServico = new PetServico();
        
        public string cliCpf;

        public Pet()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            CadastroPet cadPet = new CadastroPet(cliCpf);
            cadPet.Show();
            this.Hide();
        }

        private void RefreshDataGridView()
        {
            dgvPet.DataSource = petServico.TodosOsPets();
        }

        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
            this.Hide();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dgvPet.DataSource = petServico.Buscar(Convert.ToString(txbPesquisa.Text));
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            long idSelecionado = Convert.ToInt64(dgvPet.CurrentCell.Value);
              petServico.Excluir(idSelecionado);
            MessageBox.Show("Pet removido com sucesso!");
            RefreshDataGridView();
            gpbAtt.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            Habilita();
            lblInfo.Visible = false;

        }

        private void AttPet()
        {
            petServico.Atualizar(
                 new Modelo.Pet()
                 {
                     PetID = (txbId.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbId.Text),
                     Nome = txbNome.Text,
                     Raça = txbRaca.Text,
                     Idade = Convert.ToInt32(txbIdade.Text),
                     Cor = txbCor.Text,
                     ClienteCpf = Convert.ToString(txbCpf.Text),
                     Peso = Convert.ToDouble(txbPeso.Text),
                     Altura = Convert.ToDouble(txbAltura.Text),
                     Observacoes = txbObs.Text,
                     Tipo = cmbTipo.Text,


                 });
        }

        private void LimparCampos()
        {
            txbId.Text = string.Empty;
            txbNome.Clear();
            txbRaca.Clear();
            txbIdade.Clear();
            txbCor.Clear();
            txbPeso.Clear();
            txbAltura.Clear();
            txbObs.Clear();
        }



        public void Popular(string ID, string nome, string tipo, string raca, string cor, string idade, string peso, string cpf, string obs, string altura)
        {
            Modelo.Pet pet = new Modelo.Pet()
            {

                PetID = Convert.ToInt64(ID),
                Nome = nome,
                Raça = tipo,
                Idade = Convert.ToInt32(idade),
                Cor = cor,
                ClienteCpf = Convert.ToString(cpf),
                Peso = Convert.ToDouble(peso),
                Altura = Convert.ToDouble(altura),
                Observacoes = obs,
                Tipo = tipo,



            };
        }

        private void dgvPet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAtt.Visible = true;
            btnExcluir.Visible = true;
            gpbAtt.Visible = true;
            Desabilita();
            lblInfo.Visible = true;

            int cont = dgvPet.CurrentRow.Index;
            txbId.Text = Convert.ToString(dgvPet["PetID", cont].Value);
            txbNome.Text = Convert.ToString(dgvPet["Nome", cont].Value);
            cmbTipo.Text = Convert.ToString(dgvPet["Tipo", cont].Value);
            txbRaca.Text = Convert.ToString(dgvPet["Raça", cont].Value);
            txbCor.Text = Convert.ToString(dgvPet["Cor", cont].Value);
            txbIdade.Text = Convert.ToString(dgvPet["Idade", cont].Value);
            txbPeso.Text = Convert.ToString(dgvPet["Peso", cont].Value);
            txbCpf.Text = Convert.ToString(dgvPet["ClienteCpf", cont].Value);
            txbObs.Text = Convert.ToString(dgvPet["Observacoes", cont].Value);
            txbAltura.Text = Convert.ToString(dgvPet["Altura", cont].Value);
            Popular(txbId.Text, txbNome.Text, cmbTipo.Text, txbRaca.Text, txbCor.Text, txbIdade.Text, txbPeso.Text, txbCpf.Text, txbObs.Text, txbAltura.Text);

        }

        private void Desabilita()
        {
            txbNome.Enabled = false;
            txbRaca.Enabled = false;
            cmbTipo.Enabled = false;
            txbIdade.Enabled = false;
            txbCor.Enabled = false;
            txbCpf. Enabled = false;
            txbPeso.Enabled = false;
            txbAltura.Enabled = false;
            txbObs.Enabled = false;
            btnSalvar.Visible = false;

        
           
           


        }

        private void Habilita()
        {
            txbNome.Enabled = true;
            cmbTipo.Enabled = true;
            txbRaca.Enabled = true;
            txbIdade.Enabled = true;
            txbCor.Enabled = true;
            txbPeso.Enabled = true;
            txbAltura.Enabled = true;
            txbObs.Enabled = true;
            btnSalvar.Visible = true;
            lblAtt.Visible = true;
            txbCpf.Enabled = true;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AttPet();
            RefreshDataGridView();
            LimparCampos();
            MessageBox.Show("Pet alterado com sucesso!");
            Desabilita();
            btnAtt.Visible = false;

        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta escolha = new EscolhaConsulta();

            escolha.Show();
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
    }

 }

