-- STORED PROCEDURE SORGU ÖRNEKLERÝ

--1 PARAMETRE GÝREREK DATA EKLEME PROSEDÜRÜ

-- ÖNCELÝKLE SORGUMUZU MANUEL ÞEKÝLDE YAZIP PROSEDÜR ÝÇERÝSÝNDE ENTEGRE ETMEK DAHA KOLAY OLACAKTIR

INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
VALUES ('Barbaros Çoraplarý', 2, 4, 45)

-- Bu noktadan sonra bizim bu iþi kullanýcýnýn girdiði parametrelerle yapabilmemiz gerekiyor. O yüzden deðerleri yani VALUES'i manuel deðil dinamik þekilde kullanýcýdan almalýyýz. Bu sebeple parametreleri kullanýcýdan alack bir deðiþkenler oluþturmamýz gerekiyor.

ALTER PROC dbo.addProduct
@UrunIsmi varchar(40),
@TedarikciNo int,
@KategoriNo int,
@BirimFiyat int
AS
BEGIN
INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
VALUES (@UrunIsmi, @TedarikciNo, @KategoriNo, @BirimFiyat)
PRINT 'HOJGELDÝN BEA. Ürün Kaydý Baþarýlý Þekilde Gerçekleþtirildi.'
SELECT * FROM Products
END

EXEC dbo.addProduct 'Seda Sever PC Oyunlarý',1, 3, 650

SELECT * FROM Products

-- 2 ÜRÜN GÜNCELLEME PROSEDÜRÜ

--- YÝNE ÖNCELÝKLE SORGUMUZU YAZALIM

UPDATE Products
SET ProductName = 'Barbaros Parfümleri'
WHERE ProductID = 80

-- ÞÝMDÝ DE BUNU PROSEDÜR MANTIÐINA UYGUN OLARAK DÝNAMÝK HALE GETÝRELÝM

ALTER PROC dbo.UpdateProducts
@UrunID int,
@UrunAdi nvarchar(40)
AS
BEGIN
UPDATE Products
SET ProductName = @UrunAdi
WHERE ProductID = @UrunID
PRINT 'ÜRÜN GÜNCELLEME ÝÞLEMÝ BAÞARIYLA GERÇEKLEÞTÝRÝLDÝ ' + @UrunAdi +' Ürünler arasýnda yerini aldý'
SELECT * FROM Products
END

EXEC dbo.UpdateProducts 80, 'Barbaros Çoraplarý'


--3 ÜRÜN SÝLME PROSEDÜRÜ
-- öncelikle silme komutunu manuel olarak yazalým
DELETE 
FROM Products
WHERE ProductID = 81

-- Sonra bunu prosedürel hale getirelim.

ALTER PROC dbo.DeleteProduct
@UrunId int
AS
BEGIN
DELETE 
FROM Products
WHERE ProductID = @UrunId
PRINT 'ÜRÜN SÝLME BAÞARILI ' + CONVERT (VARCHAR(50),@UrunId) + ' numaralý ürün silinmiþtir.' 
SELECT * FROM Products
END

EXEC DeleteProduct 81


-- KOÞULA BAÐLI OLARAK GELEN SONUCU DEÐÝÞTÝRME. ÜRÜNLERÝ KULLANICININ GÝRDÝÐÝ PARAMETREYE GÖRE UCUZDAN PAHALIYA YA DA PAHALIDAN UCUZA SIRALAMA

-- ÖNCE SORGUMUZU MANUEL YAZALIM

SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice ASC

SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC

-- ÞÝMDÝ BUNU PROSEDÜRE UYGUN HALE GETÝRELÝM

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
PRINT 'GÝRMENÝZ GEREKEN DEÐERLER YA  UCUZ YA DA PAHALI OLMALIDIR'
END

END

EXEC OrderProducts 'pahalý'

-- ÖRNEÐÝN BÝR E-TÝCARET SÝTESÝNDE EN ÇOK SATAN 15 ÜRÜNÜ LÝSTELEYEN BÝR BACK END SERVÝSÝ YAZILACAÐI ZAMAN AÞAÐIDAKÝ GÝBÝ BÝR KOD BLOÐU YETERLÝ OLACAKTIR.
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

--Kullanýcýnýn girdiði aya göre satýlan ürünleri listeleme kodunun prosedürel haliyle yazýlmasý

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