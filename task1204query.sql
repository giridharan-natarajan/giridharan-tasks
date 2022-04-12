

create proc sp_insTask
@sno int, @StuName Varchar(20)
as
insert [dbo].[newTaskTest] values (@sno,@StuName)

select * from [dbo].[newTaskTest]
create proc upd_task
@sno int ,@stuName varchar(20)
as
update [dbo].[newTaskTest] set StuName = @stuName where sno=@sno

create proc del_task
@sno int
as
delete [dbo].[newTaskTest] where sno=@sno