#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["API-Template.Web/API-Template.Web.csproj", "API-Template.Web/"]
COPY ["API-Template.Infrastructure/API-Template.Infrastructure.csproj", "API-Template.Infrastructure/"]
COPY ["API-Template.Core/API-Template.Core.csproj", "API-Template.Core/"]
RUN dotnet restore "API-Template.Web/API-Template.Web.csproj"
COPY . .
WORKDIR "/src/API-Template.Web"
RUN dotnet build "API-Template.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API-Template.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API-Template.Web.dll"]