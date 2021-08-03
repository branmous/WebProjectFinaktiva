# Web Project Finaktiva

_acontinuacion describire brevemente la solucion de la prueba tecnica del Backend Finaktiva!
### Pre-requisitos 📋
_Para la ejecucion del proyecto se debe contar con Visual Studio y SQL SERVER

### Base de datos 🔧
_El proyecto esta corriendo con el string Connection Local de la maquina (localdb)\\MSSQLLocalDB

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
