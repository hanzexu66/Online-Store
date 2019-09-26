drop table DBAccount;
drop table DBimage;
drop table DBItem;
drop table DBitemaccusation;
drop table dbitemcollection;
drop table dbitemevaluation;
drop table dbitemimage;
drop table dborder;
drop table dborderitem;
drop table dbpayinfo;
drop table dbshop;
drop table dbshopaccusation;
drop table dbshopfollow;
drop table dbshoppingcart;
drop table dbshoptag;
drop table dbuser;
drop table dbuserinfo;


delete from dbaccount;
delete from dbImage;
delete from dbitem;
delete from dbitemaccusation;
delete from dbitemcollection;
delete from dbitemevaluation;
delete from dbitemimage;
delete from dborder;
delete from dborderitem;
delete from dbpayinfo;
delete from dbshop;
delete from dbshopaccusation;
delete from dbshopfollow;
delete from dbshoppingcart;
delete from dbshoptag;
delete from dbuser;
delete from dbuserinfo;


Create table DBimage
(
imageID varchar2(30),
img blob,
primary key(imageID)
);

create table DBUser(
  userID varchar2(30) primary key,
  userName varchar2(20),
  userNickName varchar(20),
  userGender char(1),
  userLevel int,
  userMoney numeric(10,2),
  userIconID varchar2(30),
  foreign key (userIconID) references dbImage(imageID)
  );


create table DBuserInfo
(
receiveID varchar2(30) primary key,
userID varchar2(30) ,
receiptName varchar2(20),
province varchar2(10),
city varchar2(10),
district varchar2(10),
street varchar2(10),
detailAdress varchar2(200),
receiptPhone char(11),
visibility numeric(1,0),
foreign key (userID) references dbuser(userID) on delete cascade
);


create table DBAccount(
  userID varchar2(30) primary key ,
  password varchar2(20),
  registerTime timestamp,
  lastLogin timestamp,
  lastLoginIP varchar(15),
  foreign key(userID) references dbuser(userID) on delete cascade
  );


create table DBshop
(shopID varchar2(30)primary key,
userID varchar2(30),
shopName varchar2(20),
shopIcon varchar2(30),
shopIntroduction varchar2(200),
applicationTime timestamp,
approvalTime timestamp,
favorableRate numeric(5,2),
salesValue numeric(10,2),
salesVolume int,
followVolume int,
foreign key(userID) references DBuser(userID) on delete cascade,
foreign key(shopIcon) references DBimage(imageID)
);

create table DBitem (
itemID varchar2(30) not null primary key,
shopID varchar2(30),
itemName varchar2(20char),
itemScore numeric(2,1), 
itemPrice numeric(10,2),
itemFollow int,
itemType varchar2(16),
itemIntroduction varchar2(100char),
foreign key (shopID) references DBshop(shopID) on delete cascade
);



create table DBitemImage (
imageID varchar2(30),
itemID varchar2(30),
primary key(imageID),
foreign key (itemID) references DBitem(itemID) on delete cascade,
foreign key (imageID) references DBimage(imageID) on delete cascade
);


create table DBorder (
orderID varchar2(30) not null primary key,
userID varchar2(30),
orderState int,
ReceiveID varchar2(30),
createTime timestamp,
visibility number(1),
foreign key (userID) references DBuser(userID) on delete cascade,
foreign key(receiveID) references DBuserInfo(receiveID)
);


create table DBpayInfo(
orderID varchar2(30) not null primary key,
payTime timestamp not null,
paymoney numeric(10,2) not null,
foreign key (orderID) references DBorder(orderID)
);


create table DBshopTag(
shopID varchar2(30) not null,
shopTag varchar2(20char) not null,
primary key(shopID, shopTag),
foreign key (shopID) references DBshop(shopID) on delete cascade
);



create table DBitemEvaluation(
userID varchar2(30) not null,
itemID varchar2(30) not null,
evaluationContent varchar2(200 char) not null,
evaluationTime timestamp not null,
Primary key (userID, itemID,evaluationTime),
foreign key (itemID) references DBitem(itemID) on delete cascade,
foreign key (userID) references DBuser(userID) on delete cascade
);

Create table DBshoppingCart
(userID varchar2(30) not null,
itemID varchar2(30) not null,
Primary key (userID, itemID),
foreign key (itemID) references DBitem(itemID) on delete cascade,
foreign key (userID) references DBuser(userID) on delete cascade
);

Create table DBitemCollection
(userID varchar2(30) not null,
itemID varchar2(30) not null,
Primary key(userID, itemID),
foreign key (itemID) references DBitem(itemID) on delete cascade,
foreign key (userID) references DBuser(userID) on delete cascade
);

Create table DBitemAccusation
(userID varchar2(30) not null,-- references DBuser(userID),
itemID varchar2(30) not null,-- references DBitem(itemID),
AccusationTime timestamp not null,
accusationReason varchar2(200 char) not null,
accusationState int not null,
Primary key(userID, itemID,accusationTime),
foreign key (itemID) references DBitem(itemID) on delete cascade,
foreign key (userID) references DBuser(userID) on delete cascade
);

Create table DBorderitem
(orderID varchar2(30) not null,-- references DBorder(orderID),
itemID varchar2(30) not null,-- references DBitem(itemID),
itemAmount numeric(10,2) not null,
Primary key(orderID, itemID),
foreign key (itemID) references DBitem(itemID) on delete cascade,
foreign key (orderID) references DBorder(orderID) on delete cascade
);

Create table DBshopAccusation
(userID varchar2(30) not null,-- references DBuser(userID),
shopID varchar2(30) not null,-- references DBshop(shopID),
accusationReason varchar2(200 char),
accusationTime timestamp not null,
accusationState int not null,
Primary key(userID, shopID,accusationTime),
foreign key (userID) references DBuser(userID) on delete cascade,
foreign key (shopID) references DBshop(shopID) on delete cascade
);


Create table DBshopFollow
(userID varchar2(30) not null,-- references DBuser(userID),
shopID varchar2(30) not null,-- references DBshop(shopID),
Primary key(userID, shopID),
foreign key (userID) references DBuser(userID) on delete cascade,
foreign key (shopID) references DBshop(shopID) on delete cascade
);
