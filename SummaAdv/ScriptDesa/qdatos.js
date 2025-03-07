var qdatos_meses = [
    { Text: "01", Value: 1 },
    { Text: "02", Value: 2 },
    { Text: "03", Value: 3 },
    { Text: "04", Value: 4 },
    { Text: "05", Value: 5 },
    { Text: "06", Value: 6 },
    { Text: "07", Value: 7 },
    { Text: "08", Value: 8 },
    { Text: "09", Value: 9 },
    { Text: "10", Value: 10 },
    { Text: "11", Value: 11 },
    { Text: "12", Value: 12 }
];


var qdatos_anios = [
    //{ Text: "1998" }, { Text: "1999" }, { Text: "2000" }, { Text: "2001" }, { Text: "2002" }, { Text: "2003" }, { Text: "2004" }, { Text: "2005" },
    //{ Text: "2006" }, { Text: "2007" }, { Text: "2008" }, { Text: "2009" }, { Text: "2010" }, { Text: "2011" }, { Text: "2012" }, 
    { Text: "2013" }, { Text: "2014" }, { Text: "2015" }, { Text: "2016" }, { Text: "2017" }, { Text: "2018" }, { Text: "2019" }, { Text: "2020" }, { Text: "2021" },
    { Text: "2022" }, { Text: "2023" }, { Text: "2024" }, { Text: "2025" }, { Text: "2026" }, { Text: "2027" }, { Text: "2028" }, { Text: "2029" }, { Text: "2030" },
];

var gOrigenesSeg = [];
gOrigenesSeg["Ninguno"] = 0;
gOrigenesSeg["Pantalla"] = 1;
gOrigenesSeg["Anio"] = 2;
gOrigenesSeg["Mes"] = 3;
gOrigenesSeg["LetraVentas"] = 5;
gOrigenesSeg["LetraCompras"] = 6;
gOrigenesSeg["Ejercicio"] = 7;
gOrigenesSeg["TipoMov"] = 8;
gOrigenesSeg["Proveedor"] = 9;
gOrigenesSeg["Despacho"] = 10;
gOrigenesSeg["Sucursal"] = 11;


var qtiposgrafcategoria = [
    { 'Valor': 'line', 'Descripcion': 'Lineas ' },
    { 'Valor': 'spline', 'Descripcion': 'sp Lineas' },
    { 'Valor': 'point', 'Descripcion': 'Puntos' },
    { 'Valor': 'column', 'Descripcion': 'Columnas' },
    { 'Valor': 'area', 'Descripcion': 'Areas ' },
    { 'Valor': 'bar', 'Descripcion': 'Barras ' },
    { 'Valor': 'waterfall', 'Descripcion': 'Cascada' },
];

var qtiposgraftorta = [
    { 'Valor': 'pie', 'Descripcion': 'Torta' },
    { 'Valor': 'doughnut', 'Descripcion': 'Dona' },
];

var gEstadoAdjunto = [];
gEstadoAdjunto["En_Blanco"] = 0;
gEstadoAdjunto["Sin_Cambios"] = 1;
gEstadoAdjunto["Nuevo"] = 2;
gEstadoAdjunto["Modificado"] = 3;
gEstadoAdjunto["Borrado"] = 4;
