/*Department*/
Create Proc GetDepartment
as
begin
     select * from Department
end
go

EXEC GetDepartment
/*Employee*/
Create Proc GetEmployee
as
begin
     select * from Employee
end
go

EXEC GetEmployee

create proc spInsert
@idemploy nvarchar(255),
@name nvarchar(255),
@datebirth datetime,
@gender int,
@placebirth nvarchar(255),
@iddepart nvarchar(255)
as
begin
    insert Employee(idemploy,name,datebirth,gender,placebirth,iddepart) values(@idemploy,@name,@datebirth,@gender,@placebirth,@iddepart)
end
go


create proc spUpdate
@idemploy nvarchar(255),
@name nvarchar(255),
@datebirth datetime,
@gender int,
@placebirth nvarchar(255),
@iddepart nvarchar(255)
as
begin
    update Employee
    set
       name= @name,
	   datebirth=@datebirth,
	   gender = @gender,
	   placebirth=@placebirth,
	   iddepart = @iddepart
    where idemploy = @idemploy
end
go



create proc spDelete
@idemploy nvarchar(255)
as
begin
    delete Employee where idemploy = @idemploy
end
go

