
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-FYRVVQ : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Runtime=.NET Core 3.1  

                                    Method |      find |         Mean |      Error |     StdDev |       Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------ |---------- |-------------:|-----------:|-----------:|-------------:|-------:|------:|------:|----------:|
                           FindWithForLoop |   Person9 |     44.30 ns |   0.453 ns |   0.401 ns |     44.30 ns |      - |     - |     - |         - |
                       FindWithForEachLoop |   Person9 |     53.00 ns |   0.427 ns |   0.399 ns |     53.07 ns |      - |     - |     - |         - |
                FindWithLinqFirstOrDefault |   Person9 |    156.54 ns |   1.673 ns |   1.397 ns |    156.46 ns | 0.0286 |     - |     - |     120 B |
                           FindWithForLoop |  Person42 |    213.26 ns |   2.687 ns |   2.382 ns |    212.44 ns |      - |     - |     - |         - |
                          FindWithLinqFind |   Person9 |    223.82 ns |   1.793 ns |   1.590 ns |    223.75 ns | 0.2255 |     - |     - |     944 B |
                       FindWithForEachLoop |  Person42 |    226.33 ns |   1.996 ns |   1.769 ns |    226.84 ns |      - |     - |     - |         - |
                       FindWithForEachLoop | Person100 |    305.78 ns |   1.849 ns |   1.639 ns |    305.49 ns |      - |     - |     - |         - |
                           FindWithForLoop | Person100 |    307.00 ns |   3.462 ns |   3.069 ns |    306.37 ns |      - |     - |     - |         - |
                           FindWithForLoop |  Person75 |    387.58 ns |   2.753 ns |   2.575 ns |    388.54 ns |      - |     - |     - |         - |
                          FindWithLinqFind |  Person42 |    406.27 ns |   2.896 ns |   2.568 ns |    405.83 ns | 0.2255 |     - |     - |     944 B |
                       FindWithForEachLoop |  Person75 |    435.74 ns |   9.253 ns |  15.712 ns |    428.66 ns |      - |     - |     - |         - |
                          FindWithLinqFind | Person100 |    532.72 ns |   6.422 ns |   5.693 ns |    532.57 ns | 0.2251 |     - |     - |     944 B |
                FindWithLinqFirstOrDefault |  Person42 |    550.60 ns |   7.360 ns |   6.146 ns |    550.05 ns | 0.0286 |     - |     - |     120 B |
                          FindWithLinqFind |  Person75 |    606.67 ns |  10.011 ns |   8.874 ns |    603.52 ns | 0.2251 |     - |     - |     944 B |
                FindWithLinqFirstOrDefault | Person100 |    961.37 ns |  21.908 ns |  19.421 ns |    952.87 ns | 0.0286 |     - |     - |     120 B |
                FindWithLinqFirstOrDefault |  Person75 |    965.19 ns |  11.378 ns |  10.643 ns |    964.68 ns | 0.0286 |     - |     - |     120 B |
        FindByManualParallelTasksBy20Count |   Person9 |  1,580.99 ns |  15.210 ns |  13.484 ns |  1,578.21 ns | 0.7725 |     - |     - |    3232 B |
        FindByManualParallelTasksBy20Count |  Person42 |  2,261.39 ns |  11.524 ns |  10.779 ns |  2,259.85 ns | 0.7706 |     - |     - |    3232 B |
                       FindWithParallelFor |   Person9 |  2,323.20 ns |  30.409 ns |  28.444 ns |  2,319.15 ns | 0.4959 |     - |     - |    2068 B |
        FindByManualParallelTasksBy20Count | Person100 |  2,351.12 ns |  34.920 ns |  30.956 ns |  2,346.00 ns | 0.7706 |     - |     - |    3232 B |
        FindByManualParallelTasksBy20Count |  Person75 |  2,619.76 ns |  26.952 ns |  25.211 ns |  2,616.60 ns | 0.7706 |     - |     - |    3232 B |
        FindByManualParallelTasksBy50Count |   Person9 |  3,475.19 ns |  25.397 ns |  23.756 ns |  3,472.04 ns | 1.5755 |     - |     - |    6592 B |
                       FindWithParallelFor |  Person42 |  3,576.27 ns |  69.480 ns |  68.239 ns |  3,567.96 ns | 0.5455 |     - |     - |    2273 B |
 FindByManualParallelTasksByProcessorCount |   Person9 |  3,912.29 ns |  39.125 ns |  36.597 ns |  3,913.86 ns | 0.5035 |     - |     - |    2136 B |
 FindByManualParallelTasksByProcessorCount | Person100 |  4,242.27 ns | 110.924 ns | 108.943 ns |  4,197.37 ns | 0.5035 |     - |     - |    2136 B |
 FindByManualParallelTasksByProcessorCount |  Person42 |  4,358.28 ns |  43.876 ns |  41.042 ns |  4,352.71 ns | 0.5035 |     - |     - |    2136 B |
        FindByManualParallelTasksBy50Count |  Person42 |  4,402.08 ns |  39.057 ns |  34.623 ns |  4,390.88 ns | 1.5717 |     - |     - |    6592 B |
 FindByManualParallelTasksByProcessorCount |  Person75 |  4,593.27 ns |  97.216 ns | 115.729 ns |  4,557.87 ns | 0.5035 |     - |     - |    2136 B |
                       FindWithParallelFor |  Person75 |  4,714.35 ns |  25.488 ns |  23.842 ns |  4,712.50 ns | 0.6027 |     - |     - |    2507 B |
                       FindWithParallelFor | Person100 |  4,738.86 ns |  33.052 ns |  30.917 ns |  4,734.88 ns | 0.6104 |     - |     - |    2528 B |
        FindByManualParallelTasksBy50Count |  Person75 |  5,327.30 ns |  50.774 ns |  45.009 ns |  5,320.05 ns | 1.5717 |     - |     - |    6592 B |
        FindByManualParallelTasksBy50Count | Person100 |  5,557.30 ns | 109.241 ns | 196.984 ns |  5,474.15 ns | 1.5717 |     - |     - |    6592 B |
       FindByManualParallelTasksBy100Count |   Person9 |  6,131.49 ns |  45.711 ns |  40.522 ns |  6,129.48 ns | 2.9144 |     - |     - |   12192 B |
       FindByManualParallelTasksBy100Count |  Person42 |  8,450.94 ns |  97.952 ns |  86.832 ns |  8,449.89 ns | 2.9144 |     - |     - |   12192 B |
       FindByManualParallelTasksBy100Count |  Person75 | 10,320.73 ns | 114.020 ns | 106.655 ns | 10,328.27 ns | 2.9144 |     - |     - |   12192 B |
       FindByManualParallelTasksBy100Count | Person100 | 11,296.87 ns | 183.357 ns | 171.512 ns | 11,289.78 ns | 2.9144 |     - |     - |   12192 B |
       FindByManualParallelTasksBy200Count |  Person75 | 26,497.55 ns | 325.870 ns | 304.819 ns | 26,392.18 ns | 5.2185 |     - |     - |   21912 B |
       FindByManualParallelTasksBy200Count |  Person42 | 26,738.68 ns | 202.797 ns | 169.344 ns | 26,764.30 ns | 5.2185 |     - |     - |   21912 B |
       FindByManualParallelTasksBy200Count |   Person9 | 26,838.33 ns | 258.019 ns | 215.457 ns | 26,867.75 ns | 5.2185 |     - |     - |   21912 B |
       FindByManualParallelTasksBy200Count | Person100 | 27,027.26 ns | 349.826 ns | 292.121 ns | 27,130.74 ns | 5.2185 |     - |     - |   21912 B |
