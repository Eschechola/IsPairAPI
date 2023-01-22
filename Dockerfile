FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
EXPOSE 80
EXPOSE 443
WORKDIR /ispairapi
COPY ["IsPairAPI/IsPairAPI.csproj", "IsPairAPI/"]

RUN dotnet restore "IsPairAPI/IsPairAPI.csproj"

WORKDIR /ispairapi/build
COPY . .
RUN dotnet build "IsPairAPI/IsPairAPI.csproj" -c Release -o build-files
RUN dotnet publish "IsPairAPI/IsPairAPI.csproj" -c Release -o publish-files

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /published-app
COPY --from=build-env /ispairapi/build/publish-files .
ENTRYPOINT [ "dotnet", "IsPairAPI.dll" ]