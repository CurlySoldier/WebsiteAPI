﻿FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WebsiteAPI.csproj", "./"]
RUN dotnet restore "WebsiteAPI.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "WebsiteAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebsiteAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebsiteAPI.dll"]
