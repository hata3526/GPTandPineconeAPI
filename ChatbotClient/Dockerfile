# Prepare build environment
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src/

# Copy source files into build environment
COPY ./ChatbotClient/ ./ChatbotClient

# Restore
RUN dotnet restore ChatbotClient

# Release build and publish
RUN dotnet build ChatbotClient -c Release -o /app/build
RUN dotnet publish ChatbotClient -c Release -o /app/publish

# Run Nginx
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/wwwroot .
COPY ./ChatbotClient/nginx.conf /etc/nginx/nginx.conf