using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace BlogAPI.Repository
{
    public class UserRepository
    {
        public ServiceFeedback AddUser(User model)
        {
            using (var context = new EfDataContext())
            {
                if (model.ID == new Guid())
                    model.ID = Guid.NewGuid();
                if (model.CreationDate == new DateTime())
                    model.CreationDate = DateTime.Now;
                context.Users.Add(model);
                context.SaveChanges();
            }

            return new ServiceFeedback
            {
                Message = "Success",
                Status = 200
            };
        }

        public List<User> GetAllUsers()
        {
            using var context = new EfDataContext();
            return context.Users.Select(row => row).ToList();
        }
    }
}
