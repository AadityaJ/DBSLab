CREATE TABLE CUSTOMER_420_(
Cust int PRIMARY KEY NOT NULL,
Cname varchar(10) NOT NULL,
City varchar(20)
);

CREATE TABLE ORDERS_420_(
Order_ID int PRIMARY KEY NOT NULL,
Odate date,
Cust int,
FOREIGN KEY(Cust) references CUSTOMER_420_(Cust),
Ordamt int
);

CREATE TABLE ITEM_420_(
Item int,
Unitprice int
);

CREATE TABLE SHIPMENT_420_(
Order_ID int,
FOREIGN KEY(Order_ID) references ORDERS_420_(Order_ID),
Warehouse_ID int PRIMARY KEY NOT NULL,
Shipdate date
);
/******************************************************************************************/
INSERT INTO CUSTOMER_420_(Cust,Cname,City) VALUES (001,'Aakarsh','Jaipur');
INSERT INTO CUSTOMER_420_(Cust,Cname,City) VALUES (002,'Auro','Rajasthan');
INSERT INTO CUSTOMER_420_(Cust,Cname,City) VALUES (003,'Aabas','Delhi');
INSERT INTO CUSTOMER_420_(Cust,Cname,City) VALUES (004,'Kia','Jaipur');
INSERT INTO CUSTOMER_420_(Cust,Cname,City) VALUES (005,'Mirri','Tindoor');

INSERT INTO ORDERS_420_(Order_ID,Odate,Cust,Ordamt) VALUES (23,'04-FEB-2016',001,4);
INSERT INTO ORDERS_420_(Order_ID,Odate,Cust,Ordamt) VALUES (24,'05-FEB-2016',002,3);
INSERT INTO ORDERS_420_(Order_ID,Odate,Cust,Ordamt) VALUES (25,'07-FEB-2016',003,9);
INSERT INTO ORDERS_420_(Order_ID,Odate,Cust,Ordamt) VALUES (26,'12-FEB-2016',004,8);
INSERT INTO ORDERS_420_(Order_ID,Odate,Cust,Ordamt) VALUES (27,'28-FEB-2016',005,4);

INSERT INTO ITEM_420_(Item,Unitprice) VALUES (50,200);
INSERT INTO ITEM_420_(Item,Unitprice) VALUES (60,250);
INSERT INTO ITEM_420_(Item,Unitprice) VALUES (70,240);
INSERT INTO ITEM_420_(Item,Unitprice) VALUES (80,355);
INSERT INTO ITEM_420_(Item,Unitprice) VALUES (90,400);

INSERT INTO SHIPMENT_420_(Order_ID,Warehouse_ID,Shipdate) VALUES (23,123,'05-FEB-2016');
INSERT INTO SHIPMENT_420_(Order_ID,Warehouse_ID,Shipdate) VALUES (24,124,'06-FEB-2016');
INSERT INTO SHIPMENT_420_(Order_ID,Warehouse_ID,Shipdate) VALUES (25,125,'08-FEB-2016');
INSERT INTO SHIPMENT_420_(Order_ID,Warehouse_ID,Shipdate) VALUES (26,126,'13-FEB-2016');
INSERT INTO SHIPMENT_420_(Order_ID,Warehouse_ID,Shipdate) VALUES (27,127,'29-FEB-2016');


