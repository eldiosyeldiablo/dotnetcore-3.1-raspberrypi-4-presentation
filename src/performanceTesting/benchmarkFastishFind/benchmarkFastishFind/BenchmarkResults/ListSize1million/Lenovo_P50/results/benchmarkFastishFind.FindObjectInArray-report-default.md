
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-LSTWDQ : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Runtime=.NET Core 3.1  

                                    Method |          find |             Mean |          Error |         StdDev |           Median |     Gen 0 |   Gen 1 |   Gen 2 | Allocated |
------------------------------------------ |-------------- |-----------------:|---------------:|---------------:|-----------------:|----------:|--------:|--------:|----------:|
                           FindWithForLoop |       Person9 |         45.05 ns |       0.259 ns |       0.216 ns |         45.05 ns |         - |       - |       - |         - |
                       FindWithForEachLoop |       Person9 |         46.86 ns |       1.203 ns |       1.647 ns |         46.32 ns |         - |       - |       - |         - |
                FindWithLinqFirstOrDefault |       Person9 |        148.20 ns |       1.096 ns |       0.856 ns |        148.25 ns |    0.0286 |       - |       - |     120 B |
                       FindWithParallelFor |       Person9 |      2,296.40 ns |      43.840 ns |      48.728 ns |      2,293.24 ns |    0.4807 |       - |       - |    2007 B |
                       FindWithForEachLoop |  Person333342 |  4,655,445.85 ns |  92,216.293 ns |  90,568.730 ns |  4,638,208.59 ns |         - |       - |       - |         - |
                           FindWithForLoop |  Person333342 |  4,765,689.90 ns |  43,215.429 ns |  38,309.352 ns |  4,769,238.67 ns |         - |       - |       - |         - |
                FindWithLinqFirstOrDefault |  Person333342 |  4,854,025.95 ns |  59,921.223 ns |  53,118.604 ns |  4,835,777.34 ns |         - |       - |       - |     120 B |
                       FindWithParallelFor |  Person666675 |  7,503,909.62 ns |  64,287.826 ns |  53,683.247 ns |  7,488,750.00 ns |         - |       - |       - |    3519 B |
                       FindWithParallelFor |  Person333342 |  7,852,784.84 ns | 399,803.833 ns | 869,140.629 ns |  7,393,243.75 ns |         - |       - |       - |    3531 B |
                       FindWithForEachLoop |  Person666675 |  8,087,114.69 ns |  59,259.628 ns |  55,431.493 ns |  8,089,960.94 ns |         - |       - |       - |         - |
                           FindWithForLoop |  Person666675 |  8,151,886.50 ns |  83,174.564 ns |  73,732.085 ns |  8,135,867.97 ns |         - |       - |       - |         - |
                FindWithLinqFirstOrDefault |  Person666675 |  9,960,949.11 ns |  61,294.999 ns |  54,336.420 ns |  9,939,803.91 ns |         - |       - |       - |     120 B |
                          FindWithLinqFind |       Person9 | 11,272,254.84 ns |  72,188.045 ns |  67,524.742 ns | 11,264,875.78 ns |   78.1250 | 78.1250 | 78.1250 | 8000144 B |
                       FindWithParallelFor | Person1000000 | 11,636,496.93 ns |  55,293.859 ns |  51,721.910 ns | 11,618,608.59 ns |         - |       - |       - |    3545 B |
                       FindWithForEachLoop | Person1000000 | 13,418,949.35 ns | 118,647.840 ns |  92,632.429 ns | 13,439,418.75 ns |         - |       - |       - |         - |
       FindByManualParallelTasksBy100Count |  Person666675 | 13,526,649.04 ns | 110,697.663 ns |  92,437.562 ns | 13,499,150.00 ns | 1875.0000 |       - |       - | 8011392 B |
       FindByManualParallelTasksBy200Count |  Person666675 | 13,594,785.83 ns |  78,542.319 ns |  69,625.720 ns | 13,585,988.28 ns | 1890.6250 |       - |       - | 8022592 B |
                           FindWithForLoop | Person1000000 | 13,637,369.89 ns | 140,777.232 ns | 117,555.364 ns | 13,657,214.84 ns |         - |       - |       - |         - |
       FindByManualParallelTasksBy100Count |  Person333342 | 13,837,276.46 ns | 141,097.365 ns | 131,982.563 ns | 13,853,521.88 ns | 1875.0000 |       - |       - | 8011392 B |
                          FindWithLinqFind |  Person333342 | 13,916,207.03 ns |  97,331.633 ns |  91,044.069 ns | 13,909,349.22 ns |   78.1250 | 78.1250 | 78.1250 | 8000144 B |
       FindByManualParallelTasksBy200Count |  Person333342 | 14,220,043.80 ns | 282,265.619 ns | 777,441.490 ns | 13,763,794.53 ns | 1890.6250 |       - |       - | 8022592 B |
       FindByManualParallelTasksBy100Count |       Person9 | 14,927,469.17 ns | 112,312.264 ns |  93,785.827 ns | 14,940,866.41 ns | 1875.0000 |       - |       - | 8011392 B |
       FindByManualParallelTasksBy200Count |       Person9 | 15,054,207.19 ns |  65,463.231 ns |  61,234.347 ns | 15,054,310.94 ns | 1890.6250 |       - |       - | 8022592 B |
       FindByManualParallelTasksBy200Count | Person1000000 | 15,200,101.12 ns |  88,679.563 ns |  78,612.123 ns | 15,209,321.88 ns | 1890.6250 |       - |       - | 8022592 B |
       FindByManualParallelTasksBy100Count | Person1000000 | 15,219,913.39 ns | 144,063.090 ns | 134,756.704 ns | 15,254,727.34 ns | 1875.0000 |       - |       - | 8011392 B |
                FindWithLinqFirstOrDefault | Person1000000 | 15,644,876.34 ns | 176,383.420 ns | 156,359.308 ns | 15,669,012.50 ns |         - |       - |       - |     120 B |
                          FindWithLinqFind |  Person666675 | 16,936,098.33 ns | 124,688.071 ns | 116,633.299 ns | 16,896,850.00 ns |   62.5000 | 62.5000 | 62.5000 | 8000144 B |
 FindByManualParallelTasksByProcessorCount |  Person666675 | 19,964,011.46 ns | 129,539.009 ns | 121,170.870 ns | 19,982,840.62 ns |   62.5000 | 62.5000 | 62.5000 | 8001088 B |
        FindByManualParallelTasksBy20Count |  Person666675 | 20,544,760.71 ns | 208,185.144 ns | 184,550.708 ns | 20,481,259.38 ns |   62.5000 | 62.5000 | 62.5000 | 8002432 B |
        FindByManualParallelTasksBy20Count |  Person333342 | 20,702,985.58 ns | 110,896.159 ns |  92,603.315 ns | 20,706,146.88 ns |   62.5000 | 62.5000 | 62.5000 | 8002432 B |
        FindByManualParallelTasksBy50Count |  Person666675 | 20,802,066.67 ns |  83,762.767 ns |  78,351.744 ns | 20,792,565.62 ns |   62.5000 | 62.5000 | 62.5000 | 8005792 B |
 FindByManualParallelTasksByProcessorCount |  Person333342 | 20,844,165.91 ns | 398,457.963 ns | 489,342.163 ns | 20,752,337.50 ns |   62.5000 | 62.5000 | 62.5000 | 8001088 B |
        FindByManualParallelTasksBy50Count |  Person333342 | 21,470,182.40 ns | 395,607.212 ns | 439,716.368 ns | 21,303,256.25 ns |   62.5000 | 62.5000 | 62.5000 | 8005792 B |
 FindByManualParallelTasksByProcessorCount |       Person9 | 21,859,248.44 ns | 116,844.308 ns |  97,570.289 ns | 21,847,564.06 ns |   62.5000 | 62.5000 | 62.5000 | 8001088 B |
        FindByManualParallelTasksBy20Count |       Person9 | 23,238,201.41 ns | 451,510.276 ns | 519,959.906 ns | 23,037,509.38 ns |   62.5000 | 62.5000 | 62.5000 | 8002432 B |
        FindByManualParallelTasksBy50Count |       Person9 | 23,372,940.14 ns | 224,360.916 ns | 187,351.526 ns | 23,329,065.62 ns |   62.5000 | 62.5000 | 62.5000 | 8005792 B |
 FindByManualParallelTasksByProcessorCount | Person1000000 | 23,688,880.29 ns | 122,190.511 ns | 102,034.611 ns | 23,669,778.12 ns |   62.5000 | 62.5000 | 62.5000 | 8001088 B |
        FindByManualParallelTasksBy20Count | Person1000000 | 23,752,627.81 ns | 230,260.560 ns | 215,385.871 ns | 23,765,401.56 ns |   62.5000 | 62.5000 | 62.5000 | 8002432 B |
        FindByManualParallelTasksBy50Count | Person1000000 | 23,765,864.06 ns | 207,627.136 ns | 184,056.048 ns | 23,747,460.94 ns |   62.5000 | 62.5000 | 62.5000 | 8005792 B |
                          FindWithLinqFind | Person1000000 | 24,596,350.48 ns | 151,093.181 ns | 126,169.649 ns | 24,590,925.00 ns |   62.5000 | 62.5000 | 62.5000 | 8000144 B |
