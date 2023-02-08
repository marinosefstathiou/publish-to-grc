FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
LABEL org.opencontainers.image.source="https://github.com/marinosefstathiou/publish-to-grc"
WORKDIR /app
EXPOSE 5150

ENV ASPNETCORE_URLS=http://+:5150

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["KubeTestAPI.csproj", "./"]
RUN dotnet restore "KubeTestAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "KubeTestAPI.csproj" -c Release -o /app/build

# run migrations
RUN dotnet ef database update

FROM build AS publish
RUN dotnet publish "KubeTestAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KubeTestAPI.dll"]
