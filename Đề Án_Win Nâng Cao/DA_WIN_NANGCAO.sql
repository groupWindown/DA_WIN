﻿CREATE DATABASE DA_WIN_NANGCAO
GO
use DA_WIN_NANGCAO
GO
CREATE TABLE CHUCVU
(
	MACHUCVU  NVARCHAR(10) NOT NULL,
	TENCHUCVU NVARCHAR(50),
	PRIMARY KEY (MACHUCVU),
);

CREATE TABLE PHONGBAN
(
	MAPHONGBAN  NVARCHAR(10) NOT NULL,
	TENPHONGBAN NVARCHAR(50),
	MATRUONGPHONG NVARCHAR(10) ,
	PRIMARY KEY (MAPHONGBAN),
);


--- chuyên môn đổi thành kỹ năng chuyên môn của nhân viên
CREATE TABLE CHUYENMON
(
	MACHUYENMON  NVARCHAR(10) NOT NULL,
	TENCHUYENMON NVARCHAR(50),
	PRIMARY KEY (MACHUYENMON),
);
CREATE TABLE CHITIETCHUYENMON
(
	MACHUYENMON  NVARCHAR(10) NOT NULL,
	MAUNGVIEN  NVARCHAR(10) NOT NULL,
	PRIMARY KEY (MACHUYENMON,MAUNGVIEN)
);

CREATE TABLE TRINHDOHOCVAN
(
	MATRINHDOHOCVAN  NVARCHAR(10) NOT NULL,
	TENTRINHDOHOCVAN NVARCHAR(50),
	PRIMARY KEY (MATRINHDOHOCVAN),
);

CREATE TABLE TRINHDOTINHOC
(
	MATRINHDOTINHOC  NVARCHAR(10) NOT NULL,
	TENTRINHDOTINHOC NVARCHAR(50),
	PRIMARY KEY (MATRINHDOTINHOC),
);

CREATE TABLE NGOAINGU
(
	MANGOAINGU  NVARCHAR(10) NOT NULL,
	TENNGOAINGU  NVARCHAR(50) ,
	PRIMARY KEY (MANGOAINGU)
);

CREATE TABLE CHITIETNGOAINGU
(
	MANGOAINGU  NVARCHAR(10) NOT NULL,
	MAUNGVIEN  NVARCHAR(10) NOT NULL,
	PRIMARY KEY (MANGOAINGU,MAUNGVIEN)
);

CREATE TABLE DANTOC
(
	MADANTOC NVARCHAR(10) NOT NULL,
	TENDANTOC NVARCHAR(50),
	PRIMARY KEY (MADANTOC),
);

CREATE TABLE TONGIAO
(
	MATONGIAO  NVARCHAR(10) NOT NULL,
	TENTONGIAO NVARCHAR(50),
	PRIMARY KEY (MATONGIAO),
);

CREATE TABLE QUOCTICH
(
	MAQUOCTICH  NVARCHAR(10) NOT NULL,
	TENQUOCTICH NVARCHAR(50),
	PRIMARY KEY (MAQUOCTICH),
);

CREATE TABLE NHANVIEN
(
	MANV  NVARCHAR(10) NOT NULL,
	HOTEN NVARCHAR(50),
	MAPHONGBAN  NVARCHAR(10) NOT NULL,
	MACHUCVU  NVARCHAR(10) NOT NULL,
	NGAYVAOLAM DATE,
	TINHTRANG NVARCHAR(50),
	MAHOSO NVARCHAR(10),
	PRIMARY KEY (MANV)
);

CREATE TABLE TAIKHOAN
(
	MANV  NVARCHAR(10) NOT NULL,
	MATKHAU NVARCHAR(10),
	HOATDONG BIT,
	PRIMARY KEY (MANV)
);
CREATE TABLE NHOMNGUOIDUNG
(
	MANHOM  NVARCHAR(10) NOT NULL,
	TENNHOM NVARCHAR(50),
	GHICHU NVARCHAR(50) NOT NULL,
	PRIMARY KEY (MANHOM)
);
CREATE TABLE NGUOIDUNGNHOMNGUOIDUNG
(
	MANV  NVARCHAR(10) NOT NULL,
	MANHOM NVARCHAR(10) NOT NULL,
	GHICHU NVARCHAR(50) NOT NULL,
	PRIMARY KEY (MANV,MANHOM)
);
CREATE TABLE MANHINH
(
	MAMANHINH  NVARCHAR(10) NOT NULL,
	TENMANHINH NVARCHAR(50) NOT NULL,
	PRIMARY KEY (MAMANHINH)
);
CREATE TABLE PHANQUYEN
(
	MAMANHINH  NVARCHAR(10) NOT NULL,
	MANHOM NVARCHAR(10) NOT NULL,
	COQUYEN BIT,
	PRIMARY KEY (MAMANHINH,MANHOM)
);

CREATE TABLE HOPDONGLAODONG
(
	MAHOPDONG  NVARCHAR(10) NOT NULL,
	TENHOPDONG NVARCHAR(50),
	PRIMARY KEY (MAHOPDONG),
);

CREATE TABLE CHITIETHOPDONG
(
	MACTHD NVARCHAR(10) NOT NULL,
	MAHOPDONG  NVARCHAR(10) NOT NULL,
	MANV NVARCHAR(10)NOT NULL,
	KYLANTHU INT,
	NGAYKY DATE,
	NGAYBD DATE,
	NGAYKT DATE,
	LUONGTHOATHUAN MONEY,
	PRIMARY KEY (MACTHD)
);



