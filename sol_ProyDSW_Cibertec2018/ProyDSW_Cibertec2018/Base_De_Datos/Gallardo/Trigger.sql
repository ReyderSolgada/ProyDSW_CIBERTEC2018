USE BD_DSWI
GO


CREATE TRIGGER TG_GENERA_CONTRAS_EMPLEADO
ON TBEMPLEADOS
AFTER  INSERT
AS 
BEGIN 
DECLARE @NOM CHAR(4)
DECLARE @DNI CHAR(4)
DECLARE @ID CHAR(5)
DECLARE @EMAIL varchar(50)
DECLARE @MENSAJE varchar(160)

	SELECT @NOM=SUBSTRING(inserted.NOMEMP,0,5),@DNI=SUBSTRING(inserted.DNI,0,5), @ID=inserted.CODEMP,@EMAIL=inserted.EMAIL FROM inserted
	UPDATE TBEMPLEADOS SET TBEMPLEADOS.CONTRA=CONCAT(@NOM,@DNI)
	WHERE TBEMPLEADOS.CODEMP=@ID

	SELECT @MENSAJE='Esta es su contraseña Autogenerada:    ' + CONTRA + '<br/>' +' Por Favor Cambiar La Contraseña
	 desde la configuracion de usuarios.' from TBEMPLEADOS

	EXEC  msdb.dbo.sp_send_dbmail 
	@profile_name='GallardoEnvio',
	@recipients= @EMAIL,
	@subject= 'Envio de Contraseña C#',
	@body=@MENSAJE,
	@body_format = 'HTML'

END