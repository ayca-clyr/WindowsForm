--1) En fazla ka� farkl� �r�n yollanan �lkenin hangi �ehrine en fazla �r�n yollad�m?
select distinct
	o.ShipCountry,
	tablo2.ShipCity,
	tablo1.MaxAdet
from
(
	select
		max(t1.Adet) as MaxAdet
	from
	(	
		select
			o.ShipCity,
			count(od.ProductID) as Adet
		from [Order Details] od
		join Orders o on od.OrderID=o.OrderID
		where o.ShippedDate is not null and o.ShipCountry in
		(
			select
				tablo2.ShipCountry
			from
			(
				select
					max(t1.Adet) as MaxAdet
				from
				(
					select
						o.ShipCountry,
						count(od.ProductID) as Adet
					from [Order Details] od
					join Orders o on od.OrderID=o.OrderID
					where o.ShippedDate is not null
					group by o.ShipCountry
				) as t1
			) as tablo1
			join
			(
				select
					o.ShipCountry,
					count(od.ProductID) as Adet
				from [Order Details] od
				join Orders o on od.OrderID=o.OrderID
				where o.ShippedDate is not null
				group by o.ShipCountry
			) as tablo2 on tablo1.MaxAdet=tablo2.Adet
		)
		group by o.ShipCity
	) as t1
) as tablo1
join
(	
		select
			o.ShipCity,
			count(od.ProductID) as Adet
		from [Order Details] od
		join Orders o on od.OrderID=o.OrderID
		where o.ShippedDate is not null and o.ShipCountry in
		(
			select
				tablo2.ShipCountry
			from
			(
				select
					max(t1.Adet) as MaxAdet
				from
				(
					select
						o.ShipCountry,
						count(od.ProductID) as Adet
					from [Order Details] od
					join Orders o on od.OrderID=o.OrderID
					where o.ShippedDate is not null
					group by o.ShipCountry
				) as t1
			) as tablo1
			join
			(
				select
					o.ShipCountry,
					count(od.ProductID) as Adet
				from [Order Details] od
				join Orders o on od.OrderID=o.OrderID
				where o.ShippedDate is not null
				group by o.ShipCountry
			) as tablo2 on tablo1.MaxAdet=tablo2.Adet
		)
		group by o.ShipCity
) as tablo2 on tablo1.MaxAdet=tablo2.Adet
join Orders o on tablo2.ShipCity=o.ShipCity

--2) Customer bazl� , United Package ile ta��nm�� ve 1998 Y�l�nda teslim edilmi� toplam �r�n say�s�n� g�steriniz. (shippers tablosundaki companyname bilgisi,shippeddate,toplam Toplam Adet,customerID)

select
	c.CustomerID,
	c.CompanyName,
	'1998 y�l�nda United Package ile ta��nan' as A��klama,
	tablo1.ToplamAdet
from
(
	select
		o.CustomerID,
		sum(od.Quantity) as ToplamAdet
	from  Orders o 
	join [Order Details] od on o.OrderID=od.OrderID
	join Shippers s on o.ShipVia=s.ShipperID
	where s.CompanyName='United Package' and year(o.ShippedDate)=1998
	group by o.CustomerID
) as tablo1
join Customers c on tablo1.CustomerID=c.CustomerID
order by ToplamAdet desc

--3) En �ok sat�� yapan eleman�m ve o eleman�n en �ok satt��� �r�n hangisidir.(FullName,ProductName)


--4) 1997 y�l�nda hangi m��teriminden maksimum kazan� alm���md�r?
select
	tablo2.CustomerID,
	c.CompanyName,
	c.ContactName,
	tablo1.MaxTutar
from
(
	select
		max(t1.ToplamTutar) as MaxTutar
	from
	(
		select
			o.CustomerID,
			sum(od.UnitPrice*od.Quantity) as ToplamTutar
		from [Order Details] od
		join Orders o on od.OrderID=o.OrderID
		where year(o.ShippedDate)=1997
		group by o.CustomerID
	) as t1
) as tablo1
join
(
	select
		o.CustomerID,
		sum(od.UnitPrice*od.Quantity) as ToplamTutar
	from [Order Details] od
	join Orders o on od.OrderID=o.OrderID
	where year(o.ShippedDate)=1997
	group by o.CustomerID
) as tablo2 on tablo1.MaxTutar=tablo2.ToplamTutar
join Customers c on tablo2.CustomerID=c.CustomerID

--Paris i�in sat�lan son sipari�, ve sipari� tarihiyle teslim tarihi aras�ndaki g�n fark�

--Brazil ya ya giden sipari�lerde category bazl� olarak ka� adet �r�n sat�lm��t�r.


--�al��anlar�m hangi kategoride en �ok hangi �r�n� satm��lard�r(Order Details deki quantity lere g�re)��kt�=> FullName, CategoryName,ProductName, MaxTotal
select
	tablo1.FullName,
	tablo1.CategoryName,
	tablo2.ProductName,
	tablo2.Total,
	tablo1.MaxTotal
from
(
	select
		t1.FullName,
		t1.CategoryName,
		max(t1.Total) as MaxTotal
	from
	(
		select 
			e.FirstName + ' ' + e.LastName as FullName,
			c.CategoryName,
			p.ProductName,
			sum(od.Quantity) as Total
		from Employees e
		join Orders o on e.EmployeeID=o.EmployeeID
		join [Order Details] od on o.OrderID=od.OrderID
		join Products p on od.ProductID=p.ProductID
		join Categories	C ON P.CategoryID=c.CategoryID
		where o.ShippedDate is not null
		group by e.FirstName + ' ' + e.LastName, c.CategoryName,p.ProductName
	) as t1
	group by t1.FullName,t1.CategoryName
) as tablo1
join
(
	select 
		e.FirstName + ' ' + e.LastName as FullName,
		c.CategoryName,
		p.ProductName,
		sum(od.Quantity) as Total
	from Employees e
	join Orders o on e.EmployeeID=o.EmployeeID
	join [Order Details] od on o.OrderID=od.OrderID
	join Products p on od.ProductID=p.ProductID
	join Categories	C ON P.CategoryID=c.CategoryID
	where o.ShippedDate is not null
	group by e.FirstName + ' ' + e.LastName, c.CategoryName,p.ProductName
) as tablo2 on tablo1.MaxTotal=tablo2.Total
where tablo2.FullName=tablo1.FullName and tablo1.CategoryName=tablo2.CategoryName
order by tablo1.FullName,tablo1.CategoryName
