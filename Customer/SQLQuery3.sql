use [CustomerAPI.Data];
SET IDENTITY_INSERT Customer ON

insert into Customer(UserID,UserName,Password,ContactNumber,UserType,Address) 
values
(1,'srinivas1','srinivas014','9502691700','User','Chennai'),
(2,'srinivas2','srinivas014','9502691700','User','Hyderabad'),
(3,'srinivas3','srinivas014','9502691700','Admin','Hyderabad'),
(4,'srinivas4','srinivas014','9502691700','User','Hyderabad');


select * from Customer