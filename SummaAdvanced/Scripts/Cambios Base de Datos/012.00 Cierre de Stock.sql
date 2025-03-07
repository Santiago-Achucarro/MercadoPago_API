IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 12.00)
begin

INSERT INTO genVersion(Version) Values(12.00);

CREATE Table stkProductosCostoCierre(
Producto_Id int NOT NULL,
Empresa_Id Int Not null, 
Fecha DateTime NOT NULL, 
Costo Numeric(19,8) NOT NULL, 
Primary key(Empresa_Id, Fecha, Producto_Id)
);

CREATE Table stkMoviCRevaluo(
	stkMoviCabeReva BigInt NOT NULL, 
	stkMoviCabe BigInt NOT NULL, 
	primary key(stkMoviCabeReva));

ALTER TABLE stkMoviCRevaluo ADD Foreign Key (stkMoviCabeReva) references stkmovicabe;


ALTER TABLE stkMoviCRevaluo ADD Foreign Key (stkMoviCabe) references stkmovicabe;

CREATE INDEX idxstkMoviCRevaluoC  ON stkMoviCRevaluo (stkMoviCabe);

-- Para Arreglar error de Asiento
update stkmovicuerpo set conRenglonHaber = 0 where conRenglonDebe = conRenglonHaber;

insert into stkMoviCRevaluo(stkMoviCabeReva, stkMoviCabe)
select stkMoviCabe, stkMoviCabe-1 from stkMoviCabe WHERE  SubTipoMov_Id = 'RV';

END
