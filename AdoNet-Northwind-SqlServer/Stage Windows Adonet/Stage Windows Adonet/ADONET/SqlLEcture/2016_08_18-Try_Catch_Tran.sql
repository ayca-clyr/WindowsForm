--Veritabanýna sipariþ ekliycem. Procedure gelen parametreler, Customers.CompanyName,Employees.FirstName Lastname(Burcu Engin),ProductName,Quatity
--Ýlk önce orders tanlosuna, order details tablosuna veri ekleneck. ORderdate þuanki zaman, requrieddate þimdiki zamanýn 20 gün sonrasý
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
	------ProductID yi ve Unitprice almak için 1. Yöntem
	select @procID=p.ProductID,@price=p.UnitPrice from Products p where p.ProductName=@urun
	-----ProductID yi ve Unitprice almak için 2. Yöntem
	--set @procID=(select p.ProductID from Products p where p.ProductName=@urun)
	--set @price=(select p.UnitPrice from Products p where p.ProductName=@urun)
	-----EmployeeID yi almak için 1.
	--set @empID=(select e.EmployeeID from Employees e where e.FirstName + ' ' + e.LastName=@calisan)
	-----EmployeeID yi almak için 2.
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
		raiserror('Güncelemeyeceksin :D',16,1)
		update Products set UnitsInStock=UnitsInStock-@adet where ProductID=@procID
	commit tran -- tüm iþlemlerim doðru birþekilde gerçekleþti
	end try
	begin catch
			print 'Sipariþ gerçekleþemedi!'
			rollback -- tran bloðunda hata aldýn, hata aldýðýn yere kadar gerçekleþtirdiðin iþlemleri geri al
	end catch
	end

end
---Test Etmek için
exec sp_SiparisEkle 'Bólido Comidas preparadas','Nancy Davolio','Chai',10

----Try_Catch - Transaction
--Hata Ayýklama olarak geçer. Try bloðu içersinde yazdýðýmýz kodlarda hata alma olasýlýðýmýz yüksekse, kodlarý çalýþtýrmaya devam etme ve ctach bloðu içerisindeki kodlarý çalýþtýr diyoruz.Yazým þekli:
--begin try
----- hata alýnmasý muhtemek kod satýrlarý
--end try
--begin catch
----- hata alýndýðýnda çalýþacak kod satýrlarý
--end catch

--sistemde var olan tüm hata mesajlarý
select * from sys.messages



-----Raiserror => try bloðu içerisinde kendimiz hata yaratmak için kullanýyoruz.
begin try
	raiserror('Ben yarattým ben :D',16,1)
end try
begin catch
	select ERROR_MESSAGE() as Mesajim,ERROR_LINE() as HataSatiri
end catch

----
--error_message > hata mesajý oluþturmak için
--error_number => hata numarasý
--error_state => hatanon kod deðer
--error_severity=> hata deresi(0-25 arasýnda bir deðer alýr)
--error_line => hatanýn gerçekleþtiði satýr sayýsý

---Önem derecesi
--0-18 arasýnda ise kullanýcý kaynaklý hatalarmýþ
--19-25 arasýndaki hatalar sysadmin tarafýndan sabit belirtilen hatalarmýþ
--Not => 20 den büyük olan hatalarý sistem otomatikman kilitliyor. Kritik derecedeki hatalar demek

----Transaction
--try bloðu içerisine yazýlýr.Yazým Þekli
--begin try
	--begin tran
		--kodlar
	--commit tran
--end try
--begin catch
	--rollback
--end catch

---Trigger (Tetikleyici)
--DML(Insert,Update,Delete) Trigger => Ýlgili veri tabaný üzerinde bir takým iþlemler öncesi ya da sonradýnda kendiliðinden tetiklenmesini istediðimiz ekstra iþleri belirttiðim yapýlardýr. Yazým þekli:
--create trigger TriggerAdi
--on TabloAdi
--after insert => delete, update .(instead of delete => delete iþlemini engelle onu yerine alttaki kodlarý çalýþtýr)
--as
--begin
---- kodlar
--end

---Yeni bir kargo firmaý eklediðimde tüm kargolarýmýn listesi gelsin

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

-----Products tablosundaki hiçbir verimi silme sadece Discountinued alanýný false yap
create trigger SilmeFalseYap
on products
instead of delete
as
begin
	update Products set Discontinued=0 where ProductID=(select ProductID from deleted)
end
--
delete from Products where ProductID=5

----Employees tablosunda yapýlan deðiþiklikleri EmployeesLog tablosunda tutan trigger ý yazýnýz. Employees tablosunda olmasý gereken alanlar (ID, process,users,employeeID) Trigger
select SYSTEM_USER