CREATE TABLE LOAIKHENTHUONG
(
	MALOAIKHENTHUONG  NVARCHAR(10) NOT NULL,
	LOAITENKHENTHUONG NVARCHAR (50),
	TIENTHUONG MONEY,
	PRIMARY KEY (MALOAIKHENTHUONG),
);



CREATE TABLE CHITIETKHENTHUONG
(
	MACTKHENTHUONG  NVARCHAR(10) NOT NULL,
	MALOAIKHENTHUONG  NVARCHAR(10) NOT NULL,
	MANV NVARCHAR(10)NOT NULL,
	NGAYKHENTHUONG DATE,
	PRIMARY KEY (MACTKHENTHUONG)
);

CREATE TABLE DAOTAO
(
	MAKHOADAOTAO  NVARCHAR(10) NOT NULL,
	TENKHOADAOTAO NVARCHAR(50) ,
	PRIMARY KEY (MAKHOADAOTAO)
);

CREATE TABLE CHUONGTRINHDAOTAO
(
	MACTKHOADAOTAO  NVARCHAR(10) NOT NULL,
	MAKHOADAOTAO  NVARCHAR(10) NOT NULL,
	MANV NVARCHAR(10)NOT NULL,
	NGAYBD DATE,
	NGAYKT DATE,
	PRIMARY KEY (MACTKHOADAOTAO)
);

CREATE TABLE BAOHIEM
(
	MABAOHIEM  NVARCHAR(10) NOT NULL,
	MANV NVARCHAR(10)NOT NULL,
	LOAIBAOHIEM NVARCHAR(50) ,
	NOICAP NVARCHAR(50) ,
	NOIKHAM NVARCHAR(50) ,
	NGAYDK DATE,
	NGAYHH DATE,
	PRIMARY KEY (MABAOHIEM)
);

CREATE TABLE BANGCHAMCONG
(
	MANV NVARCHAR(10) NOT NULL,
	NGAYLAM DATE NOT NULL,
	GIOVAO TIME,
	GIORA TIME,
	PRIMARY KEY (MANV,NGAYLAM)
);

CREATE TABLE DANHMUCTANGCA
(
	MALOAICA NVARCHAR(10) NOT NULL,
	TENLOAICA NVARCHAR(50) ,
	HESO INT,
	SOGIOTANGCA FLOAT, ---CHI HIEN LEN CHO THAY
	PRIMARY KEY (MALOAICA)
);

CREATE TABLE BANGTANGCA
(
	MANV NVARCHAR(10) ,
	NGAYTANGCA DATE,
	MALOAICA NVARCHAR(10) ,
	PRIMARY KEY (MANV,NGAYTANGCA)
);

CREATE TABLE BANGTANGLUONG
(
	MABANGTANGLUONG NVARCHAR(10) NOT NULL,
	MANV NVARCHAR(10)NOT NULL,
	NGAYBD DATE,
	MUCTANG FLOAT,
	TONGTIENTANG MONEY,
	TANGLANTHU INT,
	PRIMARY KEY (MABANGTANGLUONG)
);



CREATE TABLE TONGLUONG
(
	MANV NVARCHAR(10)NOT NULL,
	LUONGTHANG NVARCHAR(10),
	TONGTIENLUONG MONEY,
	PRIMARY KEY (MANV,LUONGTHANG)
);



CREATE TABLE DS_KYLUAT
(
	MAKYLUAT NVARCHAR(10)NOT NULL,
	TENKYLUAT NVARCHAR(50),
	HINHTHUC NVARCHAR(50),
	TIENKYLUAT MONEY,
	PRIMARY KEY (MAKYLUAT)
);

CREATE TABLE QUANLYKYLUAT
(
	MAQUANLYKYLUAT NVARCHAR(10)NOT NULL,
	MANV NVARCHAR(10),
	MAKYLUAT NVARCHAR(10)NOT NULL,
	NGAYKYLUAT DATE,
	COQUANKYLUAT NVARCHAR(50),
	PRIMARY KEY (MAQUANLYKYLUAT)
);

CREATE TABLE QUANLYNGHIVIEC
(
	MAQUANLYNGHIVIEC NVARCHAR(10)NOT NULL,
	MANV NVARCHAR(10),
	SOQUYETDINH INT,
	NGAYQUYETDINH DATE,
	NGUOIKY NVARCHAR(50),
	NGAYNGHIVIEC DATE,
	LYDO NVARCHAR(50),
	PRIMARY KEY (MAQUANLYNGHIVIEC)
);

CREATE TABLE QUANLYTHAISAN
(
	MAQUANLYTHAISAN NVARCHAR(10)NOT NULL,
	MANV NVARCHAR(10),
	SOQUYETDINH INT,
	SINHCONTHU INT,
	NGAYQUYETDINH DATE,
	COQUANQUYETDINH NVARCHAR(50),
	NGAYBATDAU DATE,
	NGAYKETTHUC DATE,
	PRIMARY KEY (MAQUANLYTHAISAN)
);

