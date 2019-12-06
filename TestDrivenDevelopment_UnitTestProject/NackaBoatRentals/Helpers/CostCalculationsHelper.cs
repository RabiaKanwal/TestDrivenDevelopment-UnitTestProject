using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NackaBoatRentals.Helpers
{
    public static class CostCalculationsHelper
    {
        public static int TotalHours(int rentminutes)
        {
            int finalHours = 0;

            if(rentminutes%60==0)
            {
              finalHours= (rentminutes/60)  ;
            }

            else
            {
                finalHours = (rentminutes / 60)+1 ;
            }
            return finalHours;

        }
        public static int TotalCost(string boatcategory,int rentminutes)
        {
            int iBasicCharge = 50;
            int iHourlyCharge = 10;
            int iTotalCost=0;
            int iFinalhours = TotalHours(rentminutes);
           
            if (boatcategory.Equals("jolly-boat"))
            {
                iTotalCost = iBasicCharge + (iHourlyCharge * iFinalhours);
            }
            else if (boatcategory.Equals("< 40 feet"))
            {
                iTotalCost = (iBasicCharge * 12 / 10) + (iHourlyCharge * 13 / 10 * iFinalhours);
            }
            else if (boatcategory.Equals(">= 40 feet"))
            {
                iTotalCost = (iBasicCharge * 15 / 10) + (iHourlyCharge * 14 / 10 * iFinalhours);
            }

            return iTotalCost;
        }

    }
}
