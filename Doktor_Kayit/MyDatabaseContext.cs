using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doktor_Kayit
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
    }
}
