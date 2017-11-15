FROM microsoft/dotnet:2.0-sdk
WORKDIR /app

# copy everything else and build
COPY LidarrAPI/* ./
RUN dotnet publish -c Release -o out
RUN dotnet restore

ENTRYPOINT ["dotnet", "out/LidarrAPI.dll"]
