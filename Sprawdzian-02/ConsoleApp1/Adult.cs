﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Adult : Human
    {
        public Child[] Children {  get; set; }

        public string EatSnack() { return "Cake."; }
    }
}
