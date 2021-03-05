# order_grabber
final de plataformas de desarrollo

## Instrucciones de compilacion
1. Descargar el proyecto.
2. Abrir con visual studio 2019 la solucion.
3. Asegurese que exista la carpeta App_data dentro de la carpeta DataService en caso de no existir crearla.
4. En la barra de Herramientas valla a Administrador de paquetes NutGet -> Consola del Administrador de paquetes
5. En la consola asegurese que esta seleccionado el proyecyo data_service y ejecute el comando Update-Database.
6. En caso de que la migracion falle borre el contenido de la carpeta bin y obj/debug dentro del directorio Data_service.
6. Valla a Opciones de solucion haciendo click derecho en la solucion y selecione propiedades, dentro de propiedades valla a la opcion proyecto de inicio y seleccione proyecto de inicios multiples y Data_Service, WebApp, WebApi y DesktopApp con la opcion "Iniciar".
7. finalmente compile toda la solucion.
