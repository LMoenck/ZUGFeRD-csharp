﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZUGFeRD_Test
{
    public class Assert
    {
        public static bool AreEqual(object o1, object o2)
        {
            if (!o1.Equals(o2))
            {
                throw new Exception();
            }
            return true;
        }


        public static bool AreEqual(decimal d1, decimal d2)
        {
            if (d1 != d2)
            {
                throw new Exception();
            }
            return true;
        }
    }
}
