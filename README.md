# Web Project Finaktiva

a continuación describiré brevemente la solución de la prueba técnica del Backend Finaktiva!

### Pre-requisitos 📋

Para la ejecución del proyecto se debe contar con Visual Studio y SQL SERVER

### Base de datos 🔧

El proyecto esta corriendo con el string Connection Local de la máquina (localdb)\\MSSQLLocalDB

## Estructura 🚀

El Proyecto esta compuesto por una arquitectura de tres capas (Infraestructura, Dominio y Presentación) las cuales describiré a continuación.

## Infraestructura ⚙️

En esta capa se encuentra lo relacionado al modelo de base de datos, y los respectivos repositorios los cuales generan todo el Crud a cada tabla creada.

para el desarrollo se creo dos tablas:

* User - La cual contiene toda la información de los usuarios.
* Rol - La cual contiene los roles Administrador y operativos.

## Dominio 🔩

En esta capa se encuentra toda la logica que negocio del proyecto.

## Presentación 🛠️

En esta capa se encuentra el proyecto Backend hecho en Frameword .Net Core 3.1
En este proyecto tiene un controlador llamado UsersController en cual contiene los servicios expuestos para el consumo REST.

El controllador contiene los Siguentes Servicios

* api/Users/Authenticate - Este Servicio se encarga de loguear el usuario
    Recibe como parametros es siguente JSON:
    ```
    {
        "Username":"string",
        "Password":"string"
    }
    ```

* api/users/Register - Este Servicio se encarga registrar al usuario
    Recibe como parametros es siguente JSON:
    ```
    {
    "FirstName": "string",
    "LastName": "string",
    "Username": "string",
    "Password":"string",
    "RolId": int
    }
    ```

* api/users/CreateUser - Este Servicio se encarga crear un usuario y solo el adminitrador puede utilizar este servicio
    Recibe como parametros es siguente JSON:
    ```
    {
    "FirstName": "string",
    "LastName": "string",
    "Username": "string",
    "Password":"string",
    "RolId": int
    }
    ```

* api/users/UpdateUser - Este Servicio se encarga de actualizar un usuario y solo el adminitrador puede utilizar este servicio
    Recibe como parametros es siguente JSON:
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

* api/users/DeleteUser?userId=string - Este Servicio se encarga de eliminar un usuario recibe como parametro el userID y solo el adminitrador puede utilizar este servicio

* api/users/getAll - Este usuario se encarga de mostrar todos los usuarios creados y los usuarios Administradores y operativos pueden utilizar este servicio
