using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KitchSAService
    {
        public List<string> KitAss(string RangeHood,
                                string Heat,
                                string Aerosol)
        {
            List<string> result = new List<string>();
            if (RangeHood.Equals("Yes"))
            {
                result.Add("Natural gas stoves emit Nitrgen Dioxide, Carbon Monoxide and Formaldehyde, each being the cause for respiratory illnesses. Using a range hood efficiently helps keep the emission percentages at low levels.");
            }
            else
            {
                result.Add("Natural gas stoves emit Nitrgen Dioxide, Carbon Monoxide and Formaldehyde, each being the cause for respiratory illnesses. Using a range hood efficiently helps keep the emission percentages at low levels. Since you dont have a range hood, using the kitchen exhaust and opening windows acts as a substitute.");
            }
            if (Heat.Equals("Electricity"))
            {
                result.Add("Electric stoves usually emit the least amount of Nitrogen Dioxide and Carbon Monoxide gradually but initial usage has shown that electric stoves can emit high amounts of Nitrogen Dioxide and Carbon Monoxide especially the first time it is turned on.");
            }
            else if (Heat.Equals("NaturalGas"))
            {
                result.Add("Natural gas burners when used can add 25-33% of Nitrogen Dioxide concentrations on an average per week during the summer and 35-39% on an average per week during the winter. When using Natural Gas, always remember to ventilate your kitchen.");
            }
            else
            {
                result.Add("LPG tends to settle in your household air at nose levels since it is much denser than Natural Gas which tends to settle near the ceiling. Emissions from LPG's can also cause respiratory illnesses if not dealt with through ventilation regularly.");
            }
            if (Aerosol.Equals("Yes"))
            {
                result.Add("Aerosol sprays have been found to emit TVOCs that are harmful and tend to cause respiratory illnesses and allergies if exposed to regularly.");
            }
            else
            {
                result.Add("");
            }

            return result;
        }
    }
}
