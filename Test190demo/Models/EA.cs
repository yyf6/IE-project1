namespace Test190demo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EA : DbContext
    {
        public EA()
            : base("name=EA")
        {
        }

        public virtual DbSet<Emission> Emissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
