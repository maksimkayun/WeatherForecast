FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ServiceWeather/ServiceWeather.csproj", "ServiceWeather/"]
RUN dotnet restore "ServiceWeather/ServiceWeather.csproj"
COPY . .
WORKDIR "/src/ServiceWeather"
RUN dotnet build "ServiceWeather.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceWeather.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS="http://0.0.0.0:5000"
ENTRYPOINT ["dotnet", "ServiceWeather.dll"]
