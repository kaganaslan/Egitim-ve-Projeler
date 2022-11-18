--TRIGGERLAR --

-- T�RK�ES� TET�KLEY�C� OLARAK GE�EN YAPILARDIR VE BEL�RL� ANLAMLARDA STORED PROCEDURE'LERE BENZEMEKTED�RLER.
-- HER D�ZEYDE TRIGGERLAR BULUNMAKTADIR AMA GENEL OLARAK YAPILAN ��LMLER DML TRIGGERLAR SEV�YES�NDE YAPILMAKTADIR. 
-- DML TRIGGERLAR B�R TABLODA INSERT, UPDATE VEYA DELETE ��LEMLER� GER�EKLE�T���NDE DEVREYE G�RERLER. 
-- �RNE��N B�R TABLODA INSERT ��LEM� GER�EKLE�T���NDE RAM BELLE �ZER�NDE GE��C� B�R inserted tablosu olu�turulur. E�er bu insert i�lemi sorunsuzsa "inserted" tablosundaki bu veriler ger�ek tabloya insert edilir.
-- E�er bir taboda DELETE i�lemi ger�ekle�tiriliyor ise yine ayn� �ekilde RAM bellek �zerinde ge�ici bir "deleted" tablosunda veriler tutulur. E�er ki bu transaction'da bir hata yoksa ger�ek tablodan veri silinir.
-- E�er ki bir tabloda UPDATE i�lemi ger�ekle�tiriliyorsa updated ad�nda ge�ici bir tablo olu�turulmaz!!!!! ��nk� update i�lemi ger�ekle�tirildi�i zaman �nce delete sonra insert i�lemi ger�ekle�tirilir.  yani arka planda hem deleted hem de inserted tablolar� olu�ur.
-- Haliyle arkaplanda b�yle tablolar olu�tu�u i�in sorgu esnas�nda bu tablolardan faydalanmaktay�z. SELECT gibi i�lemleri yapmak m�mk�nd�r.

-- yani �zet olarak triggerlar belirli bir olay meydana geldi�inde ya da gelmeden �nce otomatik olarak istedi�imiz �ekilde �al��an �zel bir yap�d�r.
-- 2 �e�it trigger kullan�m� bulunmaktad�r.
-- Birincisi olay ger�ekle�tikten sonra olacaklar� tasarlamak �zerine (AFTER TRIGGER)
-- Di�eri olay�n ger�ekle�mesi yerine �u i�lemi ger�ekle�tir �eklinde. (INSTEAD OF TRIGGER)

-- CREATE TRIGGER -TriggerAdi-
-- ON -IslemYap�lanTablo-
-- AFTER // FOR -hangii�lemdensonraolaca��n�belirtiyoruz �rne�in delete ya da update ya da insert gibi
-- AS
-- KOD BLOKLARI

CREATE TRIGGER UyariVer
ON Personeller
AFTER DELETE
AS
PRINT 'Bir adet personel silinmi�tir.'

select*from Personeller

DELETE
FROM Personeller
WHERE PersonelID = 6

CREATE TRIGGER FiyatArttirmaTrigger
ON Products
AFTER INSERT
AS
UPDATE Products SET UnitPrice += 50

SELECT * FROM Products

INSERT INTO 
Products (ProductName)
VALUES ('�orum Mam�lleri')


ALTER TRIGGER AfterUpdateSuppliers
ON Suppliers
AFTER UPDATE
AS
INSERT INTO Products(ProductName ) VALUES('UMUT')
PRINT 'Guncelle�tirme ��lemi Ba�ar�l�'

UPDATE Suppliers 
SET CompanyName ='Bilim Bey A.�' WHERE SupplierID = 5

SELECT * FROM Products

-- Ram bellekte olu�an ge�ici tablolar� kullanmak �zerine �rnek

CREATE TABLE RecordTable
(
RecordId int primary key identity(1,1),
RecordDescription varchar(100)
)

