```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19044.3086/21H2/November2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2


```
| Method          | Mean | Error | Ratio | RatioSD | Alloc Ratio |
|---------------- |-----:|------:|------:|--------:|------------:|
| Dapper          |   NA |    NA |     ? |       ? |           ? |
| EntityFramework |   NA |    NA |     ? |       ? |           ? |

Benchmarks with issues:
  DatabaseInsertBenchmark.Dapper: DefaultJob
  DatabaseInsertBenchmark.EntityFramework: DefaultJob
