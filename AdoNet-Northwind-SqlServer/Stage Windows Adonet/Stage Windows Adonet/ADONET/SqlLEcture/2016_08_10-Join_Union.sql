
--JOIN
--Join(Birleþtirici) => Ýki ya da daha fazla tabloyu ayný anda sorgulamak için kullanýrým
--1) Inner Join=> Ýliþkili tablolarda sadece Birbirleriyle iliþkisi olan verileri getirir. Ortak kayýtlarý. Default olarak inner join geçerlidir.
select 
	c.CategoryName,
	p.ProductName
from Categories c
inner join Products p on c.CategoryID=p.CategoryID

--2) Left Join / Left Outer Join => Ýlk tablonun tüm satýrlarýný, ikinci tablonun ise ortak alanlarýný getirir.
select
	c.CategoryName,
	p.ProductName
from Categories c 
left join Products p on c.CategoryID=p.CategoryID

--3)Right Join / Right Outer Join => Ýkinci tablonun tamamý, birinci tablonun ortak verilerini listelemek için kullanýrým.

select
	c.CategoryName,
	p.ProductName
from Categories c
right join Products p on c.CategoryID=p.CategoryID

--4) Full Join / Full Outer Join => Her iki tabloda da yer alan verileri getirmek için kulanýlýr.
select
	c.CategoryName,
	p.ProductName
from Categories c
full join Products p on c.CategoryID=p.CategoryID

--Hangi ürünü hangi tedarikçimden almýþým
select
	s.CompanyName,
	p.ProductName
from Suppliers s
inner join Products p on s.SupplierID=p.SupplierID
--Dairy Products kategorisinde ait stoðumda bulunan ürünler hangileridir.
select
	c.CategoryName,
	p.ProductName
from Categories c
inner join Products p on c.CategoryID=p.CategoryID
where c.CategoryName='Dairy Products' and p.UnitsInStock>0
--1996 da sipariþ vermemiþ müþterilerim (CompanyName, ContactName)
select distinct
	c.CompanyName,
	c.ContactName
from Customers c
inner join Orders o on c.CustomerID=o.CustomerID
where year(o.OrderDate)!=1996
--1997 ye sipariþ vermiþ ama 1998 de sipariþ vermemiþ müþterim ya da müþterilerimin bilgileri nelerdir
select distinct
	c.CustomerID,
	c.CompanyName,
	c.ContactName
from Customers c
join orders o on c.CustomerID=o.CustomerID
where year(o.OrderDate)=1997 and year(o.OrderDate)!=1998


--Kategori adý Condiments olan ürünlerin stok bilgisini getiriniz
select 
	p.ProductName,
	p.UnitsInStock
from Categories c
join Products p on p.CategoryID=c.CategoryID
where c.CategoryName='Condiments'
order by p.UnitsInStock desc
--ALFKI id li müþterimin sipariþlerini hangi kargo firmasý taþýmaktadýr
select distinct
	s.CompanyName
from Orders o 
join Shippers s on o.ShipVia=s.ShipperID
where o.CustomerID='ALFKI'
--Çalýþanlarýmý amirleriyle beraber listeleyiniz(Rapor Veren, Rapor Verilen)
select
	Calisan.FirstName + ' ' + Calisan.LastName as Çalýþan,
	Amir.FirstName + ' ' + Amir.LastName as Amir
from Employees Calisan
join Employees Amir on Calisan.ReportsTo=Amir.EmployeeID

--Chai veya Tofu ürünleirnin 1996 yýlýndaki sipariþlerini ürün adý, adedi ve gönderildiði þehir halinde raporlayýnýz.
select
	p.ProductName,
	od.Quantity,
	o.ShipCity
from Products p
join [Order Details] od on p.ProductID=od.ProductID
join Orders o on od.OrderID=o.OrderID
where p.ProductName in ('Chai','Tofu') and year(o.OrderDate)=1996

--1996 yýlýnýn temmuz ayýnda satýlan ürünler nelerdir
select distinct
	p.ProductName
from Products p
join [Order Details] od on p.ProductID=od.ProductID
join orders o on od.OrderID=o.OrderID
where year(o.ShippedDate)=1996 and MONTH(o.ShippedDate)=7
--Federal ... ile taþýnmýþ ve Nancy nin almýþ olduðu sipariþler
select
	o.OrderID,
	o.OrderDate,
	o.ShippedDate
