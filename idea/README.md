# Hublsoft
This solution contains EF migrations.
For further info please see https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application
To enable, 
1. change appsettings.json to point to a valid SQL server
 "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-Hublsoft.Task.Web-610C59CF-6A1D-4AD4-9C18-A8640E273139;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  
  2. Run Update-database -context ApplicationDbContext
  
  
