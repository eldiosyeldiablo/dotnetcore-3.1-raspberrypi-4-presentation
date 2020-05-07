``` ini

BenchmarkDotNet=v0.12.0, OS=raspbian 10
ARMv7 Processor rev 3 (v7l), 4 logical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), Arm RyuJIT
  Job-TYENZR : .NET Core 3.1.0 (CoreCLR 4.700.19.56106, CoreFX 4.700.19.56202), Arm RyuJIT

Runtime=.NET Core 3.1  

```
|                                Method | CountToAppend |       Mean |    Error |   StdDev | Ratio | RatioSD | Rank |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |-------------- |-----------:|---------:|---------:|------:|--------:|-----:|--------:|------:|------:|----------:|
|        StringConcatPatternSomeStrings |             1 |   420.8 ns |  2.59 ns |  2.29 ns |  0.97 |    0.03 |    1 |  0.9775 |     - |     - |     160 B |
|  StringInterpolationPatternAllStrings |             1 |   428.3 ns |  4.28 ns |  3.80 ns |  0.99 |    0.03 |    2 |  0.9775 |     - |     - |     160 B |
|                   StringConcatPattern |             1 |   430.1 ns |  9.92 ns | 11.80 ns |  1.00 |    0.00 |    2 |  0.9775 |     - |     - |     160 B |
|                   StringFormatPattern |             1 | 1,423.9 ns |  6.38 ns |  5.97 ns |  3.29 |    0.10 |    3 |  0.9766 |     - |     - |     160 B |
| StringInterpolationPatternSomeStrings |             1 | 1,554.2 ns |  5.81 ns |  5.43 ns |  3.59 |    0.11 |    4 |  1.0986 |     - |     - |     180 B |
|                  StringBuilderPattern |             1 | 2,581.0 ns | 34.74 ns | 30.80 ns |  5.95 |    0.19 |    5 |  3.7117 |     - |     - |     608 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             2 |   800.3 ns |  4.79 ns |  4.00 ns |  0.95 |    0.01 |    1 |  1.6127 |     - |     - |     264 B |
|        StringConcatPatternSomeStrings |             2 |   802.6 ns |  6.61 ns |  5.52 ns |  0.96 |    0.01 |    1 |  1.6127 |     - |     - |     264 B |
|                   StringConcatPattern |             2 |   839.5 ns |  6.84 ns |  5.71 ns |  1.00 |    0.00 |    2 |  1.6127 |     - |     - |     264 B |
|                   StringFormatPattern |             2 | 1,684.2 ns |  5.03 ns |  4.45 ns |  2.01 |    0.02 |    3 |  1.4153 |     - |     - |     232 B |
| StringInterpolationPatternSomeStrings |             2 | 1,948.1 ns |  9.83 ns |  8.72 ns |  2.32 |    0.02 |    4 |  1.5373 |     - |     - |     252 B |
|                  StringBuilderPattern |             2 | 2,920.0 ns | 18.04 ns | 15.99 ns |  3.48 |    0.04 |    5 |  4.1504 |     - |     - |     680 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             3 |   993.3 ns | 16.31 ns | 15.26 ns |  0.97 |    0.02 |    1 |  2.0733 |     - |     - |     340 B |
|        StringConcatPatternSomeStrings |             3 | 1,000.1 ns | 20.00 ns | 23.03 ns |  0.98 |    0.02 |    1 |  2.0733 |     - |     - |     340 B |
|                   StringConcatPattern |             3 | 1,024.0 ns |  7.83 ns |  6.94 ns |  1.00 |    0.00 |    2 |  2.0733 |     - |     - |     340 B |
|                   StringFormatPattern |             3 | 2,420.6 ns | 13.71 ns | 12.82 ns |  2.36 |    0.02 |    3 |  2.0256 |     - |     - |     332 B |
| StringInterpolationPatternSomeStrings |             3 | 2,856.1 ns | 16.17 ns | 14.34 ns |  2.79 |    0.03 |    4 |  2.1477 |     - |     - |     352 B |
|                  StringBuilderPattern |             3 | 4,513.1 ns | 34.36 ns | 30.46 ns |  4.41 |    0.04 |    5 |  6.7673 |     - |     - |    1108 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|        StringConcatPatternSomeStrings |             4 | 1,201.1 ns |  8.27 ns |  6.90 ns |  1.00 |    0.01 |    1 |  2.5368 |     - |     - |     416 B |
|  StringInterpolationPatternAllStrings |             4 | 1,201.7 ns |  9.67 ns |  9.04 ns |  1.00 |    0.01 |    1 |  2.5368 |     - |     - |     416 B |
|                   StringConcatPattern |             4 | 1,206.4 ns |  8.25 ns |  7.72 ns |  1.00 |    0.00 |    1 |  2.5368 |     - |     - |     416 B |
|                   StringFormatPattern |             4 | 2,644.6 ns | 11.98 ns | 11.21 ns |  2.19 |    0.02 |    2 |  2.4910 |     - |     - |     408 B |
| StringInterpolationPatternSomeStrings |             4 | 2,912.8 ns | 11.20 ns | 10.48 ns |  2.41 |    0.02 |    3 |  2.6093 |     - |     - |     428 B |
|                  StringBuilderPattern |             4 | 5,032.4 ns | 39.06 ns | 36.54 ns |  4.17 |    0.04 |    4 |  7.2250 |     - |     - |    1184 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|                   StringConcatPattern |             5 | 1,403.5 ns | 10.51 ns |  9.32 ns |  1.00 |    0.00 |    1 |  3.0022 |     - |     - |     492 B |
|  StringInterpolationPatternAllStrings |             5 | 1,437.5 ns |  8.24 ns |  7.30 ns |  1.02 |    0.01 |    2 |  3.0022 |     - |     - |     492 B |
|        StringConcatPatternSomeStrings |             5 | 1,626.9 ns | 29.77 ns | 24.86 ns |  1.16 |    0.02 |    3 |  3.0022 |     - |     - |     492 B |
|                   StringFormatPattern |             5 | 5,183.2 ns | 76.11 ns | 71.19 ns |  3.69 |    0.07 |    4 |  8.6365 |     - |     - |    1416 B |
|                  StringBuilderPattern |             5 | 5,401.3 ns | 69.41 ns | 64.93 ns |  3.85 |    0.05 |    5 |  7.6904 |     - |     - |    1260 B |
| StringInterpolationPatternSomeStrings |             5 | 5,548.9 ns | 44.32 ns | 41.46 ns |  3.95 |    0.04 |    6 |  8.9264 |     - |     - |    1464 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             6 | 1,603.4 ns |  6.43 ns |  5.37 ns |  0.99 |    0.01 |    1 |  3.4657 |     - |     - |     568 B |
|        StringConcatPatternSomeStrings |             6 | 1,610.0 ns | 10.06 ns |  7.85 ns |  0.99 |    0.01 |    1 |  3.4657 |     - |     - |     568 B |
|                   StringConcatPattern |             6 | 1,624.5 ns | 15.82 ns | 14.80 ns |  1.00 |    0.00 |    1 |  3.4657 |     - |     - |     568 B |
|                  StringBuilderPattern |             6 | 5,733.5 ns | 25.47 ns | 22.58 ns |  3.53 |    0.03 |    2 |  8.1558 |     - |     - |    1336 B |
|                   StringFormatPattern |             6 | 5,865.4 ns | 34.38 ns | 30.48 ns |  3.61 |    0.04 |    3 |  9.6130 |     - |     - |    1576 B |
| StringInterpolationPatternSomeStrings |             6 | 6,310.7 ns | 56.45 ns | 52.81 ns |  3.88 |    0.05 |    4 |  9.7351 |     - |     - |    1596 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|  StringInterpolationPatternAllStrings |             7 | 1,807.2 ns | 17.63 ns | 16.49 ns |  1.00 |    0.01 |    1 |  3.9291 |     - |     - |     644 B |
|                   StringConcatPattern |             7 | 1,811.7 ns | 14.82 ns | 13.86 ns |  1.00 |    0.00 |    1 |  3.9291 |     - |     - |     644 B |
|        StringConcatPatternSomeStrings |             7 | 2,026.6 ns | 15.90 ns | 14.87 ns |  1.12 |    0.01 |    2 |  3.9291 |     - |     - |     644 B |
|                   StringFormatPattern |             7 | 6,094.5 ns | 75.46 ns | 70.58 ns |  3.36 |    0.04 |    3 | 10.6354 |     - |     - |    1744 B |
| StringInterpolationPatternSomeStrings |             7 | 6,356.0 ns | 40.86 ns | 38.22 ns |  3.51 |    0.03 |    4 | 10.7498 |     - |     - |    1764 B |
|                  StringBuilderPattern |             7 | 7,151.9 ns | 41.55 ns | 38.87 ns |  3.95 |    0.04 |    5 | 12.3749 |     - |     - |    2028 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|                   StringConcatPattern |             8 | 2,010.3 ns | 15.79 ns | 14.77 ns |  1.00 |    0.00 |    1 |  4.3831 |     - |     - |     720 B |
|  StringInterpolationPatternAllStrings |             8 | 2,012.3 ns | 34.68 ns | 32.44 ns |  1.00 |    0.02 |    1 |  4.3831 |     - |     - |     720 B |
|        StringConcatPatternSomeStrings |             8 | 2,013.1 ns | 14.73 ns | 13.06 ns |  1.00 |    0.01 |    1 |  4.3831 |     - |     - |     720 B |
|                   StringFormatPattern |             8 | 6,797.2 ns | 47.58 ns | 44.51 ns |  3.38 |    0.04 |    2 | 11.6272 |     - |     - |    1904 B |
| StringInterpolationPatternSomeStrings |             8 | 7,116.8 ns | 35.58 ns | 33.28 ns |  3.54 |    0.02 |    3 | 11.7264 |     - |     - |    1924 B |
|                  StringBuilderPattern |             8 | 7,466.9 ns | 51.61 ns | 48.28 ns |  3.71 |    0.04 |    4 | 12.8174 |     - |     - |    2104 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|                   StringConcatPattern |             9 | 2,228.7 ns | 26.74 ns | 25.01 ns |  1.00 |    0.00 |    1 |  4.8523 |     - |     - |     796 B |
|        StringConcatPatternSomeStrings |             9 | 2,249.9 ns | 19.94 ns | 18.66 ns |  1.01 |    0.02 |    1 |  4.8523 |     - |     - |     796 B |
|  StringInterpolationPatternAllStrings |             9 | 2,516.0 ns | 35.70 ns | 33.39 ns |  1.13 |    0.01 |    2 |  4.8523 |     - |     - |     796 B |
| StringInterpolationPatternSomeStrings |             9 | 7,595.3 ns | 49.48 ns | 43.86 ns |  3.41 |    0.05 |    3 | 12.7258 |     - |     - |    2092 B |
|                   StringFormatPattern |             9 | 7,637.4 ns | 46.33 ns | 43.34 ns |  3.43 |    0.04 |    3 | 12.6572 |     - |     - |    2072 B |
|                  StringBuilderPattern |             9 | 7,735.7 ns | 38.63 ns | 34.25 ns |  3.47 |    0.05 |    3 | 13.2904 |     - |     - |    2180 B |
|                                       |               |            |          |          |       |         |      |         |       |       |           |
|        StringConcatPatternSomeStrings |            10 | 2,398.8 ns | 20.85 ns | 18.49 ns |  1.00 |    0.01 |    1 |  5.3177 |     - |     - |     872 B |
|                   StringConcatPattern |            10 | 2,407.4 ns | 15.58 ns | 13.81 ns |  1.00 |    0.00 |    1 |  5.3177 |     - |     - |     872 B |
|  StringInterpolationPatternAllStrings |            10 | 2,723.1 ns | 23.08 ns | 21.59 ns |  1.13 |    0.01 |    2 |  5.3177 |     - |     - |     872 B |
|                   StringFormatPattern |            10 | 7,692.2 ns | 63.62 ns | 56.40 ns |  3.20 |    0.03 |    3 | 13.6871 |     - |     - |    2244 B |
| StringInterpolationPatternSomeStrings |            10 | 8,068.3 ns | 66.57 ns | 59.01 ns |  3.35 |    0.03 |    4 | 13.7787 |     - |     - |    2264 B |
|                  StringBuilderPattern |            10 | 8,661.3 ns | 78.22 ns | 73.17 ns |  3.59 |    0.04 |    5 | 13.7482 |     - |     - |    2256 B |
