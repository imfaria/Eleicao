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
    public partial class CadastrarUmPartido : Form
    {
        public CadastrarUmPartido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVereador frm = new FormVereador();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSecao s = new FormSecao();
            s.Show();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            FormPrefeito pre = new FormPrefeito();
            pre.Show();
        }

        private void btnZona_Click(object sender, EventArgs e)
        {
            FormZona z = new FormZona();
            z.Show();
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            FormPartido p = new FormPartido();
            p.Show();
        }
    }
}
