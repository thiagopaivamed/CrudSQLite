using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDSQLite.Models
{
    public class Context : DbContext
    {
        public DbSet<Airplane> Airplanes { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
