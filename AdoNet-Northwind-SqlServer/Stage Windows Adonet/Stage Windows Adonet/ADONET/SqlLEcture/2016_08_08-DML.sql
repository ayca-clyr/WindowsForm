--Use => Gidilmek istenen veritabanýný belirtmek için
--Go=> Kendinden önceki kod satýrýnýn çalýþmasý bitmeden alttakilere geçmez

/*
 1) Satýr bazlý yorum eklemek için --(Ýki yan tire)
 2) Paragraf bazlý yorum eklemek için /* .... */ kullanýlýr
*/

--DML -> Data MAnipulation Language (Veri Ýþleme Dili) => Sadece tablolardaki kayýtlarla ilgili iþlemleir yapmak için kullanýrým.
--Select=> Veri seçmek, veriyi sorgulamak için
--Insert=> Veri eklemek için
--Update=> Veri güncellemek için
--Delete=> Veriyi silmek için

---Insert
--Yazým þekli
--Insert iþleminde zorunlu alanlarýn hepsine veri eklenmelidir.
insert into Employees(FirstName,LastName,BirthDate) values('Burcu','Engin','1988-09-16')

--Update
--Yazým þekli
update Employees set LastName='Ergin' where EmployeeID=10
update Employees set Country='Amerika' where Country='USA'

--Delete
--Yazým þekli
--Verileri silmek için kullanýrým. Bir sart belirtmez isem butun kayitlari silecektir.
delete from Employees where EmployeeID=12

----Truncate Kullanýmý
--Bir tabloda yer alan kayýtlarý silmek için kullanýrým. Delete in where siz halidir. Yani tablodaki tüm verileri siler. 
--Delete ile tablo sildiðimizde identity deðeri yeni veri eklediðimizde kaldýðý yerden devam ederken, truncate de sýfýrlanýr.
--Eðer truncate uygulanacak tabloda foreign key var ise iþlem gerçekleþmez. --Truncate iþlemi daha hýzlýdýr. Çünkü Transaction Log dosyasýnda delete iþlemi satýr satýr tutulurken, truncate de tüm tablo tek satýr halinde tutulur. 


--Select
--select *(tüm alanlarý getir) KolonAdi1,KolonAdi2,KolonAdi3 from TabloAdi
select * from Employees
select EmployeeID,FirstName,LastName, City from Employees
select EmployeeID,FirstName + ' ' + LastName as [Full Name] from Employees -- "+" iþareti ile ad ve soyadý string birleþtirme yaptým.
--as=> aliases - takma ad
select * from [Order Details]--Boþluk ile ayrýlmýþ tablo adý, kolon adý gibi ifadeleriniz bulunuyor ise [] iþareti arasýnda yazmanýz gerekmektedir.
select e.FirstName + ' ' + e.LastName FullName, e.Country from Employees e
-- Takma ad vermek için illaki as keyword une gerek yok. Boþluk býrakarak da verebilirsiniz
select BirthDate LastName, City, 'Deneme' from Employees

--
select 'B','urcu' Ad, 'Engin' Soyad
select 12 as Sonuc
select 12 + 34 as Sonuc --Matematiksel iþlem
select '23'+ 34 as Sonuc --Matematiksel iþlem
select '23' + '34' as Sonuc --String birleþtirme

--Categories tablosundaki tüm veriler
select * from Categories

select CategoryName from Categories

select * from Products

--Ürün adý Tofu olaný getiriniz
select * from Products where ProductName='Tofu'
select p.UnitsInStock from Products p where p.ProductName='Tofu'

--CategoryID si 7 olan ürünleri getiriniz
select * from Products where CategoryID=7
select p.ProductID,p.ProductName,p.UnitsInStock from Products p where p.CategoryID=7

--Operatörler
-- < => Küçüktür
-- > => Büyüktür
-- <= => Küçük eþittir
-- >= => Büyük eþittir
-- <> != => Eþit deðildir

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

--Kaçýþ Karakterleri
--String ifadeler için kullanlýr. Bir metnin içerisindeki kelime ya da harfi bulmak için kullanýrým. Like keyword u ile birlikte kullanýlýr.

--% => Nereye konuldu ise o kýsýmdaki harflerin bilinmediðini gösterir.
-- %Tofu => Baþlangýcý bilinmeyene ama sonu Tofu ile bitenleri getir
-- Tofu% => Tofu ile baþlayan ama sonu bilinmeyen ifadeleri getir
-- %Tofu% => Baþlangýcý ya da sonu bilinmeyen ama içerisinde Tofu geçenleri getir.
select p.ProductName from Products p where ProductName like '%ch%'

-- _ => Tek bir karakter yerine geçer
select * from Products where ProductName like '____'

-- Ürün adý içersinde c ve i geçenleri bana bulunuz
select * from Products where ProductName like '%c%i%' or ProductName like '%i%c%'

select * from Products where ProductName like '%c%' and ProductName like '%i%'
--sipariþ tarihi 01.07.1996 ile 01.07.1998 arasýndaki spariþ lerin id lerini bana getiriniz
select * from Orders where OrderDate between '1996-07-01' and '1998-07-01'
--id si 2 veya 4 olan ve adýnda "ang" ifadesi geçen ürünleri bana getiriniz
select * from Products p where p.ProductID in (2,4) and p.ProductName like '%ang%'
select * from Products p where (p.ProductID=4 or p.ProductID=2) and p.ProductName like '%ang%'
--Toast seven çalýþaným kimdir?
select * from Employees e where e.Notes like '%toast%'
--Hiçkimseye rapor vermeyen çalýþaným kimdir?
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
 --Replace => verilen bir ifade içerisindeki deðiþmesini istediðimiz karakter ya da kelimeler için kullanýyoruz.
 select replace('Bilge Adam','Adam','Kadýn') as Baslik
 --Charindex =>metnin içerisinde aranýlacak olan karakterin kaçýncý karakter olduðunu döndürür
 select CHARINDEX('g','Bilge Adam',2)

 --0(555) 555 55 55 => 5555555555
 select replace(replace(SUBSTRING('0(555) 555 55 55',3,14),')',''),' ','')

 select Upper(substring('RamazanKemal Erorhan',1,1)) + '.' + Upper(Substring('RamazanKemal Erorhan',CHARINDEX(' ','RamazanKemal Erorhan',1)+1,len('RamazanKemal Erorhan')-charindex(' ','RamazanKemal Erorhan',1)))
