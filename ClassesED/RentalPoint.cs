﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class RentalPoint
{
    public string Name { get; set; }
    public string Address { get; set; }
    public RentalPoint(string name, string address)
    {
        Name = name;
        Address = address;
    }
}
