dotnet ef migrations add Initial -c ITDeveloperDbContext -v -s src/ITDeveloper.Mvc -p src/ITDeveloper.Data
dotnet ef database update -p src/ITDeveloper.Data -s src/ITDeveloper.Mvc



 /Users/gilmaralcantara/work/courses/udemy_dotnet/ITDeveloper/src/ITDeveloper.Mvc/obj/dotnet-aspnet-codegenerator --project "/Users/gilmaralcantara/work/courses/udemy_dotnet/ITDeveloper/src/ITDeveloper.Mvc/ITDeveloper.Mvc.csproj" controller --model Patient --dataContext ITDeveloperDbContext  --referenceScriptLibraries   -name PatientController --no-build -outDir "/Users/gilmaralcantara/work/courses/udemy_dotnet/ITDeveloper/src/ITDeveloper.Mvc/Controllers" --controllerNamespace ITDeveloper.Mvc.Controllers
 