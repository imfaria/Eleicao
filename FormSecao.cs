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
    public partial class FormSecao : Form
    {
        public FormSecao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cod_secao = textBox1.Text;

            if (cod_secao == "")
            {
                MessageBox.Show("Digite o código da seção.");
            }
            else
            {
                Secao zona = new Secao(cod_secao);
                MessageBox.Show("Dados gravados com sucesso.");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
