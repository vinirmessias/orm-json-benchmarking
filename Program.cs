﻿using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis;
using orm_json_benchmarking.Benchmarks;

class Program
{
    static void Main(string[] args)
    {
        string option = string.Empty;

        do
        {
            Console.WriteLine("Selecione o benchmark a ser executado:");
            Console.WriteLine("1 - DatabaseInsertBenchmark");
            Console.WriteLine("2 - DatabaseSelectBenchmark");
            Console.WriteLine("3 - DatabaseDeleteBenchmark");
            Console.WriteLine("4 - JsonSerializerBenchmark");
            Console.WriteLine("5 - Parar execução");

            option = Console.ReadLine();

            if (option == "1")
            {
                BenchmarkRunner.Run<DatabaseInsertBenchmark>();
            }
            else if (option == "2")
            {
                BenchmarkRunner.Run<DatabaseSelectBenchmark>();
            }
            else if (option == "3")
            {
                BenchmarkRunner.Run<DatabaseDeleteBenchmark>();
            }
            else if (option == "4")
            {
                BenchmarkRunner.Run<JsonSerializerBenchmark>();
            }
            else if (option == "5")
            {
                Console.WriteLine("Encerrando");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        } while (option != "5");
        
    }
}