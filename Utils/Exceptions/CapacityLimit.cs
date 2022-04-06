using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Exceptions
{
   public class CapacityLimit:Exception
    {
        
        public CapacityLimit(string message):base(message)
        {

        }
    }
}
