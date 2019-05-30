FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["RefitSampleProject/RefitSampleProject.csproj", "RefitSampleProject/"]
RUN dotnet restore "RefitSampleProject/RefitSampleProject.csproj"
COPY . .
WORKDIR "/src/RefitSampleProject"
RUN dotnet build "RefitSampleProject.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RefitSampleProject.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RefitSampleProject.dll"]