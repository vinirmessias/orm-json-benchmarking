using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Interfaces
{
    internal interface IJsonSerializer
    {
        string Serialize(UserModel user);
    }
}