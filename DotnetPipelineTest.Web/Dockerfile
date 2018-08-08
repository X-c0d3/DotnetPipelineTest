FROM microsoft/aspnetcore-build:latest AS build
WORKDIR /app


COPY *.csproj ./
RUN dotnet restore


COPY . ./
RUN dotnet publish -c Release -o output


FROM microsoft/aspnetcore:latest
WORKDIR /app
COPY --from=build /app/output .

EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT ["dotnet", "DotnetPipelineTest.Web.dll"]