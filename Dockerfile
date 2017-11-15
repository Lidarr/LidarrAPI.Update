FROM microsoft/dotnet:2.0-sdk
WORKDIR /app

# copy everything else and build
COPY LidarrAPI/* ./
RUN dotnet publish -c Release -o out
RUN dotnet restore

COPY docker-entrypoint.sh ./

#ENTRYPOINT ["dotnet", "out/LidarrAPI.dll"]
ENTRYPOINT ["./docker-entrypoint.sh"]