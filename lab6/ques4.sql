CREATE OR REPLACE PROCEDURE tot_damn (drvid in number,yr in number)
is res number;
BEGIN
	select sum(damage_amount) into res
	from accident_420_ natural join participated_420_
	where driver_id=drvid and extract(year from accident_date)=yr;
	dbms_output.put_line(res);
END;
/