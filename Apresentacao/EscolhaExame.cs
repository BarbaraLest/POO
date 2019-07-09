using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class EscolhaExame : Form
    {
        public EscolhaExame()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MarcarExame marcar = new MarcarExame();
            Home home = new Home();
            marcar.Show();
            home.Hide();
            this.Hide();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            Home home = new Home();
            exame.Show();
            home.Hide();
            this.Hide();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            exame.Show();
            this.Hide();
        }
    }
}
