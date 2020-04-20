# RUN

dotnet run --project src/ITDeveloper.Mvc

# DB Migrate

dotnet ef migrations add -c ITDeveloperDbContext -v -s src/ITDeveloper.Mvc -p src/ITDeveloper.Data Initial
dotnet ef database update -p src/ITDeveloper.Data -s src/ITDeveloper.Mvc

# Generate Scarfold

./tools/dotnet-aspnet-codegenerator --project src/ITDeveloper.Mvc/ controller --model Patient --dataContext ITDeveloperDbContext --referenceScriptLibraries -name PatientController --no-build -outDir "/Users/gilmaralcantara/work/courses/udemy_dotnet/ITDeveloper/src/ITDeveloper.Mvc/Controller" --controllerNamespace ITDeveloper.Mvc.Controllers
