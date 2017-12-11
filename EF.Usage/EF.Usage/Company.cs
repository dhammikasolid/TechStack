﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Usage
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Department> Departments { get; set; }
    }
}
