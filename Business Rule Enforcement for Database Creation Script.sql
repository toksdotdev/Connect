create database Connect

---contains the Account Type for users e.g. buyer, seller e.t.c.---
create table Account_Type
(
	iA_Tid int IDENTITY(001,1) CONSTRAINT cAccount_TypePk PRIMARY KEY,
	vcType varchar(20) not null
)
---contains info for user of our services---
create table User_Details
(
	iU_Did int IDENTITY(0000000000000001,1) CONSTRAINT cAccount_DetailsPk PRIMARY KEY,
	vcFirstName varchar(30) not null,
	vcMiddleName varchar(30),
	vcLastName varchar(30) not null,
	vcEmail varchar(50) not null,
	vcPassword varchar(50) not null,
	cSex char(1),
	dDOB datetime,
	iProfilePictureId int,
	--iProfilePictureId int IDENTITY(0000000000000001,1),
	vcAddress varchar(100),
	--mMoneyBalance 
	iFK_AccountTypeId int constraint fkAccount_Type  Foreign key references Account_Type(iA_Tid) not null,
)

---contains the details about each bank in our log, so as to easily verify any bank details challenge---
create table Bank_Details
(
	iB_Did int IDENTITY(0000000000000001,1) CONSTRAINT cBank_DetailsPk PRIMARY KEY,
	vcBankName varchar(50) not null,
	vcBankHqLocation varchar(100),
	vcBankPhoneNo varchar(20), ---can include +(234)-, dont forget By The Special Grace Of The Most High God's Love---
	vcBankEmail varchar(50)
)

---user bank details for payment to those who choose to sell their login details---
create table User_Bank_Details
(
	iU_B_Did int IDENTITY(0000000000000001,1) CONSTRAINT cUser_Bank_DetailsPk PRIMARY KEY,
	iAccountNo varchar(10) not null,
	iFK_Bank_DetailsId int constraint fkBank_Details  Foreign key references Bank_Details(iB_Did) not null, --foreign key to bank id here---
)


create table Buyer_Details
(
	iB_Did int IDENTITY(0000000000000001,1) CONSTRAINT cBuyer_DetailsPk PRIMARY KEY,
	iFKUser_DetailsId int constraint fkBuyer_User_Details  Foreign key references User_Details(iU_Did) not null,
	dDataBought decimal not null,
	dDataUsed decimal not null,
	iHasExpired bit not null
)
---contains the up to date details of the a sellers internet login details---
create table Sellers_Login
(
	iS_Lid int IDENTITY(0000000000000001,1) CONSTRAINT cSellers_LoginPk PRIMARY KEY,
	iFK_User_DetailsId int constraint fkUser_Details  Foreign key references User_Details(iU_Did) not null,
	vcUsername varchar(50) not null, --this is the matric number of the user to login--
	vcLoginPassword varchar(50) not null,
	dtDateAddedOrUpdated datetime CONSTRAINT cSellers_LoginDateAddedOrUpdated DEFAULT getdate() not null,
	iHasExpired bit not null,
	dDataBalance decimal not null,
	dDataSizeAsAtTimeOfUpload decimal not null,
	dDataUsedByCustomers decimal not null,
	iIsLoginInUse bit not null, --so user cannot take llogins that is been used by another cutomer to browse the internet at such given time--
)

---the log of data used by every customer - service purchase---
create table Data_Usage_Log
(
	iD_U_Lid int IDENTITY(0000000000000001,1) CONSTRAINT cData_Usage_LogPk PRIMARY KEY,
	iFKBuyer_User_DetailsId int constraint fkBuyer_User_Log_Details  Foreign key references User_Details(iU_Did) not null, --foreign key to the person / userId who used the data to browse, that is buyer---
	dDataUsed decimal not null,
	dtDateUsed datetime CONSTRAINT cData_Usage_LogDate DEFAULT getdate() not null,
	iFKSellers_LoginId int constraint fkSellers_Login  Foreign key references Sellers_Login(iS_Lid) not null, --foreign key to the person / userId who used the data to browse, that is buyer---
)

---list of all the withrawals that have been made in times past---
create table Withrawal_Table
(
	iD_U_Lid int IDENTITY(0000000000000001,1) CONSTRAINT cWithdrawal_TablePk PRIMARY KEY,
	iFKUser_DetailsId int constraint fkUser_Details_for_withdrawal  Foreign key references User_Details(iU_Did) not null, --foreign key to the person / userId who used the data to browse, that is buyer---
	iUserId int not null, --insert foreign key here
	mAmountWithrawn money not null,
)