CREATE TABLE HOSOTUYENDUNG
(
	MAUNGVIEN NVARCHAR(10)NOT NULL,
	MADANTOC NVARCHAR(10) NOT NULL,
	MATONGIAO  NVARCHAR(10) NOT NULL,
	MAQUOCTICH  NVARCHAR(10) NOT NULL,
	HOTEN NVARCHAR(50),
	GIOITINH NVARCHAR(10),
	NGAYSINH DATE,
	NOISINH NVARCHAR(50),
	CMND INT,
	NGAYCAP DATE,
	NOICAP NVARCHAR(50),
	QUEQUAN NVARCHAR(50),
	DIACHITHUONGTRU NVARCHAR(50),
	NOIOHIENTAI NVARCHAR(50),
	DIENTHOAI INT,
	EMAIL NVARCHAR(50),
	TINHTRANGHONNHAN NVARCHAR(10),
	DIENUUTIEN NVARCHAR(50),
	TINHTRANGSUCKHOE NVARCHAR(50),
	NGAYTUYENDUNG DATE,
	HINHTHUCTUYENDUNG NVARCHAR(50),
	VITRITUYENDUNG NVARCHAR(50),
	MATRINHDOHOCVAN  NVARCHAR(10),
	MATRINHDOTINHOC  NVARCHAR(10),
	PRIMARY KEY (MAUNGVIEN)
	
);

CREATE TABLE KQ_TUYENDUNG
(
	MAKQ NVARCHAR(10)NOT NULL,
	MAUNGVIEN NVARCHAR(10)NOT NULL,
	KETQUA NVARCHAR(50),
	PRIMARY KEY (MAKQ,MAUNGVIEN)
);

CREATE TABLE HINHANH
(
	MAHINHANH NVARCHAR(10)NOT NULL,
	TENHINHANH NVARCHAR(50),
	URL TEXT NOT NULL,
	MANV NVARCHAR(10),
	MAUNGVIEN NVARCHAR(10),
	PRIMARY KEY (MAHINHANH)

);



/*-------------------------------------------------------------------KHOA---------------------*/
ALTER TABLE CHITIETCHUYENMON
ADD FOREIGN KEY(MACHUYENMON)REFERENCES CHUYENMON(MACHUYENMON),
	FOREIGN KEY(MAUNGVIEN)REFERENCES HOSOTUYENDUNG(MAUNGVIEN)

ALTER TABLE CHITIETNGOAINGU
ADD FOREIGN KEY(MANGOAINGU)REFERENCES NGOAINGU(MANGOAINGU),
	FOREIGN KEY(MAUNGVIEN)REFERENCES HOSOTUYENDUNG(MAUNGVIEN)

ALTER TABLE NHANVIEN
ADD FOREIGN KEY(MAPHONGBAN)REFERENCES PHONGBAN(MAPHONGBAN),
	FOREIGN KEY(MACHUCVU)REFERENCES CHUCVU(MACHUCVU),
	FOREIGN KEY(MAHOSO)REFERENCES HOSOTUYENDUNG(MAUNGVIEN)

ALTER TABLE PHONGBAN
ADD FOREIGN KEY(MATRUONGPHONG)REFERENCES NHANVIEN(MANV)

ALTER TABLE TAIKHOAN
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE NGUOIDUNGNHOMNGUOIDUNG
ADD FOREIGN KEY(MANV)REFERENCES TAIKHOAN(MANV),
	FOREIGN KEY(MANHOM)REFERENCES NHOMNGUOIDUNG(MANHOM)
ALTER TABLE PHANQUYEN
ADD FOREIGN KEY(MAMANHINH)REFERENCES MANHINH(MAMANHINH),
	FOREIGN KEY(MANHOM)REFERENCES NHOMNGUOIDUNG(MANHOM)

ALTER TABLE CHITIETHOPDONG
ADD FOREIGN KEY(MAHOPDONG)REFERENCES HOPDONGLAODONG(MAHOPDONG),
	FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE CHITIETKHENTHUONG
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV),
	FOREIGN KEY(MALOAIKHENTHUONG)REFERENCES LOAIKHENTHUONG(MALOAIKHENTHUONG)
	

ALTER TABLE CHUONGTRINHDAOTAO
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV),
	FOREIGN KEY(MAKHOADAOTAO)REFERENCES DAOTAO(MAKHOADAOTAO)

ALTER TABLE BAOHIEM
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE BANGCHAMCONG
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE BANGTANGCA
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV),
	FOREIGN KEY(MALOAICA)REFERENCES DANHMUCTANGCA(MALOAICA)

ALTER TABLE BANGTANGLUONG
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE TONGLUONG
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE QUANLYKYLUAT
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV),
	FOREIGN KEY(MAKYLUAT)REFERENCES DS_KYLUAT(MAKYLUAT)

ALTER TABLE QUANLYNGHIVIEC
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE QUANLYTHAISAN
ADD FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

ALTER TABLE HOSOTUYENDUNG
ADD 
	FOREIGN KEY(MATRINHDOHOCVAN)REFERENCES TRINHDOHOCVAN(MATRINHDOHOCVAN),
	FOREIGN KEY(MATRINHDOTINHOC)REFERENCES TRINHDOTINHOC(MATRINHDOTINHOC),
	FOREIGN KEY(MADANTOC)REFERENCES DANTOC(MADANTOC),
	FOREIGN KEY(MATONGIAO)REFERENCES TONGIAO(MATONGIAO),
	FOREIGN KEY(MAQUOCTICH)REFERENCES QUOCTICH(MAQUOCTICH)

