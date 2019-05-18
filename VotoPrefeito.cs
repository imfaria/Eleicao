using System;
using System.Linq;

namespace TrabalhoPOO
{
    public class VotoPrefeito
    {
        public Urna Urna { get; set; }
        public Eleitor Eleitor { get; set; }
        public Prefeito Prefeito { get; set; }

        public VotoPrefeito(Urna Urna, string Titulo, string CodPrefeito)
        {
            this.Urna = Urna;
            this.Eleitor = Eleitor;
            this.Prefeito = Prefeito.lstPrefeitos.Where(m => m.CodCandidato == CodPrefeito).FirstOrDefault();//9999 para brancos
        }

        public int farofa(string ingrediente)
        {
            int n;

            try
            {
                //exception
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return n;
        }
    }
}