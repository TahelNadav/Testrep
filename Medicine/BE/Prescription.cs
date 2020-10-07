using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Prescription
    {
        public Drug drug { get; set; }
        public Doctor doctor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Patient customer{ get; set; }

    }
}
