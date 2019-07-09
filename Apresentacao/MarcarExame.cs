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
    public partial class MarcarExame : Form
    {
        ExameServico exameServico = new ExameServico();
        public MarcarExame()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            Gravar();
            MessageBox.Show("Exame marcado com sucesso!");
            Exame exame = new Exame();
            exame.Show();
            this.Hide();
        }

        private void Gravar()
        {
            exameServico.Gravar(
                new Modelo.Exame
                {
                    Cliente = txbCliente.Text,
                    Pet = txbPet.Text,
                    Horario = txbHora.Text,
                    Data = dtpData.Value.Date,
                    Descricao = cbTipo.Text,
                    VencimentoPagamento = DateTime.Now.Date,

                });
        }

        private void gbpDetalhes_Enter(object sender, EventArgs e)
        {

        }
    }
}

