--Hangi (Supplier)tedarik�eden en fazla(order Details.Quantity + product.Units�nstock) hangi �r�n(ProductName) temin edilmi�tir
select tablo1.CompanyName,tablo2.ProductName,tablo1.MaxToplam
from(
	select
		t1.CompanyName,
		max(t1.SatilanToplam) as MaxToplam
	from(
		select
			s.CompanyName,
			p.ProductName,
			sum(od.Quantity) + p.UnitsInStock as SatilanToplam
		from Suppliers s
		join Products p on s.SupplierID=p.SupplierID
		join [Order Details] od on p.ProductID=od.ProductID
		group by s.CompanyName,p.ProductName, p.UnitsInStock
	) as t1
	group by t1.CompanyName
) as tablo1
join (
		select
			s.CompanyName,
			p.ProductName,
			sum(od.Quantity) + p.UnitsInStock as SatilanToplam
		from Suppliers s
		join Products p on s.SupplierID=p.SupplierID
		join [Order Details] od on p.ProductID=od.ProductID
		group by s.CompanyName,p.ProductName, p.UnitsInStock
) as tablo2 on tablo1.CompanyName=tablo2.CompanyName and tablo1.MaxToplam=tablo2.SatilanToplam

--view la�t�rma
create view vw_SupplierMaxProduct
as
	select tablo1.CompanyName,tablo2.ProductName,tablo1.MaxToplam
from(
	select
		t1.CompanyName,
		max(t1.SatilanToplam) as MaxToplam
	from(
		select
			s.CompanyName,
			p.ProductName,
			sum(od.Quantity) + p.UnitsInStock as SatilanToplam
		from Suppliers s
		join Products p on s.SupplierID=p.SupplierID
		join [Order Details] od on p.ProductID=od.ProductID
		group by s.CompanyName,p.ProductName, p.UnitsInStock
	) as t1
	group by t1.CompanyName
) as tablo1
join (
		select
			s.CompanyName,
			p.ProductName,
			sum(od.Quantity) + p.UnitsInStock as SatilanToplam
		from Suppliers s
		join Products p on s.SupplierID=p.SupplierID
		join [Order Details] od on p.ProductID=od.ProductID
		group by s.CompanyName,p.ProductName, p.UnitsInStock
) as tablo2 on tablo1.CompanyName=tablo2.CompanyName and tablo1.MaxToplam=tablo2.SatilanToplam
--
select * from vw_SupplierMaxProduct where ProductName='Chang'

---ProductName,UnitPrice,UnitsInStock,CategoryName bilgileri d��ardan gelen parametreleri products tablosuna kaydeden procedure. Not:// Belirtilen kategori yoksa kategoriyi Categories tablosuna ekleyip id sini alan, varsa sadece id sini alan ekstradan bir procedure daha yap�n.


create proc sp_IdBul
(
	@catName varchar(20),
	@id int output -- D��ar� giden parametre. ��indeki de�er procedure un i�inde belirlenip procedure un d���na ��kacak demek
)
as 
begin
	if exists(select * from Categories where CategoryName=@catName)
	begin
		set @id=(select CategoryID from Categories where CategoryName=@catName)
	end
	else
	begin
		insert into Categories(CategoryName) values(@catName)
		select @id=SCOPE_IDENTITY()
	end
end

--
alter proc sp_UrunEkle
(
	@procName varchar(20),
	@price money,
	@stock int,
	@catName varchar(20)
)as
begin
	declare @catID int
	exec sp_IdBul @catName,@catID output
	if not exists(select * from Products p where p.ProductName=@procName)
	begin
	insert into Products(ProductName,UnitPrice,UnitsInStock,CategoryID) values(@procName,@price,@stock,@catID)
	end
	else
	begin
		update Products set UnitPrice=@price, UnitsInStock+=@stock where ProductName=@procName
	end
end
--Procedure �al��t�rmak
exec sp_UrunEkle 'Mouse',120,1100,'Bilgisayar'

select ProductName from Products

--Execute kullan�m�
alter proc sp_ExecKullanimi
as
begin
declare @sorgu varchar(300)
set @sorgu=('select ProductName from Products')
exec (@sorgu)
end
---Test
exec sp_ExecKullanimi

--
create proc sp_TabloOlust�r2

as
begin

create table DenemeTablom
(
	id int primary key identity(1,1),
	name varchar(20)
)
end

--Tablo olu�turma(Parametreli)
alter proc sp_TabloOlust�r
(
@tabloAdi varchar(20),
@isim varchar(20)
)
as
begin
declare @sorgu varchar(500)
set @sorgu=('
create table '+@tabloAdi+'
(
	id int primary key identity(1,1),
	name varchar(20) not null
)
')
exec (@sorgu)
declare @sorgu2 varchar(500)
set @sorgu2=('
insert into ' +@tabloAdi+' (name) values('''+ @isim+ ''')
')
exec (@sorgu2)
end

exec sp_TabloOlust�r 'Deneme','Burcu'

--Tablo ad�n�, 3 kolonun ad�n� ve o alanlara ait tipleri d��ardan parametre olarak alabilece�im, procedure u olu�turunuz. Herparametre bir string ifade olarak d���n�n :D
create proc sp_TabloOlusturma
(
	@tabloAdi varchar(20),
	@kolonAdi1 varchar(20),
	@tipi1 varchar(20),
	@kolonAdi2 varchar(20),
	@tipi2 varchar(20),
	@kolonAdi3 varchar(20),
	@tipi3 varchar(20)
) as
begin
	declare @sonuc varchar(500)
	set @sonuc=('
		create table ' + @tabloAdi +'
		(
			' +@kolonAdi1+ ' '+ @tipi1 + ',
			' +@kolonAdi2+ ' ' + @tipi2+ ',
			' +@kolonAdi3+ ' ' + @tipi3 + '
		)
	')
	exec (@sonuc)
end
---
exec sp_TabloOlusturma 'Calismaca','ID','int','FirstName','varchar(20)','LastName','varchar(20)'

--D��ar�dan girilen productId lerine ait �r�n bilgilerim gelsin. Ama ka� tane ProductID si yollanaca��n� bilmiyorum :(

create proc sp_UrunGetir
(
	@IDler varchar(50)
)as
begin
	declare @sonuc varchar(200)
	set @sonuc=('select ProductName from Products where ProductID in('+@IDler+')')
	exec (@sonuc)
end


exec sp_UrunGetir '1,75,54,65,98'

--(Database de var olan)Girilen CategoryName ine g�re indirim mi zamm� yapaca�� bilgisini al�p ona g�re o kategoriye ait �r�nlerin fiyatlar�n� g�ncelleyen procedure

alter proc sp_FiyatGuncelle
(
	@catName varchar(50),
	@process varchar(10),
	@oran int
) as
begin
	if @process='zam'
	begin
		update Products set UnitPrice=(UnitPrice+((UnitPrice*@oran)/100)) where CategoryID =(select c.CategoryID from Categories c where c.CategoryName=@catName)
	end
	else
	begin
	update Products set UnitPrice=(UnitPrice-((UnitPrice*@oran)/100)) where CategoryID =(select c.CategoryID from Categories c where c.CategoryName=@catName)
	end
	select p.ProductName,p.UnitPrice from Categories c join Products p on c.CategoryID=p.CategoryID where c.CategoryName=@catName
end

exec sp_FiyatGuncelle 'Condiments','indirim', 20