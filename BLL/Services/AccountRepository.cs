using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Mactor.DAL.Entites;
using Mactor.DAL;

namespace Mactor.BLL
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MactorContext _context;
        private readonly UserManager<User> userManager;

        public AccountRepository(MactorContext context,UserManager<User> userManager)
        {
            this._context = context;
            this.userManager = userManager;
        }

        public async Task<bool> isEmailExist(string email)
        {
            return await userManager.FindByEmailAsync(email) == null ? false : true;
        }

        public async Task<bool> isUserNameExist(string userName)
        {
            return await userManager.FindByNameAsync(userName) == null ? false : true;
        }

        public async Task<IdentityResult> CreatAccount(User user,string password)
        {
           return await userManager.CreateAsync(user,password);        
        }

        public async Task<User> GetAccountAsync(string Id)
        {
            return await userManager.FindByIdAsync(Id);
        }

        public async Task<bool> SaveAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count > 0 ? true : false;
        }

        async Task<bool> IAccountRepository.ConfirmEmail()
        {
            throw new NotImplementedException();
        }

        async Task<bool> IAccountRepository.SendConfirmationEmail(string id)
        {
            throw new NotImplementedException();
        }
    }
}
