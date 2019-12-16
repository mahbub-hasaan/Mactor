using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mactor.BLL
{
    public interface IUserRepository
    {
        Task<IdentityUser> GetUserAsync(string email);
        Task<bool> BlockUserAsync(Guid id);
    }
}
