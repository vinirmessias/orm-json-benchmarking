```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19044.3086/21H2/November2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2


```
| Method         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|--------------- |---------:|---------:|---------:|------:|--------:|--------:|----------:|------------:|
| Newtonsoft     | 87.39 μs | 1.690 μs | 2.681 μs |  1.00 |    0.00 | 38.2080 | 156.25 KB |        1.00 |
| SystemTextJson | 42.75 μs | 0.846 μs | 1.728 μs |  0.49 |    0.03 |  5.7373 |  23.44 KB |        0.15 |
| Jil            | 33.65 μs | 0.668 μs | 1.818 μs |  0.39 |    0.02 | 21.9727 |  89.87 KB |        0.58 |
