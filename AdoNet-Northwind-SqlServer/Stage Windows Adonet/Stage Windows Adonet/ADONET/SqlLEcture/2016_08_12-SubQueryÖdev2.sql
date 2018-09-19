--1-�r�nlerin bir listesini ve �r�n�n o ana kadarki verilmi� en y�ksek sipari� miktar�n� g�r�nt�leyin.(subquery)
select
	p.ProductName,
	max(od.Quantity) as MaxAdet
from [Order Details] od
join Products p on od.ProductID=p.ProductID
group by p.ProductName
--2-Hangi kargo �irketi hangi �r�n� en fazla ta��m��t�r.
select 
	s.CompanyName,
	p.ProductName,
	tablo1.TopMax
from (
       select 
			t1.ShipVia,
			max(t1.Tasinma) as TopMax
       from (
             select 
				o.ShipVia,
				od.ProductID,
				count(o.OrderID) as Tasinma
             from Orders o
             join [Order Details] od on o.OrderID=od.OrderID
             group by o.ShipVia,od.ProductID
             ) as t1
       group by t1.ShipVia
)as tablo1
join (
	select 
		o.ShipVia,
		od.ProductID,
		count(o.OrderID) as Tasinma
	from Orders o
	join [Order Details] od on o.OrderID=od.OrderID
	group by o.ShipVia,od.ProductID
) as tablo2 on tablo1.ShipVia=tablo2.ShipVia
join Products p on tablo2.ProductID=p.ProductID
join Shippers s on tablo1.ShipVia=s.ShipperID
where tablo1.TopMax=tablo2.Tasinma
--3-01.01.1996-01.01.1997 tarihleri aras�nda en fazla hangi �r�n sat�n al�nm��t�r.
select 
	p.ProductName, 
	t2.maxToplam 
from 
(
	select max(t1.toplam) as maxToplam from 
	(
		select  
			od.ProductID as UrunID, 
			sum(od.Quantity) as toplam 
		from [Order Details] od 
		inner join Orders o on od.OrderID=o.OrderID
		where o.ShippedDate between '01.01.1996' and '01.01.1997'
		group by od.ProductID
	) as t1
) as t2
inner join 
(
	select  
		od.ProductID as UrunID, 
		sum(od.Quantity) as toplam 
	from [Order Details] od 
	inner join Orders o on od.OrderID=o.OrderID
	where o.ShippedDate between '01.01.1996' and '01.01.1997'
	group by od.ProductID
) as t3 on t2.maxToplam=t3.toplam
inner join Products p on t3.UrunID=p.ProductID
--4-Hangi �lkeler de hangi sipari�ler, En ge� teslim edilmi�tir?
select 
	o.ShipCountry, 
	p.ProductID 
from Orders o 
inner join [Order Details] od  on o.OrderID=od.OrderID
inner join Products p on od.ProductID=p.ProductID
where DATEDIFF(day , o.RequiredDate,o.ShippedDate)=(
	select 
		max(DATEDIFF(day , o.RequiredDate,o.ShippedDate)) 
	from orders o 
	where o.RequiredDate<o.ShippedDate
	)
and  o.RequiredDate<o.ShippedDate
--5-Hangi tedarik�iden en fazla hangi �r�n temin edilmi�tir?(Stock da var olan ve sat�lan adetlerin toplam�ndan bulunacak)
select
	tablo1.CompanyName,
	tablo2.ProductName,
	tablo1.MaxAdet
