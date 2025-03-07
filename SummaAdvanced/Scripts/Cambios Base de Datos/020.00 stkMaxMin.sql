IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 20.00)
begin

INSERT INTO genVersion(Version) Values(20.00);

alter table stkMaxMin ADD Empresa_Id Int NOT NULL;


alter table stkMaxMin drop constraint [XPKstkMaxMin];

alter table stkMaxMin add primary key(Producto_ID, Deposito_Id, Empresa_Id);

End

