//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Remoting.Messaging;

//namespace DAL
//{
//    public class IAFactoryContext
//    {
//        public static IAContext CurrentDbContext()
//        {
//            IAContext db = CallContext.GetData(nameof(IAContext)) as IAContext;
//            if (db == null)
//            {
//                db = new IAContext();
//                CallContext.SetData(nameof(IAContext), db);
//            }
//            return db;
//        }
//    }
//}
//}



