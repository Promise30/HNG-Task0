# HNG-Task
## PublicAPIService

## Description
This is a simple ASP.NET Core Web API that provides basic information such as email, current date and time in ISO 8601 format, and a GitHub URL. This project is part of the HNG internship tasks.

## Setup Instructions

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022 or any other C# IDE

### Running the Project Locally
1. Clone the repository:
    <p><code>git clone https://github.com/Promise30/HNG-Task0.git</code></p>

2. Navigate to the project directory:
   <p><code>cd HNG-Task0-PublicAPIService</code></p>
4. Open the project in Visual Studio 2022.
5. Restore the dependencies and build the project.
6. Run the project using Visual Studio or the .NET CLI:
   <p><code>dotnet run</code></p>


## API Documentation

### Endpoint URL
- `GET /api/basic-info`

### Request
- Method: `GET`
- URL: `/api/basic-info`

### Response
- Status: `200 OK`
- Content-Type: `application/json`
- Body:
<p><code>
    {
        "email": "promiseadeagbo@gmail.com",
        "current_dateTime": "2025-01-30T09:30:00Z",
        "github_url": "https://github.com/Promise30/HNG-Task0"
    }
</code></p>

    

### Example Usage
To get the basic information, send a `GET` request to the following URL:
<p><code>curl -X GET "http://localhost:5000/api/basic-info"</code></p>


## Additional Information
For more information, please visit [HNG](https://hng.tech/hire/csharp-developers).

    
