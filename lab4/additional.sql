/*question a*/
select cname 
from customer_420_ natural join orders_420_ 
where Odate='09-MAR-2015';
/*question b*/
/*there is no relation and so it cant be done*/
/*question c*/
/*question d*/
select max(Odate) as maximum  from orders_420_ ; 