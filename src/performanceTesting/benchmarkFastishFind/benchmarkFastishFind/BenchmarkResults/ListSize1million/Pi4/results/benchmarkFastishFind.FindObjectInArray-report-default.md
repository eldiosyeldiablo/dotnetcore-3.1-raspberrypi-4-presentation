
BenchmarkDotNet=v0.12.0, OS=raspbian 10
ARMv7 Processor rev 3 (v7l), 4 logical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), Arm RyuJIT
  Job-TVKVDN : .NET Core 3.1.0 (CoreCLR 4.700.19.56106, CoreFX 4.700.19.56202), Arm RyuJIT

Runtime=.NET Core 3.1  

                                    Method |          find |            Mean |           Error |          StdDev |      Gen 0 |   Gen 1 |   Gen 2 | Allocated |
------------------------------------------ |-------------- |----------------:|----------------:|----------------:|-----------:|--------:|--------:|----------:|
                           FindWithForLoop |       Person9 |        274.8 ns |         0.76 ns |         0.71 ns |          - |       - |       - |         - |
                       FindWithForEachLoop |       Person9 |        277.6 ns |         0.51 ns |         0.47 ns |          - |       - |       - |         - |
                FindWithLinqFirstOrDefault |       Person9 |        987.0 ns |         3.28 ns |         3.07 ns |     0.3662 |       - |       - |      60 B |
                       FindWithParallelFor |       Person9 |     56,429.6 ns |     6,201.35 ns |    17,892.33 ns |     8.3008 |       - |       - |    1227 B |
                       FindWithForEachLoop |  Person333342 |  9,486,270.7 ns |    33,978.82 ns |    30,121.33 ns |          - |       - |       - |         - |
                           FindWithForLoop |  Person333342 |  9,804,029.0 ns |    18,143.90 ns |    15,150.98 ns |          - |       - |       - |         - |
                          FindWithLinqFind |       Person9 | 19,567,304.8 ns |    48,350.24 ns |    40,374.64 ns |    31.2500 | 31.2500 | 31.2500 | 4000080 B |
                       FindWithParallelFor |  Person333342 | 19,961,206.6 ns |   366,818.23 ns |   325,174.80 ns |          - |       - |       - |    1796 B |
                           FindWithForLoop |  Person666675 | 20,675,422.2 ns |    56,967.30 ns |    53,287.24 ns |          - |       - |       - |         - |
                       FindWithForEachLoop |  Person666675 | 20,840,229.6 ns |   410,434.28 ns |   729,546.51 ns |          - |       - |       - |         - |
                           FindWithForLoop | Person1000000 | 22,955,325.5 ns |    12,763.49 ns |     9,964.89 ns |          - |       - |       - |         - |
                       FindWithForEachLoop | Person1000000 | 23,200,477.8 ns |   148,265.37 ns |   138,687.52 ns |          - |       - |       - |         - |
                       FindWithParallelFor |  Person666675 | 26,064,827.8 ns |   369,311.17 ns |   345,453.90 ns |          - |       - |       - |    1887 B |
                FindWithLinqFirstOrDefault |  Person333342 | 26,797,718.9 ns |   526,234.81 ns |   665,518.54 ns |          - |       - |       - |      60 B |
                          FindWithLinqFind |  Person333342 | 30,795,084.1 ns |   114,069.08 ns |   106,700.29 ns |    31.2500 | 31.2500 | 31.2500 | 4000080 B |
                       FindWithParallelFor | Person1000000 | 31,973,825.3 ns |   582,620.98 ns |   544,984.02 ns |          - |       - |       - |    2505 B |
                          FindWithLinqFind | Person1000000 | 33,047,412.3 ns |   208,329.71 ns |   184,678.86 ns |          - |       - |       - | 4000080 B |
        FindByManualParallelTasksBy20Count |       Person9 | 33,499,982.5 ns |   215,217.68 ns |   190,784.87 ns |          - |       - |       - | 4001407 B |
 FindByManualParallelTasksByProcessorCount | Person1000000 | 33,620,021.8 ns |   189,277.43 ns |   158,055.23 ns |          - |       - |       - | 4000384 B |
                          FindWithLinqFind |  Person666675 | 34,392,050.0 ns |   677,844.12 ns |   696,096.01 ns |          - |       - |       - | 4000080 B |
        FindByManualParallelTasksBy20Count | Person1000000 | 34,805,390.5 ns |   278,008.96 ns |   246,447.70 ns |          - |       - |       - | 4001407 B |
 FindByManualParallelTasksByProcessorCount |  Person333342 | 35,326,783.7 ns |    86,210.20 ns |    76,423.10 ns |          - |       - |       - | 4000384 B |
 FindByManualParallelTasksByProcessorCount |       Person9 | 37,619,151.1 ns |   211,774.94 ns |   198,094.41 ns |    31.2500 | 31.2500 | 31.2500 | 4000384 B |
 FindByManualParallelTasksByProcessorCount |  Person666675 | 38,016,753.2 ns |    78,158.38 ns |    65,265.79 ns |          - |       - |       - | 4000384 B |
        FindByManualParallelTasksBy20Count |  Person333342 | 40,701,358.5 ns |   148,925.77 ns |   132,018.81 ns |          - |       - |       - | 4001407 B |
        FindByManualParallelTasksBy50Count | Person1000000 | 41,007,574.2 ns |   400,174.37 ns |   354,744.15 ns | 24923.0769 |       - |       - | 4003125 B |
        FindByManualParallelTasksBy50Count |       Person9 | 41,174,002.9 ns |   593,059.63 ns |   554,748.34 ns | 24923.0769 |       - |       - | 4003125 B |
       FindByManualParallelTasksBy100Count | Person1000000 | 41,664,335.2 ns |   347,831.97 ns |   308,343.98 ns | 24923.0769 |       - |       - | 4006127 B |
       FindByManualParallelTasksBy100Count |       Person9 | 41,867,727.1 ns |   353,050.04 ns |   312,969.67 ns | 24916.6667 |       - |       - | 4006127 B |
        FindByManualParallelTasksBy20Count |  Person666675 | 42,167,530.5 ns |   262,336.26 ns |   232,554.26 ns |          - |       - |       - | 4001407 B |
       FindByManualParallelTasksBy200Count |       Person9 | 42,223,245.0 ns |   411,824.44 ns |   365,071.64 ns | 24833.3333 |       - |       - | 4012118 B |
       FindByManualParallelTasksBy200Count | Person1000000 | 42,255,571.5 ns |   481,464.99 ns |   426,806.18 ns | 24916.6667 |       - |       - | 4012127 B |
        FindByManualParallelTasksBy50Count |  Person666675 | 47,458,554.6 ns |   285,466.73 ns |   253,058.82 ns | 24909.0909 |       - |       - | 4003125 B |
        FindByManualParallelTasksBy50Count |  Person333342 | 47,666,563.7 ns |   241,201.58 ns |   213,818.92 ns | 24909.0909 |       - |       - | 4003125 B |
       FindByManualParallelTasksBy100Count |  Person666675 | 48,323,938.4 ns |   207,145.03 ns |   172,975.49 ns | 24909.0909 |       - |       - | 4006127 B |
       FindByManualParallelTasksBy200Count |  Person666675 | 48,439,323.3 ns |   361,956.85 ns |   320,865.32 ns | 24909.0909 |       - |       - | 4012124 B |
       FindByManualParallelTasksBy200Count |  Person333342 | 48,534,111.7 ns |   163,062.52 ns |   144,550.68 ns | 24909.0909 |       - |       - | 4012120 B |
       FindByManualParallelTasksBy100Count |  Person333342 | 48,771,725.7 ns |   130,715.17 ns |   109,153.09 ns | 24909.0909 |       - |       - | 4006127 B |
                FindWithLinqFirstOrDefault |  Person666675 | 56,829,073.8 ns | 1,135,873.33 ns | 2,828,718.76 ns |          - |       - |       - |      60 B |
                FindWithLinqFirstOrDefault | Person1000000 | 83,768,075.9 ns | 1,671,048.99 ns | 2,650,460.77 ns |          - |       - |       - |      60 B |
