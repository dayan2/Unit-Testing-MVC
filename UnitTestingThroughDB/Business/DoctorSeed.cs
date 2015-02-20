using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Business
{
    public class DoctorSeed : DropCreateDatabaseIfModelChanges<MyEFContext>
    {
        protected override void Seed(MyEFContext context)
        {
            Doctor doctor = new Doctor { ID = 1, Name = "Dayan" };
            context.Doctors.Add(doctor);
            context.SaveChanges();
 	        base.Seed(context);
        }
    }
}
