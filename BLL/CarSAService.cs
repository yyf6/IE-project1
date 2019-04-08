using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class CarSAService
    {
        public List<string> CarAss(string CarStatus, string Upholstery, string Vents, string StuckCondition, string ParkPlace)
        {
            bool condition = true;
            int mark = 5;
            ////var resultBuilder = new StringBuilder();
            List<string> result = new List<string>();
            if (CarStatus.Equals("New"))
            {
                result.Add("Due to new car materials, the concentration of TVOCs levels are high inside your car (Barnes, Ng, Ma, & Lai, 2018)..");
                if (Vents.Equals("Yes"))
                {
                    result.Add("Always remember to change AC internal circulation when in a tunnel or stuck in traffic (Barnes, Ng, Ma, & Lai, 2018)..");
                }
                else
                {
                    result.Add("Opening your AC vent helps your car to breathe in fresh air and get rid of TVOCs from new material in your car. Just remember to close it back when going past outdoor pollution or if in traffic (Barnes, Ng, Ma, & Lai, 2018).");
                }
                if (StuckCondition.Equals("Yes"))
                {
                    result.Add("Concentration of TVOCs are significantly higher when vehicles are static for long periods of time. So if you have to be static, an air purifier helps remove 90% of particulate matter and other harmful gases (Barnes, Ng, Ma, & Lai, 2018).");
                }
                if (StuckCondition.Equals("NotOften"))
                {
                    result.Add("Make sure to maintain your air filtration system as a car older than 10 years can possibly suffer from filter leakage which causes harmful gases to enter the inside of your car. Make sure to open your vents when not in traffic or tunnels (Barnes, Ng, Ma, & Lai, 2018).");
                }
                if (ParkPlace.Equals("OnlyRoadParking"))
                {
                    result.Add("Since you park only outdoors, TVOC concentrations are 40% higher in your car, with formaldehyde concentrations in your car being approximately twice the amount in the Summer as compared to Winter (Müller, Klingelhöfer, Uibel, & Groneberg, 2011).");
                }
                else
                {
                    result.Add("Since you park outdoors and indoors, the TVOC and formaldehyde concentrations are significantly higher than when you park indoors (Müller, Klingelhöfer, Uibel, & Groneberg, 2011). Always remember to open your windows and air your vehicle out when you start your journey.");
                }
            }
            if (CarStatus.Equals("TwoFiveYearsOld"))
            {
                result.Add("As compared to TVOC levels in new cars, your car will have a lower level of TVOC concentrations (Barnes, Ng, Ma, & Lai, 2018).");
                if (Upholstery.Equals("Yes"))
                {
                    result.Add("New fittings in your car emit high levels of TVOCs. Opening your AC vent helps your car to breathe in fresh air and get rid of TVOCs from new material in your car (Barnes, Ng, Ma, & Lai, 2018). Just remember to close it back when going past outdoor pollution or if in traffic.");
                }
                if (Upholstery.Equals("No"))
                {
                    result.Add("Since your upholstery is quite mature, TVOCs have had time to escape from them (Barnes, Ng, Ma, & Lai, 2018).");
                }
                if (Vents.Equals("Yes"))
                {
                    result.Add("Always remember to change AC internal circulation when in a tunnel or stuck in traffic(Barnes, Ng, Ma, & Lai, 2018).");
                }
                else
                {
                    result.Add("Since you do not turn on your AC vents, TVOCs, mold spores and bacteria along with dust accumulate and are harmful to breathe in (Barnes, Ng, Ma, & Lai, 2018). The ideal frequency of cleaning your car is once in three weeks.");
                }
                if (StuckCondition.Equals("Yes"))
                {
                    result.Add("Concentration of TVOCs are significantly higher when vehicles are static for long periods of time. So if you have to be static, an air purifier helps remove 90% of particulate matter and other harmful gases(Barnes, Ng, Ma, & Lai, 2018).");
                }
                if (StuckCondition.Equals("NotOften"))
                {
                    result.Add("Make sure to maintain your air filtration system as a car older than 10 years can possibly suffer from filter leakage which causes harmful gases to enter the inside of your car. Make sure to open your vents when not in traffic or tunnels");
                }
                if (ParkPlace.Equals("OnlyRoadParking"))
                {
                    result.Add("Since you park only outdoors, TVOC concentrations are 40% higher in your car, with formaldehyde concentrations in your car being approximately twice the amount in the Summer as compared to Winter.");
                }
                else
                {
                    result.Add("Since you park outdoors and indoors, the TVOC and formaldehyde concentrations are significantly higher than when you park indoors. Always remember to open your windows and air your vehicle out when you start your journey.");
                }
            }
            if (CarStatus.Equals("SixTenYearsOld"))
            {
                result.Add("As compared to TVOC levels in new cars, your car will have a lower level of TVOC concentrations.");
                if (Upholstery.Equals("Yes"))
                {
                    result.Add("New fittings in your car emit high levels of TVOCs. Opening your AC vent helps your car to breathe in fresh air and get rid of TVOCs from new material in your car. Just remember to close it back when going past outdoor pollution or if in traffic.");
                }
                if (Upholstery.Equals("No"))
                {
                    result.Add("Since your upholstery is quite mature, TVOCs have had time to escape from them.");
                }
                if (Vents.Equals("Yes"))
                {
                    result.Add("Always remember to change AC internal circulation when in a tunnel or stuck in traffic.");
                }
                else
                {
                    result.Add("Since you do not turn on your AC vents, TVOCs, mold spores and bacteria along with dust accumulate and are harmful to breathe in. The ideal frequency of cleaning your car is once in three weeks.");
                }
                if (StuckCondition.Equals("Yes"))
                {
                    result.Add("Concentration of TVOCs are significantly higher when vehicles are static for long periods of time. So if you have to be static, an air purifier helps remove 90% of particulate matter and other harmful gases.");
                }
                if (StuckCondition.Equals("NotOften"))
                {
                    result.Add("Make sure to maintain your air filtration system as a car older than 10 years can possibly suffer from filter leakage which causes harmful gases to enter the inside of your car. Make sure to open your vents when not in traffic or tunnels");
                }
                if (ParkPlace.Equals("OnlyRoadParking"))
                {
                    result.Add("Since you park only outdoors, TVOC concentrations are 40% higher in your car, with formaldehyde concentrations in your car being approximately twice the amount in the Summer as compared to Winter.");
                }
                else
                {
                    result.Add("Since you park outdoors and indoors, the TVOC and formaldehyde concentrations are significantly higher than when you park indoors. Always remember to open your windows and air your vehicle out when you start your journey.");
                }
            }
            if (CarStatus.Equals("OverTenYears"))
            {
                result.Add("TVOCs tend to accumulate in older cars with harmful gas concentrations often increasing and decreasing in an unstable manner.");
                if (Upholstery.Equals("Yes"))
                {
                    result.Add("New fittings in your car emit high levels of TVOCs. Opening your AC vent helps your car to breathe in fresh air and get rid of TVOCs from new material in your car. Just remember to close it back when going past outdoor pollution or if in traffic.");
                }
                if (Upholstery.Equals("No"))
                {
                    result.Add("Since your upholstery is quite mature, TVOCs have had time to escape from them.");
                }
                if (Vents.Equals("Yes"))
                {
                    result.Add("Always remember to change AC internal circulation when in a tunnel or stuck in traffic.");
                }
                else
                {
                    result.Add("Since you do not turn on your AC vents, TVOCs, mold spores and bacteria along with dust accumulate and are harmful to breathe in. The ideal frequency of cleaning your car is once in three weeks.");
                }
                if (StuckCondition.Equals("Yes"))
                {
                    result.Add("Concentration of TVOCs are significantly higher when vehicles are static for long periods of time. So if you have to be static, an air purifier helps remove 90% of particulate matter and other harmful gases.");
                }
                if (StuckCondition.Equals("NotOften"))
                {
                    result.Add("Make sure to maintain your air filtration system as a car older than 10 years can possibly suffer from filter leakage which causes harmful gases to enter the inside of your car. Make sure to open your vents when not in traffic or tunnels");
                }
                if (ParkPlace.Equals("OnlyRoadParking"))
                {
                    result.Add("Since you park only outdoors, TVOC concentrations are 40% higher in your car, with formaldehyde concentrations in your car being approximately twice the amount in the Summer as compared to Winter.");
                }
                else
                {
                    result.Add("Since you park outdoors and indoors, the TVOC and formaldehyde concentrations are significantly higher than when you park indoors. Always remember to open your windows and air your vehicle out when you start your journey.");
                }
            }
            return result;
        }
    }
}
