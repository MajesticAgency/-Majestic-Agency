using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProblemDomainOfProject { get; set; }
        public int Budget { get; set; }
        public DateTime Timeline { get; set; }
        public string ExampleWebsiteURL { get; set; }
        public string FileUrl { get; set; }
        public string Discover { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
