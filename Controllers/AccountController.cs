using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mactor.Models;
using AutoMapper;
using Mactor.BLL;
using Mactor.DAL.Entites;
namespace Mactor.Controllers
{
    [Route("api/[controller]")]
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
        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> CreatAccountAsync([FromBody] UserCreatDto user)
        {
            if (user == null)
            {
                return BadRequest();
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
