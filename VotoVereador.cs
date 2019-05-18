using System.Linq;

namespace TrabalhoPOO
{
    public class VotoVereador
    {
        public Urna Urna { get; set; }
        public Eleitor Eleitor { get; set; }
        public Vereador Vereador { get; set; }

        public VotoVereador(Urna Urna, string Titulo, string CodVereador)
        {
            this.Urna = Urna;
            this.Eleitor = Eleitor;
            this.Vereador = Vereador.lstVereadores.Where(m => m.CodCandidato == CodVereador).FirstOrDefault();//9999 para brancos
        }

    }
}