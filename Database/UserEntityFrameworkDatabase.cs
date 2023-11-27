using orm_json_benchmarking.Interfaces;
using orm_json_benchmarking.Models;
using static orm_json_benchmarking.Models.UserModel;

namespace orm_json_benchmarking.Database
{
    internal class UserEntityFrameworkDatabase : IUserDatabase
    {
        public long? Insert(UserModel user)
        {
            using (var context = new UserContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
                return user.Id;
            }
        }

        public UserModel Get(long? id)
        {
            using (var context = new UserContext())
            {
                return context.Users.Find(id);
            }
        }

        public void Delete(long? id)
        {
            using (var context = new UserContext())
            {
                var user = context.Users.Find(id);
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}