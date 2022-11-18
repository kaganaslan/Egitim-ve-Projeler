CREATE TABLE Urun
(
UrunNo char(10) PRIMARY KEY not null,
UrunAdi varchar(20) not null,
Fiyat money not null,
Miktar decimal not null
)