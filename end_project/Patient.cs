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
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int PatientId { get; set; }
        public string PatientName { get; set;}
        public string PatientAddress { get; set; }
        public DateTime PatientBirth { get; set; }
        public string PatientPhone { get; set; }
        public string InsuranceCompanyName { get; set; }
      
    }
}
