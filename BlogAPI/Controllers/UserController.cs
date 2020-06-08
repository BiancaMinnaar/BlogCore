using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.Repository;
using DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        public WebAPIResult<User> Post([FromBody]User value)
        {
            try
            {
                return new WebAPIResult<User>
                {
                    Status = new UserRepository().AddUser(value)
                };
            }
            catch (Exception excp)
            {
                return new WebAPIResult<User>
                {
                    Status = new ServiceFeedback
                    {
                        Message = excp.Message,
                        StackTrace = excp.StackTrace,
                        Status = 500
                    },
                    DataModel = value
                };
            }
        }

        [HttpGet]
        public WebAPIResult<List<User>> Get()
        {
            var userRepo = new UserRepository();
            try
            {
                return new WebAPIResult<List<User>>
                {
                    DataModel = userRepo.GetAllUsers(),
                    Status = new ServiceFeedback
                    {
                        Message = "Success",
                        Status = 200
                    }
                };
            }
            catch(Exception excp)
            {
                return new WebAPIResult<List<User>>
                {
                    Status = new ServiceFeedback
                    {
                        Message = excp.Message,
                        StackTrace = excp.StackTrace,
                        Status = 500
                    }
                };
            }
        }
    }
}
