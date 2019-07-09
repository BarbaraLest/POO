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
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class AcompanhamentoConsulta : Form
    {
     
        ConsultaServico consultaServico = new ConsultaServico();
        VeterinarioServico vet = new VeterinarioServico();
        ReceitaServico receitaServico = new ReceitaServico();
       




        public AcompanhamentoConsulta()
        {
            InitializeComponent();
            DesativarCampos();
            
           

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                AtualizarCData();
            
            
            
            MessageBox.Show("Consulta atualizada com sucesso!");
            
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
            this.Hide();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            EscolhaConsulta consulta = new EscolhaConsulta();
            consulta.Show();
            this.Hide();
        }

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
            this.Hide();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
            this.Hide();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

       

        private void LimparCampos()
        {
            txbPet.Clear();
            txbVet.Clear();
            txbCliente.Clear();
            
            txbHora.Clear();
            txbObs.Clear();
            txbValor.Clear();
            
            
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvVet.DataSource = consultaServico.BuscarVet(Convert.ToString(txbPesVet.Text));
           
            dgvVet.Visible = true;
        }

        private void MostrarCampos()
        {
            gbpDetalhes.Visible = true;
            
            gpbPagemento.Visible = true;
            gpbReceitas.Visible = true;
            gpbObs.Visible = true;
            BtnAtualizar.Visible = true;
            cbReceita.Visible = true;
            label12.Visible = true;
            dgvVet.Visible = true;
        }

        private void DesativarCampos()
        {
            gbpDetalhes.Visible = false;
           
            gpbPagemento.Visible = false;
            gpbReceitas.Visible = false;
            gpbObs.Visible = false;
            BtnAtualizar.Visible = false;
            btnSalvar.Visible = false;
        }

       

        

        private void dgvVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro caixa = new Financeiro();
            caixa.Show();
            this.Hide();
        }

        public void Popular(string ID, string cliente, string vet, string hora, string pet, DateTime data, string obs, string situacao, DateTime vencimento, double valor, DateTime pagamento)
        {
            Modelo.Consulta consulta = new Modelo.Consulta()
            {
                ConsultaID = Convert.ToInt64(ID),
                Cliente = cliente,
                Veterinario = vet,
                Hora = hora,
                Pet = pet,
                Data = data,
                Observacoes = obs,
                Situacao = situacao,
                VencimentoPagamento = vencimento,
                Valor = valor,
                Pagamento = pagamento,
                


            };


        }

        private void GravarReceita()
        {
            receitaServico.Gravar(
                new Modelo.Receita()
                {
                    ReceitaID = (txbReceitaID.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbReceitaID.Text),
                    Cliente = txbCliente.Text,
                    Veterinario = txbVet.Text,
                    Pet = txbPet.Text,
                    Data = dtpData.Value,
                    Descricao = cbReceita.Text,
                });
           
         }

        private void AtualizaReceita()
        {

            receitaServico.Atualizar(
                new Modelo.Receita()
                {
                    ReceitaID = (txbReceitaID.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbReceitaID.Text),
                    Cliente = txbCliente.Text,
                    Veterinario = txbVet.Text,
                    Pet = txbVet.Text,
                    Data = dtpData.Value,
                    Descricao = cbReceita.Text,

                  });

        }

        private void dgvVet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarCampos();
           
            int cont = dgvVet.CurrentRow.Index;
            txbId.Text = Convert.ToString(dgvVet["ConsultaID", cont].Value);
            txbCliente.Text = Convert.ToString(dgvVet["Cliente", cont].Value);
            txbVet.Text = Convert.ToString(dgvVet["Veterinario", cont].Value);
            txbHora.Text = Convert.ToString(dgvVet["Hora", cont].Value);
            txbPet.Text = Convert.ToString(dgvVet["Pet", cont].Value);
            dtpData.Value = Convert.ToDateTime(dgvVet["Data", cont].Value);
            txbObs.Text = Convert.ToString(dgvVet["Observacoes", cont].Value);
            txbValor.Text = Convert.ToString(dgvVet["Valor", cont].Value);
            cbSituacao.Text = Convert.ToString(dgvVet["Situacao", cont].Value);
            dtpPagamento.Value = Convert.ToDateTime(dgvVet["Data", cont].Value);
            dtpVencimento.Value = Convert.ToDateTime(dgvVet["VencimentoPagamento", cont].Value);
            double valor;
            valor = Convert.ToDouble(txbValor.Text);
            Popular(txbId.Text, txbCliente.Text, txbVet.Text, txbHora.Text, txbPet.Text, dtpData.Value, txbObs.Text, cbSituacao.Text, dtpVencimento.Value, valor, dtpPagamento.Value);

        }

        private void Edicao()
        {
            txbCliente.Enabled = true;
            txbHora.Enabled = true;
            txbObs.Enabled = true;
            dtpPagamento.Enabled = true;
            txbPet.Enabled = true;
            txbValor.Enabled = true;
            txbVet.Enabled = true;
            btnSalvar.Visible = true;
            dtpPagamento.Enabled = true;
            dtpVencimento.Enabled = true;
            cbSituacao.Enabled = true;
            cbReceita.Enabled = true;
    
            btnCadastrarReceita.Enabled = true;

        }

        private void RefreshDataGridView()
        {
            dgvVet.DataSource = vet.TodosOsVeterinarios();
         
        }

       
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Edicao();
           
            btnCadastrarReceita.Enabled = true;
        }

        private void AtualizarCData()
        {
            consultaServico.Atualizar(
                new Modelo.Consulta()
            {
                ConsultaID = (txbId.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbId.Text),
                   
                    Cliente = txbCliente.Text,
                    Veterinario = txbVet.Text,
                    Hora = txbHora.Text,
                    Pet = txbPet.Text,
                    Data = dtpData.Value,
                    Observacoes = txbObs.Text,
                    Situacao = cbSituacao.Text,
                    VencimentoPagamento = dtpVencimento.Value,
                    Pagamento = dtpPagamento.Value,
                    Valor = Convert.ToDouble(txbValor.Text),


                });

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtivarReceita_Click(object sender, EventArgs e)
        {
           
            GravarReceita();

        }

        private void txbPesVet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            EscolhaExame exame = new EscolhaExame();
            exame.Show();
            this.Hide();
        }
    }
}
