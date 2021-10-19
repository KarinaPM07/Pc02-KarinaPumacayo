using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Semana7PC02.Models
{

public class AdopcionContext : DbContext
{
    public DbSet<Mascota> Mascota{set; get;}
    public AdopcionContext(DbContextOptions dco) : base(dco)
    {

    }
}

}