ALTER TABLE KQ_TUYENDUNG
ADD FOREIGN KEY(MAUNGVIEN)REFERENCES HOSOTUYENDUNG(MAUNGVIEN)

ALTER TABLE HINHANH
ADD FOREIGN KEY(MAUNGVIEN)REFERENCES HOSOTUYENDUNG(MAUNGVIEN),
	FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)

--------------------------------DEFAULT--------------------------

ALTER TABLE CHITIETHOPDONG
ADD CONSTRAINT MACDINH_TTTL DEFAULT (0) FOR LUONGTHOATHUAN

ALTER TABLE LOAIKHENTHUONG
ADD CONSTRAINT MACDINH_TTTTL DEFAULT (0) FOR TIENTHUONG

ALTER TABLE BANGTANGLUONG
ADD CONSTRAINT MACDINH_TTL DEFAULT (0) FOR TONGTIENTANG

ALTER TABLE TONGLUONG
ADD CONSTRAINT MACDINH_TL DEFAULT (0) FOR TONGTIENLUONG

ALTER TABLE CHITIETKHENTHUONG
ADD CONSTRAINT NGAY_KT DEFAULT (CONVERT (DATE,GETDATE(),120) ) FOR NGAYKHENTHUONG

ALTER TABLE BANGCHAMCONG
ADD CONSTRAINT NGAY_LAM DEFAULT (CONVERT (DATE,GETDATE(),120) ) FOR NGAYLAM

ALTER TABLE BANGTANGLUONG
ADD CONSTRAINT NGAY_TANGLUONG DEFAULT (CONVERT (DATE,GETDATE(),120) ) FOR NGAYBD



--NGAY HIEN TAI
SELECT CONVERT (DATE,GETDATE(),120)
--------------------------------------------------TRIGEER----------------------------------------------------------

---CHITIETHOPDONG
---- Luong thoa thuan luon > 0
CREATE TRIGGER LUONG_LON_0
ON CHITIETHOPDONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT LUONGTHOATHUAN FROM inserted) < 0
			ROLLBACK TRAN
	END

---NGAY KY SAU TRUOC HOAC BẰNG NGAY BẮT ĐẦU
---NGAY BAT DAU SAU NGAY KET THUC
CREATE TRIGGER NGAY_BATDAU
ON CHITIETHOPDONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT NGAYKY FROM inserted) < (SELECT NGAYBD FROM inserted)
			BEGIN
				IF(SELECT NGAYBD FROM inserted) > (SELECT NGAYKT FROM inserted)
				ROLLBACK TRAN
			END
		ELSE
			BEGIN
				ROLLBACK TRAN
			END
	END

---LOAIKHENTHUONG
---TIEN THUONG > 0
CREATE TRIGGER LUONG_THUONG
ON LOAIKHENTHUONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT TIENTHUONG FROM inserted) < 0
			ROLLBACK TRAN
	END

---CHUONGTRINHDAOTAO
CREATE TRIGGER NGAY_BATDAU_CTDT
ON CHUONGTRINHDAOTAO
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT NGAYBD FROM inserted) < (SELECT CONVERT (DATE,GETDATE(),120))
			BEGIN
				IF(SELECT NGAYBD FROM inserted) > (SELECT NGAYKT FROM inserted)
				ROLLBACK TRAN
			END
		ELSE
			BEGIN
				ROLLBACK TRAN
			END
	END
-----BANGCHAMCONG
--GIO RA SAU GIO VAO
CREATE TRIGGER GIO_RA
ON BANGCHAMCONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF (SELECT GIORA FROM inserted) < (SELECT GIOVAO FROM inserted)
		ROLLBACK TRAN
	END

----DANH MUC TANG CA
--SỐ GIO TANG CA >=0
CREATE TRIGGER TANG_CA
ON DANHMUCTANGCA
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT SOGIOTANGCA FROM inserted) < 0
		ROLLBACK TRAN
	END



-----BANGTANGLUONG
-- Ngay bat đầu từ ngày hiện tại trơ đi
-- mức tăng, tổng tiền tăng >=0
--tăng lần thứ >0
CREATE TRIGGER TANG_LUONG
ON BANGTANGLUONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT MUCTANG FROM inserted) < convert(float,0)
		ROLLBACK TRAN					
	END

CREATE TRIGGER TANG_LUONG1
ON BANGTANGLUONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT TONGTIENTANG FROM inserted) < 0
		ROLLBACK TRAN
	END

CREATE TRIGGER TANG_LUONG2
ON BANGTANGLUONG
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT TANGLANTHU FROM inserted) < 0
		ROLLBACK TRAN
	END

------DS_ky luât
---tiền kỷ luật > 0
CREATE TRIGGER TIEN_KLUAT
ON DS_KYLUAT
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT TIENKYLUAT FROM inserted) < 0
		ROLLBACK TRAN
	END

--quan ly thai san
---ngay ket thuc sau ngay bat dau, 6 tháng sau ngày bắt đầu
ALTER TRIGGER THAI_SAN
ON QUANLYTHAISAN
FOR INSERT, UPDATE
AS
	BEGIN
		IF(SELECT NGAYKETTHUC FROM inserted )IS NULL
		BEGIN
			UPDATE QUANLYTHAISAN 
			SET NGAYKETTHUC=CONVERT(DATE,DATEADD(MONTH,6,(SELECT NGAYBATDAU FROM inserted )))
			WHERE MAQUANLYTHAISAN=(SELECT MAQUANLYTHAISAN FROM inserted)
		END 
		
	END


