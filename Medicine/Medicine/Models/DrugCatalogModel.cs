using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicine.Models
{
    public class DrugCatalogModel
    {

        public List<Drug> GetDrugs()
        {
            List<Drug> drugs = new List<Drug>
            {
                new Drug
                {
                    Id = 1,
                    Name = "אקמול",
                    Ingredient = new List<Ingredient> { new Ingredient { Id = 2, Name = "Paracetamol" },new Ingredient { Id = 7, Name = "paracetamol" } },
                    ImagePath="/images/acamol.jpg"

                },
                new Drug
                {
                    Id = 3,
                    Name = "נורופן",
                    Ingredient = new List<Ingredient> { new Ingredient { Id = 4, Name = "Ibuprofen" } },
                    ImagePath="/images/nurofen.jpeg"

                },
                new Drug
                {
                    Id = 5,
                    Name = "מוקסיפן",
                    Ingredient = new List<Ingredient> { new Ingredient { Id = 6, Name = "Amoxicillin" } },
                    ImagePath="/images/moxy_hh.jpg"

                }
            };
            return drugs;
        

    }

}
}