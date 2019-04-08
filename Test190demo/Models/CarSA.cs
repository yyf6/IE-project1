using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test190demo.Models
{
    public class CarSA
    {
        public CarCondition CarStatus { get; set; }

        public Upholstery UpholsteryChanging { get; set; }

        public Vent Vents { get; set; }

        public Stuck StuckCondition { get; set; }

        public Park ParkPlace { get; set; }

        public enum CarCondition
        {
            New, TwoFiveYearsOld, SixTenYearsOld, OverTenYears
        }

        public enum Upholstery
        {
            Yes, No
        }

        public enum Vent
        {
            Yes, No
        }

        public enum Stuck
        {
            Yes, No, NotOften
        }

        public enum Park
        {
            OnlyRoadParking, GarageOrShade
        }
    }
}