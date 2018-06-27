USE MASTER
GO

IF DB_ID ('BD_DSWI') IS NOT NULL 
 	BEGIN 
 	 	ALTER DATABASE BD_DSWI
		SET SINGLE_USER WITH ROLLBACK IMMEDIATE
		DROP DATABASE BD_DSWI
 	END 
GO

CREATE DATABASE BD_DSWI
COLLATE MODERN_SPANISH_CI_AI
GO

USE BD_DSWI
GO

SET LANGUAGE SPANISH
GO

SET DATEFORMAT DMY
GO

IF OBJECT_ID ('TBDISTRITO','U') IS NOT NULL
	BEGIN
		DROP TABLE TBDISTRITO
	END
GO
CREATE TABLE TBDISTRITO(
	CODDIS CHAR(5) PRIMARY KEY,
	NOMDIS VARCHAR(50)
)
GO

IF OBJECT_ID ('TBCLIENTES','U') IS NOT NULL
	BEGIN
		DROP TABLE TBCLIENTES
	END
GO
CREATE TABLE TBCLIENTES(
	CODCLI CHAR(5) PRIMARY KEY,
	NOMCLI VARCHAR(50),
	CODDIS CHAR(5) FOREIGN KEY REFERENCES TBDISTRITO(CODDIS),
	DIRECCION VARCHAR(50),
	DNI CHAR(8),
	EMAIL VARCHAR(50),
	CELULAR CHAR(9),
	ELIMINADO CHAR(2)
)
GO
IF OBJECT_ID ('TBCARGO','U') IS NOT NULL
	BEGIN
		DROP TABLE TBCARGO
	END
GO
CREATE TABLE TBCARGO(
CODCARGO INT PRIMARY KEY,
NOMCARGO VARCHAR(50)
)
GO
IF OBJECT_ID ('TBEMPLEADOS','U') IS NOT NULL
	BEGIN
		DROP TABLE TBEMPLEADOS
	END
GO
CREATE TABLE TBEMPLEADOS(
	CODEMP CHAR(5) PRIMARY KEY,
	NOMEMP VARCHAR(50),
	CODDIS CHAR(5) FOREIGN KEY REFERENCES TBDISTRITO(CODDIS),
	DIRECCION VARCHAR(50),
	DNI CHAR(8),
	CELULAR CHAR(9),
	FEC_ING DATE,
	CODCARGO INT FOREIGN KEY REFERENCES TBCARGO(CODCARGO),
	ELIMINADO CHAR(2)
)
GO

IF OBJECT_ID ('TBTIPO','U') IS NOT NULL
	BEGIN
		DROP TABLE TBTIPO
	END
GO
CREATE TABLE TBTIPO(
	CODTIPO CHAR(5) PRIMARY KEY,
	DESCRIPCION VARCHAR(50)
)
GO

IF OBJECT_ID ('TBPRODUCTO','U') IS NOT NULL
	BEGIN
		DROP TABLE TBPRODUCTO
	END
GO
CREATE TABLE TBPRODUCTO(
	CODPRO CHAR(5) PRIMARY KEY,
	NOMPRO VARCHAR(50),
	DESCRIPCION VARCHAR(250),
	PESO_TAMAN VARCHAR(250), 
	STOCK INT,
	PRECIO MONEY,
	CODTIPO CHAR(5) FOREIGN KEY REFERENCES TBTIPO(CODTIPO),
	ELIMINADO CHAR(2)
)
GO
IF OBJECT_ID ('TBBOLETA','U') IS NOT NULL
	BEGIN
		DROP TABLE TBBOLETA
	END
GO
CREATE TABLE TBBOLETA(
NROBOL VARCHAR(12) PRIMARY KEY,
CODCLI CHAR(5) FOREIGN KEY REFERENCES TBCLIENTES(CODCLI),
CODEMP CHAR(5) REFERENCES TBEMPLEADOS(CODEMP) NULL,
FECHAEMICION DATETIME,
FECHAVENC DATETIME,
ESTADO INT
)
GO
IF OBJECT_ID ('TBDETALLE_BOLETA','U') IS NOT NULL
	BEGIN
		DROP TABLE TBDETALLE_BOLETA
	END
GO
CREATE TABLE TBDETALLE_BOLETA(
NROBOL VARCHAR(12) FOREIGN KEY REFERENCES TBBOLETA(NROBOL),
CODPRO CHAR(5) FOREIGN KEY REFERENCES TBPRODUCTO(CODPRO),
CANTIDAD INT,
PRECIO DECIMAL(8,2)
)
GO
IF OBJECT_ID ('TBDESPACHO','U') IS NOT NULL
	BEGIN
		DROP TABLE TBDESPACHO
	END
GO
CREATE TABLE TBDESPACHO(
NRODESPACHO CHAR(5) PRIMARY KEY,
FECHATRASLADO DATETIME,
FECHAENTREGA DATETIME NULL,
DESTINO CHAR(5) REFERENCES TBDISTRITO(CODDIS),
TRANSPORTISTA CHAR(5) REFERENCES TBEMPLEADOS(CODEMP),
ESTADO INT
)
GO
IF OBJECT_ID ('TBDETALLE_DESPACHO','U') IS NOT NULL
	BEGIN
		DROP TABLE TBDETALLE_DESPACHO
	END
GO
CREATE TABLE TBDETALLE_DESPACHO(
NRODESPACHO CHAR(5) FOREIGN KEY REFERENCES TBDESPACHO(NRODESPACHO),
NROBOL VARCHAR(12) FOREIGN KEY REFERENCES TBBOLETA(NROBOL),
NROCAJAS INT,
)
GO