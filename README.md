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
En este proyecto tiene un controlador llamado UserController en cual contiene los servicios expuestos para el consumo REST.
