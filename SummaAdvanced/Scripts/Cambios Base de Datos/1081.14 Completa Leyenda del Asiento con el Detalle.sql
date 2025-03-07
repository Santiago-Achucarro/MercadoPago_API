UPDATE conMovCont SET LeyendaLibroMayor = LEFT(comMovDetalle.Detalle,100)
FROM conMovCont
INNER JOIN comMovDetalleCont ON conMovCont.conAsientos = comMovDetalleCont.comMovProv AND
	conMovCont.Renglon = comMovDetalleCont.conRenglon
INNER JOIN comMovDetalle ON comMovDetalleCont.comMovProv = comMovDetalle.comMovProv AND
	comMovDetalleCont.Renglon = comMovDetalle.Renglon
WHERE conMovCont.LeyendaLibroMayor = ' ' AND comMovDetalle.Detalle <> ' '
GO

Insert into genVersion (Version) Values (1081.14)
GO

