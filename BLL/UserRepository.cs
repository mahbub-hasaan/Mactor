using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mactor.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mactor.BLL
{
    public class UserRepository : IUserRepository,IDisposable
    {
        private readonly MactorContext contex;

        public UserRepository(MactorContext _contex)
        {
            contex = _contex;
        }

        public Task<bool> BlockUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityUser> GetUserAsync(string email)
        {
            if (email.Equals(null))
            {
                throw new ArgumentException(nameof(email));
            }
            return await contex.Users.FirstOrDefaultAsync(u => u.Email==email);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
