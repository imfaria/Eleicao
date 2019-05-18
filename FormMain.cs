using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPOO
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            CadastrarUmPartido c = new CadastrarUmPartido();
            c.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVotacao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
