DECLARE 
   no int;
   totprice int;
   disc int;
BEGIN
   select count(order_id) into no from orders_420_;
   IF no<10 THEN
      dbms_output.put_line('no customers. :)');
   ELSIF no>10 THEN
      select sum(ordamt) into totprice from orders_420_;
      disc := (20/100)*totprice;
      dbms_output.put_line('Discount' || disc);
   END IF; 
END;
/