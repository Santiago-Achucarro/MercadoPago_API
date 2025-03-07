ALTER Table venMovConStockCr Add CantEntregadaForm QCantidadD8 NULL
go

Update venMovConStockCr set CantEntregadaForm = CantEntregada * Factor
GO

ALTER Table venMovConStockCr Alter Column CantEntregadaForm QCantidadD8  NOT NULL
go

if ((select Dominio_Id from genInstalacion ) = 'MX')
BEGIN

Update genSegmentos set Origen1N = 0, Origen4C = 1, TieneColumnaAutomatica = 0, 
	Orden1C = 2, Orden2C = 1, Orden3C = 3, Orden4C =4, Orden1N = 0,
	Digitos4C = 20, Digitos1N = 0 where Segmento_Id = 'FPRO'

Update genSegmentosNombres set Nombre4C = 'Folio' where Segmento_Id = dbo.FuncFKgenSegmentos('FPRO')

Update genAsiSegmentos SET Segmento4C =  rtrim(str(Segmento1N,10))+Segmento4C  where Segmento_Id = dbo.FuncFKgenSegmentos('FPRO')
Update genAsiSegmentos SET Segmento1N = 0 where Segmento_Id = dbo.FuncFKgenSegmentos('FPRO')

END
GO
Alter table ComCfdiSat Alter Column Folio VarChar(25) 
GO

INSERT INTO genVersion (Version) Values(1026.00)
GO