-------khi kết quả tuyển dụng là đậu thì tự động thêm nhân viên
--CREATE TRIGGER TD_THEMNV
--ON KQ_TUYENDUNG
--FOR INSERT, UPDATE
--AS
--	BEGIN
--		IF(SELECT KETQUA FROM KQ_TUYENDUNG)='Đậu'
--		BEGIN
--		DECLARE @L INT
--		SET @L=(SELECT COUNT (*) FROM NHANVIEN )
--		DECLARE @M NVARCHAR(10)
--		SET @M='0'
--		WHILE @L
--			BEGIN
--				SET @M = @M+'0'
--			END

--			INSERT INTO NHANVIEN(MANV,HOTEN,MAPHONGBAN,MACHUCVU,NGAYVAOLAM,TINHTRANG,MAHOSO)
--			SELECT MANV
--		END
--	END







-----them nhan vien them tai khoan
--ALTER TRIGGER Them_NhanVien
--ON NHANVIEN
--FOR INSERT,UPDATE
--AS
--	BEGIN
--	IF (SELECT TINHTRANG FROM inserted)=N'Đi làm lại'
--	BEGIN

--		INSERT INTO NHANVIEN(MANV,HOTEN,MAPHONGBAN,MACHUCVU,NGAYVAOLAM,TINHTRANG,MAHOSO)
--			SELECT MANV='NV00000'+CONVERT(NVARCHAR(10),(SELECT COUNT(*) FROM NHANVIEN)),HOTEN=(SELECT HOTEN FROM deleted), MAPHONGBAN=(SELECT MAPHONGBAN FROM deleted), MACHUCVU=(SELECT MACHUCVU FROM deleted),NGAYVAOLAM=(SELECT (CONVERT(date, GETDATE(),120))),TINHTRANG='Đang làm', MAHOSO = (SELECT MAHOSO FROM DELETED)
--		INSERT INTO TAIKHOAN(MANV,MATKHAU,HOATDONG)
--			SELECT MANV=(SELECT MANV FROM inserted), MK=(SELECT REPLACE (CONVERT(NVARCHAR(10),(SELECT NGAYSINH FROM HOSOTUYENDUNG,inserted WHERE HOSOTUYENDUNG.MAUNGVIEN=inserted.MAHOSO)),'-','')), HOATDONG=1
--	END
--	ELSE
--	IF (SELECT TINHTRANG FROM inserted)=N'Nghỉ làm'
--	BEGIN
--		DELETE TAIKHOAN 
--		WHERE TAIKHOAN.MANV=(SELECT MANV FROM NHANVIEN WHERE TINHTRANG=N'Nghỉ làm')
--	END
--	ELSE
--	BEGIN
--		INSERT INTO TAIKHOAN(MANV,MATKHAU,HOATDONG)
--			SELECT MANV=(SELECT MANV FROM inserted), MK=(SELECT REPLACE (CONVERT(NVARCHAR(10),(SELECT NGAYSINH FROM HOSOTUYENDUNG,inserted WHERE HOSOTUYENDUNG.MAUNGVIEN=inserted.MAHOSO)),'-','')), HOATDONG=1
--	END
--	END
		
--SELECT REPLACE(CONVERT(NVARCHAR(10),(SELECT NGAYSINH FROM HOSOTUYENDUNG,NHANVIEN WHERE HOSOTUYENDUNG.MAUNGVIEN=NHANVIEN.MAHOSO and NHANVIEN.MAHOSO='HSTD0001')),'-','')




---------------------------------------------------NHẬP LIỆU-------------------------------------------------------
INSERT INTO  CHUCVU
VALUES  ('CVGD0001',N'Giám đốc '),
		('CVTP0001',N'Trưởng phòng nhân sự'),
		('CVTP0002',N'Trưởng phòng kế toán - tài chính'),
		('CVTP0003',N'Trường phòng marketing'),
		('CVTP0004',N'Trưởng phòng sản xuất'),
		('CVTP0005',N'Trưởng phòng kinh doanh'),
		('CVTP0006',N'Trưởng phòng hành chính'),
		('CVTP0007',N'Trưởng phòng tuyển dụng'),
		('CVNV0001',N'Nhân viên cao cấp'),
		('CVNV0002',N'Nhân viên văn phòng')	
-- MaPB, TenPB, Ma Trưởng Phòng
INSERT INTO PHONGBAN
VALUES ('PB000001',N'Phòng nhân sự',NULL),
		('PB000002',N'Phòng kế toán - tài chính',NULL),
		('PB000003',N'Phòng marketing',NULL),
		('PB000004',N'Phòng sản xuất',NULL),
		('PB000005',N'Phòng kinh doanh',NULL),
		('PB000006',N'Phòng hành chính',NULL),
		('PB000007',N'Phòng giám đốc',NULL)

--- chuyên môn đổi thành kỹ năng chuyên môn của nhân viên
INSERT INTO CHUYENMON
VALUES ('CM000001',N'Giao tiếp hiệu quả'),
		('CM000002',N'Tổ chức và sắp xếp thời gian khoa học'),
		('CM000003',N'Tin học văn phòng'),
		('CM000004',N'Làm việc nhóm hiệu quả'),
		('CM000005',N'Biết xử lý và giải quyết vấn đề'),
		('CM000006',N'Chăm sóc khách hàng'),
		('CM000007',N'Kỹ năng đàm phán và thuyết phục'),
		('CM000008',N'Khả năng chịu được áp lực'),
		('CM000009',N'Biết học hỏi'),
		('CM000010',N'Nghiên cứu và tổng hợp thông tin')



