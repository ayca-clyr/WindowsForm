--Use => Gidilmek istenen veritaban�n� belirtmek i�in
--Go=> Kendinden �nceki kod sat�r�n�n �al��mas� bitmeden alttakilere ge�mez

/*
 1) Sat�r bazl� yorum eklemek i�in --(�ki yan tire)
 2) Paragraf bazl� yorum eklemek i�in /* .... */ kullan�l�r
*/

--DML -> Data MAnipulation Language (Veri ��leme Dili) => Sadece tablolardaki kay�tlarla ilgili i�lemleir yapmak i�in kullan�r�m.
--Select=> Veri se�mek, veriyi sorgulamak i�in
--Insert=> Veri eklemek i�in
--Update=> Veri g�ncellemek i�in
--Delete=> Veriyi silmek i�in

---Insert
--Yaz�m �ekli
--Insert i�leminde zorunlu alanlar�n hepsine veri eklenmelidir.
insert into Employees(FirstName,LastName,BirthDate) values('Burcu','Engin','1988-09-16')

--Update
--Yaz�m �ekli
update Employees set LastName='Ergin' where EmployeeID=10
update Employees set Country='Amerika' where Country='USA'

--Delete
--Yaz�m �ekli
--Verileri silmek i�in kullan�r�m. Bir sart belirtmez isem butun kayitlari silecektir.
delete from Employees where EmployeeID=12

----Truncate Kullan�m�
--Bir tabloda yer alan kay�tlar� silmek i�in kullan�r�m. Delete in where siz halidir. Yani tablodaki t�m verileri siler. 
--Delete ile tablo sildi�imizde identity de�eri yeni veri ekledi�imizde kald��� yerden devam ederken, truncate de s�f�rlan�r.
--E�er truncate uygulanacak tabloda foreign key var ise i�lem ger�ekle�mez. --Truncate i�lemi daha h�zl�d�r. ��nk� Transaction Log dosyas�nda delete i�lemi sat�r sat�r tutulurken, truncate de t�m tablo tek sat�r halinde tutulur. 


--Select
--select *(t�m alanlar� getir) KolonAdi1,KolonAdi2,KolonAdi3 from TabloAdi
select * from Employees
select EmployeeID,FirstName,LastName, City from Employees
select EmployeeID,FirstName + ' ' + LastName as [Full Name] from Employees -- "+" i�areti ile ad ve soyad� string birle�tirme yapt�m.
--as=> aliases - takma ad
select * from [Order Details]--Bo�luk ile ayr�lm�� tablo ad�, kolon ad� gibi ifadeleriniz bulunuyor ise [] i�areti aras�nda yazman�z gerekmektedir.
select e.FirstName + ' ' + e.LastName FullName, e.Country from Employees e
-- Takma ad vermek i�in illaki as keyword une gerek yok. Bo�luk b�rakarak da verebilirsiniz
select BirthDate LastName, City, 'Deneme' from Employees

--
select 'B','urcu' Ad, 'Engin' Soyad
select 12 as Sonuc
select 12 + 34 as Sonuc --Matematiksel i�lem
select '23'+ 34 as Sonuc --Matematiksel i�lem
select '23' + '34' as Sonuc --String birle�tirme

--Categories tablosundaki t�m veriler
select * from Categories

select CategoryName from Categories

select * from Products

--�r�n ad� Tofu olan� getiriniz
select * from Products where ProductName='Tofu'
select p.UnitsInStock from Products p where p.ProductName='Tofu'

--CategoryID si 7 olan �r�nleri getiriniz
select * from Products where CategoryID=7
select p.ProductID,p.ProductName,p.UnitsInStock from Products p where p.CategoryID=7

--Operat�rler
-- < => K���kt�r
-- > => B�y�kt�r
-- <= => K���k e�ittir
-- >= => B�y�k e�ittir
-- <> != => E�it de�ildir

select * from Products where UnitPrice>=20.25

select ProductName,UnitPrice from Products where UnitPrice>10 and UnitPrice<20

