using Microsoft.AspNetCore.Identity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ABCareApp.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Status = true;
            CreationDate = DateTime.Now;
        }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate  { get; set; }

        public string FullName
        {
            get { return $"{Name} {MiddleName} {Surname} "; }
        }


    }
}
