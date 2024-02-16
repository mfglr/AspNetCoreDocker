FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /App
COPY bin/Release/net7.0/publish app/
ENTRYPOINT ["dotnet","AspNetCoreDocker.Console.dll"]