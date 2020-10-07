using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicine.Models
{
    public class DoctorsModel
    {

        private List<Doctor> doctors = new List<Doctor>();
        public DoctorsModel()
        {
            List<Doctor> docs = new List<Doctor>()
            {
                new Doctor(){FirstName="אברהם",LastName="כהן",LicenseNumber=1,SocialSecurityNumber=1},

                new Doctor(){FirstName="יצחק",LastName="לוי",LicenseNumber=2,SocialSecurityNumber=2}
            };
            doctors = docs;
        }

        public List<Doctor> GetDoctors()
        {

            return doctors;
        }

        public bool DeleteDoctor(int Id)
        {
            Doctor d = (Doctor)(from doc in doctors
                                where doc.Id == Id
                                select doc);
            return doctors.Remove(d);
        }
        public void EditDoctor(int Id, Doctor doc)
        {
            Doctor d = (Doctor)(from doct in doctors
                                where doct.Id == Id
                                select doct);
            doctors.Remove(d);
            doctors.Add(doc);
        }




    }
}