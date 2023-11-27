using BenchmarkDotNet.Attributes;
using orm_json_benchmarking.Database;

namespace orm_json_benchmarking.Benchmarks
{
    [MemoryDiagnoser]
    public class DatabaseDeleteBenchmark
    {
        private static int NumberOfValidations = 100;

        [Benchmark(Baseline = true)]
        public void EntityFramework()
        {
            var database = new UserEntityFrameworkDatabase();

            for (int i = NumberOfValidations; i == 0; i--)
            {
                database.Delete(i+1);
            }
        }

        [Benchmark]
        public void Dapper()
        {
            var database = new UserDapperDatabase();

            for (int i = NumberOfValidations; i == 0; i--)
            {
                database.Delete(i+1);
            }
        }
    }
}