using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class AQFactoryContext
    {
        public static AQDbContext CurrentDbContext() {
            var db = CallContext.GetData(nameof(AQDbContext)) as AQDbContext;
            if (db == null) {
                db = new AQDbContext();
                CallContext.SetData(nameof(AQDbContext), db);
            } return db; }
    }
}
