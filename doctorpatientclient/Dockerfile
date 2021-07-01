FROM mcr.microsoft.com/dotnet/sdk:3.1 AS builder
WORKDIR /src
COPY ./doctorpatientclient.csproj .
RUN dotnet restore doctorpatientclient.csproj
COPY . .
RUN dotnet build doctorpatientclient.csproj -c Debug -o /src/out
# using ASP.NET Core SDK to run the image inside the container
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=builder /src/out .

EXPOSE 80
ENTRYPOINT [ "dotnet", "doctorpatientclient.dll"]