TollApp
Project Setup
Prerequisites
•	Visual Studio 2022
•	.NET 8 SDK
•	Internet connection for downloading dependencies
Steps to Set Up the Project
1.	Clone the Repository
2.	Open the Project in Visual Studio
•	Launch Visual Studio 2022.
•	Open the solution file TollApp.sln.
3.	Restore NuGet Packages
•	Visual Studio should automatically restore the required NuGet packages. If not, go to Tools > NuGet Package Manager > Package Manager Console and run:
     Update-Package -reinstall
4.	Set Up the Database Using Entity Framework Core
•	Open appsettings.json in the project.
•	Update the connection string to point to your SQL Server instance and desired database name:
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your_server_name;Database=TollAppDB;Trusted_Connection=True;"
       }
     }
5.	Add Migration and Update Database
•	Open Package Manager Console and run the following commands to add a migration and update the database:
     Add-Migration InitialCreate
     Update-Database
(Note Check for the Migration if it already exists than no need to run 'Add-Migration InitialCreate')
6.	Build the Solution
•	Press Ctrl+Shift+B to build the solution.
7.	Run the Application
•	Press F5 to run the application.
Features
Toll Entry
•	Form for Toll Entry: Allows users to enter toll details such as interchange name, date, and vehicle number.
•	Validation: Ensures that all required fields are filled and the vehicle number follows the specified format.
Toll Exit
•	Form for Toll Exit: Allows users to record toll exit details.
•	Calculate Toll: Calculates the toll based on distance, base rate, distance rate, weekend rate, and discount rate.
•	Post Exit Toll: Sends the toll exit details to a server endpoint and handles the response.
User Interface
•	Fixed Form Size: The forms are non-resizable to maintain a consistent user experience.
•	Customizable Buttons and Labels: The entry form has customizable button text and title labels.
Error Handling
•	Exception Handling: Catches and displays exceptions that occur during server communication.
Asynchronous Operations
•	Async/Await: Uses asynchronous methods for server communication to keep the UI responsive.
Serialization
•	JSON Serialization: Serializes and deserializes toll data to and from JSON format for server communication.
Repositories
    Created All the required repositories for Management of CRUD operations for All the entities.
Authentication
    Used an API Key for Client Authentication.
Additional Information
•	HttpClientInstance: A singleton instance of HttpClient used for making HTTP requests.
•	StringConstants: Contains URL constants for server endpoints.
•	TollEntryForm: A user control for entering toll details.
•	RTOExit: A model representing the toll exit details.
