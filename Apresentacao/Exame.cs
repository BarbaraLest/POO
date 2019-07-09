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
    public partial class Exame : Form
    {
        ExameServico exameServico = new ExameServico();
        public Exame()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvExames.DataSource = exameServico.TodosOsExames();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinario vet = new Veterinario();
            vet.Show();
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
            EscolhaConsulta consulta = new EscolhaConsulta();
            consulta.Show();
            this.Hide();
        }

        private void buttonFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            financeiro.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MarcarExame marcar = new MarcarExame();
            marcar.Show();
        }

        private void dgvExames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Popular(string ID, string cliente, string vet, string pet, DateTime data, string hora, string tipo, string obs, string situacao, DateTime vencimento, DateTime pagamento, double valor)
        {
            Modelo.Exame exame = new Modelo.Exame()
            {
                ExameID = Convert.ToInt64(ID),
                Cliente = cliente,
                Veterinario = vet,
                Horario = hora,
                Pet = pet,
                Data = data,
                Observacao = obs,
                Descricao = tipo,
                Situacao = situacao,
                VencimentoPagamento = vencimento,
                Pagamento = pagamento,
                Valor = valor,



            };


        }

        private void AtivaCampos()
        {
            txbCliente.Enabled = true;
            txbHora.Enabled = true;
            txbObs.Enabled = true;
            txbPet.Enabled = true;
            txbValor.Enabled = true;
            txbVet.Enabled = true;
            cbSituacao.Enabled = true;
            cbTipo.Enabled = true;
            btnSalvar.Visible = true;
            dtpPagamento.Enabled = true;
            dtpVencimento.Enabled = true;
            dtpData.Enabled = true;
        }

        private void MostraCampos()
        {
            gpbPagemento.Visible = true;
            gbpDetalhes.Visible = true;
            btnExcluir.Visible = true;
            BtnAtualizar.Visible = true;

        }

        private void DesativaCampos()
        {
            gpbPagemento.Visible = false;
            gbpDetalhes.Visible = false;
            btnSalvar.Visible = false;
            BtnAtualizar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void dgvExames_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvExames.CurrentRow.Index;
            MostraCampos();
            txbId.Text = Convert.ToString(dgvExames["ExameID", cont].Value);
            txbCliente.Text = Convert.ToString(dgvExames["Cliente", cont].Value);
            txbPet.Text = Convert.ToString(dgvExames["Pet", cont].Value);
            txbVet.Text = Convert.ToString(dgvExames["Veterinario", cont].Value);
            txbObs.Text = Convert.ToString(dgvExames["Observacao", cont].Value);
            cbTipo.Text = Convert.ToString(dgvExames["Descricao", cont].Value);
            txbHora.Text = Convert.ToString(dgvExames["Horario", cont].Value);
            dtpData.Value = Convert.ToDateTime(dgvExames["Data", cont].Value);
           
            txbValor.Text = Convert.ToString(dgvExames["Valor", cont].Value);
            double valor = Convert.ToDouble(txbValor.Text);
            cbSituacao.Text = Convert.ToString(dgvExames["Situacao", cont].Value);
            dtpPagamento.Value = Convert.ToDateTime(dgvExames["Data", cont].Value);
            dtpVencimento.Value = Convert.ToDateTime(dgvExames["VencimentoPagamento", cont].Value);
            Popular(txbId.Text, txbCliente.Text, txbVet.Text, txbPet.Text, dtpData.Value, txbHora.Text, cbTipo.Text, txbObs.Text, cbSituacao.Text, dtpVencimento.Value, dtpPagamento.Value, valor);
        }

        private void Atualizar()
        {
            exameServico.Atualizar(
                new Modelo.Exame()
                {       
                    ExameID = (txbId.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txbId.Text),

                    Cliente = txbCliente.Text,
                    Veterinario = txbVet.Text,
                    Horario = txbHora.Text,
                    Pet = txbPet.Text,
                    Data = dtpData.Value,
                    Observacao = txbObs.Text,
                    Descricao = cbTipo.Text,
                    Situacao = cbSituacao.Text,
                    Valor = Convert.ToDouble(txbValor.Text),
                    VencimentoPagamento = dtpVencimento.Value,
                    Pagamento = dtpPagamento.Value,


                });

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtivaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DesativaCampos();
            Atualizar();
            MessageBox.Show("Exame atualizado com sucesso!");
            RefreshDataGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            long idSelecionado = Convert.ToInt64(dgvExames.CurrentCell.Value);
            exameServico.Excluir(idSelecionado);
            MessageBox.Show("Exame removido com sucesso!");
            RefreshDataGridView();
            DesativaCampos();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            EscolhaExame escolha = new EscolhaExame();

            escolha.Show();
            this.Hide();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            dgvExames.DataSource = exameServico.BuscarCliente(Convert.ToString(txbPesquisa.Text));
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
