using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace EF.Usage
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public decimal? Salery { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
