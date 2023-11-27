﻿using BenchmarkDotNet.Running;
using orm_json_benchmarking.Benchmarks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando processo de benchmarking...");

        BenchmarkRunner.Run<DatabaseInsertBenchmark>();
        BenchmarkRunner.Run<DatabaseSelectBenchmark>();
        BenchmarkRunner.Run<DatabaseDeleteBenchmark>();

        BenchmarkRunner.Run<JsonSerializerBenchmark>();
    }
}