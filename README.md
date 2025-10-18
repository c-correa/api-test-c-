# API-TEST-C

API-TEST-C is a modular backend project in **.NET**, designed to facilitate scalability, maintainability, and organization through functional modules (such as appointments and users).  

---

## 📂 Project Structure

API-TEST-C/
├─ .vscode/ # Configuración del editor Visual Studio Code
├─ Assets/ # Recursos estáticos del proyecto
├─ bin/ # Archivos compilados
├─ data/ # Datos de prueba / seeders
├─ Mapping/ # Configuración de mapeos (AutoMapper u otros)
├─ Migrations/ # Migraciones de la base de datos
├─ obj/ # Archivos temporales de compilación
├─ Properties/ # Propiedades del proyecto
├─ Src/ # Código fuente principal
│ ├─ Modules/ # Módulos funcionales
│ │ ├─ Appointment/ # Funcionalidad de citas
│ │ │ ├─ Controllers/ # Controladores de API
│ │ │ ├─ Dto/ # Objetos de transferencia de datos
│ │ │ ├─ Models/ # Entidades y modelos de datos
│ │ │ └─ Services/ # Lógica de negocio
│ │ └─ User/ # Funcionalidad de usuarios
│ │ ├─ Controllers/
│ │ ├─ Dto/
│ │ ├─ Models/
│ │ └─ Services/
│ └─ Shared/ # Componentes compartidos entre módulos
│ ├─ Mapping/ # Configuración de mapeos globales
│ └─ Utils/ # Utilidades y helpers
├─ utils/ # Funciones generales del proyecto
├─ .env # Variables de entorno
├─ .gitignore # Archivos ignorados por Git
├─ appsettings.json # Configuración principal
├─ appsettings.Development.json # Configuración para desarrollo
├─ Program.cs # Punto de entrada de la aplicación
├─ README.md # Documentación
├─ test.csproj # Archivo del proyecto .NET
├─ test.http # Requests para probar la API
└─ test.sln # Solución de Visual Studio

---


---

## ⚙️ Requirements

- [.NET 6 or 7 SDK](https://dotnet.microsoft.com/download)
- SQL Server / PostgreSQL (depending on your configuration)
- Visual Studio Code or Visual Studio
- (Optional) Postman or VS Code REST Client to test endpoints

---

## 🚀 How to run the project

```bash
# Clone the repository
git clone https://github.com/c-correa/api-test-c-
cd API-TEST-C

# Set up environment variables in the .env file
# For example:
# DB_CONNECTION=Server=localhost;Database=ApiTest;User Id=sa;Password=your_password;
# PORT=5000

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run --project Src

# Create a new migration
dotnet ef migrations add MigrationName --project Src --startup-project Src

# Apply pending migrations
dotnet ef database update --project Src --startup-project Src
