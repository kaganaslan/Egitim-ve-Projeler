--DDL KOMUTLARI �LE �RNEKLER


--CREATE KOMUTU �LE TABLO SEGMENT� VE �ST SEGMENTLERDE OLU�TURMA ��LEM� GER�EKLE�T�R�L�R. DATA KATMANINDAK� OLU�TURMA KOMUTU INSERT �KEN BU KATMANDA BUNU CREATE �LE GER�EKLE�T�RMEKTEY�Z

CREATE TABLE Ilceler
(
ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
IlceAdi varchar(50)
)

-- TABLO VE �ST SEGMENTLERDE(DATABASE SEGMENT� G�B�, FUNCTION, TRIGGER, STORE PROCEDURE G�B�) G�NCELLE�T�RME ��LEM� YAPAB�LMEM�Z ���N ALTER KOMUTUNU KULLANMAKTAYIZ. DATA SEGMENT�NDE BU ��LEM� UPDATE KOMUTU �LE YAPACA�IZ.
ALTER TABLE Ilceler
ADD IlceMerkezi varchar(50) -- ADD KOMUTU �LE S�TUN EKLEME ��LEM� GER�EKLE�T�RD�K.

ALTER TABLE Ilceler
ADD Email varchar(50)

ALTER TABLE Ilceler
DROP COLUMN Email --DROP COLUMN D�YEREK S�LMEK �STED���M�Z S�TUNUN S�L�NMES� ��LEM�N� GER�EKLE�T�R�YORUZ. YAN� DATA KATMANINDAK� DELETE KOMUTUNA KAR�ILIK GELMEKTED�R. 

ALTER TABLE Ilceler
ADD Email varchar(50)

ALTER TABLE Ilceler
ALTER COLUMN Email int -- ALTER COLUMN D�YEREK ilgili s�tunun veri tipi �zerinde de�i�iklik hakk�m�z bulunmaktad�r. Fakat rename i�lemi i�in store procedure gereklili�i bulunmaktad�r.


SELECT *
FROM Projeler

-- DML �RNEKLER�


--DATA KATMANINDA TABLOMUZA VER� EKLEMEK ���N INSERT KOMUTUNU KULLANMAKTAYIZ. ONCE INSERT INTO <tabloadi> girerek prantez a��p (<kolonadi1>,<kolonadi2>,...) �EKL�NDE HANG� TABLONUN HANG� KOLONLARINA VER� G�RECE��M�Z� BEL�RT�YORUZ. TAB� BURALARDA NULLABLE'LIK DURUMU �NEML�D�R. SONRA VALUES diyip parantez a�arak s�ras�yla �ncesinde tan�mlam�� oldu�umuz s�tunlara de�erlerimizi at�yoruz.
INSERT INTO Projeler (ProjeAdi, Adres, SehirID)
VALUES ('Kanyon AVM', 'Levent', 34)

-- DATA �ZER�NDE DE����KL�K, G�NCELLEME, MOD�F�YE i�lemlerinin ger�ekle�tirilebilmesi i�in UPDATE komutunu kullanmaktay�z. Bu komutun kullan�m� i�in bize hangi sat�rda de�i�iklik ger�ekle�tirece�imizi belirten bir unique de�er tutucuya ihtiya� duymaktay�z. Genelde bu i�lem ID'ler �zerinden ger�ekle�tirilir. Kullan�m �ekli UPDATE <tabloadi> SET <de�i�tirmek istedi�imiz datan�n bulundu�u s�tun> = <yeni de�er> WHERE <�art�sa�layans�tunadi> = <�art de�eri>
UPDATE Projeler
SET ProjeAdi = 'Kanyon AVM', SehirID = 35, Adres = 'Menemen'
WHERE ProjeID = 4 

--WHERE KOMUTU UPDATE ��LEM�N�N YAPILMASI ���N GEREKL� DE��LD�R. FAKAT WHERE KULLANILMADAN B�R UPDATE ��LEM� GER�EKLE�T�R�LD���NDE A�A�IDA G�RECE��N�Z G�B� TABLODAK� B�T�N KAYITLARI DE���T�RMEKTED�R VE BU DA DB Y�NET�M� A�ISINDAN EN SAKINCALI ��LEMLERDEN B�R�D�R.
UPDATE Projeler
SET Adres = 'Maltepe'

INSERT INTO Projeler (ProjeAdi,Adres,SehirID, BaslangicTarihi)
VALUES ('Forum �stanbul', 'Bayrampa�a', 34, '2021-12-12')

SELECT *
FROM Projeler


--DELETE ��LEM�N�N GER�EKLE�MES� ���N E�ER K� �L��K�L� TABLOLAR VAR �SE �OKLU S�LME ��LEM� GER�EKLE�MEZ. �NCE �L��K�LER� AYIRMAK GEREK�R. FAKAT TEKL� SATIR S�LMEKTE B�R PROBLEM BULUNMAMAKTADIR. BU DURUMDA DA B�ZE Y�NE UNIQUE DE�ER VEREB�LECEK B�R S�TUN �ZER�NDEN WHERE KULLANARAK �LG�L� �ARTI YAZIP O SATIRIN S�L�NMES�N� SA�LAYAB�L�R�Z.
DELETE 
FROM Projeler
WHERE ProjeID = 6

-- BU KOMUT DA �L��K�L� OLMAYAN SORUNSUZ TABLOLARIN ��ER�S�NDEK� T�M DATALARIN S�L�NMES�N� SA�LAR. 
DELETE FROM Projeler


CREATE TABLE BosBeles
(
 ID int identity(1,1) primary key,
 BosbelesSutun varchar(50)
)

-- DROP TABLE KOMUTU �LE TABLOYU S�LD�K.
DROP TABLE BosBeles
