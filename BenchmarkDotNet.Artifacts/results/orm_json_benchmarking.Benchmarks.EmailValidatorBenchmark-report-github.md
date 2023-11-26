```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19044.3086/21H2/November2021Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2


```
| Method        | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|-------------- |------------:|----------:|----------:|------:|--------:|--------:|----------:|------------:|
| Regex         | 33,273.8 ns | 657.69 ns | 615.20 ns |  1.00 |    0.00 |  1.7700 |    7520 B |        1.00 |
| Simple        |    634.1 ns |   8.32 ns |   7.78 ns |  0.02 |    0.00 |       - |         - |        0.00 |
| RegexCompiled | 17,759.1 ns | 332.58 ns | 311.10 ns |  0.53 |    0.02 | 11.4746 |   48000 B |        6.38 |
