-- STORED PROCEDURE --
-- Genellikle rutinleþmiþ iþlemlerin kolayca yapýlmasýný saðlamak için gerçekleþtirilen kod bloklarý.
-- Ýlk kez çalýþtýklarý zaman derlenirler. Daha sonra çalýþtýrýldýklarýnda tekrar derlenmezler. Dolayýsýyl performans kazancý saðlarlar.
-- Kaydedilebilen ve tekrar çaðrýlabilen sql kod bloklarý olarak tanýmlayabiliriz.
-- TANIMLAMA yapýlýp kaydedildiken sonra EXEC keywordu ile çaðrýlýrlar.

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

EXEC dbo.SearchEmployee 'özkaya'



