using BenchmarkDotNet.Attributes;
using orm_json_benchmarking.Database;
using orm_json_benchmarking.Models;

namespace orm_json_benchmarking.Benchmarks
{
    [MemoryDiagnoser]
    public class DatabaseInsertBenchmark
    {
        private static int NumberOfValidations = 100;
        private readonly UserModel user = new UserModel{ Username = "JohnDoe", Password = "teste", Role = 1, CreationDate = DateTime.Now };

        [Benchmark(Baseline = true)]
        public void EntityFramework()
        {
            var database = new UserEntityFrameworkDatabase();

            for (int i = 0; i < NumberOfValidations; i++)
            {
                database.Insert(user);
            }
        }

        [Benchmark]
        public void Dapper()
        {
            var database = new UserDapperDatabase();

            for (int i = 0; i < NumberOfValidations; i++)
            {
                database.Insert(user);
            }
        }
    }
}