-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Alter TRIGGER triggerStudentDelete
   ON  tblStudent
   after delete, insert,update
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @Id int,@Action nvarchar(50),@ActionBy nvarchar(50),@Date datetime
	if exists(select * from inserted) and not exists(select * from deleted)
	Begin
	set @Action='Insert'
	set @Id=(select RecordId from inserted)
	set @ActionBy=SYSTEM_USER
	set @Date=GETDATE()
		insert into Logger (Table_Name,[Action],ActionBy,ActionDate,RecordId) values ('tblStudent',@Action,@ActionBy,@Date,@Id)
	End

	if exists(select * from deleted) and not exists (select * from inserted)
	Begin
	set @Action='Delete'
	set @Id=(select RecordId from deleted)
	set @ActionBy=SYSTEM_USER
	set @Date=GETDATE()
		insert into Logger (Table_Name,[Action],ActionBy,ActionDate,Recordid) values ('tblStudent',@Action,@ActionBy,@Date,@Id)
	End

	if exists(SELECT * from inserted) and exists (SELECT * from deleted)
	Begin
	set @Action='Updated'
	set @Id=(select RecordId from deleted)
	set @ActionBy=SYSTEM_USER
	set @Date=GETDATE()
		insert into Logger (Table_Name,[Action],ActionBy,ActionDate,Recordid) values ('tblStudent',@Action,@ActionBy,@Date,@Id)
	End
    -- Insert statements for trigger here
END
GO
