```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19044.3086/21H2/November2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2


```
| Method         | Mean     | Error    | StdDev   | Ratio | Gen0    | Allocated | Alloc Ratio |
|--------------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| Newtonsoft     | 76.65 μs | 1.491 μs | 1.596 μs |  1.00 | 38.2080 | 156.25 KB |        1.00 |
| SystemTextJson | 39.64 μs | 0.485 μs | 0.405 μs |  0.52 |  5.7373 |  23.44 KB |        0.15 |
| Jil            | 30.87 μs | 0.399 μs | 0.373 μs |  0.40 | 21.9727 |  89.87 KB |        0.58 |
