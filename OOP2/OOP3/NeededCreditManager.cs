﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class NeededCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("NEEDED CREDIT CALCULATED");
        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
