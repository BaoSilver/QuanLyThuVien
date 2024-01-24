CREATE TABLE Taikhoan (
    email Nvarchar(255) Primary key,
    password NVARCHAR(20),
);
CREATE TABLE Docgia (
    MaDG INT primary key,
    TenDG NVARCHAR(50),
    Ngaysinh DATE,
    Gioitinh NVARCHAR(10),
    Diachi NVARCHAR(255),
);
CREATE TABLE Sach 
(
    Masach INT primary key,
    Tensach NVARCHAR(255) ,
    MaTG NVARCHAR(50) foreign key (MaTG) references Tacgia(MaTG), 
    Maloai nvarchar(50) foreign key (Maloai) references Theloai(Maloai),
	Manhaxb int foreign key (Manhaxb) references NhaXB(Manhaxb),
	Soluong int,
);
CREATE TABLE Thuthu (
    MaTT INT primary key,
    Hoten NVARCHAR(50),
    Ngaysinh DATE,
    Gioitinh NVARCHAR(10),
	email nvarchar(255) foreign key (email) references Taikhoan(email)
);
CREATE TABLE Phieumuon
 (
    Maphieu INT primary key,
    Masach INT foreign key (Masach) references Sach(Masach), 
	MaDG int foreign key (MaDG) references Docgia(MaDG),
    Ngaymuon DATE,
    Ngaytra DATE,
    Soluong INT,
);
create table Tacgia
(
	MaTG Nvarchar(50) primary key,
	TenTG nvarchar (255),
	Ngaysinh nvarchar(50),
	Gioitinh Nvarchar(10),
);
create table Theloai 
(
	Maloai nvarchar(50) primary key,
	Tenloai nvarchar(255)
);
 create table NhaXB
 (
	Manhaxb int primary key ,
	TenNhaxb nvarchar(255)
);

