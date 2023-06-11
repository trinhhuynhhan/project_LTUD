create Database UDQuanLyDienThoai
go
use UDQuanLyDienThoai
 
go
-- tao bang Loai
create table Loai (MaLoai char(10) primary key, TenLoai nvarchar(30) )
go
-- tạo bảng CuaHang
create table CuaHang(MaCH char(10) primary key,TenCH nvarchar(30))
go
-- tao bang san pham
create Table Sanpham(MaSP char(10) primary key, TenSP nvarchar(30), GiaSP float, NoiSX nvarchar(30), MaLoai char(10) constraint fk_SP_Loai references Loai(MaLoai),MaCH char(10) constraint fk_SP_CH references CuaHang(MaCH))
go
 
insert into Loai(MaLoai,TenLoai)
values('ML01', N'SamSung'), ('ML02', N'Oppo' ), ('ML03', N'Apple'),('ML04', N'NoKia')
go
insert into CuaHang(MaCH,TenCH)
values ('CH01',N'Cellphones'),('CH02',N'FPT Shop'),('CH03',N'TopZone'),('CH04',N'Điện Máy Xanh')
go
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP01', N'Iphone 14',6000000 ,N'TPHCM','ML03','CH03')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP02', N'Iphone 12',8000000 ,N'TPHCM','ML03','CH03')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP03', N'Iphone 13',7000000 ,N'TPHCM','ML03','CH03')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP04', N'Iphone 15',9000000 ,N'TPHCM','ML03','CH03')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP05', N'SamSung Galaxy A03',9000000 ,N'TPHCM','ML01','CH01')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP06', N'SamSung Galaxy S22+ 5G',9000000 ,N'TPHCM','ML01','CH01')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP07', N'SamSung Galaxy A53',9000000 ,N'TPHCM','ML01','CH01')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP08', N'SamSung Galaxy S22',9000000 ,N'TPHCM','ML01','CH01')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP09', N'Oppo Reno6',9000000 ,N'TPHCM','ML02','CH01')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP10', N'Oppo Find x5 Pro',9000000 ,N'TPHCM','ML02','CH01')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP11', N'Oppo Reno',9000000 ,N'TPHCM','ML02','CH04')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP12', N'Oppo A95',9000000 ,N'TPHCM','ML02','CH04')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP13', N'Nokia 1280',9000000 ,N'TPHCM','ML03','CH02')
Insert into Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) 
values ('SP14', N'Nokia 8800',9000000 ,N'TPHCM','ML03','CH02')

 
go

Create PROC selectAllSP
AS
SELECT * From Sanpham

Create PROC selectALLLoai
AS
SELECT * FROM Loai

Create PROC selectALLCuaHang
AS
SELECT * FROM CuaHang

----SanPham

Create Proc insertSP(@MaSP char(10), @TenSP nvarchar(30), @GiaSP float,@NoiSX nvarchar(30),@MaLoai char(10),@MaCH char(10))
AS
INSERT INTO Sanpham(MaSP,TenSP,GiaSP,NoiSX,MaLoai,MaCH) VALUES (@MaSP,@TenSP,@GiaSP,@NoiSX,@MaLoai,@MaCH)

Create Proc deleteSP(@MaSP char(10))
AS
DELETE FROM Sanpham Where MaSP = @MaSP;

Create Proc updateSP(@MaSP char(10), @TenSP nvarchar(30), @GiaSP float,@NoiSX nvarchar(30),@MaLoai char(10))
AS
UPDATE Sanpham SET TenSP = @TenSP,GiaSP = @GiaSP,NoiSX = @NoiSX,MaLoai = @MaLoai WHERE MaSP = @MaSP
go
Create Proc findHD(@MaSP char(10))
AS 
SELECT * FROM Sanpham WHERE MaSP=@MaSP
go
Create Proc Top10SP(@MaSP char(10), @TenSP nvarchar(30), @GiaSP float,@NoiSX nvarchar(30),@MaLoai char(10))
AS
SELECT TOP(10)MaSP,TenSP,GiaSP,NoiSX  FROM Sanpham WHERE MaSP = @MaSP ORDER BY MaSP Desc ;

-----Loai
go
Create Proc insertLoai(@MaLoai char(10),@TenLoai nvarchar(30))
AS
INSERT INTO Loai(MaLoai,TenLoai) VALUES (@MaLoai,@TenLoai)
go
Create Proc deleteLoai(@MaLoai char(10))
AS
DELETE FROM Loai Where MaLoai = @MaLoai;
go
Create Proc updateLoai(@MaLoai char(10),@TenLoai nvarchar(30))
AS
UPDATE Loai SET  TenLoai = @TenLoai WHERE MaLoai = @MaLoai;
go
Create Proc findLoai(@Maloai char(10))
AS 
SELECT * FROM Loai WHERE MaLoai= @Maloai
go
-- Cua Hang

Create Proc insertCH(@MaCH char(10),@TenCH nvarchar(30))
AS
INSERT INTO CuaHang(MaCH,TenCH) VALUES (@MaCH,@TenCH)
go
Create Proc deleteCH(@MaCH char(10))
AS
DELETE FROM CuaHang Where MaCH = @MaCH;
go
Create Proc updateCH(@MaCH char(10),@TenCH nvarchar(30))
AS
UPDATE CuaHang SET  TenCH = @TenCH WHERE MaCH = @MaCH
go
Create Proc findCH(@Maloai char(10))
AS 
SELECT * FROM CuaHang WHERE MaCH= TenCH
go
Create Proc Top3SPNew(@MaSP char(10), @TenSP nvarchar(30), @GiaSP float,@NoiSX nvarchar(30),@MaLoai char(10))
AS
SELECT TOP(10)MaSP,TenSP,GiaSP,NoiSX  FROM Sanpham WHERE MaLoai = @MaLoai ORDER BY MaSP ;