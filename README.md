# CRUD_Console_App
CRUD_Console_App

COMMAND CREATING A DATABASE

CREATE DATABASE ConsoleCRUD
create table Details(
		User_Id INT primary key identity(1,1) not null,
		name varchar(50) not null,
		email varchar(50) not null,
		age int not null,

)

select * from Details

delete from Details where User_Id = 2;
