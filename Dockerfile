FROM microsoft/dotnet:2.0-sdk
WORKDIR /app

# copy everything else and build
COPY LidarrAPI/* ./
COPY docker-services/LidarrAPI/docker-entrypoint.sh ./

# There are some extra directories that cause issues for a build if they exist, remove them
RUN rm -fr -- bin
RUN rm -fr -- obj
RUN rm -fr -- Properties
RUN rm -fr -- Debug

# Run needed things on build
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Docker Entry
ENTRYPOINT ["./docker-entrypoint.sh"]