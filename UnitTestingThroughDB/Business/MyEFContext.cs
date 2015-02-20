using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MyEFContext : DbContext
    {
        public MyEFContext()
            : base("MyEFContext")
        {
            Database.SetInitializer(new DoctorSeed());
        }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
