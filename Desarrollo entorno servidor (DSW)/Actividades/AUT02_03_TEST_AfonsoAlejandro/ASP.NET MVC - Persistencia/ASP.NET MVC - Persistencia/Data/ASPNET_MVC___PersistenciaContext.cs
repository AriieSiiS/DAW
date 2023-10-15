using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_MVC___Persistencia.Models;

namespace ASP.NET_MVC___Persistencia.Data
{
    public class ASPNET_MVC___PersistenciaContext : DbContext
    {
        public ASPNET_MVC___PersistenciaContext (DbContextOptions<ASPNET_MVC___PersistenciaContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_MVC___Persistencia.Models.Character> Character { get; set; } = default!;
    }
}
