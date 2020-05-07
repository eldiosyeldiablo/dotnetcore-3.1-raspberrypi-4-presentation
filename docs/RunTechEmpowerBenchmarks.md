# TechEmpower Benchmarks

TechEmpower Benchmarks is a series of benchmark tests that exercise frameworks, languages, libaries, etc. on cloud and physical machines to that developers can review and compare to make informed decisions.

You can read more about it on their website [here](https://www.techempower.com/benchmarks/).

# Download TechEmpower Benchmarks

Pick a new location where you want to download/clone their source code and testing libraries.

```text
mkdir benchmarks
cd benchmarks
git clone https://github.com/TechEmpower/FrameworkBenchmarks.git
git checkout 4ebc75cbb3c3bb0c700799e2192ef470801ee924
```

The commit I ran this test on was: 4ebc75cbb3c3bb0c700799e2192ef470801ee924
this will run against aspnetcore sdk:3.1.101

FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101

# Test the framework and your machine's configurations, etc

```test
cd FrameworkBenchmarks
./tfb --mode verify --test gemini
```

# Run spot/limited performance tests on aspcore


For this test we care about "aspcore".

-- Information about the various tests
https://github.com/TechEmpower/FrameworkBenchmarks/wiki/Project-Information-Framework-Tests-Overview

https://github.com/TechEmpower/FrameworkBenchmarks/wiki/Development-Testing-and-Debugging

--Get the current list of tests
```text
./tfb --list-tests
```

Run the default benchmark for the aspcore test
```text
./tfb --test aspcore
```

The console will show the results but ./results will have the results in files that you can review and parse in detail

This file can be visualized using the instructions here: Data Visualization
If you have a results.json file that you would like to visualize, you can do that here. You can also attach a runid parameter to that url where runid is a run listed on tfb-status like so: https://www.techempower.com/benchmarks/#section=test&runid=fd07b64e-47ce-411e-8b9b-b13368e988c6

The direct link to the parser is located here: https://www.techempower.com/benchmarks/#section=test

# Run true load test

To run a true load test using TechEmpower you will need 3 dedicated machines as described [here](https://github.com/TechEmpower/FrameworkBenchmarks/wiki/Benchmarking-Getting-Started#benchmark-suite-deployment)

From their current page's documentation:
Prerequisites

Before you get started, the following are the steps you must take on each machine (App, Database, Client) to run the benchmarking suite:

1. Docker installed (you can verify this via docker run hello-world)
2. /lib/systemd/system/docker.service needs ExecStart to have an additional flag: -H [machine's ip]:2375
3. sudo systemctl daemon-reload
4. sudo service docker restart (you can verify this via sudo service docker status and see the newly added -H [machine's ip]:2375 flag)

Since the tests can run for several hours, it helps to set everything up so that once the tests are running, you can leave the machines unattended and don't need to be around to enter ssh or sudo passwords.

Running the Benchmarking Suite

Let us assume make some assumptions for the example:

1. You cloned the repository into the home directory of user techempower
2. Your App machine has the IP 10.0.0.1
3. Your Database machine has the IP 10.0.0.2
4. Your Client machine has the IP 10.0.0.3

The following command, given the prerequisites here, would run a benchmark for all the tests in the codebase.

```text
docker run \
  --network=host \
  --mount type=bind,source=/home/techempower/FrameworkBenchmarks,target=/FrameworkBenchmarks \
  techempower/tfb \
  --server-host 10.0.0.1 \
  --database-host 10.0.0.2 \
  --client-host 10.0.0.3 \
  --network-mode host \
  --quiet
```