--Veritaban�na sipari� ekliycem. Procedure gelen parametreler, Customers.CompanyName,Employees.FirstName Lastname(Burcu Engin),ProductName,Quatity
--�lk �nce orders tanlosuna, order details tablosuna veri ekleneck. ORderdate �uanki zaman, requrieddate �imdiki zaman�n 20 g�n sonras�
alter proc sp_SiparisEkle
(
	@sirket varchar(50),
	@calisan varchar(50),
	@urun varchar(50),
	@adet int
)as
begin
	declare @cusID char(5),@procID int,@empID int,@price money
	set @cusID=(select c.CustomerID from Customers c where c.CompanyName=@sirket)
	------ProductID yi ve Unitprice almak i�in 1. Y�ntem
	select @procID=p.ProductID,@price=p.UnitPrice from Products p where p.ProductName=@urun
	-----ProductID yi ve Unitprice almak i�in 2. Y�ntem
	--set @procID=(select p.ProductID from Products p where p.ProductName=@urun)
	--set @price=(select p.UnitPrice from Products p where p.ProductName=@urun)
	-----EmployeeID yi almak i�in 1.
	--set @empID=(select e.EmployeeID from Employees e where e.FirstName + ' ' + e.LastName=@calisan)
	-----EmployeeID yi almak i�in 2.
	declare @ad varchar(20),@soyad varchar(20)
	set @ad=Rtrim(SUBSTRING(@calisan,1,CHARINDEX(' ',@calisan,1)))
	set @soyad=SUBSTRING(@calisan,CHARINDEX(' ',@calisan,1)+1,len(@calisan)-CHARINDEX(' ',@calisan,1))
	set @empID=(select e.EmployeeID from Employees e where e.FirstName=@ad and e.LastName=@soyad)
	if not (@procID='' or @cusID='' or @empID='')
	begin
	begin try
	begin tran
		insert into Orders(EmployeeID,CustomerID,OrderDate,RequiredDate) values(@empID,@cusID,getdate(),DATEADD(day,20,getdate()))
		declare @orderID int=(select SCOPE_IDENTITY())
		insert into [Order Details](OrderID,ProductID,Quantity,UnitPrice) values (@orderID,@procID,@adet,@price)
		raiserror('G�ncelemeyeceksin :D',16,1)
		update Products set UnitsInStock=UnitsInStock-@adet where ProductID=@procID
	commit tran -- t�m i�lemlerim do�ru bir�ekilde ger�ekle�ti
	end try
	begin catch
			print 'Sipari� ger�ekle�emedi!'
			rollback -- tran blo�unda hata ald�n, hata ald���n yere kadar ger�ekle�tirdi�in i�lemleri geri al
	end catch
	end

end
---Test Etmek i�in
exec sp_SiparisEkle 'B�lido Comidas preparadas','Nancy Davolio','Chai',10

----Try_Catch - Transaction
--Hata Ay�klama olarak ge�er. Try blo�u i�ersinde yazd���m�z kodlarda hata alma olas�l���m�z y�ksekse, kodlar� �al��t�rmaya devam etme ve ctach blo�u i�erisindeki kodlar� �al��t�r diyoruz.Yaz�m �ekli:
--begin try
----- hata al�nmas� muhtemek kod sat�rlar�
--end try
--begin catch
----- hata al�nd���nda �al��acak kod sat�rlar�
--end catch

--sistemde var olan t�m hata mesajlar�
select * from sys.messages



-----Raiserror => try blo�u i�erisinde kendimiz hata yaratmak i�in kullan�yoruz.
begin try
	raiserror('Ben yaratt�m ben :D',16,1)
end try
begin catch
	select ERROR_MESSAGE() as Mesajim,ERROR_LINE() as HataSatiri
end catch

----
--error_message > hata mesaj� olu�turmak i�in
--error_number => hata numaras�
--error_state => hatanon kod de�er
--error_severity=> hata deresi(0-25 aras�nda bir de�er al�r)
--error_line => hatan�n ger�ekle�ti�i sat�r say�s�

---�nem derecesi
--0-18 aras�nda ise kullan�c� kaynakl� hatalarm��
--19-25 aras�ndaki hatalar sysadmin taraf�ndan sabit belirtilen hatalarm��
--Not => 20 den b�y�k olan hatalar� sistem otomatikman kilitliyor. Kritik derecedeki hatalar demek

----Transaction
--try blo�u i�erisine yaz�l�r.Yaz�m �ekli
--begin try
	--begin tran
		--kodlar
	--commit tran
--end try
--begin catch
	--rollback
--end catch

---Trigger (Tetikleyici)
--DML(Insert,Update,Delete) Trigger => �lgili veri taban� �zerinde bir tak�m i�lemler �ncesi ya da sonrad�nda kendili�inden tetiklenmesini istedi�imiz ekstra i�leri belirtti�im yap�lard�r. Yaz�m �ekli:
--create trigger TriggerAdi
--on TabloAdi
--after insert => delete, update .(instead of delete => delete i�lemini engelle onu yerine alttaki kodlar� �al��t�r)
--as
--begin
---- kodlar
--end

---Yeni bir kargo firma� ekledi�imde t�m kargolar�m�n listesi gelsin

create trigger ShippersList
on Shippers
after insert
as
begin
	select CompanyName,Phone from Shippers
end

--
insert into Shippers(CompanyName,Phone) values ('Tetikci','999999999')
--
enable trigger ShippersList on Shippers

--
update Products set Discontinued=1 

-----Products tablosundaki hi�bir verimi silme sadece Discountinued alan�n� false yap
create trigger SilmeFalseYap
on products
instead of delete
as
begin
	update Products set Discontinued=0 where ProductID=(select ProductID from deleted)
end
--
delete from Products where ProductID=5

----Employees tablosunda yap�lan de�i�iklikleri EmployeesLog tablosunda tutan trigger � yaz�n�z. Employees tablosunda olmas� gereken alanlar (ID, process,users,employeeID) Trigger
select SYSTEM_USER