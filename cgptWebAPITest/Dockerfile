# NOTE: Context directory must be the parent one in order to refer all projects in use.
# See https://www.jamestharpe.com/docker-include-files-outside-build-context/

# Prepare base environment
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app/

# Prepare build environment
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src/

# Copy source files into build environment
COPY ./cgptWebAPITest/ ./cgptWebAPITest


# Restore
RUN dotnet restore cgptWebAPITest

# Release build and publish
RUN dotnet build cgptWebAPITest -c Release -o /app/build
RUN dotnet publish cgptWebAPITest -c Release -o /app/publish -p:UseAppHost=false

# Run the host server
FROM base AS final
WORKDIR /app/
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "cgptWebAPITest.dll"]