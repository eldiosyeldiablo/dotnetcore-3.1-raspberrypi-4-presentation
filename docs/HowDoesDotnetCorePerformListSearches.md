# Raspberry Pi 4 Model B - DotNet Core Performance List Search

For this performance test we are going to look at a series of simple List<string> data sets and use the
BenchmarkDotNet nuget package to test several of the DotNet Api's search capabilities.
For fun we will also test a method I wrote that combines Parallel.ForEach with hand rolled chunking.
I wrote this method called with the assumption that I would not do better than Microsoft's dotnet core implementation of
Parallel.ForEach. I did write several iterations of this and I even managed to waste a good amount of time by accidently breaking the logic on the out of bounds condition and on end of list condition.
I am sort of happy to say that given an hour of time I failed to do better than the Microsoft engineers did.

## Run the tests

dotnet build -c Release -r linux-arm
dotnet run -c Release -r linux-arm --project benchmarkFastishFind


### Test 1 (5 threads, 10 seconds)

This simple test at 5 threads over 10 seconds resulted in 3,332 requests per second with zero failed results. The average response time was 0.94 milliseconds with a max response time of 40 milliseconds.

### Test 2 (10 threads, 60 seconds)

- 6,149 req/sec
- 0 failed
- 368,930 total requests
- 1.06 ms average
- 42 ms max

### Test 3 (15 threads, 60 seconds)

- 6,689 req/sec
- 0 failed
- 401,318 total requests
- 1.67 ms average
- 74 ms max

### Test 4 (100 threads, 120 seconds)

Below you can see performance has degregatted.

- 1,986 req/sec
- 0 failed
- 238,275 total requests
- 46.94 ms average
- 955 ms max
