# SMP-Gateway-API

El código es una aplicación de Windows Forms en C# que lee puntos de una API de Gateway. La aplicación tiene dos botones de opción: "Solo datos dinámicos" y "Todos los datos (estáticos y dinámicos)". El usuario puede seleccionar qué tipo de datos desea leer.

La aplicación tiene un cuadro de texto donde el usuario puede ingresar la dirección IP de la API de Gateway. El usuario también puede ingresar su nombre de usuario y contraseña.

La aplicación tiene un botón que el usuario puede hacer clic para leer los puntos. Cuando se hace clic en el botón, la aplicación primero obtendrá información de todos los puntos. Luego, la aplicación obtendrá los puntos especificados en el cuadro de texto.

Si se selecciona el botón de opción "Solo datos dinámicos", la aplicación solo obtendrá los datos dinámicos para los puntos especificados. Los datos dinámicos son datos que cambian con el tiempo.

Si se selecciona el botón de opción "Todos los datos (estáticos y dinámicos)", la aplicación obtendrá todos los datos para los puntos especificados. Esto incluye tanto datos dinámicos como datos estáticos. Los datos estáticos son datos que no cambian con el tiempo.

Luego, la aplicación imprimirá los datos de los puntos especificados en el cuadro de texto.

Aquí hay un desglose del código:

