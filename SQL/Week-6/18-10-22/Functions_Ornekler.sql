--SQL FUNCTIONS

-- FONKSÝYONLAR ÝSTENEN DEÐER TÝPÝNDE GERÝ DÖNÜÞ SAÐLAYABÝLEN SQL KODLARIDIR.

-- DIFFERENCES BETWEEN STORED PROCEDURES AND FUNCTIONS:
-- FONKSÝYONLAR GERÝYE HER ZAMAN BÝR DEÐER DÖNDÜRÜR (SAYILAR, STRING IFADELER, TABLOLAR VS.) FAKAT STORED PROCEDURE'LER GERÝYE BÝR DEÐER DÖNDÜREBÝLÝR YA DA DÖNDÜRMEZ.
-- FONKSÝYONLARDA GÝRÝÞ ÝÇÝN PARAMETRELER VERÝLÝR, STORED PROCEDURELERDE HEM GÝRÝÞ HEM ÇIKIÞ ÝÇÝN PARAMETRELER VERÝLEBÝLMEKTEDÝR.
-- FONKSÝYONLAR STORED PROCEDURELER TARAFINDAN ÇALIÞTIRILABÝLÝR FAKAT SP'LER FONKSÝYONLAR ÝÇERÝSÝNDE ÇALIÞTIRILAMAZ.
-- FONKSÝYONLAR ÝÇERÝSÝNDE CRUD ÝÞLEMLERÝ YAPILAMAZ. SADECE SELECT ÝFADESÝ ÝÇÝN KULLANILABÝLÝR. SP ÝÇERÝSÝNDE ÖNCEKÝ ÖRNEKLERÝMÝZDEKÝ GÝBÝ BÜTÜN SELECT/INSERT/UPDATE/DELETE ÝÞLEMLERÝ YAPILABÝLMEKTEDÝR.
-- TRY CATCH YAPISI SP'DE YAPILABÝLÝRKEN FONKSÝYONLARDA GEÇERLÝLÝÐÝ YOKTUR.
-- PRINT IFADELERÝ SP'DE GEÇERLÝYKEN FONKSYÝONLARDA GEÇERLÝ DEÐÝLDÝR.
-- FONKSÝYONLAR ÝLE DÖNDÜRMÜÞ OLDUÐUNUZ BÝR TABLOYU JOIN ÝFADESÝ ÝÇERÝSÝNDE KULLANABÝLÝRSÝNÝZ. FAKAT STORED PROCEDURE ÝLE DÖNDÜRDÜÐÜNÜZ BÝR TABLODA BU ÝÞLEM GERÇEKLEÞTÝRÝLEMEZ.

-- FONKSÝYON ÇEÞÝTLERÝ
-- GERÝYE SABÝT DEÐER DÖNDÜRENLER
-- GERÝYE SORGU DÖNDÜRENLER
-- GERÝYE TABLO DEÐÝÞKENÝ DÖNDÜRENLER


-- GENELDE GERÝYE TABLO DÖNDÜRMEK ÝÇÝN FUNCTÝON KULLANMAK ÝMKAN DAHÝLÝNDE OLSA DA ÇOK ÖNERÝLMEMEKTEDÝR. ÇÜNKÜ PERFORMANSI ETKÝLEMEKTEDÝR. BU ÝÞLEMLER ÝÇÝN YA SP'LER YA DA VÝEW'LAR TERCÝH EDÝLMEKTEDÝR.

-- TABLE döndüren bir function için syntax þu þekildedir;
-- CREATE FUNCTION functionismi (@param1 datatype, @param2 datatype)
-- RETURNS TABLE
-- AS
--RETURN
-- SQL DEÐERLERÝ

-- deðer döndüren bir funcTion için syntax þu þekildedir;
-- CREATE FUNCTION functionismi (@param_n datatype, @param_n2 datatype)
-- RETURNS returntype
-- AS
--BEGIN
-- SQL DEÐERLERÝ
--END

-- örnek olarak int deðer alan ve tablo döndüren bir function yazalým.
ALTER FUNCTION fn_SelectFunction (@sayi int)
RETURNS TABLE
AS
RETURN
SELECT * FROM Products Where UnitsInStock <= @sayi

-- Bu ifade ile
SELECT * FROM Products
WHERE UnitsInStock <= 50
-- bu ifade ayný sonucu döndürmektedir. Fakat biz bu iþi fonksiyon aracýlýðýyla yaptýðýmýz için her defasýnda deðiþen where koþulu için tekrar tekrar sorgu yazmak yerine sadece dönüþ tipi table olan tablomuzun parametresini deðiþtirerek yeni sorgular yapabiliyor hale geleceðiz.
SELECT * FROM fn_SelectFunction (50) -- burdaki fn_ ifadesinden sonrasý normal bir tabloymuþ gibi çalýþýyor. çünkü return kýsmýna table döneceðini belirtmiþ olduk.

-- BÝR ÖRNEK DE DEÐER DÖNDÜREN FUNCTION'LAR ÜZERÝNDEN YAPALIM

CREATE FUNCTION fn_MakeFullName (@isim varchar(50), @soyisim varchar(50))
RETURNS varchar(50)
AS
BEGIN
RETURN @isim + ' ' + @soyisim
END

select dbo.fn_MakeFullName('barb','ciga')

SELECT FirstName, LastName ,dbo.fn_MakeFullName(FirstName, LastName) AS FullName
FROM Employees

-- ürün fiyatý kulanýcýnýn girdiði deðer arasýnda alan ürünleri listeleyen bir fonksiyon yazalým.

ALTER FUNCTION fn_AralikliUrun (@fiyat1 int, @fiyat2 int)
RETURNS TABLE
AS
RETURN 
SELECT ProductID, ProductName, UnitPrice 
FROM Products 
WHERE UnitPrice BETWEEN @fiyat1 and @fiyat2


SELECT OD.ProductID, O.EmployeeID, FA.ProductName, Fa.UnitPrice,  E.FirstName
FROM [Order Details] AS OD
INNER JOIN Orders as o
ON O.OrderID = OD.OrderID
INNER JOIN fn_AralikliUrun (40,50) AS FA ON FA.ProductID = OD.ProductID
INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID



