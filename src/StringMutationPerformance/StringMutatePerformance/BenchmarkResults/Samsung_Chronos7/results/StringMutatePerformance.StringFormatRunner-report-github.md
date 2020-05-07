``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 18.04
Intel Core i7-3635QM CPU 2.40GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-NVUEUX : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|                                Method | CountToAppend |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |-------------- |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|        StringConcatPatternSomeStrings |             1 |    57.07 ns |  0.147 ns |  0.131 ns |  1.00 |    0.00 | 0.0535 |     - |     - |     168 B |
|                   StringConcatPattern |             1 |    57.26 ns |  0.131 ns |  0.122 ns |  1.00 |    0.00 | 0.0535 |     - |     - |     168 B |
|  StringInterpolationPatternAllStrings |             1 |    57.77 ns |  0.735 ns |  0.651 ns |  1.01 |    0.01 | 0.0534 |     - |     - |     168 B |
|                   StringFormatPattern |             1 |   373.87 ns |  1.442 ns |  1.349 ns |  6.53 |    0.02 | 0.0534 |     - |     - |     168 B |
| StringInterpolationPatternSomeStrings |             1 |   406.69 ns |  2.212 ns |  2.069 ns |  7.10 |    0.04 | 0.0634 |     - |     - |     200 B |
|                  StringBuilderPattern |             1 |   500.34 ns |  3.986 ns |  3.728 ns |  8.74 |    0.07 | 0.2365 |     - |     - |     744 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             2 |    99.06 ns |  0.396 ns |  0.370 ns |  1.00 |    0.00 | 0.0969 |     - |     - |     304 B |
|  StringInterpolationPatternAllStrings |             2 |    99.58 ns |  0.476 ns |  0.422 ns |  1.01 |    0.01 | 0.0969 |     - |     - |     304 B |
|        StringConcatPatternSomeStrings |             2 |    99.93 ns |  0.982 ns |  0.919 ns |  1.01 |    0.01 | 0.0969 |     - |     - |     304 B |
|                   StringFormatPattern |             2 |   426.13 ns |  2.315 ns |  2.052 ns |  4.30 |    0.02 | 0.0763 |     - |     - |     240 B |
| StringInterpolationPatternSomeStrings |             2 |   448.80 ns |  1.585 ns |  1.483 ns |  4.53 |    0.02 | 0.0863 |     - |     - |     272 B |
|                  StringBuilderPattern |             2 |   543.85 ns |  2.981 ns |  2.789 ns |  5.49 |    0.04 | 0.2594 |     - |     - |     816 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             3 |   116.73 ns |  0.933 ns |  0.872 ns |  1.00 |    0.00 | 0.1223 |     - |     - |     384 B |
|  StringInterpolationPatternAllStrings |             3 |   120.60 ns |  0.524 ns |  0.490 ns |  1.03 |    0.01 | 0.1223 |     - |     - |     384 B |
|        StringConcatPatternSomeStrings |             3 |   121.00 ns |  0.893 ns |  0.836 ns |  1.04 |    0.01 | 0.1223 |     - |     - |     384 B |
|                   StringFormatPattern |             3 |   510.74 ns |  4.014 ns |  3.754 ns |  4.38 |    0.04 | 0.1173 |     - |     - |     368 B |
| StringInterpolationPatternSomeStrings |             3 |   536.19 ns |  1.837 ns |  1.718 ns |  4.59 |    0.04 | 0.1268 |     - |     - |     400 B |
|                  StringBuilderPattern |             3 |   695.23 ns |  2.476 ns |  2.316 ns |  5.96 |    0.04 | 0.4148 |     - |     - |    1304 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|  StringInterpolationPatternAllStrings |             4 |   136.06 ns |  0.686 ns |  0.608 ns |  0.99 |    0.01 | 0.1478 |     - |     - |     464 B |
|        StringConcatPatternSomeStrings |             4 |   136.23 ns |  0.941 ns |  0.880 ns |  1.00 |    0.01 | 0.1478 |     - |     - |     464 B |
|                   StringConcatPattern |             4 |   136.75 ns |  1.337 ns |  1.251 ns |  1.00 |    0.00 | 0.1478 |     - |     - |     464 B |
|                   StringFormatPattern |             4 |   568.36 ns |  3.624 ns |  3.390 ns |  4.16 |    0.04 | 0.1421 |     - |     - |     448 B |
| StringInterpolationPatternSomeStrings |             4 |   592.65 ns |  1.364 ns |  1.276 ns |  4.33 |    0.04 | 0.1526 |     - |     - |     480 B |
|                  StringBuilderPattern |             4 |   761.67 ns | 13.285 ns | 12.427 ns |  5.57 |    0.09 | 0.4406 |     - |     - |    1384 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|  StringInterpolationPatternAllStrings |             5 |   155.75 ns |  0.772 ns |  0.685 ns |  1.00 |    0.01 | 0.1733 |     - |     - |     544 B |
|                   StringConcatPattern |             5 |   156.33 ns |  0.805 ns |  0.753 ns |  1.00 |    0.00 | 0.1733 |     - |     - |     544 B |
|        StringConcatPatternSomeStrings |             5 |   156.52 ns |  0.802 ns |  0.711 ns |  1.00 |    0.01 | 0.1733 |     - |     - |     544 B |
|                   StringFormatPattern |             5 |   770.67 ns |  2.907 ns |  2.719 ns |  4.93 |    0.03 | 0.4997 |     - |     - |    1568 B |
|                  StringBuilderPattern |             5 |   800.13 ns |  4.279 ns |  3.793 ns |  5.12 |    0.04 | 0.4663 |     - |     - |    1464 B |
| StringInterpolationPatternSomeStrings |             5 |   859.97 ns | 17.742 ns | 16.596 ns |  5.50 |    0.12 | 0.5226 |     - |     - |    1640 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|  StringInterpolationPatternAllStrings |             6 |   174.59 ns |  0.846 ns |  0.791 ns |  0.97 |    0.01 | 0.1988 |     - |     - |     624 B |
|        StringConcatPatternSomeStrings |             6 |   175.10 ns |  0.776 ns |  0.726 ns |  0.98 |    0.01 | 0.1988 |     - |     - |     624 B |
|                   StringConcatPattern |             6 |   179.21 ns |  1.769 ns |  1.655 ns |  1.00 |    0.00 | 0.1988 |     - |     - |     624 B |
|                   StringFormatPattern |             6 |   808.88 ns |  3.258 ns |  3.047 ns |  4.51 |    0.04 | 0.5474 |     - |     - |    1720 B |
| StringInterpolationPatternSomeStrings |             6 |   844.21 ns |  4.869 ns |  4.555 ns |  4.71 |    0.04 | 0.5579 |     - |     - |    1752 B |
|                  StringBuilderPattern |             6 |   863.57 ns |  4.327 ns |  3.836 ns |  4.82 |    0.05 | 0.4921 |     - |     - |    1544 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             7 |   198.06 ns |  1.224 ns |  1.145 ns |  1.00 |    0.00 | 0.2244 |     - |     - |     704 B |
|  StringInterpolationPatternAllStrings |             7 |   199.14 ns |  1.266 ns |  1.185 ns |  1.01 |    0.01 | 0.2244 |     - |     - |     704 B |
|        StringConcatPatternSomeStrings |             7 |   199.75 ns |  1.479 ns |  1.311 ns |  1.01 |    0.01 | 0.2244 |     - |     - |     704 B |
|                   StringFormatPattern |             7 |   878.48 ns |  2.028 ns |  1.797 ns |  4.43 |    0.03 | 0.6037 |     - |     - |    1896 B |
| StringInterpolationPatternSomeStrings |             7 |   908.69 ns |  4.443 ns |  4.156 ns |  4.59 |    0.04 | 0.6142 |     - |     - |    1928 B |
|                  StringBuilderPattern |             7 |   982.12 ns |  3.167 ns |  2.808 ns |  4.96 |    0.03 | 0.7229 |     - |     - |    2272 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|  StringInterpolationPatternAllStrings |             8 |   212.59 ns |  1.001 ns |  0.936 ns |  1.00 |    0.01 | 0.2499 |     - |     - |     784 B |
|                   StringConcatPattern |             8 |   212.78 ns |  0.574 ns |  0.537 ns |  1.00 |    0.00 | 0.2499 |     - |     - |     784 B |
|        StringConcatPatternSomeStrings |             8 |   214.90 ns |  1.956 ns |  1.830 ns |  1.01 |    0.01 | 0.2499 |     - |     - |     784 B |
|                   StringFormatPattern |             8 |   936.72 ns |  2.062 ns |  1.929 ns |  4.40 |    0.01 | 0.6571 |     - |     - |    2064 B |
| StringInterpolationPatternSomeStrings |             8 |   965.41 ns |  4.923 ns |  4.605 ns |  4.54 |    0.03 | 0.6676 |     - |     - |    2096 B |
|                  StringBuilderPattern |             8 | 1,033.29 ns |  5.723 ns |  5.074 ns |  4.86 |    0.03 | 0.7496 |     - |     - |    2352 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             9 |   230.24 ns |  1.001 ns |  0.937 ns |  1.00 |    0.00 | 0.2754 |     - |     - |     864 B |
|        StringConcatPatternSomeStrings |             9 |   231.91 ns |  1.391 ns |  1.301 ns |  1.01 |    0.01 | 0.2754 |     - |     - |     864 B |
|  StringInterpolationPatternAllStrings |             9 |   234.54 ns |  0.816 ns |  0.763 ns |  1.02 |    0.01 | 0.2751 |     - |     - |     864 B |
|                   StringFormatPattern |             9 |   990.87 ns |  2.288 ns |  2.028 ns |  4.30 |    0.02 | 0.7133 |     - |     - |    2240 B |
| StringInterpolationPatternSomeStrings |             9 | 1,025.87 ns |  3.515 ns |  3.116 ns |  4.45 |    0.02 | 0.7229 |     - |     - |    2272 B |
|                  StringBuilderPattern |             9 | 1,107.10 ns |  3.664 ns |  3.427 ns |  4.81 |    0.02 | 0.7744 |     - |     - |    2432 B |
|                                       |               |             |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |            10 |   250.66 ns |  1.084 ns |  1.014 ns |  1.00 |    0.00 | 0.3009 |     - |     - |     944 B |
|        StringConcatPatternSomeStrings |            10 |   252.80 ns |  0.893 ns |  0.835 ns |  1.01 |    0.01 | 0.3009 |     - |     - |     944 B |
|  StringInterpolationPatternAllStrings |            10 |   253.35 ns |  0.868 ns |  0.812 ns |  1.01 |    0.01 | 0.3009 |     - |     - |     944 B |
|                   StringFormatPattern |            10 | 1,054.93 ns |  3.812 ns |  3.380 ns |  4.21 |    0.01 | 0.7687 |     - |     - |    2416 B |
| StringInterpolationPatternSomeStrings |            10 | 1,080.79 ns |  3.689 ns |  3.450 ns |  4.31 |    0.03 | 0.7801 |     - |     - |    2448 B |
|                  StringBuilderPattern |            10 | 1,139.41 ns |  2.100 ns |  1.965 ns |  4.55 |    0.02 | 0.7992 |     - |     - |    2512 B |
