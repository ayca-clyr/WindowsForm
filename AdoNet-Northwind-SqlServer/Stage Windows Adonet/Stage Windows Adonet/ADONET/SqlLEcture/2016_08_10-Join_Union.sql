
--JOIN
--Join(Birle�tirici) => �ki ya da daha fazla tabloyu ayn� anda sorgulamak i�in kullan�r�m
--1) Inner Join=> �li�kili tablolarda sadece Birbirleriyle ili�kisi olan verileri getirir. Ortak kay�tlar�. Default olarak inner join ge�erlidir.
select 
	c.CategoryName,
	p.ProductName
from Categories c
inner join Products p on c.CategoryID=p.CategoryID

--2) Left Join / Left Outer Join => �lk tablonun t�m sat�rlar�n�, ikinci tablonun ise ortak alanlar�n� getirir.
select
	c.CategoryName,
	p.ProductName
from Categories c 
left join Products p on c.CategoryID=p.CategoryID

--3)Right Join / Right Outer Join => �kinci tablonun tamam�, birinci tablonun ortak verilerini listelemek i�in kullan�r�m.

select
	c.CategoryName,
	p.ProductName
from Categories c
right join Products p on c.CategoryID=p.CategoryID

--4) Full Join / Full Outer Join => Her iki tabloda da yer alan verileri getirmek i�in kulan�l�r.
select
	c.CategoryName,
	p.ProductName
from Categories c
full join Products p on c.CategoryID=p.CategoryID

--Hangi �r�n� hangi tedarik�imden alm���m
select
	s.CompanyName,
	p.ProductName
from Suppliers s
inner join Products p on s.SupplierID=p.SupplierID
--Dairy Products kategorisinde ait sto�umda bulunan �r�nler hangileridir.
select
	c.CategoryName,
	p.ProductName
from Categories c
inner join Products p on c.CategoryID=p.CategoryID
where c.CategoryName='Dairy Products' and p.UnitsInStock>0
--1996 da sipari� vermemi� m��terilerim (CompanyName, ContactName)
select distinct
	c.CompanyName,
	c.ContactName
from Customers c
inner join Orders o on c.CustomerID=o.CustomerID
where year(o.OrderDate)!=1996
--1997 ye sipari� vermi� ama 1998 de sipari� vermemi� m��terim ya da m��terilerimin bilgileri nelerdir
select distinct
	c.CustomerID,
	c.CompanyName,
	c.ContactName
from Customers c
join orders o on c.CustomerID=o.CustomerID
where year(o.OrderDate)=1997 and year(o.OrderDate)!=1998


--Kategori ad� Condiments olan �r�nlerin stok bilgisini getiriniz
select 
	p.ProductName,
	p.UnitsInStock
from Categories c
join Products p on p.CategoryID=c.CategoryID
where c.CategoryName='Condiments'
order by p.UnitsInStock desc
--ALFKI id li m��terimin sipari�lerini hangi kargo firmas� ta��maktad�r
select distinct
	s.CompanyName
from Orders o 
join Shippers s on o.ShipVia=s.ShipperID
where o.CustomerID='ALFKI'
--�al��anlar�m� amirleriyle beraber listeleyiniz(Rapor Veren, Rapor Verilen)
select
	Calisan.FirstName + ' ' + Calisan.LastName as �al��an,
	Amir.FirstName + ' ' + Amir.LastName as Amir
from Employees Calisan
join Employees Amir on Calisan.ReportsTo=Amir.EmployeeID

--Chai veya Tofu �r�nleirnin 1996 y�l�ndaki sipari�lerini �r�n ad�, adedi ve g�nderildi�i �ehir halinde raporlay�n�z.
select
	p.ProductName,
	od.Quantity,
	o.ShipCity
from Products p
join [Order Details] od on p.ProductID=od.ProductID
join Orders o on od.OrderID=o.OrderID
where p.ProductName in ('Chai','Tofu') and year(o.OrderDate)=1996

