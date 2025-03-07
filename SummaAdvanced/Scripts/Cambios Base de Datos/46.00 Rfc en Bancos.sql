IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 46.00)
begin


ALTER TABLE tesBancos Add RFC Char(14)
ALTER TABLE venMovimientosFiscal alter column SelloDigital VarChar(max)
ALTER TABLE venMovimientosFiscal alter column SelloFiscal VarChar(max)
Drop Table venmovclieSuc

INSERT INTO genVersion(Version) Values(46.00);

END



