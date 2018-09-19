--sistemde var olan t�m view lar� listelemek i�in
select name,type_desc,create_date from sys.all_views

--belirli bir database deki view lar� listelemek i�in
Use Northwind
go
select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='VIEW'

-----De�i�ken Tan�mlama
--t�m local de�i�kenler tek @ i�areti ile ba�lar. Tan�mlanacak de�i�ken ifadesi @ i�areti ile ba�lay�p tutaca�� de�ere g�re bir isimlendirme yapman�z gerekir. 
--De�i�ken tan�mlamalar�ndA "DECLARE" keyword u kullan�l�r.
declare @ad nvarchar(50)
declare @sayi int,@sayac int, @tarih datetime

--"@@" �ift @ i�areti global de�i�kenler i�in kullan�l�r. Global den kast�m�z sistemin i�inde tan�ml� olan de�i�kenlerdir.
--@@error => ald���n son hatay� verir
--@@identity => eklenen son kayd�n id si verir.

----De�i�kene Veri atama
--1.y�ntem
declare @metin nvarchar(50)='Burcu'

--2. Y�ntem
declare @metin2 nvarchar(50)
set @metin2='Engin'

--3.Y�ntem
declare @metin3 varchar(20)
select @metin3='Bilge Adam'

select @metin + ' ' + @metin2 + ' => ' + @metin3 --Select ile sonu� result penceresinde ��kar
--
print @metin + ' ' + @metin2 -- print ile sonu� messages penceresinde ��kar

----Son Id yi alma
insert into Categories(CategoryName) values('Deneme')
--1.Y�ntem
select @@IDENTITY --ekledi�im verilerde sistem geneline bak�p eklenenin id sini al�r
--2. y�ntem
select SCOPE_IDENTITY() --en son �al��t�r�lan aktifdeki(scope) veriyi al�r
--3.Y�ntem
select IDENT_CURRENT('Categories') --Belirtilen tabloya eklenen son veriyi al�r.

--En g�venli olan scope_identity dir. Session daki id yi bana verir. En g�vensiz olan� ise ident_current, t�m tabloyu geziyor.

---
insert into Categories(CategoryName) values('Deneme2')
declare @id int
select @id=SCOPE_IDENTITY()
insert into Products(ProductName,CategoryID,UnitsInStock) values('Denemenin �r�n�',@id,10)

----IF -Else
--If-else bloklar� alt�ndaki ifadelerde birden fazla kod sat�r�ndan olu�uyor ise begin-end blo�u i�erisinde yaz�lmal�d�r. C# da ki { ... } i�aretine denk gelir.

declare @sayi2 int=5
if @sayi2>10
begin
	print 'Say� 10 dan b�y�k'
end
else
begin
	print 'Say� 10 dan k���k'
end

--- Beverages kategorisine ait olan �r�nlerimden sot�umda nekadar kald�. 1000 nin alt�nda ise yeni sipari� vericem.
declare @stok int
select
	@stok=sum(p.UnitsInStock)
from Categories c
join Products p on c.CategoryID=p.CategoryID
where c.CategoryName='Beverages'
if @stok<1000
begin
	print 'Yeni sipari�ler geldi :D'
	declare @katID int=(select CategoryID from Categories where CategoryName='Beverages')
	update Products set UnitsInStock = UnitsInStock + 50 where CategoryID=@katID
end
else
begin
	print 'Biraz daha beklemen laz�m. �al��anlar�n satar yak�nda :)'
end

--case -- when ?

---While
--Sql de bir �e�it d�ng� bulunmaktad�r. While d�ng�s�... D�ng�de �art ger�ekle�ti�i m�ddet�e begin- end blo�u i�erisindeki kodlar� �al��t�rmaya devam eder. "Break" ve "Continue" ifadeleri sqlde de ge�erlidir. Break d�ng�den ��kmay�, continue d�ng�ye devam etmeyi sa�lar, blok i�erisinde alt sat�r�nda yazan kodlar� �al��t�rmaz. d�ng�y� ba�a alarak devam eder.Yaz�m �ekli:
--while (sart_tanimi)
--begin
---- kodlar
--end

-- 1 den 10 a kadar yazd�rma
declare @sayacim int = 0
while(@sayacim < 10)
begin
	print @sayacim
	--set @sayacim=@sayacim + 1
	set @sayacim += 1
end

--�r�n fiyat ortalamalar� 50 in �st�ne olana kadar her �r�n� %10 zam uygula
while(select avg(UnitPrice) from Products)<50
begin
	update Products set UnitPrice=(UnitPrice*0.1)+UnitPrice
	if(select avg(UnitPrice) from Products)>50
		break
	else
		continue
end

--
declare @ortalama money=(select avg(UnitPrice) from Products)
while @ortalama<50
begin
	update Products set UnitPrice=(UnitPrice*0.1)+UnitPrice
	if(select avg(UnitPrice) from Products)>50
		break
	else
		set @ortalama=(select avg(UnitPrice) from Products)
		continue
end

select avg(UnitPrice) from Products

