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
    public partial class HistoricoCliente : Form
    {
        private ClienteServico clienteServico = new ClienteServico();
        ConsultaServico consultaServico = new ConsultaServico();
        ExameServico exameServico = new ExameServico();

        public HistoricoCliente(string nome)
        {
            InitializeComponent();
            txbNome.Text = nome;
            RefreshConsulta();
           
        }
        private void RefreshConsulta()
        {
            dgvHist.DataSource = consultaServico.BuscarCliente(Convert.ToString(txbNome.Text));
        }

        private void RefreshExame()
        {
            dgvHist.DataSource = exameServico.BuscarCliente(Convert.ToString(txbNome.Text));
        }

        private void HistoricoCliente_Load(object sender, EventArgs e)
        {

        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshExame();
        }

        private void dgvHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshConsulta();

        }
    }
}
