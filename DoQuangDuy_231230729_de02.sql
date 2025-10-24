-- Tạo database
CREATE DATABASE [DoQuangDuy_231230729_de02];
GO
USE [DoQuangDuy_231230729_de02];
GO

-- Tạo bảng HvtCatalog
CREATE TABLE dqdCatalog (
    dqdId INT IDENTITY(1,1) PRIMARY KEY,
    dqdCateName NVARCHAR(200) NOT NULL,
    dqdCatePrice DECIMAL(18,2) NOT NULL,
    dqdCateQty INT NOT NULL,
    dqdPicture NVARCHAR(500) NULL,
    dqdCateActive BIT NOT NULL
);
GO

INSERT INTO dqdCatalog (dqdCateName, dqdCatePrice, dqdCateQty, dqdPicture, dqdCateActive)
VALUES
('DoQuangDuy', 231230729 , 10, 'sp_a.jpg', 1),
('San pham A', 150.00, 10, 'sp_a.jpg', 1),
('San pham B', 300.00, 5, 'sp_b.jpg', 1),
('San pham C', 450.00, 2, 'sp_c.jpg', 0);

GO
