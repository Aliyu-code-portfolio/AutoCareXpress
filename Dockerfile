#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/backend/presentation/ACX.WebAPI/ACX.WebAPI.csproj", "src/backend/presentation/ACX.WebAPI/"]
COPY ["src/backend/core/ACX.LoggerService/ACX.LoggerService.csproj", "src/backend/core/ACX.LoggerService/"]
COPY ["src/backend/core/ACX.Application/ACX.Application.csproj", "src/backend/core/ACX.Application/"]
COPY ["src/backend/infrastructure/ACX.Shared/ACX.Shared.csproj", "src/backend/infrastructure/ACX.Shared/"]
COPY ["src/backend/core/ACX.Domain/ACX.Domain.csproj", "src/backend/core/ACX.Domain/"]
COPY ["src/backend/infrastructure/ACX.Persistence/ACX.Persistence.csproj", "src/backend/infrastructure/ACX.Persistence/"]
COPY ["src/backend/infrastructure/ACX.Service/ACX.Service.csproj", "src/backend/infrastructure/ACX.Service/"]
COPY ["src/backend/infrastructure/ACX.ServiceContract/ACX.ServiceContract.csproj", "src/backend/infrastructure/ACX.ServiceContract/"]
COPY ["src/backend/presentation/ACX.EndsPoint/ACX.EndsPoint.csproj", "src/backend/presentation/ACX.EndsPoint/"]
RUN dotnet restore "src/backend/presentation/ACX.WebAPI/ACX.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/backend/presentation/ACX.WebAPI"
RUN dotnet build "ACX.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ACX.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ACX.WebAPI.dll"]