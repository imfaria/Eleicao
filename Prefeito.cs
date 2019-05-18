using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoPOO.Exceptions;

namespace TrabalhoPOO
{
    public class Prefeito :Candidato
    {
        public static List<Prefeito> lstPrefeitos = new List<Prefeito>();//Context
        public VicePrefeito VicePrefeito { get; set; }


        public Prefeito(string CodCandidato, string Nome, string Email, DateTime DataNascimento, string CodPartido) : base(CodCandidato, Nome, Email, DataNascimento, CodPartido)
        {
            if (CodCandidato.Length > 2)
            {
                throw new Exception("O código do prefeito deve conter somente 2 dígitos");
            }
            else
            {
                this.CodCandidato = CodCandidato;
                this.Nome = Nome;
                this.Email = Email;
                this.DataNascimento = DataNascimento;
                this.Partido = Partido.lstPartidos.Where(m => m.CodPartido == CodPartido).FirstOrDefault();
                lstPrefeitos.Add(this);
            }
        }



    }
}
