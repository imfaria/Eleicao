using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Secao
    {
        public static List<Secao> lstSecoes = new List<Secao>();//Context
        public string CodSecao { get; set; }

        public Secao(string CodSecao)
        {
            this.CodSecao = CodSecao;
            lstSecoes.Add(this);
        }
    }
}
