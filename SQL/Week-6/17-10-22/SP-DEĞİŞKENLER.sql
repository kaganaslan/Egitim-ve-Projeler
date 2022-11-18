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
 print('Tedarikçi ekleme iþlemi baþarýlý!')
END

EXEC dbo.InsertSupp 'Bayatlý A.Þ.', 'Kaðan Aslan', 'Çorum Republic', 'Türkiye'

SELECT * FROM Suppliers

