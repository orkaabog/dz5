using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    public class Espresso : Coffee
    {

        public double GetCost()
        {
            return 1.33;
        }

        public String GetDescription()
        {
            return "Espresso";
        }
    }
}
