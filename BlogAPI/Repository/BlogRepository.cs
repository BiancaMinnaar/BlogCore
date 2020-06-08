using System;
using DomainModels;

namespace BlogAPI.Repository
{
    public class BlogRepository
    {
        public ServiceFeedback AddBlog(Blog model)
        {
            return new ServiceFeedback
            {
                Message = "Success",
                Status = 200
            };
        }
    }
}
