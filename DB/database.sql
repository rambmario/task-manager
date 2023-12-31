USE [master]
GO
/****** Object:  Database [Gestion_tarea]    Script Date: 25/09/2023 16:43:19 ******/
CREATE DATABASE [Gestion_tarea]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestion_tarea', FILENAME = N'D:\VBNet\DATA\Gestion_tarea.mdf' , SIZE = 6080KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gestion_tarea_log', FILENAME = N'D:\VBNet\DATA\Gestion_tarea_log.ldf' , SIZE = 3840KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Gestion_tarea] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion_tarea].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestion_tarea] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestion_tarea] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestion_tarea] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestion_tarea] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestion_tarea] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestion_tarea] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Gestion_tarea] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestion_tarea] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestion_tarea] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestion_tarea] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestion_tarea] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestion_tarea] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestion_tarea] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestion_tarea] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestion_tarea] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestion_tarea] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestion_tarea] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestion_tarea] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestion_tarea] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestion_tarea] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestion_tarea] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestion_tarea] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestion_tarea] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gestion_tarea] SET  MULTI_USER 
GO
ALTER DATABASE [Gestion_tarea] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestion_tarea] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestion_tarea] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestion_tarea] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Gestion_tarea] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestion_tarea] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Gestion_tarea] SET QUERY_STORE = OFF
GO
USE [Gestion_tarea]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empresa] [varchar](50) NULL,
	[codigo_empresa] [varchar](50) NULL,
	[id_tipo_empresa] [int] NULL,
	[mail_empresa] [varchar](50) NULL,
	[password_mail] [varchar](50) NULL,
	[logo] [varchar](5000) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROYECTO]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROYECTO](
	[id_proyecto] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[nombre_proyecto] [varchar](50) NULL,
	[codigo_proyecto] [varchar](50) NULL,
	[id_tipo_proyecto] [int] NULL,
	[id_empresa] [int] NULL,
	[hora_prevista] [decimal](18, 2) NULL,
	[hora_real] [decimal](18, 2) NULL,
	[fecha_prevista_fin] [datetime] NULL,
	[fecha_real_fin] [datetime] NULL,
	[id_estado_proyecto] [int] NULL,
 CONSTRAINT [PK_PROYECTO] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sub_proyecto]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sub_proyecto](
	[id_sub_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sub_proyecto] [varchar](50) NULL,
	[codigo_sub_proyecto] [varchar](50) NULL,
	[hora_prevista] [decimal](18, 2) NULL,
	[hora_real] [decimal](18, 2) NULL,
	[fecha_prevista] [datetime] NULL,
	[fecha_real] [datetime] NULL,
	[id_proyecto] [int] NULL,
 CONSTRAINT [PK_Sub_proyecto] PRIMARY KEY CLUSTERED 
(
	[id_sub_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vista_datos]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista_datos]
AS
SELECT     dbo.Empresa.id_empresa, dbo.Empresa.nombre_empresa, dbo.PROYECTO.id_proyecto, dbo.PROYECTO.nombre_proyecto, dbo.Sub_proyecto.id_sub_proyecto, 
                      dbo.Sub_proyecto.nombre_sub_proyecto
FROM         dbo.Empresa INNER JOIN
                      dbo.PROYECTO ON dbo.Empresa.id_empresa = dbo.PROYECTO.id_empresa INNER JOIN
                      dbo.Sub_proyecto ON dbo.PROYECTO.id_proyecto = dbo.Sub_proyecto.id_proyecto
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[id_cliente] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[nombre_cliente] [varchar](50) NULL,
	[nombre_permiso] [varchar](50) NULL,
 CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_mejora]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_mejora](
	[id_estado_mejora] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_mejora] [nchar](10) NULL,
 CONSTRAINT [PK_Estado_mejora] PRIMARY KEY CLUSTERED 
(
	[id_estado_mejora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_proyecto]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_proyecto](
	[id_estado_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_proyecto] [varchar](50) NULL,
 CONSTRAINT [PK_Estado_proyecto] PRIMARY KEY CLUSTERED 
(
	[id_estado_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_tarea]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_tarea](
	[id_estado_tarea] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_tarea] [varchar](50) NULL,
 CONSTRAINT [PK_Estado_tarea] PRIMARY KEY CLUSTERED 
(
	[id_estado_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feriado]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feriado](
	[id_feriado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_feriado] [varchar](50) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_Feriado] PRIMARY KEY CLUSTERED 
(
	[id_feriado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gantt]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gantt](
	[id_gantt] [int] IDENTITY(1,1) NOT NULL,
	[dia] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[nombre_usuario] [varchar](50) NULL,
	[horas] [decimal](18, 2) NULL,
	[es_feriado] [bit] NULL,
 CONSTRAINT [PK_Gantt] PRIMARY KEY CLUSTERED 
(
	[id_gantt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hora_real]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hora_real](
	[id_hora_real] [int] IDENTITY(1,1) NOT NULL,
	[id_tarea] [int] NULL,
	[id_usuario] [int] NULL,
	[fecha_carga] [datetime] NULL,
	[hora_real] [decimal](18, 2) NULL,
	[id_usuario_asignado] [int] NULL,
	[comentario] [varchar](5000) NULL,
	[costo] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Hora_real] PRIMARY KEY CLUSTERED 
(
	[id_hora_real] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log_Error]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log_Error](
	[id_log_error] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[numero] [varchar](50) NULL,
	[mensaje] [varchar](5000) NULL,
	[origen] [varchar](5000) NULL,
	[descripcion] [varchar](8000) NULL,
 CONSTRAINT [PK_Log_Error] PRIMARY KEY CLUSTERED 
(
	[id_log_error] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mejora]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mejora](
	[id_mejora] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_mejora] [varchar](5000) NULL,
	[id_tipo_mejora] [int] NULL,
	[id_sub_proyecto] [int] NULL,
	[fecha_prevista_cierre] [datetime] NULL,
	[fecha_real] [datetime] NULL,
	[prioridad] [decimal](18, 0) NULL,
	[id_usuario] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_origen_mejora] [int] NULL,
	[ubicacion_archivos] [varchar](5000) NULL,
	[id_responsable_analisis] [int] NULL,
	[descripcion_causa] [varchar](5000) NULL,
	[id_metodo_causa] [int] NULL,
	[fecha_causa] [datetime] NULL,
	[fecha_finalizacion_accion] [datetime] NULL,
	[id_usuario_accion_correctiva] [int] NULL,
	[descripcion_accion_correctiva] [varchar](5000) NULL,
	[prevision_accion_correctiva] [varchar](5000) NULL,
	[fecha_accion_correctiva] [datetime] NULL,
	[id_usuario_cierre] [int] NULL,
	[analisis_eficacia] [char](1) NULL,
	[descripcion_cierre] [varchar](5000) NULL,
	[numero_accion_relacionada] [decimal](18, 0) NULL,
	[costo_prevencion] [decimal](18, 2) NULL,
	[costo_acciones] [decimal](18, 2) NULL,
	[costo_no_calidad] [decimal](18, 2) NULL,
	[costo_total] [decimal](18, 2) NULL,
	[fecha_cierre] [datetime] NULL,
	[id_estado_mejora] [int] NULL,
 CONSTRAINT [PK_Mejora] PRIMARY KEY CLUSTERED 
(
	[id_mejora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mejora_accion]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mejora_accion](
	[id_mejora_accion] [int] IDENTITY(1,1) NOT NULL,
	[id_mejora] [int] NULL,
	[fecha_accion] [datetime] NULL,
	[id_usuario_accion] [int] NULL,
	[descripccion_accion] [varchar](5000) NULL,
 CONSTRAINT [PK_Mejora_accion] PRIMARY KEY CLUSTERED 
(
	[id_mejora_accion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodo_causa]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_causa](
	[id_metodo_causa] [int] IDENTITY(1,1) NOT NULL,
	[nombre_metodo_causa] [varchar](50) NULL,
 CONSTRAINT [PK_Metodo_causa] PRIMARY KEY CLUSTERED 
(
	[id_metodo_causa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Origen_mejora]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Origen_mejora](
	[id_origen_mejora] [int] IDENTITY(1,1) NOT NULL,
	[nombre_origen_mejora] [varchar](50) NULL,
 CONSTRAINT [PK_Origen_mejora] PRIMARY KEY CLUSTERED 
(
	[id_origen_mejora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAREA]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAREA](
	[id_tarea] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[id_tipo_tarea] [int] NULL,
	[id_sub_proyecto] [int] NULL,
	[nombre_tarea] [varchar](5000) NULL,
	[fecha_pedido] [datetime] NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_fin] [datetime] NULL,
	[fecha_real] [datetime] NULL,
	[ubicacion_documento] [varchar](5000) NULL,
	[hora_prevista] [decimal](18, 2) NULL,
	[hora_real] [decimal](18, 2) NULL,
	[prioridad] [decimal](18, 0) NULL,
	[id_usuario] [int] NULL,
	[id_estado_tarea] [int] NULL,
	[id_proyecto] [int] NULL,
	[id_empresa] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[enviada] [bit] NULL,
	[archivo_relacionado] [varchar](5000) NULL,
	[complejidad] [char](1) NULL,
	[es_feriado] [bit] NULL,
	[IDCalendar] [varchar](5000) NULL,
 CONSTRAINT [PK_TAREA] PRIMARY KEY CLUSTERED 
(
	[id_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_empresa]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_empresa](
	[id_tipo_empresa] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_empresa] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_empresa] PRIMARY KEY CLUSTERED 
(
	[id_tipo_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_mejora]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_mejora](
	[id_tipo_mejora] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_mejora] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_mejora] PRIMARY KEY CLUSTERED 
(
	[id_tipo_mejora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_proyecto]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_proyecto](
	[id_tipo_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_proyecto] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_proyecto] PRIMARY KEY CLUSTERED 
(
	[id_tipo_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_tarea]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_tarea](
	[id_tipo_tarea] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_tarea] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_tarea] PRIMARY KEY CLUSTERED 
(
	[id_tipo_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_usuario]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_usuario](
	[id_tipo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_usuario] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_usuario] PRIMARY KEY CLUSTERED 
(
	[id_tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[apellido_usuario] [varchar](50) NULL,
	[identificador] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
	[id_tipo_usuario] [int] NULL,
	[id_empresa] [int] NULL,
	[costo] [decimal](18, 2) NULL,
	[capacidad_trabajo] [decimal](18, 2) NULL,
	[usuario_calendar] [varchar](500) NULL,
	[password_calendar] [varchar](500) NULL,
	[mail] [varchar](500) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Tipo_empresa] FOREIGN KEY([id_tipo_empresa])
REFERENCES [dbo].[Tipo_empresa] ([id_tipo_empresa])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Tipo_empresa]
GO
ALTER TABLE [dbo].[PROYECTO]  WITH CHECK ADD  CONSTRAINT [FK_PROYECTO_Tipo_proyecto] FOREIGN KEY([id_tipo_proyecto])
REFERENCES [dbo].[Tipo_proyecto] ([id_tipo_proyecto])
GO
ALTER TABLE [dbo].[PROYECTO] CHECK CONSTRAINT [FK_PROYECTO_Tipo_proyecto]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Tipo_Usuario] FOREIGN KEY([id_tipo_usuario])
REFERENCES [dbo].[Tipo_usuario] ([id_tipo_usuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Tipo_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_Delete]
    @id_cliente    int
AS

DELETE FROM [dbo].[Cliente]
WHERE
    [id_cliente]  =  @id_cliente
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_Exist]
    @nombre_cliente    varchar  (50),
    @nombre_permiso    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_cliente
FROM
    [dbo].[Cliente]
WHERE
    [nombre_cliente] = @nombre_cliente AND
    [nombre_permiso] = @nombre_permiso

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_cliente] AS [Id cliente] ,
    RTRIM(nombre_cliente) AS [Nombre cliente] ,
    RTRIM(nombre_permiso) AS [Nombre permiso]
FROM
    [dbo].[Cliente]
WHERE
    [nombre_cliente] LIKE @nombre+'%'
ORDER BY
    [nombre_cliente]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_GetAll]
AS

SELECT TOP 100
    [id_cliente] AS [Id cliente] ,
    RTRIM(nombre_cliente) AS [Nombre cliente] ,
    RTRIM(nombre_permiso) AS [Nombre permiso]
FROM
    [dbo].[Cliente]
ORDER BY
    [nombre_cliente]
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_GetCmb]
AS

SELECT
    [id_cliente],
    [nombre_cliente],
    [nombre_permiso]
FROM
    [dbo].[Cliente]
ORDER BY
    [nombre_cliente]
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_GetOne]
    @id_cliente    int
AS

SELECT
    [id_cliente] AS [Id cliente] ,
    [nombre_cliente] AS [Nombre cliente] ,
    [nombre_permiso] AS [Nombre permiso]
FROM
    [dbo].[Cliente]
WHERE
    [id_cliente]  =  @id_cliente
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_Insert]
    @id_cliente    int  output,
    @nombre_cliente    varchar  (50),
    @nombre_permiso    varchar  (50)
AS

INSERT INTO [dbo].[Cliente]
(
    [nombre_cliente],
    [nombre_permiso]
)
VALUES
(
    @nombre_cliente,
    @nombre_permiso
)
SET @id_cliente = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_InsertOne]
AS

INSERT INTO [dbo].[Cliente]
(
    [nombre_cliente],
    [nombre_permiso]
)
VALUES
(
    'Ninguno',
    'Ninguno'
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Cliente_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Cliente_Update]
    @id_cliente    int  output,
    @nombre_cliente    varchar  (50),
    @nombre_permiso    varchar  (50)
AS

UPDATE [dbo].[Cliente] SET
    [nombre_cliente] = @nombre_cliente,
    [nombre_permiso] = @nombre_permiso
WHERE
    [id_cliente]  =  @id_cliente
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_Delete]
    @id_empresa    int
AS

DELETE FROM [dbo].[Empresa]
WHERE
    [id_empresa]  =  @id_empresa
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_Exist]
    @nombre_empresa    varchar  (50),
    @codigo_empresa    varchar  (50),
    @id_tipo_empresa    int  ,
    @mail_empresa    varchar  (50),
    @password_mail    varchar  (50),
    @logo    varchar  (5000)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_empresa
FROM
    [dbo].[Empresa]
WHERE
    [nombre_empresa] = @nombre_empresa AND
    [codigo_empresa] = @codigo_empresa AND
    [id_tipo_empresa] = @id_tipo_empresa AND
    [mail_empresa] = @mail_empresa AND
    [password_mail] = @password_mail AND
    [logo] = @logo

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_empresa] AS [Id empresa] ,
    RTRIM(nombre_empresa) AS [Nombre empresa] ,
    RTRIM(codigo_empresa) AS [Codigo empresa] ,
    [id_tipo_empresa] AS [Id tipo empresa] ,
    RTRIM(mail_empresa) AS [Mail empresa] ,
    RTRIM(password_mail) AS [Password mail] ,
    RTRIM(logo) AS [Logo]
FROM
    [dbo].[Empresa]
WHERE
    [nombre_empresa] LIKE @nombre+'%'
ORDER BY
    [nombre_empresa]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_GetAll]
AS

SELECT TOP 100
    [id_empresa] AS [Id empresa] ,
    RTRIM(nombre_empresa) AS [Nombre empresa] ,
    RTRIM(codigo_empresa) AS [Codigo empresa] ,
    [id_tipo_empresa] AS [Id tipo empresa] ,
    RTRIM(mail_empresa) AS [Mail empresa] ,
    RTRIM(password_mail) AS [Password mail] ,
    RTRIM(logo) AS [Logo]
FROM
    [dbo].[Empresa]
ORDER BY
    [nombre_empresa]
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Empresa_GetAll_2]
AS

SELECT
    [id_empresa] AS [Id empresa] ,
    RTRIM(nombre_empresa) AS [Nombre empresa] ,
    RTRIM(mail_empresa) AS [Mail empresa] ,
    [nombre_tipo_empresa] AS [tipo empresa] ,
    RTRIM(codigo_empresa) AS [Codigo empresa]
FROM
    [dbo].[Empresa] INNER JOIN
	Tipo_empresa ON Tipo_empresa.id_tipo_empresa = Empresa.id_tipo_empresa
ORDER BY
    [nombre_empresa]


GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_GetAllTipo]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Empresa_GetAllTipo]
	@id_tipo_empresa int
AS

SELECT
    [id_empresa] AS [Id empresa] ,
    RTRIM(nombre_empresa) AS [Nombre empresa] ,
    RTRIM(mail_empresa) AS [Mail empresa] ,
    [id_tipo_empresa] AS [Id tipo empresa] ,
    RTRIM(codigo_empresa) AS [Codigo empresa]
FROM
    [dbo].[Empresa]
WHERE
	id_tipo_empresa = @id_tipo_empresa
ORDER BY
    [nombre_empresa]



GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_GetCmb]
AS

SELECT
    [id_empresa],
    [nombre_empresa],
    [codigo_empresa],
    [id_tipo_empresa],
    [mail_empresa],
    [password_mail],
    [logo]
FROM
    [dbo].[Empresa]
ORDER BY
    [nombre_empresa]
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_GetOne]
    @id_empresa    int
AS

SELECT
    [id_empresa] AS [Id empresa] ,
    [nombre_empresa] AS [Nombre empresa] ,
    [codigo_empresa] AS [Codigo empresa] ,
    [id_tipo_empresa] AS [Id tipo empresa] ,
    [mail_empresa] AS [Mail empresa] ,
    [password_mail] AS [Password mail] ,
    [logo] AS [Logo]
FROM
    [dbo].[Empresa]
WHERE
    [id_empresa]  =  @id_empresa
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_Insert]
    @id_empresa    int  output,
    @nombre_empresa    varchar  (50),
    @codigo_empresa    varchar  (50),
    @id_tipo_empresa    int  ,
    @mail_empresa    varchar  (50),
    @password_mail    varchar  (50),
    @logo    varchar  (5000)
AS

INSERT INTO [dbo].[Empresa]
(
    [nombre_empresa],
    [codigo_empresa],
    [id_tipo_empresa],
    [mail_empresa],
    [password_mail],
    [logo]
)
VALUES
(
    @nombre_empresa,
    @codigo_empresa,
    @id_tipo_empresa,
    @mail_empresa,
    @password_mail,
    @logo
)
SET @id_empresa = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_InsertOne]
AS

INSERT INTO [dbo].[Empresa]
(
    [nombre_empresa],
    [codigo_empresa],
    [id_tipo_empresa],
    [mail_empresa],
    [password_mail],
    [logo]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    1,
    'Ninguno',
    'Ninguno',
    'Ninguno'
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Empresa_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Empresa_Update]
    @id_empresa    int  output,
    @nombre_empresa    varchar  (50),
    @codigo_empresa    varchar  (50),
    @id_tipo_empresa    int  ,
    @mail_empresa    varchar  (50),
    @password_mail    varchar  (50),
    @logo    varchar  (5000)
AS

UPDATE [dbo].[Empresa] SET
    [nombre_empresa] = @nombre_empresa,
    [codigo_empresa] = @codigo_empresa,
    [id_tipo_empresa] = @id_tipo_empresa,
    [mail_empresa] = @mail_empresa,
    [password_mail] = @password_mail,
    [logo] = @logo
WHERE
    [id_empresa]  =  @id_empresa
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_Delete]
    @id_estado_mejora    int
AS

DELETE FROM [dbo].[Estado_mejora]
WHERE
    [id_estado_mejora]  =  @id_estado_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_Exist]
    @nombre_estado_mejora    nchar  (20)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_estado_mejora
FROM
    [dbo].[Estado_mejora]
WHERE
    [nombre_estado_mejora] = @nombre_estado_mejora

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_estado_mejora] AS [Id estado mejora] ,
    [nombre_estado_mejora] AS [Nombre estado mejora]
FROM
    [dbo].[Estado_mejora]
WHERE
    [nombre_estado_mejora] LIKE @nombre+'%'
