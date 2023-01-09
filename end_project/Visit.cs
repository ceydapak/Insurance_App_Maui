using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace end_project
{
    public class Visit
    {
        public DateTime VisitDate { get; set; }
        public int VisitCost { get; set; }
        public string DoctorName { get; set; }
    }
}
