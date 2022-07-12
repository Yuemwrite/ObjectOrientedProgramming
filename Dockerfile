FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ObjectOrientedProgramming/ObjectOrientedProgramming.csproj", "ObjectOrientedProgramming/"]
RUN dotnet restore "ObjectOrientedProgramming/ObjectOrientedProgramming.csproj"
COPY . .
WORKDIR "/src/ObjectOrientedProgramming"
RUN dotnet build "ObjectOrientedProgramming.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObjectOrientedProgramming.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObjectOrientedProgramming.dll"]
