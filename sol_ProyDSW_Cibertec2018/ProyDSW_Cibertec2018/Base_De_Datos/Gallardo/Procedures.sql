USE BD_DSWI
GO

IF OBJECT_ID('USP_LISTAR_EMPLEADOS','P') IS NOT NULL
	DROP PROCEDURE USP_LISTAR_EMPLEADOS
GO
CREATE PROCEDURE USP_LISTAR_EMPLEADOS
AS
	SELECT E.CODEMP,E.NOMEMP,D.NOMDIS,E.DIRECCION,E.DNI,E.EMAIL,E.TURNO,E.CELULAR,E.FEC_ING,C.NOMCARGO,E.ELIMINADO,E.CONTRA
	FROM TBEMPLEADOS E INNER JOIN TBDISTRITO D
		ON E.CODDIS = D.CODDIS INNER JOIN TBCARGO C
			ON E.CODCARGO = C.CODCARGO
GO



IF OBJECT_ID('USP_ELIMINAR_EMPLEADOS_LOGIC','P') IS NOT NULL
	DROP PROCEDURE USP_ELIMINAR_EMPLEADOS_LOGIC
GO
CREATE PROCEDURE USP_ELIMINAR_EMPLEADOS_LOGIC
@XCODEMP CHAR(5)
AS
	UPDATE TBEMPLEADOS
	SET ELIMINADO = 'SI'
	WHERE CODEMP = @XCODEMP
GO


IF OBJECT_ID('USP_INSERTAR_EMPLEADOS','P') IS NOT NULL
	DROP PROCEDURE USP_INSERTAR_EMPLEADOS
GO
CREATE PROCEDURE USP_INSERTAR_EMPLEADOS
@XCODEMP CHAR(5),@XNOMEMP VARCHAR(50),@XCODDIS CHAR(5),@XDIRECCION VARCHAR(50),
@XDNI CHAR(8),@XEMAIL VARCHAR(50),@XTURNO CHAR(1),@XCELULAR CHAR(9),@XFEC_ING DATE,@XCODCARGO CHAR(5)
AS
	INSERT INTO TBEMPLEADOS(CODEMP,NOMEMP,CODDIS,DIRECCION,DNI,EMAIL,TURNO,CELULAR,FEC_ING,CODCARGO)
	 VALUES (@XCODEMP,@XNOMEMP,@XCODDIS,@XDIRECCION,@XDNI,@XEMAIL,@XTURNO,@XCELULAR,
									@XFEC_ING,@XCODCARGO)
GO


IF OBJECT_ID('USP_ACTUALIZAR_EMPLEADOS','P') IS NOT NULL
	DROP PROCEDURE USP_ACTUALIZAR_EMPLEADOS
GO
CREATE PROCEDURE USP_ACTUALIZAR_EMPLEADOS
@XCODEMP CHAR(5),@XNOMEMP VARCHAR(50),@XCODDIS CHAR(5),@XDIRECCION VARCHAR(50),
@XDNI CHAR(8),@XEMAIL VARCHAR(50),@XTURNO CHAR(1),@XCELULAR CHAR(9),@XFEC_ING DATE,@XCODCARGO CHAR(5),@XCONTRA VARCHAR(25)
AS
	UPDATE TBEMPLEADOS
	SET NOMEMP = @XNOMEMP,
		CODDIS = @XCODDIS,
		DIRECCION = @XDIRECCION,
		DNI = @XDNI,
		EMAIL=@XEMAIL,
		TURNO = @XTURNO,
		CELULAR = @XCELULAR,
		FEC_ING = @XFEC_ING,
		CODCARGO = @XCODCARGO,
		CONTRA=@XCONTRA
	WHERE CODEMP = @XCODEMP
GO




--***********************************************************
IF OBJECT_ID('USP_LISTAR_CARGOS','P') IS NOT NULL
	DROP PROCEDURE USP_LISTAR_CARGOS
GO
CREATE PROCEDURE USP_LISTAR_CARGOS
AS
	SELECT C.CODCARGO,C.NOMCARGO
	FROM TBCARGO C
GO

IF OBJECT_ID('USP_LISTAR_DISTRITOS','P') IS NOT NULL
	DROP PROCEDURE USP_LISTAR_DISTRITOS
GO
CREATE PROCEDURE USP_LISTAR_DISTRITOS
AS
	SELECT D.CODDIS,D.NOMDIS
	FROM TBDISTRITO D
GO