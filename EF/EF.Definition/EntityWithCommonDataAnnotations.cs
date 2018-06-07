using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAndDapper
{
    public class EntityWithCommonDataAnnotations
    {
        [Key]
        public string Key { get; set; }

        [Required, MaxLength(128)]
        public string S1 { get; set; }

        public decimal ? D1 { get; set; }
    }
}
