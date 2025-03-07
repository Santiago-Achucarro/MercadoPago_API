
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 17.00)
begin

INSERT INTO genVersion(Version) Values(17.00);

Create Table comOCAntiRecepcion 
(
	comAntiRecepcion bigint,
	comOcRecepcion BigInt, 
	Primary Key(comAntiRecepcion)
);

INSERT INTO tesRengConciliac
		SELECT tesRengMovi.tesMovimientos, tesRengMovi.conRenglon, 
			conMovCont.ImporteMonedaOriginal
		 from tesRengMovi INNER JOIN conMovCont ON
		tesRengMovi.tesMovimientos = conMovCont.conAsientos And
		tesRengMovi.conRenglon = conMovCont.Renglon
		INNER JOIN tesIdentifica ON
		tesIdentifica.tesIdentifica =tesRengMovi.Cartera_Id
		INNER JOIN tesTiposId ON
		tesTiposId.tesTiposId = tesIdentifica.TipoCartera
		where tesTiposId.TipoCartera = 'CP' AND 
			NOT EXISTS(SELECT 1 FROM tesRengConciliac WHERE
			tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos AND 
			tesRengConciliac.conRenglon = tesRengMovi.conRenglon);

Alter table tesRengConcilEsp Add Importe QmonedaD2;

DROP INDEX XIE1tesCheqTerceros ON dbo.tesCheqTerceros;

Alter table tesCheqTerceros Alter Column BancoConc Int;

CREATE INDEX XIE1tesCheqTerceros ON dbo.tesCheqTerceros
(
	BancoConc ,
	NumeroConc
);

Alter table tesCheqTerceros Alter Column BancoConcVta Int;

exec Borra_cuerpoForm 'tesIdCheqTerceros';
delete from disControles where Formulario_Id =dbo.FuncFKdisFormularios('tesIdCheqTerceros');
delete from disFormularios where Formulario_Id ='tesIdCheqTerceros';

end


		
		



