CREATE OR REPLACE TRIGGER driver_info 
AFTER 
INSERT 
ON PARTICIPATED_420_
FOR EACH ROW
BEGIN
  DBMS_OUTPUT.PUT_LINE(:NEW.driver_id);
END;
/