from
(
	select
		t2.CompanyName,
		max(ToplamAdet) as MaxAdet
	from
	(
		select
			s.CompanyName,
			p.ProductName,
			sum(t1.SiparisToplam + p.UnitsInStock) as ToplamAdet
		from 
		(
			select
				p.ProductName,
				sum(od.Quantity) as SiparisToplam
			from [Order Details] od
			join Products p on od.ProductID=p.ProductID
			group by p.ProductName
		) as t1
		join Products p on t1.ProductName=p.ProductName
		join Suppliers s on p.SupplierID=s.SupplierID
		group by s.CompanyName,p.ProductName
	) as t2
	group by t2.CompanyName
) as tablo1
join
(
	select
		s.CompanyName,
		p.ProductName,
		sum(t1.SiparisToplam + p.UnitsInStock) as ToplamAdet
	from 
	(
		select
			p.ProductName,
			sum(od.Quantity) as SiparisToplam
		from [Order Details] od
		join Products p on od.ProductID=p.ProductID
		group by p.ProductName
	) as t1
	join Products p on t1.ProductName=p.ProductName
	join Suppliers s on p.SupplierID=s.SupplierID
	group by s.CompanyName,p.ProductName
) as tablo2 on tablo1.CompanyName=tablo2.CompanyName
where tablo1.MaxAdet=tablo2.ToplamAdet
--6-En fazla hangi �r�n hangi kargo firmas�yla en �ok ta��nm��t�r.
select 
	s.CompanyName,
	p.ProductName,
	tablo1.TopMax
from (
       select 
			t1.ShipVia,
			max(t1.Tasinma) as TopMax
       from (
             select 
				o.ShipVia,
				od.ProductID,
				count(o.OrderID) as Tasinma
             from Orders o
             join [Order Details] od on o.OrderID=od.OrderID
             group by o.ShipVia,od.ProductID
             ) as t1
       group by t1.ShipVia
)as tablo1
join (
	select 
		o.ShipVia,
		od.ProductID,
		count(o.OrderID) as Tasinma
	from Orders o
	join [Order Details] od on o.OrderID=od.OrderID
	group by o.ShipVia,od.ProductID
) as tablo2 on tablo1.ShipVia=tablo2.ShipVia
join Products p on tablo2.ProductID=p.ProductID
join Shippers s on tablo1.ShipVia=s.ShipperID
where tablo1.TopMax=tablo2.Tasinma
--7-Leka Trading �irketinin tedarik etti�i �r�nlerden ortalama ne kadar para kazand�k.
select
	sum(od.UnitPrice*od.Quantity) as ToplamKazanc
from Suppliers s
join Products p on s.SupplierID=p.SupplierID
join [Order Details] od on p.ProductID=od.ProductID
where s.CompanyName='Leka Trading'
--8-20'den fazla kez siparis edilmis olan urun sipari�leri hangi b�lgeden verilmi�tir.
select distinct
	tablo2.ShipCountry
from
(
	select
		t1.ProductName,
		count(t1.OrderID) as SiparisSayisi
	from
	(
		select
			o.ShipCountry,
			p.ProductName,
			od.OrderID
		from Products p
		join [Order Details] od on p.ProductID=od.ProductID
		join Orders o on od.OrderID=o.OrderID
	) as t1
	group by t1.ProductName
	having COUNT(t1.OrderID)>20
) as tablo1
join
(
	select
		o.ShipCountry,
		p.ProductName,
		od.OrderID
	from Products p
	join [Order Details] od on p.ProductID=od.ProductID
	join Orders o on od.OrderID=o.OrderID
) as tablo2 on tablo1.ProductName=tablo2.ProductName
--9-Kategori bazl� olarak en �ok para kazand���m �r�nlerimden sto�um ne kadar var?(categoryName,ProductName,ToplamTutar,UnitslnStock)
select
	tablo2.CategoryName,
	tablo2.ProductName,
	tablo1.MaxTutar,
	p.UnitsInStock
