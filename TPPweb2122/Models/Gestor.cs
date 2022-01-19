using System.Collections.Generic;

namespace TPPweb2122.Models
{
    public class Gestor : Utilizador
    {
        public Gestor()
        {
            Funcionarios = new HashSet<Funcionario>();
        }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
