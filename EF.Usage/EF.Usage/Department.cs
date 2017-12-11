﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Usage
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? Budget { get; set; }

        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
