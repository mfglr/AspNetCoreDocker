FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish AspNetCoreDocker.API.csproj -c Release -o out

RUN mkdir -p certificates
COPY certificates/aspnetapp.pfx certificates

WORKDIR out
ENTRYPOINT ["dotnet", "AspNetCoreDocker.API.dll"]
