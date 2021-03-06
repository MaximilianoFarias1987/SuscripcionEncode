USE [master]
GO
/****** Object:  Database [Encode]    Script Date: 2/9/2021 08:05:35 ******/
CREATE DATABASE [Encode]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Encode', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Encode.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Encode_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Encode_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Encode] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Encode].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Encode] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Encode] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Encode] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Encode] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Encode] SET ARITHABORT OFF 
GO
ALTER DATABASE [Encode] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Encode] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Encode] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Encode] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Encode] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Encode] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Encode] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Encode] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Encode] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Encode] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Encode] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Encode] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Encode] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Encode] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Encode] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Encode] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Encode] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Encode] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Encode] SET  MULTI_USER 
GO
ALTER DATABASE [Encode] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Encode] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Encode] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Encode] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Encode] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Encode] SET QUERY_STORE = OFF
GO
USE [Encode]
GO
/****** Object:  Table [dbo].[Suscripcion]    Script Date: 2/9/2021 08:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suscripcion](
	[IdAsociacion] [int] IDENTITY(1,1) NOT NULL,
	[IdSuscriptor] [int] NOT NULL,
	[FechaAlta] [date] NOT NULL,
	[FechaFin] [date] NULL,
	[MotivoFin] [nvarchar](200) NULL,
 CONSTRAINT [PK__Suscripc__77CD3C42E6F55DF1] PRIMARY KEY CLUSTERED 
(
	[IdAsociacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suscriptor]    Script Date: 2/9/2021 08:05:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suscriptor](
	[IdSuscriptor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[NumeroDocumento] [int] NOT NULL,
	[TipoDocumento] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](12) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSuscriptor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Suscripcion] ON 

INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (15, 1, CAST(N'2021-08-30' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (16, 3, CAST(N'2021-08-30' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (17, 6, CAST(N'2021-08-30' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (18, 13, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (19, 7, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (20, 8, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (21, 11, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (22, 12, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (23, 10, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (24, 4, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (25, 5, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (26, 16, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (27, 18, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (28, 17, CAST(N'2021-08-31' AS Date), NULL, NULL)
INSERT [dbo].[Suscripcion] ([IdAsociacion], [IdSuscriptor], [FechaAlta], [FechaFin], [MotivoFin]) VALUES (29, 9, CAST(N'2021-09-01' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Suscripcion] OFF
GO
SET IDENTITY_INSERT [dbo].[Suscriptor] ON 

INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (1, N'Maximiliano', N'Farias', 33223349, N'DNI', N'Plaza Huincul ', N'3512533349', N'maximilianocba07@gmail.com', N'maximilianocba07', N'usuario1234$')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (2, N'Prueba', N'Pruebaaa', 21421412, N'DNI', N'asfasfsaf', N'123123123', N'prueba@prueba.com.ar', N'prueba', N'123456')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (3, N'prueba', N'ConSuscripcion', 1223456, N'DNI', N'asfsafsaf', N'3135646', N'prueba2@gmail.com', N'pruSus', N'123456789')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (4, N'', N'prueba5', 111111111, N'DNI', N'fasfasfasfas', N'1231321', N'sadasdasdasd@asdas.com', N'asdasdsfa', N'asasfasf')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (5, N'asdasd', N'asaaaa', 123456, N'DNI', N'sadasddas2232', N'1234566', N'asdas@ads.com', N'asdadas', N'646asdasd')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (6, N'rrrrrrr', N'qqqqqqqqqqq', 889998898, N'DNI', N'zxczxc', N'12313', N'xzczxczx', N'zxczxc', N'zxczxc')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (7, N'prueba10', N'prueba10', 2222222, N'DNI', N'asfsafsaf', N'1231321', N'prueba10@gmail.com', N'prueba10', N'1231312')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (8, N'santiago', N'manzilla', 30256897, N'DNI', N'sadasdasd', N'1234567', N'smana@gmail.com', N'smanzilla', N'1234567')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (9, N'Prueba', N'Update', 40987654, N'DNI', N'sadasd', N'asdasd', N'asdsadas@gail.com', N'asad', N'213132')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (10, N'pruebars', N'pruebars', 55889966, N'DNI', N'asdasdas', N'44444', N'sdsfafas', N'pruebars', N'sadasdas')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (11, N'sdfdsf', N'sdfsdf', 123123, N'DNI', N'dsfsdf', N'234234', N'dsfsdf', N'sdfdfff', N'sfa222')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (12, N'asasdas', N'asdasdas', 1231313, N'DNI', N'asdasd', N'23213', N'asdas', N'asddddddd', N'asasf2')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (13, N'probando', N'transaccion', 12003214, N'DNI', N'fafasf', N'3512554', N'asfaf@asd.com', N'pruebaTranasaccion', N'123456788')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (14, N'nuevo', N'pormil', 1010101010, N'DNI', N'asdsadas', N'123123213', N'aasdas.cas@dads.com', N'nuevo', N'dasdasdasd')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (15, N'nuevo12', N'pormildos', 222444777, N'DNI', N'asdsadas', N'123125', N'aasdas.cas@dads.com', N'pormilnuevos', N'dasdasdasd')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (16, N'lalalaljdsdas', N'asdasdas', 777888999, N'DNI', N'asdads', N'3121546', N'asda@asd.com', N'laala7777', N'asdadasd')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (17, N'asdasd', N'asdasd', 3242342, N'DNI', N'asdasd', N'32434', N'asda@zfz.com', N'llutltlt', N'xcvxcvxcv')
INSERT [dbo].[Suscriptor] ([IdSuscriptor], [Nombre], [Apellido], [NumeroDocumento], [TipoDocumento], [Direccion], [Telefono], [Email], [NombreUsuario], [Password]) VALUES (18, N'que', N'ande', 764321, N'DNI', N'fsafa', N'213122', N'afsfas@asd.com', N'queAndeee', N'asdasd')
SET IDENTITY_INSERT [dbo].[Suscriptor] OFF
GO
ALTER TABLE [dbo].[Suscripcion]  WITH CHECK ADD  CONSTRAINT [Suscripcion_Suscriptor] FOREIGN KEY([IdSuscriptor])
REFERENCES [dbo].[Suscriptor] ([IdSuscriptor])
GO
ALTER TABLE [dbo].[Suscripcion] CHECK CONSTRAINT [Suscripcion_Suscriptor]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarSuscriptor]    Script Date: 2/9/2021 08:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BuscarSuscriptor]
@TipoDoc varchar(50),
@Documento int
as
select s.IdSuscriptor ,s.Nombre, s.Apellido,s.NumeroDocumento,s.TipoDocumento,s.Direccion,s.Telefono,s.Email,s.NombreUsuario,s.Password
from  Suscriptor s 
where TipoDocumento = @TipoDoc and NumeroDocumento = @Documento
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarSuscriptorSuscripto]    Script Date: 2/9/2021 08:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BuscarSuscriptorSuscripto]
@TipoDoc varchar(50),
@Documento int
as
select s.Nombre, s.Apellido,s.NumeroDocumento,s.TipoDocumento,s.Direccion,s.Telefono,s.Email,s.NombreUsuario,s.Password,
su.FechaAlta,su.FechaFin,su.MotivoFin
from  Suscriptor s join Suscripcion su
on s.IdSuscriptor=su.IdSuscriptor 
where TipoDocumento = @TipoDoc and NumeroDocumento = @Documento
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarSuscriptor]    Script Date: 2/9/2021 08:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_EditarSuscriptor]
@Nombre nvarchar(100),
@Apellido nvarchar(100),
@NumeroDocumento int,
@Direccion nvarchar(100),
@Telefono nvarchar(12),
@Email nvarchar(100),
@NombreUsuario nvarchar(50),
@Password nvarchar(50)
as
Update Suscriptor set
Nombre=@Nombre,
Apellido=@Apellido,
Direccion=@Direccion,
Telefono=@Telefono,
Email=@Email,
NombreUsuario=@NombreUsuario,
Password=@Password
where NumeroDocumento=@NumeroDocumento
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarSuscripcion]    Script Date: 2/9/2021 08:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertarSuscripcion]
@IdSuscriptor int,
@FechaAlta date = null,
@FechaFin date = null,
@MotivoFin nvarchar(200) = null
as
set @FechaAlta = COALESCE(@FechaAlta, CONVERT(date, SYSDATETIME()));
insert into Suscripcion
values (@IdSuscriptor,@FechaAlta,@FechaFin,@MotivoFin)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarSuscriptor]    Script Date: 2/9/2021 08:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertarSuscriptor]
@Nombre nvarchar(100),
@Apellido nvarchar(100),
@NumeroDocumento int,
@TipoDocumento nvarchar(50),
@Direccion nvarchar(100),
@Telefono nvarchar(12),
@Email nvarchar(100),
@NombreUsuario nvarchar(50),
@Password nvarchar(50)
as
insert into Suscriptor values (@Nombre,@Apellido,@NumeroDocumento,@TipoDocumento,@Direccion,@Telefono,@Email,@NombreUsuario,@Password)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarSuscriptorSuscripcion]    Script Date: 2/9/2021 08:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertarSuscriptorSuscripcion]
@Nombre nvarchar(100),
@Apellido nvarchar(100),
@NumeroDocumento int,
@TipoDocumento nvarchar(50),
@Direccion nvarchar(100),
@Telefono nvarchar(12),
@Email nvarchar(100),
@NombreUsuario nvarchar(50),
@Password nvarchar(50),
@FechaAlta date = null,
@FechaFin date = null,
@MotivoFin nvarchar(200) = null
as
declare @IdSuscriptor int
insert into Suscriptor values (@Nombre,@Apellido,@NumeroDocumento,@TipoDocumento,@Direccion,@Telefono,@Email,@NombreUsuario,@Password)
set @IdSuscriptor=IDENT_CURRENT('Suscriptor')
set @FechaAlta = COALESCE(@FechaAlta, CONVERT(date, SYSDATETIME()));
insert into Suscripcion
values (@IdSuscriptor,@FechaAlta,@FechaFin,@MotivoFin)
GO
USE [master]
GO
ALTER DATABASE [Encode] SET  READ_WRITE 
GO