ORDER BY
    [nombre_estado_mejora]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_GetAll]
AS

SELECT TOP 100
    [id_estado_mejora] AS [Id estado mejora] ,
    [nombre_estado_mejora] AS [Nombre estado mejora]
FROM
    [dbo].[Estado_mejora]
ORDER BY
    [nombre_estado_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_GetCmb]
AS

SELECT
    [id_estado_mejora],
    [nombre_estado_mejora]
FROM
    [dbo].[Estado_mejora]
ORDER BY
    [nombre_estado_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_GetOne]
    @id_estado_mejora    int
AS

SELECT
    [id_estado_mejora] AS [Id estado mejora] ,
    [nombre_estado_mejora] AS [Nombre estado mejora]
FROM
    [dbo].[Estado_mejora]
WHERE
    [id_estado_mejora]  =  @id_estado_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_Insert]
    @id_estado_mejora    int  output,
    @nombre_estado_mejora    nchar  (20)
AS

INSERT INTO [dbo].[Estado_mejora]
(
    [nombre_estado_mejora]
)
VALUES
(
    @nombre_estado_mejora
)
SET @id_estado_mejora = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_InsertOne]
AS

INSERT INTO [dbo].[Estado_mejora]
(
    [nombre_estado_mejora]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_mejora_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_mejora_Update]
    @id_estado_mejora    int  output,
    @nombre_estado_mejora    nchar  (20)
AS

UPDATE [dbo].[Estado_mejora] SET
    [nombre_estado_mejora] = @nombre_estado_mejora
WHERE
    [id_estado_mejora]  =  @id_estado_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_Delete]
    @id_estado_proyecto    int
AS

DELETE FROM [dbo].[Estado_proyecto]
WHERE
    [id_estado_proyecto]  =  @id_estado_proyecto
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_Exist]
    @nombre_estado_proyecto    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_estado_proyecto
FROM
    [dbo].[Estado_proyecto]
WHERE
    [nombre_estado_proyecto] = @nombre_estado_proyecto

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_estado_proyecto] AS [Id estado proyecto] ,
    RTRIM(nombre_estado_proyecto) AS [Nombre estado proyecto]
FROM
    [dbo].[Estado_proyecto]
WHERE
    [nombre_estado_proyecto] LIKE @nombre+'%'
ORDER BY
    [nombre_estado_proyecto]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_GetAll]
AS

SELECT TOP 100
    [id_estado_proyecto] AS [Id estado proyecto] ,
    RTRIM(nombre_estado_proyecto) AS [Nombre estado proyecto]
FROM
    [dbo].[Estado_proyecto]
ORDER BY
    [nombre_estado_proyecto]
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_GetCmb]
AS

SELECT
    [id_estado_proyecto],
    [nombre_estado_proyecto]
FROM
    [dbo].[Estado_proyecto]
ORDER BY
    [nombre_estado_proyecto]
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_GetOne]
    @id_estado_proyecto    int
AS

SELECT
    [id_estado_proyecto] AS [Id estado proyecto] ,
    [nombre_estado_proyecto] AS [Nombre estado proyecto]
FROM
    [dbo].[Estado_proyecto]
WHERE
    [id_estado_proyecto]  =  @id_estado_proyecto
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_Insert]
    @id_estado_proyecto    int  output,
    @nombre_estado_proyecto    varchar  (50)
AS

INSERT INTO [dbo].[Estado_proyecto]
(
    [nombre_estado_proyecto]
)
VALUES
(
    @nombre_estado_proyecto
)
SET @id_estado_proyecto = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_InsertOne]
AS

INSERT INTO [dbo].[Estado_proyecto]
(
    [nombre_estado_proyecto]
)
VALUES
(
    'Ninguno'
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_proyecto_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Estado_proyecto_Update]
    @id_estado_proyecto    int  output,
    @nombre_estado_proyecto    varchar  (50)
AS

UPDATE [dbo].[Estado_proyecto] SET
    [nombre_estado_proyecto] = @nombre_estado_proyecto
WHERE
    [id_estado_proyecto]  =  @id_estado_proyecto
GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_Delete]
    @id_estado_tarea    int
AS

DELETE FROM [dbo].[Estado_tarea]
WHERE
    [id_estado_tarea]  =  @id_estado_tarea


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_Exist]
    @nombre_estado_tarea    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_estado_tarea
FROM
    [dbo].[Estado_tarea]
WHERE
    [nombre_estado_tarea] = @nombre_estado_tarea

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_estado_tarea] AS [Id estado tarea] ,
    RTRIM(nombre_estado_tarea) AS [Nombre estado tarea]
FROM
    [dbo].[Estado_tarea]
WHERE
    [nombre_estado_tarea] LIKE @nombre+'%'
ORDER BY
    [nombre_estado_tarea]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_GetAll]
AS

SELECT TOP 100
    [id_estado_tarea] AS [Id estado tarea] ,
    RTRIM(nombre_estado_tarea) AS [Nombre estado tarea]
FROM
    [dbo].[Estado_tarea]
ORDER BY
    [nombre_estado_tarea]


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_GetCmb]
AS

SELECT
    [id_estado_tarea],
    [nombre_estado_tarea]
FROM
    [dbo].[Estado_tarea]
ORDER BY
    [nombre_estado_tarea]


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_GetOne]
    @id_estado_tarea    int
AS

SELECT
    [id_estado_tarea] AS [Id estado tarea] ,
    [nombre_estado_tarea] AS [Nombre estado tarea]
FROM
    [dbo].[Estado_tarea]
WHERE
    [id_estado_tarea]  =  @id_estado_tarea


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_Insert]
    @id_estado_tarea    int  output,
    @nombre_estado_tarea    varchar  (50)
AS

INSERT INTO [dbo].[Estado_tarea]
(
    [nombre_estado_tarea]
)
VALUES
(
    @nombre_estado_tarea
)
SET @id_estado_tarea = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_InsertOne]
AS

INSERT INTO [dbo].[Estado_tarea]
(
    [nombre_estado_tarea]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Estado_tarea_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Estado_tarea_Update]
    @id_estado_tarea    int  output,
    @nombre_estado_tarea    varchar  (50)
AS

UPDATE [dbo].[Estado_tarea] SET
    [nombre_estado_tarea] = @nombre_estado_tarea
WHERE
    [id_estado_tarea]  =  @id_estado_tarea


GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_Delete]
    @id_feriado    int
AS

DELETE FROM [dbo].[Feriado]
WHERE
    [id_feriado]  =  @id_feriado
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_Exist]
    @nombre_feriado    varchar  (50),
    @fecha    datetime  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_feriado
FROM
    [dbo].[Feriado]
WHERE
    [nombre_feriado] = @nombre_feriado AND
    [fecha] = @fecha

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_feriado] AS [Id feriado] ,
    RTRIM(nombre_feriado) AS [Nombre feriado] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Feriado]
WHERE
    [nombre_feriado] LIKE @nombre+'%'
ORDER BY
    [nombre_feriado]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_GetAll]
AS

SELECT TOP 100
    [id_feriado] AS [Id feriado] ,
    RTRIM(nombre_feriado) AS [Nombre feriado] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Feriado]
ORDER BY
    [nombre_feriado]
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_GetCmb]
AS

SELECT
    [id_feriado],
    [nombre_feriado],
    [fecha]
FROM
    [dbo].[Feriado]
ORDER BY
    [nombre_feriado]
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_GetOne]
    @id_feriado    int
AS

SELECT
    [id_feriado] AS [Id feriado] ,
    [nombre_feriado] AS [Nombre feriado] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Feriado]
WHERE
    [id_feriado]  =  @id_feriado
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_GetOne_Fecha]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Feriado_GetOne_Fecha]
    @fecha    datetime
AS

SELECT
    [id_feriado] AS [Id feriado] ,
    [nombre_feriado] AS [Nombre feriado] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Feriado]
WHERE
    DAY([fecha])  =  DAY(@fecha) AND
	MONTH([fecha])  =  MONTH(@fecha) AND
	YEAR([fecha])  =  YEAR(@fecha)

GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_Insert]
    @id_feriado    int  output,
    @nombre_feriado    varchar  (50),
    @fecha    datetime  
AS

INSERT INTO [dbo].[Feriado]
(
    [nombre_feriado],
    [fecha]
)
VALUES
(
    @nombre_feriado,
    @fecha
)
SET @id_feriado = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_InsertOne]
AS

INSERT INTO [dbo].[Feriado]
(
    [nombre_feriado],
    [fecha]
)
VALUES
(
    'Ninguno',
    '01-01-2000'
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Feriado_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Feriado_Update]
    @id_feriado    int  output,
    @nombre_feriado    varchar  (50),
    @fecha    datetime  
AS

UPDATE [dbo].[Feriado] SET
    [nombre_feriado] = @nombre_feriado,
    [fecha] = @fecha
WHERE
    [id_feriado]  =  @id_feriado
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_Delete]
    @id_gantt    int
AS

DELETE FROM [dbo].[Gantt]
WHERE
    [id_gantt]  =  @id_gantt
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_Exist]
    @dia    varchar  (50),
    @fecha    datetime  ,
    @nombre_usuario    varchar  (50),
    @horas    decimal  (18,2),
    @es_feriado    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_gantt
FROM
    [dbo].[Gantt]
WHERE
    [dia] = @dia AND
    [fecha] = @fecha AND
    [nombre_usuario] = @nombre_usuario AND
    [horas] = @horas AND
    [es_feriado] = @es_feriado

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_gantt] AS [Id gantt] ,
    RTRIM(dia) AS [Dia] ,
    [fecha] AS [Fecha] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    [horas] AS [Horas] ,
    [es_feriado] AS [Es feriado]
FROM
    [dbo].[Gantt]
WHERE
    [dia] LIKE @nombre+'%'
ORDER BY
    [dia]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_GetAll]
AS

SELECT TOP 100
    [id_gantt] AS [Id gantt] ,
    RTRIM(dia) AS [Dia] ,
    [fecha] AS [Fecha] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    [horas] AS [Horas] ,
    [es_feriado] AS [Es feriado]
FROM
    [dbo].[Gantt]
ORDER BY
    [dia]
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Gantt_GetAll_2]
AS

SELECT
    [id_gantt] AS [Id gantt] ,
    RTRIM(dia) AS [Día] ,
    [fecha] AS [Fecha] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    [horas] AS [Horas],
	es_feriado AS [Es feriado]
FROM
    [dbo].[Gantt]
ORDER BY
    fecha
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_GetCmb]
AS

SELECT
    [id_gantt],
    [dia],
    [fecha],
    [nombre_usuario],
    [horas],
    [es_feriado]
FROM
    [dbo].[Gantt]
ORDER BY
    [dia]
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_GetOne]
    @id_gantt    int
AS

SELECT
    [id_gantt] AS [Id gantt] ,
    [dia] AS [Dia] ,
    [fecha] AS [Fecha] ,
    [nombre_usuario] AS [Nombre usuario] ,
    [horas] AS [Horas] ,
    [es_feriado] AS [Es feriado]
FROM
    [dbo].[Gantt]
WHERE
    [id_gantt]  =  @id_gantt
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_Insert]
    @id_gantt    int  output,
    @dia    varchar  (50),
    @fecha    datetime  ,
    @nombre_usuario    varchar  (50),
    @horas    decimal  (18,2),
    @es_feriado    bit  
AS

INSERT INTO [dbo].[Gantt]
(
    [dia],
    [fecha],
    [nombre_usuario],
    [horas],
    [es_feriado]
)
VALUES
(
    @dia,
    @fecha,
    @nombre_usuario,
    @horas,
    @es_feriado
)
SET @id_gantt = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_InsertOne]
AS

INSERT INTO [dbo].[Gantt]
(
    [dia],
    [fecha],
    [nombre_usuario],
    [horas],
    [es_feriado]
)
VALUES
(
    'Ninguno',
    '01-01-2000',
    'Ninguno',
    0,
     0 
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Gantt_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Gantt_Update]
    @id_gantt    int  output,
    @dia    varchar  (50),
    @fecha    datetime  ,
    @nombre_usuario    varchar  (50),
    @horas    decimal  (18,2),
    @es_feriado    bit  
AS

UPDATE [dbo].[Gantt] SET
    [dia] = @dia,
    [fecha] = @fecha,
    [nombre_usuario] = @nombre_usuario,
    [horas] = @horas,
    [es_feriado] = @es_feriado
WHERE
    [id_gantt]  =  @id_gantt
GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_Delete]
    @id_hora_real    int
AS

DELETE FROM [dbo].[Hora_real]
WHERE
    [id_hora_real]  =  @id_hora_real


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_Real_DeleteTarea]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_Real_DeleteTarea]
    @id_Tarea    int,
    @id_usuario int
AS

DELETE FROM [dbo].[Hora_Real]
WHERE
    [id_tarea] = @id_Tarea AND
    [id_usuario] = @id_usuario


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_Exist]
    @id_tarea    int  ,
    @id_usuario    int  ,
    @fecha_carga    datetime  ,
    @hora_real    decimal  (18,2),
    @id_usuario_asignado    int  ,
    @comentario    varchar  (5000),
    @costo    decimal  (18,2)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_hora_real
FROM
    [dbo].[Hora_real]
WHERE
    [id_tarea] = @id_tarea AND
    [id_usuario] = @id_usuario AND
    [fecha_carga] = @fecha_carga AND
    [hora_real] = @hora_real AND
    [id_usuario_asignado] = @id_usuario_asignado AND
    [comentario] = @comentario AND
    [costo] = @costo

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_hora_real] AS [Id hora real] ,
    [id_tarea] AS [Id tarea] ,
    [id_usuario] AS [Id usuario] ,
    [fecha_carga] AS [Fecha carga] ,
    [hora_real] AS [Hora real] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    RTRIM(comentario) AS [Comentario] ,
    [costo] AS [Costo]
FROM
    [dbo].[Hora_real]
WHERE
    [id_tarea] LIKE @nombre+'%'
ORDER BY
    [id_tarea]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_GetAll]
AS

SELECT TOP 100
    [id_hora_real] AS [Id hora real] ,
    [id_tarea] AS [Id tarea] ,
    [id_usuario] AS [Id usuario] ,
    [fecha_carga] AS [Fecha carga] ,
    [hora_real] AS [Hora real] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    RTRIM(comentario) AS [Comentario] ,
    [costo] AS [Costo]
FROM
    [dbo].[Hora_real]
ORDER BY
    [id_tarea]


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_GetCmb]
AS

SELECT
    [id_hora_real],
    [id_tarea],
    [id_usuario],
    [fecha_carga],
    [hora_real],
    [id_usuario_asignado],
    [comentario],
    [costo]
FROM
    [dbo].[Hora_real]
ORDER BY
    [id_tarea]


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_GetOne]
    @id_hora_real    int
AS

SELECT
    [id_hora_real] AS [Id hora real] ,
    [id_tarea] AS [Id tarea] ,
    [id_usuario] AS [Id usuario] ,
    [fecha_carga] AS [Fecha carga] ,
    [hora_real] AS [Hora real] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [comentario] AS [Comentario] ,
    [costo] AS [Costo]
FROM
    [dbo].[Hora_real]
WHERE
    [id_hora_real]  =  @id_hora_real


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_GetTarea]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_GetTarea]
	@id_tarea int
AS

SELECT
    [id_hora_real] AS [Id hora real] ,
    hora_real.[id_tarea] AS [Id tarea] ,
    [identificador] AS [usuario] ,
    [fecha_carga] AS [Fecha carga] ,
    hora_real.[hora_real] AS [Hora real],
	RTRIM(comentario) AS [Comentario] ,
    hora_real.[costo] AS [Costo]
FROM
    [dbo].[Hora_real] INNER JOIN
	usuario ON usuario.id_usuario = hora_real.id_usuario_asignado
WHERE
	Hora_real.id_tarea = @id_tarea
ORDER BY
    [id_hora_real]


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_Insert]
    @id_hora_real    int  output,
    @id_tarea    int  ,
    @id_usuario    int  ,
    @fecha_carga    datetime  ,
    @hora_real    decimal  (18,2),
    @id_usuario_asignado    int  ,
    @comentario    varchar  (5000),
    @costo    decimal  (18,2)
AS

INSERT INTO [dbo].[Hora_real]
(
    [id_tarea],
    [id_usuario],
    [fecha_carga],
    [hora_real],
    [id_usuario_asignado],
    [comentario],
    [costo]
)
VALUES
(
    @id_tarea,
    @id_usuario,
    @fecha_carga,
    @hora_real,
    @id_usuario_asignado,
    @comentario,
    @costo
)
SET @id_hora_real = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_InsertOne]
AS

INSERT INTO [dbo].[Hora_real]
(
    [id_tarea],
    [id_usuario],
    [fecha_carga],
    [hora_real],
    [id_usuario_asignado],
    [comentario],
    [costo]
)
VALUES
(
    1,
    1,
    '01-01-2000',
    0,
    1,
    'Ninguno',
     0 
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_real_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_real_Update]
    @id_hora_real    int  output,
    @id_tarea    int  ,
    @id_usuario    int  ,
    @fecha_carga    datetime  ,
    @hora_real    decimal  (18,2),
    @id_usuario_asignado    int  ,
    @comentario    varchar  (5000),
    @costo    decimal  (18,2)
AS

UPDATE [dbo].[Hora_real] SET
    [id_tarea] = @id_tarea,
    [id_usuario] = @id_usuario,
    [fecha_carga] = @fecha_carga,
    [hora_real] = @hora_real,
    [id_usuario_asignado] = @id_usuario_asignado,
    [comentario] = @comentario,
    [costo] = @costo
WHERE
    [id_hora_real]  =  @id_hora_real


