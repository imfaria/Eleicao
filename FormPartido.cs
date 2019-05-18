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
    public partial class FormPartido : Form
    {
        public FormPartido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_partido = textBox1.Text;
            if(cod_partido == "")
            {
                MessageBox.Show("Digite o codigo do partido.");
            }
            else
            {
                Partido p = new Partido(cod_partido);
                MessageBox.Show("Dados gravados com sucesso.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
