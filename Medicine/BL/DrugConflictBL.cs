using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class DrugConflictBL
    {
        public List<string> DrugConflictcheckBL(string idpatient, string nx2,ref bool ans)
        {
           // bool re = true;
            DrugConflict dal = new DrugConflict();

            //בדאל עם התרופה להוספה  DrugConflictcheck לעבור על כלאחד ולשלוח לפונקצית   idpatient לבקש מהדאל את רשימת תרופותיו של 
            List<string> re= dal.DrugConflictcheck(idpatient, nx2);
            foreach(var item in re)
            {
                if (item.Contains("high"))
                {
                    ans = true;
                }
            }

            return re;
        }
    }
}
