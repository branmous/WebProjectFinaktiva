# Web Project Finaktiva

Se realiza una descripción de la solución desarrollada para la  prueba técnica del Backend Finaktiva!

### Pre-requisitos 📋

Para la ejecución del proyecto se debe contar con Visual Studio y SQL SERVER.

### Base de datos 🔧

El proyecto esta corriendo con el string Connection Local de la máquina (localdb)\\MSSQLLocalDB

## Estructura 🚀

El Proyecto esta compuesto por una arquitectura de tres capas:
Infraestructura, Dominio y Presentación a continuación, se realiza una descripción de cada capa.

## Infraestructura ⚙️

Esta capa comprende todo lo relacionado con el modelo de base de datos y los repositorios que generan todo el Crud de cada tabla creada.

A nivel de desarrollo se creo dos tablas:

* User - Contiene la información de los usuarios.
* Rol - Contiene los roles Administrador y operativos.

## Dominio 🔩

Esta capa comprende todo lo relacionado con la logica que negocio del proyecto.

## Presentación 🛠️

- Esta capa comprende todo lo relacionado con el proyecto Backend hecho en Frameword .Net Core 3.1.

- El proyecto tiene un controlador llamado UsersController el cual  contiene los servicios expuestos para el consumo REST a continuación, se indican los servicios que contiene el controllador:

 Servicios UsersController

* api/Users/Authenticate - Este Servicio se encarga de loguear el usuario.
    Recibe como parametros el siguente JSON:
    ```
    {
        "Username":"string",
        "Password":"string"
    }
    ```

* api/users/Register - Este Servicio se encarga del  registro del usuario.
    Recibe como parametros el siguente JSON:
    ```
    {
    "FirstName": "string",
    "LastName": "string",
    "Username": "string",
    "Password":"string",
    "RolId": int
    }
    ```

* api/users/CreateUser - Este Servicio se encarga de  crear un usuario.
    Nota: Solo el adminitrador puede utilizar este servicio
    Recibe como parametros el siguente JSON:
    ```
    {
    "FirstName": "string",
    "LastName": "string",
    "Username": "string",
    "Password":"string",
    "RolId": int
    }
    ```

* api/users/UpdateUser - Este Servicio se encarga de actualizar un usuario.
Nota:Solo el adminitrador puede utilizar este servicio.
    Recibe como parametros el siguente JSON:
    ```
    {
    "Id":"string",
    "FirstName": "string",
    "LastName": "string",
    "Username": "string",
    "Password":"string",
    "RolId": int
    }
    ```

* api/users/DeleteUser?userId=string - Este Servicio se encarga de eliminar un usuario.
    Recibe como parametros el userID 
    Nota:Solo el adminitrador puede utilizar este servicio

* api/users/getAll - Este usuario se encarga de mostrar todos los usuarios creados.
Nota: Solo los usuarios Administradores y operativos pueden utilizar este servicio.
