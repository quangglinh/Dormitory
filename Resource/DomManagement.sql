USE [DomManagement]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[managerID] [nchar](10) NOT NULL,
	[name] [nchar](200) NOT NULL,
	[email] [nchar](200) NULL,
	[phone] [nchar](20) NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[managerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Manager] ([managerID], [name], [email], [phone]) VALUES (N'mng06344  ', N'Nguyễn Văn An                                                                                                                                                                                           ', N'annv@fe.edu.vn                                                                                                                                                                                          ', N'045982824           ')
INSERT [dbo].[Manager] ([managerID], [name], [email], [phone]) VALUES (N'mng06345  ', N'Nguyễn Văn Bình                                                                                                                                                                                         ', N'binhbv@fe.edu.vn                                                                                                                                                                                        ', N'096293888           ')
/****** Object:  Table [dbo].[Room]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[roomID] [nchar](10) NOT NULL,
	[dom] [nchar](10) NOT NULL,
	[monthlyFee] [nchar](10) NOT NULL,
	[numberOfSlot] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[roomID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Room] ([roomID], [dom], [monthlyFee], [numberOfSlot]) VALUES (N'A101      ', N'A         ', N'900000    ', 6)
INSERT [dbo].[Room] ([roomID], [dom], [monthlyFee], [numberOfSlot]) VALUES (N'B102      ', N'B         ', N'800000    ', 6)
INSERT [dbo].[Room] ([roomID], [dom], [monthlyFee], [numberOfSlot]) VALUES (N'C103      ', N'C         ', N'700000    ', 8)
/****** Object:  Table [dbo].[Student]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[studentID] [nchar](10) NOT NULL,
	[name] [nchar](200) NOT NULL,
	[email] [nchar](200) NULL,
	[phone] [nchar](20) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Student] ([studentID], [name], [email], [phone]) VALUES (N'se06118   ', N'Nguyễn Sơn Lâm                                                                                                                                                                                          ', N'lamnsse06118@fpt.edu.vn                                                                                                                                                                                 ', N'01634301455         ')
INSERT [dbo].[Student] ([studentID], [name], [email], [phone]) VALUES (N'se06119   ', N'Nguyễn Văn Linh                                                                                                                                                                                         ', N'linhnvse06119@fpt.edu.vn                                                                                                                                                                                ', N'01634301456         ')
/****** Object:  Table [dbo].[WorkStatus]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkStatus](
	[statusID] [int] NOT NULL,
	[status] [nchar](100) NOT NULL,
 CONSTRAINT [PK_WorkStatus] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[WorkStatus] ([statusID], [status]) VALUES (1, N'not process                                                                                         ')
INSERT [dbo].[WorkStatus] ([statusID], [status]) VALUES (2, N'processing                                                                                          ')
INSERT [dbo].[WorkStatus] ([statusID], [status]) VALUES (3, N'done                                                                                                ')
INSERT [dbo].[WorkStatus] ([statusID], [status]) VALUES (4, N'reject                                                                                              ')
/****** Object:  Table [dbo].[StudentStatus]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentStatus](
	[studentID] [nchar](10) NOT NULL,
	[month] [nchar](10) NOT NULL,
	[year] [nchar](10) NOT NULL,
	[electricCost] [nchar](10) NULL,
	[waterCost] [nchar](10) NULL,
	[extraFee] [nchar](10) NULL,
	[extraFeeContent] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[StudentStatus] ([studentID], [month], [year], [electricCost], [waterCost], [extraFee], [extraFeeContent]) VALUES (N'se06119   ', N'10        ', N'2018      ', N'100000    ', N'50000     ', N'no        ', N'no')
INSERT [dbo].[StudentStatus] ([studentID], [month], [year], [electricCost], [waterCost], [extraFee], [extraFeeContent]) VALUES (N'se06119   ', N'9         ', N'2018      ', N'100000    ', N'40000     ', N'40000     ', N'thay bóng dèn')
/****** Object:  Table [dbo].[StudentAccount]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAccount](
	[username] [nchar](200) NOT NULL,
	[password] [nchar](200) NOT NULL,
	[owner] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[StudentAccount] ([username], [password], [owner]) VALUES (N'nguyenlam                                                                                                                                                                                               ', N'lam123                                                                                                                                                                                                  ', N'se06118   ')
/****** Object:  Table [dbo].[Slot]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[slotNumber] [int] NOT NULL,
	[roomID] [nchar](10) NOT NULL,
	[studentID] [nchar](10) NULL,
	[isAvailable] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Slot] ([slotNumber], [roomID], [studentID], [isAvailable]) VALUES (1, N'A101      ', N'se06118   ', 0)
INSERT [dbo].[Slot] ([slotNumber], [roomID], [studentID], [isAvailable]) VALUES (2, N'B102      ', NULL, 1)
/****** Object:  Table [dbo].[ProblemComplain]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemComplain](
	[studentID] [nchar](10) NOT NULL,
	[fromSlot] [int] NOT NULL,
	[atRoom] [nchar](10) NOT NULL,
	[reason] [nchar](4000) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ProblemComplain] ([studentID], [fromSlot], [atRoom], [reason], [status]) VALUES (N'se06118   ', 1, N'A101      ', N'bình nóng lạnh bị hỏng                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          ', 1)
INSERT [dbo].[ProblemComplain] ([studentID], [fromSlot], [atRoom], [reason], [status]) VALUES (N'se06118   ', 1, N'A101      ', N'quạt trần bị hỏng                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ', 2)
/****** Object:  Table [dbo].[ManagerAccount]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerAccount](
	[username] [nchar](100) NOT NULL,
	[password] [nchar](200) NOT NULL,
	[owner] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ManagerAccount] ([username], [password], [owner]) VALUES (N'nguyenan22                                                                                          ', N'binh123                                                                                                                                                                                                 ', N'mng06344  ')
/****** Object:  Table [dbo].[LeaveRoomRequest]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaveRoomRequest](
	[studentID] [nchar](10) NOT NULL,
	[fromSlot] [int] NOT NULL,
	[atRoom] [nchar](10) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[LeaveRoomRequest] ([studentID], [fromSlot], [atRoom], [status]) VALUES (N'se06118   ', 1, N'A101      ', 1)
/****** Object:  Table [dbo].[ChangeRoomRequest]    Script Date: 10/30/2018 11:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChangeRoomRequest](
	[studentID] [nchar](10) NOT NULL,
	[fromSlot] [int] NOT NULL,
	[atRoom] [nchar](10) NOT NULL,
	[toSlot] [nchar](10) NOT NULL,
	[toRoom] [nchar](10) NOT NULL,
	[reason] [nchar](3000) NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ChangeRoomRequest] ([studentID], [fromSlot], [atRoom], [toSlot], [toRoom], [reason], [status]) VALUES (N'se06118   ', 1, N'A101      ', N'2         ', N'B102      ', N'private reason                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          ', 1)
INSERT [dbo].[ChangeRoomRequest] ([studentID], [fromSlot], [atRoom], [toSlot], [toRoom], [reason], [status]) VALUES (N'se06119   ', 2, N'B102      ', N'4         ', N'A101      ', NULL, 2)
/****** Object:  ForeignKey [FK_ChangeRoomRequest_Student]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[ChangeRoomRequest]  WITH CHECK ADD  CONSTRAINT [FK_ChangeRoomRequest_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[ChangeRoomRequest] CHECK CONSTRAINT [FK_ChangeRoomRequest_Student]
GO
/****** Object:  ForeignKey [FK_LeaveRoomRequest_WorkStatus]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[LeaveRoomRequest]  WITH CHECK ADD  CONSTRAINT [FK_LeaveRoomRequest_WorkStatus] FOREIGN KEY([status])
REFERENCES [dbo].[WorkStatus] ([statusID])
GO
ALTER TABLE [dbo].[LeaveRoomRequest] CHECK CONSTRAINT [FK_LeaveRoomRequest_WorkStatus]
GO
/****** Object:  ForeignKey [FK_ManagerAccount_Manager]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[ManagerAccount]  WITH CHECK ADD  CONSTRAINT [FK_ManagerAccount_Manager] FOREIGN KEY([owner])
REFERENCES [dbo].[Manager] ([managerID])
GO
ALTER TABLE [dbo].[ManagerAccount] CHECK CONSTRAINT [FK_ManagerAccount_Manager]
GO
/****** Object:  ForeignKey [FK_ProblemComplain_WorkStatus]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[ProblemComplain]  WITH CHECK ADD  CONSTRAINT [FK_ProblemComplain_WorkStatus] FOREIGN KEY([status])
REFERENCES [dbo].[WorkStatus] ([statusID])
GO
ALTER TABLE [dbo].[ProblemComplain] CHECK CONSTRAINT [FK_ProblemComplain_WorkStatus]
GO
/****** Object:  ForeignKey [FK_Slot_Room]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[Slot]  WITH CHECK ADD  CONSTRAINT [FK_Slot_Room] FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[Slot] CHECK CONSTRAINT [FK_Slot_Room]
GO
/****** Object:  ForeignKey [FK_Slot_Student]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[Slot]  WITH CHECK ADD  CONSTRAINT [FK_Slot_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[Slot] CHECK CONSTRAINT [FK_Slot_Student]
GO
/****** Object:  ForeignKey [FK_Account_Student]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[StudentAccount]  WITH CHECK ADD  CONSTRAINT [FK_Account_Student] FOREIGN KEY([owner])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[StudentAccount] CHECK CONSTRAINT [FK_Account_Student]
GO
/****** Object:  ForeignKey [FK_StudentStatus_Student]    Script Date: 10/30/2018 11:08:43 ******/
ALTER TABLE [dbo].[StudentStatus]  WITH CHECK ADD  CONSTRAINT [FK_StudentStatus_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[StudentStatus] CHECK CONSTRAINT [FK_StudentStatus_Student]
GO
