using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Emission
    {
        public virtual Guid report_GUID { get; set; }
        public virtual string report_id { get; set; }
        public virtual string facility_id { get; set; }
        public virtual string jurisdiction_facility_id { get; set; }
        public virtual string facility_name { get; set; }
        public virtual string registered_business_name { get; set; }
        public virtual string primary_anzsic_class_code { get; set; }
        public virtual string primary_anzsic_class_name { get; set; }
        public virtual string substance_id { get; set; }
        public virtual string substance_name { get; set; }
        public virtual string air_total_emission_kg { get; set; }
        public virtual string suburb { get; set; }
        public virtual string postcode { get; set; }
        public virtual string latitude { get; set; }
        public virtual string longitude { get; set; }
    }
}
