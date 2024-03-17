# Usar la imagen base de .NET SDK para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecer el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiar el archivo csproj y restaurar las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar todos los archivos del proyecto y compilar la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# Crear una imagen final basada en una imagen de .NET mínima
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]