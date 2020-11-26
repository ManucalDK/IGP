# Prueba Tecnica - InterGrupo

## - Manuel Alejandro Calambas Velasco

Prueba tecnica en donde se realiza una api usando .netcore 5 para la gestion de empleados y se consume usando una spa con angular 10.

### Software requerido
•	.net core 5.0.
•	Motor de base de datos SQL Server.
•	Npm como gestor de paquetes para javascript.
•	POSTMAN

## Instrucciones de instalación y puesta en marcha: 
### API

•	Para correr el api, a través de la línea de comandos ingresar a la ruta Back/IGP y lanzar las instrucciones:

`dotnet build`

•	Al terminar la construcción del del proyecto e instalación de dependencias es necesario realizar la migración de la base de datos generada. Pero antes debe validarse el archivo “appsettings.json” en donde se encuentra configurada la cadena de conexión a la base de datos, de tal forma que concuerde con su instancia instalada de sql server.

Para lo cual debe ejecutarse el comando:

`dotnet ef database update`

•	Para finalizar y poner en marcha la api se ejecuta el siguiente comando: 

`dotnet run`

Esto pondrá en marcha el api en la dirección http://localhost:5000

### FRONTEND

•	Para poner en marcha el proyecto front se requiere en primer lugar ejecutar una nueva línea de comandos y ubicarse dentro de la carpeta “front” del proyecto. Para posteriormente realizar la instalación de los paquetes node asociados al proyecto de angular, por lo que primero hay que lanzar el comando.

`npm install`

Al terminar la instalación de los paquetes el Frontend se pone en marcha haciendo uso del comando:

`ng serve`

# NOTAS ADICIONALES:

Dentro del proyecto se encuentra una carpeta llamada postman, en donde se encuentra un archivo con los end points ya configurados para testear en la herramienta del mismo nombre.
