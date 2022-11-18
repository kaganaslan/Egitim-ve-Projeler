CREATE PROC dbo.InsertSupp
(
@CompanyName nvarchar(40),
@ContactName nvarchar(30),
@Address nvarchar(60),
@City nvarchar(15)

)
AS
BEGIN
 INSERT INTO Suppliers (CompanyName, ContactName, Address, City)
 VALUES (@CompanyName, @ContactName, @Address, @City)
 print('Tedarik�i ekleme i�lemi ba�ar�l�!')
END

EXEC dbo.InsertSupp 'Bayatl� A.�.', 'Ka�an Aslan', '�orum Republic', 'T�rkiye'

SELECT * FROM Suppliers

