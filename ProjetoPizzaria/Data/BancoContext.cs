using Microsoft.EntityFrameworkCore;
using ProjetoPizzaria.Models;
using System.Collections.Generic;

namespace ProjetoPizzaria.Data
{
        public class BancoContext : DbContext
        {
            public BancoContext(DbContextOptions<BancoContext> options) : base(options)
            {
            }
            public DbSet<EstoqueModel> Produtos { get; set; }

        }
}
