-- SQL VIEWS
-- Db'de istediðimiz zaman istediðimiz tablolarý birleþtirip istediðimiz sorgu biçimiyle çaðýrabilmekteyiz. Fakat bu sonucu daha sonrasýnda tekrar görüntüleyebilmek adýna tekrar sorgu yazmak istemiyorsak bu durumlarda viewlardan yararlanmaktayýz.

-- Sorgunun doðru olup olmadýðýný kontrol için ilk sefer derleme yapýlýr sonrasýnda sadece çaðrýlýr.
-- Viewlar'da veri tutulmaz sadece gösterilir. Her çaðrýlma iþlemi gerçekleþtiðinde sorgu çalýþtýrýlmýþ olur.

-- syntax 
-- CREATE VIEW VIEWADI
-- AS
-- SELECT SUTUN ADI FROM TABLO ADI

CREATE VIEW view_SiparisGetir
as
SELECT *
FROM [Order Details]


SELECT * FROM view_SiparisGetir

-- GÜNCELLEME ÝÇÝN DE KLASÝK DDL KOMUTLARI KULLANMAKTAYIZ

ALTER VIEW view_SiparisGetir
AS
SELECT od.OrderID, P.ProductName, od.UnitPrice
FROM [Order Details] AS OD
INNER JOIN Products AS P
ON P.ProductID = od.ProductID

SELECT * FROM view_SiparisGetir

-- ÖRNEK OLARAK BREZÝLYALI MÜÞTERÝLERÝ GÖSTEREN BÝR VÝEW YAZALIM 
CREATE VIEW [Brezilyalý Müþterilerim] AS SELECT CustomerID, CompanyName FROM Customers WHERE Country = 'Brazil'

SELECT * FROM [Brezilyalý Müþterilerim]

-- ÜRÜNLERÝN FÝYATININ ÜRÜN FÝYAT ORTALAMASI ÜZERÝNDE OLANLARI GÖSTEREN BÝR VIEW YAZIN

CREATE VIEW ortalamaUstunuGoster
AS
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products)

select * from ortalamaUstunuGoster


SELECT  UnitPrice
FROM Products
GROUP BY  UnitPrice
HAVING UnitPrice > AVG(UnitPrice)



-- HAVING ( AGGREGATE FUNCTION KULLANIMLARINDA KULLANDIÐIMIZ ÞART ÝFADESÝDÝR. VE GROUP BY ÝLE BERABER KULLANILIR)

-- MÜÞTERÝ ADEDÝ 10'DAN BÜYÜK OLAN ÜLKELERÝ GÖSTERME KOMUTU

SELECT COUNT(CustomerID) as [Müþteri Adedi], Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 10

CREATE VIEW AmerikaliMusterileriNSayisiniGosterenTablo
as
SELECT COUNT(CustomerID) as [Müþteri Adedi], Country
FROM Customers
GROUP BY Country
HAVING Country = 'USA'

select * from AmerikaliMusterileriNSayisiniGosterenTablo


-- 50'den fazla sipariþ alan personelleri listeleyen kod ve view ile gösterilmesi
 
-- EÐER KÝ BÝZ COUNT, SUM, MAX, MIN GÝBÝ Aggregate FUNCTION'LAR KULLANIYORSAK BURADAKÝ SORGUDAN SONUÇ ALABÝLMEMÝZ ÝÇÝN MUTLAKA GROUP BY KULLANMAMIZ GEREKÝYOR. BU GÝBÝ SORGULARDA ÝÞÝN ÝÇERÝSÝNE BÝR ÞART BAÐLAMAK ÝSTERSEK HAVING KEYWORDUNU KULLANMAMIZ GEREKÝR.  BU SORUDAKÝ LOGIC ÞU ÞEKÝLDE ÇALIÞMAKTADIR. ÖNCELÝKLE BÝZE SÝPARÝÞLERÝ SAYAN BÝR KOMUT GEREKÝYOR BUNU COUNT(ORDERID) DIYEREK SAÐLADIK. FAKAT BU SAYMA ÝÞLEMÝNDE YAPACAÐIMIZ GRUPLAMA ÞU ÞEKÝLDE OLACAK, ÖRNEÐÝN 1 NOLU ÇALIÞAN ÝÇÝN 10 SÝPARÝÞ VAR, 2 NOLU ÇALIÞAN ÝÇÝN 15 SÝPARÝÞ VAR ÞEKLÝNDE SÝPARÝÞLERÝ TEK TEK SAYACAK. BU SEBEPLE BURADA GRUPLAMAYI SAÐLAYAN KOLON ÇALIÞAN ÝLE ALAKALI BÝR KOLON OLMALI. SADECE ÇALIÞAN ID'SINI GÖSTERMEK ÝSTESEYDÝK GROUP BY EmployeeID þeklinde yazacaktýk. FAKAT BÝZ ÇALIÞAN ÝSMÝNÝ DE GÖSTERMEK ÝSTEDÝÐÝMÝZ ÝÇÝN JOIN YAPARAK ÇALIÞAN TABLOSUNDAKÝ VERÝLERÝ DE SORGUMUZA KATTIK. BU YÜZDEN GROUP BY ÝÇERÝSÝNE SELECT ÝFADESÝNÝN YANINDA YER ALAN O.EmployeeID ve E.EmployeeName ifadesini de ekledik.


SELECT E.EmployeeID, E.FirstName, COUNT(O.OrderID) AS SiparisAdedi
FROM Orders as O
INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID
GROUP BY E.EmployeeID, E.FirstName
HAVING COUNT(O.OrderID) > 50

CREATE VIEW EllidenYuksekSiparisAlanlar
AS
SELECT E.FirstName, COUNT(O.OrderID) AS SiparisAdedi
FROM Orders as O
INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID
GROUP BY E.FirstName
HAVING COUNT(O.OrderID) > 50

SELECT * FROM EllidenYuksekSiparisAlanlar


-- Order details içerisinde dip toplam fiyat 1500 ile 3000 arasýnda olan sipariþleri listeleyin 


SELECT OrderID , SUM(UnitPrice * Quantity * (1-Discount)) AS [Toplam Fiyat]
FROM [Order Details]
GROUP BY OrderID
HAVING SUM(UnitPrice * Quantity * (1-Discount)) BETWEEN 1500 AND 3000
ORDER BY [Toplam Fiyat] DESC

CREATE VIEW TopFiyatHesaplaOrderBy1500and3000
as
SELECT OrderID , SUM(UnitPrice * Quantity * (1-Discount)) AS [Toplam Fiyat]
FROM [Order Details]
GROUP BY OrderID
HAVING SUM(UnitPrice * Quantity * (1-Discount)) BETWEEN 1500 AND 3000

üü


10