using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mactor.DAL
{
    public class MactorContext:IdentityDbContext
    {
        public MactorContext(DbContextOptions<MactorContext> options) : base(options)
        {

        }

       
    }
}
