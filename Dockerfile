FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
LABEL org.opencontainers.image.source="https://github.com/marinosefstathiou/publish-to-grc"
WORKDIR /app
EXPOSE 5150

ENV ASPNETCORE_URLS=http://+:5150

# NEW
# Install the .NET Core SDK
#RUN apt-get update && apt-get install -y wget
#RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
#RUN dpkg -i packages-microsoft-prod.deb
#RUN apt-get update && apt-get install -y dotnet-sdk-6.0

# NEW
# Install the Entity Framework Core CLI tools
#RUN dotnet tool install --global dotnet-ef

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

# NEW
#RUN dotnet restore

FROM build AS publish
RUN dotnet publish "KubeTestAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KubeTestAPI.dll"]
