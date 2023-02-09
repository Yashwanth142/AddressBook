use Addressbook
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DisplayAllDetails
	
AS
BEGIN
	SET NOCOUNT ON;
	select FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email,date_added from Family WHERE date_added >='20121014 14:00:00'
  AND date_added <='20121015 14:00:00'
END
GO
