using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mactor.DAL.Entites;
namespace Mactor.BLL
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> CreatAccount(User user,string password);
        public Task<bool> SaveAsync();
    }
}
