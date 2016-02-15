/*question 1*/
select count(*) from accident_420_ where accident_date>='01-JAN-2008' and accident_date<='31-DEC-2008' ;
/*question 2*/
select count(*) from participated_420_ natural join car_420 where MODEL='santro';
/*question 3*/
select name as OWNER_NAME,count(report_number) as Number_of_Accidents,sum(damage_amount) 
from person_420_ natural join participated_420_ 
group by (name,damage_amount) order by (damage_amount) desc;
/*quesion 5*/
select name ,count(report_number) 
from person_420_ natural join participated_420_ 
group by (name) having count(report_number)>2;
/*question 6*/
select name ,count(report_number) 
from person_420_ natural join participated_420_ group by (name) having count(report_number)=0 ;
