-----Having
--Grupland�rma yaparken sorguda bir ko�ulun verilmesi gerekiyorsa devreye girer. Having kelimesiyle group by ile gruplanan kay�tlar �zerinde k�s�tlama yapmam� sa�lar. Having varsa group by kullan�lmal�d�r. Yaz�m �ekli:
--select 
--sutun(lar)
--from tablo(lar)
--group by sutun(lar)
--having grup_kisitlamasi

---Having Kurallar�
--1) Select komutunda group by yok ise having kullanamazs�n�z
--2) having s�zc���nden sonra aggregate fonksiyonlardan en az biri kullan�lmal�d�r
--3) having sadece gruplanm�� kay�tlar i�in kullan�l�r
--4) select sorgusunda where komutu da kullan�labilir. Fark�, where bir tablonun bir sat�r� �zerinde o ko�ulu ararken, having gruplanm�� kay�tlar i�inde o ko�ulu arar.

--�al��anlar�mdan �u ana kadar vermi� oldu�u sipari� say�s� 100 � ge�enleri listeleyiniz
select
	e.FirstName + ' ' + e.LastName as FullName,
	count(o.OrderID) as SiparisSayisi
from Employees e
join Orders o on e.EmployeeID=o.EmployeeID
group by e.FirstName + ' ' + e.LastName
having count(o.OrderID)>100
--Eski Y�ntem
select
*
from(
	select
		e.FirstName + ' ' + e.LastName as FullName,
		count(o.OrderID) as SiparisSayisi
	from Employees e
	join Orders o on e.EmployeeID=o.EmployeeID
	group by e.FirstName + ' ' + e.LastName
) as t1
where t1.SiparisSayisi>100

--8-20'den fazla kez siparis edilmis olan urun sipari�leri hangi �lkelerden verilmi�tir.
select distinct
	tablo2.ShipCountry
from(
	select
		t1.ProductName,
		count(t1.OrderID) as Sayi
	from (
		select
			o.ShipCountry,
			p.ProductName,
			o.OrderID
		from Orders o
		join [Order Details] od on o.OrderID=od.OrderID
		join Products p on od.ProductID=p.ProductID
	) as t1
	group by t1.ProductName
	having count(t1.OrderID)>20
) as tablo1
join(
	select
		o.ShipCountry,
		p.ProductName,
		o.OrderID
	from Orders o
	join [Order Details] od on o.OrderID=od.OrderID
	join Products p on od.ProductID=p.ProductID	
)as tablo2 on tablo1.ProductName=tablo2.ProductName

--Ortalama sat�� fiyat�n�n �st�nde olan sipari�lerimi getiriniz (OrderID,OrderDate,Total)

select
	o.OrderID,o.OrderDate,
	sum(od.UnitPrice*od.Quantity) as Tutar
from [Order Details] od
join Orders o on od.OrderID=o.OrderID
group by o.OrderID,o.OrderDate
having sum(od.UnitPrice*od.Quantity)>(
	select
		avg(Toplam) as Ortalama
	from(
		select
			od.OrderID, sum(od.UnitPrice*od.Quantity)as Toplam
		from [Order Details] od
		group by od.OrderID
	)as t1
)

--�r�n baz� olarak ortalama sat�� adedinin �zerinde sat�lan �r�nleri getiriniz
select
	p.ProductName,
	sum(od.Quantity) as ToplamAdet
from [Order Details] od
join Products p on od.ProductID=p.ProductID
group by p.ProductName
having sum(od.Quantity)>(
	select
		avg(t1.ToplamAdet) as OrtalamaAdet
	from(
		select
			od.ProductID,
			sum(od.Quantity) as ToplamAdet
		from [Order Details] od
		group by od.ProductID
	) as t1
)
--en pahal� �r�n�mden elde etti�im ciro nekadard�r
select
	p.ProductName,
	sum((od.UnitPrice*od.Quantity)*(1-od.Discount)) as ToplamCiro
from [Order Details] od
join Products p on od.ProductID=p.ProductID
where p.UnitPrice=(
	select
		max(p.UnitPrice)
	from Products p
)
group by p.ProductName


----VIEW
--Yaz�m �ekli:
--create => Yaratmak
--Alter => D�zenlemek
--drop => Silmek
--create view View_Adi(vw_)
--as
--begin
--sorgu
--end

alter view vw_ProductName
as
select p.ProductName,p.UnitPrice from Products p

--View � �al��t�rmak i�in
select * from vw_ProductName

--View lar birden fazla tablonun istenilen verilerini sunabilmek i�in ilgili sorguyu veritaban� i�erisine kaydetti�imiz yap�lard�r. View lar� veri saklamaz. �lgili kodlar view i�erisinde veri taban�na kaydedilir. Yani veritaan�nda sanal tablo olu�turdu�umuzu s�yleyebiliriz. Kompleks bir sorguyu �al��t�rmak i�in tekrar tekrar yazmak yerine o sorguyu view olarak veri taban�na kaydedebiliriz.
--Not:// View i�erisinde order by kullanabilmek i�in bir �art vard�r. O da order by ile top keyword unu kullanmak. 
alter view vw_Siparisler
as
--%100 de s�ralama yapm�yor, s�ralama yapmas� i�in 100 den k���k bir de�er belirtmek gerekmekte
select top 99.9999 percent
	o.OrderID,o.OrderDate,o.ShippedDate,p.ProductName,od.UnitPrice,od.Quantity
from Orders o
join [Order Details] od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID
order by p.UnitPrice

go

select * from vw_Siparisler

--
insert into vw_Siparisler(ProductName) values('Deneme')
insert into vw_Siparisler(OrderDate,ShippedDate) values ('2016-08-01','2016-08-10')
--View da Update, Delete, Insert ��lemleri
--1) insert, updatei delete i�inde kullan�lacak alanlar, view i�erisinde olmak zorundad�r.
--2) View i�erisinde join bir yap� kullan�p, o view a insert yapmak isterseniz, yaln�zca 1 tablodaki kolonlara i�lem yapabilirsiniz.
--3) insert, update, delete i�lemlerini yapabilmek i�in, o tablolara ait zorunlu alanlar�n view da olmas� gerekmektedir.
--4)insert, update, delete i�lemlerini yapaca��n�z view da distinct ve group by fonksiyonlar�n�n kullan�lmamas� gerekir.

--create.....
--with encryption | with schemabinding => ara�t�rma?
--as
--sorgu
update vw_ProductName set ProductName='Deneme3' where ProductName='Deneme'
select * from vw_ProductName
--
delete from vw_ProductName where ProductName='Deneme3'

--View � silmek i�in
drop view vw_ProductName
