using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Interfaces
{
    internal interface IUserDatabase
    {
        long? Insert(UserModel user);

        UserModel Get(long? id);
        
        void Delete(long? id);
    }
}