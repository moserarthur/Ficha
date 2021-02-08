using FichaApexEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaApexEntityFramework
{
    public class FichaDBContext : DbContext
    {   
        public FichaDBContext(DbContextOptions<FichaDBContext> options)
            :base (options)
        { }
        public DbSet<Ficha> Fichas { get; set; }

    }
}
