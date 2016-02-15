create table person_420_(driver_id varchar(10) not null,name varchar(10),address varchar(20),primary key(driver_id));

create table car_420_(regNo varchar(12) not null,model varchar(10),year int,primary key(regNo));

create table accident_420_(report_number int not null,accident_date date,location varchar(20),primary key(report_number));

create table owns_420_(driver_id varchar(10),foreign key (driver_id) references person_420_(driver_id),regNo varchar(12),foreign key (regNo) references car_420_(regNo));

create table participated_420_(driver_id varchar(10),foreign key (driver_id) references person_420_(driver_id),regNo varchar(12),foreign key (regNo) references car_420_(regNo),report_number int not null,foreign key(report_number) references accident_420_(report_number),damage_amount int);
																																	
/*TABLES CREATED*/																										
**********************************************************************************************************
insert into person_420_ values('123456','aaditya','manipalmit');
insert into person_420_ values('122345','jamuar','manipalkmc');
insert into person_420_ values('090812','hello','manipalmit');
insert into person_420_ values('987381','malcom','newdelhi');
insert into person_420_ values('457290','gladwell','karachi');
/*PERSON CREATED*/
insert into car_420_ values('dl-9898','abchcbx',1996);
insert into car_420_ values('ka-9128','volkswagen',1999);
insert into car_420_ values('jh-1328','lambo',1996);
insert into car_420_ values('mh-9988','jetta',1996);
insert into car_420_ values('ga-6568','santro',1996);
/*CAR CREATED*/
insert into accident_420_ values(5363,'08-FEB-2014','France');
insert into accident_420_ values(1234,'18-FEB-2014','Luvre');
insert into accident_420_ values(5361,'12-APR-2013','Luxemberg');
insert into accident_420_ values(5360,'12-JAN-2014','Greece');
insert into accident_420_ values(5367,'21-MAR-2014','Spain');
/*ACCIDENT CREATED*/
insert into owns_420_ values('123456','dl-9898');
insert into owns_420_ values('122345','ka-9128');
insert into owns_420_ values('090812','jh-1328');
insert into owns_420_ values('987381','mh-9988');
insert into owns_420_ values('457290','ga-6568');
/*OWNS CREATED*/
insert into participated_420_ values('123456','dl-9898',5363,10000);
insert into participated_420_ values('122345','ka-9128',1234,12000);
insert into participated_420_ values('090812','jh-1328',5361,13000);
insert into participated_420_ values('987381','mh-9988',5360,9000);
insert into participated_420_ values('457290','ga-6568',5367,17000);
/*PARTICIPATED CREATED*/
*********************************************************************************************************

update participated_420_ set damage_amount = 25000 where regno='dl-9898' and report_number=5363;

*********************************************************************************************************

delete from participated_420_ where report_number = 5361 ;
delete from accident_420_ where accident_date = '12-APR-13';

*********************************************************************************************************
alter table participated_420_ drop column DAMAGE_AMOUNT;
alter table participated_420_ add DAMAGE_AMOUNT int;
*********************************************************************************************************

alter table car_420_ add check(year>1980);

*********************************************************************************************************
update participated_420_ set damage_amount = 90000 where report_no=5363; 