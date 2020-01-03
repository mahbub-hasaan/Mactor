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
        Task<IdentityResult> CreatAccount(User user,string password);
        Task<User> GetAccountAsync(string Id);
        Task<bool> SaveAsync();
        Task<bool> SendConfirmationEmail(string Id);
        Task<bool> ConfirmEmail();
        Task<bool> isEmailExist(string email);
        Task<bool> isUserNameExist(string userName);
    }
}
