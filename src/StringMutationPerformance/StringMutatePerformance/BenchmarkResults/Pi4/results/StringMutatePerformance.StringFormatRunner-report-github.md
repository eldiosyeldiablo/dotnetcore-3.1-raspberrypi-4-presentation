``` ini

BenchmarkDotNet=v0.12.0, OS=raspbian 10
ARMv7 Processor rev 3 (v7l), 4 logical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), Arm RyuJIT
  Job-IDFNNY : .NET Core 3.1.0 (CoreCLR 4.700.19.56106, CoreFX 4.700.19.56202), Arm RyuJIT

Runtime=.NET Core 3.1  

```
|                                Method | CountToAppend |       Mean |     Error |    StdDev | Ratio | RatioSD | Rank |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|-----:|--------:|------:|------:|----------:|
|  StringInterpolationPatternAllStrings |             1 |   424.0 ns |   5.85 ns |   5.47 ns |  0.98 |    0.01 |    1 |  0.9775 |     - |     - |     160 B |
|        StringConcatPatternSomeStrings |             1 |   424.8 ns |   2.94 ns |   2.61 ns |  0.98 |    0.01 |    1 |  0.9775 |     - |     - |     160 B |
|                   StringConcatPattern |             1 |   431.4 ns |   3.69 ns |   3.45 ns |  1.00 |    0.00 |    2 |  0.9775 |     - |     - |     160 B |
|                   StringFormatPattern |             1 | 1,390.2 ns |   9.97 ns |   9.33 ns |  3.22 |    0.03 |    3 |  0.9766 |     - |     - |     160 B |
| StringInterpolationPatternSomeStrings |             1 | 1,712.5 ns |  40.78 ns |  45.33 ns |  3.97 |    0.12 |    4 |  1.0986 |     - |     - |     180 B |
|                  StringBuilderPattern |             1 | 2,692.5 ns |  31.54 ns |  29.50 ns |  6.24 |    0.09 |    5 |  3.7117 |     - |     - |     608 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|        StringConcatPatternSomeStrings |             2 |   799.3 ns |   4.62 ns |   4.10 ns |  0.98 |    0.01 |    1 |  1.6127 |     - |     - |     264 B |
|  StringInterpolationPatternAllStrings |             2 |   800.9 ns |   4.52 ns |   4.01 ns |  0.99 |    0.01 |    1 |  1.6127 |     - |     - |     264 B |
|                   StringConcatPattern |             2 |   812.5 ns |   4.73 ns |   3.95 ns |  1.00 |    0.00 |    2 |  1.6127 |     - |     - |     264 B |
|                   StringFormatPattern |             2 | 1,613.5 ns |   7.00 ns |   6.21 ns |  1.99 |    0.01 |    3 |  1.4153 |     - |     - |     232 B |
| StringInterpolationPatternSomeStrings |             2 | 1,937.3 ns |  10.88 ns |  10.17 ns |  2.39 |    0.01 |    4 |  1.5373 |     - |     - |     252 B |
|                  StringBuilderPattern |             2 | 3,023.6 ns |  14.85 ns |  13.17 ns |  3.72 |    0.03 |    5 |  4.1504 |     - |     - |     680 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             3 |   981.9 ns |   5.13 ns |   4.28 ns |  0.96 |    0.01 |    1 |  2.0733 |     - |     - |     340 B |
|        StringConcatPatternSomeStrings |             3 | 1,025.8 ns |  12.81 ns |  11.35 ns |  1.00 |    0.01 |    2 |  2.0733 |     - |     - |     340 B |
|                   StringConcatPattern |             3 | 1,027.6 ns |   8.27 ns |   7.73 ns |  1.00 |    0.00 |    2 |  2.0733 |     - |     - |     340 B |
|                   StringFormatPattern |             3 | 2,410.4 ns |  13.58 ns |  12.04 ns |  2.35 |    0.02 |    3 |  2.0256 |     - |     - |     332 B |
| StringInterpolationPatternSomeStrings |             3 | 2,565.7 ns |  17.01 ns |  15.91 ns |  2.50 |    0.03 |    4 |  2.1477 |     - |     - |     352 B |
|                  StringBuilderPattern |             3 | 4,484.4 ns |  41.74 ns |  39.04 ns |  4.36 |    0.05 |    5 |  6.7673 |     - |     - |    1108 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             4 | 1,210.5 ns |   9.20 ns |   8.61 ns |  1.00 |    0.01 |    1 |  2.5368 |     - |     - |     416 B |
|        StringConcatPatternSomeStrings |             4 | 1,211.0 ns |   9.48 ns |   8.87 ns |  1.00 |    0.01 |    1 |  2.5368 |     - |     - |     416 B |
|                   StringConcatPattern |             4 | 1,213.7 ns |   8.30 ns |   7.35 ns |  1.00 |    0.00 |    1 |  2.5368 |     - |     - |     416 B |
|                   StringFormatPattern |             4 | 2,671.0 ns |  12.19 ns |  11.40 ns |  2.20 |    0.02 |    2 |  2.4910 |     - |     - |     408 B |
| StringInterpolationPatternSomeStrings |             4 | 2,959.8 ns |  13.16 ns |  12.31 ns |  2.44 |    0.02 |    3 |  2.6093 |     - |     - |     428 B |
|                  StringBuilderPattern |             4 | 4,613.2 ns |  36.94 ns |  34.55 ns |  3.80 |    0.03 |    4 |  7.2250 |     - |     - |    1184 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|                   StringConcatPattern |             5 | 1,408.8 ns |   9.41 ns |   8.34 ns |  1.00 |    0.00 |    1 |  3.0022 |     - |     - |     492 B |
|        StringConcatPatternSomeStrings |             5 | 1,415.2 ns |  11.38 ns |   9.50 ns |  1.01 |    0.01 |    1 |  3.0022 |     - |     - |     492 B |
|  StringInterpolationPatternAllStrings |             5 | 1,644.0 ns |  18.35 ns |  17.17 ns |  1.17 |    0.01 |    2 |  3.0022 |     - |     - |     492 B |
|                   StringFormatPattern |             5 | 5,106.7 ns |  20.68 ns |  17.27 ns |  3.63 |    0.02 |    3 |  8.6365 |     - |     - |    1416 B |
|                  StringBuilderPattern |             5 | 5,410.2 ns |  59.52 ns |  55.68 ns |  3.84 |    0.04 |    4 |  7.6904 |     - |     - |    1260 B |
| StringInterpolationPatternSomeStrings |             5 | 5,762.0 ns |  58.28 ns |  54.51 ns |  4.09 |    0.05 |    5 |  8.9264 |     - |     - |    1464 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             6 | 1,609.9 ns |   7.48 ns |   6.63 ns |  0.98 |    0.01 |    1 |  3.4657 |     - |     - |     568 B |
|                   StringConcatPattern |             6 | 1,642.6 ns |  19.35 ns |  18.10 ns |  1.00 |    0.00 |    2 |  3.4657 |     - |     - |     568 B |
|        StringConcatPatternSomeStrings |             6 | 1,668.2 ns |  27.70 ns |  25.91 ns |  1.02 |    0.02 |    2 |  3.4657 |     - |     - |     568 B |
|                  StringBuilderPattern |             6 | 5,444.1 ns |  36.03 ns |  33.70 ns |  3.31 |    0.04 |    3 |  8.1558 |     - |     - |    1336 B |
|                   StringFormatPattern |             6 | 5,592.8 ns |  38.68 ns |  32.30 ns |  3.41 |    0.04 |    4 |  9.6130 |     - |     - |    1576 B |
| StringInterpolationPatternSomeStrings |             6 | 6,006.9 ns |  38.81 ns |  36.30 ns |  3.66 |    0.04 |    5 |  9.7351 |     - |     - |    1596 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             7 | 1,804.0 ns |  13.07 ns |  10.20 ns |  0.99 |    0.01 |    1 |  3.9291 |     - |     - |     644 B |
|                   StringConcatPattern |             7 | 1,822.6 ns |  24.28 ns |  21.52 ns |  1.00 |    0.00 |    1 |  3.9291 |     - |     - |     644 B |
|        StringConcatPatternSomeStrings |             7 | 1,826.3 ns |  19.38 ns |  18.13 ns |  1.00 |    0.02 |    1 |  3.9291 |     - |     - |     644 B |
|                   StringFormatPattern |             7 | 6,050.1 ns |  42.52 ns |  37.69 ns |  3.32 |    0.05 |    2 | 10.6354 |     - |     - |    1744 B |
| StringInterpolationPatternSomeStrings |             7 | 6,509.1 ns |  39.87 ns |  37.29 ns |  3.57 |    0.04 |    3 | 10.7498 |     - |     - |    1764 B |
|                  StringBuilderPattern |             7 | 7,322.9 ns |  32.92 ns |  30.80 ns |  4.02 |    0.04 |    4 | 12.3749 |     - |     - |    2028 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|        StringConcatPatternSomeStrings |             8 | 2,003.4 ns |  10.46 ns |   9.27 ns |  0.99 |    0.01 |    1 |  4.3831 |     - |     - |     720 B |
|  StringInterpolationPatternAllStrings |             8 | 2,023.8 ns |  13.23 ns |  11.73 ns |  1.00 |    0.01 |    1 |  4.3831 |     - |     - |     720 B |
|                   StringConcatPattern |             8 | 2,026.0 ns |  17.44 ns |  16.31 ns |  1.00 |    0.00 |    1 |  4.3831 |     - |     - |     720 B |
| StringInterpolationPatternSomeStrings |             8 | 7,055.6 ns |  61.32 ns |  54.36 ns |  3.48 |    0.04 |    2 | 11.7264 |     - |     - |    1924 B |
|                   StringFormatPattern |             8 | 7,185.5 ns |  52.38 ns |  48.99 ns |  3.55 |    0.03 |    3 | 11.6272 |     - |     - |    1904 B |
|                  StringBuilderPattern |             8 | 8,172.0 ns |  58.30 ns |  54.53 ns |  4.03 |    0.05 |    4 | 12.8174 |     - |     - |    2104 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|        StringConcatPatternSomeStrings |             9 | 2,229.8 ns |  37.64 ns |  35.21 ns |  0.99 |    0.02 |    1 |  4.8523 |     - |     - |     796 B |
|  StringInterpolationPatternAllStrings |             9 | 2,230.2 ns |  39.29 ns |  36.75 ns |  0.99 |    0.02 |    1 |  4.8523 |     - |     - |     796 B |
|                   StringConcatPattern |             9 | 2,253.6 ns |  13.68 ns |  12.12 ns |  1.00 |    0.00 |    1 |  4.8523 |     - |     - |     796 B |
| StringInterpolationPatternSomeStrings |             9 | 7,580.0 ns |  53.00 ns |  49.58 ns |  3.37 |    0.03 |    2 | 12.7335 |     - |     - |    2092 B |
|                   StringFormatPattern |             9 | 7,647.4 ns |  32.23 ns |  26.91 ns |  3.39 |    0.02 |    2 | 12.6572 |     - |     - |    2072 B |
|                  StringBuilderPattern |             9 | 8,210.3 ns | 130.83 ns | 122.38 ns |  3.65 |    0.06 |    3 | 13.2904 |     - |     - |    2180 B |
|                                       |               |            |           |           |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |            10 | 2,414.4 ns |  19.60 ns |  18.33 ns |  0.99 |    0.01 |    1 |  5.3177 |     - |     - |     872 B |
|                   StringConcatPattern |            10 | 2,442.2 ns |  10.33 ns |   8.63 ns |  1.00 |    0.00 |    1 |  5.3177 |     - |     - |     872 B |
|        StringConcatPatternSomeStrings |            10 | 2,659.2 ns |  25.56 ns |  23.91 ns |  1.09 |    0.01 |    2 |  5.3177 |     - |     - |     872 B |
|                   StringFormatPattern |            10 | 8,155.0 ns |  61.51 ns |  57.53 ns |  3.34 |    0.02 |    3 | 13.6871 |     - |     - |    2244 B |
|                  StringBuilderPattern |            10 | 8,303.0 ns |  96.25 ns |  85.32 ns |  3.40 |    0.03 |    4 | 13.7482 |     - |     - |    2256 B |
| StringInterpolationPatternSomeStrings |            10 | 8,695.5 ns | 107.19 ns |  95.02 ns |  3.56 |    0.04 |    5 | 13.7787 |     - |     - |    2264 B |