INSERT INTO TRINHDOHOCVAN
VALUES ('TDHV0001',N'Cử nhân'),
		('TDHV0002',N'Thạc sĩ'),
		('TDHV0003',N'Tiến sĩ'),
		('TDHV0004',N'PGS tiến sĩ'),
		('TDHV0005',N'Trung học phổ thông'),
		('TDHV0006',N'Trung học cơ sở'),
		('TDHV0007',N'Khác')

INSERT INTO TRINHDOTINHOC
VALUES ('TDTH0001',N'Chứng chỉ ứng dụng CNTT cơ bản'),
		('TDTH0002',N'Chứng chỉ ứng dụng CNTT nâng cao'),
		('TDTH0003',N'MOS'),
		('TDTH0004',N'IC3')

INSERT INTO NGOAINGU
VALUES ('NN000001',N'Tiếng anh'),
		('NN000002',N'Tiếng trung'),
		('NN000003',N'Tiếng nga'),
		('NN000004',N'Tiếng pháp'),
		('NN000005',N'Tiếng nhật'),
		('NN000006',N'Tiếng hàn'),
		('NN000007',N'Tiếng thái'),
		('NN000008',N'Tiếng canada'),
		('NN000009',N'Tiếng brazil'),
		('NN000010',N'Tiếng séc'),
		('NN000011',N'Tiếng ả rập'),
		('NN000012',N'Tiếng italia'),
		('NN000013',N'Tiếng thổ nhĩ kỳ'),
		('NN000014',N'Tiếng đan mạch'),
		('NN000015',N'Tiếng hà lan')



INSERT INTO DANTOC
VALUES ('DT000001',N'Kinh'),
		('DT000002',N'Hoa'),
		('DT000003',N'Tày'),
		('DT000004',N'Nùng'),
		('DT000005',N'Thái'),
		('DT000006',N'Mường'),
		('DT000007',N'Khơ me'),
		('DT000008',N'Dao'),
		('DT000009',N'Gia Rai'),
		('DT000010',N'Ê đê'),
		('DT000011',N'Ba na'),
		('DT000012',N'Chăm'),
		('DT000013',N'Cơ ho'),
		('DT000014',N'Sán dìu'),
		('DT000015',N'Sán chay')

INSERT INTO TONGIAO
VALUES ('TG000001',N'Phật giáo'),
		('TG000002',N'Kito giáo'),
		('TG000003',N'Hồi giáo'),
		('TG000004',N'Đạo giáo'),
		('TG000005',N'Nho giáo'),
		('TG000006',N'Thần giáo'),
		('TG000007',N'Do thái giáo'),
		('TG000008',N'Cao đài giáo'),
		('TG000009',N'Công giáo'),
		('TG000010',N'Hòa hảo'),
		('TG000011',N'Tin lành'),
		('TG000012',N'Ấn độ giáo'),
		('TG000013',N'Không tôn giáo'),
		('TG000014',N'Bà la môn'),
		('TG000015',N'Công giáo la mã')

INSERT INTO QUOCTICH
VALUES ('QT000001',N'Việt Nam'),
		('QT000002',N'Trung Quốc'),
		('QT000003',N'Nhật Bản'),
		('QT000004',N'Hàn Quốc'),
		('QT000005',N'Thái Lan'),
		('QT000006',N'Lào'),
		('QT000007',N'Campuchia'),
		('QT000008',N'Mỹ'),
		('QT000009',N'Canada'),
		('QT000010',N'Brazil'),
		('QT000011',N'Hà lan'),
		('QT000012',N'Nga'),
		('QT000013',N'Pháp'),
		('QT000014',N'Đức'),
		('QT000015',N'Thổ nhĩ kỳ')

SET DATEFORMAT DMY
INSERT INTO HOSOTUYENDUNG
VALUES ('HSTD0001','DT000001','TG000001','QT000001',N'Đặng Tuấn Anh',N'Nam','22/08/1994',N'Đồng Nai','123456789','24/07/2009',N'Đồng Nai',N'Đồng Nai',N'Biên Hòa - Đồng Nai',N'140 Lê Trọng Tấn','0123456789','dangtuananh123@gmail.com',N'Độc thân',N'Không',N'Tốt',N'10/01/2018',N'Trực tiếp',N'Trưởng phòng nhân sự','TDHV0001','TDTH0002')
SET DATEFORMAT DMY
INSERT INTO HOSOTUYENDUNG
VALUES	('HSTD0002','DT000001','TG000001','QT000001',N'ĐặnG Anh',N'Nam','22/08/1994',N'Đồng Nai','123456789','24/07/2009',N'Đồng Nai',N'Đồng Nai',N'Biên Hòa - Đồng Nai',N'140 Lê Trọng Tấn','0123456789','dangtuananh123@gmail.com',N'Độc thân',N'Không',N'Tốt',N'10/01/2018',N'Trực tiếp',N'Trưởng phòng nhân sự','TDHV0001','TDTH0002')

INSERT INTO CHITIETCHUYENMON
VALUES ('CM000001','HSTD0001')

