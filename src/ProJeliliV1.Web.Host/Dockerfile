FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/ProJeliliV1.Web.Host/ProJeliliV1.Web.Host.csproj", "src/ProJeliliV1.Web.Host/"]
COPY ["src/ProJeliliV1.Web.Core/ProJeliliV1.Web.Core.csproj", "src/ProJeliliV1.Web.Core/"]
COPY ["src/ProJeliliV1.Application/ProJeliliV1.Application.csproj", "src/ProJeliliV1.Application/"]
COPY ["src/ProJeliliV1.Core/ProJeliliV1.Core.csproj", "src/ProJeliliV1.Core/"]
COPY ["src/ProJeliliV1.EntityFrameworkCore/ProJeliliV1.EntityFrameworkCore.csproj", "src/ProJeliliV1.EntityFrameworkCore/"]
WORKDIR "/src/src/ProJeliliV1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ProJeliliV1.Web.Host", "src/ProJeliliV1.Web.Host"]
COPY ["src/ProJeliliV1.Web.Core", "src/ProJeliliV1.Web.Core"]
COPY ["src/ProJeliliV1.Application", "src/ProJeliliV1.Application"]
COPY ["src/ProJeliliV1.Core", "src/ProJeliliV1.Core"]
COPY ["src/ProJeliliV1.EntityFrameworkCore", "src/ProJeliliV1.EntityFrameworkCore"]
WORKDIR "/src/src/ProJeliliV1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ProJeliliV1.Web.Host.dll"]
