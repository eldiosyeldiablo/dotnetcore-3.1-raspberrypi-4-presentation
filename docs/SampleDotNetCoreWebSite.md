# Raspberry Pi 4 Model B - DotNet Core Sample Website

This article assumes you already have a Raspberry Pi configured, running and on your network and the dotnet core 3.1 sdk is installed on your machine.

## Create sample dotnet core web site

Type the following commands to create the sample site, build and run it:

``` text
mkdir helloworldwebsite
dotnet new webapp
dotnet build -r linux-arm
dotnet run -r linux-arm
```

Note that by default the new site will run and listen on localhost on port 5000 (http) and 5001 (https).

If you want test out the website from another machine you will need to edit the Properties/launchSettings.json file. One option is to replace localhost with * for the applicationUrl.

## Playing with SSL

By default the dotnet template is configured to redirect the clients to https. If you want to turn this setting off during your troubleshooting or local development follow these steps:

1. Type: ```vi Startup.cs```
2. Comment out ```app.UseHttpsRedirection();```
3. Save and exit the text editor.
4. Recompile and run the application.

## Exercise

Now that you know how to create a sample dotnet core web site using the command line new command let's explore the new command.

Type: ```dotnet new --help```

Using the information shown with --help create a new web api project and get it running on your own.

Celebrate! ![Celebrate](https://gph.is/1sEAZgl)