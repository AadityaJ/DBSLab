CREATE OR REPLACE FUNCTION accidents (yr in number)
	RETURN number
AS
	tot_acc number;
BEGIN
	select count(distinct report_number) into tot_acc
	from accident_420_
	where extract(year from accident_date)=yr;
	RETURN (tot_acc);
END;
/