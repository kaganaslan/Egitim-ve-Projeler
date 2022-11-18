-- STORED PROCEDURE --
-- Genellikle rutinle�mi� i�lemlerin kolayca yap�lmas�n� sa�lamak i�in ger�ekle�tirilen kod bloklar�.
-- �lk kez �al��t�klar� zaman derlenirler. Daha sonra �al��t�r�ld�klar�nda tekrar derlenmezler. Dolay�s�yl performans kazanc� sa�larlar.
-- Kaydedilebilen ve tekrar �a�r�labilen sql kod bloklar� olarak tan�mlayabiliriz.
-- TANIMLAMA yap�l�p kaydedildiken sonra EXEC keywordu ile �a�r�l�rlar.

--deneme store procedure

CREATE PROCEDURE dbo.Bas
AS 
BEGIN
    SELECT 'S.A'
END

EXEC dbo.Bas


CREATE PROC dbo.SearchEmployee
(
@EmployeeName VARCHAR(50)
)
AS
BEGIN 
SELECT * FROM Personeller WHERE PersonelTamAdi LIKE '%' + @EmployeeName +'%'
END

EXEC dbo.SearchEmployee '�zkaya'



