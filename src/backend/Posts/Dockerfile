FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/Posts.Api/Posts.Api.csproj", "src/Posts.Api/"]
RUN dotnet restore "src/Posts.Api/Posts.Api.csproj"
COPY . .
WORKDIR "/src/src/Posts.Api"
RUN dotnet build "Posts.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Posts.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Posts.Api.dll"]