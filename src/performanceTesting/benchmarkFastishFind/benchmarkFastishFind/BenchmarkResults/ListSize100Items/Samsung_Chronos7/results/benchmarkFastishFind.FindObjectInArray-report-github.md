``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 18.04
Intel Core i7-3635QM CPU 2.40GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-OVMXXE : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|                                    Method |      find |         Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------- |-------------:|-----------:|-----------:|-------:|------:|------:|----------:|
|                           FindWithForLoop |   Person9 |     64.50 ns |   0.095 ns |   0.089 ns |      - |     - |     - |         - |
|                       FindWithForEachLoop |   Person9 |     69.82 ns |   0.124 ns |   0.110 ns |      - |     - |     - |         - |
|                FindWithLinqFirstOrDefault |   Person9 |    191.40 ns |   0.573 ns |   0.536 ns | 0.0381 |     - |     - |     120 B |
|                           FindWithForLoop |  Person42 |    243.40 ns |   0.756 ns |   0.707 ns |      - |     - |     - |         - |
|                       FindWithForEachLoop |  Person42 |    245.42 ns |   0.775 ns |   0.687 ns |      - |     - |     - |         - |
|                          FindWithLinqFind |   Person9 |    284.40 ns |   2.596 ns |   2.429 ns | 0.3009 |     - |     - |     944 B |
|                       FindWithForEachLoop | Person100 |    339.22 ns |   0.374 ns |   0.313 ns |      - |     - |     - |         - |
|                           FindWithForLoop | Person100 |    368.02 ns |   1.347 ns |   1.260 ns |      - |     - |     - |         - |
|                       FindWithForEachLoop |  Person75 |    450.55 ns |   0.350 ns |   0.273 ns |      - |     - |     - |         - |
|                           FindWithForLoop |  Person75 |    469.16 ns |   0.506 ns |   0.422 ns |      - |     - |     - |         - |
|                          FindWithLinqFind |  Person42 |    501.21 ns |   3.289 ns |   2.915 ns | 0.3004 |     - |     - |     944 B |
|                FindWithLinqFirstOrDefault |  Person42 |    633.17 ns |   1.575 ns |   1.473 ns | 0.0381 |     - |     - |     120 B |
|                          FindWithLinqFind | Person100 |    653.59 ns |   1.800 ns |   1.503 ns | 0.3004 |     - |     - |     944 B |
|                          FindWithLinqFind |  Person75 |    733.26 ns |   1.390 ns |   1.301 ns | 0.3004 |     - |     - |     944 B |
|                FindWithLinqFirstOrDefault |  Person75 |  1,064.76 ns |   4.142 ns |   3.672 ns | 0.0381 |     - |     - |     120 B |
|                FindWithLinqFirstOrDefault | Person100 |  1,101.17 ns |   6.010 ns |   5.622 ns | 0.0381 |     - |     - |     120 B |
|        FindByManualParallelTasksBy20Count |   Person9 |  2,014.32 ns |   5.848 ns |   5.470 ns | 1.0300 |     - |     - |    3232 B |
|        FindByManualParallelTasksBy20Count |  Person42 |  2,730.75 ns |   4.561 ns |   4.043 ns | 1.0300 |     - |     - |    3232 B |
|        FindByManualParallelTasksBy20Count | Person100 |  2,989.40 ns |  14.841 ns |  13.157 ns | 1.0300 |     - |     - |    3232 B |
|                       FindWithParallelFor |   Person9 |  3,022.10 ns |  59.584 ns |  97.898 ns | 0.6599 |     - |     - |    2070 B |
|        FindByManualParallelTasksBy20Count |  Person75 |  3,031.83 ns |  19.988 ns |  17.718 ns | 1.0300 |     - |     - |    3232 B |
|        FindByManualParallelTasksBy50Count |   Person9 |  3,921.49 ns |  11.051 ns |   9.796 ns | 2.0981 |     - |     - |    6592 B |
|                       FindWithParallelFor |  Person42 |  3,979.10 ns |  79.655 ns | 209.844 ns | 0.7095 |     - |     - |    2220 B |
|        FindByManualParallelTasksBy50Count |  Person42 |  5,257.34 ns |   9.457 ns |   8.846 ns | 2.0981 |     - |     - |    6592 B |
|                       FindWithParallelFor |  Person75 |  5,546.47 ns | 107.472 ns | 147.109 ns | 0.7782 |     - |     - |    2422 B |
|                       FindWithParallelFor | Person100 |  5,914.73 ns |  84.106 ns |  78.673 ns | 0.7935 |     - |     - |    2475 B |
|        FindByManualParallelTasksBy50Count |  Person75 |  6,195.23 ns |  11.598 ns |  10.849 ns | 2.0981 |     - |     - |    6592 B |
|        FindByManualParallelTasksBy50Count | Person100 |  6,681.98 ns |  26.193 ns |  23.219 ns | 2.0981 |     - |     - |    6592 B |
|       FindByManualParallelTasksBy100Count |   Person9 |  7,146.04 ns |  29.436 ns |  26.095 ns | 3.8834 |     - |     - |   12192 B |
| FindByManualParallelTasksByProcessorCount |   Person9 |  8,863.95 ns | 104.324 ns |  97.585 ns | 0.6714 |     - |     - |    2136 B |
| FindByManualParallelTasksByProcessorCount | Person100 |  9,184.05 ns |  74.450 ns |  69.641 ns | 0.6714 |     - |     - |    2136 B |
| FindByManualParallelTasksByProcessorCount |  Person75 |  9,448.80 ns |  39.265 ns |  36.728 ns | 0.6714 |     - |     - |    2136 B |
| FindByManualParallelTasksByProcessorCount |  Person42 |  9,615.88 ns | 138.768 ns | 129.804 ns | 0.6714 |     - |     - |    2136 B |
|       FindByManualParallelTasksBy100Count |  Person75 | 11,943.34 ns |  83.473 ns |  69.704 ns | 3.8757 |     - |     - |   12192 B |
|       FindByManualParallelTasksBy100Count |  Person42 | 12,407.42 ns |  49.888 ns |  44.225 ns | 3.8757 |     - |     - |   12192 B |
|       FindByManualParallelTasksBy100Count | Person100 | 13,390.58 ns |  74.222 ns |  69.427 ns | 3.8757 |     - |     - |   12192 B |
|       FindByManualParallelTasksBy200Count |   Person9 | 28,600.44 ns | 103.536 ns |  96.848 ns | 6.9580 |     - |     - |   21912 B |
|       FindByManualParallelTasksBy200Count |  Person42 | 29,107.99 ns | 100.355 ns |  88.962 ns | 6.9580 |     - |     - |   21912 B |
|       FindByManualParallelTasksBy200Count |  Person75 | 29,188.47 ns |  52.638 ns |  43.955 ns | 6.9580 |     - |     - |   21912 B |
|       FindByManualParallelTasksBy200Count | Person100 | 29,477.83 ns |  71.937 ns |  56.164 ns | 6.9580 |     - |     - |   21912 B |
