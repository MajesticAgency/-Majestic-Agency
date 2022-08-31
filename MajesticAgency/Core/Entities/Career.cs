using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Career
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentResidence { get; set; }
        public string WorkingField { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public int NumOfExperience { get; set; }
        public string CurrentWork { get; set; }
        public int ExpectedSalary  { get; set; }
        public string Features { get; set; }
        public string BehanceLink { get; set; }
        [NotMapped]
        public IFormFile CV { get; set; }
        public string Note { get; set; }

    }
}
