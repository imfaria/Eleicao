using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Eleitor
    {
        public static List<Eleitor> lstEleitores = new List<Eleitor>();
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Titulo { get; set; }
        public Zona Zona { get; set; }
        public Secao Secao { get; set; }

        public Eleitor(string Nome,DateTime DataNascimento, string Titulo, string CodZona, string CodSecao)
        {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Titulo = Titulo;
            Zona = Zona.lstZonas.Where(m => m.CodZona == CodZona).FirstOrDefault();
            Secao = Secao.lstSecoes.Where(m => m.CodSecao == CodSecao).FirstOrDefault();
            lstEleitores.Add(this);
        }

        public void ExcluirEleitor(string titulo)
        {
            foreach (Eleitor eleitor in Eleitor.lstEleitores)
            {
                if (eleitor.Titulo == titulo)
                {
                    Eleitor.lstEleitores.Remove(eleitor);
                }
            }
        }

        public Eleitor PesquisaEleitor(string titulo)
        {
            foreach (Eleitor eleitor in Eleitor.lstEleitores)
            {
                if (eleitor.Titulo == titulo)
                {
                    return eleitor;
                }
            }
            return null;
        }

        public void AlterarEleitor(string Nome, DateTime DataNascimento, string Titulo, string CodZona, string CodSecao)
        {
            Eleitor eleitor = PesquisaEleitor(Titulo);
            Eleitor.lstEleitores.Remove(eleitor);

            eleitor.Nome = Nome;
            eleitor.DataNascimento = DataNascimento;
            eleitor.Titulo = Titulo;
            foreach (Zona item in Zona.lstZonas)
            {
                if (item.CodZona == CodZona)
                {
                    eleitor.Zona = item;
                }
            }
            foreach (Secao item2 in Secao.lstSecoes)
            {
                if (item2.CodSecao == CodSecao)
                {
                    eleitor.Secao = item2;
                }
            }
            Eleitor.lstEleitores.Add(eleitor);
        }

    }
}
