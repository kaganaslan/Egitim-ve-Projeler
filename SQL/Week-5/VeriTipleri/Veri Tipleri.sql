-- Veri Tipleri
--1) Metinsel Ifadeler

-- char : unicode deteklemiyor. char(n) �eklinde olu�turulur. 8000 karaktere kadar de�er alabilir. Belirtilenden az karakter girilse dahi giri� yap�lan boyut kadar yer kaplarlar. �neri: veri giri� boyutu sabit olan datalar i�in kullan�lmas� �nerilir.

-- nchar : unicode destekler. max 4000 karakter.

-- varchar : Chardan fark� nedir? Chardan farkl� olarak verinin boyutu kadar alan kaplamaktad�r. Birbirinden farkl� uzunlukta olan verilerin giri�inde kullan�lmas� �nerilir. varchar(MAX) 2 GB'a kadar alan kullan�m� sa�lar. 8000 karaktere kadar m�sade eder.

-- nvarchar : unicode destekler.  4000 karaktere kadar m�sade eder.

----------------------------------------------------------------------

--2) Binary �fadeler

-- binary : 1 ve 0lar� temsilen ikilik taban veri tipidir. Sabit uzunlukta veri tiplerinde kullan�l�r. 8000 byte'a kadar veri depolar.

-- varbinary girilen karakter kadar yer kaplar. 

-- image : resim dosyalar�n� saklamak i�in kullan�l�r. MAX 2GB'l�k alan depolamas� yapar. Bunun yerine varbinary(MAX) kullan�lmas� daha uygundur. 

----------------------------------------------------------------------

--3) Say�sal veri tipleri

-- bit : Bir byte uzunlu�unda tam say� veri tipi. Genellikle evet/hay�r ayar�nda mant�ksal verileri tutmak i�in kullan�l�r.

-- int : 4 byte b�y�kl���nde , -2 milyar, + 2 milyar aras�nda de�er tutar. 

-- bigint : 8 byte b�y�kl���nde, -2 ^63, 2 ^63 aras� de�er tutar.

-- smallint : 2 byte b�y�kl���nde -32.768, 32768 aras�nda de�er tutar. 

-- tinyint : 1 byte b�y�kl���nde , 0-255 aras�nda de�er tutar.

-- decimal, numeric : �kisinin de kullan�m� ayn�. Bu veri tipinde saklanacak say�n�n basaamak say�s� tan�mlanabilmektedir. -38 ve +38 basamak say�s� aras� verileri depolar. 

----------------------------------------------------------------------

-- 4) Parasal Veri Tipleri

-- money : 8 byte boyutunda, yakla��k olarak -2^64 ile 2^64 aras�nda parasal de�erleri tutar. 4 basama�a kadar duyarl� ondal�k tipli verileri saklamaktad�r.

-- smallmoney : 4 byte uzunlu�unda yakla��k olarak -214.000 ile 214.000 aras� parasal de�erleri tutmak i�in kullan�l�r. 

----------------------------------------------------------------------

-- 5 ) Tarih - Zaman Vs

-- date : YYYY-AA-GG . 3 byte uzunlu�unda veri saklar.

-- smalldatetime : 4 byte uzunlu�unda veri saklar. y�l-ay-g�n ve saat-dakika-saniye-salise �eklinde saklar.

-- datetime : YYYY-AA-GG ve zaman verilerini tutan veri tipi. 1 Ocak 1753 - 31 Aral�k 9999 aras� veriler.

-- time : Sadece saat verilerini tutar. 3-5 byte aras� yer kaplar.

-- datetimeoffset : �lkelere g�re de�i�en zaman fark�n� hesaplay�p tutarken kullan�l�r.