GO
/****** Object:  StoredProcedure [dbo].[cop_Hora_Real_UpdateID]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Hora_Real_UpdateID]
    @id_Tarea int,
    @id_usuario int
AS

UPDATE [dbo].[Hora_real] SET
    [id_tarea] = @id_Tarea 
WHERE
    [id_tarea] = 0 AND
    [id_usuario] = @id_usuario


GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_Delete]
    @id_log_error    int
AS

DELETE FROM [dbo].[Log_error]
WHERE
    [id_log_error]  =  @id_log_error



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_Exist]
    @fecha    datetime  ,
    @numero    varchar  (50),
    @mensaje    varchar  (5000),
    @origen    varchar  (5000),
    @descripcion    varchar  (8000)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_log_error
FROM
    [dbo].[Log_error]
WHERE
    [fecha] = @fecha AND
    [numero] = @numero AND
    [mensaje] = @mensaje AND
    [origen] = @origen AND
    [descripcion] = @descripcion

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_log_error] AS [Id log error] ,
    [fecha] AS [Fecha] ,
    RTRIM(numero) AS [Numero] ,
    RTRIM(mensaje) AS [Mensaje] ,
    RTRIM(origen) AS [Origen] ,
    RTRIM(descripcion) AS [Descripcion]
FROM
    [dbo].[Log_error]
WHERE
    [fecha] LIKE @nombre+'%'
ORDER BY
    [fecha]
END



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_GetAll]
AS

SELECT TOP 100
    [id_log_error] AS [Id log error] ,
    [fecha] AS [Fecha] ,
    RTRIM(numero) AS [Numero] ,
    RTRIM(mensaje) AS [Mensaje] ,
    RTRIM(origen) AS [Origen] ,
    RTRIM(descripcion) AS [Descripcion]
FROM
    [dbo].[Log_error]
ORDER BY
    [fecha]



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_GetCmb]
AS

SELECT
    [id_log_error],
    [fecha],
    [numero],
    [mensaje],
    [origen],
    [descripcion]
FROM
    [dbo].[Log_error]
ORDER BY
    [fecha]



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_GetOne]
    @id_log_error    int
AS

SELECT
    [id_log_error] AS [Id log error] ,
    [fecha] AS [Fecha] ,
    [numero] AS [Numero] ,
    [mensaje] AS [Mensaje] ,
    [origen] AS [Origen] ,
    [descripcion] AS [Descripcion]
FROM
    [dbo].[Log_error]
WHERE
    [id_log_error]  =  @id_log_error



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_Insert]
    @id_log_error    int  output,
    @fecha    datetime  ,
    @numero    varchar  (50),
    @mensaje    varchar  (5000),
    @origen    varchar  (5000),
    @descripcion    varchar  (8000)
AS

INSERT INTO [dbo].[Log_error]
(
    [fecha],
    [numero],
    [mensaje],
    [origen],
    [descripcion]
)
VALUES
(
    @fecha,
    @numero,
    @mensaje,
    @origen,
    @descripcion
)
SET @id_log_error = @@IDENTITY



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_InsertOne]
AS

INSERT INTO [dbo].[Log_error]
(
    [fecha],
    [numero],
    [mensaje],
    [origen],
    [descripcion]
)
VALUES
(
    '01-01-2000',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno'
)



GO
/****** Object:  StoredProcedure [dbo].[cop_Log_error_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Log_error_Update]
    @id_log_error    int  output,
    @fecha    datetime  ,
    @numero    varchar  (50),
    @mensaje    varchar  (5000),
    @origen    varchar  (5000),
    @descripcion    varchar  (8000)
AS

UPDATE [dbo].[Log_error] SET
    [fecha] = @fecha,
    [numero] = @numero,
    [mensaje] = @mensaje,
    [origen] = @origen,
    [descripcion] = @descripcion
WHERE
    [id_log_error]  =  @id_log_error



GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_Delete]
    @id_mejora_accion    int
AS

DELETE FROM [dbo].[Mejora_accion]
WHERE
    [id_mejora_accion]  =  @id_mejora_accion


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_Exist]
    @id_mejora    int  ,
    @fecha_accion    datetime  ,
    @id_usuario_accion    int  ,
    @descripccion_accion    varchar  (5000)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_mejora_accion
FROM
    [dbo].[Mejora_accion]
WHERE
    [id_mejora] = @id_mejora AND
    [fecha_accion] = @fecha_accion AND
    [id_usuario_accion] = @id_usuario_accion AND
    [descripccion_accion] = @descripccion_accion

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_mejora_accion] AS [Id mejora accion] ,
    [id_mejora] AS [Id mejora] ,
    [fecha_accion] AS [Fecha accion] ,
    [id_usuario_accion] AS [Id usuario accion] ,
    RTRIM(descripccion_accion) AS [Descripccion accion]
FROM
    [dbo].[Mejora_accion]
WHERE
    [id_mejora] LIKE @nombre+'%'
ORDER BY
    [id_mejora]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_GetAll]
AS

SELECT TOP 100
    [id_mejora_accion] AS [Id mejora accion] ,
    [id_mejora] AS [Id mejora] ,
    [fecha_accion] AS [Fecha accion] ,
    [id_usuario_accion] AS [Id usuario accion] ,
    RTRIM(descripccion_accion) AS [Descripccion accion]
FROM
    [dbo].[Mejora_accion]
ORDER BY
    [id_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_GetAll_2]
	@id_mejora int
AS

SELECT
    [id_mejora_accion] AS [Id mejora accion] ,
    [fecha_accion] AS [Fecha] ,
    [nombre_usuario] AS [Usuario] ,
    RTRIM(descripccion_accion) AS [Descripccion]
FROM
    [dbo].[Mejora_accion] INNER JOIN
	Usuario ON Usuario.id_usuario = mejora_accion.id_usuario_accion
WHERE	
	Mejora_accion.id_mejora = @id_mejora

GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_GetCmb]
AS

SELECT
    [id_mejora_accion],
    [id_mejora],
    [fecha_accion],
    [id_usuario_accion],
    [descripccion_accion]
FROM
    [dbo].[Mejora_accion]
ORDER BY
    [id_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_GetOne]
    @id_mejora_accion    int
AS

SELECT
    [id_mejora_accion] AS [Id mejora accion] ,
    [id_mejora] AS [Id mejora] ,
    [fecha_accion] AS [Fecha accion] ,
    [id_usuario_accion] AS [Id usuario accion] ,
    [descripccion_accion] AS [Descripccion accion]
FROM
    [dbo].[Mejora_accion]
WHERE
    [id_mejora_accion]  =  @id_mejora_accion


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_Insert]
    @id_mejora_accion    int  output,
    @id_mejora    int  ,
    @fecha_accion    datetime  ,
    @id_usuario_accion    int  ,
    @descripccion_accion    varchar  (5000)
AS

INSERT INTO [dbo].[Mejora_accion]
(
    [id_mejora],
    [fecha_accion],
    [id_usuario_accion],
    [descripccion_accion]
)
VALUES
(
    @id_mejora,
    @fecha_accion,
    @id_usuario_accion,
    @descripccion_accion
)
SET @id_mejora_accion = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_InsertOne]
AS

INSERT INTO [dbo].[Mejora_accion]
(
    [id_mejora],
    [fecha_accion],
    [id_usuario_accion],
    [descripccion_accion]
)
VALUES
(
    1,
    '01-01-2000',
    1,
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_Update]
    @id_mejora_accion    int  output,
    @id_mejora    int  ,
    @fecha_accion    datetime  ,
    @id_usuario_accion    int  ,
    @descripccion_accion    varchar  (5000)
AS

UPDATE [dbo].[Mejora_accion] SET
    [id_mejora] = @id_mejora,
    [fecha_accion] = @fecha_accion,
    [id_usuario_accion] = @id_usuario_accion,
    [descripccion_accion] = @descripccion_accion
WHERE
    [id_mejora_accion]  =  @id_mejora_accion


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_accion_UpdateID]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_accion_UpdateID]
    @id_mejora    int 
AS

UPDATE [dbo].[Mejora_accion] SET
    [id_mejora] = @id_mejora
WHERE
    [id_mejora]  =  0


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_Delete]
    @id_mejora    int
AS

DELETE FROM [dbo].[Mejora]
WHERE
    [id_mejora]  =  @id_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_Exist]
    @descripcion_mejora    varchar  (5000),
    @id_tipo_mejora    int  ,
    @id_sub_proyecto    int  ,
    @fecha_prevista_cierre    datetime  ,
    @fecha_real    datetime  ,
    @prioridad    decimal  (18,0),
    @id_usuario    int  ,
    @id_usuario_asignado    int  ,
    @id_origen_mejora    int  ,
    @ubicacion_archivos    varchar  (5000),
    @id_responsable_analisis    int  ,
    @descripcion_causa    varchar  (5000),
    @id_metodo_causa    int  ,
    @fecha_causa    datetime  ,
    @fecha_finalizacion_accion    datetime  ,
    @id_usuario_accion_correctiva    int  ,
    @descripcion_accion_correctiva    varchar  (5000),
    @prevision_accion_correctiva    varchar  (5000),
    @fecha_accion_correctiva    datetime  ,
    @id_usuario_cierre    int  ,
    @analisis_eficacia    char  (1),
    @descripcion_cierre    varchar  (5000),
    @numero_accion_relacionada    decimal  (18,0),
    @costo_prevencion    decimal  (18,2),
    @costo_acciones    decimal  (18,2),
    @costo_no_calidad    decimal  (18,2),
    @costo_total    decimal  (18,2),
    @fecha_cierre    datetime  ,
    @id_estado_mejora    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_mejora
FROM
    [dbo].[Mejora]
WHERE
    [descripcion_mejora] = @descripcion_mejora AND
    [id_tipo_mejora] = @id_tipo_mejora AND
    [id_sub_proyecto] = @id_sub_proyecto AND
    [fecha_prevista_cierre] = @fecha_prevista_cierre AND
    [fecha_real] = @fecha_real AND
    [prioridad] = @prioridad AND
    [id_usuario] = @id_usuario AND
    [id_usuario_asignado] = @id_usuario_asignado AND
    [id_origen_mejora] = @id_origen_mejora AND
    [ubicacion_archivos] = @ubicacion_archivos AND
    [id_responsable_analisis] = @id_responsable_analisis AND
    [descripcion_causa] = @descripcion_causa AND
    [id_metodo_causa] = @id_metodo_causa AND
    [fecha_causa] = @fecha_causa AND
    [fecha_finalizacion_accion] = @fecha_finalizacion_accion AND
    [id_usuario_accion_correctiva] = @id_usuario_accion_correctiva AND
    [descripcion_accion_correctiva] = @descripcion_accion_correctiva AND
    [prevision_accion_correctiva] = @prevision_accion_correctiva AND
    [fecha_accion_correctiva] = @fecha_accion_correctiva AND
    [id_usuario_cierre] = @id_usuario_cierre AND
    [analisis_eficacia] = @analisis_eficacia AND
    [descripcion_cierre] = @descripcion_cierre AND
    [numero_accion_relacionada] = @numero_accion_relacionada AND
    [costo_prevencion] = @costo_prevencion AND
    [costo_acciones] = @costo_acciones AND
    [costo_no_calidad] = @costo_no_calidad AND
    [costo_total] = @costo_total AND
    [fecha_cierre] = @fecha_cierre AND
    [id_estado_mejora] = @id_estado_mejora

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_mejora] AS [Id mejora] ,
    RTRIM(descripcion_mejora) AS [Descripcion mejora] ,
    [id_tipo_mejora] AS [Id tipo mejora] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    [fecha_prevista_cierre] AS [Fecha prevista cierre] ,
    [fecha_real] AS [Fecha real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [id_origen_mejora] AS [Id origen mejora] ,
    RTRIM(ubicacion_archivos) AS [Ubicacion archivos] ,
    [id_responsable_analisis] AS [Id responsable analisis] ,
    RTRIM(descripcion_causa) AS [Descripcion causa] ,
    [id_metodo_causa] AS [Id metodo causa] ,
    [fecha_causa] AS [Fecha causa] ,
    [fecha_finalizacion_accion] AS [Fecha finalizacion accion] ,
    [id_usuario_accion_correctiva] AS [Id usuario accion correctiva] ,
    RTRIM(descripcion_accion_correctiva) AS [Descripcion accion correctiva] ,
    RTRIM(prevision_accion_correctiva) AS [Prevision accion correctiva] ,
    [fecha_accion_correctiva] AS [Fecha accion correctiva] ,
    [id_usuario_cierre] AS [Id usuario cierre] ,
    [analisis_eficacia] AS [Analisis eficacia] ,
    RTRIM(descripcion_cierre) AS [Descripcion cierre] ,
    [numero_accion_relacionada] AS [Numero accion relacionada] ,
    [costo_prevencion] AS [Costo prevencion] ,
    [costo_acciones] AS [Costo acciones] ,
    [costo_no_calidad] AS [Costo no calidad] ,
    [costo_total] AS [Costo total] ,
    [fecha_cierre] AS [Fecha cierre] ,
    [id_estado_mejora] AS [Id estado mejora]
FROM
    [dbo].[Mejora]
WHERE
    [descripcion_mejora] LIKE @nombre+'%'
ORDER BY
    [descripcion_mejora]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_GetAll]
AS

SELECT TOP 100
    [id_mejora] AS [Id mejora] ,
    RTRIM(descripcion_mejora) AS [Descripcion mejora] ,
    [id_tipo_mejora] AS [Id tipo mejora] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    [fecha_prevista_cierre] AS [Fecha prevista cierre] ,
    [fecha_real] AS [Fecha real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [id_origen_mejora] AS [Id origen mejora] ,
    RTRIM(ubicacion_archivos) AS [Ubicacion archivos] ,
    [id_responsable_analisis] AS [Id responsable analisis] ,
    RTRIM(descripcion_causa) AS [Descripcion causa] ,
    [id_metodo_causa] AS [Id metodo causa] ,
    [fecha_causa] AS [Fecha causa] ,
    [fecha_finalizacion_accion] AS [Fecha finalizacion accion] ,
    [id_usuario_accion_correctiva] AS [Id usuario accion correctiva] ,
    RTRIM(descripcion_accion_correctiva) AS [Descripcion accion correctiva] ,
    RTRIM(prevision_accion_correctiva) AS [Prevision accion correctiva] ,
    [fecha_accion_correctiva] AS [Fecha accion correctiva] ,
    [id_usuario_cierre] AS [Id usuario cierre] ,
    [analisis_eficacia] AS [Analisis eficacia] ,
    RTRIM(descripcion_cierre) AS [Descripcion cierre] ,
    [numero_accion_relacionada] AS [Numero accion relacionada] ,
    [costo_prevencion] AS [Costo prevencion] ,
    [costo_acciones] AS [Costo acciones] ,
    [costo_no_calidad] AS [Costo no calidad] ,
    [costo_total] AS [Costo total] ,
    [fecha_cierre] AS [Fecha cierre] ,
    [id_estado_mejora] AS [Id estado mejora]
FROM
    [dbo].[Mejora]
ORDER BY
    [descripcion_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_GetAllMaestro]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_GetAllMaestro]
	@bandera int,
	@id_empresa int,
	@id_proyecto int,
	@id_sub_proyecto int,
	@id_usuario int,
	@id_estado_mejora int,
	@bandera_estado bit,
	@todo bit,
	@usuario bit,
	@tipo_mejora bit,
	@es_entre_fecha bit,
	@id_tipo_mejora int,
	@fecha_inicio datetime,
	@fecha_fin datetime
AS
IF @bandera is null
begin
	set @bandera = 1
end


--6 if anidados
--el primero referenciado a el filtro de fechas
--el segundo referenciado al filtro de tipo de tareas
--el tercero representa el check todo
--el cuarto si se desea filtrar por usuario asignado
--el quinto cada uno de los radio buttons
--y el sexto el estado al que se desea  filtrar (checkbox)


--ESTRUCTURA DEL ANIDAMIENTO

--IF @TODO = x --REPRESENTACION DEL CHECKBOX TODO
	-- Todo = 1 (se filtra por todo teniendo en cuenta el combo anterior)
	-- Todo = 0 (Se filtra teniendo en cuenta el combo seleccionado)
	--IF @usuario x --REPRESENTA EL CHECK USUARIO ASIGANDO
		--USUARIO = 1 (filtro por usuario, toda las consultas where contienen el filtro)
		--USUARIO = 0 (filtro normalmente sin tener en cuenta el usuario)
	--	IF @bandera = x --REPRESENTA VALOR SELECCIONADIO DE RADIO BUTTONS (EMPRESA, PROYECTO, SUBPROYECTO)
	--		IF @bandera_estado = x --REPRESENTA EL CHECKBOX FILTRAR ESTADO.



IF @todo = 1 --Todo x ...
BEGIN
	IF @es_entre_fecha = 1
	BEGIN
		IF @tipo_mejora = 1
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		WHERE
				--			mejora.id_estado_mejora = @id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre
			END

			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
			END
		END

		IF @tipo_mejora = 0
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_usuario_asignado = @id_usuario AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_usuario_asignado = @id_usuario AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_usuario_asignado = @id_usuario AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		WHERE
				--			mejora.id_estado_mejora = @id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre
			END
			
			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
			END
		END
	END

	IF @es_entre_fecha = 0
	BEGIN
		IF @tipo_mejora = 1
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_usuario_asignado = @id_usuario AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		WHERE
				--			mejora.id_estado_mejora = @id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre
			END

			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
			END
		END

		IF @tipo_mejora = 0
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_usuario_asignado = @id_usuario 
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_usuario_asignado = @id_usuario 
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_usuario_asignado = @id_usuario 
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_usuario_asignado = @id_usuario
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		WHERE
				--			mejora.id_estado_mejora = @id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_mejora] AS [Id mejora] ,
				--			[nombre_estado_mejora] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_mejora] AS [Tipo mejora] ,
				--			RTRIM(descripcion_mejora) AS [Descripcion] ,
				--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
				--			mejora.[fecha_real] AS [Fecha real] ,
				--			
				--			
				--			RTRIM(comentario) AS [Comentario] ,
				--			[id_mejora] AS [N° Mejora] ,
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[nombre_usuario] AS [Asignado]
				--		FROM
				--			[dbo].[Mejora] INNER JOIN
				--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
				--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
				--		ORDER BY
				--			[prioridad],
				--			mejora.fecha_prevista_cierre
			END
			
			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_estado_mejora = @id_estado_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END
			END
		END
	END

END


IF @todo = 0 --Por seleccion de Radio Buttons
BEGIN
	IF @es_entre_fecha = 1
	BEGIN
		IF @tipo_mejora = 1
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_estado_mejora = @id_estado_mejora AND
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							proyecto.id_empresa = @id_empresa AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							mejora.id_tipo_mejora = @id_tipo_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END

			END
		END

		IF @tipo_mejora = 0
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_estado_mejora = @id_estado_mejora AND
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario AND
						[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
						[dbo].[Mejora].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							proyecto.id_empresa = @id_empresa AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							[dbo].[Mejora].[fecha_real] >= @fecha_inicio AND
							[dbo].[Mejora].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END

			END
		END
	END

	IF @es_entre_fecha = 0
	BEGIN
		IF @tipo_mejora = 1
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_estado_mejora = @id_estado_mejora AND
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario AND
						mejora.id_tipo_mejora = @id_tipo_mejora
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							proyecto.id_empresa = @id_empresa AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							mejora.id_tipo_mejora = @id_tipo_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END

			END
		END

		IF @tipo_mejora = 0
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_estado_mejora = @id_estado_mejora AND
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						proyecto.id_empresa = @id_empresa AND
						mejora.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						sub_proyecto.id_proyecto = @id_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto AND
						mejora.id_estado_mejora = @id_estado_mejora AND
						mejora.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_mejora] AS [Id mejora] ,
						[nombre_estado_mejora] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_mejora] AS [Tipo mejora] ,
						RTRIM(descripcion_mejora) AS [Descripcion] ,
						mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
						DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
						mejora.[fecha_real] AS [Fecha real] ,
						
						
						[id_mejora] AS [N° Mejora] ,
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[nombre_usuario] AS [Asignado]
					FROM
						[dbo].[Mejora] INNER JOIN
						Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
						estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
					WHERE
						mejora.id_sub_proyecto = @id_sub_proyecto  AND
						mejora.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						mejora.fecha_prevista_cierre

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_estado_mejora = @id_estado_mejora AND
							proyecto.id_empresa = @id_empresa
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							proyecto.id_empresa = @id_empresa
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							sub_proyecto.id_proyecto = @id_proyecto
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto AND
							mejora.id_estado_mejora = @id_estado_mejora
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_mejora] AS [Id mejora] ,
							[nombre_estado_mejora] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_mejora] AS [Tipo mejora] ,
							RTRIM(descripcion_mejora) AS [Descripcion] ,
							mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
							DATEDIFF(d, mejora.[fecha_prevista_cierre], getdate()) AS Demora,
							mejora.[fecha_real] AS [Fecha real] ,
							
							
							[id_mejora] AS [N° Mejora] ,
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[nombre_usuario] AS [Asignado]
						FROM
							[dbo].[Mejora] INNER JOIN
							Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
							estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
						WHERE
							mejora.id_sub_proyecto = @id_sub_proyecto
						ORDER BY
							[prioridad],
							mejora.fecha_prevista_cierre

				END

			END
		END
	END

	--IF @bandera = 4 --Por Usuario(NO SE USA MAS)
	--BEGIN
	--	IF @bandera_estado = 1
	--		SELECT
	--			[id_mejora] AS [Id mejora] ,
	--			[nombre_estado_mejora] AS [Estado] ,
	--			[prioridad] AS [Prioridad] ,
	--			[nombre_tipo_mejora] AS [Tipo mejora] ,
	--			RTRIM(descripcion_mejora) AS [Descripcion] ,
	--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
	--			mejora.[fecha_real] AS [Fecha real] ,
	--			
	--			
	--			RTRIM(comentario) AS [Comentario] ,
	--			[id_mejora] AS [N° Mejora] ,
	--			[nombre_empresa] AS [Empresa] ,
	--			[nombre_proyecto] AS [proyecto] ,
	--			[nombre_sub_proyecto] AS [sub proyecto] ,
	--			[nombre_usuario] AS [Asignado]
	--		FROM
	--			[dbo].[Mejora] INNER JOIN
	--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
	--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
	--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
	--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
	--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
	--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
	--		WHERE
	--			mejora.id_usuario_asignado = @id_usuario AND
	--			mejora.id_estado_mejora = @id_estado_mejora
	--		ORDER BY
	--			[prioridad],
	--			mejora.fecha_prevista_cierre

	--	IF @bandera_estado = 0
	--		SELECT
	--			[id_mejora] AS [Id mejora] ,
	--			[nombre_estado_mejora] AS [Estado] ,
	--			[prioridad] AS [Prioridad] ,
	--			[nombre_tipo_mejora] AS [Tipo mejora] ,
	--			RTRIM(descripcion_mejora) AS [Descripcion] ,
	--			mejora.[fecha_prevista_cierre] AS [Fecha prevista] ,
	--			mejora.[fecha_real] AS [Fecha real] ,
	--			
	--			
	--			RTRIM(comentario) AS [Comentario] ,
	--			[id_mejora] AS [N° Mejora] ,
	--			[nombre_empresa] AS [Empresa] ,
	--			[nombre_proyecto] AS [proyecto] ,
	--			[nombre_sub_proyecto] AS [sub proyecto] ,
	--			[nombre_usuario] AS [Asignado]
	--		FROM
	--			[dbo].[Mejora] INNER JOIN
	--			Tipo_mejora ON Tipo_mejora.id_tipo_mejora = mejora.id_tipo_mejora INNER JOIN
	--			sub_proyecto ON sub_proyecto.id_sub_proyecto = mejora.id_sub_proyecto INNER JOIN
	--			proyecto ON proyecto.id_proyecto = sub_proyecto.id_proyecto INNER JOIN
	--			empresa ON empresa.id_empresa = proyecto.id_empresa INNER JOIN
	--			usuario ON usuario.id_usuario = mejora.id_usuario_asignado INNER JOIN
	--			estado_mejora ON estado_mejora.id_estado_mejora = mejora.id_estado_mejora
	--		WHERE
	--			mejora.id_usuario_asignado = @id_usuario
	--		ORDER BY
	--			[prioridad],
	--			mejora.fecha_prevista_cierre
	--END

END



GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_GetCmb]
AS

SELECT
    [id_mejora],
    [descripcion_mejora],
    [id_tipo_mejora],
    [id_sub_proyecto],
    [fecha_prevista_cierre],
    [fecha_real],
    [prioridad],
    [id_usuario],
    [id_usuario_asignado],
    [id_origen_mejora],
    [ubicacion_archivos],
    [id_responsable_analisis],
    [descripcion_causa],
    [id_metodo_causa],
    [fecha_causa],
    [fecha_finalizacion_accion],
    [id_usuario_accion_correctiva],
    [descripcion_accion_correctiva],
    [prevision_accion_correctiva],
    [fecha_accion_correctiva],
    [id_usuario_cierre],
    [analisis_eficacia],
    [descripcion_cierre],
    [numero_accion_relacionada],
    [costo_prevencion],
    [costo_acciones],
    [costo_no_calidad],
    [costo_total],
    [fecha_cierre],
    [id_estado_mejora]
FROM
    [dbo].[Mejora]
ORDER BY
    [descripcion_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_GetOne]
    @id_mejora    int
AS

SELECT
    [id_mejora] AS [Id mejora] ,
    [descripcion_mejora] AS [Descripcion mejora] ,
    [id_tipo_mejora] AS [Id tipo mejora] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    [fecha_prevista_cierre] AS [Fecha prevista cierre] ,
    [fecha_real] AS [Fecha real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [id_origen_mejora] AS [Id origen mejora] ,
    [ubicacion_archivos] AS [Ubicacion archivos] ,
    [id_responsable_analisis] AS [Id responsable analisis] ,
    [descripcion_causa] AS [Descripcion causa] ,
    [id_metodo_causa] AS [Id metodo causa] ,
    [fecha_causa] AS [Fecha causa] ,
    [fecha_finalizacion_accion] AS [Fecha finalizacion accion] ,
    [id_usuario_accion_correctiva] AS [Id usuario accion correctiva] ,
    [descripcion_accion_correctiva] AS [Descripcion accion correctiva] ,
    [prevision_accion_correctiva] AS [Prevision accion correctiva] ,
    [fecha_accion_correctiva] AS [Fecha accion correctiva] ,
    [id_usuario_cierre] AS [Id usuario cierre] ,
    [analisis_eficacia] AS [Analisis eficacia] ,
    [descripcion_cierre] AS [Descripcion cierre] ,
    [numero_accion_relacionada] AS [Numero accion relacionada] ,
    [costo_prevencion] AS [Costo prevencion] ,
    [costo_acciones] AS [Costo acciones] ,
    [costo_no_calidad] AS [Costo no calidad] ,
    [costo_total] AS [Costo total] ,
    [fecha_cierre] AS [Fecha cierre] ,
    [id_estado_mejora] AS [Id estado mejora]
FROM
    [dbo].[Mejora]
WHERE
    [id_mejora]  =  @id_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_Insert]
    @id_mejora    int  output,
    @descripcion_mejora    varchar  (5000),
    @id_tipo_mejora    int  ,
    @id_sub_proyecto    int  ,
    @fecha_prevista_cierre    datetime  ,
    @fecha_real    datetime  ,
    @prioridad    decimal  (18,0),
    @id_usuario    int  ,
    @id_usuario_asignado    int  ,
    @id_origen_mejora    int  ,
    @ubicacion_archivos    varchar  (5000),
    @id_responsable_analisis    int  ,
    @descripcion_causa    varchar  (5000),
    @id_metodo_causa    int  ,
    @fecha_causa    datetime  ,
    @fecha_finalizacion_accion    datetime  ,
    @id_usuario_accion_correctiva    int  ,
    @descripcion_accion_correctiva    varchar  (5000),
    @prevision_accion_correctiva    varchar  (5000),
    @fecha_accion_correctiva    datetime  ,
    @id_usuario_cierre    int  ,
    @analisis_eficacia    char  (1),
    @descripcion_cierre    varchar  (5000),
    @numero_accion_relacionada    decimal  (18,0),
    @costo_prevencion    decimal  (18,2),
    @costo_acciones    decimal  (18,2),
    @costo_no_calidad    decimal  (18,2),
    @costo_total    decimal  (18,2),
    @fecha_cierre    datetime  ,
    @id_estado_mejora    int  
AS

INSERT INTO [dbo].[Mejora]
(
    [descripcion_mejora],
    [id_tipo_mejora],
    [id_sub_proyecto],
    [fecha_prevista_cierre],
    [fecha_real],
    [prioridad],
    [id_usuario],
    [id_usuario_asignado],
    [id_origen_mejora],
    [ubicacion_archivos],
    [id_responsable_analisis],
    [descripcion_causa],
    [id_metodo_causa],
    [fecha_causa],
    [fecha_finalizacion_accion],
    [id_usuario_accion_correctiva],
    [descripcion_accion_correctiva],
    [prevision_accion_correctiva],
    [fecha_accion_correctiva],
    [id_usuario_cierre],
    [analisis_eficacia],
    [descripcion_cierre],
    [numero_accion_relacionada],
    [costo_prevencion],
    [costo_acciones],
    [costo_no_calidad],
    [costo_total],
    [fecha_cierre],
    [id_estado_mejora]
)
VALUES
(
    @descripcion_mejora,
    @id_tipo_mejora,
    @id_sub_proyecto,
    @fecha_prevista_cierre,
    @fecha_real,
    @prioridad,
    @id_usuario,
    @id_usuario_asignado,
    @id_origen_mejora,
    @ubicacion_archivos,
    @id_responsable_analisis,
    @descripcion_causa,
    @id_metodo_causa,
    @fecha_causa,
    @fecha_finalizacion_accion,
    @id_usuario_accion_correctiva,
    @descripcion_accion_correctiva,
    @prevision_accion_correctiva,
    @fecha_accion_correctiva,
    @id_usuario_cierre,
    @analisis_eficacia,
    @descripcion_cierre,
    @numero_accion_relacionada,
    @costo_prevencion,
    @costo_acciones,
    @costo_no_calidad,
    @costo_total,
    @fecha_cierre,
    @id_estado_mejora
)
SET @id_mejora = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_InsertOne]
AS

INSERT INTO [dbo].[Mejora]
(
    [descripcion_mejora],
    [id_tipo_mejora],
    [id_sub_proyecto],
    [fecha_prevista_cierre],
    [fecha_real],
    [prioridad],
    [id_usuario],
    [id_usuario_asignado],
    [id_origen_mejora],
    [ubicacion_archivos],
    [id_responsable_analisis],
    [descripcion_causa],
    [id_metodo_causa],
    [fecha_causa],
    [fecha_finalizacion_accion],
    [id_usuario_accion_correctiva],
    [descripcion_accion_correctiva],
    [prevision_accion_correctiva],
    [fecha_accion_correctiva],
    [id_usuario_cierre],
    [analisis_eficacia],
    [descripcion_cierre],
    [numero_accion_relacionada],
    [costo_prevencion],
    [costo_acciones],
    [costo_no_calidad],
    [costo_total],
    [fecha_cierre],
    [id_estado_mejora]
)
VALUES
(
    'Ninguno',
    1,
    1,
    '01-01-2000',
    '01-01-2000',
    0,
    1,
    1,
    1,
    'Ninguno',
    1,
    'Ninguno',
    1,
    '01-01-2000',
    '01-01-2000',
    1,
    'Ninguno',
    'Ninguno',
    '01-01-2000',
    1,
    '',
    'Ninguno',
    0,
    0,
    0,
    0,
    0,
    '01-01-2000',
     1 
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Mejora_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Mejora_Update]
    @id_mejora    int  output,
    @descripcion_mejora    varchar  (5000),
    @id_tipo_mejora    int  ,
    @id_sub_proyecto    int  ,
    @fecha_prevista_cierre    datetime  ,
    @fecha_real    datetime  ,
    @prioridad    decimal  (18,0),
    @id_usuario    int  ,
    @id_usuario_asignado    int  ,
    @id_origen_mejora    int  ,
    @ubicacion_archivos    varchar  (5000),
    @id_responsable_analisis    int  ,
    @descripcion_causa    varchar  (5000),
    @id_metodo_causa    int  ,
    @fecha_causa    datetime  ,
    @fecha_finalizacion_accion    datetime  ,
    @id_usuario_accion_correctiva    int  ,
    @descripcion_accion_correctiva    varchar  (5000),
    @prevision_accion_correctiva    varchar  (5000),
    @fecha_accion_correctiva    datetime  ,
    @id_usuario_cierre    int  ,
    @analisis_eficacia    char  (1),
    @descripcion_cierre    varchar  (5000),
    @numero_accion_relacionada    decimal  (18,0),
    @costo_prevencion    decimal  (18,2),
    @costo_acciones    decimal  (18,2),
    @costo_no_calidad    decimal  (18,2),
    @costo_total    decimal  (18,2),
    @fecha_cierre    datetime  ,
    @id_estado_mejora    int  
AS

UPDATE [dbo].[Mejora] SET
    [descripcion_mejora] = @descripcion_mejora,
    [id_tipo_mejora] = @id_tipo_mejora,
    [id_sub_proyecto] = @id_sub_proyecto,
    [fecha_prevista_cierre] = @fecha_prevista_cierre,
    [fecha_real] = @fecha_real,
    [prioridad] = @prioridad,
    [id_usuario] = @id_usuario,
    [id_usuario_asignado] = @id_usuario_asignado,
    [id_origen_mejora] = @id_origen_mejora,
    [ubicacion_archivos] = @ubicacion_archivos,
    [id_responsable_analisis] = @id_responsable_analisis,
    [descripcion_causa] = @descripcion_causa,
    [id_metodo_causa] = @id_metodo_causa,
    [fecha_causa] = @fecha_causa,
    [fecha_finalizacion_accion] = @fecha_finalizacion_accion,
    [id_usuario_accion_correctiva] = @id_usuario_accion_correctiva,
    [descripcion_accion_correctiva] = @descripcion_accion_correctiva,
    [prevision_accion_correctiva] = @prevision_accion_correctiva,
    [fecha_accion_correctiva] = @fecha_accion_correctiva,
    [id_usuario_cierre] = @id_usuario_cierre,
    [analisis_eficacia] = @analisis_eficacia,
    [descripcion_cierre] = @descripcion_cierre,
    [numero_accion_relacionada] = @numero_accion_relacionada,
    [costo_prevencion] = @costo_prevencion,
    [costo_acciones] = @costo_acciones,
    [costo_no_calidad] = @costo_no_calidad,
    [costo_total] = @costo_total,
    [fecha_cierre] = @fecha_cierre,
    [id_estado_mejora] = @id_estado_mejora
WHERE
    [id_mejora]  =  @id_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_Delete]
    @id_metodo_causa    int
AS

DELETE FROM [dbo].[Metodo_causa]
WHERE
    [id_metodo_causa]  =  @id_metodo_causa


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_Exist]
    @nombre_metodo_causa    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_metodo_causa
FROM
    [dbo].[Metodo_causa]
WHERE
    [nombre_metodo_causa] = @nombre_metodo_causa

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_metodo_causa] AS [Id metodo causa] ,
    RTRIM(nombre_metodo_causa) AS [Nombre metodo causa]
FROM
    [dbo].[Metodo_causa]
WHERE
    [nombre_metodo_causa] LIKE @nombre+'%'
ORDER BY
    [nombre_metodo_causa]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_GetAll]
AS

SELECT TOP 100
    [id_metodo_causa] AS [Id metodo causa] ,
    RTRIM(nombre_metodo_causa) AS [Nombre metodo causa]
FROM
    [dbo].[Metodo_causa]
ORDER BY
    [nombre_metodo_causa]


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_GetCmb]
AS

SELECT
    [id_metodo_causa],
    [nombre_metodo_causa]
FROM
    [dbo].[Metodo_causa]
ORDER BY
    [nombre_metodo_causa]


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_GetOne]
    @id_metodo_causa    int
AS

SELECT
    [id_metodo_causa] AS [Id metodo causa] ,
    [nombre_metodo_causa] AS [Nombre metodo causa]
FROM
    [dbo].[Metodo_causa]
WHERE
    [id_metodo_causa]  =  @id_metodo_causa


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_Insert]
    @id_metodo_causa    int  output,
    @nombre_metodo_causa    varchar  (50)
AS

INSERT INTO [dbo].[Metodo_causa]
(
    [nombre_metodo_causa]
)
VALUES
(
    @nombre_metodo_causa
)
SET @id_metodo_causa = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_InsertOne]
AS

INSERT INTO [dbo].[Metodo_causa]
(
    [nombre_metodo_causa]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Metodo_causa_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Metodo_causa_Update]
    @id_metodo_causa    int  output,
    @nombre_metodo_causa    varchar  (50)
AS

UPDATE [dbo].[Metodo_causa] SET
    [nombre_metodo_causa] = @nombre_metodo_causa
WHERE
    [id_metodo_causa]  =  @id_metodo_causa


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_Delete]
    @id_origen_mejora    int
AS

DELETE FROM [dbo].[Origen_mejora]
WHERE
    [id_origen_mejora]  =  @id_origen_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_Exist]
    @nombre_origen_mejora    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_origen_mejora
FROM
    [dbo].[Origen_mejora]
WHERE
    [nombre_origen_mejora] = @nombre_origen_mejora

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_origen_mejora] AS [Id origen mejora] ,
    RTRIM(nombre_origen_mejora) AS [Nombre origen mejora]
FROM
    [dbo].[Origen_mejora]
WHERE
    [nombre_origen_mejora] LIKE @nombre+'%'
ORDER BY
    [nombre_origen_mejora]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_GetAll]
AS

SELECT TOP 100
    [id_origen_mejora] AS [Id origen mejora] ,
    RTRIM(nombre_origen_mejora) AS [Nombre origen mejora]
FROM
    [dbo].[Origen_mejora]
ORDER BY
    [nombre_origen_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_GetCmb]
AS

SELECT
    [id_origen_mejora],
    [nombre_origen_mejora]
FROM
    [dbo].[Origen_mejora]
ORDER BY
    [nombre_origen_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_GetOne]
    @id_origen_mejora    int
AS

SELECT
    [id_origen_mejora] AS [Id origen mejora] ,
    [nombre_origen_mejora] AS [Nombre origen mejora]
FROM
    [dbo].[Origen_mejora]
WHERE
    [id_origen_mejora]  =  @id_origen_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_Insert]
    @id_origen_mejora    int  output,
    @nombre_origen_mejora    varchar  (50)
AS

INSERT INTO [dbo].[Origen_mejora]
(
    [nombre_origen_mejora]
)
VALUES
(
    @nombre_origen_mejora
)
SET @id_origen_mejora = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_InsertOne]
AS

INSERT INTO [dbo].[Origen_mejora]
(
    [nombre_origen_mejora]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Origen_mejora_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Origen_mejora_Update]
    @id_origen_mejora    int  output,
    @nombre_origen_mejora    varchar  (50)
AS

UPDATE [dbo].[Origen_mejora] SET
    [nombre_origen_mejora] = @nombre_origen_mejora
WHERE
    [id_origen_mejora]  =  @id_origen_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_Delete]
    @id_proyecto    int
AS

DELETE FROM [dbo].[Proyecto]
WHERE
    [id_proyecto]  =  @id_proyecto

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_Exist]
    @nombre_proyecto    varchar  (50),
    @codigo_proyecto    varchar  (50),
    @id_tipo_proyecto    int  ,
    @id_empresa    int  ,
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @fecha_prevista_fin    datetime  ,
    @fecha_real_fin    datetime  ,
    @id_estado_proyecto    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_proyecto
FROM
    [dbo].[Proyecto]
WHERE
    [nombre_proyecto] = @nombre_proyecto AND
    [codigo_proyecto] = @codigo_proyecto AND
    [id_tipo_proyecto] = @id_tipo_proyecto AND
    [id_empresa] = @id_empresa AND
    [hora_prevista] = @hora_prevista AND
    [hora_real] = @hora_real AND
    [fecha_prevista_fin] = @fecha_prevista_fin AND
    [fecha_real_fin] = @fecha_real_fin AND
    [id_estado_proyecto] = @id_estado_proyecto

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_proyecto] AS [Id proyecto] ,
    RTRIM(nombre_proyecto) AS [Nombre proyecto] ,
    RTRIM(codigo_proyecto) AS [Codigo proyecto] ,
    [id_tipo_proyecto] AS [Id tipo proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista_fin] AS [Fecha prevista fin] ,
    [fecha_real_fin] AS [Fecha real fin] ,
    [id_estado_proyecto] AS [Id estado proyecto]
FROM
    [dbo].[Proyecto]
WHERE
    [nombre_proyecto] LIKE @nombre+'%'
ORDER BY
    [nombre_proyecto]
END

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_GetAll]
AS

SELECT TOP 100
    [id_proyecto] AS [Id proyecto] ,
    RTRIM(nombre_proyecto) AS [Nombre proyecto] ,
    RTRIM(codigo_proyecto) AS [Codigo proyecto] ,
    [id_tipo_proyecto] AS [Id tipo proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista_fin] AS [Fecha prevista fin] ,
    [fecha_real_fin] AS [Fecha real fin] ,
    [id_estado_proyecto] AS [Id estado proyecto]
FROM
    [dbo].[Proyecto]
ORDER BY
    [nombre_proyecto]

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Proyecto_GetAll_2]
AS

SELECT
    [id_proyecto] AS [Id proyecto] ,
    RTRIM(nombre_proyecto) AS [Nombre proyecto] ,
    RTRIM(codigo_proyecto) AS [Codigo proyecto] ,
    [nombre_tipo_proyecto] AS [tipo proyecto] ,
    [nombre_empresa] AS [Empresa] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista_fin] AS [Fecha prevista fin] ,
    [fecha_real_fin] AS [Fecha real fin] ,
    [id_estado_proyecto] AS [Id Estado proyecto]
FROM
    [dbo].[Proyecto] INNER JOIN
	Tipo_proyecto ON Tipo_proyecto.id_tipo_proyecto = PROYECTO.id_tipo_proyecto INNER JOIN
	empresa ON empresa.id_empresa = proyecto.id_empresa
ORDER BY
    [nombre_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_GetCmb]
AS

SELECT
    [id_proyecto],
    [nombre_proyecto],
    [codigo_proyecto],
    [id_tipo_proyecto],
    [id_empresa],
    [hora_prevista],
    [hora_real],
    [fecha_prevista_fin],
    [fecha_real_fin],
    [id_estado_proyecto]
FROM
    [dbo].[Proyecto]
ORDER BY
    [nombre_proyecto]

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_GetCmbEmpresa]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Proyecto_GetCmbEmpresa]
	@id_empresa int
AS

SELECT
    [id_proyecto],
    [nombre_proyecto],
    [codigo_proyecto],
    [id_tipo_proyecto],
    [Proyecto].[id_empresa],
    [hora_prevista],
    [hora_real],
    [fecha_prevista_fin] ,
    [fecha_real_fin] ,
    [id_estado_proyecto] 
FROM
    [dbo].[Proyecto] INNER JOIN
	empresa ON empresa.id_empresa = [Proyecto].id_empresa
WHERE
	[Proyecto].id_empresa = @id_empresa AND
	id_estado_proyecto <> 4
ORDER BY
    [nombre_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_GetOne]
    @id_proyecto    int
AS

SELECT
    [id_proyecto] AS [Id proyecto] ,
    [nombre_proyecto] AS [Nombre proyecto] ,
    [codigo_proyecto] AS [Codigo proyecto] ,
    [id_tipo_proyecto] AS [Id tipo proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista_fin] AS [Fecha prevista fin] ,
    [fecha_real_fin] AS [Fecha real fin] ,
    [id_estado_proyecto] AS [Id estado proyecto]
FROM
    [dbo].[Proyecto]
WHERE
    [id_proyecto]  =  @id_proyecto

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_Insert]
    @id_proyecto    int  output,
    @nombre_proyecto    varchar  (50),
    @codigo_proyecto    varchar  (50),
    @id_tipo_proyecto    int  ,
    @id_empresa    int  ,
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @fecha_prevista_fin    datetime  ,
    @fecha_real_fin    datetime  ,
    @id_estado_proyecto    int  
AS

INSERT INTO [dbo].[Proyecto]
(
    [nombre_proyecto],
    [codigo_proyecto],
    [id_tipo_proyecto],
    [id_empresa],
    [hora_prevista],
    [hora_real],
    [fecha_prevista_fin],
    [fecha_real_fin],
    [id_estado_proyecto]
)
VALUES
(
    @nombre_proyecto,
    @codigo_proyecto,
    @id_tipo_proyecto,
    @id_empresa,
    @hora_prevista,
    @hora_real,
    @fecha_prevista_fin,
    @fecha_real_fin,
    @id_estado_proyecto
)
SET @id_proyecto = @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_InsertOne]
AS

INSERT INTO [dbo].[Proyecto]
(
    [nombre_proyecto],
    [codigo_proyecto],
    [id_tipo_proyecto],
    [id_empresa],
    [hora_prevista],
    [hora_real],
    [fecha_prevista_fin],
    [fecha_real_fin],
    [id_estado_proyecto]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    1,
    1,
    0,
    0,
    '01-01-2000',
    '01-01-2000',
     1 
)

GO
/****** Object:  StoredProcedure [dbo].[cop_Proyecto_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Proyecto_Update]
    @id_proyecto    int  output,
    @nombre_proyecto    varchar  (50),
    @codigo_proyecto    varchar  (50),
    @id_tipo_proyecto    int  ,
    @id_empresa    int  ,
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @fecha_prevista_fin    datetime  ,
    @fecha_real_fin    datetime  ,
    @id_estado_proyecto    int  
AS

UPDATE [dbo].[Proyecto] SET
    [nombre_proyecto] = @nombre_proyecto,
    [codigo_proyecto] = @codigo_proyecto,
    [id_tipo_proyecto] = @id_tipo_proyecto,
    [id_empresa] = @id_empresa,
    [hora_prevista] = @hora_prevista,
    [hora_real] = @hora_real,
    [fecha_prevista_fin] = @fecha_prevista_fin,
    [fecha_real_fin] = @fecha_real_fin,
    [id_estado_proyecto] = @id_estado_proyecto
WHERE
    [id_proyecto]  =  @id_proyecto

GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_Delete]
    @id_sub_proyecto    int
AS

DELETE FROM [dbo].[Sub_proyecto]
WHERE
    [id_sub_proyecto]  =  @id_sub_proyecto


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_Exist]
    @nombre_sub_proyecto    varchar  (50),
    @codigo_sub_proyecto    varchar  (50),
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @fecha_prevista    datetime  ,
    @fecha_real    datetime  ,
    @id_proyecto    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_sub_proyecto
FROM
    [dbo].[Sub_proyecto]
WHERE
    [nombre_sub_proyecto] = @nombre_sub_proyecto AND
    [codigo_sub_proyecto] = @codigo_sub_proyecto AND
    [hora_prevista] = @hora_prevista AND
    [hora_real] = @hora_real AND
    [fecha_prevista] = @fecha_prevista AND
    [fecha_real] = @fecha_real AND
    [id_proyecto] = @id_proyecto

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_sub_proyecto) AS [Nombre sub proyecto] ,
    RTRIM(codigo_sub_proyecto) AS [Codigo sub proyecto] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista] AS [Fecha prevista] ,
    [fecha_real] AS [Fecha real] ,
    [id_proyecto] AS [Id proyecto]
FROM
    [dbo].[Sub_proyecto]
WHERE
    [nombre_sub_proyecto] LIKE @nombre+'%'
ORDER BY
    [nombre_sub_proyecto]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_Find_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Sub_proyecto_Find_2]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_sub_proyecto) AS [Nombre sub proyecto] ,
    RTRIM(codigo_sub_proyecto) AS [Codigo sub proyecto] ,
    Sub_proyecto.[hora_prevista] AS [Hora prevista] ,
    Sub_proyecto.[hora_real] AS [Hora real] ,
    Sub_proyecto.[fecha_prevista] AS [Fecha prevista] ,
    Sub_proyecto.[fecha_real] AS [Fecha real] ,
    [nombre_proyecto] AS [proyecto]
FROM
    [dbo].[Sub_proyecto] INNER JOIN
	PROYECTO ON PROYECTO.id_proyecto = Sub_proyecto.id_proyecto
WHERE
    [nombre_sub_proyecto] LIKE @nombre+'%'
ORDER BY
    [nombre_sub_proyecto]
END



GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_GetAll]
AS

SELECT TOP 100
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_sub_proyecto) AS [Nombre sub proyecto] ,
    RTRIM(codigo_sub_proyecto) AS [Codigo sub proyecto] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista] AS [Fecha prevista] ,
    [fecha_real] AS [Fecha real] ,
    [id_proyecto] AS [Id proyecto]
FROM
    [dbo].[Sub_proyecto]
ORDER BY
    [nombre_sub_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_GetAll_2]
AS

SELECT
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_sub_proyecto) AS [Nombre sub proyecto] ,
    RTRIM(codigo_sub_proyecto) AS [Codigo sub proyecto] ,
    Sub_proyecto.[hora_prevista] AS [Hora prevista] ,
    Sub_proyecto.[hora_real] AS [Hora real] ,
    Sub_proyecto.[fecha_prevista] AS [Fecha prevista] ,
    Sub_proyecto.[fecha_real] AS [Fecha real] ,
    [nombre_proyecto] AS [proyecto]
FROM
    [dbo].[Sub_proyecto] INNER JOIN
	PROYECTO ON PROYECTO.id_proyecto = Sub_proyecto.id_proyecto
ORDER BY
    [nombre_sub_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_GetCmb]
AS

SELECT
    [id_sub_proyecto],
    [nombre_sub_proyecto],
    [codigo_sub_proyecto],
    [hora_prevista],
    [hora_real],
    [fecha_prevista],
    [fecha_real],
    [id_proyecto]
FROM
    [dbo].[Sub_proyecto]
ORDER BY
    [nombre_sub_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_GetCmbProyecto]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_GetCmbProyecto]
	@id_proyecto int
AS

SELECT
    [id_sub_proyecto],
    [nombre_sub_proyecto],
    [codigo_sub_proyecto],
    Sub_proyecto.[hora_prevista],
    Sub_proyecto.[hora_real],
    Sub_proyecto.[fecha_prevista],
    Sub_proyecto.[fecha_real],
    Sub_proyecto.[id_proyecto]
FROM
    [dbo].[Sub_proyecto] INNER JOIN
	proyecto ON PROYECTO.id_proyecto = Sub_proyecto.id_proyecto
WHERE
	sub_proyecto.id_proyecto = @id_proyecto
ORDER BY
    [nombre_sub_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_GetOne]
    @id_sub_proyecto    int
AS

SELECT
    [id_sub_proyecto] AS [Id sub proyecto] ,
    [nombre_sub_proyecto] AS [Nombre sub proyecto] ,
    [codigo_sub_proyecto] AS [Codigo sub proyecto] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [fecha_prevista] AS [Fecha prevista] ,
    [fecha_real] AS [Fecha real] ,
    [id_proyecto] AS [Id proyecto]
FROM
    [dbo].[Sub_proyecto]
WHERE
    [id_sub_proyecto]  =  @id_sub_proyecto


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_Insert]
    @id_sub_proyecto    int  output,
    @nombre_sub_proyecto    varchar  (50),
    @codigo_sub_proyecto    varchar  (50),
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @fecha_prevista    datetime  ,
    @fecha_real    datetime  ,
    @id_proyecto    int  
AS

INSERT INTO [dbo].[Sub_proyecto]
(
    [nombre_sub_proyecto],
    [codigo_sub_proyecto],
    [hora_prevista],
    [hora_real],
    [fecha_prevista],
    [fecha_real],
    [id_proyecto]
)
VALUES
(
    @nombre_sub_proyecto,
    @codigo_sub_proyecto,
    @hora_prevista,
    @hora_real,
    @fecha_prevista,
    @fecha_real,
    @id_proyecto
)
SET @id_sub_proyecto = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_InsertOne]
AS

INSERT INTO [dbo].[Sub_proyecto]
(
    [nombre_sub_proyecto],
    [codigo_sub_proyecto],
    [hora_prevista],
    [hora_real],
    [fecha_prevista],
    [fecha_real],
    [id_proyecto]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    0,
    0,
    '01-01-2000',
    '01-01-2000',
     1 
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Sub_proyecto_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Sub_proyecto_Update]
    @id_sub_proyecto    int  output,
    @nombre_sub_proyecto    varchar  (50),
    @codigo_sub_proyecto    varchar  (50),
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @fecha_prevista    datetime  ,
    @fecha_real    datetime  ,
    @id_proyecto    int  
AS

UPDATE [dbo].[Sub_proyecto] SET
    [nombre_sub_proyecto] = @nombre_sub_proyecto,
    [codigo_sub_proyecto] = @codigo_sub_proyecto,
    [hora_prevista] = @hora_prevista,
    [hora_real] = @hora_real,
    [fecha_prevista] = @fecha_prevista,
    [fecha_real] = @fecha_real,
    [id_proyecto] = @id_proyecto
WHERE
    [id_sub_proyecto]  =  @id_sub_proyecto


GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_Delete]
    @id_tarea    int
AS

DELETE FROM [dbo].[Tarea]
WHERE
    [id_tarea]  =  @id_tarea
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_Exist]
    @id_tipo_tarea    int  ,
    @id_sub_proyecto    int  ,
    @nombre_tarea    varchar  (5000),
    @fecha_pedido    datetime  ,
    @fecha_inicio    datetime  ,
    @fecha_fin    datetime  ,
    @fecha_real    datetime  ,
    @ubicacion_documento    varchar  (5000),
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @prioridad    decimal  (18,0),
    @id_usuario    int  ,
    @id_estado_tarea    int  ,
    @id_proyecto    int  ,
    @id_empresa    int  ,
    @id_usuario_asignado    int  ,
    @enviada    bit  ,
    @archivo_relacionado    varchar  (5000),
    @complejidad    char  (1),
    @es_feriado    bit  ,
    @IDCalendar    varchar  (5000)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tarea
FROM
    [dbo].[Tarea]
WHERE
    [id_tipo_tarea] = @id_tipo_tarea AND
    [id_sub_proyecto] = @id_sub_proyecto AND
    [nombre_tarea] = @nombre_tarea AND
    [fecha_pedido] = @fecha_pedido AND
    [fecha_inicio] = @fecha_inicio AND
    [fecha_fin] = @fecha_fin AND
    [fecha_real] = @fecha_real AND
    [ubicacion_documento] = @ubicacion_documento AND
    [hora_prevista] = @hora_prevista AND
    [hora_real] = @hora_real AND
    [prioridad] = @prioridad AND
    [id_usuario] = @id_usuario AND
    [id_estado_tarea] = @id_estado_tarea AND
    [id_proyecto] = @id_proyecto AND
    [id_empresa] = @id_empresa AND
    [id_usuario_asignado] = @id_usuario_asignado AND
    [enviada] = @enviada AND
    [archivo_relacionado] = @archivo_relacionado AND
    [complejidad] = @complejidad AND
    [es_feriado] = @es_feriado AND
    [IDCalendar] = @IDCalendar

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tarea] AS [Id tarea] ,
    [id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_pedido] AS [Fecha pedido] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    RTRIM(ubicacion_documento) AS [Ubicacion documento] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [enviada] AS [Enviada] ,
    RTRIM(archivo_relacionado) AS [Archivo relacionado] ,
    [complejidad] AS [Complejidad] ,
    [es_feriado] AS [Es feriado] ,
    RTRIM(IDCalendar) AS [Idcalendar]
FROM
    [dbo].[Tarea]
WHERE
    [id_tipo_tarea] LIKE @nombre+'%'
ORDER BY
    [id_tipo_tarea]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_GetAll]
AS

SELECT TOP 100
    [id_tarea] AS [Id tarea] ,
    [id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_pedido] AS [Fecha pedido] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    RTRIM(ubicacion_documento) AS [Ubicacion documento] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [enviada] AS [Enviada] ,
    RTRIM(archivo_relacionado) AS [Archivo relacionado] ,
    [complejidad] AS [Complejidad] ,
    [es_feriado] AS [Es feriado] ,
    RTRIM(IDCalendar) AS [Idcalendar]
FROM
    [dbo].[Tarea]
ORDER BY
    [id_tipo_tarea]
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[cop_Tarea_GetAll_2]
AS

SELECT
    [id_tarea] AS [Id tarea] ,
    [id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    --RTRIM(comentario) AS [Comentario] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado]
FROM
    [dbo].[Tarea]
ORDER BY
    [id_tipo_tarea]




GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll_Dinamica]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Tarea_GetAll_Dinamica]
	@fecha_desde datetime,
	@fecha_hasta datetime
AS

SELECT     
	dbo.TAREA.id_tarea, 
	dbo.Empresa.nombre_empresa AS Unidad, 
	dbo.Tipo_tarea.nombre_tipo_tarea AS Tipo, 
	dbo.PROYECTO.nombre_proyecto AS Cuenta, 
	dbo.Sub_proyecto.nombre_sub_proyecto AS Subproyecto,
	dbo.TAREA.fecha_pedido AS Pedido,
	dbo.TAREA.nombre_tarea AS Tarea,
	dbo.TAREA.fecha_inicio AS Inicio, 
	dbo.TAREA.fecha_fin AS Fin,
	dbo.TAREA.fecha_real AS [Fecha Real],
	dbo.TAREA.hora_real AS [Hora Real],
	dbo.TAREA.hora_prevista AS Hora, 
	dbo.Estado_tarea.nombre_estado_tarea AS Estado,
	dbo.Usuario.identificador AS Usuario
FROM         
	dbo.TAREA INNER JOIN
	dbo.Tipo_tarea ON dbo.TAREA.id_tipo_tarea = dbo.Tipo_tarea.id_tipo_tarea INNER JOIN
	dbo.Sub_proyecto ON dbo.TAREA.id_sub_proyecto = dbo.Sub_proyecto.id_sub_proyecto INNER JOIN
	dbo.PROYECTO ON dbo.TAREA.id_proyecto = dbo.PROYECTO.id_proyecto INNER JOIN
	dbo.Empresa ON dbo.TAREA.id_empresa = dbo.Empresa.id_empresa INNER JOIN
	dbo.Estado_tarea ON dbo.TAREA.id_estado_tarea = dbo.Estado_tarea.id_estado_tarea INNER JOIN
	dbo.Usuario ON dbo.TAREA.id_usuario = dbo.Usuario.id_usuario
WHERE
	Tarea.fecha_real >= @fecha_desde AND
	Tarea.fecha_real < @fecha_hasta
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll_Gantt]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Tarea_GetAll_Gantt]
AS

SELECT
	fecha_inicio AS [Fecha inicio], 
	nombre_usuario AS [Nombre usuario], 
	SUM (hora_prevista) AS Horas 
FROM 
	tarea inner join usuario on
	tarea.id_usuario_asignado=usuario.id_usuario   
WHERE
	id_estado_tarea = 1 
GROUP BY 
	fecha_inicio, 
	nombre_usuario 
ORDER BY
    fecha_inicio
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll_Gantt_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Tarea_GetAll_Gantt_2]
	@fecha datetime,
	@id_usuario int
AS

SELECT
	fecha_inicio AS [Fecha inicio], 
	nombre_usuario AS [Nombre usuario], 
	SUM (hora_prevista) AS Horas 
FROM 
	tarea inner join usuario on
	tarea.id_usuario_asignado=usuario.id_usuario   
WHERE
	id_estado_tarea = 1 AND
	DAY(fecha_inicio) = DAY(@fecha) AND
	MONTH(fecha_inicio) = MONTH(@fecha) AND
	YEAR(fecha_inicio) = YEAR(@fecha) AND
	id_usuario_asignado = @id_usuario
GROUP BY 
	fecha_inicio, 
	nombre_usuario 
ORDER BY
    fecha_inicio
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll_Gantt_Grilla]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Tarea_GetAll_Gantt_Grilla]
    @id_usuario    int
AS

SET LANGUAGE Spanish;
SELECT
	DATENAME(w, fecha_inicio) AS Día,
	fecha_inicio AS [Fecha], 
	nombre_usuario AS [Nombre usuario], 
	SUM (hora_prevista) AS Horas,
	es_feriado AS [Es Feriado] 
FROM 
	tarea inner join usuario on
	tarea.id_usuario_asignado=usuario.id_usuario   
WHERE
	id_estado_tarea = 1 AND
	Tarea.id_usuario_asignado = @id_usuario
GROUP BY 
	fecha_inicio, 
	nombre_usuario , 
	es_feriado
ORDER BY
    fecha_inicio
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAll_GanttDetalle]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tarea_GetAll_GanttDetalle]
	@id_usuario int,
	@fecha datetime
AS

SELECT
	[id_tarea] AS [Id tarea] ,
	[nombre_proyecto] AS [Proyecto-Cuenta] ,
	RTRIM(nombre_tarea) AS [Descripción],
	[id_tarea] AS [N° Tarea]
FROM
	[dbo].[Tarea] INNER JOIN
	proyecto ON proyecto.id_proyecto = tarea.id_proyecto
WHERE
	id_estado_tarea = 1 AND
	DAY(fecha_inicio) = DAY(@fecha) AND
	MONTH(fecha_inicio) = MONTH(@fecha) AND
	YEAR(fecha_inicio) = YEAR(@fecha) AND
	id_usuario_asignado = @id_usuario
ORDER BY
	id_tarea




GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAllDashboard]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Tarea_GetAllDashboard]
	@id_usuario int,
	@fecha datetime
AS

Declare @fecha_fin datetime
Set @fecha_fin = DATEADD(d, 1, @fecha)

Declare @pendiente int
Declare @retrasada int
Declare @prioritaria int
Declare @hoy int
Declare @semana int

--pendientes
SELECT 
    @pendiente = COUNT([id_tarea])
FROM
    [dbo].[Tarea]
WHERE
	id_usuario_asignado = @id_usuario And
	id_estado_tarea = 1 

--retrasadas
SELECT 
    @retrasada = COUNT([id_tarea])
FROM
    [dbo].[Tarea]
WHERE
	id_usuario_asignado = @id_usuario And
	id_estado_tarea = 1 And
	fecha_fin < @fecha_fin

--prioritarias
SELECT 
    @prioritaria = COUNT([id_tarea])
FROM
    [dbo].[Tarea]
WHERE
	id_usuario_asignado = @id_usuario And
	id_estado_tarea = 1 And
	prioridad = 1

--hoy
SELECT 
    @hoy = COUNT([id_tarea])
FROM
    [dbo].[Tarea]
WHERE
	id_usuario_asignado = @id_usuario And
	Tarea.id_estado_tarea = 1 And
	DAY(fecha_fin) = DAY(@fecha) And
	MONTH(fecha_fin) = MONTH(@fecha) And
	YEAR(fecha_fin) = YEAR(@fecha) 

IF @pendiente IS NULL BEGIN SET @pendiente = 0 END
IF @retrasada IS NULL BEGIN SET @retrasada = 0 END
IF @prioritaria IS NULL BEGIN SET @prioritaria = 0 END
IF @hoy IS NULL BEGIN SET @hoy = 0 END

SELECT
	@pendiente AS Pendiente,
	@retrasada AS Retrasada,
	@prioritaria AS Prioritaria,
	@hoy AS Hoy
 



GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAllHorasPrevistas]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Tarea_GetAllHorasPrevistas]
    @id_usuario   int,
	@fecha datetime
AS

DECLARE @hp decimal(18,2), @hr decimal(18,2)

SELECT
    @hp = SUM([hora_prevista]) ,
    @hr = SUM([hora_real])
FROM
    [dbo].[Tarea]
WHERE
    [id_usuario_asignado] =  @id_usuario AND
	YEAR([fecha_inicio]) = YEAR(@fecha) AND
	MONTH([fecha_inicio]) = MONTH(@fecha) AND
	DAY([fecha_inicio]) = DAY(@fecha) 

IF @hp IS NULL BEGIN SET @hp=0 END
IF @hr IS NULL BEGIN SET @hr=0 END

SELECT 
	@hp AS [Hora prevista],
	@hr AS [Hora real] 




GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAllMaestro]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[cop_Tarea_GetAllMaestro]
	@bandera int,
	@id_empresa int,
	@id_proyecto int,
	@id_sub_proyecto int,
	@id_usuario int,
	@id_estado_tarea int,
	@bandera_estado bit,
	@todo bit,
	@usuario bit,
	@tipo_tarea bit,
	@es_entre_fecha bit,
	@id_tipo_tarea int,
	@fecha_inicio datetime,
	@fecha_fin datetime
AS
IF @bandera is null
begin
	set @bandera = 1
end


--4 if anidados
--el primero representa el check todo
--el segundo si se desea filtrar por usuario asignado
--el tercero cada uno de los radio buttons
--y el cuarto el estado al que se desea  filtrar (checkbox)


--ESTRUCTURA DEL ANIDAMIENTO

--IF @TODO = x --REPRESENTACION DEL CHECKBOX TODO
	-- Todo = 1 (se filtra por todo teniendo en cuenta el combo anterior)
	-- Todo = 0 (Se filtra teniendo en cuenta el combo seleccionado)
	--IF @usuario x --REPRESENTA EL CHECK USUARIO ASIGANDO
		--USUARIO = 1 (filtro por usuario, toda las consultas where contienen el filtro)
		--USUARIO = 0 (filtro normalmente sin tener en cuenta el usuario)
	--	IF @bandera = x --REPRESENTA VALOR SELECCIONADIO DE RADIO BUTTONS (EMPRESA, PROYECTO, SUBPROYECTO)
	--		IF @bandera_estado = x --REPRESENTA EL CHECKBOX FILTRAR ESTADO.



IF @todo = 1 --Todo x ...
BEGIN
	IF @es_entre_fecha = 1
	BEGIN
		IF @tipo_tarea = 1
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							--(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		WHERE
				--			tarea.id_estado_tarea = @id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin
			END

			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
			END
		END

		IF @tipo_tarea = 0
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_usuario_asignado = @id_usuario AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_usuario_asignado = @id_usuario AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_usuario_asignado = @id_usuario AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		WHERE
				--			tarea.id_estado_tarea = @id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin
			END
			
			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
			END
		END
	END

	IF @es_entre_fecha = 0
	BEGIN
		IF @tipo_tarea = 1
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_usuario_asignado = @id_usuario AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		WHERE
				--			tarea.id_estado_tarea = @id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin
			END

			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
			END
		END

		IF @tipo_tarea = 0
		BEGIN
			IF @usuario = 1
			BEGIN

				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_usuario_asignado = @id_usuario 
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_usuario_asignado = @id_usuario 
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_usuario_asignado = @id_usuario 
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_usuario_asignado = @id_usuario
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
				--IF @bandera = 4 --Todo x Usuario (no se utiliza mas)
				--BEGIN
				--	IF @bandera_estado = 1 --Con estado Filtrado
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		WHERE
				--			tarea.id_estado_tarea = @id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin

				--	IF @bandera_estado = 0
				--		SELECT
				--			[id_tarea] AS [Id tarea] ,
				--			[nombre_estado_tarea] AS [Estado] ,
				--			[prioridad] AS [Prioridad] ,
				--			[nombre_tipo_tarea] AS [Tipo tarea] ,
				--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
				--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
				--			tarea.[fecha_real] AS [Fecha real] ,
				--			tarea.[hora_prevista] AS [Hora prevista] ,
				--			tarea.[hora_real] AS [Hora real] ,
				--			RTRIM(comentario) AS [Comentario] ,
				--			
				--			[nombre_empresa] AS [Empresa] ,
				--			[nombre_proyecto] AS [proyecto] ,
				--			[nombre_sub_proyecto] AS [sub proyecto] ,
				--			[id_tarea] AS [N° Tarea]
				--		FROM
				--			[dbo].[Tarea] INNER JOIN
				--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
				--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
				--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
				--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
				--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
				--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
				--		ORDER BY
				--			[prioridad],
				--			tarea.fecha_fin
			END
			
			IF @usuario = 0
			BEGIN
				IF @bandera = 1 --Todo Seleccionado empresa. (Todas las empresas)
				BEGIN
					IF @bandera_estado = 1 --Con un estado filtrado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin estado Seleccionado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Todo x Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_estado_tarea = @id_estado_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Todo por SubProyecto
				BEGIN
					IF @bandera_estado = 1 --Con Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END
			END
		END
	END

END


IF @todo = 0 --Por seleccion de Radio Buttons
BEGIN
	IF @es_entre_fecha = 1
	BEGIN
		IF @tipo_tarea = 1
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_empresa = @id_empresa AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
							tarea.id_tipo_tarea = @id_tipo_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END

			END
		END

		IF @tipo_tarea = 0
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario AND
						[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
						[dbo].[Tarea].[fecha_real] < @fecha_fin
					ORDER BY
						[prioridad],
						tarea.fecha_fin

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_empresa = @id_empresa AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
							[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
							[dbo].[Tarea].[fecha_real] < @fecha_fin
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END

			END
		END
	END

	IF @es_entre_fecha = 0
	BEGIN
		IF @tipo_tarea = 1
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea
					ORDER BY
						[prioridad],
						tarea.fecha_fin
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea
					ORDER BY
						[prioridad],
						tarea.fecha_fin
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario AND
						tarea.id_tipo_tarea = @id_tipo_tarea
					ORDER BY
						[prioridad],
						tarea.fecha_fin

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_empresa = @id_empresa AND
						tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa AND
						tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
						tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
						tarea.id_tipo_tarea = @id_tipo_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END

			END
		END

		IF @tipo_tarea = 0
		BEGIN
			IF @usuario = 1 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
					[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_empresa = @id_empresa AND
						tarea.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						tarea.fecha_fin
	
			END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_proyecto = @id_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						tarea.fecha_fin
			END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto AND
						tarea.id_estado_tarea = @id_estado_tarea AND
						tarea.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
					SELECT
						[id_tarea] AS [Id tarea] ,
						[nombre_estado_tarea] AS [Estado] ,
						[prioridad] AS [Prioridad] ,
						[nombre_tipo_tarea] AS [Tipo tarea] ,
						RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
						tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
						(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
						tarea.[fecha_real] AS [Fecha real] ,
						tarea.[hora_prevista] AS [Hora prevista] ,
						tarea.[hora_real] AS [Hora real] ,
						
						[nombre_empresa] AS [Empresa] ,
						[nombre_proyecto] AS [proyecto] ,
						[nombre_sub_proyecto] AS [sub proyecto] ,
						[id_tarea] AS [N° Tarea]
					FROM
						[dbo].[Tarea] INNER JOIN
						Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
						sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
						proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
						empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
						usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
						estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
					WHERE
						tarea.id_sub_proyecto = @id_sub_proyecto  AND
						tarea.id_usuario_asignado = @id_usuario
					ORDER BY
						[prioridad],
						tarea.fecha_fin

			END

			END

			IF @usuario = 0 --Filtro por usuario
			BEGIN

				IF @bandera = 1 --Por Empresa
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_estado_tarea = @id_estado_tarea AND
							tarea.id_empresa = @id_empresa
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
						[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_empresa = @id_empresa
						ORDER BY
							[prioridad],
							tarea.fecha_fin
	
				END
				IF @bandera = 2 --Por Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin Filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_proyecto = @id_proyecto
						ORDER BY
							[prioridad],
							tarea.fecha_fin
				END
				IF @bandera = 3 --Por Sub Proyecto
				BEGIN
					IF @bandera_estado = 1 --Con filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto AND
							tarea.id_estado_tarea = @id_estado_tarea
						ORDER BY
							[prioridad],
							tarea.fecha_fin

					IF @bandera_estado = 0 --Sin filtro de estado
						SELECT
							[id_tarea] AS [Id tarea] ,
							[nombre_estado_tarea] AS [Estado] ,
							[prioridad] AS [Prioridad] ,
							[nombre_tipo_tarea] AS [Tipo tarea] ,
							RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
							tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
							(case when DATEDIFF(d, Tarea.fecha_fin, getdate()) < 0 then 0 else DATEDIFF(d, Tarea.fecha_fin, getdate()) end) AS Demora,
							tarea.[fecha_real] AS [Fecha real] ,
							tarea.[hora_prevista] AS [Hora prevista] ,
							tarea.[hora_real] AS [Hora real] ,
							
							[nombre_empresa] AS [Empresa] ,
							[nombre_proyecto] AS [proyecto] ,
							[nombre_sub_proyecto] AS [sub proyecto] ,
							[id_tarea] AS [N° Tarea]
						FROM
							[dbo].[Tarea] INNER JOIN
							Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
							sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
							proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
							empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
							usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
							estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
						WHERE
							tarea.id_sub_proyecto = @id_sub_proyecto
						ORDER BY
							[prioridad],
							tarea.fecha_fin

				END

			END
		END
	END

	--IF @bandera = 4 --Por Usuario(NO SE USA MAS)
	--BEGIN
	--	IF @bandera_estado = 1
	--		SELECT
	--			[id_tarea] AS [Id tarea] ,
	--			[nombre_estado_tarea] AS [Estado] ,
	--			[prioridad] AS [Prioridad] ,
	--			[nombre_tipo_tarea] AS [Tipo tarea] ,
	--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
	--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
	--			tarea.[fecha_real] AS [Fecha real] ,
	--			tarea.[hora_prevista] AS [Hora prevista] ,
	--			tarea.[hora_real] AS [Hora real] ,
	--			RTRIM(comentario) AS [Comentario] ,
	--			
	--			[nombre_empresa] AS [Empresa] ,
	--			[nombre_proyecto] AS [proyecto] ,
	--			[nombre_sub_proyecto] AS [sub proyecto] ,
	--			[id_tarea] AS [N° Tarea]
	--		FROM
	--			[dbo].[Tarea] INNER JOIN
	--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
	--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
	--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
	--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
	--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
	--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
	--		WHERE
	--			tarea.id_usuario_asignado = @id_usuario AND
	--			tarea.id_estado_tarea = @id_estado_tarea
	--		ORDER BY
	--			[prioridad],
	--			tarea.fecha_fin

	--	IF @bandera_estado = 0
	--		SELECT
	--			[id_tarea] AS [Id tarea] ,
	--			[nombre_estado_tarea] AS [Estado] ,
	--			[prioridad] AS [Prioridad] ,
	--			[nombre_tipo_tarea] AS [Tipo tarea] ,
	--			RTRIM(nombre_tarea) AS [Descripcion] , [nombre_usuario] AS [Asignado] ,
	--			tarea.fecha_inicio AS [Inicio], tarea.[fecha_fin] AS [Fin Previsto] ,
	--			tarea.[fecha_real] AS [Fecha real] ,
	--			tarea.[hora_prevista] AS [Hora prevista] ,
	--			tarea.[hora_real] AS [Hora real] ,
	--			RTRIM(comentario) AS [Comentario] ,
	--			
	--			[nombre_empresa] AS [Empresa] ,
	--			[nombre_proyecto] AS [proyecto] ,
	--			[nombre_sub_proyecto] AS [sub proyecto] ,
	--			[id_tarea] AS [N° Tarea]
	--		FROM
	--			[dbo].[Tarea] INNER JOIN
	--			Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
	--			sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
	--			proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
	--			empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
	--			usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
	--			estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
	--		WHERE
	--			tarea.id_usuario_asignado = @id_usuario
	--		ORDER BY
	--			[prioridad],
	--			tarea.fecha_fin
	--END

END




GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAllMaestroDashboard]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[cop_Tarea_GetAllMaestroDashboard]
	@id_usuario int,
	@fecha datetime,
	@consulta int
AS

--programadas
IF @consulta = 1 BEGIN
SELECT
	[id_tarea] AS [Id tarea] ,
	[nombre_estado_tarea] AS [Estado] ,
	[prioridad] AS [Prioridad] ,
	[nombre_tipo_tarea] AS [Tipo tarea] ,
	RTRIM(nombre_tarea) AS [Descripcion] ,
	tarea.[fecha_fin] AS [Fecha fin] ,
	DATEDIFF(d, Tarea.fecha_fin, getdate()) AS Demora,
	tarea.[fecha_real] AS [Fecha real] ,
	tarea.[hora_prevista] AS [Hora prevista] ,
	tarea.[hora_real] AS [Hora real] ,
	[id_tarea] AS [N° Tarea] ,
	[nombre_empresa] AS [Empresa] ,
	[nombre_proyecto] AS [proyecto] ,
	[nombre_sub_proyecto] AS [sub proyecto] ,
	[nombre_usuario] AS [Asignado]
FROM
	[dbo].[Tarea] INNER JOIN
	Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
	sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
	proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
	empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
	usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
	estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
WHERE
	id_usuario_asignado = @id_usuario And
	Tarea.id_estado_tarea = 1 
ORDER BY
	tarea.fecha_fin
END


--retrasadas
IF @consulta = 2 BEGIN
SELECT
	[id_tarea] AS [Id tarea] ,
	[nombre_estado_tarea] AS [Estado] ,
	[prioridad] AS [Prioridad] ,
	[nombre_tipo_tarea] AS [Tipo tarea] ,
	RTRIM(nombre_tarea) AS [Descripcion] ,
	tarea.[fecha_fin] AS [Fecha fin] ,
	DATEDIFF(d, Tarea.fecha_fin, getdate()) AS Demora,
	tarea.[fecha_real] AS [Fecha real] ,
	tarea.[hora_prevista] AS [Hora prevista] ,
	tarea.[hora_real] AS [Hora real] ,
	[id_tarea] AS [N° Tarea] ,
	[nombre_empresa] AS [Empresa] ,
	[nombre_proyecto] AS [proyecto] ,
	[nombre_sub_proyecto] AS [sub proyecto] ,
	[nombre_usuario] AS [Asignado]
FROM
	[dbo].[Tarea] INNER JOIN
	Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
	sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
	proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
	empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
	usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
	estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
WHERE
	id_usuario_asignado = @id_usuario And
	Tarea.id_estado_tarea = 1 And
	fecha_fin < @fecha
ORDER BY
	tarea.fecha_fin
END


--prioritarias
IF @consulta = 3 BEGIN
SELECT
	[id_tarea] AS [Id tarea] ,
	[nombre_estado_tarea] AS [Estado] ,
	[prioridad] AS [Prioridad] ,
	[nombre_tipo_tarea] AS [Tipo tarea] ,
	RTRIM(nombre_tarea) AS [Descripcion] ,
	tarea.[fecha_fin] AS [Fecha fin] ,
	DATEDIFF(d, Tarea.fecha_fin, getdate()) AS Demora,
	tarea.[fecha_real] AS [Fecha real] ,
	tarea.[hora_prevista] AS [Hora prevista] ,
	tarea.[hora_real] AS [Hora real] ,
	[id_tarea] AS [N° Tarea] ,
	[nombre_empresa] AS [Empresa] ,
	[nombre_proyecto] AS [proyecto] ,
	[nombre_sub_proyecto] AS [sub proyecto] ,
	[nombre_usuario] AS [Asignado]
FROM
	[dbo].[Tarea] INNER JOIN
	Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
	sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
	proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
	empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
	usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
	estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
WHERE
	id_usuario_asignado = @id_usuario And
	Tarea.id_estado_tarea = 1 And
	prioridad = 1
ORDER BY
	tarea.fecha_fin
END


--hoy
IF @consulta = 4 BEGIN
SELECT
	[id_tarea] AS [Id tarea] ,
	[nombre_estado_tarea] AS [Estado] ,
	[prioridad] AS [Prioridad] ,
	[nombre_tipo_tarea] AS [Tipo tarea] ,
	RTRIM(nombre_tarea) AS [Descripcion] ,
	tarea.[fecha_fin] AS [Fecha fin] ,
	DATEDIFF(d, Tarea.fecha_fin, getdate()) AS Demora,
	tarea.[fecha_real] AS [Fecha real] ,
	tarea.[hora_prevista] AS [Hora prevista] ,
	tarea.[hora_real] AS [Hora real] ,
	[id_tarea] AS [N° Tarea] ,
	[nombre_empresa] AS [Empresa] ,
	[nombre_proyecto] AS [proyecto] ,
	[nombre_sub_proyecto] AS [sub proyecto] ,
	[nombre_usuario] AS [Asignado]
FROM
	[dbo].[Tarea] INNER JOIN
	Tipo_tarea ON Tipo_tarea.id_tipo_tarea = tarea.id_tipo_tarea INNER JOIN
	sub_proyecto ON sub_proyecto.id_sub_proyecto = tarea.id_sub_proyecto INNER JOIN
	proyecto ON proyecto.id_proyecto = tarea.id_proyecto INNER JOIN
	empresa ON empresa.id_empresa = tarea.id_empresa INNER JOIN
	usuario ON usuario.id_usuario = tarea.id_usuario_asignado INNER JOIN
	estado_tarea ON estado_tarea.id_estado_tarea = tarea.id_estado_tarea
WHERE
	id_usuario_asignado = @id_usuario And
	Tarea.id_estado_tarea = 1 And
	DAY(fecha_fin) = DAY(@fecha) And
	MONTH(fecha_fin) = MONTH(@fecha) And
	YEAR(fecha_fin) = YEAR(@fecha) 
ORDER BY
	tarea.fecha_fin
END




GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetAllMailing]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[cop_Tarea_GetAllMailing]
	@id_empresa int
AS

SELECT
    [id_tarea] AS [Id tarea] ,
	id_tarea AS Numero
   -- [id_tipo_tarea] AS [Id tipo tarea] ,
   -- [id_sub_proyecto] AS [Id sub proyecto] ,
   -- RTRIM(nombre_tarea) AS [Nombre tarea] ,
  --  [fecha_fin] AS [Fecha fin] ,
  --  [fecha_real] AS [Fecha real] ,
  --  RTRIM(comentario) AS [Comentario] 
  --  [hora_prevista] AS [Hora prevista] ,
  --  [hora_real] AS [Hora real] ,
  --  [prioridad] AS [Prioridad] ,
 --   [id_usuario] AS [Id usuario] ,
 --   [id_estado_tarea] AS [Id estado tarea] ,
 --   [id_proyecto] AS [Id proyecto] ,
  --  [id_empresa] AS [Id empresa] ,
 --   [id_usuario_asignado] AS [Id usuario asignado] ,
  --  [enviada] AS [Enviada] ,
  --  RTRIM(archivo_relacionado) AS [Archivo relacionado]
FROM
    [dbo].[Tarea]
WHERE
	id_empresa = @id_empresa AND
	id_estado_tarea = 4 AND
	enviada = 0
ORDER BY
    [id_tipo_tarea]



GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_GetCmb]
AS

SELECT
    [id_tarea],
    [id_tipo_tarea],
    [id_sub_proyecto],
    [nombre_tarea],
    [fecha_pedido],
    [fecha_inicio],
    [fecha_fin],
    [fecha_real],
    [ubicacion_documento],
    [hora_prevista],
    [hora_real],
    [prioridad],
    [id_usuario],
    [id_estado_tarea],
    [id_proyecto],
    [id_empresa],
    [id_usuario_asignado],
    [enviada],
    [archivo_relacionado],
    [complejidad],
    [es_feriado],
    [IDCalendar]
FROM
    [dbo].[Tarea]
ORDER BY
    [id_tipo_tarea]
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetEntreFecha]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tarea_GetEntreFecha]
	@fecha_inicio datetime,
	@fecha_fin datetime,
	@id_empresa int,
	@id_proyecto int,
	@id_subproyecto int,
	@consulta int
AS

SET @fecha_fin = DATEADD(d, 1, @fecha_fin)

--filtrado por empresa
IF @consulta = 1 BEGIN
SELECT
    [id_tarea] AS [Id tarea] ,
    [dbo].[Tarea].[id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado],
	nombre_tipo_tarea
FROM
    [dbo].[Tarea] INNER JOIN
	tipo_tarea ON tipo_Tarea.id_tipo_tarea = tarea.id_tipo_tarea
where
	[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
	[dbo].[Tarea].[fecha_real] < @fecha_fin AND
	id_empresa = @id_empresa AND
	id_estado_tarea IN (1,4)
ORDER BY
    [dbo].[Tarea].[fecha_real]
END


--filtrado por proyecto
IF @consulta = 2 BEGIN
SELECT
    [id_tarea] AS [Id tarea] ,
    [dbo].[Tarea].[id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado],
	nombre_tipo_tarea
FROM
    [dbo].[Tarea] INNER JOIN
	tipo_tarea ON tipo_Tarea.id_tipo_tarea = tarea.id_tipo_tarea
where
	[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
	[dbo].[Tarea].[fecha_real] < @fecha_fin AND
	id_empresa = @id_empresa AND
	id_proyecto = @id_proyecto AND
	id_estado_tarea IN (1,4)
ORDER BY
    [dbo].[Tarea].[fecha_real]
END


--filtrado por subproyecto
IF @consulta = 3 BEGIN
SELECT
    [id_tarea] AS [Id tarea] ,
    [dbo].[Tarea].[id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado],
	nombre_tipo_tarea
FROM
    [dbo].[Tarea] INNER JOIN
	tipo_tarea ON tipo_Tarea.id_tipo_tarea = tarea.id_tipo_tarea
where
	[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
	[dbo].[Tarea].[fecha_real] < @fecha_fin AND
	id_empresa = @id_empresa AND
	id_proyecto = @id_proyecto AND
	id_sub_proyecto = @id_subproyecto AND
	id_estado_tarea IN (1,4)
ORDER BY
    [dbo].[Tarea].[fecha_real]
END

GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetEntreFechaIngesoft]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Tarea_GetEntreFechaIngesoft]
	@fecha_inicio datetime,
	@fecha_fin datetime,
	@id_empresa int,
	@id_proyecto int,
	@id_subproyecto int,
	@consulta int
AS

SET @fecha_fin = DATEADD(d, 1, @fecha_fin)


--por empresa
IF @consulta = 1 BEGIN
SELECT
    [dbo].[Tarea].[id_tarea] AS [Id tarea] ,
    [dbo].[Tarea].[id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    Tarea.[hora_prevista] AS [Hora prevista] ,
    [prioridad] AS [Prioridad] ,
    Tarea.[id_estado_tarea] AS [Id estado tarea] ,
    Tarea.[id_proyecto] AS [Id proyecto] ,
	nombre_tipo_tarea,
	nombre_empresa,
	complejidad,
	hora_real.comentario,
	hora_real.hora_real,
	[dbo].[Tarea].hora_prevista,
	hora_real.hora_real / (case when tarea.hora_prevista is null or tarea.hora_prevista = 0 then 1 else tarea.hora_prevista end) * 100 AS Avance,
	nombre_proyecto AS [Nombre proyecto],
	nombre_estado_tarea AS [Nombre estado tarea]
FROM         
	dbo.TAREA INNER JOIN
	dbo.Tipo_tarea ON dbo.Tipo_tarea.id_tipo_tarea = dbo.TAREA.id_tipo_tarea INNER JOIN
	dbo.Empresa ON dbo.Empresa.id_empresa = dbo.TAREA.id_empresa INNER JOIN
	dbo.Hora_real ON dbo.Hora_real.id_tarea = dbo.TAREA.id_tarea INNER JOIN
	dbo.PROYECTO ON dbo.TAREA.id_proyecto = dbo.PROYECTO.id_proyecto INNER JOIN
	dbo.Estado_tarea ON dbo.TAREA.id_estado_tarea = dbo.Estado_tarea.id_estado_tarea
where
	[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
	[dbo].[Tarea].[fecha_real] < @fecha_fin AND
	tarea.id_empresa = @id_empresa AND
	Tarea.id_estado_tarea IN (1,4)
ORDER BY
    [dbo].[Tarea].[fecha_real]
END


--por proyecto
IF @consulta = 2 BEGIN
SELECT
    [dbo].[Tarea].[id_tarea] AS [Id tarea] ,
    [dbo].[Tarea].[id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    Tarea.[hora_prevista] AS [Hora prevista] ,
    [prioridad] AS [Prioridad] ,
    Tarea.[id_estado_tarea] AS [Id estado tarea] ,
    Tarea.[id_proyecto] AS [Id proyecto] ,
	nombre_tipo_tarea,
	nombre_empresa,
	complejidad,
	hora_real.comentario,
	hora_real.hora_real,
	[dbo].[Tarea].hora_prevista,
	hora_real.hora_real / (case when tarea.hora_prevista is null or tarea.hora_prevista = 0 then 1 else tarea.hora_prevista end) * 100 AS Avance,
	nombre_proyecto AS [Nombre proyecto],
	nombre_estado_tarea AS [Nombre estado tarea]
FROM         
	dbo.TAREA INNER JOIN
	dbo.Tipo_tarea ON dbo.Tipo_tarea.id_tipo_tarea = dbo.TAREA.id_tipo_tarea INNER JOIN
	dbo.Empresa ON dbo.Empresa.id_empresa = dbo.TAREA.id_empresa INNER JOIN
	dbo.Hora_real ON dbo.Hora_real.id_tarea = dbo.TAREA.id_tarea INNER JOIN
	dbo.PROYECTO ON dbo.TAREA.id_proyecto = dbo.PROYECTO.id_proyecto INNER JOIN
	dbo.Estado_tarea ON dbo.TAREA.id_estado_tarea = dbo.Estado_tarea.id_estado_tarea
where
	[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
	[dbo].[Tarea].[fecha_real] < @fecha_fin AND
	tarea.id_empresa = @id_empresa AND
	Tarea.id_proyecto = @id_proyecto AND
	Tarea.id_estado_tarea IN (1,4)
ORDER BY
    [dbo].[Tarea].[fecha_real]
END


--por subproyecto
IF @consulta = 3 BEGIN
SELECT
    [dbo].[Tarea].[id_tarea] AS [Id tarea] ,
    [dbo].[Tarea].[id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    RTRIM(nombre_tarea) AS [Nombre tarea] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    Tarea.[hora_prevista] AS [Hora prevista] ,
    [prioridad] AS [Prioridad] ,
    Tarea.[id_estado_tarea] AS [Id estado tarea] ,
    Tarea.[id_proyecto] AS [Id proyecto] ,
	nombre_tipo_tarea,
	nombre_empresa,
	complejidad,
	hora_real.comentario,
	hora_real.hora_real,
	[dbo].[Tarea].hora_prevista,
	hora_real.hora_real / (case when tarea.hora_prevista is null or tarea.hora_prevista = 0 then 1 else tarea.hora_prevista end) * 100 AS Avance,
	nombre_proyecto AS [Nombre proyecto],
	nombre_estado_tarea AS [Nombre estado tarea]
FROM         
	dbo.TAREA INNER JOIN
	dbo.Tipo_tarea ON dbo.Tipo_tarea.id_tipo_tarea = dbo.TAREA.id_tipo_tarea INNER JOIN
	dbo.Empresa ON dbo.Empresa.id_empresa = dbo.TAREA.id_empresa INNER JOIN
	dbo.Hora_real ON dbo.Hora_real.id_tarea = dbo.TAREA.id_tarea INNER JOIN
	dbo.PROYECTO ON dbo.TAREA.id_proyecto = dbo.PROYECTO.id_proyecto INNER JOIN
	dbo.Estado_tarea ON dbo.TAREA.id_estado_tarea = dbo.Estado_tarea.id_estado_tarea
where
	[dbo].[Tarea].[fecha_real] >= @fecha_inicio AND
	[dbo].[Tarea].[fecha_real] < @fecha_fin AND
	tarea.id_empresa = @id_empresa AND
	Tarea.id_proyecto = @id_proyecto AND
	id_sub_proyecto = @id_subproyecto AND
	Tarea.id_estado_tarea IN (1,4)
ORDER BY
    [dbo].[Tarea].[fecha_real]
END



GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_GetOne]
    @id_tarea    int
AS

SELECT
    [id_tarea] AS [Id tarea] ,
    [id_tipo_tarea] AS [Id tipo tarea] ,
    [id_sub_proyecto] AS [Id sub proyecto] ,
    [nombre_tarea] AS [Nombre tarea] ,
    [fecha_pedido] AS [Fecha pedido] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin] AS [Fecha fin] ,
    [fecha_real] AS [Fecha real] ,
    [ubicacion_documento] AS [Ubicacion documento] ,
    [hora_prevista] AS [Hora prevista] ,
    [hora_real] AS [Hora real] ,
    [prioridad] AS [Prioridad] ,
    [id_usuario] AS [Id usuario] ,
    [id_estado_tarea] AS [Id estado tarea] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_empresa] AS [Id empresa] ,
    [id_usuario_asignado] AS [Id usuario asignado] ,
    [enviada] AS [Enviada] ,
    [archivo_relacionado] AS [Archivo relacionado] ,
    [complejidad] AS [Complejidad] ,
    [es_feriado] AS [Es feriado] ,
    [IDCalendar] AS [Idcalendar]
FROM
    [dbo].[Tarea]
WHERE
    [id_tarea]  =  @id_tarea
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetOne_Fechas]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cop_Tarea_GetOne_Fechas]
    @id_usuario    int
AS

DECLARE @fecha_inicio datetime
DECLARE @fecha_fin datetime

SELECT TOP 1
    @fecha_inicio = [fecha_inicio] 
FROM
    [dbo].[Tarea]
WHERE
    id_estado_tarea = 1 AND
	id_usuario_asignado = @id_usuario
ORDER BY
	fecha_inicio

SELECT TOP 1
    @fecha_fin = [fecha_inicio] 
FROM
    [dbo].[Tarea]
WHERE
    id_estado_tarea = 1 AND
	id_usuario_asignado = @id_usuario
ORDER BY
	fecha_inicio DESC


IF @fecha_inicio IS NULL BEGIN SET @fecha_inicio = getdate() SET @fecha_fin = GETDATE() END

SELECT 
	@fecha_inicio AS [Fecha inicio],
	@fecha_fin AS [Fecha fin]
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_GetOneCalendarID]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tarea_GetOneCalendarID]
    @IDCalendar   varchar(500)
AS

SELECT
    [id_tarea] AS [Id tarea] 
    --[id_tipo_tarea] AS [Id tipo tarea] ,
    --[id_sub_proyecto] AS [Id sub proyecto] ,
    --[nombre_tarea] AS [Nombre tarea] ,
    --[fecha_pedido] AS [Fecha pedido] ,
    --[fecha_inicio] AS [Fecha inicio] ,
    --[fecha_fin] AS [Fecha fin] ,
    --[fecha_real] AS [Fecha real] ,
    --[ubicacion_documento] AS [Ubicacion documento] ,
    --[hora_prevista] AS [Hora prevista] ,
    --[hora_real] AS [Hora real] ,
    --[prioridad] AS [Prioridad] ,
    --[id_usuario] AS [Id usuario] ,
    --[id_estado_tarea] AS [Id estado tarea] ,
    --[id_proyecto] AS [Id proyecto] ,
    --[id_empresa] AS [Id empresa] ,
    --[id_usuario_asignado] AS [Id usuario asignado] ,
    --[enviada] AS [Enviada] ,
    --[archivo_relacionado] AS [Archivo relacionado] ,
    --[complejidad] AS [Complejidad] ,
    --[es_feriado] AS [Es feriado] ,
    --[IDCalendar] AS [Idcalendar]
FROM
    [dbo].[Tarea]
WHERE
    RTRIM([IDCalendar])  =  RTRIM(@IDCalendar)
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_Insert]
    @id_tarea    int  output,
    @id_tipo_tarea    int  ,
    @id_sub_proyecto    int  ,
    @nombre_tarea    varchar  (5000),
    @fecha_pedido    datetime  ,
    @fecha_inicio    datetime  ,
    @fecha_fin    datetime  ,
    @fecha_real    datetime  ,
    @ubicacion_documento    varchar  (5000),
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @prioridad    decimal  (18,0),
    @id_usuario    int  ,
    @id_estado_tarea    int  ,
    @id_proyecto    int  ,
    @id_empresa    int  ,
    @id_usuario_asignado    int  ,
    @enviada    bit  ,
    @archivo_relacionado    varchar  (5000),
    @complejidad    char  (1),
    @es_feriado    bit  ,
    @IDCalendar    varchar  (5000)
AS

INSERT INTO [dbo].[Tarea]
(
    [id_tipo_tarea],
    [id_sub_proyecto],
    [nombre_tarea],
    [fecha_pedido],
    [fecha_inicio],
    [fecha_fin],
    [fecha_real],
    [ubicacion_documento],
    [hora_prevista],
    [hora_real],
    [prioridad],
    [id_usuario],
    [id_estado_tarea],
    [id_proyecto],
    [id_empresa],
    [id_usuario_asignado],
    [enviada],
    [archivo_relacionado],
    [complejidad],
    [es_feriado],
    [IDCalendar]
)
VALUES
(
    @id_tipo_tarea,
    @id_sub_proyecto,
    @nombre_tarea,
    @fecha_pedido,
    @fecha_inicio,
    @fecha_fin,
    @fecha_real,
    @ubicacion_documento,
    @hora_prevista,
    @hora_real,
    @prioridad,
    @id_usuario,
    @id_estado_tarea,
    @id_proyecto,
    @id_empresa,
    @id_usuario_asignado,
    @enviada,
    @archivo_relacionado,
    @complejidad,
    @es_feriado,
    @IDCalendar
)
SET @id_tarea = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_InsertOne]
AS

INSERT INTO [dbo].[Tarea]
(
    [id_tipo_tarea],
    [id_sub_proyecto],
    [nombre_tarea],
    [fecha_pedido],
    [fecha_inicio],
    [fecha_fin],
    [fecha_real],
    [ubicacion_documento],
    [hora_prevista],
    [hora_real],
    [prioridad],
    [id_usuario],
    [id_estado_tarea],
    [id_proyecto],
    [id_empresa],
    [id_usuario_asignado],
    [enviada],
    [archivo_relacionado],
    [complejidad],
    [es_feriado],
    [IDCalendar]
)
VALUES
(
    1,
    1,
    'Ninguno',
    '01-01-2000',
    '01-01-2000',
    '01-01-2000',
    '01-01-2000',
    'Ninguno',
    0,
    0,
    0,
    1,
    1,
    1,
    1,
    1,
    0,
    'Ninguno',
    '',
    0,
    'Ninguno'
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Tarea_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Tarea_Update]
    @id_tarea    int  output,
    @id_tipo_tarea    int  ,
    @id_sub_proyecto    int  ,
    @nombre_tarea    varchar  (5000),
    @fecha_pedido    datetime  ,
    @fecha_inicio    datetime  ,
    @fecha_fin    datetime  ,
    @fecha_real    datetime  ,
    @ubicacion_documento    varchar  (5000),
    @hora_prevista    decimal  (18,2),
    @hora_real    decimal  (18,2),
    @prioridad    decimal  (18,0),
    @id_usuario    int  ,
    @id_estado_tarea    int  ,
    @id_proyecto    int  ,
    @id_empresa    int  ,
    @id_usuario_asignado    int  ,
    @enviada    bit  ,
    @archivo_relacionado    varchar  (5000),
    @complejidad    char  (1),
    @es_feriado    bit  ,
    @IDCalendar    varchar  (5000)
AS

UPDATE [dbo].[Tarea] SET
    [id_tipo_tarea] = @id_tipo_tarea,
    [id_sub_proyecto] = @id_sub_proyecto,
    [nombre_tarea] = @nombre_tarea,
    [fecha_pedido] = @fecha_pedido,
    [fecha_inicio] = @fecha_inicio,
    [fecha_fin] = @fecha_fin,
    [fecha_real] = @fecha_real,
    [ubicacion_documento] = @ubicacion_documento,
    [hora_prevista] = @hora_prevista,
    [hora_real] = @hora_real,
    [prioridad] = @prioridad,
    [id_usuario] = @id_usuario,
    [id_estado_tarea] = @id_estado_tarea,
    [id_proyecto] = @id_proyecto,
    [id_empresa] = @id_empresa,
    [id_usuario_asignado] = @id_usuario_asignado,
    [enviada] = @enviada,
    [archivo_relacionado] = @archivo_relacionado,
    [complejidad] = @complejidad,
    [es_feriado] = @es_feriado,
    [IDCalendar] = @IDCalendar
WHERE
    [id_tarea]  =  @id_tarea
GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_Delete]
    @id_tipo_empresa    int
AS

DELETE FROM [dbo].[Tipo_empresa]
WHERE
    [id_tipo_empresa]  =  @id_tipo_empresa


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_Exist]
    @nombre_tipo_empresa    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_empresa
FROM
    [dbo].[Tipo_empresa]
WHERE
    [nombre_tipo_empresa] = @nombre_tipo_empresa

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_empresa] AS [Id tipo empresa] ,
    RTRIM(nombre_tipo_empresa) AS [Nombre tipo empresa]
FROM
    [dbo].[Tipo_empresa]
WHERE
    [nombre_tipo_empresa] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_empresa]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_GetAll]
AS

SELECT TOP 100
    [id_tipo_empresa] AS [Id tipo empresa] ,
    RTRIM(nombre_tipo_empresa) AS [Nombre tipo empresa]
FROM
    [dbo].[Tipo_empresa]
ORDER BY
    [nombre_tipo_empresa]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_GetCmb]
AS

SELECT
    [id_tipo_empresa],
    [nombre_tipo_empresa]
FROM
    [dbo].[Tipo_empresa]
ORDER BY
    [nombre_tipo_empresa]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_GetOne]
    @id_tipo_empresa    int
AS

SELECT
    [id_tipo_empresa] AS [Id tipo empresa] ,
    [nombre_tipo_empresa] AS [Nombre tipo empresa]
FROM
    [dbo].[Tipo_empresa]
WHERE
    [id_tipo_empresa]  =  @id_tipo_empresa


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_Insert]
    @id_tipo_empresa    int  output,
    @nombre_tipo_empresa    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_empresa]
(
    [nombre_tipo_empresa]
)
VALUES
(
    @nombre_tipo_empresa
)
SET @id_tipo_empresa = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_InsertOne]
AS

INSERT INTO [dbo].[Tipo_empresa]
(
    [nombre_tipo_empresa]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_empresa_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_empresa_Update]
    @id_tipo_empresa    int  output,
    @nombre_tipo_empresa    varchar  (50)
AS

UPDATE [dbo].[Tipo_empresa] SET
    [nombre_tipo_empresa] = @nombre_tipo_empresa
WHERE
    [id_tipo_empresa]  =  @id_tipo_empresa


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_Delete]
    @id_tipo_mejora    int
AS

DELETE FROM [dbo].[Tipo_mejora]
WHERE
    [id_tipo_mejora]  =  @id_tipo_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_Exist]
    @nombre_tipo_mejora    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_mejora
FROM
    [dbo].[Tipo_mejora]
WHERE
    [nombre_tipo_mejora] = @nombre_tipo_mejora

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_mejora] AS [Id tipo mejora] ,
    RTRIM(nombre_tipo_mejora) AS [Nombre tipo mejora]
FROM
    [dbo].[Tipo_mejora]
WHERE
    [nombre_tipo_mejora] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_mejora]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_GetAll]
AS

SELECT TOP 100
    [id_tipo_mejora] AS [Id tipo mejora] ,
    RTRIM(nombre_tipo_mejora) AS [Nombre tipo mejora]
FROM
    [dbo].[Tipo_mejora]
ORDER BY
    [nombre_tipo_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_GetCmb]
AS

SELECT
    [id_tipo_mejora],
    [nombre_tipo_mejora]
FROM
    [dbo].[Tipo_mejora]
ORDER BY
    [nombre_tipo_mejora]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_GetOne]
    @id_tipo_mejora    int
AS

SELECT
    [id_tipo_mejora] AS [Id tipo mejora] ,
    [nombre_tipo_mejora] AS [Nombre tipo mejora]
FROM
    [dbo].[Tipo_mejora]
WHERE
    [id_tipo_mejora]  =  @id_tipo_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_Insert]
    @id_tipo_mejora    int  output,
    @nombre_tipo_mejora    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_mejora]
(
    [nombre_tipo_mejora]
)
VALUES
(
    @nombre_tipo_mejora
)
SET @id_tipo_mejora = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_InsertOne]
AS

INSERT INTO [dbo].[Tipo_mejora]
(
    [nombre_tipo_mejora]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_mejora_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_mejora_Update]
    @id_tipo_mejora    int  output,
    @nombre_tipo_mejora    varchar  (50)
AS

UPDATE [dbo].[Tipo_mejora] SET
    [nombre_tipo_mejora] = @nombre_tipo_mejora
WHERE
    [id_tipo_mejora]  =  @id_tipo_mejora


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_Delete]
    @id_tipo_proyecto    int
AS

DELETE FROM [dbo].[Tipo_proyecto]
WHERE
    [id_tipo_proyecto]  =  @id_tipo_proyecto


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_Exist]
    @nombre_tipo_proyecto    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_proyecto
FROM
    [dbo].[Tipo_proyecto]
WHERE
    [nombre_tipo_proyecto] = @nombre_tipo_proyecto

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_proyecto] AS [Id tipo proyecto] ,
    RTRIM(nombre_tipo_proyecto) AS [Nombre tipo proyecto]
FROM
    [dbo].[Tipo_proyecto]
WHERE
    [nombre_tipo_proyecto] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_proyecto]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_GetAll]
AS

SELECT TOP 100
    [id_tipo_proyecto] AS [Id tipo proyecto] ,
    RTRIM(nombre_tipo_proyecto) AS [Nombre tipo proyecto]
FROM
    [dbo].[Tipo_proyecto]
ORDER BY
    [nombre_tipo_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_GetCmb]
AS

SELECT
    [id_tipo_proyecto],
    [nombre_tipo_proyecto]
FROM
    [dbo].[Tipo_proyecto]
ORDER BY
    [nombre_tipo_proyecto]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_GetOne]
    @id_tipo_proyecto    int
AS

SELECT
    [id_tipo_proyecto] AS [Id tipo proyecto] ,
    [nombre_tipo_proyecto] AS [Nombre tipo proyecto]
FROM
    [dbo].[Tipo_proyecto]
WHERE
    [id_tipo_proyecto]  =  @id_tipo_proyecto


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_Insert]
    @id_tipo_proyecto    int  output,
    @nombre_tipo_proyecto    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_proyecto]
(
    [nombre_tipo_proyecto]
)
VALUES
(
    @nombre_tipo_proyecto
)
SET @id_tipo_proyecto = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_InsertOne]
AS

INSERT INTO [dbo].[Tipo_proyecto]
(
    [nombre_tipo_proyecto]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_proyecto_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_proyecto_Update]
    @id_tipo_proyecto    int  output,
    @nombre_tipo_proyecto    varchar  (50)
AS

UPDATE [dbo].[Tipo_proyecto] SET
    [nombre_tipo_proyecto] = @nombre_tipo_proyecto
WHERE
    [id_tipo_proyecto]  =  @id_tipo_proyecto


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_Delete]
    @id_tipo_tarea    int
AS

DELETE FROM [dbo].[Tipo_tarea]
WHERE
    [id_tipo_tarea]  =  @id_tipo_tarea


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_Exist]
    @nombre_tipo_tarea    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_tarea
FROM
    [dbo].[Tipo_tarea]
WHERE
    [nombre_tipo_tarea] = @nombre_tipo_tarea

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_tarea] AS [Id tipo tarea] ,
    RTRIM(nombre_tipo_tarea) AS [Nombre tipo tarea]
FROM
    [dbo].[Tipo_tarea]
WHERE
    [nombre_tipo_tarea] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_tarea]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_GetAll]
AS

SELECT TOP 100
    [id_tipo_tarea] AS [Id tipo tarea] ,
    RTRIM(nombre_tipo_tarea) AS [Nombre tipo tarea]
FROM
    [dbo].[Tipo_tarea]
ORDER BY
    [nombre_tipo_tarea]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_GetCmb]
AS

SELECT
    [id_tipo_tarea],
    [nombre_tipo_tarea]
FROM
    [dbo].[Tipo_tarea]
ORDER BY
    [nombre_tipo_tarea]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_GetOne]
    @id_tipo_tarea    int
AS

SELECT
    [id_tipo_tarea] AS [Id tipo tarea] ,
    [nombre_tipo_tarea] AS [Nombre tipo tarea]
FROM
    [dbo].[Tipo_tarea]
WHERE
    [id_tipo_tarea]  =  @id_tipo_tarea


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_Insert]
    @id_tipo_tarea    int  output,
    @nombre_tipo_tarea    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_tarea]
(
    [nombre_tipo_tarea]
)
VALUES
(
    @nombre_tipo_tarea
)
SET @id_tipo_tarea = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_InsertOne]
AS

INSERT INTO [dbo].[Tipo_tarea]
(
    [nombre_tipo_tarea]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_tarea_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_tarea_Update]
    @id_tipo_tarea    int  output,
    @nombre_tipo_tarea    varchar  (50)
AS

UPDATE [dbo].[Tipo_tarea] SET
    [nombre_tipo_tarea] = @nombre_tipo_tarea
WHERE
    [id_tipo_tarea]  =  @id_tipo_tarea


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_Delete]
    @id_tipo_usuario    int
AS

DELETE FROM [dbo].[Tipo_usuario]
WHERE
    [id_tipo_usuario]  =  @id_tipo_usuario


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_Exist]
    @nombre_tipo_usuario    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_usuario
FROM
    [dbo].[Tipo_usuario]
WHERE
    [nombre_tipo_usuario] = @nombre_tipo_usuario

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_usuario] AS [Id tipo usuario] ,
    RTRIM(nombre_tipo_usuario) AS [Nombre tipo usuario]
FROM
    [dbo].[Tipo_usuario]
WHERE
    [nombre_tipo_usuario] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_usuario]
END


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_GetAll]
AS

SELECT TOP 100
    [id_tipo_usuario] AS [Id tipo usuario] ,
    RTRIM(nombre_tipo_usuario) AS [Nombre tipo usuario]
FROM
    [dbo].[Tipo_usuario]
ORDER BY
    [nombre_tipo_usuario]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_GetCmb]
AS

SELECT
    [id_tipo_usuario],
    [nombre_tipo_usuario]
FROM
    [dbo].[Tipo_usuario]
ORDER BY
    [nombre_tipo_usuario]


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_GetOne]
    @id_tipo_usuario    int
AS

SELECT
    [id_tipo_usuario] AS [Id tipo usuario] ,
    [nombre_tipo_usuario] AS [Nombre tipo usuario]
FROM
    [dbo].[Tipo_usuario]
WHERE
    [id_tipo_usuario]  =  @id_tipo_usuario


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_Insert]
    @id_tipo_usuario    int  output,
    @nombre_tipo_usuario    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_usuario]
(
    [nombre_tipo_usuario]
)
VALUES
(
    @nombre_tipo_usuario
)
SET @id_tipo_usuario = @@IDENTITY


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_InsertOne]
AS

INSERT INTO [dbo].[Tipo_usuario]
(
    [nombre_tipo_usuario]
)
VALUES
(
    'Ninguno'
)


GO
/****** Object:  StoredProcedure [dbo].[cop_Tipo_usuario_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Tipo_usuario_Update]
    @id_tipo_usuario    int  output,
    @nombre_tipo_usuario    varchar  (50)
AS

UPDATE [dbo].[Tipo_usuario] SET
    [nombre_tipo_usuario] = @nombre_tipo_usuario
WHERE
    [id_tipo_usuario]  =  @id_tipo_usuario


GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_Delete]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Delete]
    @id_usuario    int
AS

DELETE FROM [dbo].[Usuario]
WHERE
    [id_usuario]  =  @id_usuario
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_Exist]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Exist]
    @nombre_usuario    varchar  (50),
    @apellido_usuario    varchar  (50),
    @identificador    varchar  (50),
    @clave    varchar  (50),
    @id_tipo_usuario    int  ,
    @id_empresa    int  ,
    @costo    decimal  (18,2),
    @capacidad_trabajo    decimal  (18,2),
    @usuario_calendar    varchar  (500),
    @password_calendar    varchar  (500),
    @mail    varchar  (500)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_usuario
FROM
    [dbo].[Usuario]
WHERE
    [nombre_usuario] = @nombre_usuario AND
    [apellido_usuario] = @apellido_usuario AND
    [identificador] = @identificador AND
    [clave] = @clave AND
    [id_tipo_usuario] = @id_tipo_usuario AND
    [id_empresa] = @id_empresa AND
    [costo] = @costo AND
    [capacidad_trabajo] = @capacidad_trabajo AND
    [usuario_calendar] = @usuario_calendar AND
    [password_calendar] = @password_calendar AND
    [mail] = @mail

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_Find]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(apellido_usuario) AS [Apellido usuario] ,
    RTRIM(identificador) AS [Identificador] ,
    RTRIM(clave) AS [Clave] ,
    [id_tipo_usuario] AS [Id tipo usuario] ,
    [id_empresa] AS [Id empresa] ,
    [costo] AS [Costo] ,
    [capacidad_trabajo] AS [Capacidad trabajo] ,
    RTRIM(usuario_calendar) AS [Usuario calendar] ,
    RTRIM(password_calendar) AS [Password calendar] ,
    RTRIM(mail) AS [Mail]
FROM
    [dbo].[Usuario]
WHERE
    [nombre_usuario] LIKE @nombre+'%'
ORDER BY
    [nombre_usuario]
END
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetAll]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_GetAll]
AS

SELECT TOP 100
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(apellido_usuario) AS [Apellido usuario] ,
    RTRIM(identificador) AS [Identificador] ,
    RTRIM(clave) AS [Clave] ,
    [id_tipo_usuario] AS [Id tipo usuario] ,
    [id_empresa] AS [Id empresa] ,
    [costo] AS [Costo] ,
    [capacidad_trabajo] AS [Capacidad trabajo] ,
    RTRIM(usuario_calendar) AS [Usuario calendar] ,
    RTRIM(password_calendar) AS [Password calendar] ,
    RTRIM(mail) AS [Mail]
FROM
    [dbo].[Usuario]
ORDER BY
    [nombre_usuario]
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetAll_2]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Usuario_GetAll_2]
AS

SELECT
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(apellido_usuario) AS [Apellido usuario] ,
    RTRIM(identificador) AS [Identificador] ,
    RTRIM(clave) AS [Clave] ,
    [nombre_tipo_usuario] AS [Tipo usuario]
FROM
    [dbo].[Usuario] INNER JOIN
	tipo_usuario ON Tipo_usuario.id_tipo_usuario = Usuario.id_tipo_usuario
ORDER BY
    [nombre_usuario]


GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetAll_3]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Usuario_GetAll_3]
AS

SELECT
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(apellido_usuario) AS [Apellido usuario] ,
    RTRIM(identificador) AS [Identificador] ,
    RTRIM(clave) AS [Clave] ,
    [nombre_tipo_usuario] AS [tipo usuario] ,
    [nombre_empresa] AS [empresa]
FROM
    [dbo].[Usuario] INNER JOIN
	Tipo_usuario ON Tipo_usuario.id_tipo_usuario = Usuario.id_tipo_usuario INNER JOIN
	Empresa ON Empresa.id_empresa = Usuario.id_empresa
ORDER BY
    [nombre_usuario]


GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetCmb]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_GetCmb]
AS

SELECT
    [id_usuario],
    [nombre_usuario],
    [apellido_usuario],
    [identificador],
    [clave],
    [id_tipo_usuario],
    [id_empresa],
    [costo],
    [capacidad_trabajo],
    [usuario_calendar],
    [password_calendar],
    [mail]
FROM
    [dbo].[Usuario]
ORDER BY
    [nombre_usuario]
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetCmbAsignado]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[cop_Usuario_GetCmbAsignado]
	@id_empresa int
AS

SELECT
    [id_usuario],
    [nombre_usuario],
    [apellido_usuario],
    [identificador],
    [clave],
    [id_tipo_usuario]
FROM
    [dbo].[Usuario] INNER JOIN
	empresa ON empresa.id_empresa = usuario.id_empresa
WHERE
	usuario.id_empresa = @id_empresa
ORDER BY
    [nombre_usuario]


GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_GetOne]
    @id_usuario    int
AS

SELECT
    [id_usuario] AS [Id usuario] ,
    [nombre_usuario] AS [Nombre usuario] ,
    [apellido_usuario] AS [Apellido usuario] ,
    [identificador] AS [Identificador] ,
    [clave] AS [Clave] ,
    [id_tipo_usuario] AS [Id tipo usuario] ,
    [id_empresa] AS [Id empresa] ,
    [costo] AS [Costo] ,
    [capacidad_trabajo] AS [Capacidad trabajo] ,
    [usuario_calendar] AS [Usuario calendar] ,
    [password_calendar] AS [Password calendar] ,
    [mail] AS [Mail]
FROM
    [dbo].[Usuario]
WHERE
    [id_usuario]  =  @id_usuario
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_GetUser]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[cop_Usuario_GetUser]
	@nombre_usuario	varchar(50),
	@password_usuario	varchar(50)
AS

SELECT     
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(apellido_usuario) AS [Apellido usuario] ,
    RTRIM(identificador) AS [Identificador] ,
    RTRIM(clave) AS [Clave] ,
    [id_tipo_usuario] AS [Id tipo usuario] ,
    [id_empresa] AS [Id empresa] ,
    [costo] AS [Costo] ,
    [capacidad_trabajo] AS [Capacidad trabajo] ,
    RTRIM(usuario_calendar) AS [Usuario calendar] ,
    RTRIM(password_calendar) AS [Password calendar],
	mail AS Mail
FROM         
	dbo.USUARIO
WHERE
	identificador = @nombre_usuario AND
	clave = @password_usuario


GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_Insert]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Insert]
    @id_usuario    int  output,
    @nombre_usuario    varchar  (50),
    @apellido_usuario    varchar  (50),
    @identificador    varchar  (50),
    @clave    varchar  (50),
    @id_tipo_usuario    int  ,
    @id_empresa    int  ,
    @costo    decimal  (18,2),
    @capacidad_trabajo    decimal  (18,2),
    @usuario_calendar    varchar  (500),
    @password_calendar    varchar  (500),
    @mail    varchar  (500)
AS

INSERT INTO [dbo].[Usuario]
(
    [nombre_usuario],
    [apellido_usuario],
    [identificador],
    [clave],
    [id_tipo_usuario],
    [id_empresa],
    [costo],
    [capacidad_trabajo],
    [usuario_calendar],
    [password_calendar],
    [mail]
)
VALUES
(
    @nombre_usuario,
    @apellido_usuario,
    @identificador,
    @clave,
    @id_tipo_usuario,
    @id_empresa,
    @costo,
    @capacidad_trabajo,
    @usuario_calendar,
    @password_calendar,
    @mail
)
SET @id_usuario = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_InsertOne]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_InsertOne]
AS

INSERT INTO [dbo].[Usuario]
(
    [nombre_usuario],
    [apellido_usuario],
    [identificador],
    [clave],
    [id_tipo_usuario],
    [id_empresa],
    [costo],
    [capacidad_trabajo],
    [usuario_calendar],
    [password_calendar],
    [mail]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    1,
    1,
    0,
    0,
    'Ninguno',
    'Ninguno',
    'Ninguno'
)
GO
/****** Object:  StoredProcedure [dbo].[cop_Usuario_Update]    Script Date: 25/09/2023 16:43:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Update]
    @id_usuario    int  output,
    @nombre_usuario    varchar  (50),
    @apellido_usuario    varchar  (50),
    @identificador    varchar  (50),
    @clave    varchar  (50),
    @id_tipo_usuario    int  ,
    @id_empresa    int  ,
    @costo    decimal  (18,2),
    @capacidad_trabajo    decimal  (18,2),
    @usuario_calendar    varchar  (500),
    @password_calendar    varchar  (500),
    @mail    varchar  (500)
AS

UPDATE [dbo].[Usuario] SET
    [nombre_usuario] = @nombre_usuario,
    [apellido_usuario] = @apellido_usuario,
    [identificador] = @identificador,
    [clave] = @clave,
    [id_tipo_usuario] = @id_tipo_usuario,
    [id_empresa] = @id_empresa,
    [costo] = @costo,
    [capacidad_trabajo] = @capacidad_trabajo,
    [usuario_calendar] = @usuario_calendar,
    [password_calendar] = @password_calendar,
    [mail] = @mail
WHERE
    [id_usuario]  =  @id_usuario
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 4
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Empresa"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 201
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PROYECTO"
            Begin Extent = 
               Top = 6
               Left = 239
               Bottom = 114
               Right = 404
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sub_proyecto"
            Begin Extent = 
               Top = 6
               Left = 442
               Bottom = 114
               Right = 630
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2625
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vista_datos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vista_datos'
GO
USE [master]
GO
ALTER DATABASE [Gestion_tarea] SET  READ_WRITE 
GO
