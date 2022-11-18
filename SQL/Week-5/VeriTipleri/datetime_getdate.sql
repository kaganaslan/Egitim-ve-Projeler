CREATE TABLE ORDERS
(
OrderNo int identity(1,1) PRIMARY KEY not null,
OrderDate Datetime default getdate(),
Descriptio varchar(500),
OrderAddress varchar(500),
DeliverDate Datetime 
)