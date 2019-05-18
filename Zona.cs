using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Zona
    {
        public static List<Zona> lstZonas = new List<Zona>();//Context
        public string CodZona { get; set; }
        List<Secao> lstSecoes { get; set; }

        public Zona(string CodZona)
        {
            this.CodZona = CodZona;
            this.lstSecoes = new List<Secao>();
            lstZonas.Add(this);
        }
    }
}
