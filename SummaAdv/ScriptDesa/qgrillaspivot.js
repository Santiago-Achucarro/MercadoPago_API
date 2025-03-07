var ggrdpivot = [];

var qgrdpvt_config = function (pNombre, pUrlServidor, pCatalogo, pCubo, pMeasures, pFilas, pColumnas, pTitulo) {
    var _Nombre = pNombre;
    var _UrlServidor = pUrlServidor;
    var _Catalogo = pCatalogo;
    var _Cubo = pCubo;
    var _Measures = pMeasures;
    var _Filas = pFilas;
    var _Columnas = pColumnas;
    var _Titulo = pTitulo;
    this.getNombre = function () { return _Nombre };
    this.getUrlServidor = function () { return _UrlServidor };
    this.getCatalogo = function () { return _Catalogo };
    this.getCubo = function () { return _Cubo };
    this.getMeasures = function () { return _Measures };
    this.getFilas = function () { return _Filas };
    this.getColumnas = function () { return _Columnas };
    this.getTitulo = function () { return _Titulo };
}



function qgrdpvt_Crear(pNombreGrilla) {
    var lgrdPivot = null;

    if ($("#" + pNombreGrilla).data("igPivotView") != null)
        $("#" + pNombreGrilla).igPivotView("destroy");


    $.each(ggrdpivot, function (lClave, lValor) {
        if (lValor.getNombre() == pNombreGrilla) {
            lgrdPivot = lValor;
        }
    })

    if (lgrdPivot != null) {

        $("#" + lgrdPivot.getNombre()).igPivotView({
            dataSourceOptions: {
                xmlaOptions: {
                    serverUrl: lgrdPivot.getUrlServidor(),
                    catalog: lgrdPivot.getCatalogo(),
                    cube: lgrdPivot.getCubo()
                },
                rows: lgrdPivot.getFilas(),
                columns: lgrdPivot.getColumnas(),
                measures: lgrdPivot.getMeasures(),
            },
            pivotGridOptions: {
                gridOptions: {
                    alternateRowStyles: true,
                    caption: lgrdPivot.getTitulo(),
                    defaultColumnWidth: '*',
                },
                dataSourceInitialized: function (evt, ui) {
                    // alert("Expandir!");
                    ui.owner.expandTupleMember("rowAxis", 0, 0, true);
                    ui.owner.expandTupleMember("columnAxis", 0, 0, true);
                },
                pivotGridRendered: function (evt, ui) {
                    $("[aria-describedby*='_pivotGrid_Axis']").addClass('alignCol-derecha');
                    $("#" + lgrdPivot.getNombre() + "_dataSelector .ui-igcombo-wrapper").hide();
                }
            },
            dataSelectorPanel: {
                collapsed : false,
                //collapsible : false,
                location: "left",
                //resizable : false,
                //size : 250,
            },
        });
    }
}

function qgrdpvt_DestruirGrdPvt() {
    $.each(ggrdpivot, function (lClave, lValor) {
        if ($("#" + lValor.getNombre()).data("igPivotView") != null)
            $("#" + lValor.getNombre()).igPivotView("destroy");
    })
}

