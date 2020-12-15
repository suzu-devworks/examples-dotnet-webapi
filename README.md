# examples-dotnet-webapi

## ASP.NET Core WebAPI

### The way to the present

```shell
git clone https://github.com/suzu-devworks/examples-dotnet-webapi.git

dotnet new sln -o .
dotnet new webapi -o src/ExamplesWebApi
dotnet sln add src/ExamplesWebApi/ExamplesWebApi.csproj

## clear newline(CR).
find . -type d -name '.git' -prune -o -type f -print | xargs sed -i 's/\r//g'
## clear BOM(UTF-8).
find . -type d -name '.git' -prune -o -type f -print | xargs sed -i -s -e '1s/^\xef\xbb\xbf//'

## Add Packages
dotnet add src/ExamplesWebApi/ package NLog.Extensions.Logging

## Already in use.
##dotnet add src/ExamplesWebApi/ package Swashbuckle.AspNetCore

dotnet clean
dotnet restore
dotnet run --project src/ExamplesWebApi
```

### Referenced.

* https://docs.microsoft.com/ja-jp/aspnet/core/fundamentals/localization?view=aspnetcore-5.0
* https://docs.microsoft.com/ja-jp/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio

