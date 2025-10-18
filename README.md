# API-TEST-C

API-TEST-C es un proyecto backend modular en **.NET**, diseñado para facilitar la escalabilidad, mantenimiento y organización por módulos funcionales (como citas y usuarios).  

---

## 📂 Estructura del proyecto

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

## ⚙️ Requisitos

- [.NET 6 o 7 SDK](https://dotnet.microsoft.com/download)
- SQL Server / PostgreSQL según configuración
- Visual Studio Code o Visual Studio
- (Opcional) Postman o VS Code REST Client para probar endpoints

---

## 🚀 Cómo iniciar el proyecto

```bash
# Clonar el repositorio
git clone <URL_DEL_REPOSITORIO>
cd API-TEST-C

# Configurar variables de entorno en el archivo .env
# Por ejemplo:
# DB_CONNECTION=Server=localhost;Database=ApiTest;User Id=sa;Password=your_password;
# PORT=5000

# Restaurar dependencias
dotnet restore

# Construir el proyecto
dotnet build

# Ejecutar la aplicación
dotnet run --project Src


# Crear una nueva migración
dotnet ef migrations add NombreDeLaMigracion --project Src --startup-project Src

# Aplicar migraciones pendientes
dotnet ef database update --project Src --startup-project Src


La API estará disponible en http://localhost:5163 según tu configuración.
La documentación Swagger se puede consultar en:
http://localhost:5163/SWAGGER/index.html
