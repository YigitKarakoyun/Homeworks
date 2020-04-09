using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPagedList.Entity
{
    public class Tools
    {
        static Model1 Meyveler = null;
        public static Model1 GetMeyveler() {
            if (Meyveler == null)
            {
                Meyveler = new Model1();
            }
            return Meyveler;
        }

    }
}
