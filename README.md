# Cafeteria-IS
>Proyecto para curso de Ingeniería de Software. 

>En el presente proyecto desarrollamos un sistema de punto de venta para una cafetería utilizando los conocimientos adquiridos durante la clase de Ing. Software partiendo de la definición de requisitos, propuesta de arquitectura y diseño de las mismas, así como el diseño de un prototipo inicial. 

## [Requerimientos](https://docs.google.com/document/d/1sG8yo0S3KhbQsJgGiIOQJq9hIEQRfRCZqeJmT6Blb60/edit?usp=sharing)
Documento compartido con los requerimientos funcionales y no funcionales definidos para el desarrollo de nuestro sistema de punto de venta para Cafetería. 

## [Modelo arquitectónico, diseño de datos y prototipo.](https://docs.google.com/presentation/d/1ir-GeO6sYMTI_OfAWJf3rYoKQYfSAyVn/edit?usp=sharing&ouid=115022025169927677578&rtpof=true&sd=true) 
Presentación compartida donde se muestran los diagramas correspondientes para diseño arquitectónico basado en MVC, diseño de datos para manejo de la información del sistema y vistas de prototipo de interfaz del sistema.

### [Prototipo.](https://www.figma.com/file/zUVZWv2q62oWpfe07mtLVE/IngSoftware_Prototipo?node-id=0%3A1)
Prototipo elaborado en Figma con vistas y navegación para el sistema de punto de venta. 

### Clonar proyecto
`git clone https://github.com/HeiderVS/Cafeteria-IS.git`

![2021-12-16 20-02-32](https://user-images.githubusercontent.com/40531216/146476776-180fe739-4c63-48d4-b138-e0630bb6ad41.gif)

Este comando ejecutado en terminal nos creara una copia del proyecto en nuestro entorno local. 

### [Telerik Winforms](https://www.telerik.com/products/winforms.aspx)
Para la interfaz de usuario se estan utilizando componentes de Telerik. Estos nos permiten agregar funcionalidades a las tablas tales como busqueda, celdas de seleccion, incremento numerico, etc...

La version instalada para el desarrollo del proyecto corresponde [R3 2021 SP2 (version 2021.3.1123)](https://www.telerik.com/products/winforms.aspx).  

![image](https://user-images.githubusercontent.com/40531216/146474885-103b5102-75c2-4413-ac56-585bb2cfd8d4.png)

Es necesario integrar los RadControls de Telerik al toolbox del IDE, se anexa documentacion oficial. [Adding RadControls to Visual Studio Toolbox](https://docs.telerik.com/devtools/winforms/visual-studio-integration/adding-radcontrols-to-visual-studio-toolbox )

### Entity Framework 
Es una libreria que nos permite mapear bases de datos a objetos .NET. La version utilizada en el proyecto corresponde a 
* EntityFramework 6.4.4 
* EntityFrameworkCore 3.1.21

![image](https://user-images.githubusercontent.com/40531216/146665804-c2cece31-78cf-41c9-a2f7-2a6457e9b4c9.png)

### [SQL Server 2019 Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) 
Utilizamos SQL Server como sistema de gestion de Base de datos. Generamos una base de datos en la cual crearemos las tablas de los modelos de datos de Entity Framework. Se anexa documentacion completa del procedimiento para generar las tablas creadas con Entity Framework en la base de datos SQL. 

[How to generate a database using Entity Framework Model-First in ASP.NET](https://www.linkedin.com/pulse/how-generate-database-using-entity-framework-aspnet-negron-montero/)

#### Diagrama de BD
![image](https://user-images.githubusercontent.com/40531216/146666608-baed54a3-37f4-4faa-87d5-57c52ce11815.png)

### Tablas

#### Usuarios

>Informacion de los usuarios administrador y vendedor, registrados en el sistema.

|Campo|Descripcion|
|---|---------|
|id|Identificador del usuario en el sistema|
|usuario|Nombre de usuario asignado por el sistema (3 letras por nombre y apellidos, seguido de un numero)|
|nombre|Nombre de usuario|
|apellidoPaterno|Apellido de usuario|
|apellidoMaterno|Apellido de usuario|
|rolID|Identificador de tipo de usuario (0 - Admin, 1 - Empleado)|
|PasswordStored|Contrasena generada por el sistema, encriptada en BD|

#### Roles 

>Identificador y descripcion de los niveles de acceso al sistema. 

|Campo|Descripcion|
|---|---------|
|id|Identificador del rol de usuario (0,1)|
|rol|Descripcion del rol (Administrador, Vendedor)|

#### Productos

> Informacion del producto registrado en inventario y disponible en Punto de Venta. 

|Campo|Descripcion|
|---|---------|
|id|Identificador del producto|
|nombre|Nombre del producto registrado|
|marca|Marca del producto registrado|
|precio|Costo de venta por unidad|
|cantidad|Numero de unidades disponibles|
|categoriaId|Identificador de la categoria de productos dentro del sistema|

#### Categorias

> Listado de categorias de productos dentro del sistema. 

|Campo|Descripcion|
|---|---------|
|id|Identificador de categoria|
|id|Descripcion de categoria (Bebidas, botanas, yogures, energeticos, cereales, postres, helados, dulces y galletas.)|

#### Ventas

> Informacion de ordenes de compra realizadas en el sistema

|Campo|Descripcion|
|---|---------|
|id|Identificador de orden de compra|
|total|Monto pagado|
|fecha|Fecha de orden de compra realizada|
|vendedorId|Identificador de usuario que realizo la venta|

#### ProductosVendidos|

> Relacion de productos vendidos y la orden de compra a la que pertenecen.

|Campo|Descripcion|
|---|---------|
|id|Identificador de producto vendido|
|productoId|Identificador del producto registrado en el sistema|
|ventaId|Identificador de orden de compra a la que pertenece el producto vendido|
 
