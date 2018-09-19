--Yunus Y�ntemi :)
select Upper(Replace('Orhan Kandemir',Substring('Orhan Kandemir',2,CHARINDEX(' ','Orhan Kandemir')-1),'.'))

--Tarih Fonksiyonlar�
select getdate() as Tarih -- O anki tarih ve saati verir
select year(getdate()) as Yil
select year('1996-05-03') as Yil
use Northwind
go
select year(BirthDate) as Y�l from Employees 
select MONTH(getdate()) as Ay  -- Say�sal olarak ka��nc� ayda oldu�umuzu g�sterir
select MONTH(BirthDate) from Employees

select day(getdate()) as Gun
select DATENAME(WEEKDAY,getdate()) -- metinsel olarak g�n bilgisini almak i�in kullan�l�r
select DATENAME(dd,getdate()) -- g�n� say�sal olarak almak i�in
select DATENAME(mm,GETDATE()) -- ay bilgisinin metinsel de�erine ula�mak i�in
select DATENAME(WEEK,getdate()) --y�l�n ka��nc� haftas�nda oldu�unuzu verir
select datename(DAYOFYEAR,getdate()) --y�l�n ka��nc� g�n�nde oldu�unuzu verir
select datediff(year,'1998-09-09',getdate()) --Y�la g�re fark
select DATEDIFF(MONTH,'1998-09-09',getdate()) --Ay bazl� fark
select DATEDIFF(year, BirthDate,getdate()) as Yas from Employees
select datepart(year,getdate())
select datepart(MONTH,getdate())
select DATEADD(YEAR,2,getdate())
select DATEADD(day,100,'1998-09-09')

select format(getdate(),'dd-MM-yyyy') --tarih format�n� de�i�tirmak i�in
--ya�� 50 den b�y�k olan erkek �al��anlar�m
select 
	FirstName + ' ' +LastName as FullName, 
	TitleOfCourtesy,
	DATEDIFF(year,birthdate,getdate()) as Age 
from Employees 
where TitleOfCourtesy='Mr.' and DATEDIFF(year,BirthDate,getdate())>50

--1998 y�l�na ait sipari�lerim
select 
	OrderID,
	CustomerID,
	EmployeeID,
	OrderDate
from Orders
where year(OrderDate)=1998
--1997 y�l�na ait UK ve Fransaya yap�lan sat��lar
select
	OrderID,
	OrderDate,
	ShipCountry
from Orders
--where year(OrderDate)=1997 and ShipCountry in ('UK','France')
where YEAR(OrderDate)=1997 and (ShipCountry='UK' or ShipCountry='France')
--1998 de sipari� verilmi� ama teslim edilmemi� sipari�ler
select 
	OrderID,
	OrderDate,
	ShippedDate
from Orders
where year(OrderDate)=1998 and ShippedDate is null

--Teslim edilmesi gereken tarihten sonra teslim edilen �r�nler, ve ka� g�n ge� kal�nd���n�n bilgisi
select
	OrderID,
	OrderDate,
	RequiredDate,
	ShippedDate,
	DATEDIFF(day,RequiredDate,ShippedDate) as GecikmeGunSayisi
from Orders
--where RequiredDate<ShippedDate
where DATEDIFF(day,RequiredDate,ShippedDate)>=1

--bu y�l i�in do�um g�n� ge�en �al��anlar�m
select
	FirstName + ' ' + LastName as FullName,
	BirthDate
from Employees
where MONTH(BirthDate)<MONTH(GETDATE()) or (MONTH(BirthDate)=MONTH(getdate()) and DAY(BirthDate)<day(GETDATE()))


--ORDER BY
--S�ralama yapmak i�in kulland���m komuttur. Raporlanan sonucunun i�erisinde ge�en kolon ya da kolonlara g�re s�ralama yapmak i�in kullan�r�m.Order by ile k���kten b�y��e s�ralama asc(varsay�lan olarak ge�erli s�ralama t�r�) ile, b�y�kten k����e s�ralama desc ile yap�l�r. where den sonra yaz�l�r. Hem say�sla hem de alfabetik olarak s�ralama yapar

select 
	OrderID,
	OrderDate,
	ShippedDate,
	ShipCountry
from Orders
where year(OrderDate)=1998
order by ShipCountry,OrderDate desc

--Teslim edilmesi gereken tarih ile teslim tarihi aras�ndaki fark� en �ok olandan en az olana do�ru s�ralay�n�z
select
	OrderID,
	OrderDate,
	RequiredDate,
	ShippedDate,
	DATEDIFF(day,RequiredDate,ShippedDate) as Fark
from Orders
where RequiredDate<ShippedDate
order by Fark desc

--�r�n fiyatlar�n� b�y�kten k����e s�ralay�n�z
select 
	ProductID,
	ProductName,
	UnitPrice
from Products
order by UnitPrice desc

-- top => ��kan raporda ka� sat�rl�k veriyi g�stermek istedi�imi belirtirim

select top 5
	ProductName,
	UnitsInStock
from Products
order by UnitsInStock desc
--Y�zde olarak getirlmesini istiyorsak percent komutunu kullanaca��z
select top 50 percent
	OrderID
from Orders

--distinct=> ayn� olan sat�rlar� tek olarak g�ster
select distinct
	e.Country
from Employees e

--Teslim edilmemi� son 3 sipari�im
select top 3
	OrderID,
	OrderDate,
	ShippedDate
from Orders
where ShippedDate is null
order by OrderDate desc

--sto�umda bulunan en pahal� 5 �r�n�m
select top 5
	ProductName,
	UnitsInStock,
	UnitPrice
from Products
where UnitsInStock>0
order by UnitPrice desc
--Hangi �lkelere ihracat yap�yorum
select distinct
	ShipCountry
from Orders

--A ile H aras�nda herhangi bir harf ile ba�layan �r�n isimlerini getiriniz
select
	ProductName
from Products
--where ProductName between 'A' and 'H'
where ProductName like '[A-H]%' --A dan H a kadar olan isimleri getirir
--
select
 ProductName
from Products
where ProductName like '[^a-h]%' --A ile H aras�nda olmayanlar� getiriniz
--
select
	ProductName
from Products
where ProductName like '[Tofu]%'
--
select
	ProductName
from Products
where ProductName like '[^A^C]%' --A veya C ile ba�layan isimleri getirme demek
--
select 
	ProductName
from Products
where ProductName like 'A[^N]%' --A ile ba�layan ama 2. harfi n olmayan �r�nleri getir
--
select
	ProductID,
	ProductName
from Products
where ProductID like '[25]%' --ProductId si 2 veya 5 ile ba�layan �r�nleri getiriniz
--
--select
--	FirstName
--from Employees
--where FirstName like 'Er[ms]an'
