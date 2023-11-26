using Jil;
using orm_json_benchmarking.Interfaces;
using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Serializers;

public class JilSerializer : IJsonSerializer
{
    public string Serialize(UserModel user)
    {
        using(var output = new StringWriter())
        {
            JSON.Serialize(
                user,
                output
            );

            return output.ToString();
        }
    }
}