# C# Library
This repo is intended to be used as a reference for furure coding necessities.
![Alt Text](./assets/Csharp.gif)

## Tutorial
Following [this](https://www.youtube.com/watch?v=wxznTygnRfQ) tutorial from Bro Code
- **TIME:** 1:18:31
- **LESSON:** About to start on some examples of using the code all together

## Notes
- So far it seems super similar to C++ or C but with more {}s
- It's C++ and Java 

## Downloading/Configuring C# on Linux (PopOS/Ubuntu)
1. Open a terminal and download base packages:
```sh
sudo apt update
sudo apt install -y wget apt-transport-https software-properties-common
```
2. Add microsoft signing key:
```sh
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
```
3. Install the .NET SDK for development:
```sh
sudo apt update
sudo apt install -y dotnet-sdk-9.0
```
4. Verify it works:
```sh
dotnet --version
```
5. Open VS Code and download the 'C# Dev Kit'
6. Environment created and ready

## Making a Program
- Each time you're most likely going to need to follow this to get a file running
1. Make a new folder to house your project, app, main file, etc.
2. Get the .NET environment running, init project:
```sh
dotnet new console
```
3. Put your code into the Program.cs file
4. Compile and run:
```sh
dotnet run
```