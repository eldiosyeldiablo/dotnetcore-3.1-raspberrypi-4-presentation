# Raspberry Pi 4 Model B - Create and Publish DotNet Core App

In this article I will document how I configured my new Raspberry Pi to run a simple dotnet core 3.1 app.

This article assumes you already have a Raspberry Pi configured, running and on your network and the dotnet core 3.1 sdk is installed on your machine.

## Update Prerequisites

Type the following commands:

```text
sudo apt-get update
sudo apt-get install curl libunwind8 gettext apt-transport-https
```

## Create sample application

1. From your computer open command prompt
2. Navigate to where you want your sample application to be created at
3. Type: ```mkdir helloworld```
4. Type: ```cd helloworld```
5. Run: ```dotnet new console```
6. Publish the application for linux: ```dotnet publish -r linux-arm```
7. Change directory into the published location. Type: ```cd bin\Debug\netcoreapp3.1\linux-arm```
8. Prepare the published directory for copying. Type: ```tar cf publish.tar publish```
9. Copy the files to your Raspberry Pi with the tool(s) of your choice.

## Remote back into your Raspberry Pi

1. Change directory to where you placed the tar file.
2. Untar the file. Type: ```tar xvf publish.tar```
3. Change directory into publish directory
4. Grant execute rights on the executable: ```chmod 755 ./helloworld```
5. Run it! ```./helloworld```

Celebrate! ![Celebrate](https://gph.is/1GLI4QV)

Microsoft Raspberry Pi documentation [Here](https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md#linux)
