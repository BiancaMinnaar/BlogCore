using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Blog> GetBlogs()
        {
            using var context = new EfDataContext();
            return context.Blogs.Select(row => row).OrderBy(e => e.CreationDate).ToList();
        }

        public ServiceFeedback AddBlogEntry(BlogEntry model)
        {
            using (var context = new EfDataContext())
            {
                if (model.ID == new Guid())
                    model.ID = Guid.NewGuid();
                if (model.EntryDate == new DateTime())
                    model.EntryDate= DateTime.Now;
                context.BlogEntries.Add(model);
                context.SaveChanges();
            }

            return new ServiceFeedback
            {
                Message = "Success",
                Status = 200
            };
        }

        public List<BlogEntry> GetBlogEntriesSortAsc()
        {
            using var context = new EfDataContext();
            return context.BlogEntries.Select(row => row).OrderBy(e => e.EntryDate).ToList();
        }
    }
}
