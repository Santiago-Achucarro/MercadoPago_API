IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 43.02)
begin

Drop Index comOCSegmentos.XAK1genOCSegmentos;

CREATE UNIQUE NONCLUSTERED INDEX XAK1genOCSegmentos ON comOCSegmentos
( 
	Segmento1C            ASC,
	Segmento2C            ASC,
	Segmento3C            ASC,
	Segmento4C            ASC,
	Segmento2N            ASC,
	Segmento3N            ASC,
	Segmento4N            ASC,
	Segmento1N            ASC,
	Empresa_Id            ASC
)
INSERT INTO genVersion(Version) Values(43.02);

End


