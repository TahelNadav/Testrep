using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicine.Models
{
    public class PatientModel
    {

        private List<Patient> patients;
        public PatientModel()
        {
            patients = new List<Patient>()
            {
                 new Patient(){FirstName="אברהם",LastName="כהן",SocialSecurityNumber=1},

                new Patient(){FirstName="יצחק",LastName="לוי",SocialSecurityNumber=2}
            };
        }
        public List<Patient> GetPatients()
        {

            return patients;
        }

        public bool DeletePatient(int Id)
        {
            Patient p = (Patient)(from pat in patients
                                  where pat.Id == Id
                                  select pat);
            return patients.Remove(p);
        }
        public void EditPatient(int Id, Patient pat)
        {
            Patient p = (Patient)(from pa in patients
                                  where pa.Id == Id
                                  select pa);
            patients.Remove(p);
            patients.Add(pat);
        }
    
}
}