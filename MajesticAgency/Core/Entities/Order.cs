using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProblemDomainOfProject { get; set; }
        public string Budget { get; set; }
        public DateTime Timeline { get; set; }
        public string ExampleWebsiteURL { get; set; }
        [NotMapped]
        public IFormFile FileUrl { get; set; }
        public string Discover { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
