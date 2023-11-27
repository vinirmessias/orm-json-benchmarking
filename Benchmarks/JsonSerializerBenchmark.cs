using BenchmarkDotNet.Attributes;
using orm_json_benchmarking.Models;
using orm_json_benchmarking.Serializers;

namespace orm_json_benchmarking.Benchmarks;

[MemoryDiagnoser]
public class JsonSerializerBenchmark
{
    private static int NumberOfValidations = 100;
    private readonly UserModel user = new UserModel{ Id = 1, Username = "JohnDoe", Password = "teste", Role = 1, CreationDate = DateTime.Now };

    [Benchmark(Baseline = true)]
    public void Newtonsoft()
    {
        var serializer = new NewtonsoftSerializer();

        for (int i = 0; i < NumberOfValidations; i++)
        {
            serializer.Serialize(user);
        }
    }

    [Benchmark]
    public void SystemTextJson()
    {
        var serializer = new SystemTextJsonSerializer();

        for (int i = 0; i < NumberOfValidations; i++)
        {
            serializer.Serialize(user);
        }
    }

    [Benchmark]
    public void Jil()
    {
        var serializer = new JilSerializer();

        for (int i = 0; i < NumberOfValidations; i++)
        {
            serializer.Serialize(user);
        }
    }
}