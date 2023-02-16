/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [MaNV]
      ,[TenNV]
      ,[GT]
      ,[SDT]
      ,[ChucVu]
      ,[DiaChi]
  FROM [CAFE].[dbo].[NhanVien]

  select * from NhanVien where ChucVu = 'Thu Ngân';

  select * from NhanVien where ChucVu = 'Pha Chế';

  select * from NhanVien;