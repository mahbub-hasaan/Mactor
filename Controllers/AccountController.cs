using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mactor.Models;
using AutoMapper;
using Mactor.BLL;
using Mactor.DAL.Entites;
namespace Mactor.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;

        public AccountController(IMapper mapper,IAccountRepository accountRepository)
        {
            _mapper = mapper;
            this._accountRepository = accountRepository;
        }
        // GET: api/account
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(string Id)
        {
            var account =await _accountRepository.GetAccountAsync(Id);
            UserDto user = _mapper.Map<UserDto>(account);
            return new JsonResult(user);
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> CreatAccountAsync([FromBody] UserCreatDto user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            if(await _accountRepository.isEmailExist(user.Email))
            {
                throw new Exception("Email already exist");
            }

            if(await _accountRepository.isUserNameExist(user.UserName))
            {
                throw new Exception("User Name already exist");
            }

            User u = _mapper.Map<User>(user);
            var result = await _accountRepository.CreatAccount(u, u.PasswordHash);
            if (!result.Succeeded)
            {
                throw new Exception("Account Creation faild");
                //return StatusCode(500, "Account Creation faild");
            }
            return Ok();
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
