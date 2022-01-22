using System.Collections.Generic;

namespace TPPweb2122.Models
{
    public class Cliente : Utilizador
    {
        public Cliente()
        {
            Reservas = new HashSet<Reserva>();
        }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
