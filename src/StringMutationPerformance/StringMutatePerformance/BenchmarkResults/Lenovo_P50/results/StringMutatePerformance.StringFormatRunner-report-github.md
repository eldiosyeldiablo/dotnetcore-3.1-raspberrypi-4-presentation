``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  Job-LCRCWL : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|                                Method | CountToAppend |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|        StringConcatPatternSomeStrings |             1 |  39.91 ns |  0.890 ns |  1.627 ns |  39.59 ns |  1.01 |    0.04 | 0.0401 |     - |     - |     168 B |
|                   StringConcatPattern |             1 |  40.46 ns |  0.706 ns |  0.660 ns |  40.18 ns |  1.00 |    0.00 | 0.0401 |     - |     - |     168 B |
|  StringInterpolationPatternAllStrings |             1 |  42.25 ns |  0.929 ns |  1.877 ns |  41.77 ns |  1.05 |    0.06 | 0.0401 |     - |     - |     168 B |
|                   StringFormatPattern |             1 | 283.20 ns |  5.746 ns |  6.841 ns | 281.95 ns |  6.94 |    0.22 | 0.0401 |     - |     - |     168 B |
| StringInterpolationPatternSomeStrings |             1 | 311.19 ns |  5.944 ns |  6.845 ns | 311.47 ns |  7.70 |    0.22 | 0.0477 |     - |     - |     200 B |
|                  StringBuilderPattern |             1 | 413.82 ns | 15.654 ns | 44.663 ns | 398.83 ns | 11.45 |    1.25 | 0.1774 |     - |     - |     744 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|        StringConcatPatternSomeStrings |             2 |  71.55 ns |  0.603 ns |  0.504 ns |  71.66 ns |  0.96 |    0.02 | 0.0726 |     - |     - |     304 B |
|  StringInterpolationPatternAllStrings |             2 |  72.27 ns |  0.818 ns |  0.765 ns |  72.25 ns |  0.97 |    0.02 | 0.0726 |     - |     - |     304 B |
|                   StringConcatPattern |             2 |  74.66 ns |  1.543 ns |  1.585 ns |  74.82 ns |  1.00 |    0.00 | 0.0726 |     - |     - |     304 B |
|                   StringFormatPattern |             2 | 305.61 ns |  4.848 ns |  4.534 ns | 305.39 ns |  4.10 |    0.12 | 0.0572 |     - |     - |     240 B |
| StringInterpolationPatternSomeStrings |             2 | 348.06 ns |  7.912 ns |  7.013 ns | 347.19 ns |  4.67 |    0.12 | 0.0648 |     - |     - |     272 B |
|                  StringBuilderPattern |             2 | 434.64 ns |  4.694 ns |  4.161 ns | 433.91 ns |  5.83 |    0.16 | 0.1950 |     - |     - |     816 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|        StringConcatPatternSomeStrings |             3 |  86.65 ns |  0.931 ns |  0.825 ns |  86.53 ns |  0.99 |    0.01 | 0.0918 |     - |     - |     384 B |
|                   StringConcatPattern |             3 |  87.41 ns |  1.167 ns |  1.035 ns |  87.39 ns |  1.00 |    0.00 | 0.0918 |     - |     - |     384 B |
|  StringInterpolationPatternAllStrings |             3 |  88.22 ns |  1.627 ns |  2.673 ns |  87.55 ns |  1.02 |    0.03 | 0.0918 |     - |     - |     384 B |
|                   StringFormatPattern |             3 | 408.42 ns |  3.302 ns |  2.927 ns | 407.94 ns |  4.67 |    0.07 | 0.0877 |     - |     - |     368 B |
| StringInterpolationPatternSomeStrings |             3 | 408.58 ns |  5.402 ns |  4.511 ns | 409.61 ns |  4.67 |    0.07 | 0.0954 |     - |     - |     400 B |
|                  StringBuilderPattern |             3 | 568.54 ns | 12.553 ns | 23.268 ns | 560.34 ns |  6.58 |    0.28 | 0.3109 |     - |     - |    1304 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             4 | 101.44 ns |  2.076 ns |  2.307 ns | 101.12 ns |  1.00 |    0.00 | 0.1109 |     - |     - |     464 B |
|        StringConcatPatternSomeStrings |             4 | 102.52 ns |  2.085 ns |  1.848 ns | 101.73 ns |  1.01 |    0.03 | 0.1109 |     - |     - |     464 B |
|  StringInterpolationPatternAllStrings |             4 | 102.59 ns |  2.066 ns |  2.459 ns | 101.72 ns |  1.01 |    0.04 | 0.1109 |     - |     - |     464 B |
|                   StringFormatPattern |             4 | 423.91 ns |  3.766 ns |  3.523 ns | 422.22 ns |  4.16 |    0.11 | 0.1068 |     - |     - |     448 B |
| StringInterpolationPatternSomeStrings |             4 | 497.47 ns | 14.137 ns | 11.805 ns | 495.40 ns |  4.88 |    0.19 | 0.1144 |     - |     - |     480 B |
|                  StringBuilderPattern |             4 | 617.27 ns | 12.384 ns | 10.978 ns | 614.33 ns |  6.07 |    0.20 | 0.3300 |     - |     - |    1384 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             5 | 119.33 ns |  2.277 ns |  2.019 ns | 118.84 ns |  1.00 |    0.00 | 0.1299 |     - |     - |     544 B |
|  StringInterpolationPatternAllStrings |             5 | 119.50 ns |  1.696 ns |  1.587 ns | 119.29 ns |  1.00 |    0.02 | 0.1299 |     - |     - |     544 B |
|        StringConcatPatternSomeStrings |             5 | 119.79 ns |  2.259 ns |  2.113 ns | 119.25 ns |  1.00 |    0.02 | 0.1299 |     - |     - |     544 B |
|                   StringFormatPattern |             5 | 636.03 ns |  7.301 ns |  6.472 ns | 635.66 ns |  5.33 |    0.10 | 0.3748 |     - |     - |    1568 B |
|                  StringBuilderPattern |             5 | 667.53 ns | 10.648 ns |  8.892 ns | 668.62 ns |  5.59 |    0.14 | 0.3500 |     - |     - |    1464 B |
| StringInterpolationPatternSomeStrings |             5 | 701.95 ns | 10.755 ns |  8.981 ns | 701.65 ns |  5.88 |    0.12 | 0.3920 |     - |     - |    1640 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|        StringConcatPatternSomeStrings |             6 | 132.75 ns |  1.195 ns |  0.998 ns | 132.22 ns |  1.00 |    0.02 | 0.1490 |     - |     - |     624 B |
|                   StringConcatPattern |             6 | 133.48 ns |  2.352 ns |  2.085 ns | 133.26 ns |  1.00 |    0.00 | 0.1490 |     - |     - |     624 B |
|  StringInterpolationPatternAllStrings |             6 | 135.55 ns |  2.440 ns |  2.283 ns | 135.31 ns |  1.02 |    0.02 | 0.1490 |     - |     - |     624 B |
|                   StringFormatPattern |             6 | 690.19 ns | 14.209 ns | 34.855 ns | 676.15 ns |  5.40 |    0.45 | 0.4110 |     - |     - |    1720 B |
|                  StringBuilderPattern |             6 | 695.56 ns |  9.781 ns |  7.636 ns | 691.86 ns |  5.22 |    0.10 | 0.3691 |     - |     - |    1544 B |
| StringInterpolationPatternSomeStrings |             6 | 696.50 ns | 12.156 ns | 10.151 ns | 693.39 ns |  5.22 |    0.12 | 0.4187 |     - |     - |    1752 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             7 | 149.72 ns |  1.855 ns |  1.735 ns | 149.03 ns |  1.00 |    0.00 | 0.1681 |     - |     - |     704 B |
|  StringInterpolationPatternAllStrings |             7 | 149.86 ns |  3.155 ns |  3.098 ns | 148.68 ns |  1.00 |    0.02 | 0.1681 |     - |     - |     704 B |
|        StringConcatPatternSomeStrings |             7 | 152.26 ns |  2.468 ns |  2.187 ns | 151.14 ns |  1.02 |    0.02 | 0.1681 |     - |     - |     704 B |
|                   StringFormatPattern |             7 | 705.50 ns |  8.410 ns |  7.866 ns | 703.90 ns |  4.71 |    0.07 | 0.4530 |     - |     - |    1896 B |
| StringInterpolationPatternSomeStrings |             7 | 756.95 ns | 10.426 ns |  8.706 ns | 756.80 ns |  5.06 |    0.08 | 0.4606 |     - |     - |    1928 B |
|                  StringBuilderPattern |             7 | 810.62 ns | 16.138 ns | 13.476 ns | 808.26 ns |  5.42 |    0.09 | 0.5426 |     - |     - |    2272 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|                   StringConcatPattern |             8 | 163.73 ns |  2.312 ns |  2.050 ns | 163.75 ns |  1.00 |    0.00 | 0.1874 |     - |     - |     784 B |
|        StringConcatPatternSomeStrings |             8 | 165.57 ns |  3.202 ns |  2.995 ns | 164.26 ns |  1.01 |    0.02 | 0.1874 |     - |     - |     784 B |
|  StringInterpolationPatternAllStrings |             8 | 172.09 ns |  4.307 ns |  4.608 ns | 171.82 ns |  1.05 |    0.04 | 0.1874 |     - |     - |     784 B |
|                   StringFormatPattern |             8 | 795.37 ns | 15.822 ns | 28.123 ns | 793.78 ns |  4.73 |    0.16 | 0.4930 |     - |     - |    2064 B |
|                  StringBuilderPattern |             8 | 854.73 ns | 10.298 ns |  9.632 ns | 853.85 ns |  5.22 |    0.09 | 0.5617 |     - |     - |    2352 B |
| StringInterpolationPatternSomeStrings |             8 | 856.39 ns | 10.137 ns |  8.986 ns | 855.95 ns |  5.23 |    0.10 | 0.5007 |     - |     - |    2096 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|  StringInterpolationPatternAllStrings |             9 | 185.90 ns |  1.958 ns |  1.529 ns | 185.97 ns |  0.99 |    0.02 | 0.2065 |     - |     - |     864 B |
|        StringConcatPatternSomeStrings |             9 | 187.67 ns |  3.794 ns |  3.549 ns | 186.72 ns |  1.00 |    0.02 | 0.2065 |     - |     - |     864 B |
|                   StringConcatPattern |             9 | 188.13 ns |  2.641 ns |  2.470 ns | 187.87 ns |  1.00 |    0.00 | 0.2065 |     - |     - |     864 B |
|                   StringFormatPattern |             9 | 870.01 ns | 26.997 ns | 22.544 ns | 860.43 ns |  4.63 |    0.11 | 0.5350 |     - |     - |    2240 B |
| StringInterpolationPatternSomeStrings |             9 | 890.27 ns | 15.950 ns | 14.140 ns | 889.36 ns |  4.73 |    0.08 | 0.5426 |     - |     - |    2272 B |
|                  StringBuilderPattern |             9 | 949.98 ns | 18.627 ns | 24.221 ns | 946.18 ns |  5.04 |    0.19 | 0.5798 |     - |     - |    2432 B |
|                                       |               |           |           |           |           |       |         |        |       |       |           |
|        StringConcatPatternSomeStrings |            10 | 203.52 ns |  2.822 ns |  2.502 ns | 203.70 ns |  1.00 |    0.03 | 0.2255 |     - |     - |     944 B |
|                   StringConcatPattern |            10 | 203.53 ns |  3.964 ns |  4.071 ns | 203.53 ns |  1.00 |    0.00 | 0.2255 |     - |     - |     944 B |
|  StringInterpolationPatternAllStrings |            10 | 208.19 ns |  3.989 ns |  3.536 ns | 208.30 ns |  1.02 |    0.03 | 0.2255 |     - |     - |     944 B |
| StringInterpolationPatternSomeStrings |            10 | 968.31 ns | 19.156 ns | 21.292 ns | 969.79 ns |  4.75 |    0.13 | 0.5836 |     - |     - |    2448 B |
|                  StringBuilderPattern |            10 | 972.94 ns | 18.747 ns | 20.837 ns | 972.65 ns |  4.79 |    0.14 | 0.5989 |     - |     - |    2512 B |
|                   StringFormatPattern |            10 | 977.35 ns | 19.642 ns | 34.914 ns | 983.06 ns |  4.71 |    0.22 | 0.5760 |     - |     - |    2416 B |
