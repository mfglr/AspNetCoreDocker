FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish AspNetCoreDocker.API.csproj -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/publish .

RUN mkdir -p certificates
COPY certificates/aspnetapp.pfx certificates

ENV ASPNETCORE_URLS="https://+;http://+"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/app/certificates/aspnetapp.pfx
ENV ASPNETCORE_HTTPS_PORTS=5001
ENTRYPOINT ["dotnet", "AspNetCoreDocker.API.dll"]