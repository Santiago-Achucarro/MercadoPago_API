Create Table esptesT3PromocionesKSK
(
	testT3promociones		int not null,
	ProporcionEmpresa		decimal(18,2),
	ProporcionBanco			decimal(18,2)
	
CONSTRAINT XPKesptesT3PromocionesKSK PRIMARY KEY CLUSTERED (testT3promociones ASC)

)

INSERT INTO genVersionEmpresas (Version) Values(602)
GO

