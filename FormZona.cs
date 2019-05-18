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
    public partial class FormZona : Form
    {
        public FormZona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cod_zona = textBox1.Text;

            if(cod_zona == "")
            {
                MessageBox.Show("Digite o código da zona.");
            }
            else
            {
                Zona zona = new Zona(cod_zona);
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
