using BenchmarkDotNet.Attributes;
using orm_json_benchmarking.Database;

namespace orm_json_benchmarking.Benchmarks
{
    [MemoryDiagnoser]
    public class DatabaseSelectBenchmark
    {
        private static int NumberOfValidations = 100;

        [Benchmark(Baseline = true)]
        public void EntityFramework()
        {
            var database = new UserEntityFrameworkDatabase();

            for (int i = 0; i < NumberOfValidations; i++)
            {
                database.Get(i+1);
            }
        }

        [Benchmark]
        public void Dapper()
        {
            var database = new UserDapperDatabase();

            for (int i = 0; i < NumberOfValidations; i++)
            {
                database.Get(i+1);
            }
        }
    }
}