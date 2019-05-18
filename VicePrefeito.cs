namespace TrabalhoPOO
{
    public class VicePrefeito:Candidato
    {

        public VicePrefeito(string Nome, string Email, System.DateTime DataNascimento, string CodPartido, string CodCandidato) : base(CodCandidato, Nome, Email, DataNascimento, CodPartido)
        {
            this.CodCandidato = CodCandidato;
            this.Nome = Nome;
            this.Email = Email;
            this.DataNascimento = DataNascimento;
            this.Partido = Partido;
        }
    }
}