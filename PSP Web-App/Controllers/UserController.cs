using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PSP_Web_App.BusnLogic;
using PSP_Web_App.DalMSSQL;
using System.Text.Json;

namespace PSP_Web_App.Controllers
{
    [ApiController]
    [EnableCors]
    public class UsersController : ControllerBase
    {

        private UserContainer us;
        private readonly IConfiguration configuration;

        public UsersController(IConfiguration ic)
        {
            configuration = ic;
            us = new(new UserMSSQL(configuration["db:ConnectionString"]));
        }

        [HttpGet]
        [Route("api/GetUserUnsafe")]
        public string getUserUnsafe(string id)
        {
            User user = us.GetUserNotSafe(id);
            var json = JsonSerializer.Serialize(user);
            return json;

        }

        [HttpGet]
        [Route("api/GetUserSafe")]
        public string getUserSafe(int id)
        {
            User user = us.GetUserSafe(id);
            var json = JsonSerializer.Serialize(user);
            return json;
        }
    }
    }