from 
(
	select
		t1.CategoryName,
		max(t1.ToplamTutar) as MaxTutar
	from
	(
		select
			c.CategoryName,
			p.ProductName,
			sum(od.UnitPrice*od.Quantity) as ToplamTutar
		from [Order Details] od
		join Products p on od.ProductID=p.ProductID
		join Categories c on p.CategoryID=c.CategoryID
		group by c.CategoryName,p.ProductName
	) as t1
	group by t1.CategoryName
) as tablo1
join
(
	select
	c.CategoryName,
			p.ProductName,
		sum(od.UnitPrice*od.Quantity) as ToplamTutar
	from [Order Details] od
	join Products p on od.ProductID=p.ProductID
	join Categories c on p.CategoryID=c.CategoryID
	group by c.CategoryName,p.ProductName
) as tablo2 on tablo1.MaxTutar=tablo2.ToplamTutar
join Products p on tablo2.ProductName=p.ProductName
where tablo1.CategoryName=tablo2.CategoryName
--10-Londra da �al��an en az sat�� yapan �al��an�m hangisidir?
select
	tablo2.FullName,
	tablo1.MinAdet
from
(
	select
		min(t1.Sayi) as MinAdet
	from
	(
		select
			e.FirstName + ' ' + e.LastName as FullName,
			count(o.OrderID) as Sayi
		from Employees e
		join Orders o on e.EmployeeID=o.EmployeeID
		where o.ShipCity='London'
		group by e.FirstName + ' ' + e.LastName 
	) as t1
) as tablo1
join
(
	select
		e.FirstName + ' ' + e.LastName as FullName,
		count(o.OrderID) as Sayi
	from Employees e
	join Orders o on e.EmployeeID=o.EmployeeID
	where o.ShipCity='London'
	group by e.FirstName + ' ' + e.LastName 
) as tablo2 on tablo1.MinAdet=tablo2.Sayi
--11-En fazla sat�� yapan sat�c�n�n rapor verdi�i �al��an�n�n sipari�leriyle ilgilendi�i ka� m��teri vard�r?
select distinct
	c.CompanyName
from Employees e
join Orders o on e.EmployeeID=o.EmployeeID
join Customers c on o.CustomerID=c.CustomerID
where e.EmployeeID=(
	select
		emp.EmployeeID
	from
	(
		select top 1
			e.EmployeeID,
			sum(od.UnitPrice*od.Quantity) as Kazanc�m
		from Employees e
		join Orders o on e.EmployeeID=o.EmployeeID
		join [Order Details] od on o.OrderID=od.OrderID
		group by e.EmployeeID
		order by Kazanc�m desc
	) as t1
	join Employees e on t1.EmployeeID=e.EmployeeID
	join Employees emp on e.ReportsTo=emp.EmployeeID
)
order by c.CompanyName asc
--12-Speedy Express ile ta��m�� �r�nlerden fiyat� max olan �r�n ve bu �r�n�n sipari�ini alm�� olan �al��an�n FullName ini getiriniz?
select distinct
	e.FirstName + ' '  + e.LastName as FullName
from [Order Details] od
join Orders o on od.OrderID=o.OrderID
join Employees e on o.EmployeeID=e.EmployeeID
join Shippers s on o.ShipVia=s.ShipperID
where od.ProductID in
(
	select
		p.ProductID
	from Products p
	where p.UnitPrice=
	(
		select  
			max(p.UnitPrice) as MaxFiyat
		from Products p
		where p.ProductID in
		(
			select distinct
				od.ProductID
			from Shippers s
			join Orders o on s.ShipperID=o.ShipVia
			join [Order Details] od on o.OrderID=od.OrderID
			where s.CompanyName='Speedy Express'
		)
	)
) and s.CompanyName='Speedy Express'
--13-Y�llar Baz�nda en �ok ta��ma yapan kargo firmalar� nelerdir?(Her senenin birincisi)
select
	tablo1.Yil,tablo2.CompanyName,tablo1.MaxTasinma
