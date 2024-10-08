# API Automation Framework (C#, RestSharp, NUnit, Allure, NLog)

This project is an API automation framework built using .NET 8.0, NUnit(for testing), RestSharp(for API calls), NLog(for logging) and Allure(for reporting). It contains tests for a RESTful API.

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/vs/) (or any compatible IDE)

Project has a dependancy with the following nuGet packages.

Allure.NUnit Version = 2.12.1 Microsoft.Extensions.Configuration.Json Version = 9.0.0-rc.1.24431.7
Microsoft.NET.Test.Sdk Version = 17.11.1 Newtonsoft.Json Version = 13.0.3 NLog Version = 5.3.4 NLog.Extensions.Logging Version = 5.3.14 NUnit3TestAdapter Version = 4.6.0 RestSharp Version = 112.1.0 System.Configuration.ConfigurationManager Version = 9.0.0-rc.1.24431.7

## Set Up

You need to install Allure to generate the report using command line.

```
Set-ExecutionPolicy RemoteSigned -Scope CurrentUser iwr -useb get.scoop.sh | iex
```
```
scoop install allure
```
In nlog.config file you need to change the log file location according to your project path.
```
<target xsi:type="File" name="logfile" fileName="D:\AUTOMATION\C#\latest3\AmusedAutomation\logs\Logs.log"
```

### 1. How to run the Test suit

#### 1. In Visual Studio
- CLick on View
- Select Test Explorer
- Select Run button
- Select Run All Tests In View

#### 2. In command line

##### 2.1. Clone the Repository

Clone the repository to your local machine using the following command:

```bash
git clone git@github.com:jefly/AutomationC-RestSharp.git
```

##### 2.2. Navigate to the Project Directory
```bash
cd AmusedAutomation
```

##### 2.3. Build the project 
```bash
dotnet build
```

##### 2.4. Run the Automation Suite 
```bash
dotnet test
```

#### 2.5. Generate the report 
```bash
allure generate --clean reports
```

#### 2.6. Open the report 
```bash
allure serve reports
```
