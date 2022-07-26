USE [AFIP]
GO
/****** Object:  Table [dbo].[CodigoActividad]    Script Date: 23/07/2022 20:41:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigoActividad](
	[CUIL] [varchar](11) NOT NULL,
	[Codigo] [varchar](6) NOT NULL,
 CONSTRAINT [PK__tmp_ms_x__3214EC07EFEA3241] PRIMARY KEY CLUSTERED 
(
	[CUIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'20005344565', N'001322')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'20142398258', N'001100')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'20222222227', N'12346')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'20276378751', N'001322')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'20292666557', N'004355')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'20294366764', N'004355')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'27302353876', N'004355')
INSERT [dbo].[CodigoActividad] ([CUIL], [Codigo]) VALUES (N'27303224561', N'004355')
GO
