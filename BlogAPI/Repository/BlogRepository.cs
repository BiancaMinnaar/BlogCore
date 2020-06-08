using System;
using DomainModels;

namespace BlogAPI.Repository
{
    public class BlogRepository
    {
        public ServiceFeedback AddBlog(Blog model)
        {
            using (var context = new EfDataContext())
            {
                if (model.ID == new Guid())
                    model.ID = Guid.NewGuid();
                if (model.CreationDate == new DateTime())
                    model.CreationDate = DateTime.Now;
                context.Blogs.Add(model);
                context.SaveChanges();
            }

            return new ServiceFeedback
            {
                Message = "Success",
                Status = 200
            };
        }
    }
}
