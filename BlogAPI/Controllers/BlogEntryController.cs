using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.Repository;
using DomainModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    public class BlogEntryController : Controller
    {
        [HttpPost]
        public WebAPIResult<BlogEntry> Post([FromBody]BlogEntry value)
        {
            try
            {
                return new WebAPIResult<BlogEntry>
                {
                    Status = new BlogRepository().AddBlogEntry(value)
                };
            }
            catch (Exception excp)
            {
                return new WebAPIResult<BlogEntry>
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
        public WebAPIResult<List<BlogEntry>> Get()
        {
            var blogRepo = new BlogRepository();
            try
            {
                return new WebAPIResult<List<BlogEntry>>
                {
                    DataModel = blogRepo.GetBlogEntriesSortAsc(),
                    Status = new ServiceFeedback
                    {
                        Message = "Success",
                        Status = 200
                    }
                };
            }
            catch (Exception excp)
            {
                return new WebAPIResult<List<BlogEntry>>
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
