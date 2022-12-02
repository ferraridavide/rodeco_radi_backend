#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RodecoRADI.WebAPI/RodecoRADI.WebAPI.csproj", "RodecoRADI.WebAPI/"]
COPY ["RodecoRADI.Core/RodecoRADI.Core.csproj", "RodecoRADI.Core/"]
RUN dotnet restore "RodecoRADI.WebAPI/RodecoRADI.WebAPI.csproj"
COPY . .
WORKDIR "/src/RodecoRADI.WebAPI"
RUN dotnet build "RodecoRADI.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RodecoRADI.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RodecoRADI.WebAPI.dll"]