#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SportApp.ProductsServices.Api/SportApp.ProductsServices.Api.csproj", "SportApp.ProductsServices.Api/"]
COPY ["SportApp.ProductsServices.Application/SportApp.ProductsServices.Application.csproj", "SportApp.ProductsServices.Application/"]
COPY ["SportApp.ProductsServices.Domain/SportApp.ProductsServices.Domain.csproj", "SportApp.ProductsServices.Domain/"]
COPY ["SportApp.ProductsServices.Infrastructure/SportApp.ProductsServices.Infrastructure.csproj", "SportApp.ProductsServices.Infrastructure/"]
RUN dotnet restore "./SportApp.ProductsServices.Api/SportApp.ProductsServices.Api.csproj"
COPY . .
WORKDIR "/src/SportApp.ProductsServices.Api"
RUN dotnet build "./SportApp.ProductsServices.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SportApp.ProductsServices.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SportApp.ProductsServices.Api.dll"]