-- Veri Tipleri
--1) Metinsel Ifadeler

-- char : unicode deteklemiyor. char(n) þeklinde oluþturulur. 8000 karaktere kadar deðer alabilir. Belirtilenden az karakter girilse dahi giriþ yapýlan boyut kadar yer kaplarlar. Öneri: veri giriþ boyutu sabit olan datalar için kullanýlmasý önerilir.

-- nchar : unicode destekler. max 4000 karakter.

-- varchar : Chardan farký nedir? Chardan farklý olarak verinin boyutu kadar alan kaplamaktadýr. Birbirinden farklý uzunlukta olan verilerin giriþinde kullanýlmasý önerilir. varchar(MAX) 2 GB'a kadar alan kullanýmý saðlar. 8000 karaktere kadar müsade eder.

-- nvarchar : unicode destekler.  4000 karaktere kadar müsade eder.

----------------------------------------------------------------------

--2) Binary Ýfadeler

-- binary : 1 ve 0larý temsilen ikilik taban veri tipidir. Sabit uzunlukta veri tiplerinde kullanýlýr. 8000 byte'a kadar veri depolar.

-- varbinary girilen karakter kadar yer kaplar. 

-- image : resim dosyalarýný saklamak için kullanýlýr. MAX 2GB'lýk alan depolamasý yapar. Bunun yerine varbinary(MAX) kullanýlmasý daha uygundur. 

----------------------------------------------------------------------

--3) Sayýsal veri tipleri

-- bit : Bir byte uzunluðunda tam sayý veri tipi. Genellikle evet/hayýr ayarýnda mantýksal verileri tutmak için kullanýlýr.

-- int : 4 byte büyüklüðünde , -2 milyar, + 2 milyar arasýnda deðer tutar. 

-- bigint : 8 byte büyüklüðünde, -2 ^63, 2 ^63 arasý deðer tutar.

-- smallint : 2 byte büyüklüðünde -32.768, 32768 arasýnda deðer tutar. 

-- tinyint : 1 byte büyüklüðünde , 0-255 arasýnda deðer tutar.

-- decimal, numeric : Ýkisinin de kullanýmý ayný. Bu veri tipinde saklanacak sayýnýn basaamak sayýsý tanýmlanabilmektedir. -38 ve +38 basamak sayýsý arasý verileri depolar. 

----------------------------------------------------------------------

-- 4) Parasal Veri Tipleri

-- money : 8 byte boyutunda, yaklaþýk olarak -2^64 ile 2^64 arasýnda parasal deðerleri tutar. 4 basamaða kadar duyarlý ondalýk tipli verileri saklamaktadýr.

-- smallmoney : 4 byte uzunluðunda yaklaþýk olarak -214.000 ile 214.000 arasý parasal deðerleri tutmak için kullanýlýr. 

----------------------------------------------------------------------

-- 5 ) Tarih - Zaman Vs

-- date : YYYY-AA-GG . 3 byte uzunluðunda veri saklar.

-- smalldatetime : 4 byte uzunluðunda veri saklar. yýl-ay-gün ve saat-dakika-saniye-salise þeklinde saklar.

-- datetime : YYYY-AA-GG ve zaman verilerini tutan veri tipi. 1 Ocak 1753 - 31 Aralýk 9999 arasý veriler.

-- time : Sadece saat verilerini tutar. 3-5 byte arasý yer kaplar.

-- datetimeoffset : Ülkelere göre deðiþen zaman farkýný hesaplayýp tutarken kullanýlýr.
