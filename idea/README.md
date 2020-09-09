# Hublsoft

## Initialising the databse

This solution contains EF migrations.
For further info please see https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application
To enable, first change appsettings.json to point to a valid SQL server
 "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-Hublsoft.Task.Web-610C59CF-6A1D-4AD4-9C18-A8640E273139;Trusted_Connection=True;MultipleActiveResultSets=true"
  },

### Visual Studio Pro / Powershell
Within VS Pro, using e.g. the Package Manager console (Powershell), you can execute the 'Update-database' command to initialise (and upgrade) the database:

```powershell
Update-database --context ApplicationDbContext
```
### Cross-platform / command line
If you are working without powershell, just use the normal `dotnet` commands for entity framework:

```cmd
dotnet ef database update --context ApplicationDbContext
```