--1996 y�l�n�n temmuz ay�nda sat�lan �r�nler nelerdir
select distinct
	p.ProductName
from Products p
join [Order Details] od on p.ProductID=od.ProductID
join orders o on od.OrderID=o.OrderID
where year(o.ShippedDate)=1996 and MONTH(o.ShippedDate)=7
--Federal ... ile ta��nm�� ve Nancy nin alm�� oldu�u sipari�ler
select
	o.OrderID,
	o.OrderDate,
	o.ShippedDate
from Employees e
join Orders o on e.EmployeeID=o.EmployeeID
join Shippers s on o.ShipVia=s.ShipperID
where s.CompanyName like 'Fed_ral%' and e.FirstName='Nancy'
--Konbu �r�n� hangi tarihlerde hangi m��terime sat�lm��t�r
select
	c.CompanyName,
	c.ContactName,
	o.ShippedDate
from Customers c
join orders o on c.CustomerID=o.CustomerID
join [Order Details] od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID
where p.ProductName='Konbu' and o.ShippedDate is not null

--Kategorinin ba�l� oldu�u �r�n�n hangi �al��an taraf�ndan hangi m��teriye ka� adet ve hangi tarihte, hangi kargo firmas�yla sat�lm�� oldu�u, ayr�ca �r�n�n tedarik�isiyle birlikte listeleyiniz.(Employee,Customer,Supplier,Category,Product,Shipper,OrderDate,Quantity)
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
--�ki ya da daha fazla sorguyu birbirini ba�lamak i�in kullan�r�z. Geriye tek bir sonu� k�mesi getirir

select FirstName + ' ' + LastName as FullName,BirthDate from Employees
union
select ContactName, NULL from Customers

--Firma olarak hangi �irketlerle �al���yorum. (CompanyName,ContactName,Phone)
select CompanyName, ContactName,Phone from Customers
union
select CompanyName,'Bilgi Yok!', Phone from Shippers
union
select CompanyName,ContactName,Phone from Suppliers

--Union All
--Sorgu sonu�lar�nda ayn� olan sat�rlar� da yazar. Union ayn� olan sat�rlar� tek bir sat�rm�� gibi ekrana yazd�r�r yani distinct i�lemi uygular. Ama union all t�m sat�rlar� oldu�u gibi getirir.

--1996 de sat�lm�� �r�nlerle, 1998 de sat�lm�� �r�nler nelerdir

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
--Sum => Toplam�n�
--Avg => Ortalamas�n�
--Max => Maksimumu
--Min => Minimumu

--En son hangi tarihte sipari� verilmi�
select max(o.orderdate) as SonSiparis from orders o

--En pahal� �r�n�m fiyat� nedir?
select max(p.UnitPrice) as MaxFiyat from Products p

--Stokta olan �r�nlerin toplam tutar�
select sum(p.UnitPrice*p.UnitsInStock) from Products p where p.UnitsInStock>0 
--ortalama tutar
select sum(p.UnitPrice*p.UnitsInStock)/sum(p.UnitsInStock) from Products p where p.UnitsInStock>0 
--Depomda ka� farkl� �r�n�m var
select count(*) from Products where UnitsInStock>0
--�al��anlar�m�n ya� ortalamas� ka�t�r
select datediff(year,birthdate,getdate()) as Yas from Employees
select avg(DATEDIFF(year,e.birthdate,getdate())) as OrtalamaYasi from Employees e

--Group By
--Sorguda ��kan sonu�lar�, gruplamak i�in kullan�r�m. Where �art�ndan sonra kullan�l�r. Kolon isimlerin bir aggregate fonksiyon kullan�p, ekstradan bir kolon daha eklemek istiyorsan�z gruop by � kullanmak zorundas�n�z.

select
	c.CategoryName,
	p.ProductName,
	sum(p.UnitPrice*p.UnitsInStock)
from Products p
join Categories c on p.CategoryID=c.CategoryID
where p.UnitsInStock>0
group by p.ProductName,c.CategoryName

