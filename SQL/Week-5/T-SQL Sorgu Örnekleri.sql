--�al��anlar�n Ad Soyad ve Full Ad olarak sorgusu
SELECT E.FirstName, E.LastName, E.FirstName + ' ' + E.LastName AS TamAd�
FROM Employees AS E

--�al��an Erkekleri Listeleme sorgusu
SELECT * 
FROM Employees
WHERE TitleOfCourtesy = 'Mr.'

--�al��an kad�nlar� listeleme
SELECT *
FROM Employees AS E
WHERE TitleOfCourtesy IN ('Mrs.', 'Ms.')

SELECT *
FROM Employees 
WHERE TitleOfCourtesy = 'Ms.' OR TitleOfCourtesy = 'Mrs.'


--Yinelenen datalar� tek sefer g�sterebilmek ad�na kullan�lan metot Distinct metodudur.
SELECT DISTINCT City
FROM Employees

--1955-01-01'den sonra do�anlar� g�sterelim
SELECT *
FROM Employees 
WHERE BirthDate > '1955-01-01'

-- Ya� bulmak i�in Datediff �zelli�ini kullan�yoruz. 3 parametre al�r ilk parametre hangi cinsten tutmak istedi�imizi, ikinci ���nc� parametre neyden ikinci parametre neyi ��kartaca��m�z� g�sterir.
SELECT FirstName, DATEDIFF(YEAR, BirthDate, GetDate()) AS YA�
FROM Employees

--Ka� ya��nda i�e ba�lad�klar�n� bulal�m
SELECT FirstName, DATEDIFF(YEAR, BirthDate , HireDate) AS IseBaslama
FROM Employees

--Adreslerinde rd harfi ge�enleri bulal�m
SELECT *
FROM Employees
WHERE Address LIKE '%RD%'

--�al��an ya� ortalamas�n� hesaplayal�m
SELECT AVG(DATEDIFF(YEAR,BirthDate, GetDate())) AS Ya�Ortalamas�
FROM Employees

-- En pahal� 3 �r�n� getirelim
SELECT TOP 3 ProductName, UnitPrice
From Products
ORDER BY UnitPrice DESC

-- En ucuz 5 �r�n�n ortalama fiyat�
SELECT AVG(EnDusukler.UnitPrice) AS EnDusukOrtalama
FROM
(
SELECT TOP 5 ProductName, UnitPrice
From Products
ORDER BY UnitPrice ASC
) AS EnDusukler

--Stok say�s� 30-40 aras� olanlar� bulal�m.
SELECT ProductName, UnitsInStock
FROM Products
WHERE UnitsInStock BETWEEN 30 AND 40
ORDER BY UnitsInStock

-- en pahal� �r�n�n ad� nedir?
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice =
(
SELECT MAX(UnitPrice)AS EnPahal�Urun
FROM Products
)

--M��terileri �lkelerdeki adetlerine g�re veren sorgu??
SELECT Country, COUNT(CustomerID) AS M��teriAdeti
FROM Customers
GROUP BY Country

--Sipari�lerden kazan�lan toplam rakamlar. Sipari� ID'sine g�re SUM i�erisinde kazan� hesaplatt�rd�k ve bunu ayn� order �d'ye sahip olanlar�n hepsi i�in yapt�r�p birbirleriyle toplatt�rd�k.
SELECT OrderID, SUM(UnitPrice * Quantity * ( 1 - Discount)) AS Ciro
FROM [Order Details]
Group by OrderID

--Sipari� ID'si ayn� olanlar�n ka� tane oldu�unu hesaplad�k.
SELECT OrderID, Count(OrderID)
FROM [Order Details]
Group by OrderID



