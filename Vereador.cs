using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Vereador : Candidato
    {
        public static List<Vereador> lstVereadores = new List<Vereador>();//Context

        public Vereador(string CodCandidato, string Nome, string Email, DateTime DataNascimento, string CodPartido) : base(CodCandidato, Nome, Email, DataNascimento, CodPartido)
        {
            if (CodCandidato.Length != 4)
            {
                throw new Exception("Codigo de candidato deve ter exatamente 4 digitos");
            }
            else
            {
                this.CodCandidato = CodCandidato;
                this.Nome = Nome;
                this.Email = Email;
                this.DataNascimento = DataNascimento;
                this.Partido = Partido.lstPartidos.Where(m => m.CodPartido == CodPartido).FirstOrDefault();
                lstVereadores.Add(this);
            }
        }
    }
}
