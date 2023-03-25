USE [library22222 ]
GO
CREATE TABLE reader
(
  Rname_ VARCHAR(250) NOT NULL,
  Remail  VARCHAR(250) NOT NULL,
  Rphone  INT NOT NULL,
  Rid int  not null,
  gender varchar(50) not null, 
  books_bought int  not null, 

  PRIMARY KEY (EMAIL, usermobile)
);

CREATE TABLE payment
(
  amount FLOAT NOT NULL,
  payment_type_ VARCHAR(250)NOT NULL,
  paymentid INT NOT NULL,
  PRIMARY KEY (paymentid)
);

CREATE TABLE Category_
(
  Cid int not null , 
  Cname VARCHAR(250) NOT NULL,
  Btitle VARCHAR(250) NOT NULL,
  Bname  VARCHAR(250) not null, 
  PRIMARY KEY (Bname , Btitle)
);

CREATE TABLE IDEA_THOUGHTS
(
   comment_id int null , 
  SUBJECT_ VARCHAR(250) NOT NULL,
  Rname VARCHAR(250) NOT NULL,
  usermobile INT NOT NULL,
  FOREIGN KEY (Rname, usermobile) REFERENCES reader(EMAIL, usermobile)
);

CREATE TABLE Admin_
(
   gender varchar(50) not null ,
  Aid int not null,
  Aname VARCHAR(250) NOT NULL,
  Aemail VARCHAR(250) NOT NULL,
  Aphone  INT NOT NULL,
  PRIMARY KEY (AEMAIL, Aphone )
);

CREATE TABLE usseraccount_
( accID INT NOT NULL ,
  gender_ VARCHAR(25) NOT NULL,
  firstname_ VARCHAR (250)NOT NULL,
  lastname_ VARCHAR (250)NOT NULL,
  EMAIL VARCHAR(250) NOT NULL,
  usermobile INT NOT NULL,
  FOREIGN KEY (EMAIL, usermobile) REFERENCES reader(EMAIL, usermobile)
);

CREATE TABLE report_
(
  rname VARCHAR(250) NOT NULL,
  rsubj VARCHAR(250) NOT NULL,
  repid INT NOT NULL,
  PRIMARY KEY (repid)
);

CREATE TABLE document
(
  title_ VARCHAR(250) NOT NULL,
  price FLOAT NOT NULL,
  Author_name VARCHAR(250) NOT NULL,
  Bid  INT NOT NULL,
  sold_copies int not null, 
  year int not null ,
  month int not null , 
  PRIMARY KEY (Bid)
);
create table AUTHOR  (

gender varchar(50) not null ,
AUname varchar(250)  not null, 
 AUID   int NOT NULL ,
 AUphone int not null ,
 FOREIGN KEY (AUID ) REFERENCES document(ID)
 
 );

 create table order_(
	orderID int ,
	Rid INT NOT NULL,
	ID INT NOT NULL,
	FOREIGN KEY (ID) REFERENCES document(ID),
	

);
create  table payment_(
pid int null, 
ptype varchar(50) not null ); 