CREATE TRIGGER RecordTrigger
ON Employees
AFTER DELETE
AS
DECLARE @EmployeeName varchar(50), @EmployeeSurname varchar(50)
SELECT @EmployeeName = FirstName, @EmployeeSurname = LastName
FROM deleted
INSERT RecordTable (RecordDescription) VALUES ('�smi ' + @EmployeeName + ' olan ve soyismi ' + @EmployeeSurname + ' olan kullan�c� ' + CONVERT(varchar(100), getdate()) + ' tarihinde silinmi�tir.')

DELETE FROM Employees WHERE EmployeeID = 10

select * from RecordTable

-- PERSONEL TABLOSUNDA �S�M VE SOY �SM� G�NCELLENEN PERSONEL�N �SM�N�N �NCEK� HAL� VE SONRAK� HAL�N� LOG TABLOMUZDA KAYDEDEN 

CREATE TRIGGER Record_Update
ON Employees
AFTER UPDATE
AS
DECLARE @BeforeValue varchar(100), @AfterValue varchar(100)
SELECT @BeforeValue = FirstName FROM deleted
SELECT @AfterValue = FirstName FROM inserted
INSERT RecordTable (RecordDescription) VALUES ('Eski ad� ' + @BeforeValue + ' olan personelin ad� ' + @AfterValue + ' olacak �ekilde g�ncellenmi�tir')

UPDATE Employees set FirstName = 'Baldo' WHERE EmployeeID = 13

-- INSTEAD OF TRIGGERLAR 
-- INSERT UPDATE DELETE G�B� KOMUTLARIMIZI Y�NE KULLANIYORUZ FAKAT BURADA DEMEK �STED���M�Z �U OLUYOR INSERT YERINE �UNU YAP, YA DA DELETE YAPILMAK �STEND���NDE BUNU YAP G�B�.

CREATE TRIGGER InsteadOfSilmeOrnek
ON Employees
INSTEAD OF DELETE 
AS
DECLARE @PName varchar(50), @PSurname varchar(50)
SELECT @PName = FirstName, @PSurname = LastName FROM deleted
INSERT INTO RecordTable (RecordDescription) VALUES ('Ad�: ' + @PName + ' Soyad�: ' + @PSurname + ' olan personel silinmeye �al���ld�')


DELETE FROM Employees WHERE EmployeeID = 13


-- BELL� B�R K��� S�L�NEMEY�P �STED���M�Z K���Y� S�LEB�LMEK ADIN YAZACA�IMIZ TRIGGER MODEL�

Create TRIGGER kontrolluDelete
on Personeller
AFTER DELETE
AS
DECLARE @PersonelAdi varchar(50)
SELECT @PersonelAdi = PersonelAdi FROM deleted
IF @PersonelAdi = 'B�L�M'
BEGIN
RAISERROR('B�L�M S�L�NEMEZ!', 0 , 0)
ROLLBACK 
END

DELETE FROM Personeller WHERE PersonelAdi = 'B�L�M'



CREATE TRIGGER DeleteByGender ON Personeller
AFTER INSERT
AS
IF ( EXISTS (SELECT * FROM inserted WHERE Cinsiyet = 1))
BEGIN
RAISERROR ('Erkek personel kayd� engellenmi�tir',0,0)
ROLLBACK
END

INSERT INTO Personeller (PersonelAdi, PersonelSoyadi, Cinsiyet)
VALUES ('Selin', 'Bayatl�', 1)


-- Personellerin cinsiyetlerinde g�ncelle�tirme i�lemi ger�ekle�tirilemesin!

ALTER TRIGGER BlockGenderUpdate
ON Personeller
AFTER UPDATE
AS
IF ( EXISTS (SELECT * FROM inserted, deleted WHERE inserted.PersonelID = deleted.PersonelID AND inserted.Cinsiyet != deleted.Cinsiyet ))
BEGIN
RAISERROR('C�NS�YET DE����M� YASAK',0,0)
ROLLBACK
END

UPDATE Personeller SET Cinsiyet = 2 WHERE PersonelID = 13

