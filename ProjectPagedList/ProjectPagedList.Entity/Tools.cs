using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPagedList.Entity
{
    public class Tools
    {
        static DbMeyvelerEntities db = null;
        public static DbMeyvelerEntities GetMeyvelerEntities()
        {
            if (db==null)
            {
                db = new DbMeyvelerEntities();
            }
            return db;
        }
    }
}
