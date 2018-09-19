--sistemde var olan tüm view larý listelemek için
select name,type_desc,create_date from sys.all_views

--belirli bir database deki view larý listelemek için
Use Northwind
go
select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='VIEW'

-----Deðiþken Tanýmlama
--tüm local deðiþkenler tek @ iþareti ile baþlar. Tanýmlanacak deðiþken ifadesi @ iþareti ile baþlayýp tutacaðý deðere göre bir isimlendirme yapmanýz gerekir. 
--Deðiþken tanýmlamalarýndA "DECLARE" keyword u kullanýlýr.
declare @ad nvarchar(50)
declare @sayi int,@sayac int, @tarih datetime

--"@@" çift @ iþareti global deðiþkenler için kullanýlýr. Global den kastýmýz sistemin içinde tanýmlý olan deðiþkenlerdir.
--@@error => aldýðýn son hatayý verir
--@@identity => eklenen son kaydýn id si verir.

----Deðiþkene Veri atama
--1.yöntem
declare @metin nvarchar(50)='Burcu'

--2. Yöntem
declare @metin2 nvarchar(50)
set @metin2='Engin'

--3.Yöntem
declare @metin3 varchar(20)
select @metin3='Bilge Adam'

select @metin + ' ' + @metin2 + ' => ' + @metin3 --Select ile sonuç result penceresinde çýkar
--
print @metin + ' ' + @metin2 -- print ile sonuç messages penceresinde çýkar

----Son Id yi alma
insert into Categories(CategoryName) values('Deneme')
--1.Yöntem
select @@IDENTITY --eklediðim verilerde sistem geneline bakýp eklenenin id sini alýr
--2. yöntem
select SCOPE_IDENTITY() --en son çalýþtýrýlan aktifdeki(scope) veriyi alýr
--3.Yöntem
select IDENT_CURRENT('Categories') --Belirtilen tabloya eklenen son veriyi alýr.

--En güvenli olan scope_identity dir. Session daki id yi bana verir. En güvensiz olaný ise ident_current, tüm tabloyu geziyor.

---
insert into Categories(CategoryName) values('Deneme2')
declare @id int
select @id=SCOPE_IDENTITY()
insert into Products(ProductName,CategoryID,UnitsInStock) values('Denemenin Ürünü',@id,10)

----IF -Else
--If-else bloklarý altýndaki ifadelerde birden fazla kod satýrýndan oluþuyor ise begin-end bloðu içerisinde yazýlmalýdýr. C# da ki { ... } iþaretine denk gelir.

declare @sayi2 int=5
if @sayi2>10
begin
	print 'Sayý 10 dan büyük'
end
else
begin
	print 'Sayý 10 dan küçük'
end

--- Beverages kategorisine ait olan ürünlerimden sotðumda nekadar kaldý. 1000 nin altýnda ise yeni sipariþ vericem.
declare @stok int
select
	@stok=sum(p.UnitsInStock)
from Categories c
join Products p on c.CategoryID=p.CategoryID
where c.CategoryName='Beverages'
if @stok<1000
begin
	print 'Yeni sipariþler geldi :D'
	declare @katID int=(select CategoryID from Categories where CategoryName='Beverages')
	update Products set UnitsInStock = UnitsInStock + 50 where CategoryID=@katID
end
else
begin
	print 'Biraz daha beklemen lazým. Çalýþanlarýn satar yakýnda :)'
end

--case -- when ?

---While
--Sql de bir çeþit döngü bulunmaktadýr. While döngüsü... Döngüde þart gerçekleþtiði müddetçe begin- end bloðu içerisindeki kodlarý çalýþtýrmaya devam eder. "Break" ve "Continue" ifadeleri sqlde de geçerlidir. Break döngüden çýkmayý, continue döngüye devam etmeyi saðlar, blok içerisinde alt satýrýnda yazan kodlarý çalýþtýrmaz. döngüyü baþa alarak devam eder.Yazým þekli:
--while (sart_tanimi)
--begin
---- kodlar
--end

-- 1 den 10 a kadar yazdýrma
declare @sayacim int = 0
while(@sayacim < 10)
begin
	print @sayacim
	--set @sayacim=@sayacim + 1
	set @sayacim += 1
end

--Ürün fiyat ortalamalarý 50 in üstüne olana kadar her ürünü %10 zam uygula
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
--Exists (VarMý YokMu)
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
	print 'Kategori yoki eklemen lazým!'
end


-----STORE PROCEDURE (SAKLI YORDAM)
--select, update, delete, insert gibi iþlemleri çalýþtýrmak içi kullandýðým yöntemlerden biridir. SP ler bir kere derlenir ve bir daha derlenmeye ihtiyaç duymazlar. Veritabanýnda hazýr beklerler. 
--Örneðin bir insert komutu çalýþtýrýldýðýnda arka planda 5 aþamadan geçer.
--1) Parse => SQL ifadesinin syntax ý kontrol edilir.
--2) Resolve => SQL ifadesinde tablo ya da kolonlarýn varlýðý kontrol edilir.
--3) Optimize => Sonuca en çabuk nasýl giderim, ona karar verir.
--4) Compile => SQL ifadesi derlenir.
--5) Execute SQL ifadesi çalýþtýrýlýr.

--Bir sorguyu çalýþtýrdýðýnýz da yukarýda yazan 5 aþamayýda her defasýnda tekrar kontrol eder. Fakat yazdýðýmýzda SQL ifadesini store procedure içerisinde yazýp veritabanýna kaydettiðimizde, ilk çalýþtýðýnda tüm 5 aþamayý yapar. Diðerlerinde direk 5. aþamadaki execute dan itibaren iþlem görmeye baþlar. Bu sebeple daha hýzlýdýr. 
--Parametre almaya ya da geri döndürmeye olanak saðlar. Bu sebeple de daha güvenlidir. Dýþarýdan elen deðerlerin nekadarý iþleme tabi tutulacaksa o kadarý iþlem görür.
--Yazým Þekli:
--create procedure(proc) sp_Adi
--(var ise deðiþken)
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

--Store procedure çalýþtýrmak için 3 farklý yöntem var
execute sp_ShippersAdd 'Mng','9999999999'
exec sp_ShippersAdd 'Mng','999999999'
sp_ShippersAdd 'Mng','999999999'

--Parametrelerin ürün adý, stok, fiyat, kategori adi. Ürünü ekleyecek. 

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
		print 'Öyle bir kategori kayýtlý deðil'
	end
	select * from Products where CategoryID=@catID
end

exec sp_ProductAdd 'Etek',100,25,'Denene'

-- Dýþarýdan gelen ProductID sine göre stock ve adi ný dýþarý döndüren procedure

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

exec sp_ProductAdd2 'Kola',100,25,'Ýçecek'