from Employees e
join Orders o on e.EmployeeID=o.EmployeeID
join Shippers s on o.ShipVia=s.ShipperID
where s.CompanyName like 'Fed_ral%' and e.FirstName='Nancy'
--Konbu ürünü hangi tarihlerde hangi müþterime satýlmýþtýr
select
	c.CompanyName,
	c.ContactName,
	o.ShippedDate
from Customers c
join orders o on c.CustomerID=o.CustomerID
join [Order Details] od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID
where p.ProductName='Konbu' and o.ShippedDate is not null

--Kategorinin baðlý olduðu ürünün hangi çalýþan tarafýndan hangi müþteriye kaç adet ve hangi tarihte, hangi kargo firmasýyla satýlmýþ olduðu, ayrýca ürünün tedarikçisiyle birlikte listeleyiniz.(Employee,Customer,Supplier,Category,Product,Shipper,OrderDate,Quantity)
select
	c.CategoryName,
	p.ProductName,
	e.FirstName + ' ' + e.LastName as FullName,
	cs.CompanyName,
	od.Quantity,
	o.ShippedDate,
	s.CompanyName,
	sp.CompanyName
from Categories c
join Products p on c.CategoryID=p.CategoryID
join [Order Details] od on p.ProductID=od.ProductID
join Orders o on od.OrderID=o.OrderID
join Employees e on o.EmployeeID=e.EmployeeID
join Customers cs on o.CustomerID=cs.CustomerID
join Shippers s on o.ShipVia=s.ShipperID
join Suppliers sp on p.SupplierID=sp.SupplierID
where o.ShippedDate is not null

---UNION
--Ýki ya da daha fazla sorguyu birbirini baðlamak için kullanýrýz. Geriye tek bir sonuç kümesi getirir

select FirstName + ' ' + LastName as FullName,BirthDate from Employees
union
select ContactName, NULL from Customers

--Firma olarak hangi þirketlerle çalýþýyorum. (CompanyName,ContactName,Phone)
select CompanyName, ContactName,Phone from Customers
union
select CompanyName,'Bilgi Yok!', Phone from Shippers
union
select CompanyName,ContactName,Phone from Suppliers

--Union All
--Sorgu sonuçlarýnda ayný olan satýrlarý da yazar. Union ayný olan satýrlarý tek bir satýrmýþ gibi ekrana yazdýrýr yani distinct iþlemi uygular. Ama union all tüm satýrlarý olduðu gibi getirir.

--1996 de satýlmýþ ürünlerle, 1998 de satýlmýþ ürünler nelerdir

select distinct p.ProductName
from Products p
join [Order Details] od on p.ProductID=od.ProductID
join Orders o on od.OrderID=o.OrderID
where year(o.ShippedDate)=1996
union
select distinct p.ProductName
from Products p
join [Order Details] od on p.ProductID=od.ProductID
join Orders o on od.OrderID=o.OrderID
where year(o.ShippedDate)=1998

-----Aggregate Functions
--count => Adedini
--Sum => Toplamýný
--Avg => Ortalamasýný
--Max => Maksimumu
--Min => Minimumu

--En son hangi tarihte sipariþ verilmiþ
select max(o.orderdate) as SonSiparis from orders o

--En pahalý ürünüm fiyatý nedir?
select max(p.UnitPrice) as MaxFiyat from Products p

--Stokta olan ürünlerin toplam tutarý
select sum(p.UnitPrice*p.UnitsInStock) from Products p where p.UnitsInStock>0 
--ortalama tutar
select sum(p.UnitPrice*p.UnitsInStock)/sum(p.UnitsInStock) from Products p where p.UnitsInStock>0 
--Depomda kaç farklý ürünüm var
select count(*) from Products where UnitsInStock>0
--Çalýþanlarýmýn yaþ ortalamasý kaçtýr
select datediff(year,birthdate,getdate()) as Yas from Employees
select avg(DATEDIFF(year,e.birthdate,getdate())) as OrtalamaYasi from Employees e

--Group By
--Sorguda çýkan sonuçlarý, gruplamak için kullanýrým. Where þartýndan sonra kullanýlýr. Kolon isimlerin bir aggregate fonksiyon kullanýp, ekstradan bir kolon daha eklemek istiyorsanýz gruop by ý kullanmak zorundasýnýz.

select
	c.CategoryName,
	p.ProductName,
	sum(p.UnitPrice*p.UnitsInStock)
from Products p
join Categories c on p.CategoryID=c.CategoryID
where p.UnitsInStock>0
group by p.ProductName,c.CategoryName