from
(
	select
		t1.Yil, max(t1.Tasinma) as MaxTasinma
	from
	(
		select
			year(o.ShippedDate) as Yil,	s.CompanyName,
			count(o.OrderID) as Tasinma
		from Shippers s
		join Orders o on s.ShipperID=o.ShipVia
		where o.ShippedDate is not null
		group by year(o.ShippedDate), s.CompanyName
	) as t1
	group by t1.Yil
) as tablo1
join
(
	select
		year(o.ShippedDate) as Yil,
		s.CompanyName,
		count(o.OrderID) as Tasinma
	from Shippers s
	join Orders o on s.ShipperID=o.ShipVia
	where o.ShippedDate is not null
	group by year(o.ShippedDate), s.CompanyName
) as tablo2 on tablo1.Yil=tablo2.Yil and tablo1.MaxTasinma=tablo2.Tasinma
--14-�al��anlar�m �r�n baz�nda ka� paral�k sat�� yapm��lard�r?(UnitPrice*Quantity)
select
	e.FirstName + ' ' + e.LastName as FullName,
	p.ProductName,
	sum(od.UnitPrice*od.Quantity) as Kazanc�m
from Employees e
join Orders o on e.EmployeeID=o.EmployeeID
join [Order Details] od on o.OrderID=od.OrderID
join Products p on od.ProductID=p.ProductID
group by e.FirstName + ' ' + e.LastName, p.ProductName
order by FullName,p.ProductName
--15-Her bir b�lgedeki en k�demli ve en k�demsiz �al��anlar�n i�e ba�lama tarihleri nedir?( ilk i�e ba�layan ve en son i�e ba�layan )
select
	table1.RegionDescription, table1.FullName, table1.HireDate as MinHireDate, table2.FullName,table2.HireDate as MaxHireDate
from (
	select distinct tablo1.RegionDescription,tablo2.FullName,tablo2.HireDate
	from
	(
	select
		t1.RegionDescription,
		min(t1.HireDate) as MinHireDate
	from
	(
		select
			r.RegionDescription,
			e.FirstName + ' ' + e.LastName as FullName,
			e.HireDate
		from Employees e
		join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
		join Territories t on et.TerritoryID=t.TerritoryID
		join Region r on t.RegionID=r.RegionID
	) as t1
	group by t1.RegionDescription
) as tablo1
join(
	select
			r.RegionDescription,
			e.FirstName + ' ' + e.LastName as FullName,
			e.HireDate
		from Employees e
		join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
		join Territories t on et.TerritoryID=t.TerritoryID
		join Region r on t.RegionID=r.RegionID
) as tablo2 on tablo1.RegionDescription=tablo2.RegionDescription
where tablo1.MinHireDate=tablo2.HireDate
) as table1
join(
select distinct tablo1.RegionDescription,tablo2.FullName,tablo2.HireDate
from
(
	select
		t1.RegionDescription,
		max(t1.HireDate) as MinHireDate
	from
	(
		select
			r.RegionDescription,
			e.FirstName + ' ' + e.LastName as FullName,
			e.HireDate
		from Employees e
		join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
		join Territories t on et.TerritoryID=t.TerritoryID
		join Region r on t.RegionID=r.RegionID
	) as t1
	group by t1.RegionDescription
) as tablo1
join(
	select
			r.RegionDescription,
			e.FirstName + ' ' + e.LastName as FullName,
			e.HireDate
		from Employees e
		join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
		join Territories t on et.TerritoryID=t.TerritoryID
		join Region r on t.RegionID=r.RegionID
) as tablo2 on tablo1.RegionDescription=tablo2.RegionDescription
where tablo1.MinHireDate=tablo2.HireDate
) as table2 on table1.RegionDescription=table2.RegionDescription
--16-Category bazl� y�llara g�re toplam kazanc� bulunuz?(UnitPrice*Quantity)
select
	c.CategoryName,
	year(o.ShippedDate) as Yil,
	sum(od.UnitPrice*od.Quantity) as Kazanc�m
from Categories c
join Products p on c.CategoryID=p.CategoryID
join [Order Details] od on p.ProductID=od.ProductID
join Orders o on od.OrderID=o.OrderID
where o.ShippedDate is not null
group by c.CategoryName,year(o.ShippedDate)
order by c.CategoryName
