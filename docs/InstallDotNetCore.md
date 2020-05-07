# Raspberry Pi 4 Model B - DotNet Core setup

My last article described how easy it is to compile a dotnet core 3.1 application and publish it to your Raspberry Pi. While that works what if you want to code, compile and run your shiny new code directly on your Raspberry Pi?

In this article I will document how I installed dotnet core 3.1 on my new Raspberry Pi 4.

This article assumes you already have a Raspberry Pi configured, running and on your network and the dotnet core 3.1 sdk is installed on your machine.

Note that some of these instructions will be performed from a Windows 10 machine. If your machine is not a windows machine then some steps will be different.

## Update Prerequisites

Type the following commands:

```text
sudo apt-get update
sudo apt-get install curl libunwind8 gettext apt-transport-https
```

## Download dotnet core sdk

From your Windows machine,

1. Open the dotnet sdk download link [here](https://dotnet.microsoft.com/download/dotnet-core/3.1)
2. Look for the sdk link for Linux.
3. Select ARM32
4. Ignore the download that is started. You can cancel it.
5. Look for the "Direct link". At the time of this writing for dotnet core 3.1 the direct link is: [here](https://download.visualstudio.microsoft.com/download/pr/67766a96-eb8c-4cd2-bca4-ea63d2cc115c/7bf13840aa2ed88793b7315d5e0d74e6/dotnet-sdk-3.1.100-linux-arm.tar.gz)
6. Go back one page and repeat for the runtime. The direct link is: [here](https://download.visualstudio.microsoft.com/download/pr/8c839c0e-a5ae-4254-8d8b-c012528fe601/c147e26bad68f97eacc287a71e01331d/aspnetcore-runtime-3.1.0-linux-arm.tar.gz)

Remote into your Raspberry Pi,

1. Navigate to a location where you would like to download the sdk and runtime tar files.
2. Type:

```text
wget https://download.visualstudio.microsoft.com/download/pr/67766a96-eb8c-4cd2-bca4-ea63d2cc115c/7bf13840aa2ed88793b7315d5e0d74e6/dotnet-sdk-3.1.100-linux-arm.tar.gz
wget https://download.visualstudio.microsoft.com/download/pr/8c839c0e-a5ae-4254-8d8b-c012528fe601/c147e26bad68f97eacc287a71e01331d/aspnetcore-runtime-3.1.0-linux-arm.tar.gz
```

3. Make the installation directory. Type: ```mkdir -p $HOME/dotnet```
4. Untar the sdk. Type: ```tar zxvf dotnet-sdk-3.1.100-linux-arm.tar.gz -C $HOME/dotnet```
5. Untar the runtime. Type: ```tar zxvf aspnetcore-runtime-3.1.100-linux-arm.tar.gz -C $HOME/dotnet```
6. configure your current connection/shell to have dotnet skd and runtime in the path Type:

```
export DOTNET_ROOT=$HOME/dotnet 
export PATH=$PATH:$HOME/dotnet
```

Note: if you want to permanently keep the above in your path edit the .profile and add the following lines
```
DOTNET_ROOT=$HOME/dotnet 
PATH=$PATH:$HOME/dotnet
```

7. Verify dotnet can be executed by typing: ```dotnet --info```

## Create sample application

1. Navigate to where you want your sample application to be created at
2. Type: ```mkdir helloworld```
3. Type: ```cd helloworld```
4. Run: ```dotnet new console```
5. Compile the new console application: ```dotnet build -r linux-arm```
6. Run your awesome console application: ```dotnet run -r linux-arm```

Celebrate! ![Celebrate](https://gph.is/1sEAZgl)