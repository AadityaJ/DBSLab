create table student_420(regno varchar(10) not null,name varchar(12),major varchar(10),bdate date,primary key(regno));
create table course_420(course int not null,cname varchar(10),dept varchar(5),primary key(course));
create table enroll_420(regno varchar(10),course int,sem int,book_isbn int,foreign key (regno) references student_420(regno),foreign key (course) references course_420(course),primary key(book_isbn));
create table book_adoption_420(course int,sem int,book_isbn int,foreign key (course) references course_420,foreign key (book_isbn) references enroll_420(book_isbn));
create table text_420(book_isbn int,booktitle varchar(10),publisher varchar(10),author varchar(10),foreign key (book_isbn) references enroll_420(book_isbn));	
/*tables created now input values in them */
insert into student_420 values('140911420','aaditya','12-APR-1996','it');	
insert into student_420 values('140911400','jamuar','12-APR-1998','history');	
insert into student_420 values('140911467','hello','15-APR-1996','eee');	
insert into student_420 values('140911867','hello56','15-APR-1986','eee');
insert into student_420 values('140511467','anaar','15-APR-2001','cse');

insert into course_420 values(12,'dbs','ict');	
insert into course_420 values(14,'algebra','maths');
insert into course_420 values(15,'se','cse');
insert into course_420 values(16,'cnw','ict');
insert into course_420 values(13,'gt','maths');	

insert into enroll_420 values('140911420',12,4,456);	
insert into enroll_420 values('140911420',14,2,123);
insert into enroll_420 values('140911467',15,5,234);
insert into enroll_420 values('140911400',16,4,887);
insert into enroll_420 values('140911867',13,3,459);

insert into book_adoption_420 values(12,4,456);	
insert into book_adoption_420 values(12,2,123);
insert into book_adoption_420 values(14,5,234);
insert into book_adoption_420 values(16,4,887);
insert into book_adoption_420 values(13,3,459);

insert into text_420 values(456,'database','tmh','abcd');	
insert into text_420 values(123,'algebra','pengiun','efgh');
insert into text_420 values(234,'softw','tmh','jamuarabcd');
insert into text_420 values(459,'graph','cl liu','cl lu');
insert into text_420 values(239,'software','pengiun','sdnn');
/*insetion done*/
/*question1*/
select * from (select count(*) as books,course from book_adoption_420 group by course) where books > 1;
/*question2*/
select dept from course_420
		     where dept in 
		     (select dept from course_420 natural join(book_adoption_420) natural join(text_420)
                      group by(dept)
		      having count(distinct publisher)=1); 
/*question 3*/
select regno,name from student_420
                where regno in
                (select regno from course_420 natural join(enroll_420)
                      group by(regno)
                 having count(distinct dept)>1); 		     
/*question 4*/
select regno, name from student_420
           where regno not in
           (select regno from enroll_420);
/*question 6*/
select book_isbn from student_420 natural join enroll_420
                   where book_isbn in (select book_isbn from course_420 natural join(book_adoption_420));
/*question 9*/
select * from
(select publisher, count(book_isbn) from text_420 group by publisher);
/*quiz*/
select * from participated_420_ natural join person_420_  natural join accident where damage_amount > 50000; 