DROP PROCEDURE esptesMPCobranzaKSKGuardar
GO
CREATE PROCEDURE esptesMPCobranzaKSKGuardar
(
@pid int,
@pstatus nvarchar(100),
@pexternal_reference nvarchar(100),
@ppay_transaction_amount decimal(18,2),
@ppay_status nvarchar(100),
@pdate_created nvarchar(100),
@pcol_id int,
@pcol_email nvarchar(100),
@pcol_nickname nvarchar(100),
@pAPagar decimal(18,2) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM esptesMPCobranzaKSK WHERE (id = @pid)))
BEGIN 
	UPDATE esptesMPCobranzaKSK
	SET		status = @pstatus,
		external_reference = @pexternal_reference,
		pay_transaction_amount = @ppay_transaction_amount,
		pay_status = @ppay_status,
		date_created = @pdate_created,
		col_id = @pcol_id,
		col_email = @pcol_email,
		col_nickname = @pcol_nickname,
		APagar = @pAPagar
	WHERE (id = @pid)
END 
ELSE 
BEGIN 
	INSERT INTO esptesMPCobranzaKSK
	(
		id,
		status,
		external_reference,
		pay_transaction_amount,
		pay_status,
		date_created,
		col_id,
		col_email,
		col_nickname,
		APagar
	)
	VALUES 
	(
		@pid,
		@pstatus,
		@pexternal_reference,
		@ppay_transaction_amount,
		@ppay_status,
		@pdate_created,
		@pcol_id,
		@pcol_email,
		@pcol_nickname,
		@pAPagar
	)
END 

GO

DROP PROCEDURE esptesMPCobranzaKSKDatos
GO
CREATE PROCEDURE esptesMPCobranzaKSKDatos
(
@pid int
)
AS
SET NOCOUNT ON 

SELECT esptesMPCobranzaKSK.id, esptesMPCobranzaKSK.status, esptesMPCobranzaKSK.external_reference, esptesMPCobranzaKSK.pay_transaction_amount,
	esptesMPCobranzaKSK.pay_status, esptesMPCobranzaKSK.date_created, esptesMPCobranzaKSK.col_id, esptesMPCobranzaKSK.col_email,
	esptesMPCobranzaKSK.col_nickname, esptesMPCobranzaKSK.APagar
FROM esptesMPCobranzaKSK 
WHERE (id = @pid)
 
RETURN @@Error 

GO

DROP PROCEDURE esptesMPCobranzaKSKEliminar
GO
CREATE PROCEDURE esptesMPCobranzaKSKEliminar
(
@pid int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM esptesMPCobranzaKSK 
WHERE (id = ISNULL(@pid, id))
 
 RETURN @@Error 

GO

GO
