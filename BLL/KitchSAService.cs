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
                result.Add("Natural gas stoves emit Nitrogen Dioxide, Carbon Monoxide and Formaldehyde, each being the cause for respiratory illnesses. Using a range hood efficiently helps keep the emission percentages at low levels (Nicole, 2014).");
            }
            else
            {
                result.Add("Natural gas stoves emit Nitrogen Dioxide, Carbon Monoxide and Formaldehyde, each being the cause for respiratory illnesses. Using a range hood efficiently helps keep the emission percentages at low levels. Since you don’t have a range hood, using the kitchen exhaust and opening windows acts as a substitute (Nicole, 2014).");
            }
            if (Heat.Equals("Electricity"))
            {
                result.Add("Electric stoves usually emit the least amount of Nitrogen Dioxide and Carbon Monoxide gradually but initial usage has shown that electric stoves can emit high amounts of Nitrogen Dioxide and Carbon Monoxide especially the first time it is turned on.");
            }
            else if (Heat.Equals("NaturalGas"))
            {
                result.Add("Natural gas burners when used can add 25-33% of Nitrogen Dioxide concentrations on an average per week during the summer and 35-39% on an average per week during the winter. When using Natural Gas, always remember to ventilate your kitchen (Nicole, 2014).");
            }
            else
            {
                result.Add("Natural gas burners when used can add 25-33% of Nitrogen Dioxide concentrations on an average per week during the summer and 35-39% on an average per week during the winter. When using Natural Gas, always remember to ventilate your kitchen (Nicole, 2014).");
            }
            if (Aerosol.Equals("Yes"))
            {
                result.Add("Aerosol sprays have been found to emit TVOCs that are harmful and tend to cause respiratory illnesses and allergies if exposed to regularly (Center Of Excellence In Environmental Toxicology (CEET), Community Outreach and Engagement Core (COEC)).");
            }
            else
            {
                result.Add("");
            }

            return result;
        }
    }
}
