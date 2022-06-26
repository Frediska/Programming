using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEstablishments.Model
{
    public static class EstablishmentFactory
    {
        public static Establishment DefaultInfo()
        {
            Establishment establishment = new Establishment();
            establishment.Title = "Название";
            establishment.Address = "Адрес";
            establishment.Rating = 0;
            return establishment;
        }

        public static List<Establishment> SortEstablishments(List<Establishment> establishments)
        {
            var sortedEstablishmentList = from value in establishments
                                          orderby value.Category, value.Title
                                          select value;

            return sortedEstablishmentList.ToList();
        }
    }
}
