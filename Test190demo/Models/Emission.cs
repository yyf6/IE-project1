namespace Test190demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emission")]
    public partial class Emission
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int report_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int facility_id { get; set; }

        public string jurisdiction_facility_id { get; set; }

        public string facility_name { get; set; }

        public string registered_business_name { get; set; }

        public string primary_anzsic_class_code { get; set; }

        public string primary_anzsic_class_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int substance_id { get; set; }

        public string substance_name { get; set; }

        public string air_total_emission_kg { get; set; }

        public string suburb { get; set; }

        public string postcode { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }
    }
}
