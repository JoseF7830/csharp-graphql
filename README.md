# C# GraphQL API

Este proyecto es un backend desarrollado en C# utilizando Entity Framework Core, Hot Chocolate y GraphQL. Proporciona una API que permite gestionar una base de datos con entidades de Autores, Publicaciones y Categorías.

## Características

CRUD completo para Autores, Publicaciones y Categorías.

Uso de GraphQL para consultas eficientes.

Entity Framework Core como ORM para manejar la base de datos.

AutoMapper para mapeo de objetos.

Arquitectura modular y escalable.

## Tecnologías Utilizadas

Lenguaje: C#

ORM: Entity Framework Core

GraphQL: Hot Chocolate

Base de Datos: Microsoft SQL Server

## Paquetes Principales

AutoMapper.Extensions.Microsoft.DependencyInjection (11.0.0)

HotChocolate.AspNetCore (12.12.1)

HotChocolate.Data.EntityFramework (12.12.1)

HotChocolate.Types.Analyzers (12.12.1)

Microsoft.EntityFrameworkCore.SqlServer (6.0.7)

Microsoft.EntityFrameworkCore.Tools (6.0.7)

## Instalación

Clonar el repositorio:

```
git clone https://github.com/usuario/csharp-graphql.git
cd csharp-graphql
```

### Configurar la Base de Datos

- Asegúrate de tener una instancia de SQL Server en funcionamiento.

- Actualiza la cadena de conexión en appsettings.json.


### Restaurar las dependencias

```
dotnet restore
```


### Aplicar las migraciones

```
dotnet ef database update
```

### Ejecutar el proyecto

```
dotnet run
```


## Uso

### Ejecución local

El proyecto se ejecuta en el servidor de desarrollo de ASP.NET Core. Por defecto, estará disponible en https://localhost:5001.

Ejemplo de Consulta en GraphQL

Puedes realizar consultas a través de Banana Cake Pop. Por ejemplo:

```
query getCategorias{
  categorias{
    items{
      id
      nombre
    }
  }
}
```

Estructura del Proyecto

src/
 - Data                 # Clases de contexto
 - GraphQL              # Configuración y definiciones de Queries y Mutations
 - Models               # Entidades principales
 - Migrations           # Definicion de migraciones
 - Program.cs           # Configuración principal

## Contribución

- Haz un fork del repositorio.

- Crea una rama para tu función:

- git checkout -b nueva-funcionalidad

Realiza tus cambios y haz un commit:

- git commit -m "Agrego una nueva funcionalidad"

- Envía un Pull Request.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más información.

Autores

Jose Figueroa

