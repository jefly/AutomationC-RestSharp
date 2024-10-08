# API Automation Framework (C#, RestSharp, NUnit, Allure, NLog)

This project is an API automation framework built using .NET 8.0, NUnit(for testing), RestSharp(for API calls), NLog(for logging) and Allure(for reporting). It contains tests for a RESTful API.

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/vs/) (or any compatible IDE)

## Getting Started

Follow these steps to set up and run the API automation framework:

### 1. Clone the Repository

Clone the repository to your local machine using the following command:

```bash
git clone git@github.com:jefly/AutomationC-RestSharp.git
```

### 2. Navigate to the Project Directory
```bash
cd AmusedAutomation
```

### 3. Build the project 
```bash
dotnet build
```

### 4. Run the Automation Suite 
```bash
dotnet test
```

### 5. Generate the report 
```bash
allure generate --clean reports
```

### 6. Open the report 
```bash
allure serve reports
```