- La clase ```ReadPoint``` es la clase principal de la aplicación. Contiene el código para la interfaz de usuario y el código para leer los puntos.
- El método ```buttonGetPoint_Click``` es el controlador de eventos para el botón "Obtener punto". Este método se llama cuando el usuario hace clic en el botón obtener.
- El método ```radioButtonDynamicData_CheckedChanged``` es el controlador de eventos para el botón de opción "Solo datos dinámicos". Este método se llama cuando el usuario cambia la selección del botón de opción.
- El método ```textBoxUsername_TextChanged``` es el controlador de eventos para el cuadro de texto "Nombre de usuario". Este método se llama cuando el usuario cambia el texto en el cuadro de texto.
- El método ```ReadPoint_Load``` es el controlador de eventos para el evento "Cargar". Este método se llama cuando se carga la aplicación.
![Screenshot_10](https://github.com/psmedinadi22/SMP-Gateway-API/assets/64180738/ca97115e-3a35-470e-8215-a1e5c61ad2e9)


# Arquitectura
A continuación, se muestra el grafico de la arquitectura dispuesta para la aplicación

![Screenshot_11](https://github.com/psmedinadi22/SMP-Gateway-API/assets/64180738/6d5799e3-bece-451e-a497-3b0a4654ce2a)



Entorno de desarrollo
----
Estar en la misma red que el SMP
![image](https://github.com/psmedinadi22/SMP-Gateway-API/assets/64180738/e4de9346-1179-43a1-991b-4759596b9d4e)


Instalar DotNet:
[DotNet Dowload](https://dotnet.microsoft.com/en-us/download)

Se requiere el SDK y un editor de textos, en este caso se utiliza Visual Studio, el cual se puede descargar en el siguiente Link: 
[Visual Studio Dowload](https://visualstudio.microsoft.com/es/downloads/)

Instalar en Visual Studio:
- Desarrollo Multiplataforma NetCore
- Desarrollo de Node.js
- Desarrollo de ASP.NET y Web
- Desarrollo de Azure
- Desarrollo de escritorio de .NET

Para ejecutar el código se debe preparar el entorno de desarrollo, para Instala la biblioteca RestSharp en Visual Studio:

1. Abre la Consola del Administrador de paquetes NuGet: Para abrir la Consola del Administrador de paquetes en Visual Studio, selecciona Herramientas > Administrador de paquetes NuGet > Consola del Administrador de paquetes en el menú superior.

2. En la Consola del Administrador de paquetes, escribe el siguiente comando y presiona Enter:

```
Install-Package RestSharp
```

Esto instalará el paquete RestSharp en tu proyecto a través de NuGet. El proceso de instalación descargará los archivos necesarios y configurará las referencias y dependencias adecuadas para que RestSharp funcione correctamente en tu proyecto.

AWS 
-----

Añadir Nuget en VS
![image](https://github.com/psmedinadi22/SMP-Gateway-API/assets/64180738/a73f1984-9fcc-4cb5-a405-d47afa0f4a51)


REST API EATON
---

Para crear la REST API, Eaton provee de una biblioteca de enlaces dinámicos que contiene código y datos que pueden ser utilizados por varios programas al mismo tiempo. Esta biblioteca se llama Gateway.Api.Client.Net. Para visualizar su contenido se deben utilizar herramientas de descompilación como dotPeek, ILSpy o Reflector para examinar el código fuente del archivo DLL. Estas herramientas pueden generar un código C# legible a partir del archivo DLL, lo que te permitirá explorar las clases y los métodos contenidos en él.
Se presentará una guía de instalación de dotPeek para visualizar el archivo Gateway.Api.Client.Net, para ello se debe descargar el instalador en el siguiente link:
[Dowload dotPeek](https://www.jetbrains.com/decompiler/download/#section=web-installer)

1. Abre DotPeek: Después de instalar DotPeek, ábrelo desde el menú de inicio o el acceso directo en tu escritorio.
2. Carga el archivo DLL: En la interfaz de DotPeek, haz clic en "File" (Archivo) en la barra de menú superior y selecciona "Open File" (Abrir archivo). Navega hasta la ubicación del archivo DLL Gateway.Api.Client.Net. DotPeek descompilará el archivo y mostrará su contenido en su ventana principal.
3. Explora el contenido del DLL: En la ventana principal de DotPeek, verás una jerarquía de carpetas y archivos que representan el contenido del DLL. Puedes expandir las carpetas y archivos para navegar a través de las clases y los miembros del DLL. Al seleccionar un archivo o una clase, podrás ver su código descompilado en la ventana de código fuente.
4. Navega por los miembros y su implementación: Puedes hacer clic en las clases, los métodos y las propiedades para examinar su implementación descompilada. DotPeek también te permite navegar a través de las referencias a otros miembros y explorar las dependencias del DLL.
5. Realiza búsquedas: Si buscas un miembro o una cadena específica, puedes utilizar la función de búsqueda de DotPeek. En la barra de herramientas superior, haz clic en el icono de la lupa o presiona Ctrl + F para abrir la ventana de búsqueda. Ingresa el término de búsqueda y DotPeek resaltará los resultados correspondientes en el código y en la estructura del DLL.

![image](https://github.com/psmedinadi22/SMP-Gateway-API/assets/64180738/16d1f25e-d847-498c-a086-09491b2104f0)


Editar REST API
---

El código desarrollado está en namespace llamado Gateway.Api, el cual usa los métodos y atributos de la librerías desarrolladas por EATON, las cuales se llaman using Gateway.Api.Api, Gateway.Api.Client y Gateway.Api.Model. La parte grafica se desarrolló en las herramientas de despliegue de .Net. 



# Pasos para el desarrollo de la API

Para desarrollar alguna de las aplicaciones mencionadas en .NET, puedes seguir los siguientes pasos:

1. Configurar el entorno de desarrollo:
   - Descarga e instala Visual Studio, la principal herramienta de desarrollo para .NET.
   - Instalar los componentes necesarios para el desarrollo.

2. Crear un nuevo proyecto:
   - Abre Visual Studio y selecciona "Nuevo Proyecto" desde el menú "Archivo".
   - Elige el tipo de proyecto que desees desarrollar. Por ejemplo, si deseas crear una aplicación web, selecciona "ASP.NET Web Application". Si prefieres una aplicación de escritorio, elige "Windows Forms App" o "WPF App".

3. Diseñar la interfaz de usuario (UI):
   - Se utiliza el diseñador de formularios de Windows o el diseñador de XAML (en caso de WPF) para diseñar la interfaz de usuario.

4. Implementar la lógica de la aplicación:
   - Se implementa las funcionalidades específicas de la aplicación que hayas elegido. Se escribe el código en el lenguaje .NET compatible C#.
    
5. Acceder y procesar los datos:
   - Utiliza bibliotecas .NET para acceder y procesar los datos recolectados por el SMP Gateway. Puedes utilizar tecnologías de acceso a bases de datos como Entity Framework, ADO.NET o Dapper, según tus preferencias y necesidades.

6. Implementar características de seguridad:
   - Dado que estás trabajando con datos de seguridad, es fundamental aplicar prácticas y características de seguridad adecuadas. Asegúrate de implementar autenticación y autorización adecuadas, como roles de usuario, y proteger la aplicación contra vulnerabilidades comunes, como inyección de SQL o ataques XSS.

7. Probar la aplicación:
   - Realiza pruebas exhaustivas para garantizar que la aplicación funcione como se espera y que los datos se procesen correctamente.

8. Desplegar la aplicación:
   - Para aplicaciones de escritorio, puedes crear un instalador para distribuir la aplicación.