select ProductName,UnitPrice from Products where UnitPrice between 11 and 19
--
select p.ProductID,p.ProductName,p.CategoryID from Products p where p.CategoryID=7 or p.CategoryID=5 or p.CategoryID=6

select p.ProductID,p.ProductName,p.CategoryID from Products p where p.CategoryID in (5,6,7)

select p.ProductID,p.ProductName,p.CategoryID from Products p where p.CategoryID between 5 and 7

select p.ProductID,p.ProductName,p.CategoryID from Products p where p.ProductName in ('Chai','Tofu','Chang')

select p.ProductName, p.UnitPrice from Products p

select p.ProductName,p.UnitsInStock from Products p where p.ProductName like 'Tofu%'

--Ka��� Karakterleri
--String ifadeler i�in kullanl�r. Bir metnin i�erisindeki kelime ya da harfi bulmak i�in kullan�r�m. Like keyword u ile birlikte kullan�l�r.

--% => Nereye konuldu ise o k�s�mdaki harflerin bilinmedi�ini g�sterir.
-- %Tofu => Ba�lang�c� bilinmeyene ama sonu Tofu ile bitenleri getir
-- Tofu% => Tofu ile ba�layan ama sonu bilinmeyen ifadeleri getir
-- %Tofu% => Ba�lang�c� ya da sonu bilinmeyen ama i�erisinde Tofu ge�enleri getir.
select p.ProductName from Products p where ProductName like '%ch%'

-- _ => Tek bir karakter yerine ge�er
select * from Products where ProductName like '____'

-- �r�n ad� i�ersinde c ve i ge�enleri bana bulunuz
select * from Products where ProductName like '%c%i%' or ProductName like '%i%c%'

select * from Products where ProductName like '%c%' and ProductName like '%i%'
--sipari� tarihi 01.07.1996 ile 01.07.1998 aras�ndaki spari� lerin id lerini bana getiriniz
select * from Orders where OrderDate between '1996-07-01' and '1998-07-01'
--id si 2 veya 4 olan ve ad�nda "ang" ifadesi ge�en �r�nleri bana getiriniz
select * from Products p where p.ProductID in (2,4) and p.ProductName like '%ang%'
select * from Products p where (p.ProductID=4 or p.ProductID=2) and p.ProductName like '%ang%'
--Toast seven �al��an�m kimdir?
select * from Employees e where e.Notes like '%toast%'
--Hi�kimseye rapor vermeyen �al��an�m kimdir?
 select * from Employees e where e.ReportsTo is null
 select * from Employees e where e.ReportsTo is not null

 --String- Built In Functions
 select lower('Bilge Adam') as Baslik
 select upper('Bilge Adam') as Baslik
 select Ltrim('    Bilge Adam    ') + ltrim('Deneme') as Baslik
 select rtrim('    Bilge Adam    ') + rtrim('Deneme') as Baslik
 select len('Bilge Adam') as KarakterSayisi
 select cast('123' as int) + cast('11' as int) as Sonuc
 --Substring(metin,baslangic_indexi,uzunluk)
 select substring('Bilge Adam',7,4) as Baslik
 --Replace => verilen bir ifade i�erisindeki de�i�mesini istedi�imiz karakter ya da kelimeler i�in kullan�yoruz.
 select replace('Bilge Adam','Adam','Kad�n') as Baslik
 --Charindex =>metnin i�erisinde aran�lacak olan karakterin ka��nc� karakter oldu�unu d�nd�r�r
 select CHARINDEX('g','Bilge Adam',2)

 --0(555) 555 55 55 => 5555555555
 select replace(replace(SUBSTRING('0(555) 555 55 55',3,14),')',''),' ','')

 select Upper(substring('RamazanKemal Erorhan',1,1)) + '.' + Upper(Substring('RamazanKemal Erorhan',CHARINDEX(' ','RamazanKemal Erorhan',1)+1,len('RamazanKemal Erorhan')-charindex(' ','RamazanKemal Erorhan',1)))
