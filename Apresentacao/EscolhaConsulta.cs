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
using Apresentacao;

namespace Apresentacao
{
    public partial class EscolhaConsulta : Form
    {
        public EscolhaConsulta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MarcarConsulta consulta = new MarcarConsulta();
            consulta.Show();
            this.Hide();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            AcompanhamentoConsulta consulta = new AcompanhamentoConsulta();
            this.Hide();
            consulta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
            this.Hide();
        }
    }
}