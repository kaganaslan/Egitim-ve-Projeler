-- STORED PROCEDURE SORGU �RNEKLER�

--1 PARAMETRE G�REREK DATA EKLEME PROSED�R�

-- �NCEL�KLE SORGUMUZU MANUEL �EK�LDE YAZIP PROSED�R ��ER�S�NDE ENTEGRE ETMEK DAHA KOLAY OLACAKTIR

INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
VALUES ('Barbaros �oraplar�', 2, 4, 45)

-- Bu noktadan sonra bizim bu i�i kullan�c�n�n girdi�i parametrelerle yapabilmemiz gerekiyor. O y�zden de�erleri yani VALUES'i manuel de�il dinamik �ekilde kullan�c�dan almal�y�z. Bu sebeple parametreleri kullan�c�dan alack bir de�i�kenler olu�turmam�z gerekiyor.

ALTER PROC dbo.addProduct
@UrunIsmi varchar(40),
@TedarikciNo int,
@KategoriNo int,
@BirimFiyat int
AS
BEGIN
INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
VALUES (@UrunIsmi, @TedarikciNo, @KategoriNo, @BirimFiyat)
PRINT 'HOJGELD�N BEA. �r�n Kayd� Ba�ar�l� �ekilde Ger�ekle�tirildi.'
SELECT * FROM Products
END

EXEC dbo.addProduct 'Seda Sever PC Oyunlar�',1, 3, 650

SELECT * FROM Products

-- 2 �R�N G�NCELLEME PROSED�R�

--- Y�NE �NCEL�KLE SORGUMUZU YAZALIM

UPDATE Products
SET ProductName = 'Barbaros Parf�mleri'
WHERE ProductID = 80

-- ��MD� DE BUNU PROSED�R MANTI�INA UYGUN OLARAK D�NAM�K HALE GET�REL�M

ALTER PROC dbo.UpdateProducts
@UrunID int,
@UrunAdi nvarchar(40)
AS
BEGIN
UPDATE Products
SET ProductName = @UrunAdi
WHERE ProductID = @UrunID
PRINT '�R�N G�NCELLEME ��LEM� BA�ARIYLA GER�EKLE�T�R�LD� ' + @UrunAdi +' �r�nler aras�nda yerini ald�'
SELECT * FROM Products
END

EXEC dbo.UpdateProducts 80, 'Barbaros �oraplar�'


--3 �R�N S�LME PROSED�R�
-- �ncelikle silme komutunu manuel olarak yazal�m
DELETE 
FROM Products
WHERE ProductID = 81

-- Sonra bunu prosed�rel hale getirelim.

ALTER PROC dbo.DeleteProduct
@UrunId int
AS
BEGIN
DELETE 
FROM Products
WHERE ProductID = @UrunId
PRINT '�R�N S�LME BA�ARILI ' + CONVERT (VARCHAR(50),@UrunId) + ' numaral� �r�n silinmi�tir.' 
SELECT * FROM Products
END

EXEC DeleteProduct 81


-- KO�ULA BA�LI OLARAK GELEN SONUCU DE���T�RME. �R�NLER� KULLANICININ G�RD��� PARAMETREYE G�RE UCUZDAN PAHALIYA YA DA PAHALIDAN UCUZA SIRALAMA

-- �NCE SORGUMUZU MANUEL YAZALIM

SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice ASC

SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC

-- ��MD� BUNU PROSED�RE UYGUN HALE GET�REL�M

CREATE PROC dbo.OrderProducts
@Veri varchar(50)
AS
BEGIN

IF @Veri = 'UCUZ'
BEGIN
SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice ASC
END

ELSE IF @Veri = 'PAHALI'
BEGIN
SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC
END

ELSE
BEGIN
PRINT 'G�RMEN�Z GEREKEN DE�ERLER YA  UCUZ YA DA PAHALI OLMALIDIR'
END

END

EXEC OrderProducts 'pahal�'

-- �RNE��N B�R E-T�CARET S�TES�NDE EN �OK SATAN 15 �R�N� L�STELEYEN B�R BACK END SERV�S� YAZILACA�I ZAMAN A�A�IDAK� G�B� B�R KOD BLO�U YETERL� OLACAKTIR.
SELECT TOP 15 ProductID, COUNT(ProductID) as SatisAdedi
FROM [Order Details]
GROUP BY ProductID
ORDER BY SatisAdedi  DESC


ALTER PROC dbo.UrunGetir
@KategoriNo int,
@StokAdet smallint
AS
BEGIN
SELECT *
FROM Products
WHERE UnitsInStock <= @StokAdet AND CategoryID = @KategoriNo
END

EXEC UrunGetir 4,50

MONTH(OrderDate) = 1

--Kullan�c�n�n girdi�i aya g�re sat�lan �r�nleri listeleme kodunun prosed�rel haliyle yaz�lmas�

SELECT MONTH(O.OrderDate) AS SATILDIGI_AY, P.ProductName 
FROM Orders AS O 
INNER JOIN [Order Details] AS OD
ON O.OrderID = OD.OrderID
INNER JOIN Products AS P ON OD.ProductID = P.ProductID
WHERE MONTH(O.OrderDate) = 3

ALTER PROC dbo.AylaraGoreSatilanUrunler
@Ay int
AS
BEGIN
SELECT (O.OrderDate) AS SATILDIGI_AY, P.ProductName 
FROM Orders AS O 
INNER JOIN [Order Details] AS OD
ON O.OrderID = OD.OrderID
INNER JOIN Products AS P ON OD.ProductID = P.ProductID
WHERE MONTH(O.OrderDate) = @Ay
END

EXEC AylaraGoreSatilanUrunler 3