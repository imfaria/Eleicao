using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public abstract class Candidato
    {
        public static List<Candidato> lstCandidatos = new List<Candidato>();
        public string CodCandidato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Partido Partido { get; set; }


        public Candidato(string CodCandidato, string Nome, string Email, DateTime DataNascimento, string CodPartido)
        {
            this.CodCandidato = CodCandidato;
            this.Nome = Nome;
            this.Email = Email;
            this.DataNascimento = DataNascimento;
            this.Partido = Partido.lstPartidos.Where(m => m.CodPartido == CodPartido).FirstOrDefault();
            lstCandidatos.Add(this);
        }

        public void ExcluirCandidato(string codcandidato)
        {
            foreach (Candidato candidato in Candidato.lstCandidatos)
            {
                if (candidato.CodCandidato == codcandidato)
                {
                    Candidato.lstCandidatos.Remove(candidato);
                }
            }
        }

        public Candidato PesquisaCandidato(string nome)
        {
            foreach (Candidato item in Candidato.lstCandidatos)
            {
                if (item.Nome == nome)
                {
                    return item;
                }
            }
            return null;
        }

        public void AlterarCandidato(string CodCandidato, string Nome, string Email, DateTime DataNascimento, int numeroPartido)
        {
            Candidato candidato = PesquisaCandidato(Nome);
            Candidato.lstCandidatos.Remove(candidato);

            candidato.Nome = Nome;
            candidato.Email = Email;
            candidato.DataNascimento = DataNascimento;
            candidato.Partido = Partido.PesquisaPartido(numeroPartido);

            Candidato.lstCandidatos.Add(candidato);
        }


    }
}
