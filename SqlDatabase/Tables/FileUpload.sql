﻿
CREATE TABLE [dbo].[FileUpload](
	[FileId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](255) NOT NULL,
	[FileUploadedUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[FileUpload]  WITH CHECK ADD FOREIGN KEY([FileUploadedUserId])
REFERENCES [dbo].[UserDetails] ([UserId])
GO