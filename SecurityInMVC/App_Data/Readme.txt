Authentication: It is the process of verifying the user identity, which means to validate the user against some data source.
Authorization: It is a security machanism used to determine whether the user has access to perticular resource or not.
- Once the authentication is done then only authorization takes place.

Types of Authentications:
- Forms Authentication:  In this type of authentication, the user needs to provide his credentials through the form.
- Windows Authentication: In this type of authentication, it uses the IIS web server and along with Operating system credentials to identify the authentication.
- Passport Authentication: It is a centralized authentication service (paid service) provided by Microsoft, which offers a single logon and core profile services for the websites.
- Federated Authentication: It is also a centralized authetication service (paid service) provided by third parties like google, facebook etc..

<authentication>
<autherization> in web.config file

Forms Authentication: TO implement forms authentication we should follow three steps
	- Set the authentication mode in web.config file
	- Use the cookies for login data
	- Implement signout

Steps to implement security:
- Prepare the <authentication> tag in web.config file
- Create the Account controller with Login implmentaiton.
- Create the required controllers and Action Methods 
- Apply the autherization, In ASP.Net MVC we have 3 ways to implement
	- Application Level
	- Controller Level
	- Action Method Level	
Note: 
- [Autherize] attribute is used to implement the security
- [AllowAnonymous] attribute can be used to implement autherization for non login users(Anonymous Users)








------------------------------------------------------
create database SecurityDB
go

use SecurityDB
go

create table Employee
(
	ID int primary key IDENTITY(1,1),
	Name varchar(50),
	Designation varchar(50),
	Salary int
)

create table Users
(
	ID int primary key IDENTITY(1,1),
	Username varchar(50),
	Password varchar(50)
)

create table RoleMaster
(
	ID int primary key,
	RoleName varchar(30)
)

create table UserRoleMapping
(
	ID int primary key,
	UserID int not null,
	RoleID int Not null
)

alter table UserRoleMapping
add foreign key(UserID) references Users(ID)

alter table UserRoleMapping
add foreign key(RoleID) references RoleMaster(ID)