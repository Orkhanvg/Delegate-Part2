﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Exceptions
{
    public class AlreadyExsistException:Exception
    {
        
        public AlreadyExsistException(string message):base(message)
        {

        }
    }
}
