#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SRC/Presentation/LABMS.WebApi/LABMS.WebApi.csproj", "SRC/Presentation/LABMS.WebApi/"]
COPY ["SRC/Core/LoggerService/LoggerService.csproj", "SRC/Core/LoggerService/"]
COPY ["SRC/Core/LABMS.Application/LABMS.Application.csproj", "SRC/Core/LABMS.Application/"]
COPY ["SRC/Core/LABMS.Domain/LABMS.Domain.csproj", "SRC/Core/LABMS.Domain/"]
COPY ["SRC/Infrastructure/LABMS.Persistence/LABMS.Persistence.csproj", "SRC/Infrastructure/LABMS.Persistence/"]
COPY ["SRC/Infrastructure/LABMS.ServiceContract/LABMS.ServiceContract.csproj", "SRC/Infrastructure/LABMS.ServiceContract/"]
COPY ["SRC/Infrastructure/LABMS.ServiceRepo/LABMS.ServiceRepository.csproj", "SRC/Infrastructure/LABMS.ServiceRepo/"]
COPY ["SRC/Presentation/LABMS.Controller/LABMS.Controller.csproj", "SRC/Presentation/LABMS.Controller/"]
RUN dotnet restore "SRC/Presentation/LABMS.WebApi/LABMS.WebApi.csproj"
COPY . .
WORKDIR "/src/SRC/Presentation/LABMS.WebApi"
RUN dotnet build "LABMS.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LABMS.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LABMS.WebApi.dll"]