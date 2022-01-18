using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TPPweb2122.Models;

namespace TPPweb2122.Data
{
    public class ApplicationDbContext : IdentityDbContext<Utilizador,IdentityRole<int>,int>
    {   
        //public virtual DbSet<Categoria> Categorias {get; set;}
        //public virtual DbSet<Imovel> Imoveis {get; set;}
        //public virtual DbSet<Reserva> Reservas {get; set;}
        //public virtual DbSet<Avaliacao> Avaliacoes {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
