using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Repository
    {
        MyEFContext con = new MyEFContext();
        public void Add(Doctor doctor)
        {
            con.Doctors.Add(doctor);
            con.SaveChanges();
        }
        public List<Doctor> Show()
        {
            var list = con.Doctors.ToList();
            return list;
        }
        
    }
}