INSERT INTO CHITIETNGOAINGU
VALUES ('NN000001','HSTD0001')

SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES ('NV000001',N'Đặng Tuấn Anh','PB000001','CVTP0001','15/02/2018',N'Đang làm','HSTD0001')
SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES ('NV000002',N'Đỗ Gia Hoàng Bảo','PB000002','CVTP0002','20/10/2000',N'Đang làm','HSTD0002')
--		('NV000003','Trần Thị Minh Châu','PB000003','CVTP0003','11/01/2016',N'Đang làm'),
--		('NV000004','Tăng Phương Chi','PB000004','CVTP0004','06/07/2011',N'Đang làm'),
--		('NV000005','Phạm Tiến Dũng','PB000005','CVTP0005','05/11/2002',N'Đang làm'),
--		('NV000006','Nguyễn Thái Duy','PB000006','CVTP0006','24/09/2010',N'Đang làm'),
--		('NV000007','Mạc Trung Đức','PB000007','CVTP0007','10/11/2017',N'Đang làm'),
--		('NV000008','Vũ Hương Giang','PB000008','CVGD0001','11/02/2012',N'Đang làm'),

--		('NV000009','Nguyễn Thị Ngân Hà','PB000001','CVNV0001','17/12/2002',N'Đang làm'),
--		('NV000010','Nguyễn Lê Hiếu','PB000001','CVNV0001','09/02/2019',N'Đang làm'),
--		('NV000011','Phạm Xuân Hòa','PB000001','CVNV0001','15/08/2018',N'Đang làm'),
--		('NV000012','Nguyễn Mạnh Hùng','PB000001','CVNV0002','21/11/2000',N'Đã nghỉ'),
--		('NV000013','Nguyễn Vũ Gia Hưng','PB000001','CVNV0002','15/02/2018',N'Đang làm'),
--		('NV000014','Phạm Gia Minh','PB000001','CVNV0002','15/12/2019',N'Đang làm'),
--		('NV000015','Đỗ Hoàng Mỹ','PB000001','CVNV0002','25/10/2014',N'Đang làm'),

--		('NV000016','Đỗ Quang Ngọc','PB000002','CVNV0001','17/12/2002',N'Đang làm'),
--		('NV000017','Đàm Yến Nhi','PB000002','CVNV0001','09/02/2019',N'Đang làm'),
--		('NV000018','Đoàn Hoàng Sơn','PB000002','CVNV0001','15/08/2018',N'Đang làm'),
--		('NV000019','Nguyễn Công Thành','PB000002','CVNV0002','21/11/2000',N'Đã nghỉ'),
--		('NV000020','Bùi Phương Thảo','PB000002','CVNV0002','15/02/2018',N'Đang làm'),
--		('NV000021','Nguyễn Hương Thảo','PB000002','CVNV0002','15/12/2019',N'Đang làm'),
--		('NV000022','Phạm Xuân Hòa','PB000003','CVNV0002','25/10/2014',N'Đang làm')

INSERT INTO TAIKHOAN
VALUES ('NV000001',N'abc',1)


INSERT INTO NHOMNGUOIDUNG
VALUES ('NND01',N'Nhóm giám đốc',''),
		('NND02',N'Nhóm trưởng phòng',''),
		('NND03',N'Nhóm nhân viên','')

INSERT INTO NGUOIDUNGNHOMNGUOIDUNG
VALUES ('NV000001','NND02','')
--,
--		('NV000010','NND03',''),
--		('NV000011','NND03',''),
--		('NV000012','NND03',''),
--		('NV000013','NND03','')

INSERT INTO MANHINH
VALUES 	('MH01',N'Hồ sơ nhân viên'),
		('MH02',N'Hồ sơ ứng viên'),
		('MH03',N'Lương'),
		('MH04',N'Khen thưởng kỷ luật'),
		('MH05',N'Chấm công'),
		('MH06',N'Thống kê'),
		('MH07',N'Chương trình đào tạo')
		

INSERT INTO PHANQUYEN
VALUES ('MH07','NND01',1),
		('MH02','NND02',1),
		('MH02','NND03',1)

INSERT INTO HOPDONGLAODONG
VALUES ('HDLD0001',N'Không thời hạn'),
		('HDLD0002',N'12 tháng'),
		('HDLD0003',N'24 tháng'),
		('HDLD0004',N'36 tháng')

SET DATEFORMAT DMY
INSERT INTO CHITIETHOPDONG
VALUES ('CTHD0001','HDLD0002','NV000001',2,'01/01/2019','01/01/2019','01/01/2020',12000000)
--,
--		('CTHD0002','HDLD0001','NV000002',1,'20/10/2000','20/10/2000','20/10/2001',15000000)

INSERT INTO LOAIKHENTHUONG
VALUES ('LKT00001',N'Khen thưởng lễ','1000000'),
		('LKT00002',N'Khen thưởng tháng 13','1000000'),
		('LKT00003',N'Khen thưởng chuyên cần','1000000')

SET DATEFORMAT DMY
INSERT INTO CHITIETKHENTHUONG
VALUES ('CTKT0001','LKT00001','NV000001','30/04/2018'),
		('CTKT0002','LKT00002','NV000001','30/12/2018'),
		('CTKT0003','LKT00003','NV000001','30/08/2018')
		--,
		--('CTKT0004','LKT00002','NV000002','30/12/2018')

