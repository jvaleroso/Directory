use directory
go

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type IN (N'U'))
	BEGIN
		CREATE TABLE City(
			Id BIGINT Identity(1,1) NOT NULL,
			Name NVARCHAR(20) NOT NULL,
			ProvinceId BIGINT NOT NULL,
			PRIMARY KEY (Id)
		)
	END
ELSE
	BEGIN
		DROP TABLE City
	END
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Province]') AND type IN (N'U'))
	BEGIN
		CREATE TABLE Province(
			Id BIGINT Identity(1,1) NOT NULL,
			Name NVARCHAR(20) NOT NULL,
			Code NVARCHAR(20) NOT NULL,
			PRIMARY KEY (Id)
		)
	END
ELSE
	BEGIN
		ALTER TABLE City ALTER COLUMN ProvinceId BIGINT NULL
	END




ALTER TABLE City ADD CONSTRAINT FK_City_Province 
FOREIGN KEY (ProvinceId)
REFERENCES Province(Id)
