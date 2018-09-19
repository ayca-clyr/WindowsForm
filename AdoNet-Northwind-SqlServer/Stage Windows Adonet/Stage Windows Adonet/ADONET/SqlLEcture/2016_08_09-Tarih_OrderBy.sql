--Yunus Yöntemi :)
select Upper(Replace('Orhan Kandemir',Substring('Orhan Kandemir',2,CHARINDEX(' ','Orhan Kandemir')-1),'.'))

--Tarih Fonksiyonlarý
select getdate() as Tarih -- O anki tarih ve saati verir
select year(getdate()) as Yil
select year('1996-05-03') as Yil
use Northwind
go
select year(BirthDate) as Yýl from Employees 
select MONTH(getdate()) as Ay  -- Sayýsal olarak kaçýncý ayda olduðumuzu gösterir
select MONTH(BirthDate) from Employees

select day(getdate()) as Gun
select DATENAME(WEEKDAY,getdate()) -- metinsel olarak gün bilgisini almak için kullanýlýr
select DATENAME(dd,getdate()) -- günü sayýsal olarak almak için
select DATENAME(mm,GETDATE()) -- ay bilgisinin metinsel deðerine ulaþmak için
select DATENAME(WEEK,getdate()) --yýlýn kaçýncý haftasýnda olduðunuzu verir
select datename(DAYOFYEAR,getdate()) --yýlýn kaçýncý gününde olduðunuzu verir
select datediff(year,'1998-09-09',getdate()) --Yýla göre fark
select DATEDIFF(MONTH,'1998-09-09',getdate()) --Ay bazlý fark
select DATEDIFF(year, BirthDate,getdate()) as Yas from Employees
select datepart(year,getdate())
select datepart(MONTH,getdate())
select DATEADD(YEAR,2,getdate())
select DATEADD(day,100,'1998-09-09')

select format(getdate(),'dd-MM-yyyy') --tarih formatýný deðiþtirmak için
--yaþý 50 den büyük olan erkek çalýþanlarým
select 
	FirstName + ' ' +LastName as FullName, 
	TitleOfCourtesy,
	DATEDIFF(year,birthdate,getdate()) as Age 
from Employees 
where TitleOfCourtesy='Mr.' and DATEDIFF(year,BirthDate,getdate())>50

--1998 yýlýna ait sipariþlerim
select 
	OrderID,
	CustomerID,
	EmployeeID,
	OrderDate
from Orders
where year(OrderDate)=1998
--1997 yýlýna ait UK ve Fransaya yapýlan satýþlar
select
	OrderID,
	OrderDate,
	ShipCountry
from Orders
--where year(OrderDate)=1997 and ShipCountry in ('UK','France')
where YEAR(OrderDate)=1997 and (ShipCountry='UK' or ShipCountry='France')
--1998 de sipariþ verilmiþ ama teslim edilmemiþ sipariþler
select 
	OrderID,
	OrderDate,
	ShippedDate
from Orders
where year(OrderDate)=1998 and ShippedDate is null

--Teslim edilmesi gereken tarihten sonra teslim edilen ürünler, ve kaç gün geç kalýndýðýnýn bilgisi
select
	OrderID,
	OrderDate,
	RequiredDate,
	ShippedDate,
	DATEDIFF(day,RequiredDate,ShippedDate) as GecikmeGunSayisi
from Orders
--where RequiredDate<ShippedDate
where DATEDIFF(day,RequiredDate,ShippedDate)>=1

--bu yýl için doðum günü geçen çalýþanlarým
select
	FirstName + ' ' + LastName as FullName,
	BirthDate
from Employees
where MONTH(BirthDate)<MONTH(GETDATE()) or (MONTH(BirthDate)=MONTH(getdate()) and DAY(BirthDate)<day(GETDATE()))


--ORDER BY
--Sýralama yapmak için kullandýðým komuttur. Raporlanan sonucunun içerisinde geçen kolon ya da kolonlara göre sýralama yapmak için kullanýrým.Order by ile küçükten büyüðe sýralama asc(varsayýlan olarak geçerli sýralama türü) ile, büyükten küçüðe sýralama desc ile yapýlýr. where den sonra yazýlýr. Hem sayýsla hem de alfabetik olarak sýralama yapar

select 
	OrderID,
	OrderDate,
	ShippedDate,
	ShipCountry
from Orders
where year(OrderDate)=1998
order by ShipCountry,OrderDate desc

--Teslim edilmesi gereken tarih ile teslim tarihi arasýndaki farký en çok olandan en az olana doðru sýralayýnýz
select
	OrderID,
	OrderDate,
	RequiredDate,
	ShippedDate,
	DATEDIFF(day,RequiredDate,ShippedDate) as Fark
from Orders
where RequiredDate<ShippedDate
order by Fark desc

--Ürün fiyatlarýný büyükten küçüðe sýralayýnýz
select 
	ProductID,
	ProductName,
	UnitPrice
from Products
order by UnitPrice desc

-- top => çýkan raporda kaç satýrlýk veriyi göstermek istediðimi belirtirim

select top 5
	ProductName,
	UnitsInStock
from Products
order by UnitsInStock desc
--Yüzde olarak getirlmesini istiyorsak percent komutunu kullanacaðýz
select top 50 percent
	OrderID
from Orders

--distinct=> ayný olan satýrlarý tek olarak göster
select distinct
	e.Country
from Employees e

--Teslim edilmemiþ son 3 sipariþim
select top 3
	OrderID,
	OrderDate,
	ShippedDate
from Orders
where ShippedDate is null
order by OrderDate desc

--stoðumda bulunan en pahalý 5 ürünüm
select top 5
	ProductName,
	UnitsInStock,
	UnitPrice
from Products
where UnitsInStock>0
order by UnitPrice desc
--Hangi ülkelere ihracat yapýyorum
select distinct
	ShipCountry
from Orders

--A ile H arasýnda herhangi bir harf ile baþlayan ürün isimlerini getiriniz
select
	ProductName
from Products
--where ProductName between 'A' and 'H'
where ProductName like '[A-H]%' --A dan H a kadar olan isimleri getirir
--
select
 ProductName
from Products
where ProductName like '[^a-h]%' --A ile H arasýnda olmayanlarý getiriniz
--
select
	ProductName
from Products
where ProductName like '[Tofu]%'
--
select
	ProductName
from Products
where ProductName like '[^A^C]%' --A veya C ile baþlayan isimleri getirme demek
--
select 
	ProductName
from Products
where ProductName like 'A[^N]%' --A ile baþlayan ama 2. harfi n olmayan ürünleri getir
--
select
	ProductID,
	ProductName
from Products
where ProductID like '[25]%' --ProductId si 2 veya 5 ile baþlayan ürünleri getiriniz
--
--select
--	FirstName
--from Employees
--where FirstName like 'Er[ms]an'
