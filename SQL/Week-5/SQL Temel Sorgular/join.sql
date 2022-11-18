SELECT *
FROM Siparisler 


SELECT TOP 3 s.SiparisNo, s.SiparisTarihi, u.UrunAdi As �r�n , k.KategoriAdi, M.MusteriAdi
FROM Siparisler AS S
JOIN Urunler AS U
ON U.UrunNo = S.Urun
JOIN Musteriler AS M
ON M.MusteriNo = s.Musteri
JOIN Kategoriler AS K
on k.KategoriID = u.UrunKategorisi
ORDER BY s.SiparisNo DESC


SELECT TOP 1 s.SiparisNo, s.SiparisTarihi, u.UrunAdi AS �r�n , k.KategoriAdi, M.MusteriAdi
FROM Siparisler AS S
JOIN Urunler AS U
ON U.UrunNo = S.Urun
JOIN Musteriler AS M
ON M.MusteriNo = s.Musteri
JOIN Kategoriler AS K
on k.KategoriID = u.UrunKategorisi
WHERE k.KategoriAdi = 'G�da'
