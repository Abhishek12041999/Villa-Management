### Villa Management

### Description
•	Developed a villa booking website featuring advanced functionalities for customers to view resort villa rooms and make bookings using credit cards.
•	Built an admin dashboard allowing administrators to manage bookings, perform check-in/check-out, view summary reports, and oversee villa management via a custom Content Management System.


### Installation
1. Clone the Repository
• git clone https://github.com/yourusername/your-repo-name.git
• cd your-repo-name

2. Open the Project
• Launch Visual Studio 2022.
• Open the folder containing your cloned repository.

3. Restore NuGet Packages
• Open the Solution Explorer.
• Right-click on the solution and select "Restore NuGet Packages" to download all the necessary dependencies.

4. Set Up the Database
• Open the appsettings.json file in the API project.
• Configure the connection string to point to your local database.
json
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=YourDbName;Trusted_Connection=True;MultipleActiveResultSets=true"
}

5. Apply Migrations
• Open the Package Manager Console in Visual Studio.
• Run the following commands:
cd src/Infrastructure
dotnet ef database update

6. Build the Solution
• Right-click on the solution in Solution Explorer and select "Build Solution".

7. Run the Application
• Set the API project as the startup project.
• Press F5 to run the application.

