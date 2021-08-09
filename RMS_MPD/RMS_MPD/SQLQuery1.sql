CREATE PROCEDURE sp_insert @Fullname varchar(150), @SocialID varchar(150), 
@Email varchar(150), @PhoneNumber varchar(150), @Password varchar(150)

AS

INSERT INTO [dbo].[CustomersInfo]
           ([Fullname]
           ,[SocialID]
           ,[Email]
           ,[PhoneNumber]
           ,[Password])
     VALUES
           (@Fullname
           ,@SocialID
           ,@Email
           ,@PhoneNumber
           ,@Password)
GO