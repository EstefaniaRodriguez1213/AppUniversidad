USE [master]
GO
/****** Object:  Database [DptodeExtension]    Script Date: 18/05/2022 12:26:10 ******/
CREATE DATABASE [DptodeExtension]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DptodeExtension', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DptodeExtension.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DptodeExtension_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DptodeExtension_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DptodeExtension] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DptodeExtension].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DptodeExtension] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DptodeExtension] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DptodeExtension] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DptodeExtension] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DptodeExtension] SET ARITHABORT OFF 
GO
ALTER DATABASE [DptodeExtension] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DptodeExtension] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DptodeExtension] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DptodeExtension] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DptodeExtension] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DptodeExtension] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DptodeExtension] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DptodeExtension] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DptodeExtension] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DptodeExtension] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DptodeExtension] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DptodeExtension] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DptodeExtension] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DptodeExtension] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DptodeExtension] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DptodeExtension] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DptodeExtension] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DptodeExtension] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DptodeExtension] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DptodeExtension] SET  MULTI_USER 
GO
ALTER DATABASE [DptodeExtension] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DptodeExtension] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DptodeExtension] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DptodeExtension] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DptodeExtension]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumno](
	[Id_Alumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NULL,
	[DNI] [numeric](8, 0) NULL,
	[Carrera] [varchar](70) NULL,
	[Mail] [varchar](200) NULL,
	[Telefono] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Capacitacion]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Capacitacion](
	[Id_capacitacion] [int] IDENTITY(1,1) NOT NULL,
	[Actividad_Titulo] [varchar](200) NULL,
	[Objetivos] [varchar](8000) NULL,
	[Fecha_Incio] [date] NULL,
	[Fecha_Fin] [date] NULL,
	[Actividades_Prev] [varchar](8000) NULL,
	[Estado_Avance] [varchar](8000) NULL,
	[Part_Docentes] [int] NULL,
	[Part_ALmunos] [int] NULL,
	[Part_Egresados] [int] NULL,
	[Part_Otros] [int] NULL,
	[Otra_Info] [varchar](8000) NULL,
	[Carrera_Vincula] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_capacitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carrera](
	[Id_Carrera] [int] IDENTITY(1,1) NOT NULL,
	[Carrera] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Convenio]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Convenio](
	[Id_Convenio] [int] IDENTITY(1,1) NOT NULL,
	[Empresa_Institucion] [varchar](300) NULL,
	[Fecha_inicio] [date] NULL,
	[Renovacion_automatica] [varchar](3) NULL,
	[Fecha_fin] [date] NULL,
	[Objetivo] [varchar](8000) NULL,
	[Opciones] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Convenio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Disertante]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disertante](
	[Id_Disertante] [int] IDENTITY(1,1) NOT NULL,
	[Disertante] [varchar](100) NULL,
	[Id_Capacitacion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Disertante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAdicional]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAdicional](
	[Id_Protocolo] [int] IDENTITY(1,1) NOT NULL,
	[Id_Convenio] [int] NULL,
	[Fecha_Inicio] [date] NULL,
	[Fecha_Fin] [date] NULL,
	[Objetivos] [varchar](8000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Protocolo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PPS]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PPS](
	[Id_PPS] [int] IDENTITY(1,1) NOT NULL,
	[Id_Alumno] [int] NULL,
	[TipoPPS] [varchar](20) NULL,
	[Condicion] [varchar](50) NULL,
	[Empresa] [varchar](100) NULL,
	[Supervisor_Empresa] [varchar](150) NULL,
	[Tareas] [varchar](5000) NULL,
	[Fec_Inicio] [date] NULL,
	[Fec_Finalizacion] [date] NULL,
	[Estado] [varchar](40) NULL,
	[Observaciones] [varchar](5000) NULL,
	[Horario_de_Trabajo] [varchar](100) NULL,
	[Inf_Av_Alumno_Empresa] [varchar](15) NULL,
	[Inf_Av_Docente] [varchar](15) NULL,
	[Inf_Fial_Alumno] [varchar](15) NULL,
	[Inf_Final_Empresa] [varchar](15) NULL,
	[Inf_Fial_Docente] [varchar](15) NULL,
	[Nro_Resolucion] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_PPS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Secretaria]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Secretaria](
	[Id_Secretaria] [int] IDENTITY(1,1) NOT NULL,
	[Id_Alumno] [int] NULL,
	[Inf_A_Alumno_Empresa] [varchar](20) NULL,
	[Inf_A_Docente] [varchar](20) NULL,
	[Inf_F_Alumno] [varchar](20) NULL,
	[Inf_F_Empresa] [varchar](20) NULL,
	[Inf_F_Docente] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Secretaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/05/2022 12:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Contraseña] [varchar](20) NULL,
	[TipoUsuario] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (15, N'Estefania Janet Rodriguez', CAST(39600789 AS Numeric(8, 0)), N'Ing. Telecomunicaciones', N'restefania@gmail.com', CAST(2122122 AS Numeric(18, 0)))
INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (16, N'Juan Alberto Bianco', CAST(39899098 AS Numeric(8, 0)), N'Ing. Civil', N'juan123@gmail.com', CAST(2337238 AS Numeric(18, 0)))
INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (17, N'Santillan, Matias', CAST(40157929 AS Numeric(8, 0)), N'Ing. Civil', N'matu_santillan@hotmail.com', CAST(3876112399 AS Numeric(18, 0)))
INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (18, N'Ruben Garcia', CAST(39500789 AS Numeric(8, 0)), N'Ing. Civil', N'DD', CAST(12 AS Numeric(18, 0)))
INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (19, N'Estefania Janet Rodriguez', CAST(39500670 AS Numeric(8, 0)), N'Ing. Informatica', N'jsakj@hotmail.com', CAST(399686990 AS Numeric(18, 0)))
INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (20, N'Jesica Pacheco', CAST(22567345 AS Numeric(8, 0)), N'Ing. Civil', N'jesirabit@hotamail.com', CAST(2143156 AS Numeric(18, 0)))
INSERT [dbo].[Alumno] ([Id_Alumno], [Nombre], [DNI], [Carrera], [Mail], [Telefono]) VALUES (21, N'Guillermo Conte', CAST(12345667 AS Numeric(8, 0)), N'Ing. Industrial', N'vgdsv@gnail.com', CAST(32323 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[Capacitacion] ON 

INSERT [dbo].[Capacitacion] ([Id_capacitacion], [Actividad_Titulo], [Objetivos], [Fecha_Incio], [Fecha_Fin], [Actividades_Prev], [Estado_Avance], [Part_Docentes], [Part_ALmunos], [Part_Egresados], [Part_Otros], [Otra_Info], [Carrera_Vincula]) VALUES (94, N'Juan', N'aaaaaaaaa', CAST(0x0DB40B00 AS Date), CAST(0xB9420C00 AS Date), N'refndklanmñ', N'dwq', 33, 3, 11, 2, N'few', N'Ing. Civil')
SET IDENTITY_INSERT [dbo].[Capacitacion] OFF
SET IDENTITY_INSERT [dbo].[Convenio] ON 

INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (23, N'UNSA', CAST(0xF73F0B00 AS Date), N'0', CAST(0x39420B00 AS Date), N'ede', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (25, N'UNSA', CAST(0x61250B00 AS Date), N'0', CAST(0x39420B00 AS Date), N'bf', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (26, N'UNSA', CAST(0x61250B00 AS Date), N'0', CAST(0x39420B00 AS Date), N'bf', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (27, N'UNSA', CAST(0x61250B00 AS Date), N'0', CAST(0x39420B00 AS Date), N'Jugar', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (28, N'UNSA', CAST(0xF73F0B00 AS Date), N'0', CAST(0x39420B00 AS Date), N'fef44', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (29, N'Universidad de la Plata', CAST(0x9C400B00 AS Date), N'0', CAST(0x744D0B00 AS Date), N'Vincular a las universidades a fines de realizar no se que coosa etc etce tce tfdvgvfgdvfg<', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (31, N'UCA', CAST(0x9B400B00 AS Date), N'NO', CAST(0x5B950A00 AS Date), N'ktygttg', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (32, N'bcbds', CAST(0x684D0B00 AS Date), N'NO', CAST(0x5B950A00 AS Date), N'deq', N'Convenio marco')
INSERT [dbo].[Convenio] ([Id_Convenio], [Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) VALUES (33, N'coso', CAST(0x90400B00 AS Date), N'SI', CAST(0x5B950A00 AS Date), N'cosito', N'Convenio marco')
SET IDENTITY_INSERT [dbo].[Convenio] OFF
SET IDENTITY_INSERT [dbo].[Disertante] ON 

INSERT [dbo].[Disertante] ([Id_Disertante], [Disertante], [Id_Capacitacion]) VALUES (23, N'Estefania Rodriguez', 94)
INSERT [dbo].[Disertante] ([Id_Disertante], [Disertante], [Id_Capacitacion]) VALUES (24, N'objetivo general', 94)
INSERT [dbo].[Disertante] ([Id_Disertante], [Disertante], [Id_Capacitacion]) VALUES (25, N'Estefania', 94)
SET IDENTITY_INSERT [dbo].[Disertante] OFF
SET IDENTITY_INSERT [dbo].[PAdicional] ON 

INSERT [dbo].[PAdicional] ([Id_Protocolo], [Id_Convenio], [Fecha_Inicio], [Fecha_Fin], [Objetivos]) VALUES (5, 28, CAST(0x423F0B00 AS Date), CAST(0x0DB40B00 AS Date), N'frgrg')
SET IDENTITY_INSERT [dbo].[PAdicional] OFF
SET IDENTITY_INSERT [dbo].[PPS] ON 

INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (9, 15, N'Ingeniero', N'Convenio/Protocolo', N'Copaipa', N'Gallo', N'Desarrollo de Sw', CAST(0xE03D0B00 AS Date), CAST(0x393E0B00 AS Date), N'Baja', N'Abandona', N'08:00 hs a 12:00 hs', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (10, 16, N'Tecnico', N'Convalidacion', N'Coca Cola S.A', N'Ing. Monson', N'Administracion de obras', CAST(0x7D400B00 AS Date), CAST(0xEE400B00 AS Date), N'En curso', NULL, N'-', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (11, 17, N'Ingeniero', N'Convenio/Protocolo', N'SOMECO CONSULTORA SRL', N'Ing. Fernando Zalazar', N'Mensuras, topografía, oficina técnica', CAST(0x76400B00 AS Date), CAST(0x633F0B00 AS Date), N'Finalizada', NULL, N'Lunes a viernes de 9 a 13 hs.', N'Presentado', N' No presentado', N'Presentado', N'Presentado', N'No Presentado', N'149/20')
INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (12, 18, N'Tecnico', N'Convalidacion', N'SOMECO CONSULTORA SRL', N'Ing. Fernando Zalazar', N'FFSSDAF', CAST(0x90400B00 AS Date), CAST(0xEE400B00 AS Date), N'En curso', NULL, N'LU A VIE DE 16 A 20', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (13, 19, N'Ingeniero', N'Convalidacion', N'Toyota S.A', N'Ing. Jose Camacho', N'-', CAST(0x94400B00 AS Date), CAST(0xD0400B00 AS Date), N'Finalizada', NULL, N'-', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (15, 20, N'Ingeniero', N'Convalidacion', N'Agua de los Andes', N'Lic Camila Cabello', N'Construcciones ', CAST(0x92400B00 AS Date), CAST(0xED400B00 AS Date), N'En curso', NULL, N'En casa', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PPS] ([Id_PPS], [Id_Alumno], [TipoPPS], [Condicion], [Empresa], [Supervisor_Empresa], [Tareas], [Fec_Inicio], [Fec_Finalizacion], [Estado], [Observaciones], [Horario_de_Trabajo], [Inf_Av_Alumno_Empresa], [Inf_Av_Docente], [Inf_Fial_Alumno], [Inf_Final_Empresa], [Inf_Fial_Docente], [Nro_Resolucion]) VALUES (16, 21, N'Tecnico', N'Convenio/Protocolo', N'Coso', N'Supervisor', N'Control de procesos', CAST(0x18400B00 AS Date), CAST(0x73400B00 AS Date), N'Vencida', NULL, N'sin', NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PPS] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [TipoUsuario]) VALUES (3, N'Pato', N'145', N'Secretaria')
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [TipoUsuario]) VALUES (5, N'Juan', N'123', N'Administrador')
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [TipoUsuario]) VALUES (7, N'elmago12', N'6estefania13', N'Administrador')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Disertante]  WITH CHECK ADD FOREIGN KEY([Id_Capacitacion])
REFERENCES [dbo].[Capacitacion] ([Id_capacitacion])
GO
ALTER TABLE [dbo].[PAdicional]  WITH CHECK ADD FOREIGN KEY([Id_Convenio])
REFERENCES [dbo].[Convenio] ([Id_Convenio])
GO
ALTER TABLE [dbo].[PPS]  WITH CHECK ADD FOREIGN KEY([Id_Alumno])
REFERENCES [dbo].[Alumno] ([Id_Alumno])
GO
ALTER TABLE [dbo].[Secretaria]  WITH CHECK ADD FOREIGN KEY([Id_Alumno])
REFERENCES [dbo].[Alumno] ([Id_Alumno])
GO
USE [master]
GO
ALTER DATABASE [DptodeExtension] SET  READ_WRITE 
GO
