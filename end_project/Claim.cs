using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeignKeyAttribute = SQLiteNetExtensions.Attributes.ForeignKeyAttribute;

namespace end_project
{
    public class Claim
    {
        [PrimaryKey, AutoIncrement]
        public int ClaimId { get; set;}
        public static DateTime ClaimDate { get; set; }
        public string RepresentiveName { get; set; }
        public static int VisitCost { get; set; }
   

    }
}
