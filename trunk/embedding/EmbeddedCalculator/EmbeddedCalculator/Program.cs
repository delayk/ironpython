﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EmbeddedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Application.Run(calc);
        }
    }
}
