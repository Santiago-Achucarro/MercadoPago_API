IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 1005.05)
begin
ALTER TABLE disControlesGrilla ADD ColumnaColorFondoFila varchar(35)
ALTER TABLE disControlesGrilla ADD ColumnaColorTextoFila varchar(35)

ALTER TABLE disControlesGrillaColumnas ADD ColumnaColorFondoCelda varchar(35)
ALTER TABLE disControlesGrillaColumnas ADD ColumnaColorTextoCelda varchar(35)

ALTER TABLE disControlesTexto ADD Mascara varchar(40)


ALTER TABLE lupIdentidades ADD CharCasing varchar(6)
ALTER TABLE lupIdentidades ADD Mascara varchar(40)
ALTER TABLE lupIdentidades ADD MaximaLongitud int

exec TempdisDisenioCopiarActual

INSERT INTO genVersion(Version) Values(1005.05);

end
GO



