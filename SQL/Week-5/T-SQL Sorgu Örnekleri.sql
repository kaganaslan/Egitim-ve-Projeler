--Çalýþanlarýn Ad Soyad ve Full Ad olarak sorgusu
SELECT E.FirstName, E.LastName, E.FirstName + ' ' + E.LastName AS TamAdý
FROM Employees AS E

--Çalýþan Erkekleri Listeleme sorgusu
SELECT * 
FROM Employees
WHERE TitleOfCourtesy = 'Mr.'

--Çalýþan kadýnlarý listeleme
SELECT *
FROM Employees AS E
WHERE TitleOfCourtesy IN ('Mrs.', 'Ms.')

SELECT *
FROM Employees 
WHERE TitleOfCourtesy = 'Ms.' OR TitleOfCourtesy = 'Mrs.'


--Yinelenen datalarý tek sefer gösterebilmek adýna kullanýlan metot Distinct metodudur.
SELECT DISTINCT City
FROM Employees

--1955-01-01'den sonra doðanlarý gösterelim
SELECT *
FROM Employees 
WHERE BirthDate > '1955-01-01'

-- Yaþ bulmak için Datediff özelliðini kullanýyoruz. 3 parametre alýr ilk parametre hangi cinsten tutmak istediðimizi, ikinci üçüncü parametre neyden ikinci parametre neyi çýkartacaðýmýzý gösterir.
SELECT FirstName, DATEDIFF(YEAR, BirthDate, GetDate()) AS YAÞ
FROM Employees

--Kaç yaþýnda iþe baþladýklarýný bulalým
SELECT FirstName, DATEDIFF(YEAR, BirthDate , HireDate) AS IseBaslama
FROM Employees

--Adreslerinde rd harfi geçenleri bulalým
SELECT *
FROM Employees
WHERE Address LIKE '%RD%'

--Çalýþan yaþ ortalamasýný hesaplayalým
SELECT AVG(DATEDIFF(YEAR,BirthDate, GetDate())) AS YaþOrtalamasý
FROM Employees

-- En pahalý 3 ürünü getirelim
SELECT TOP 3 ProductName, UnitPrice
From Products
ORDER BY UnitPrice DESC

-- En ucuz 5 ürünün ortalama fiyatý
SELECT AVG(EnDusukler.UnitPrice) AS EnDusukOrtalama
FROM
(
SELECT TOP 5 ProductName, UnitPrice
From Products
ORDER BY UnitPrice ASC
) AS EnDusukler

--Stok sayýsý 30-40 arasý olanlarý bulalým.
SELECT ProductName, UnitsInStock
FROM Products
WHERE UnitsInStock BETWEEN 30 AND 40
ORDER BY UnitsInStock

-- en pahalý ürünün adý nedir?
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice =
(
SELECT MAX(UnitPrice)AS EnPahalýUrun
FROM Products
)

--Müþterileri ülkelerdeki adetlerine göre veren sorgu??
SELECT Country, COUNT(CustomerID) AS MüþteriAdeti
FROM Customers
GROUP BY Country

--Sipariþlerden kazanýlan toplam rakamlar. Sipariþ ID'sine göre SUM içerisinde kazanç hesaplattýrdýk ve bunu ayný order ýd'ye sahip olanlarýn hepsi için yaptýrýp birbirleriyle toplattýrdýk.
SELECT OrderID, SUM(UnitPrice * Quantity * ( 1 - Discount)) AS Ciro
FROM [Order Details]
Group by OrderID

--Sipariþ ID'si ayný olanlarýn kaç tane olduðunu hesapladýk.
SELECT OrderID, Count(OrderID)
FROM [Order Details]
Group by OrderID



