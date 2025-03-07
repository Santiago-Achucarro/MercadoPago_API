begin
	Alter table comOcReceCuerpo Add CantFactPendiente qMonedaD8 Null;
	Alter table stkMoviOc Add CantFactPendiente qMonedaD8 Null;
End
Go

Begin
	Update comOcReceCuerpo Set CantFactPendiente = Cantidad - IsNull((Select Sum(Cantidad) From comMovPOC Where comMovpOc.comMovProv = comOcReceCuerpo.comOrdenComp And
		comMovPOC.Renglon_OC = comOcReceCuerpo.Renglon_OC), 0);
	Alter table comOcReceCuerpo Alter column CantFactPendiente qMonedaD8 Not Null;
	Update stkMoviOc Set CantFactPendiente = (Select Sum(CantidadOc)-Sum(CantidadRece) From 
	(Select stkMoviOC.comOrdenComp, stkMoviOC.Renglon_OC, Sum(comOcCuerpo.Cantidad) CantidadOc, Sum(stkMoviCuerpo.Cantidad) CantidadRece
From stkMoviOc
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe And stkMoviOC.Renglon = stkMoviCuerpo.Renglon
Inner Join comOCCuerpo On comOCCuerpo.comOrdenComp = stkMoviOC.comOrdenComp And comOCCuerpo.Renglon_OC = stkMoviOC.Renglon_OC
Group By stkMoviOC.comOrdenComp, stkMoviOC.Renglon_OC
) a Where a.comOrdenComp = stkMoviOC.comOrdenComp And a.Renglon_OC = stkMoviOC.Renglon_OC);

	Alter table stkMoviOc Alter column CantFactPendiente qMonedaD8 Not Null;
End

CREATE TABLE comFactuReceOc
( 
	comMovProv           bigint  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	comOcRecepcion       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	Cantidad             qCantidadD8 Not Null,
	CONSTRAINT XPKcomFactuReceOc PRIMARY KEY  CLUSTERED (comMovProv ASC,comOrdenComp ASC,Renglon_OC ASC, comOcRecepcion ASC, conRenglon ASC)
)
go

CREATE TABLE comFactuReceStk
( 
	comMovProv           bigint  NOT NULL ,
	comOrdenComp         integer  NOT NULL ,
	Renglon_OC           integer  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Cantidad             qCantidadD8 Not Null,
	CONSTRAINT XPKcomFactuReceStk PRIMARY KEY  CLUSTERED (comMovProv ASC,comOrdenComp ASC,Renglon_OC ASC, stkMoviCabe ASC, Renglon ASC)
)
go





ALTER TABLE comFactuReceOc
	ADD CONSTRAINT R_4015 FOREIGN KEY (comMovProv,comOrdenComp,Renglon_OC) REFERENCES comMovPOC(comMovProv,comOrdenComp,Renglon_OC)
go




ALTER TABLE comFactuReceOc
	ADD CONSTRAINT R_4016 FOREIGN KEY (comOcRecepcion,conRenglon) REFERENCES comOcReceCuerpo(comOcRecepcion,conRenglon)
go




ALTER TABLE comFactuReceStk
	ADD CONSTRAINT R_4014 FOREIGN KEY (comMovProv,comOrdenComp,Renglon_OC) REFERENCES comMovPOC(comMovProv,comOrdenComp,Renglon_OC)
go




ALTER TABLE comFactuReceStk
	ADD CONSTRAINT R_4017 FOREIGN KEY (stkMoviCabe,Renglon) REFERENCES stkMoviOC(stkMoviCabe,Renglon)
go



Insert Into genVersion (Version) values (49.02);


