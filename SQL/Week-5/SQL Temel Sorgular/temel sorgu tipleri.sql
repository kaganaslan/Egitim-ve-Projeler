--Sorgulamalarda genel konsept þudur. Selectten sonra gelen ifadeler sorgulamamýzda hangi sütunlarýn geleceðini belirtir. Eðer buraya yýldýz koyarsanýz bütün sütunlardaki datalar gelir.
-- From 'dan sonra gelen ifade hangi tablodan verileri getireceðin ile alakalýdýr.
-- Where 'den sonra yazýlan ifadeler ise yukarýda belirttiðimiz sorgular içerisindeki þartlarý ifade eder ve o þartý saðlayan datalar gelir.

SELECT PersonelAdi,PersonelSoyad
FROM Personeller

-- Where komutu ile sorgularýmýzda koþullarý kullanmaktayýz. Örneðin bu örnekte MusteriAdi sütunu içerisinde bulunan bütün Kemal datalarýný getirdik.
-- Yine diðer dillerde olduðu gibi eþittir, eþit deðildir, büyüktür, küçüktür büyük eþittir küçük eþittir operatörlerini Where aracýlýðý ile kullanmaktayýz.
SELECT *
FROM Musteriler WHERE MusteriAdi='Kemal'

-- Yine diðer programlama dillerinde olduðu gibi çoklu koþullarýn da sorgulanabilmesi mümkündür. Örneðin aþaðýdaki örnekte Hem Müþteri Adý Kemal olan hem de Müþteri ID'si 3 olan iki þartý da saðlayan datalarý getirdi.
SELECT *
FROM Musteriler WHERE MusteriAdi='Kemal' AND MusteriID = 3

--Yine ayný þekilde OR operatörü ile hem adý kemal olan hem de musteri ýd'si 3 olan bütün datalarý getirdi. Burada tek þartýn saðlanmasý yeterli oldu.
SELECT *
FROM Musteriler WHERE MusteriAdi='Kemal' OR MusteriID = 3

--Örnek sorgu. Müþteri ID'si 1'den büyük olan bütün datalarý getirdik.
SELECT *
FROM Musteriler WHERE MusteriID>1

-- Örnek Sorgu. Personel Adý B harfi ile baþlayan datalarý getirelim.

-- Bu örnekte LIKE komutu ile sorguda aratma yapýyoruz. Yüzde iþareti neredeyse ona göre arama yapýlýyor. Yani yüzde sonda ise ilk harfi belirtilen ifade ile baþlayan datalar geliyor. Ýþaret baþta ise son harfi belirtilen harf ile biten datalar geliyor.
SELECT *
FROM Personeller
WHERE PersonelAdi LIKE 'B%'
-- Burada ise örneðin üçüncü harfi ð olan datalarý aramak istiyoruz. Fakat datalarýn kaç harften oluþtuðunu bilmiyoruz. Bu gibi durumlarda harf sayýsýný bildiðimiz kýsýmlar için alt tire kullanarak aratmak istediðimiz harfe kadar geliyoruz. ve devamýnýn kaç harften oluþacaðýný bilemediðimiz için sonuna yüzde iþareti ekliyoruz. 
-- Üçüncü harfi ð olan bütün datalar elimize ulaþtý.
SELECT *
FROM Personeller
WHERE PersonelAdi LIKE 'b_ð%'

-- IN KULLANIMI ÝLE WHERE KOÞULUNA BÝRDEN FAZLA DEÐER ATAMA ÝMKANIMIZ VARDIR

SELECT *
FROM Konutlar
WHERE OdaSayisi IN (2,4)

SELECT *
FROM Musteriler 
WHERE MusteriAdi IN ('Kemal', 'Berat')

-- JOIN MEVZUSU. DERÝN YAPILARDAN OLUÞAN VERÝTABANLARIMIZDA YANÝ ÇOKLU ÝLÝÞKÝLERÝN OLDUÐU KARMAÞIK VERÝTABANI YAPILARIMIZDA ÝLÝÞKÝLERÝ GENELDE ÝD DEDÝÐÝMÝZ NUMARALAR ARACILIÐIYLA KURMAKTAYIZ. ÝÞTE SORGU YAPARKEN BÝR TABLODAKÝ BAÞKA TABLODAN GELEN DEÐERLERÝ GÖRÜNTÜLEMEK ÝSTEDÝÐÝMÝZDE SADECE FROM YAZDIKTAN SONRA GELEN TABLODAKÝ SÜTUNLARI GÖREBÝLMEKTEYÝZ. BU YÜZDEN BU SÜTUNLARDA DAHA ÖNCE ÝLÝÞKÝ ID ÜZERÝNDEN KURULDUÐU ÝÇÝN GÖRÜNTÜLEYEBÝLDÝÐÝMÝZ TEK ÞEY O TABLODA YER ALAN BAÞKA TABLODAN GELEN ID DEÐERÝ OLMAKTADIR. BU ID DEÐERÝ YERÝNE O BAÞKA TABLODAN GELEN ÝD'NÝN ÝÞARET ETTÝÐÝ GERÇEK DEÐERÝ GÖRÜNTÜLEYEBÝLMEMÝZ ÝÇÝN ÝLÝÞKÝLÝ OLAN BU ÝKÝ TABLOYU BÝRLEÞTÝRMEMÝZ GEREKMEKTEDÝR. ÝÞTE BU SEBEPLE JOIN METODUNU KULLANIYORUZ.

-- Kullaným þekli. ÖNCE SELECT YAZIP ALTINA GEÇÝP FROM DÝYORUZ. BURADA GENELDE GENEL OLAN TABLO YAZILIR. SONRA BÝRLEÞTÝRMEK ÝSTEDÝÐÝNÝZ TABLOYU ÇAÐIRACAÐIZ. BUNUN ÝÇÝN JOIN YAZIP DÝÐER TABLONUN ADINI YAZIYORUZ. SONRA ON DÝYÝP EÞÝTLEYECEÐÝMÝZ DEÐERLERÝ KÝ BUNLAR GENELDE ID DEÐERLERÝ OLUR ÝKÝ TABLO ÝÇÝN EÞÝTLÝYORUZ VE JOIN TAMAMLANMIÞ OLUYOR. BU EÞÝTLEME ÝÞLEMÝNÝN KOLAY OLMASI ÝÇÝN AYNI ZAMANDA SELECT ÝFADESÝNDEKÝ KARIÞIKLIKLARIN GÝDERÝLMESÝ ÝÇÝN FROM DEDÝKTEN SONRA VE JOIN DEDÝKTEN SONRA AS ÝFADESÝ KULLANILARAK TABLO ADLARININ KISALTMASI YAZILIR. VE ARTIK BU ÝFADE YAZILIP NOKTA KONULARAK ÝÇERSÝNDEKÝ BÜTÜN SÜTUNLARA ERÝÞÝM SAÐLANIR.
SELECT K.KonutID, K.KonutTuru, KT.KonutTuru
FROM Konutlar AS K
JOIN KonutTurleri AS KT
ON k.KonutTuru = KT.KonutTurID


