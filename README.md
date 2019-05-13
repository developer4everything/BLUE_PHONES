1. Abrir Windows PowerShell (con permisos de administrador).

2. Acceder al directorio de SQLServer (\BLUE_PHONES\src\SQLServer).

3. Ejecutar:
   > docker build -t sqlserver:lastest .

4. Ejecutar:
   > docker run -d -p 1433:1433 --name bluephones_sqlserver_1 sqlserver:lastest

5. Comprobar la IP donde se encuentra DOCKER para la base de datos y modificar dentro del fichero 'appsettings.json' (ruta \BLUE_PHONES\src\Services\Catalog\Catalog.API) la cadena de conexión 'BluePhonesConnection':
   "BluePhonesConnection": "Server=tcp:192.168.1.36,1433;Initial Catalog=BluePhones;User Id=sa;Password=bL5ipH0n3sDb;"

6. Acceder al directorio raiz (\BLUE_PHONES).

7. Ejecutar:
   > docker-compose up --build

8. Una vez finalizado el proceso, comprobar el correcto funcionamiento de la RESTAPI mediante la URL: http://localhost/swagger/index.html

9. Acceder a la web mediante la URL: http://localhost:3000
