using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace end_project
{
    public class InsuranceCompany
    {
        [PrimaryKey]
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string RepresentiveName { get; set; }
   
    }
}
