--DDL KOMUTLARI ÝLE ÖRNEKLER


--CREATE KOMUTU ÝLE TABLO SEGMENTÝ VE ÜST SEGMENTLERDE OLUÞTURMA ÝÞLEMÝ GERÇEKLEÞTÝRÝLÝR. DATA KATMANINDAKÝ OLUÞTURMA KOMUTU INSERT ÝKEN BU KATMANDA BUNU CREATE ÝLE GERÇEKLEÞTÝRMEKTEYÝZ

CREATE TABLE Ilceler
(
ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
IlceAdi varchar(50)
)

-- TABLO VE ÜST SEGMENTLERDE(DATABASE SEGMENTÝ GÝBÝ, FUNCTION, TRIGGER, STORE PROCEDURE GÝBÝ) GÜNCELLEÞTÝRME ÝÞLEMÝ YAPABÝLMEMÝZ ÝÇÝN ALTER KOMUTUNU KULLANMAKTAYIZ. DATA SEGMENTÝNDE BU ÝÞLEMÝ UPDATE KOMUTU ÝLE YAPACAÐIZ.
ALTER TABLE Ilceler
ADD IlceMerkezi varchar(50) -- ADD KOMUTU ÝLE SÜTUN EKLEME ÝÞLEMÝ GERÇEKLEÞTÝRDÝK.

ALTER TABLE Ilceler
ADD Email varchar(50)

ALTER TABLE Ilceler
DROP COLUMN Email --DROP COLUMN DÝYEREK SÝLMEK ÝSTEDÝÐÝMÝZ SÜTUNUN SÝLÝNMESÝ ÝÞLEMÝNÝ GERÇEKLEÞTÝRÝYORUZ. YANÝ DATA KATMANINDAKÝ DELETE KOMUTUNA KARÞILIK GELMEKTEDÝR. 

ALTER TABLE Ilceler
ADD Email varchar(50)

ALTER TABLE Ilceler
ALTER COLUMN Email int -- ALTER COLUMN DÝYEREK ilgili sütunun veri tipi üzerinde deðiþiklik hakkýmýz bulunmaktadýr. Fakat rename iþlemi için store procedure gerekliliði bulunmaktadýr.


SELECT *
FROM Projeler

-- DML ÖRNEKLERÝ


--DATA KATMANINDA TABLOMUZA VERÝ EKLEMEK ÝÇÝN INSERT KOMUTUNU KULLANMAKTAYIZ. ONCE INSERT INTO <tabloadi> girerek prantez açýp (<kolonadi1>,<kolonadi2>,...) ÞEKLÝNDE HANGÝ TABLONUN HANGÝ KOLONLARINA VERÝ GÝRECEÐÝMÝZÝ BELÝRTÝYORUZ. TABÝ BURALARDA NULLABLE'LIK DURUMU ÖNEMLÝDÝR. SONRA VALUES diyip parantez açarak sýrasýyla öncesinde tanýmlamýþ olduðumuz sütunlara deðerlerimizi atýyoruz.
INSERT INTO Projeler (ProjeAdi, Adres, SehirID)
VALUES ('Kanyon AVM', 'Levent', 34)

-- DATA ÜZERÝNDE DEÐÝÞÝKLÝK, GÜNCELLEME, MODÝFÝYE iþlemlerinin gerçekleþtirilebilmesi için UPDATE komutunu kullanmaktayýz. Bu komutun kullanýmý için bize hangi satýrda deðiþiklik gerçekleþtireceðimizi belirten bir unique deðer tutucuya ihtiyaç duymaktayýz. Genelde bu iþlem ID'ler üzerinden gerçekleþtirilir. Kullaným þekli UPDATE <tabloadi> SET <deðiþtirmek istediðimiz datanýn bulunduðu sütun> = <yeni deðer> WHERE <þartýsaðlayansütunadi> = <þart deðeri>
UPDATE Projeler
SET ProjeAdi = 'Kanyon AVM', SehirID = 35, Adres = 'Menemen'
WHERE ProjeID = 4 

--WHERE KOMUTU UPDATE ÝÞLEMÝNÝN YAPILMASI ÝÇÝN GEREKLÝ DEÐÝLDÝR. FAKAT WHERE KULLANILMADAN BÝR UPDATE ÝÞLEMÝ GERÇEKLEÞTÝRÝLDÝÐÝNDE AÞAÐIDA GÖRECEÐÝNÝZ GÝBÝ TABLODAKÝ BÜTÜN KAYITLARI DEÐÝÞTÝRMEKTEDÝR VE BU DA DB YÖNETÝMÝ AÇISINDAN EN SAKINCALI ÝÞLEMLERDEN BÝRÝDÝR.
UPDATE Projeler
SET Adres = 'Maltepe'

INSERT INTO Projeler (ProjeAdi,Adres,SehirID, BaslangicTarihi)
VALUES ('Forum Ýstanbul', 'Bayrampaþa', 34, '2021-12-12')

SELECT *
FROM Projeler


--DELETE ÝÞLEMÝNÝN GERÇEKLEÞMESÝ ÝÇÝN EÐER KÝ ÝLÝÞKÝLÝ TABLOLAR VAR ÝSE ÇOKLU SÝLME ÝÞLEMÝ GERÇEKLEÞMEZ. ÖNCE ÝLÝÞKÝLERÝ AYIRMAK GEREKÝR. FAKAT TEKLÝ SATIR SÝLMEKTE BÝR PROBLEM BULUNMAMAKTADIR. BU DURUMDA DA BÝZE YÝNE UNIQUE DEÐER VEREBÝLECEK BÝR SÜTUN ÜZERÝNDEN WHERE KULLANARAK ÝLGÝLÝ ÞARTI YAZIP O SATIRIN SÝLÝNMESÝNÝ SAÐLAYABÝLÝRÝZ.
DELETE 
FROM Projeler
WHERE ProjeID = 6

-- BU KOMUT DA ÝLÝÞKÝLÝ OLMAYAN SORUNSUZ TABLOLARIN ÝÇERÝSÝNDEKÝ TÜM DATALARIN SÝLÝNMESÝNÝ SAÐLAR. 
DELETE FROM Projeler


CREATE TABLE BosBeles
(
 ID int identity(1,1) primary key,
 BosbelesSutun varchar(50)
)

-- DROP TABLE KOMUTU ÝLE TABLOYU SÝLDÝK.
DROP TABLE BosBeles
