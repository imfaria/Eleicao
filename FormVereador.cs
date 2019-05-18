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
    public partial class FormVereador : Form
    {
        public FormVereador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormVereador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_vereador = textBox1.Text;
            string nome = textBox2.Text;
            string dataNascimento = textBox3.Text;
            string cod_partido = textBox4.Text;
            string email = textBox5.Text;
            DateTime data;

            if (cod_vereador == "" || cod_partido == "" || nome == "" || dataNascimento == "" || email == "")
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else if (!DateTime.TryParse(dataNascimento, out data))
            {
                MessageBox.Show("Preencha uma data válida - dd/MM/yyyy");
            }
            else if (cod_vereador.Length != 4)
            {
                MessageBox.Show("Codigo do vereador inválido - max 4 digitos.");
            }
            else
            {
                Vereador vereador = new Vereador(cod_vereador, nome, email, data, cod_partido);
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
