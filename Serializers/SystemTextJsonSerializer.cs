using System.Text.Json;
using orm_json_benchmarking.Interfaces;
using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Serializers;

public class SystemTextJsonSerializer : IJsonSerializer
{
    public string Serialize(UserModel user)
    {
        return JsonSerializer.Serialize(user);
    }
}