--
declare @sayac2 int = 0
while @sayac2 < 1000
begin
	update Products set UnitPrice=(UnitPrice*0.1)+UnitPrice
	if(select avg(UnitPrice) from Products)>50
		break
	else
		set @sayac2+=1
		continue
end

select avg(UnitPrice) from Products
----------
--Exists (VarM� YokMu)
Use Northwind
go
if exists(select * from sys.tables where name='Categories')
begin
	print 'Tablo Var!'
end
else
begin
	print 'Tablo Yok!'
end

declare @deger varchar(20)='Elektronik'
if exists(select * from Categories where CategoryName=@deger)
begin
	print 'Kategorim mevcut!'
end
else
begin
	print 'Kategori yoki eklemen laz�m!'
end


-----STORE PROCEDURE (SAKLI YORDAM)
--select, update, delete, insert gibi i�lemleri �al��t�rmak i�i kulland���m y�ntemlerden biridir. SP ler bir kere derlenir ve bir daha derlenmeye ihtiya� duymazlar. Veritaban�nda haz�r beklerler. 
--�rne�in bir insert komutu �al��t�r�ld���nda arka planda 5 a�amadan ge�er.
--1) Parse => SQL ifadesinin syntax � kontrol edilir.
--2) Resolve => SQL ifadesinde tablo ya da kolonlar�n varl��� kontrol edilir.
--3) Optimize => Sonuca en �abuk nas�l giderim, ona karar verir.
--4) Compile => SQL ifadesi derlenir.
--5) Execute SQL ifadesi �al��t�r�l�r.

--Bir sorguyu �al��t�rd���n�z da yukar�da yazan 5 a�amay�da her defas�nda tekrar kontrol eder. Fakat yazd���m�zda SQL ifadesini store procedure i�erisinde yaz�p veritaban�na kaydetti�imizde, ilk �al��t���nda t�m 5 a�amay� yapar. Di�erlerinde direk 5. a�amadaki execute dan itibaren i�lem g�rmeye ba�lar. Bu sebeple daha h�zl�d�r. 
--Parametre almaya ya da geri d�nd�rmeye olanak sa�lar. Bu sebeple de daha g�venlidir. D��ar�dan elen de�erlerin nekadar� i�leme tabi tutulacaksa o kadar� i�lem g�r�r.
--Yaz�m �ekli:
--create procedure(proc) sp_Adi
--(var ise de�i�ken)
--as
--begin
---kodlar
--end

--Shippers tablosuna veri ekleyen procedure
alter proc sp_ShippersAdd
(
@name nvarchar(40),
@phone nvarchar(20)
)
as
begin
	insert into Shippers(CompanyName,Phone) values(@name,@phone)
	select * from Shippers
end

--Store procedure �al��t�rmak i�in 3 farkl� y�ntem var
execute sp_ShippersAdd 'Mng','9999999999'
exec sp_ShippersAdd 'Mng','999999999'
sp_ShippersAdd 'Mng','999999999'

--Parametrelerin �r�n ad�, stok, fiyat, kategori adi. �r�n� ekleyecek. 

alter proc sp_ProductAdd
(
@procName varchar(20),
@stock int,
@price money,
@catNAme varchar(20)
)
as
begin
declare @catID int
	if exists(select * from Categories where CategoryName=@catNAme)
	begin
		set @catID=(select CategoryID from Categories where CategoryName=@catNAme)
		insert into Products(ProductName,UnitPrice,UnitsInStock,CategoryID)values(@procName,@stock,@price,@catID)
	end
	else
	begin
		print '�yle bir kategori kay�tl� de�il'
	end
	select * from Products where CategoryID=@catID
end

exec sp_ProductAdd 'Etek',100,25,'Denene'

-- D��ar�dan gelen ProductID sine g�re stock ve adi n� d��ar� d�nd�ren procedure

alter proc sp_AdetDondur
(
@id int,
@adet int output,
@ad varchar(20) output
)
as
begin
	select @adet = UnitsInStock, @ad=ProductName from Products where ProductID=@id
end

--Test
declare @urunStok int,@adi varchar(20)
exec sp_AdetDondur 4, @urunStok output,@adi output
select @urunStok , @adi

--




alter proc sp_CategoryAdd(
	@name varchar(20),
	@id int output
)as
begin
	if exists(select * from Categories where CategoryName=@name)
	begin
		select @id=CategoryID from Categories where CategoryName=@name
	end
	else
	begin
		insert into Categories (CategoryName) values (@name)
		select @id=SCOPE_IDENTITY()
	end
end
--
create proc sp_ProductAdd2(
@procName varchar(20),
@stock int,
@price money,
@catName varchar(20)
)as
begin
	declare @catID int
	exec sp_CategoryAdd @catName, @catID output
	insert into Products(ProductName,UnitPrice,UnitsInStock,CategoryID)values(@procName,@stock,@price,@catID)
	select * from Products where CategoryID=@catID
end

exec sp_ProductAdd2 'Kola',100,25,'��ecek'