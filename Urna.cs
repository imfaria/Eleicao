using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Urna
    {
        public static List<Urna> lstUrnas = new List<Urna>();//Context
        public int serial;
        public Zona Zona { get; set; }
        public Secao Secao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public List<VotoPrefeito> VotosPrefeito { get; set; }
        public List<VotoVereador> VotosVereador { get; set; }

        public Urna(int serial, string CodZona, string CodSecao)
        {
            this.serial = serial;
            Zona = Zona.lstZonas.Where(m => m.CodZona == CodZona).FirstOrDefault();
            Secao = Secao.lstSecoes.Where(m => m.CodSecao == CodSecao).FirstOrDefault();
        }

        public void EfetuarVotacao(string Titulo, string CodPrefeito = "9999", string CodVereador = "9999")
        {
            VotoPrefeito votoPrefeito = new VotoPrefeito(this, Titulo, CodPrefeito);
            VotoVereador votoVereador = new VotoVereador(this, Titulo, CodPrefeito);
            VotosPrefeito.Add(votoPrefeito);
            VotosVereador.Add(votoVereador);
        }

        public string ResultadoEleicao()
        {

            foreach(Urna urna in lstUrnas)
            {

            }

            return "";
        }

    }
}
