
USE BD_DSWI
GO

CREATE TABLE TBL_LOGIN
(
	COD INT PRIMARY KEY IDENTITY(1,1),
	USERS VARCHAR(32),
	PASSWORDD VARCHAR(32)
)
GO

select * from TBL_LOGIN
GO


INSERT INTO TBL_LOGIN VALUES ('jose','123')
GO

 create proc usp_lista_login
 as
	select users,passwordd from TBL_LOGIN
	go


	execute usp_lista_login

	-- Esto es de prueba, luego implementarlo de verdad a la bd