/*

function qgrdpvt_CrearPrueba(pNombreGrilla) {
    var lgrdPivot = null;

    if ($("#" + pNombreGrilla).data("igPivotView") != null)
        $("#" + pNombreGrilla).igPivotView("destroy");

    $.each(ggrdpivot, function (lClave, lValor) {
        if (lValor.getNombre() == pNombreGrilla) {
            lgrdPivot = lValor;
        }
    })



    if (lgrdPivot != null) {

        var data =
            [{ "ProductCategory": "Clothing", "UnitPrice": 12000.81, "SellerName": "Stanley Brooker", "Country": "Bulgaria", "City": "Plovdiv", "Date": "01/01/2012", "UnitsSold": 2820.00, "UnitsSold2": 282 },
            { "ProductCategory": "Clothing", "UnitPrice": 49000.57, "SellerName": "Elisa Longbottom", "Country": "US", "City": "New York", "Date": "01/05/2013", "UnitsSold": 2960.00, "UnitsSold2": 296 },
            { "ProductCategory": "Bikes", "UnitPrice": 3000.56, "SellerName": "Lydia Burson", "Country": "Uruguay", "City": "Ciudad de la Costa", "Date": "01/06/2011", "UnitsSold": 680.00, "UnitsSold2": 68 },
            { "ProductCategory": "Accessories", "UnitPrice": 85000.58, "SellerName": "David Haley", "Country": "UK", "City": "London", "Date": "04/07/2012", "UnitsSold": 2930.00, "UnitsSold2": 293 },
            { "ProductCategory": "Components", "UnitPrice": 18000.13, "SellerName": "John Smith", "Country": "Japan", "City": "Yokohama", "Date": "12/08/2012", "UnitsSold": 2400.00, "UnitsSold2": 240 },
            { "ProductCategory": "Clothing", "UnitPrice": 68000.33, "SellerName": "Larry Lieb", "Country": "Uruguay", "City": "Ciudad de la Costa", "Date": "05/12/2011", "UnitsSold": 4560.00, "UnitsSold2": 456 },
            { "ProductCategory": "Components", "UnitPrice": 16000.05, "SellerName": "Walter Pang", "Country": "Bulgaria", "City": "Sofia", "Date": "02/19/2013", "UnitsSold": 4920.00, "UnitsSold2": 492 }];


        $("#" + lgrdPivot.getNombre()).igPivotView({
            dataSourceOptions: {
                flatDataOptions:
                {
                    dataSource: data,
                    metadata: {
                        cube: {
                            name: "Sales",
                            caption: "Sales",
                            measuresDimension: {
                                caption: "Measures",
                                measures: [ //for each measure, name and aggregator are required
                                    {
                                        caption: "Units Sold", name: "UnitsSold",
                                        // returns a function that will be used as sum aggregatro on the 'UnitsSold property' of the data objects
                                        aggregator: $.ig.OlapUtilities.prototype.sumAggregator('UnitsSold')
                                    },
                                    {
                                        caption: "Units Sold2", name: "UnitsSold2",
                                        // returns a function that will be used as sum aggregatro on the 'UnitsSold property' of the data objects
                                        aggregator: $.ig.OlapUtilities.prototype.sumAggregator('UnitsSold2')
                                    }
                                ]
                            },
                            dimensions: [ // for each dimension name and hierarchies are required
                                {
                                    caption: "Seller", name: "Seller", hierarchies: [{
                                        caption: "Seller", name: "Seller", levels: [
                                            {
                                                name: "AllSellers", caption: "All Sellers",
                                                memberProvider: function (item) { return "All Sellers"; }
                                            },
                                            {
                                                name: "SellerName", caption: "Seller",
                                                memberProvider: function (item) { return item.SellerName; }
                                            }]
                                    }]
                                },
                                {
                                    caption: "Date", name: "Date",  hierarchies: [
                                        $.ig.OlapUtilities.prototype.getDateHierarchy(
                                            "Date", // the source property name
                                            ["year", "quarter", "month", "date"], // the date parts for which levels will be generated (optional)
                                            "Dates", // The name for the hierarchy (optional)
                                            "Date", // The caption for the hierarchy (optional)
                                            ["Year", "Quarter", "Month", "Day"], // the captions for the levels (optional)
                                            "All Periods") // the root level caption (optional)
                                    ]
                                }
                            ]
                        }
                    }
                },
                // Preload hiearhies for the rows, columns, filters and measures
                rows: lgrdPivot.getFilas(),
                columns: lgrdPivot.getColumnas(),
                measures: lgrdPivot.getMeasures(),
            },
            pivotGridOptions: {
                gridOptions: {
                    alternateRowStyles: true,
                    caption: lgrdPivot.getTitulo(),
                    defaultColumnWidth: '*',
                },
                pivotGridRendered: function (evt, ui) {
                    $("[aria-describedby*='_pivotGrid_Axis']").addClass('alignCol-derecha');
                }
            },
            dataSelectorPanel: {
                //collapsed : false,
                //collapsible : false,
                location: "left",
                //resizable : true,
                //size : 250,
            },
        });
    }
}
*/