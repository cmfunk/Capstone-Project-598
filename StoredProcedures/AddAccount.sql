use [cmfunk15]
go
/***********Adding Account*************/
set ANSI_NULLS on
go
set QUOTED_IDENTIFIER on
go
create procedure [dbo].[AddAccount]
	@UserName nvarchar(32),
	@Pass1Textphrase nvarchar(64),
	@Balance float,
	@Pass2Colorcode nvarchar(16),
	@Pass3Image varbinary(MAX),
	@AccountID int,
	@Name nvarchar(80),
	@Address nvarchar(100),
	@DOB datetimeoffset,
	@CardNumber int,
	@Pin int
as
begin
	--set NOCOUNT on,
	insert dbo.Account (UserName, Pass1TextPhrase, Balance, Pass2Colorcode, Pass3Image)
	values (@UserName, @Pass1Textphrase, @Balance, @Pass2Colorcode, @Pass3Image);
	insert dbo.Customer (AccountID, Name, Address, DOB, CardNumber, Pin)
	values (1, @Name, @Address, @DOB, @CardNumber, @Pin);
end





--insert dbo.Account(Username, Pass1Textphrase, Balance, Pass2Colorcode)
