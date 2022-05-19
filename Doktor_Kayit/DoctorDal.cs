using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doktor_Kayit
{
    public class DoctorDal
    {
        public List<Doctor> GetAll()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                return context.Doctors.ToList();
            }
        }

        public void Add(Doctor doctor)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var entity = context.Entry(doctor);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Doctor doctor)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var entity = context.Entry(doctor);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Doctor doctor)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var entity = context.Entry(doctor);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
