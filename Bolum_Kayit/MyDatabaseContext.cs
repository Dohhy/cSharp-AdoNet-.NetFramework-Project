using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_Kayit
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Polyclinic> Polyclinics { get; set; }
    }
}
