﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patient:Person
    {
      public List<Prescription> prescriptions { get; set; }
      
    }
}
