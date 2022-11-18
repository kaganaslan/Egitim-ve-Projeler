--TRIGGERLAR --

-- TÜRKÇESÝ TETÝKLEYÝCÝ OLARAK GEÇEN YAPILARDIR VE BELÝRLÝ ANLAMLARDA STORED PROCEDURE'LERE BENZEMEKTEDÝRLER.
-- HER DÜZEYDE TRIGGERLAR BULUNMAKTADIR AMA GENEL OLARAK YAPILAN ÝÞLMLER DML TRIGGERLAR SEVÝYESÝNDE YAPILMAKTADIR. 
-- DML TRIGGERLAR BÝR TABLODA INSERT, UPDATE VEYA DELETE ÝÞLEMLERÝ GERÇEKLEÞTÝÐÝNDE DEVREYE GÝRERLER. 
-- ÖRNEÐÝN BÝR TABLODA INSERT ÝÞLEMÝ GERÇEKLEÞTÝÐÝNDE RAM BELLE ÜZERÝNDE GEÇÝCÝ BÝR inserted tablosu oluþturulur. Eðer bu insert iþlemi sorunsuzsa "inserted" tablosundaki bu veriler gerçek tabloya insert edilir.
-- Eðer bir taboda DELETE iþlemi gerçekleþtiriliyor ise yine ayný þekilde RAM bellek üzerinde geçici bir "deleted" tablosunda veriler tutulur. Eðer ki bu transaction'da bir hata yoksa gerçek tablodan veri silinir.
-- Eðer ki bir tabloda UPDATE iþlemi gerçekleþtiriliyorsa updated adýnda geçici bir tablo oluþturulmaz!!!!! Çünkü update iþlemi gerçekleþtirildiði zaman önce delete sonra insert iþlemi gerçekleþtirilir.  yani arka planda hem deleted hem de inserted tablolarý oluþur.
-- Haliyle arkaplanda böyle tablolar oluþtuðu için sorgu esnasýnda bu tablolardan faydalanmaktayýz. SELECT gibi iþlemleri yapmak mümkündür.

-- yani özet olarak triggerlar belirli bir olay meydana geldiðinde ya da gelmeden önce otomatik olarak istediðimiz þekilde çalýþan özel bir yapýdýr.
-- 2 çeþit trigger kullanýmý bulunmaktadýr.
-- Birincisi olay gerçekleþtikten sonra olacaklarý tasarlamak üzerine (AFTER TRIGGER)
-- Diðeri olayýn gerçekleþmesi yerine þu iþlemi gerçekleþtir þeklinde. (INSTEAD OF TRIGGER)

-- CREATE TRIGGER -TriggerAdi-
-- ON -IslemYapýlanTablo-
-- AFTER // FOR -hangiiþlemdensonraolacaðýnýbelirtiyoruz örneðin delete ya da update ya da insert gibi
-- AS
-- KOD BLOKLARI

CREATE TRIGGER UyariVer
ON Personeller
AFTER DELETE
AS
PRINT 'Bir adet personel silinmiþtir.'

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
VALUES ('Çorum Mamülleri')


ALTER TRIGGER AfterUpdateSuppliers
ON Suppliers
AFTER UPDATE
AS
INSERT INTO Products(ProductName ) VALUES('UMUT')
PRINT 'Guncelleþtirme Ýþlemi Baþarýlý'

UPDATE Suppliers 
SET CompanyName ='Bilim Bey A.Þ' WHERE SupplierID = 5

SELECT * FROM Products

-- Ram bellekte oluþan geçici tablolarý kullanmak üzerine örnek

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
INSERT RecordTable (RecordDescription) VALUES ('Ýsmi ' + @EmployeeName + ' olan ve soyismi ' + @EmployeeSurname + ' olan kullanýcý ' + CONVERT(varchar(100), getdate()) + ' tarihinde silinmiþtir.')

DELETE FROM Employees WHERE EmployeeID = 10

select * from RecordTable

-- PERSONEL TABLOSUNDA ÝSÝM VE SOY ÝSMÝ GÜNCELLENEN PERSONELÝN ÝSMÝNÝN ÖNCEKÝ HALÝ VE SONRAKÝ HALÝNÝ LOG TABLOMUZDA KAYDEDEN 

CREATE TRIGGER Record_Update
ON Employees
AFTER UPDATE
AS
DECLARE @BeforeValue varchar(100), @AfterValue varchar(100)
SELECT @BeforeValue = FirstName FROM deleted
SELECT @AfterValue = FirstName FROM inserted
INSERT RecordTable (RecordDescription) VALUES ('Eski adý ' + @BeforeValue + ' olan personelin adý ' + @AfterValue + ' olacak þekilde güncellenmiþtir')

UPDATE Employees set FirstName = 'Baldo' WHERE EmployeeID = 13

-- INSTEAD OF TRIGGERLAR 
-- INSERT UPDATE DELETE GÝBÝ KOMUTLARIMIZI YÝNE KULLANIYORUZ FAKAT BURADA DEMEK ÝSTEDÝÐÝMÝZ ÞU OLUYOR INSERT YERINE ÞUNU YAP, YA DA DELETE YAPILMAK ÝSTENDÝÐÝNDE BUNU YAP GÝBÝ.

CREATE TRIGGER InsteadOfSilmeOrnek
ON Employees
INSTEAD OF DELETE 
AS
DECLARE @PName varchar(50), @PSurname varchar(50)
SELECT @PName = FirstName, @PSurname = LastName FROM deleted
INSERT INTO RecordTable (RecordDescription) VALUES ('Adý: ' + @PName + ' Soyadý: ' + @PSurname + ' olan personel silinmeye çalýþýldý')


DELETE FROM Employees WHERE EmployeeID = 13


-- BELLÝ BÝR KÝÞÝ SÝLÝNEMEYÝP ÝSTEDÝÐÝMÝZ KÝÞÝYÝ SÝLEBÝLMEK ADIN YAZACAÐIMIZ TRIGGER MODELÝ

Create TRIGGER kontrolluDelete
on Personeller
AFTER DELETE
AS
DECLARE @PersonelAdi varchar(50)
SELECT @PersonelAdi = PersonelAdi FROM deleted
IF @PersonelAdi = 'BÝLÝM'
BEGIN
RAISERROR('BÝLÝM SÝLÝNEMEZ!', 0 , 0)
ROLLBACK 
END

DELETE FROM Personeller WHERE PersonelAdi = 'BÝLÝM'



CREATE TRIGGER DeleteByGender ON Personeller
AFTER INSERT
AS
IF ( EXISTS (SELECT * FROM inserted WHERE Cinsiyet = 1))
BEGIN
RAISERROR ('Erkek personel kaydý engellenmiþtir',0,0)
ROLLBACK
END

INSERT INTO Personeller (PersonelAdi, PersonelSoyadi, Cinsiyet)
VALUES ('Selin', 'Bayatlý', 1)


-- Personellerin cinsiyetlerinde güncelleþtirme iþlemi gerçekleþtirilemesin!

ALTER TRIGGER BlockGenderUpdate
ON Personeller
AFTER UPDATE
AS
IF ( EXISTS (SELECT * FROM inserted, deleted WHERE inserted.PersonelID = deleted.PersonelID AND inserted.Cinsiyet != deleted.Cinsiyet ))
BEGIN
RAISERROR('CÝNSÝYET DEÐÝÞÝMÝ YASAK',0,0)
ROLLBACK
END

UPDATE Personeller SET Cinsiyet = 2 WHERE PersonelID = 13

