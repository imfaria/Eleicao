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
    public partial class FormPrefeito : Form
    {
        public FormPrefeito()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVicePrefeito frm = new FormVicePrefeito();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_prefeito = textBox1.Text;
            string nome = textBox2.Text;
            string dataNascimento =  textBox3.Text;
            string cod_partido = textBox4.Text;
            string email = textBox5.Text;
            DateTime data;
            string Vicenome = textBox9.Text;
            string VicedataNascimento = textBox8.Text;
            string Viceemail = textBox6.Text;
            DateTime vicedata;


            if (cod_partido == "" || cod_prefeito == "" || nome == "" || dataNascimento == "" || email == "")
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else if (cod_prefeito.Length != 2)
            {
                MessageBox.Show("O tamanho do codigo do prefeito deve ser\n" +
                                "de no máximo 2 dígitos.");
            }
            else if(!DateTime.TryParse(dataNascimento, out data))
            {
                MessageBox.Show("Data inválida.");
            }
            else if (Vicenome == "" || VicedataNascimento == "" || Viceemail == "")
            {
                MessageBox.Show("Preencha todos os campos do vice-prefeito.");
            }
            else if (!DateTime.TryParse(VicedataNascimento, out vicedata))
            {
                MessageBox.Show("Data inválida.");
            }
            else
            {
                Prefeito prefeito = new Prefeito(cod_prefeito, nome, email, data, cod_partido);
                VicePrefeito Viceprefeito = new VicePrefeito(Vicenome, Viceemail, vicedata, cod_partido, cod_prefeito);
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
