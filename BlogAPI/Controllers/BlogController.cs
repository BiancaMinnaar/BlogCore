﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.Repository;
using DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        [HttpPost]
        public WebAPIResult<Blog> Post([FromBody]Blog value)
        {
            try
            {
                return new WebAPIResult<Blog>
                {
                    Status = new BlogRepository().AddBlog(value)
                };
            }
            catch (Exception excp)
            {
                return new WebAPIResult<Blog>
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
        public WebAPIResult<List<Blog>> Get()
        {
            var blogRepo = new BlogRepository();
            try
            {
                return new WebAPIResult<List<Blog>>
                {
                    DataModel = blogRepo.GetBlogs(),
                    Status = new ServiceFeedback
                    {
                        Message = "Success",
                        Status = 200
                    }
                };
            }
            catch (Exception excp)
            {
                return new WebAPIResult<List<Blog>>
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
