using Microsoft.AspNetCore.Identity;

namespace TPPweb2122.Models
{
    public class Utilizador : IdentityUser<int>
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Telefone { get; set; }
    }
}
