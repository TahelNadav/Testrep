using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Drug
    {
        public int Id { get; set; }
        public List< Ingredient> Ingredient { get; set; }
    }
}
