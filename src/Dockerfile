FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["*.sln", "./"]
COPY ["Application/Project.Wta.Management.Cars.Api.csproj", "Application/"]
COPY ["CrossCutting.Configuration/Project.Wta.Management.Cars.CrossCutting.Configuration.csproj", "CrossCutting.Configuration/"]
COPY ["Domain/Project.Wta.Management.Cars.Domain.csproj", "Domain/"]
COPY ["Infrastructure.Data/Project.Wta.Management.Cars.Infrastructure.Data.csproj", "Infrastructure.Data/"]

RUN dotnet restore "Application/Project.Wta.Management.Cars.Api.csproj"
COPY . . 
WORKDIR "/src/Application"

RUN mv appsettings.Docker.json appsettings.json
RUN dotnet build "Project.Wta.Management.Cars.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project.Wta.Management.Cars.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/CipherString = DEFAULT@SECLEVEL=2/CipherString = DEFAULT@SECLEVEL=1/g' /etc/ssl/openssl.cnf
ENTRYPOINT ["dotnet", "Project.Wta.Management.Cars.Api.dll"]

