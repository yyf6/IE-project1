using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModel;
using IBLL;
using DAL;
namespace BLL
{
    public class EmissionService : BaseService<Emission>, IEmissionService
    {
        public EmissionService() : base(new EmissionStore())
        {

        }

        public Emission Add(string report_id, string facility_id)
        {
            Emission emission = new Emission();
            emission.report_id = report_id;
            emission.facility_id = facility_id;
            baseStore.Create(emission);
            return emission;
        }
    }
}
