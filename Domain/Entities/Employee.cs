using Domain.Common.CustomValidations;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Domain.Entities
{
    public class Employee :BaseClass
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int Gender { get; set; }

    }
}
