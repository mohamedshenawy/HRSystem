using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        public int Age { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual Employee Employee { get; set; }
    }
}
