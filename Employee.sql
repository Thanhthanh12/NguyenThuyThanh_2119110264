CREATE DATABASE HR
CREATE TABLE Department
(
id nvarchar(10),
name nvarchar(255)
)
CREATE TABLE Employee
(
idemploy nvarchar(255),
name nvarchar(255),
datebirth nvarchar(255),
gender bit,
placebirth nvarchar(255),
iddepart nvarchar(10))

INSERT INTO Department VALUES ('IT', N'Cong nghe thong tin')
INSERT INTO Department VALUES ('KT', N'Ke toan')
INSERT INTO Department VALUES ('KSNB', N'Kiem soat noi bo')

INSERT INTO Employee VALUES (N'C53418', 'Tran Tien','11/10/2000', 1, 'Ha Noi','IT')
INSERT INTO Employee VALUES (N'X53416', 'Nguyen Cuong', '21/07/1999',	0,	'Dak Lak','KT')
INSERT INTO Employee VALUES (N'M53417', 'Nguyen Hao ', '25/12/2001',	1,	'TP Ho Chi Minh','KSNB')
delete from Employee
drop table Department
drop table Employee




