--SQL FUNCTIONS

-- FONKS�YONLAR �STENEN DE�ER T�P�NDE GER� D�N�� SA�LAYAB�LEN SQL KODLARIDIR.

-- DIFFERENCES BETWEEN STORED PROCEDURES AND FUNCTIONS:
-- FONKS�YONLAR GER�YE HER ZAMAN B�R DE�ER D�ND�R�R (SAYILAR, STRING IFADELER, TABLOLAR VS.) FAKAT STORED PROCEDURE'LER GER�YE B�R DE�ER D�ND�REB�L�R YA DA D�ND�RMEZ.
-- FONKS�YONLARDA G�R�� ���N PARAMETRELER VER�L�R, STORED PROCEDURELERDE HEM G�R�� HEM �IKI� ���N PARAMETRELER VER�LEB�LMEKTED�R.
-- FONKS�YONLAR STORED PROCEDURELER TARAFINDAN �ALI�TIRILAB�L�R FAKAT SP'LER FONKS�YONLAR ��ER�S�NDE �ALI�TIRILAMAZ.
-- FONKS�YONLAR ��ER�S�NDE CRUD ��LEMLER� YAPILAMAZ. SADECE SELECT �FADES� ���N KULLANILAB�L�R. SP ��ER�S�NDE �NCEK� �RNEKLER�M�ZDEK� G�B� B�T�N SELECT/INSERT/UPDATE/DELETE ��LEMLER� YAPILAB�LMEKTED�R.
-- TRY CATCH YAPISI SP'DE YAPILAB�L�RKEN FONKS�YONLARDA GE�ERL�L��� YOKTUR.
-- PRINT IFADELER� SP'DE GE�ERL�YKEN FONKSY�ONLARDA GE�ERL� DE��LD�R.
-- FONKS�YONLAR �LE D�ND�RM�� OLDU�UNUZ B�R TABLOYU JOIN �FADES� ��ER�S�NDE KULLANAB�L�RS�N�Z. FAKAT STORED PROCEDURE �LE D�ND�RD���N�Z B�R TABLODA BU ��LEM GER�EKLE�T�R�LEMEZ.

-- FONKS�YON �E��TLER�
-- GER�YE SAB�T DE�ER D�ND�RENLER
-- GER�YE SORGU D�ND�RENLER
-- GER�YE TABLO DE���KEN� D�ND�RENLER


-- GENELDE GER�YE TABLO D�ND�RMEK ���N FUNCT�ON KULLANMAK �MKAN DAH�L�NDE OLSA DA �OK �NER�LMEMEKTED�R. ��NK� PERFORMANSI ETK�LEMEKTED�R. BU ��LEMLER ���N YA SP'LER YA DA V�EW'LAR TERC�H ED�LMEKTED�R.

-- TABLE d�nd�ren bir function i�in syntax �u �ekildedir;
-- CREATE FUNCTION functionismi (@param1 datatype, @param2 datatype)
-- RETURNS TABLE
-- AS
--RETURN
-- SQL DE�ERLER�

-- de�er d�nd�ren bir funcTion i�in syntax �u �ekildedir;
-- CREATE FUNCTION functionismi (@param_n datatype, @param_n2 datatype)
-- RETURNS returntype
-- AS
--BEGIN
-- SQL DE�ERLER�
--END

-- �rnek olarak int de�er alan ve tablo d�nd�ren bir function yazal�m.
ALTER FUNCTION fn_SelectFunction (@sayi int)
RETURNS TABLE
AS
RETURN
SELECT * FROM Products Where UnitsInStock <= @sayi

-- Bu ifade ile
SELECT * FROM Products
WHERE UnitsInStock <= 50
-- bu ifade ayn� sonucu d�nd�rmektedir. Fakat biz bu i�i fonksiyon arac�l���yla yapt���m�z i�in her defas�nda de�i�en where ko�ulu i�in tekrar tekrar sorgu yazmak yerine sadece d�n�� tipi table olan tablomuzun parametresini de�i�tirerek yeni sorgular yapabiliyor hale gelece�iz.
SELECT * FROM fn_SelectFunction (50) -- burdaki fn_ ifadesinden sonras� normal bir tabloymu� gibi �al���yor. ��nk� return k�sm�na table d�nece�ini belirtmi� olduk.

-- B�R �RNEK DE DE�ER D�ND�REN FUNCTION'LAR �ZER�NDEN YAPALIM

CREATE FUNCTION fn_MakeFullName (@isim varchar(50), @soyisim varchar(50))
RETURNS varchar(50)
AS
BEGIN
RETURN @isim + ' ' + @soyisim
END

select dbo.fn_MakeFullName('barb','ciga')

SELECT FirstName, LastName ,dbo.fn_MakeFullName(FirstName, LastName) AS FullName
FROM Employees

-- �r�n fiyat� kulan�c�n�n girdi�i de�er aras�nda alan �r�nleri listeleyen bir fonksiyon yazal�m.

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



