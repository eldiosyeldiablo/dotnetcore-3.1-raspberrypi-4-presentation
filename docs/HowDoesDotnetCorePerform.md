# Raspberry Pi 4 Model B - DotNet Core Performance

This article assumes you already have a Raspberry Pi configured, running and on your network and the dotnet core 3.1 sdk is installed on your machine.

All of these tests were performed with a direct ethernet connection between my laptop and the Raspberry Pi. No additional devices like monitors, etc were connected to the Raspberry Pi.

Also note that these performance tests were performed with default code that Microsoft's tooling creates. No tuning has been done.

## Create and configure web api for testing

Create a simple new api project by typing the following:

```text
mkdir webapiPerformanceTest
dotnet new webapi
```

Since we are going to be doing load test from a different machine we need to edit the ip address that the site will listen on.

Edit the Properties/launchSettings.json file and replace localhost with * for the applicationUrl.

## Prepare for load testing

The load testing tool I will use is Websurge which can be found [here](https://websurge.west-wind.com/download.aspx)

Websurge requires that you edit the robots.txt file or place an empty file called websurge-allow.txt in wwwroot. If wwwroot does not exist then create it.

Edit the Startup.cs file and add ```app.UseStaticFiles();``` before ```app.UseRouting();```

Finally build, compile and run the application.

## Run the tests

Configure websurge with http GET of [](http://192.168.1.200:5000/weatherforecast). Make sure your turn off the progress info so that your test bed machine that is running websurge can perform more load on the Raspberry Pi.

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

Below you can see performance has degraded.

- 1,986 req/sec
- 0 failed
- 238,275 total requests
- 46.94 ms average
- 955 ms max


# What about testing at a lower level?
Let's see how it performs for searching on a list [here](./HowDoesDotnetCorePerformListSearches.md)
