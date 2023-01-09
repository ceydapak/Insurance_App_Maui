using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace end_project
{
   public class Doctor
    {
        [Key]
        public string DName { get; set; }
        public string DEmail { get; set; }
        public string DImg { get; set; }

        
    }
}
