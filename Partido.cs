using System.Collections.Generic;

namespace TrabalhoPOO
{
    public class Partido
    {
        public static List<Partido> lstPartidos = new List<Partido>();//Context
        public string CodPartido { get; set; }
        public int numero { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }

        public Partido()
        { }
        public Partido(string CodPartido)
        {
            this.CodPartido = CodPartido;
            lstPartidos.Add(this);
        }

        public void ExcluirPartido(string codpartido)
        {
            bool existe = false;
            foreach (Candidato candidato in Candidato.lstCandidatos)
            {
                if (candidato.Partido.CodPartido == codpartido)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                foreach (Partido partido in Partido.lstPartidos)
                {
                    if (partido.CodPartido == codpartido)
                    {
                        Partido.lstPartidos.Remove(partido);
                    }
                }
            }
        }

        public Partido PesquisaPartido(int numero)
        {
            Partido retorno = new Partido();
            foreach (Partido item in Partido.lstPartidos)
            {
                if (item.numero == numero)
                {
                    retorno = item;
                }
            }
            return retorno;
        }

        public void AlterarPartido(int numero,string cod, string sigla, string nome)
        {
            Partido partido = new Partido();
            Partido partidoAlter = partido.PesquisaPartido(numero);
            partido = partidoAlter;
            partidoAlter.CodPartido = cod;
            partidoAlter.sigla = sigla;
            partidoAlter.nome = nome;

            Partido.lstPartidos.Remove(partido);
            Partido.lstPartidos.Add(partidoAlter);
        }
    }
}