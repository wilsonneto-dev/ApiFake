FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./ApiFake/ApiFake.csproj", "ApiFake/"]
RUN dotnet restore "ApiFake/ApiFake.csproj"
COPY . .
WORKDIR "/src/ApiFake"
RUN dotnet build "ApiFake.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiFake.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiFake.dll"]
