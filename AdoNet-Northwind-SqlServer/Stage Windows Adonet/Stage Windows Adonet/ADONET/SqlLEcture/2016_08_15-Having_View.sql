-----Having
--Gruplandýrma yaparken sorguda bir koþulun verilmesi gerekiyorsa devreye girer. Having kelimesiyle group by ile gruplanan kayýtlar üzerinde kýsýtlama yapmamý saðlar. Having varsa group by kullanýlmalýdýr. Yazým þekli:
--select 
--sutun(lar)
--from tablo(lar)
--group by sutun(lar)
--having grup_kisitlamasi

---Having Kurallarý
--1) Select komutunda group by yok ise having kullanamazsýnýz
--2) having sözcüðünden sonra aggregate fonksiyonlardan en az biri kullanýlmalýdýr
--3) having sadece gruplanmýþ kayýtlar için kullanýlýr
--4) select sorgusunda where komutu da kullanýlabilir. Farký, where bir tablonun bir satýrý üzerinde o koþulu ararken, having gruplanmýþ kayýtlar içinde o koþulu arar.

--Çalýþanlarýmdan þu ana kadar vermiþ olduðu sipariþ sayýsý 100 ü geçenleri listeleyiniz
select
	e.FirstName + ' ' + e.LastName as FullName,
	count(o.OrderID) as SiparisSayisi
from Employees e
join Orders o on e.EmployeeID=o.EmployeeID
group by e.FirstName + ' ' + e.LastName
having count(o.OrderID)>100
--Eski Yöntem
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

--8-20'den fazla kez siparis edilmis olan urun sipariþleri hangi ülkelerden verilmiþtir.
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

--Ortalama satýþ fiyatýnýn üstünde olan sipariþlerimi getiriniz (OrderID,OrderDate,Total)

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

--Ürün bazý olarak ortalama satýþ adedinin üzerinde satýlan ürünleri getiriniz
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
--en pahalý ürünümden elde ettiðim ciro nekadardýr
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
--Yazým Þekli:
--create => Yaratmak
--Alter => Düzenlemek
--drop => Silmek
--create view View_Adi(vw_)
--as
--begin
--sorgu
--end

alter view vw_ProductName
as
select p.ProductName,p.UnitPrice from Products p

--View ý çalýþtýrmak için
select * from vw_ProductName

--View lar birden fazla tablonun istenilen verilerini sunabilmek için ilgili sorguyu veritabaný içerisine kaydettiðimiz yapýlardýr. View larý veri saklamaz. Ýlgili kodlar view içerisinde veri tabanýna kaydedilir. Yani veritaanýnda sanal tablo oluþturduðumuzu söyleyebiliriz. Kompleks bir sorguyu çalýþtýrmak için tekrar tekrar yazmak yerine o sorguyu view olarak veri tabanýna kaydedebiliriz.
--Not:// View içerisinde order by kullanabilmek için bir þart vardýr. O da order by ile top keyword unu kullanmak. 
alter view vw_Siparisler
as
--%100 de sýralama yapmýyor, sýralama yapmasý için 100 den küçük bir deðer belirtmek gerekmekte
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
--View da Update, Delete, Insert Ýþlemleri
--1) insert, updatei delete içinde kullanýlacak alanlar, view içerisinde olmak zorundadýr.
--2) View içerisinde join bir yapý kullanýp, o view a insert yapmak isterseniz, yalnýzca 1 tablodaki kolonlara iþlem yapabilirsiniz.
--3) insert, update, delete iþlemlerini yapabilmek için, o tablolara ait zorunlu alanlarýn view da olmasý gerekmektedir.
--4)insert, update, delete iþlemlerini yapacaðýnýz view da distinct ve group by fonksiyonlarýnýn kullanýlmamasý gerekir.

--create.....
--with encryption | with schemabinding => araþtýrma?
--as
--sorgu
update vw_ProductName set ProductName='Deneme3' where ProductName='Deneme'
select * from vw_ProductName
--
delete from vw_ProductName where ProductName='Deneme3'

--View ý silmek için
drop view vw_ProductName
