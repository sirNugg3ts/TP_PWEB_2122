using System;

namespace TPPweb2122.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public DateTime dataEntrada { get; set; }   
        public DateTime dataSaida { get; set; } 

        public int ImovelId { get; set; }
        public virtual Imovel Imovel {get; set; }
    }
}
