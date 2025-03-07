Alter table venClientes Add
	FacturaCredito       Sino  NULL ,
	MontoFacturaCredito  qMonedaD2  NULL ,
	CbuBanco             varchar(22)  NULL

if NOT exists(select 1 from venTipoMov where venTipoMov = 'I')
	Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('I', 'Factura de cr�dito electr�nica MyPymes', 1, 'FCR')
if NOT exists(select 1 from venTipoMov where venTipoMov = 'B')
	Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('B', 'Nota de d�bito de cr�dito electr�nica MyPymes', 1, 'DCR')
Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('E', 'Nota de cr�dito de cr�dito electr�nica MyPymes', 1, 'CCR')

Insert Into genVersion (Version) Values (92.10)
Go
