IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 16.00)
begin

INSERT INTO genVersion(Version) Values(16.00);

INSERT INTO comMovTipos(TipoMov, Descripcion, Signo) Values('V', 'Ajuste Positivo Estado de Cuenta', 1)
INSERT INTO comMovTipos(TipoMov, Descripcion, Signo) Values('W', 'Ajuste Negativo Estado de Cuenta', -1)


END


