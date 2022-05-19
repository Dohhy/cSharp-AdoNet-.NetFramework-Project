using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_Kayit
{
    public class PolyclinicDal
    {
        public List<Polyclinic> GetAll()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                return context.Polyclinics.ToList();
            }
        }

        public void Add(Polyclinic polyclinic)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var entity = context.Entry(polyclinic);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        
        public void Update(Polyclinic polyclinic)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var entity = context.Entry(polyclinic);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Polyclinic polyclinic)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var entity = context.Entry(polyclinic);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
