using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mactor.DAL.Entites;
namespace Mactor.BLL
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string email);
        Task<bool> BlockUserAsync(Guid id);
    }
}
