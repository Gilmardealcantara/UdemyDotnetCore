dotnet ef migrations add Initial -c ITDeveloperDbContext -v -s src/ITDeveloper.Mvc -p src/ITDeveloper.Data
dotnet ef database update -p src/ITDeveloper.Data -s src/ITDeveloper.Mvc
