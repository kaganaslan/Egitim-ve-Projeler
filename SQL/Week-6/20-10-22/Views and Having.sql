-- SQL VIEWS
-- Db'de istedi�imiz zaman istedi�imiz tablolar� birle�tirip istedi�imiz sorgu bi�imiyle �a��rabilmekteyiz. Fakat bu sonucu daha sonras�nda tekrar g�r�nt�leyebilmek ad�na tekrar sorgu yazmak istemiyorsak bu durumlarda viewlardan yararlanmaktay�z.

-- Sorgunun do�ru olup olmad���n� kontrol i�in ilk sefer derleme yap�l�r sonras�nda sadece �a�r�l�r.
-- Viewlar'da veri tutulmaz sadece g�sterilir. Her �a�r�lma i�lemi ger�ekle�ti�inde sorgu �al��t�r�lm�� olur.

-- syntax 
-- CREATE VIEW VIEWADI
-- AS
-- SELECT SUTUN ADI FROM TABLO ADI

CREATE VIEW view_SiparisGetir
as
SELECT *
FROM [Order Details]


SELECT * FROM view_SiparisGetir

-- G�NCELLEME ���N DE KLAS�K DDL KOMUTLARI KULLANMAKTAYIZ

ALTER VIEW view_SiparisGetir
AS
SELECT od.OrderID, P.ProductName, od.UnitPrice
FROM [Order Details] AS OD
INNER JOIN Products AS P
ON P.ProductID = od.ProductID

SELECT * FROM view_SiparisGetir

-- �RNEK OLARAK BREZ�LYALI M��TER�LER� G�STEREN B�R V�EW YAZALIM 
CREATE VIEW [Brezilyal� M��terilerim] AS SELECT CustomerID, CompanyName FROM Customers WHERE Country = 'Brazil'

SELECT * FROM [Brezilyal� M��terilerim]

-- �R�NLER�N F�YATININ �R�N F�YAT ORTALAMASI �ZER�NDE OLANLARI G�STEREN B�R VIEW YAZIN

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



-- HAVING ( AGGREGATE FUNCTION KULLANIMLARINDA KULLANDI�IMIZ �ART �FADES�D�R. VE GROUP BY �LE BERABER KULLANILIR)

-- M��TER� ADED� 10'DAN B�Y�K OLAN �LKELER� G�STERME KOMUTU

SELECT COUNT(CustomerID) as [M��teri Adedi], Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 10

CREATE VIEW AmerikaliMusterileriNSayisiniGosterenTablo
as
SELECT COUNT(CustomerID) as [M��teri Adedi], Country
FROM Customers
GROUP BY Country
HAVING Country = 'USA'

select * from AmerikaliMusterileriNSayisiniGosterenTablo


-- 50'den fazla sipari� alan personelleri listeleyen kod ve view ile g�sterilmesi
 
-- E�ER K� B�Z COUNT, SUM, MAX, MIN G�B� Aggregate FUNCTION'LAR KULLANIYORSAK BURADAK� SORGUDAN SONU� ALAB�LMEM�Z ���N MUTLAKA GROUP BY KULLANMAMIZ GEREK�YOR. BU G�B� SORGULARDA ���N ��ER�S�NE B�R �ART BA�LAMAK �STERSEK HAVING KEYWORDUNU KULLANMAMIZ GEREK�R.  BU SORUDAK� LOGIC �U �EK�LDE �ALI�MAKTADIR. �NCEL�KLE B�ZE S�PAR��LER� SAYAN B�R KOMUT GEREK�YOR BUNU COUNT(ORDERID) DIYEREK SA�LADIK. FAKAT BU SAYMA ��LEM�NDE YAPACA�IMIZ GRUPLAMA �U �EK�LDE OLACAK, �RNE��N 1 NOLU �ALI�AN ���N 10 S�PAR�� VAR, 2 NOLU �ALI�AN ���N 15 S�PAR�� VAR �EKL�NDE S�PAR��LER� TEK TEK SAYACAK. BU SEBEPLE BURADA GRUPLAMAYI SA�LAYAN KOLON �ALI�AN �LE ALAKALI B�R KOLON OLMALI. SADECE �ALI�AN ID'SINI G�STERMEK �STESEYD�K GROUP BY EmployeeID �eklinde yazacakt�k. FAKAT B�Z �ALI�AN �SM�N� DE G�STERMEK �STED���M�Z ���N JOIN YAPARAK �ALI�AN TABLOSUNDAK� VER�LER� DE SORGUMUZA KATTIK. BU Y�ZDEN GROUP BY ��ER�S�NE SELECT �FADES�N�N YANINDA YER ALAN O.EmployeeID ve E.EmployeeName ifadesini de ekledik.


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


-- Order details i�erisinde dip toplam fiyat 1500 ile 3000 aras�nda olan sipari�leri listeleyin 


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

��


10