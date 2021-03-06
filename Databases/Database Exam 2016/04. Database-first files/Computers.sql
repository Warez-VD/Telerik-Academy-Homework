USE [Computers]
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 8.11.2016 г. 14:26:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Vendor] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[CpuId] [int] NOT NULL,
	[Memory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Computers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComputersGpus]    Script Date: 8.11.2016 г. 14:26:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputersGpus](
	[ComputerId] [int] NOT NULL,
	[GpuId] [int] NOT NULL,
 CONSTRAINT [PK_ComputersGpus] PRIMARY KEY CLUSTERED 
(
	[ComputerId] ASC,
	[GpuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComputersStorageDevices]    Script Date: 8.11.2016 г. 14:26:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputersStorageDevices](
	[ComputerId] [int] NOT NULL,
	[StorageDeviceId] [int] NOT NULL,
 CONSTRAINT [PK_ComputersStorageDevices] PRIMARY KEY CLUSTERED 
(
	[ComputerId] ASC,
	[StorageDeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cpus]    Script Date: 8.11.2016 г. 14:26:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cpus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Vendor] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[NumberOfCores] [int] NOT NULL,
	[ClockCycles] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cpus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gpus]    Script Date: 8.11.2016 г. 14:26:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gpus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Vendor] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Memory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gpus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StorageDevices]    Script Date: 8.11.2016 г. 14:26:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StorageDevices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Vendor] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Size] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StorageDevices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD  CONSTRAINT [FK_Computers_Cpus] FOREIGN KEY([CpuId])
REFERENCES [dbo].[Cpus] ([Id])
GO
ALTER TABLE [dbo].[Computers] CHECK CONSTRAINT [FK_Computers_Cpus]
GO
ALTER TABLE [dbo].[ComputersGpus]  WITH CHECK ADD  CONSTRAINT [FK_ComputersGpus_Computers] FOREIGN KEY([ComputerId])
REFERENCES [dbo].[Computers] ([Id])
GO
ALTER TABLE [dbo].[ComputersGpus] CHECK CONSTRAINT [FK_ComputersGpus_Computers]
GO
ALTER TABLE [dbo].[ComputersGpus]  WITH CHECK ADD  CONSTRAINT [FK_ComputersGpus_Gpus] FOREIGN KEY([GpuId])
REFERENCES [dbo].[Gpus] ([Id])
GO
ALTER TABLE [dbo].[ComputersGpus] CHECK CONSTRAINT [FK_ComputersGpus_Gpus]
GO
ALTER TABLE [dbo].[ComputersStorageDevices]  WITH CHECK ADD  CONSTRAINT [FK_ComputersStorageDevices_Computers] FOREIGN KEY([ComputerId])
REFERENCES [dbo].[Computers] ([Id])
GO
ALTER TABLE [dbo].[ComputersStorageDevices] CHECK CONSTRAINT [FK_ComputersStorageDevices_Computers]
GO
ALTER TABLE [dbo].[ComputersStorageDevices]  WITH CHECK ADD  CONSTRAINT [FK_ComputersStorageDevices_StorageDevices] FOREIGN KEY([StorageDeviceId])
REFERENCES [dbo].[StorageDevices] ([Id])
GO
ALTER TABLE [dbo].[ComputersStorageDevices] CHECK CONSTRAINT [FK_ComputersStorageDevices_StorageDevices]
GO
