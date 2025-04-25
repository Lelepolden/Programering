using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class TyrannosaurusReview
    {
        public string _name = "Tyrannosaurusen Fredrik";
                public string GetName()
        {
            return _name;
        }
        public int weight = Random.Shared.Next(4500, 8000);
        public string DinoDescription = "Det är en av världens största köttätare med massvis med tänder och utmärkt hörsel.";
    }
}
