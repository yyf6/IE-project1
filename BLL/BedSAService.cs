﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BedSAService
    {
        public List<string> BedAss(string OpenWindow,
                                string Mould,
                                string Plants,
                                string Smoke,
                                string Carpet)
        {
            List<string> result = new List<string>();
            if (OpenWindow.Equals("No"))
            {
                result.Add("Whenever the weather permits, windows should be opened to balance the indoor air quality.");
                result.Add("Ventilation helps reduce the levels of common indoor pollutants which cause allergies like sneezing, irritation, headache and dizziness.");
            }
            else
            {
                result.Add("");
            }
            if (Mould.Equals("Yes"))
            {
                result.Add("For routine clean-up of mouldy surfaces, use mild detergent or vinegar diluted in water solution (4 parts vinegar to 1-part water) (Mould - Fact sheets, 2019).");
                result.Add("Ensure the surface is dried completely once cleaned.");
                result.Add("People with asthma, allergies, or other breathing conditions may be more sensitive to mould.");
            }
            else
            {
                result.Add("");
            }
            if (Plants.Equals("Yes"))
            {
                result.Add("In - door plants are pretty, but they can also collect and foster the growth of mould and have other pollutants which cause common allergy problems.");
            }
            else
            {
                result.Add("");
            }
            if (Smoke.Equals("Yes"))
            {
                result.Add("The person who is smoking already has a bigger problem but Second-hand tobacco smoke causes lung cancer.");
                result.Add("as well as a range of other respiratory symptoms and illnesses among non-smoking adults and children.");
            }
            else
            {
                result.Add("");
            }
            if (Carpet.Equals("Yes"))
            {
                result.Add("Two factors are associated with Carpet/Rug:");
                result.Add("Carpets/Rug may act as a repository for indoor air pollutants such as dirt, dust particles, allergens and other biological contamination that can build up in the carpets.");
                result.Add("New carpets/rug may emit volatile organic compounds (VOCs) that can cause smell and irritation of mucous membranes, especially in sensitive individuals.");
                result.Add("Regular cleaning is recommended as a bad carpet can have adverse effects on health leading to asthma and breathing problems in all age group.	");
            }
            else
            {
                result.Add("");
            }
            return result;

        }

        //public List<string> BedRef(string Mould,
        //            string Plants,
        //            string Smoke,
        //            string Carpet)
        //{
        //    List<string> result = new List<string>();

        //    result.Add("References List Here: ");
        //    result.Add("Improving Indoor Air Quality | US EPA. (2019). Retrieved from ");
        //    result.Add("https://www.epa.gov/indoor-air-quality-iaq/improving-indoor-air-quality");
        //    if (Mould.Equals("Yes"))
        //    {
        //        result.Add("Mould - Fact sheets. (2019). Retrieved from ");
        //        result.Add("https://www.health.nsw.gov.au/environment/factsheets/Pages/mould.aspx");
        //    }
        //    else
        //    {
        //        result.Add("");
        //    }
        //    if (Smoke.Equals("Yes"))
        //    {
        //        result.Add("Smoking compared with or in combination with other pollutants - Tobacco In Australia. (2019). Retrieved from");
        //        result.Add("https://www.tobaccoinaustralia.org.au/chapter-3-health-effects/3-25-air-pollution-cigarette-smoking-and-ill-healt");
        //    }
        //    else
        //    {
        //        result.Add("");
        //    }
        //    if (Carpet.Equals("Yes"))
        //    {
        //        result.Add("Do Carpets Impair Indoor Air Quality and Cause Adverse Health Outcomes: A Review. (2019). ");
        //        result.Add("Retrieved from https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5858259/");
        //    }
        //    else
        //    {
        //        result.Add("");
        //    }
        //    return result;
        //}
    }
}