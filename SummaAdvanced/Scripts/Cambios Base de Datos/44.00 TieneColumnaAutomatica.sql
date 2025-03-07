IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 44.00)
begin


ALTER TABLE genContadorSegmento ADD TieneColumnaAutomatica Bit


end
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 44.00)
begin

UPDATE genContadorSegmento SET TieneColumnaAutomatica = genSegmentos.TieneColumnaAutomatica 
	FROM  genSegmentos WHERE
		genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id

ALTER TABLE genContadorSegmento Alter Column TieneColumnaAutomatica SiNo

INSERT INTO genVersion(Version) Values(44.00);

END