

Update genTamanioHoja SET
	Descripcion = 'Carta',
	Altocm =27.94-1.27,
	Anchicm= 21.59-1.27,
	AltoIN = 10.5,
	AnchoIn = 8
	Where TamanioHoja = 'CA'


Update genTamanioHoja SET
	Altocm =29.7-1.27,
	Anchicm= 21-1.27,
	AltoIN = 11.69-0.5,
	AnchoIn = 8.27-0.5
	Where TamanioHoja = 'A4'

Update genTamanioHoja SET
	Descripcion = 'Oficio',
	Altocm =35.56-1.27,
	Anchicm= 21.59-1.27,
	AltoIN = 14.5-0.5,
	AnchoIn = 8.5-0.5
	Where TamanioHoja = 'LE'


Update genTamanioHoja SET
	Descripcion = 'Custom',
	Altocm =29.7-1.27,
	Anchicm= 42-1.27,
	AltoIN = 16.54-0.5,
	AnchoIn = 11.69-0.5
	Where TamanioHoja = 'A3'


INSERT INTO genVersion (Version) Values(571.00)
GO