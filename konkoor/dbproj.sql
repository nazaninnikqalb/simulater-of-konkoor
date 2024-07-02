use dbproject 
go

--ایجاد جدول کاربران برای ثبت نام و ورود به پنل

create table users ( id int identity(1,1) primary key ,
                     usernames varchar(60) not null unique ,
					 passwords  varchar(20) not null,
					 email  varchar(100)    not null)



--ایجاد جدول کد محل صدور شناسنامه

create table shenasname(codeshenasname nvarchar(10)  primary key, city nvarchar(50))
insert into shenasname(codeshenasname , city) values(111 , N'tehran'),
                                                    (222 , N'esfahan'),
													(333 , N'guilan'),
													(444 , N'mazandaran'),
													(555 , N'shiraz');

--ایجاد جدول کد رشته تحصیلی کارشناسی
create table reshtekarshenasi(codekarshenasi nvarchar(10) primary key, reshte nvarchar(50))
insert into reshtekarshenasi(codekarshenasi , reshte) values (1 , N'computer'),
                                                             (2 , N'bargh'),
															 (3 , N'mekanik'),
															 (4 , N'omran'),
															 (5 , N'sanaye');

--ایجاد جدول کد رشته امتحانی
create table reshteemtehani(codeemtehani nvarchar(10) primary key, reshte nvarchar(50))
insert into reshteemtehani(codeemtehani , reshte) values (1000 , N'computer'),
                                                         (2000 , N'bargh'),
													     (3000 , N'mekanik'),
														 (4000 , N'omran'),
														 (5000 , N'sanaye');



 --ایجاد جدول کنکور برای ریختن اطلاعات مربوط به کنکور در ان
 
 create table konkoor(id int identity(1,1) primary key,
                      nam nvarchar(30)  check (nam not like '%[^a-zA-Z]%') not null,
					  namkhanevadegi nvarchar(50) check(namkhanevadegi not like '%[^a-zA-Z]%') not null,
					  nampedar nvarchar(30) check(nampedar not like '%[^a-zA-Z]%') not null,
					  codemeli nvarchar(20) check (codemeli not like '%[^0-9]%') not null ,
					  shomareshenasname nvarchar(20) check (shomareshenasname not like '%[^0-9]%') not null,
					  codeshenasname nvarchar(10) check (codeshenasname not like '%[^0-9]%') not null,
					  jensiat nvarchar(10) ,
					  tarikhtavalod date not null,
					  codekarshenasi nvarchar(10) check (codekarshenasi not like '%[^0-9]%') not null,
					  codeemtehani nvarchar(10) check (codeemtehani not like '%[^0-9]%') not null,
					  codeposti nvarchar(20) check (codeposti not like '%[^0-9]%') ,
					  tellhamrah nvarchar(20) check (tellhamrah not like '%[^0-9]%') not null,
					  tellsabet nvarchar(20) check (tellsabet not like '%[^0-9]%') not null,
					  email nvarchar(100) ,
					  foreign key (codeshenasname) references shenasname(codeshenasname),
					  foreign key (codekarshenasi) references reshtekarshenasi(codekarshenasi),
					  foreign key (codeemtehani) references reshteemtehani(codeemtehani))
go
create trigger tr_shenasname on konkoor
after insert 
as 
begin
    
	if(select count(*) from inserted where codeshenasname not in (111,222,333,444,555)) > 0 
	begin
	    Raiserror( 'codeshenasname na motabar' , 16 , 1);
	end
end
go

create trigger tr_codekarshenasi on konkoor
after insert 
as 
begin
    
	if(select count(*) from inserted where codekarshenasi not in (1,2,3,4,5)) > 0 
	begin
	    Raiserror( 'codekarshenasi na motabar' , 16 , 1);
	end
end

go
create trigger tr_codeemtehani on konkoor
after insert 
as 
begin
    
	if(select count(*) from inserted where codeemtehani not in (1000,2000,3000,4000,5000)) > 0 
	begin
	    Raiserror( 'codeemtehani na motabar' , 16 , 1);
	end
end