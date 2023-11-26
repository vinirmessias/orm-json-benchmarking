using Newtonsoft.Json;
using orm_json_benchmarking.Interfaces;
using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Serializers;

public class NewtonsoftSerializer : IJsonSerializer
{
    public string Serialize(UserModel user)
    {
        return JsonConvert.SerializeObject(user);
    }
}