INSERT INTO DAOTAO
VALUES ('KDT01',N'Đào tạo tin học văn phòng'),
		('KDT02',N'Đào tạo nhân viên đầu vào'),
		('KDT03',N'Đào tạo sử dụng phần mềm'),
		('KDT04',N'Đào tạo trưởng phòng ')

SET DATEFORMAT DMY
INSERT INTO CHUONGTRINHDAOTAO
VALUES ('CTDT0001','KDT01','NV000001','01/01/2019','01/03/2019'),
		('CTDT0002','KDT03','NV000001','01/01/2019','01/03/2019')
		--,
		--('CTDT0003','KDT04','NV000002','01/01/2019','01/03/2019')

SET DATEFORMAT DMY
INSERT INTO BAOHIEM
VALUES ('BH01','NV000001',N'Y tế',N'TP HCM',N'Bệnh viện 115','01/01/2019','31/12/2019')
--,
--		('BH02','NV000002','Y tế','TP HCM','Bệnh viện quận Tân Phú','01/01/2019','31/12/2019')

SET DATEFORMAT DMY
INSERT INTO BANGCHAMCONG
VALUES ('NV000001','01/01/2019','08:00am','17:00pm'),
		('NV000001','02/01/2019','08:00am','17:00pm'),
		('NV000001','03/01/2019','08:00am','17:00pm'),
		('NV000001','04/01/2019','08:00am','17:00pm')
SET DATEFORMAT DMY
INSERT INTO BANGCHAMCONG
VALUES ('NV000001','12/10/2019','08:00','17:00')

INSERT INTO DANHMUCTANGCA
VALUES ('LC01',N'Tăng lễ',3,8),
		('LC02',N'Tăng chủ nhật lễ',4,8),
		('LC03',N'Tăng chủ nhật',2,8),
		('LC04',N'Tăng tối',1,4)

SET DATEFORMAT DMY
INSERT INTO BANGTANGCA
VALUES ('NV000001','01/01/2019','LC01'),
		('NV000001','19/05/2019','LC03')
		--,
		--('NV000002','19/05/2019','LC03'),
		--('NV000003','19/05/2019','LC03')

SET DATEFORMAT DMY
INSERT INTO BANGTANGLUONG
VALUES ('BTL00001','NV000001','01/01/2018','0.2','','1')
--,
--		('BTL00002','NV000002','01/01/2018','0.1','','2'),
--		('BTL00003','NV000002','01/01/2019','0.1','','3')

INSERT INTO DS_KYLUAT
VALUES ('KL001',N'Chuyên cần',N'Hành chính','200000'),
		('KL002',N'Trộm cắp',N'Đuổi việc','0'),
		('KL003',N'Tiết lộ bí mật kinh doanh',N'Đuổi việc','0')

SET DATEFORMAT DMY
INSERT INTO QUANLYKYLUAT
VALUES ('QLKL0001','NV000001','KL001','02/03/2018',N'Phòng hành chính')
--,
--		('QLKL0002','NV000012','KL002','20/05/2018','Phòng hành chính'),
--		('QLKL0003','NV000003','KL001','16/07/2015','Phòng hành chính'),
--		('QLKL0004','NV000004','KL001','02/03/2018','Phòng hành chính'),
--		('QLKL0005','NV000019','KL003','02/03/2018','Phòng hành chính')

SET DATEFORMAT DMY
--INSERT INTO QUANLYNGHIVIEC
--VALUES ('QLNV0001','NV000012','1','20/05/2018','Trưởng phòng hành chính','20/05/2018','Trộm cắp đồ công ty')
--,
--		('QLNV0002','NV000019','1','02/03/2018','Trưởng phòng hành chính','02/03/2018','Tiết lộ bí mật kinh doanh')

--SET DATEFORMAT DMY
--INSERT INTO QUANLYTHAISAN
--VALUES ('QLTS0001','NV000003','1','1','15/02/2017','Phòng hành chính','15/2/2017','15/08/2017'),
--		('QLTS0002','NV000009','1','1','24/06/2006','Phòng hành chính','24/06/2006','24/12/2006'),
--		('QLTS0003','NV000015','1','1','19/11/20016','Phòng hành chính','19/11/20016','19/05/2017')


INSERT INTO KQ_TUYENDUNG
VALUES ('KQTD0001','HSTD0001',N'Đậu')

INSERT INTO HINHANH
VALUES ('HA001',N'Nhân Viên 1','../Hinh NhanVien/chup-hinh-the-dep-41.jpg','NV000001','HSTD0001')

------------------------------------------------------------------------------------
-----------------------------------TRIGGER------------------------------------------

/*lương của 1 tháng 
CREATE TRIGGER LUONG_THANG
ON BANGTANGLUONG
FOR  INSERT, UPDATE
AS
BEGIN
	UPDATE BANGTANGLUONG
	SET LUONGTHANG =(SELECT LUONGTHOATHUAN FROM CHITIETHOPDONG,inserted WHERE MANV=CHITIETHOPDONG.MANV AND inserted.MANV=MANV ) *MUCTANG +(SELECT LUONGTHOATHUAN FROM CHITIETHOPDONG,inserted WHERE CHITIETHOPDONG.MANV=MANV AND inserted.MANV=MANV)
	WHERE MANV =(SELECT MANV FROM inserted)
END
*/
