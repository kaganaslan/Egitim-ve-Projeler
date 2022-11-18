--Sorgulamalarda genel konsept �udur. Selectten sonra gelen ifadeler sorgulamam�zda hangi s�tunlar�n gelece�ini belirtir. E�er buraya y�ld�z koyarsan�z b�t�n s�tunlardaki datalar gelir.
-- From 'dan sonra gelen ifade hangi tablodan verileri getirece�in ile alakal�d�r.
-- Where 'den sonra yaz�lan ifadeler ise yukar�da belirtti�imiz sorgular i�erisindeki �artlar� ifade eder ve o �art� sa�layan datalar gelir.

SELECT PersonelAdi,PersonelSoyad
FROM Personeller

-- Where komutu ile sorgular�m�zda ko�ullar� kullanmaktay�z. �rne�in bu �rnekte MusteriAdi s�tunu i�erisinde bulunan b�t�n Kemal datalar�n� getirdik.
-- Yine di�er dillerde oldu�u gibi e�ittir, e�it de�ildir, b�y�kt�r, k���kt�r b�y�k e�ittir k���k e�ittir operat�rlerini Where arac�l��� ile kullanmaktay�z.
SELECT *
FROM Musteriler WHERE MusteriAdi='Kemal'

-- Yine di�er programlama dillerinde oldu�u gibi �oklu ko�ullar�n da sorgulanabilmesi m�mk�nd�r. �rne�in a�a��daki �rnekte Hem M��teri Ad� Kemal olan hem de M��teri ID'si 3 olan iki �art� da sa�layan datalar� getirdi.
SELECT *
FROM Musteriler WHERE MusteriAdi='Kemal' AND MusteriID = 3

--Yine ayn� �ekilde OR operat�r� ile hem ad� kemal olan hem de musteri �d'si 3 olan b�t�n datalar� getirdi. Burada tek �art�n sa�lanmas� yeterli oldu.
SELECT *
FROM Musteriler WHERE MusteriAdi='Kemal' OR MusteriID = 3

--�rnek sorgu. M��teri ID'si 1'den b�y�k olan b�t�n datalar� getirdik.
SELECT *
FROM Musteriler WHERE MusteriID>1

-- �rnek Sorgu. Personel Ad� B harfi ile ba�layan datalar� getirelim.

-- Bu �rnekte LIKE komutu ile sorguda aratma yap�yoruz. Y�zde i�areti neredeyse ona g�re arama yap�l�yor. Yani y�zde sonda ise ilk harfi belirtilen ifade ile ba�layan datalar geliyor. ��aret ba�ta ise son harfi belirtilen harf ile biten datalar geliyor.
SELECT *
FROM Personeller
WHERE PersonelAdi LIKE 'B%'
-- Burada ise �rne�in ���nc� harfi � olan datalar� aramak istiyoruz. Fakat datalar�n ka� harften olu�tu�unu bilmiyoruz. Bu gibi durumlarda harf say�s�n� bildi�imiz k�s�mlar i�in alt tire kullanarak aratmak istedi�imiz harfe kadar geliyoruz. ve devam�n�n ka� harften olu�aca��n� bilemedi�imiz i�in sonuna y�zde i�areti ekliyoruz. 
-- ���nc� harfi � olan b�t�n datalar elimize ula�t�.
SELECT *
FROM Personeller
WHERE PersonelAdi LIKE 'b_�%'

-- IN KULLANIMI �LE WHERE KO�ULUNA B�RDEN FAZLA DE�ER ATAMA �MKANIMIZ VARDIR

SELECT *
FROM Konutlar
WHERE OdaSayisi IN (2,4)

SELECT *
FROM Musteriler 
WHERE MusteriAdi IN ('Kemal', 'Berat')

-- JOIN MEVZUSU. DER�N YAPILARDAN OLU�AN VER�TABANLARIMIZDA YAN� �OKLU �L��K�LER�N OLDU�U KARMA�IK VER�TABANI YAPILARIMIZDA �L��K�LER� GENELDE �D DED���M�Z NUMARALAR ARACILI�IYLA KURMAKTAYIZ. ��TE SORGU YAPARKEN B�R TABLODAK� BA�KA TABLODAN GELEN DE�ERLER� G�R�NT�LEMEK �STED���M�ZDE SADECE FROM YAZDIKTAN SONRA GELEN TABLODAK� S�TUNLARI G�REB�LMEKTEY�Z. BU Y�ZDEN BU S�TUNLARDA DAHA �NCE �L��K� ID �ZER�NDEN KURULDU�U ���N G�R�NT�LEYEB�LD���M�Z TEK �EY O TABLODA YER ALAN BA�KA TABLODAN GELEN ID DE�ER� OLMAKTADIR. BU ID DE�ER� YER�NE O BA�KA TABLODAN GELEN �D'N�N ��ARET ETT��� GER�EK DE�ER� G�R�NT�LEYEB�LMEM�Z ���N �L��K�L� OLAN BU �K� TABLOYU B�RLE�T�RMEM�Z GEREKMEKTED�R. ��TE BU SEBEPLE JOIN METODUNU KULLANIYORUZ.

-- Kullan�m �ekli. �NCE SELECT YAZIP ALTINA GE��P FROM D�YORUZ. BURADA GENELDE GENEL OLAN TABLO YAZILIR. SONRA B�RLE�T�RMEK �STED���N�Z TABLOYU �A�IRACA�IZ. BUNUN ���N JOIN YAZIP D��ER TABLONUN ADINI YAZIYORUZ. SONRA ON D�Y�P E��TLEYECE��M�Z DE�ERLER� K� BUNLAR GENELDE ID DE�ERLER� OLUR �K� TABLO ���N E��TL�YORUZ VE JOIN TAMAMLANMI� OLUYOR. BU E��TLEME ��LEM�N�N KOLAY OLMASI ���N AYNI ZAMANDA SELECT �FADES�NDEK� KARI�IKLIKLARIN G�DER�LMES� ���N FROM DED�KTEN SONRA VE JOIN DED�KTEN SONRA AS �FADES� KULLANILARAK TABLO ADLARININ KISALTMASI YAZILIR. VE ARTIK BU �FADE YAZILIP NOKTA KONULARAK ��ERS�NDEK� B�T�N S�TUNLARA ER���M SA�LANIR.
SELECT K.KonutID, K.KonutTuru, KT.KonutTuru
FROM Konutlar AS K
JOIN KonutTurleri AS KT
ON k.KonutTuru = KT.KonutTurID


