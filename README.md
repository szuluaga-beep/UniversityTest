Proyecto MVC .NET Core con SQLite
Este repositorio contiene una aplicación web MVC desarrollada con .NET Core y utiliza SQLite como base de datos. Aquí te explico cómo configurarlo y ejecutarlo en tu máquina.

Requisitos Previos
Antes de empezar, asegúrate de tener instalado lo siguiente:

SDK de .NET Core 8.0 o superior: Descárgalo desde la página oficial de .NET.
Visual Studio 2022 o Visual Studio Code: Cualquiera de estos IDEs te servirá para abrir y trabajar con el proyecto. Si usas VS Code, instala las extensiones C# necesarias.
Git: Para clonar el repositorio.
Configuración del Proyecto
Sigue estos pasos para configurar el proyecto:

1. Clonar el Repositorio

2. Restaurar Dependencias
Navega hasta el directorio raíz del proyecto (donde está el archivo .csproj) y ejecuta:

Bash

dotnet restore
Esto descargará todas las dependencias NuGet que el proyecto necesita.

3. Configurar la Base de Datos SQLite
Este proyecto usa SQLite, así que no necesitas instalar un servidor de base de datos aparte. La base de datos se creará automáticamente cuando apliques las migraciones.

Para aplicar las migraciones y crear o actualizar la base de datos, ejecuta desde el directorio raíz del proyecto:

Bash

dotnet ef database update
Si necesitas crear una nueva migración, puedes usar:

Bash

dotnet ef migrations add NombreDeTuMigracion
Luego de crearla, ¡no olvides ejecutar dotnet ef database update para aplicarla!

Ejecutar la Aplicación
Una vez configurada la base de datos, puedes ejecutar la aplicación de estas maneras:

Desde la Terminal
Desde el directorio raíz del proyecto, ejecuta:

Bash

dotnet run
Esto iniciará la aplicación y te dará una URL (normalmente http://localhost:5000 o https://localhost:5001) para acceder a ella en tu navegador.

Desde Visual Studio
Abre el archivo .sln del proyecto en Visual Studio 2022.
Presiona F5 o haz clic en el botón de "IIS Express" (o el perfil de inicio que tengas configurado) en la barra de herramientas.
Desde Visual Studio Code
Abre la carpeta del proyecto en Visual Studio Code.
Ve a la pestaña "Run and Debug" (Ctrl+Shift+D).
Selecciona el perfil de lanzamiento ".NET Core Launch (web)" y haz clic en el botón de inicio (flecha verde).
¡Eso es todo! Con estos pasos, deberías tener la aplicación .NET Core MVC funcionando con SQLite. Si tienes alguna duda o problema, no dudes en crear una issue en este repositorio.
