using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mactor.DAL.Entites
{
    public class User: IdentityUser
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ImagePath { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
