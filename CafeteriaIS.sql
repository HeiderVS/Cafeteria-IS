USE [master]
GO
/****** Object:  Database [CafeteriaIS]    Script Date: 20/12/2021 18:22:29 ******/
CREATE DATABASE [CafeteriaIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CafeteriaIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CafeteriaIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CafeteriaIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CafeteriaIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CafeteriaIS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CafeteriaIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CafeteriaIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CafeteriaIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CafeteriaIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CafeteriaIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CafeteriaIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [CafeteriaIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CafeteriaIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CafeteriaIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CafeteriaIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CafeteriaIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CafeteriaIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CafeteriaIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CafeteriaIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CafeteriaIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CafeteriaIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CafeteriaIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CafeteriaIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CafeteriaIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CafeteriaIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CafeteriaIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CafeteriaIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CafeteriaIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CafeteriaIS] SET RECOVERY FULL 
GO
ALTER DATABASE [CafeteriaIS] SET  MULTI_USER 
GO
ALTER DATABASE [CafeteriaIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CafeteriaIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CafeteriaIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CafeteriaIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CafeteriaIS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CafeteriaIS', N'ON'
GO
ALTER DATABASE [CafeteriaIS] SET QUERY_STORE = OFF
GO
USE [CafeteriaIS]
GO
/****** Object:  Table [dbo].[AgregarProductos]    Script Date: 20/12/2021 18:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgregarProductos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](50) NOT NULL,
	[Sku] [varchar](50) NOT NULL,
	[Precio] [decimal](6, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_AgregarProductos] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AgregarUsuarios]    Script Date: 20/12/2021 18:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgregarUsuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoPaterno] [varchar](50) NOT NULL,
	[ApellidoMaterno] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_AgregarUsuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatosVenta]    Script Date: 20/12/2021 18:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosVenta](
	[idDatosVenta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
	[precio] [decimal](6, 2) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DatosVenta] PRIMARY KEY CLUSTERED 
(
	[idDatosVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 20/12/2021 18:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[fechaVenta] [datetime2](7) NOT NULL,
	[totalVenta] [decimal](6, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AgregarUsuarios] ON 
GO
INSERT [dbo].[AgregarUsuarios] ([idUsuario], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Usuario], [Contraseña], [Estado]) VALUES (1, N'Nicolas', N'Romero', N'Gomez', N'NicRomGom', N'Z?*cYxA/iI', 1)
GO
INSERT [dbo].[AgregarUsuarios] ([idUsuario], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Usuario], [Contraseña], [Estado]) VALUES (2, N'Braulio', N'Abrajan', N'Esquivel', N'BraAbrEsq', N'vN28#twe9N', 1)
GO
SET IDENTITY_INSERT [dbo].[AgregarUsuarios] OFF
GO
/****** Object:  StoredProcedure [dbo].[BuscarProductos]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscarProductos]

@letrab VARCHAR(50)
AS 
SELECT idProducto, NombreProducto, Sku, Precio, Cantidad, Estado
FROM AgregarProductos 
                      	INNER JOIN Grupo_de_Productos on
Grupo_de_Productos.Idline=Producto1.Id_grupo
  where  (Descripcion+Grupo_de_Productos.Linea  + Codigo) LIKE  '%' + @letrab+'%' and Usa_inventarios ='SI'
GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarUsuario]
@Letra varchar(50)
as
select * from AgregarUsuarios

where Nombre + ApellidoPaterno + ApellidoMaterno + Usuario LIKE '%'+ @Letra +'%'
GO
/****** Object:  StoredProcedure [dbo].[BuscarVentas]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarVentas]

@busqueda varchar(50)
as
SELECT idVenta, fechaVenta, totalVenta, Estado
FROM Venta
where idVenta LIKE '%' + @busqueda + '%' and totalVenta >0


GO
/****** Object:  StoredProcedure [dbo].[ConteoVentas]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConteoVentas]

as
Select count (idVenta) from Venta
where Estado=0
GO
/****** Object:  StoredProcedure [dbo].[EditarProducto]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarProducto]

@idProducto int,
@NombreProducto varchar(50),
@Sku varchar(50),
@Precio decimal(6,2),
@Cantidad int,
@Estado bit

as 

if EXISTS (SELECT NombreProducto FROM Producto1  where (Sku = @Sku and idProducto <>@idProducto ) )

RAISERROR ('Este producto ya existe, ingresa uno nuevo', 16,1)


else if EXISTS (SELECT NombreProducto  FROM AgregarProductos  where (Sku =@Sku ))

update NombreProducto set  

      Sku = @Sku,
	  Precio = @Precio,
	  Cantidad = @Cantidad,
	  Estado = @Estado

where idProducto=@idProducto
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarUsuario]
@idUsuario int,
@Nombre varchar (50),
@ApellidoPaterno varchar(50),
@ApellidoMaterno varchar(50),
@Usuario varchar(50),
@Contraseña varchar(50),
@Estado bit

as
if exists (select Usuario,idUsuario from AgregarUsuarios where (Usuario=@Usuario and idUsuario<>@idUsuario))
raiserror ('Este nombre ya se encuentra registrado, intenta con uno diferente',16,1)
else
update AgregarUsuarios set Nombre=@Nombre, ApellidoPaterno=@ApellidoPaterno, ApellidoMaterno=@ApellidoMaterno, Usuario=@Usuario, Contraseña=@Contraseña
 where idUsuario=@idUsuario
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarProducto]

@id  int
as
delete from NombreProducto  where idProducto =@id 

GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuario]
@idUsuario int,
@Usuario varchar(50)

as
if exists (select Usuario from AgregarUsuarios where @Usuario= 'Administrador')
raiserror('Este usuario no puede ser eliminado',16,1)
else
delete from AgregarUsuarios where idUsuario=@idUsuario and Usuario<>'Administrador'
GO
/****** Object:  StoredProcedure [dbo].[EliminarVenta]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarVenta]

@idventa as integer
as
delete from Venta where idVenta=@idventa 
GO
/****** Object:  StoredProcedure [dbo].[FechasVentas]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FechasVentas]


as
SELECT fechaVenta FROM Venta 
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarUsuario]
@Nombre varchar (50),
@ApellidoPaterno varchar(50),
@ApellidoMaterno varchar(50),
@Usuario varchar(50),
@Contraseña varchar(50),
@Estado bit

as
if exists (select Usuario from AgregarUsuarios where Usuario=@Usuario )
raiserror ('Este nombre ya se encuentra registrado, intenta con uno diferente',16,1)
else
insert into AgregarUsuarios
values (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Usuario, @Contraseña, @Estado )
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuario]    Script Date: 20/12/2021 18:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarUsuario]
as
select * from AgregarUsuarios
GO
USE [master]
GO
ALTER DATABASE [CafeteriaIS] SET  READ_WRITE 
GO
