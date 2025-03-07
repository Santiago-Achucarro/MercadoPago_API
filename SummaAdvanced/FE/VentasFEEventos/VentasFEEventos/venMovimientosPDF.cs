using System;
using System.Data;
using Root.Reports;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Drawing;
using Recursos;
using System.Drawing.Imaging;
using System.Linq;
using System.Drawing.Text;

namespace VentasFEEventos
{
    public class venMovimientosPDF
    {

        private PdfFormatter pdfform;
        private Report reporte;

        private double rAncho = 210;
        private double rLargo = 297;
        private double rposIzq = 10; //margen izquierdo
        private double rposDer = 200; //margen derecho
        private double rposSup = 10; //margen superior
        private double rposInf = 290; //margen inferior
        private double rAltoEnc = 80; //altura del Encabezado
        private double rMargenEnc = 1; //margen entre el Cuerpo y el Encabezado
        private double rAltoPie = 55; //altura del Pie
        private double rMargenPie = 2; //margen entre el Cuerpo y el Pie



        public Report repPDF(int Segmento1N, int Segmento2N, int Segmento3N, int Segmento4N,
                string Segmento1C, string Segmento2C, string Segmento3C, string Segmento4C,
                int pUsuario_Id, int pEmpresa, string pDominio_Id, string pMoneda_Id, string pInstalacion)
        {


            // Datos de la Empresa

            GeneralesExchange.genEmpresasActionExchange ExcEmp = new GeneralesExchange.genEmpresasActionExchange
                    (GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExcEmp.Empresa_Id = "";
            ExcEmp.genEmpresas = pEmpresa;
            ExcEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBI.WrapperExecuteAction(new Framework.Core.Exchange(ExcEmp), pUsuario_Id, pEmpresa,
                    pDominio_Id, pMoneda_Id, "", pInstalacion, "", "", "", "", "", 0));


            if (!ExcEmp.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_la_Empresa");



            // Traigo los Datos
            VentasExchange.venMovimientosConsultaActionExchange Exc = new VentasExchange.venMovimientosConsultaActionExchange
                (VentasExchange.venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos);
            Exc.Empresa_Id = pEmpresa;
            Exc.Segmento_Id = "FC";

            Exc.Segmento1N = Segmento1N;
            Exc.Segmento2N = Segmento2N;
            Exc.Segmento3N = Segmento3N;
            Exc.Segmento4N = Segmento4N;
            Exc.Segmento1C = Segmento1C;
            Exc.Segmento2C = Segmento2C;
            Exc.Segmento3C = Segmento3C;
            Exc.Segmento4C = Segmento4C;

            Exc = new VentasExchange.venMovimientosConsultaActionExchange(
                Generalidades.QBI.WrapperExecuteAction(new Framework.Core.Exchange(Exc), pUsuario_Id, pEmpresa, pDominio_Id, pMoneda_Id, "",
                pInstalacion, "", "", "", "", "", 0));

            if (!Exc.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_El_Movimiento");

            GeneralesExchange.genSucursalesEmprActionExchange ExcSuc = new GeneralesExchange.genSucursalesEmprActionExchange
                (GeneralesExchange.genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.Datos);

            ExcSuc.Sucursal = Exc.SucursalEmpr;

            ExcSuc = new GeneralesExchange.genSucursalesEmprActionExchange
                (Generalidades.QBI.WrapperExecuteAction(new Framework.Core.Exchange(ExcSuc), pUsuario_Id, pEmpresa,
                pDominio_Id, pMoneda_Id, "", pInstalacion, "", "", "", "", "", 0));



            if (!ExcSuc.Existe)
            {
                object[] lParam = { Exc.SucursalEmpr };
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_la_Sucursal_<0>");
            }


            if (pDominio_Id == "MX")
            {



                VentasExchange.XmlComprobanteActionExchange ExcX = new VentasExchange.XmlComprobanteActionExchange
                    (VentasExchange.XmlComprobanteActionEnum.EnumXmlComprobanteAction.Datos);

                ExcX.Asiento_Id = Exc.venMovimientos;



                ExcX = new VentasExchange.XmlComprobanteActionExchange(
                        Generalidades.QBI.WrapperExecuteAction(new Framework.Core.Exchange(ExcX), pUsuario_Id, pEmpresa,
                        pDominio_Id, pMoneda_Id, "", pInstalacion, "", "", "", "", "", 0));



                DataTable movCuerpo = new DataTable();


                //Genero PDF
                this.pdfform = new PdfFormatter();
                this.reporte = new Report(this.pdfform);
                this.reporte.sAuthor = "Quasar/SummaAdv";
                this.reporte.sTitle = "Comprobante: " + Exc.SegmentoStr;

                // defino los tipos de fuente para el Reporte
                FontDef f_helveti = new FontDef(this.reporte, FontDef.StandardFont.Helvetica);

                // defino los tamaños y tipos de las fuentes para cada parte del Reporte
                FontProp fp_titulo = new FontPropMM(f_helveti, 3.6);
                FontProp fp_cuerpo_titulo = new FontPropMM(f_helveti, 2.2);
                FontProp fp_folio = new FontPropMM(f_helveti, 2.5);
                FontProp fp_cuerpo_datos = new FontPropMM(f_helveti, 1.8);
                FontProp fp_encpie = new FontPropMM(f_helveti, 2);
                FontProp fp_Domi = new FontPropMM(f_helveti, 1.6);
                FontProp fp_mini = new FontPropMM(f_helveti, 1.5);
                FontProp fp_Mediana = new FontPropMM(f_helveti, 1.5);

                System.Globalization.NumberFormatInfo lN2 = new CultureInfo("en-US", false).NumberFormat;
                lN2.NumberDecimalSeparator = ".";
                lN2.NumberGroupSeparator = ",";
                lN2.NumberDecimalDigits = 2;
                lN2.CurrencyDecimalSeparator = ".";
                lN2.CurrencyGroupSeparator = ",";
                lN2.CurrencyDecimalDigits = 2;
                lN2.CurrencyPositivePattern = 2; // sale $ espacio nro

                System.Globalization.NumberFormatInfo lN4 = new CultureInfo("en-US", false).NumberFormat;
                lN4.NumberDecimalSeparator = ".";
                lN4.NumberGroupSeparator = ",";
                lN4.NumberDecimalDigits = 4;
                lN4.CurrencyDecimalSeparator = ".";
                lN4.CurrencyGroupSeparator = ",";
                lN4.CurrencyDecimalDigits = 4;
                lN4.CurrencyPositivePattern = 2; // sale $ espacio nro

                // Armo la TABLA
                TableLayoutManager tabla = new TableLayoutManager(this.reporte);

                // defino la columna de la tabla
                TableLayoutManager.Column tabla_col;

                // pego la fuente del titulo a la tabla
                fp_cuerpo_titulo.bBold = true;
                tabla.fp_Header = fp_cuerpo_titulo;

                //defino altura de la tabla: para manejar el separador de paginas
                tabla.rContainerHeightMM = rposInf - rposSup - rAltoEnc - rMargenEnc - rAltoPie - rMargenPie;
                // linea de abajo separadora de filas en el cuerpo de la tabla
                tabla._cellDef.pp_LineBottom = new PenProp(this.reporte, 0.05, Color.LightGray);
                // el texto continua debajo si no alcanza en el ancho de la celda (wrap)
                tabla._cellDef.textMode = TlmBase.TextMode.MultiLine;

                // defino el evento que se ejecuta al generar una pagina nueva 
                // (nuevo contenedor)
                tabla.eNewContainer += new Root.Reports.TlmBase.NewContainerEventHandler(this.Tabla_NuevaPagina);



                // CUERPO DEL REPORTE

                // busco las UMs, para sacar la cantidad de decimales


                // defino columnas: (tabla, nombre cabecera, ancho en mm) ancho total = 190mm
                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("Item"), 15);

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("Cod.SAT"), 15);

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("Descripcion"), 50);

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("Cantidad"), 15);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("U.M."), 12.5);

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                        Recurso.GetString("UM. SAT"), 12.5);

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("Precio Unitario"), 20);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;


                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("IVA"), 15);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                            Recurso.GetString("Tasa"), 10);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;

                tabla_col = new TableLayoutManager.ColumnMM(tabla,
                    Recurso.GetString("Total"), 25);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;

                for (int nCont = 0; nCont < ExcX.Param.Concepto.Count; nCont++)
                {

                    // agrego las filas y los datos a cada columna
                    tabla.NewRow();
                    tabla.Add(0, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].NoIdentificacion));
                    tabla.Add(1, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].ClaveProdServ));
                    tabla.Add(2, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].Descripcion));
                    tabla.Add(3, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].Cantidad.ToString("N", lN2)));
                    tabla.Add(4, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].Unidad));
                    tabla.Add(5, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].ClaveUnidad));
                    tabla.Add(6, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].ValorUnitario.ToString("C", lN2)));
                    Decimal lIVA = 0;
                    Decimal lTasa = 0;


                    // todo Ver Otros IEPS e ISR
                    foreach (VentasCommon.XmlComprobanteDS.TrasladoProdRow ren in (VentasCommon.XmlComprobanteDS.TrasladoProdRow[])ExcX.Param.TrasladoProd.Select(" Renglon = " + ExcX.Param.Concepto[nCont].Renglon.ToString()))
                    {
                        lIVA += ren.Importe;
                        lTasa = ren.TasaOCuota;
                    }

                    tabla.Add(7, new RepString(fp_cuerpo_datos, lIVA.ToString("C", lN2)));
                    tabla.Add(8, new RepString(fp_cuerpo_datos, lTasa.ToString("N", lN2)));
                    tabla.Add(9, new RepString(fp_cuerpo_datos, ExcX.Param.Concepto[nCont].Importe.ToString("C", lN2)));

                }

                tabla.Close(); //cierro la tabla


                // ENCABEZADO Y PIE DEL REPORTE

                // defino el lapiz para la linea
                PenProp lapiz = new PenProp(this.reporte, 1, Color.Black);

                foreach (Page pagina in this.reporte.enum_Page)
                {
                    // ENCABEZADO
                    fp_titulo.bBold = true;
                    ListLayoutManager llm = new ListLayoutManager(this.reporte);

                    ListLayoutManager.Column colTexto = new ListLayoutManager.ColumnMM(llm, 80);
                    colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;


                    // ESTABA EN 70 X 10
                    MemoryStream pLogoEmp = new MemoryStream(Convert.FromBase64String(ExcEmp.Logo), false);
                    pagina.AddLT_MM(rposIzq + 1, rposSup + 1, new RepImageMM(pLogoEmp, 50, 13));
                    fp_encpie.bBold = true;

                    pagina.AddLT_MM(rposIzq + 2, rposSup + 15, new RepString(fp_encpie,
                        ExcX.Param.Emisor[0].Nombre.Trim()));

                    pagina.AddLT_MM(rposIzq + 55, rposSup + 20, new RepString(fp_encpie,
                                   ExcSuc.Descripcion.Trim()));

                    fp_encpie.bBold = false;
                    fp_encpie.bBold = false;
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 20, new RepString(fp_Domi,
                        ExcX.Param.Emisor[0].Calle.Trim() + " " + ExcX.Param.Emisor[0].NoExterior.Trim() +
                    " " + ExcX.Param.Emisor[0].NoInterior.Trim()));
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 24, new RepString(fp_Domi,
                        ExcX.Param.Emisor[0].Colonia.Trim())); // Colonia

                    pagina.AddLT_MM(rposIzq + 2, rposSup + 28, new RepString(fp_Domi,
                                (ExcX.Param.Emisor[0].Municipio.Trim() == "" ?
                                ExcX.Param.Emisor[0].Localidad.Trim() :
                                ExcX.Param.Emisor[0].Municipio.Trim()) + " C.P:" + ExcX.Param.Emisor[0].CodigoPostal.Trim())); // Municipio

                    pagina.AddLT_MM(rposIzq + 2, rposSup + 32, new RepString(fp_Domi,
                        ExcX.Param.Emisor[0].Provincia.Trim() + " - " + ExcX.Param.Emisor[0].Pais.Trim()));


                    pagina.AddLT_MM(rposIzq + 2, rposSup + 36, new RepString(fp_Domi,
                                "Régimen Fiscal: " + ExcX.Param.Emisor[0].RegimenFiscal.Trim()));



                    pagina.AddLT_MM(rposIzq + 55, rposSup + 25, new RepString(fp_Domi,
                                ExcSuc.Direccion.Trim()));

                    pagina.AddLT_MM(rposIzq + 55, rposSup + 29, new RepString(fp_Domi,
                        ExcSuc.Localidad.Trim())); // Colonia
                    pagina.AddLT_MM(rposIzq + 55, rposSup + 33, new RepString(fp_Domi,
                           " C.P:" + ExcSuc.CodigoPostal.Trim())); // Municipio
                    pagina.AddLT_MM(rposIzq + 55, rposSup + 37, new RepString(fp_Domi,
                        ExcSuc.DescripcionProvincias.Trim()));
                    pagina.AddLT_MM(rposIzq + 55, rposSup + 40, new RepString(fp_Domi,
                        ExcSuc.Telefono.Trim()));


                    //fp_titulo.bBold = true;

                    string lTipo = "Ingreso";
                    if (ExcX.TipoDeComprobante.Trim() == "E")
                        lTipo = "Egreso";


                    pagina.AddLT_MM(rposDer - 68, rposSup + 3, new RepString(fp_titulo, lTipo));



                    fp_titulo.bBold = false;
                    fp_folio.bBold = true;


                    //PUSE lSerie en ligar de sucursal + letra AJ DIC 2014
                    pagina.AddLT_MM(rposDer - 68, rposSup + 9, new RepString(fp_folio,
                        "Folio: " + ExcX.Segmento1N));

                    pagina.AddLT_MM(rposDer - 68, rposSup + 15, new RepString(fp_encpie,
                        "Fecha de Emisión: " + ExcX.Fecha.ToString()));

                    pagina.AddLT_MM(rposDer - 68, rposSup + 20, new RepString(fp_encpie,
                              "Lugar de Expedición:" + ExcX.LugarExpedicion.Trim()));


                    pagina.AddLT_MM(rposDer - 68, rposSup + 25, new RepString(fp_encpie,
                        "RFC: " + ExcX.Param.Emisor[0].Rfc.Trim()));

                    if (ExcX.Param.Complemento.Count > 0)
                    {
                        pagina.AddLT_MM(rposDer - 68, rposSup + 30, new RepString(fp_encpie,
                            "RFC Prov. Certif.:" + ExcX.Param.Complemento[0].RfcProvCertif.Trim()));



                        pagina.AddLT_MM(rposDer - 68, rposSup + 35, new RepString(fp_encpie,
                                "No.Certificado: " + ExcX.NoCertificado));

                        pagina.AddLT_MM(rposDer - 68, rposSup + 40, new RepString(fp_encpie,
                                "No.Certificado SAT: " + ExcX.Param.Complemento[0].NoCertificadoSAT));

                    }


                    // etiquetas encabezado
                    fp_encpie.bBold = false;
                    fp_folio.bBold = true;
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 49, new RepString(fp_folio,
                        "Receptor: " + ExcX.Param.Receptor[0].Nombre.ToString().Trim()));

                    pagina.AddLT_MM(rposIzq + 2, rposSup + 55, new RepString(fp_encpie,
                        "Domicilio: " + ExcX.Param.Receptor[0].Calle.Trim() + " " +
                        ExcX.Param.Receptor[0].NroExterior.Trim() + " " +
                        ExcX.Param.Receptor[0].NroInterior.Trim()));

                    pagina.AddLT_MM(rposIzq + 2, rposSup + 60, new RepString(fp_encpie,
                                        ExcX.Param.Receptor[0].Colonia.Trim() + " " +
                                        ExcX.Param.Receptor[0].Localidad.Trim() + " " +
                                        ExcX.Param.Receptor[0].Provincia.Trim() + " (" +
                                        ExcX.Param.Receptor[0].CodigoPostal.Trim() + ")"));

                    pagina.AddLT_MM(rposDer - 50, rposSup + 50, new RepString(fp_encpie,
                        "RFC:" + ExcX.Param.Receptor[0].Rfc.Trim()));

                    pagina.AddLT_MM(rposDer - 50, rposSup + 55, new RepString(fp_encpie,
                        "Metodo de Pago:" + ExcX.MetodoPago.Trim()));

                    /*pagina.AddLT_MM(rposDer - 50, rposSup + 60, new RepString(fp_encpie,
                        "Cuenta de Pago:" + resBase.c.Trim()));*/


                    pagina.AddLT_MM(rposIzq + 2, rposSup + 68, new RepString(fp_encpie,
                            "Folio Fiscal: " + ExcX.Param.Complemento[0].UUID.Trim()));
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 72, new RepString(fp_encpie,
                            "Fecha Timbrado: " + ExcX.Param.Complemento[0].FechaTimbrado));
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 76, new RepString(fp_encpie,
                            "USO CFDI: " + ExcX.Param.Receptor[0].UsoCfdi));


                    pagina.AddLT_MM(rposIzq + 110, rposSup + 68, new RepString(fp_encpie,
                        "Forma de Pago: " + ExcX.FormaPago.Trim()));

                    fp_encpie.bBold = false;


                    // PIE



                    // si tiene mas de una pagina, el pie solo va en la ultima
                    if (pagina.iPageNo.Equals(this.reporte.iPageCount))
                    {
                        fp_encpie.bBold = false;

                        pagina.AddLT_MM(rposDer - 50, rposInf - 54,
                            new RepString(fp_cuerpo_titulo, "SUB-TOTAL:"));
                        pagina.AddRT_MM(rposDer - 2, rposInf - 54, new RepString(fp_cuerpo_titulo,
                            ExcX.SubTotal.ToString("C", lN2)));

                        pagina.AddLT_MM(rposDer - 50, rposInf - 50,
                            new RepString(fp_cuerpo_titulo, "DESCUENTOS:"));
                        pagina.AddRT_MM(rposDer - 2, rposInf - 50, new RepString(fp_cuerpo_titulo,
                            ExcX.Descuento.ToString("C", lN2)));

                        int ultReng = 46;
                        decimal ImporteImpuesto = 0;

                        for (int nImp = 0; nImp < ExcX.Param.Traslados.Count; nImp++)
                        {

                            ultReng = 46 - (nImp * 4);

                            pagina.AddLT_MM(rposDer - 50, rposInf - ultReng,
                                new RepString(fp_cuerpo_titulo, (ExcX.Param.Traslados[nImp].Impuesto == "002" ? "IVA" : "IEPS") + ":"));
                            ImporteImpuesto = Convert.ToDecimal(ExcX.Param.Traslados[nImp].Importe);
                            pagina.AddRT_MM(rposDer - 2, rposInf - ultReng,
                                new RepString(fp_cuerpo_titulo, ImporteImpuesto.ToString("C", lN2)));


                        }

                        //  retenciones
                        for (int nImp = 0; nImp < ExcX.Param.Retenciones.Count; nImp++)
                        {

                            ultReng = 46 - (nImp * 4);

                            pagina.AddLT_MM(rposDer - 50, rposInf - ultReng,
                                new RepString(fp_cuerpo_titulo, (ExcX.Param.Retenciones[nImp].Impuesto == "002" ? "IVA" : "ISR") + ":"));
                            ImporteImpuesto = -Convert.ToDecimal(ExcX.Param.Retenciones[nImp].Importe);
                            pagina.AddRT_MM(rposDer - 2, rposInf - ultReng,
                                new RepString(fp_cuerpo_titulo, ImporteImpuesto.ToString("C", lN2)));


                        }

                        pagina.AddLT_MM(rposDer - 50, rposInf - ultReng + 4,
                            new RepString(fp_cuerpo_titulo, "TOTAL:"));
                        pagina.AddRT_MM(rposDer - 2, rposInf - ultReng + 4, new RepString(fp_cuerpo_titulo,
                            ExcX.Total.ToString("C", lN2)));

                        string lMetodo = "Pago en una sola exhibición";
                        if (ExcX.MetodoPago == "PPD")
                            lMetodo = "Pago en parcialidades o diferido";
                        else if (ExcX.MetodoPago == "PIP")
                            lMetodo = "Pago inicial y parcialidades";

                        pagina.AddLT_MM(rposIzq + 2, rposInf - ultReng + 8,
                            new RepString(fp_Mediana, lMetodo + "(" + ExcX.MetodoPago + ")"));

                        //// busco despachos
                        //string lDespachos = "";
                        //string lDes = "";
                        //for (int r = 0; r < movDesp.Rows.Count; r++)
                        //{
                        //	lDes = movDesp.Rows[r]["Despacho_id"].ToString().Trim();
                        //	if (lDespachos.IndexOf(lDes) == -1)
                        //	{
                        //		lDespachos += lDes + ",";
                        //	}
                        //}



                        bool esMonedaBase = ExcX.Moneda == "MXN";

                        // TODO DESCRIPCION MONEDA AL EXCHANGE

                        string lDescripcionMoneda = ExcX.DescripcionMoneda;

                        // total en letras
                        llm = new ListLayoutManager(this.reporte);
                        llm.rContainerHeightMM = 15;
                        colTexto = new ListLayoutManager.ColumnMM(llm, 130);
                        colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;
                        llm.container_CreateMM(pagina, rposIzq + 2, rposInf - 55);
                        llm.NewRow();
                        fp_encpie.bBold = true;
                        colTexto.Add(new RepString(fp_encpie, "Total en Letras: " +
                            GeneralidadesFEAdv.Varios.NroALetra(ExcX.Total, false, ExcX.Moneda_Id, lDescripcionMoneda.Trim(), pDominio_Id, pMoneda_Id) +
                             (esMonedaBase ? "" :
                                "\r\n" + "Tipo de Cambio: " + ExcX.TipoCambio.ToString("C", lN4))));
                        fp_encpie.bBold = false;
                        llm.Commit();
                        llm.Close();



                        if (ExcX.Param.Complemento.Count > 0)
                        {
                            string lCadenas = "";
                            double rDesde = rposIzq + 2;


                            lCadenas += "Cadena Original del complemento de certificación digital del SAT:" + "\r\n" +
                                "||1.1|" + ExcX.Param.Complemento[0].UUID.Trim() + "|" +
                                ExcX.Param.Complemento[0].FechaTimbrado.Trim() + "|" +
                                ExcX.Param.Complemento[0].SelloCFD.Trim() + "|" +
                                ExcX.Param.Complemento[0].NoCertificadoSAT.Trim() + "||";

                            lCadenas += "\r\n";
                            lCadenas += "Sello Digital del CFDI:" + "\r\n" + ExcX.Param.Complemento[0].SelloCFD;
                            lCadenas += "\r\n";
                            lCadenas += "Sello Digital del SAT:" + "\r\n" + ExcX.Param.Complemento[0].SelloSAT;

                            pagina.AddLT_MM(rposDer - 110, rposInf,
                            new RepString(fp_mini, "Este documento es una representación impreso de un CFDI"));

                            rDesde = rposIzq + 36;


                            MW6QRCode.Font QRCodeFontObj = new MW6QRCode.Font();
                            string pTimbreAux = "https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx&id=" +
                                 ExcX.Param.Complemento[0].UUID +
                              "?re=" + ExcX.Param.Emisor[0].Rfc.Trim() + "&rr=" + ExcX.Param.Receptor[0].Rfc.Trim() + "&tt=" +
                                    ExcX.Total.ToString("0000000000.000000") + "&fe=" + ExcX.Param.Complemento[0].SelloCFD.Substring(
                                        ExcX.Param.Complemento[0].SelloCFD.Length - 4);

                            QRCodeFontObj.Encode(pTimbreAux, 7, 0, 0);

                            int RowCount = QRCodeFontObj.GetRows();
                            int ColCount = QRCodeFontObj.GetCols();


                            Font fn = new Font("MW6 Matrix", 14, GraphicsUnit.Pixel);

                            string EncodedMsg = "" + System.Convert.ToChar(13) + System.Convert.ToChar(10);



                            var assembly = Assembly.GetExecutingAssembly();
                            var resourceName = "VentasFEEventos.QRBase.jpg";
                            Stream stream = assembly.GetManifestResourceStream(resourceName);
                            Bitmap b1 = new Bitmap(stream);




                            System.Drawing.Graphics qr = System.Drawing.Graphics.FromImage(b1);
                            SolidBrush sb = new SolidBrush(Color.Black);
                            for (int i = 0; i < RowCount; i++)
                            {
                                qr.DrawString(QRCodeFontObj.GetRowStringAt(i), fn, sb, 10, 10 + i * fn.GetHeight());
                            }

                            qr.Save();

                            ImageCodecInfo jpgEncoder = ImageCodecInfo.GetImageEncoders().Single(x => x.FormatDescription == "JPEG");
                            Encoder encoder2 = System.Drawing.Imaging.Encoder.Quality;
                            EncoderParameters parameters = new System.Drawing.Imaging.EncoderParameters(1);
                            EncoderParameter parameter = new EncoderParameter(encoder2, 50L);
                            parameters.Param[0] = parameter;

                            System.IO.Stream streamBm = new MemoryStream();
                            b1.Save(streamBm, jpgEncoder, parameters);




                            pagina.AddLT_MM(rposIzq + 1.5, rposInf - 35.5, new RepImageMM(streamBm, 35, 35));




                            // si tiene mas de 1 pagina, coloco la leyenda Pagina 1/x
                            pagina.AddLT_MM(rposDer - 50, rposInf, new RepString(fp_mini,
                                       "Páginas: " + pagina.iPageNo.ToString() + "/" +
                                this.reporte.iPageCount.ToString()));

                            llm = new ListLayoutManager(this.reporte);
                            llm.rContainerHeightMM = 35;
                            colTexto = new ListLayoutManager.ColumnMM(llm, 188 - (rDesde - rposIzq));
                            colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;
                            llm.container_CreateMM(pagina, rDesde, rposInf - 35);
                            llm.NewRow();
                            colTexto.Add(new RepString(fp_mini, lCadenas));
                            llm.Commit();
                            llm.Close();
                        }

                        string lObs = "";
                        llm = new ListLayoutManager(this.reporte);
                        llm.rContainerHeightMM = 45;
                        colTexto = new ListLayoutManager.ColumnMM(llm, 130);
                        colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;
                        llm.container_CreateMM(pagina, rposIzq + 2, rposInf - 20);
                        llm.NewRow();
                        colTexto.Add(new RepString(fp_mini, lObs));
                        llm.Commit();
                        llm.Close();
                    }



                    //RECUADROS, LINEAS
                    //	Rectangulo general
                    pagina.AddMM(rposIzq, rposInf - 0.5, new RepRectMM(lapiz, rposDer - rposIzq, rposInf - rposSup));
                    //  Lineas
                    // H1
                    pagina.AddMM(rposIzq, rposSup + 45, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    // H2
                    pagina.AddMM(rposIzq, rposSup + 65, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    //H3
                    pagina.AddMM(rposIzq, rposSup + 81, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    //H4
                    pagina.AddMM(rposIzq, rposInf - 36, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    //V1
                    pagina.AddMM(rposIzq + 119, rposSup + 45, new RepLineMM(lapiz, 0, 45));

                }




                //if ((Guardar) && (lFile != ""))
                //{
                //    this.reporte.Save(lFile + ".pdf");

                //    XmlDocument xDoc = new XmlDocument();
                //    if (resBase.Result.Complemento.Count > 0)
                //    {

                //        xDoc.LoadXml(resBase.Result.Complemento[0].XML);
                //        xDoc.Save(lFile + ".xml");
                //    }

                //}


            }
            else
            {
                // Arg

                rLargo = 290; // A4

                VentasExchange.venClieHabitualActionExchange exchClie = new VentasExchange.venClieHabitualActionExchange
                    (VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.DatosSucursal);

                exchClie.Cliente_Id = Exc.Cliente_Id;
                exchClie.Sucursal = Exc.Sucursal;

                exchClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBI.WrapperExecuteAction
                    (new Framework.Core.Exchange(exchClie), pUsuario_Id, pEmpresa, pDominio_Id, pMoneda_Id, "", pInstalacion, "", "", "", "", "", 0));

                VentasExchange.venCondFiscalActionExchange exchCF = new VentasExchange.venCondFiscalActionExchange
                    (VentasExchange.venCondFiscalActionEnum.EnumvenCondFiscalAction.Datos);
                exchCF.CondFisc_Id = exchClie.CondFisc_Id;

                exchCF = new VentasExchange.venCondFiscalActionExchange(Generalidades.QBI.WrapperExecuteAction
                    (new Framework.Core.Exchange(exchCF), pUsuario_Id, pEmpresa, pDominio_Id, pMoneda_Id, "", pInstalacion, "", "", "", "", "", 0));

                VentasExchange.venTipoMovActionExchange exchVTM = new VentasExchange.venTipoMovActionExchange
                    (VentasExchange.venTipoMovActionEnum.EnumvenTipoMovAction.Datos);
                exchVTM.venTipoMov = Exc.venTipoMov;
                exchVTM = new VentasExchange.venTipoMovActionExchange(Generalidades.QBI.WrapperExecuteAction
                    (new Framework.Core.Exchange(exchVTM), pUsuario_Id, pEmpresa, pDominio_Id, pMoneda_Id, "", pInstalacion, "", "", "", "", "", 0));

                DataTable movCuerpo = new DataTable();


                //Genero PDF
                this.pdfform = new PdfFormatter();
                this.reporte = new Report(this.pdfform);
                this.reporte.sAuthor = "Quasar/SummaAdv";
                this.reporte.sTitle = "Comprobante: " + Exc.SegmentoStr;

                // defino los tipos de fuente para el Reporte
                FontDef f_helveti = new FontDef(this.reporte, FontDef.StandardFont.Helvetica);


                Font fn = new Font("PF Interleaved 2 of 5", 14, GraphicsUnit.Pixel);

                FontDef f_codigoBarra = new FontDef(this.reporte, "PF Interleaved 2 of 5");

                /*
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"C:\Windows\Fonts\PF Interleaved 2 of 5");
                FontFamily fontFamily = pfc.Families[0];
                Font fn = new Font(fontFamily, 30);
                FontDef f_codigoBarra = new FontDef(this.reporte, 
                */


                // defino los tamaños y tipos de las fuentes para cada parte del Reporte
                FontProp fp_titulo = new FontPropMM(f_helveti, 3.6);
                FontProp fp_cuerpo_titulo = new FontPropMM(f_helveti, 2.2);
                FontProp fp_folio = new FontPropMM(f_helveti, 2.5);
                FontProp fp_cuerpo_datos = new FontPropMM(f_helveti, 1.8);
                FontProp fp_encpie = new FontPropMM(f_helveti, 2);
                FontProp fp_Domi = new FontPropMM(f_helveti, 1.6);
                FontProp fp_mini = new FontPropMM(f_helveti, 1.5);
                FontProp fp_Mediana = new FontPropMM(f_helveti, 1.5);
                FontProp fp_codigoBarra = new FontProp(f_codigoBarra, 1.5);


                System.Globalization.NumberFormatInfo lN2 = new CultureInfo("en-US", false).NumberFormat;
                lN2.NumberDecimalSeparator = ".";
                lN2.NumberGroupSeparator = ",";
                lN2.NumberDecimalDigits = 2;
                lN2.CurrencyDecimalSeparator = ".";
                lN2.CurrencyGroupSeparator = ",";
                lN2.CurrencyDecimalDigits = 2;
                lN2.CurrencyPositivePattern = 2; // sale $ espacio nro

                System.Globalization.NumberFormatInfo lN4 = new CultureInfo("en-US", false).NumberFormat;
                lN4.NumberDecimalSeparator = ".";
                lN4.NumberGroupSeparator = ",";
                lN4.NumberDecimalDigits = 4;
                lN4.CurrencyDecimalSeparator = ".";
                lN4.CurrencyGroupSeparator = ",";
                lN4.CurrencyDecimalDigits = 4;
                lN4.CurrencyPositivePattern = 2; // sale $ espacio nro

                // Armo la TABLA
                TableLayoutManager tabla = new TableLayoutManager(this.reporte);

                // defino la columna de la tabla
                TableLayoutManager.Column tabla_col;

                // pego la fuente del titulo a la tabla
                fp_cuerpo_titulo.bBold = true;
                tabla.fp_Header = fp_cuerpo_titulo;

                //defino altura de la tabla: para manejar el separador de paginas
                tabla.rContainerHeightMM = rposInf - rposSup - rAltoEnc - rMargenEnc - rAltoPie - rMargenPie;
                // linea de abajo separadora de filas en el cuerpo de la tabla
                tabla._cellDef.pp_LineBottom = new PenProp(this.reporte, 0.05, Color.LightGray);
                // el texto continua debajo si no alcanza en el ancho de la celda (wrap)
                tabla._cellDef.textMode = TlmBase.TextMode.MultiLine;

                // defino el evento que se ejecuta al generar una pagina nueva 
                // (nuevo contenedor)
                tabla.eNewContainer += new Root.Reports.TlmBase.NewContainerEventHandler(this.Tabla_NuevaPagina);



                // CUERPO DEL REPORTE

                // busco las UMs, para sacar la cantidad de decimales


                // defino columnas: (tabla, nombre cabecera, ancho en mm) ancho total = 190mm
                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Producto"), 26);

                //tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Cod.SAT"), 15);

                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Descripcion"), 75);

                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Cantidad"), 17);

                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;

                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("U.M."), 13);

                //tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("UM. SAT"), 12.5);

                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Precio Unitario"), 20);

                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;


                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Dto"), 14);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;
                /*
                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Tasa"), 10);

                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;
                */

                tabla_col = new TableLayoutManager.ColumnMM(tabla, Recurso.GetString("Total"), 25);
                tabla_col._cellDef.rAlignH = RepObj.rAlignRight;
                tabla_col.headerCellDef.rAlignH = RepObj.rAlignRight;

                decimal lSubTotal = 0;
                decimal lPU;
                decimal lST;

                Exc.Param.grdCuerpo.ToList().ForEach(renCuerpo =>
                {

                    // agrego las filas y los datos a cada columna
                    tabla.NewRow();
                    tabla.Add(0, new RepString(fp_cuerpo_datos, renCuerpo.Producto_Id));
                    //tabla.Add(1, new RepString(fp_cuerpo_datos, ren.));
                    if (renCuerpo.Observaciones != "")
                        tabla.Add(1, new RepString(fp_cuerpo_datos, renCuerpo.Observaciones));
                    else
                        tabla.Add(1, new RepString(fp_cuerpo_datos, renCuerpo.Detalle));

                    tabla.Add(2, new RepString(fp_cuerpo_datos, renCuerpo.CantOriginal.ToString("N", lN2)));
                    tabla.Add(3, new RepString(fp_cuerpo_datos, renCuerpo.Medida_Id));
                    //tabla.Add(5, new RepString(fp_cuerpo_datos, Exc.Param.Concepto[nCont].ClaveUnidad));

                    lPU = renCuerpo.PrecioForm;
                    lST = renCuerpo.SubTotal;
                    if (!exchCF.Discrimina)
                    {
                        lPU += renCuerpo.PrecioFormImpuesto;
                        lST += renCuerpo.SubTotalFormImpuesto;
                    }

                    tabla.Add(4, new RepString(fp_cuerpo_datos, lPU.ToString("N", lN4)));
                    tabla.Add(5, new RepString(fp_cuerpo_datos, renCuerpo.Bonificacion.ToString("N", lN2)));

                    tabla.Add(6, new RepString(fp_cuerpo_datos, lST.ToString("N", lN2)));

                    lSubTotal += lST;

                });

                tabla.Close(); //cierro la tabla


                // ENCABEZADO Y PIE DEL REPORTE

                // defino el lapiz para la linea
                PenProp lapiz = new PenProp(this.reporte, 1, Color.Black);

                foreach (Page pagina in this.reporte.enum_Page)
                {
                    // ENCABEZADO
                    fp_titulo.bBold = true;
                    ListLayoutManager llm = new ListLayoutManager(this.reporte);

                    ListLayoutManager.Column colTexto = new ListLayoutManager.ColumnMM(llm, 80);
                    colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;


                    /////////////////////////
                    // Datos de la empresa //
                    /////////////////////////
                    MemoryStream pLogoEmp = new MemoryStream(Convert.FromBase64String(ExcEmp.Logo), false);
                    pagina.AddLT_MM(rposIzq + 12, rposSup + 1, new RepImageMM(pLogoEmp, 15, 13));
                    fp_encpie.bBold = true;

                    pagina.AddLT_MM(rposIzq + 12, rposSup + 20, new RepString(fp_titulo, ExcEmp.RazonSocial));
                    pagina.AddLT_MM(rposIzq + 12, rposSup + 29, new RepString(fp_cuerpo_titulo, ExcEmp.Calle + " " + ExcEmp.NoExterior +
                        " " + ExcEmp.Localidad));
                    pagina.AddLT_MM(rposIzq + 12, rposSup + 33, new RepString(fp_cuerpo_titulo, "C.P.: " + ExcEmp.CodigoPostal));
                    pagina.AddLT_MM(rposIzq + 12, rposSup + 37, new RepString(fp_cuerpo_titulo, ExcEmp.DescripcionProvincias));
                    pagina.AddLT_MM(rposIzq + 12, rposSup + 41, new RepString(fp_cuerpo_titulo, "Tel.: " + ExcEmp.Telefono));

                    pagina.AddLT_MM(rposIzq + 120, rposSup + 29, new RepString(fp_cuerpo_titulo, "Fecha: " + Exc.Fecha.ToString("dd/MM/yyyy")));
                    pagina.AddLT_MM(rposIzq + 120, rposSup + 33, new RepString(fp_cuerpo_titulo, "CUIT: " + ExcEmp.Cuit));
                    pagina.AddLT_MM(rposIzq + 120, rposSup + 37, new RepString(fp_cuerpo_titulo, "Ing. Brutos: " + ExcEmp.NumeroIIBB));
                    pagina.AddLT_MM(rposIzq + 120, rposSup + 41, new RepString(fp_cuerpo_titulo, "Inicio de actividades: " +
                        ExcEmp.FechaInicioSociedad.ToString("dd/MM/yyyy")));



                    fp_encpie.bBold = false;

                    ///////////////////////
                    // Datos del cliente //
                    ///////////////////////
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 50, new RepString(fp_cuerpo_titulo, exchClie.RazonSocial));
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 55, new RepString(fp_cuerpo_titulo, exchClie.Direccion1_Fact + " " +
                        exchClie.NroExterior_Fact + " " + exchClie.Localidad_Fact + " C.P:" + exchClie.CodPostal_Fact));
                    pagina.AddLT_MM(rposIzq + 2, rposSup + 60, new RepString(fp_cuerpo_titulo,
                        exchClie.DescripcionProvincia_Id_Fact + " - " + exchClie.DescripcionPais_Id_Fact));

                    pagina.AddLT_MM(rposIzq + 100, rposSup + 55, new RepString(fp_cuerpo_titulo, "IVA: " + exchClie.DescripcionCondFiscal));
                    pagina.AddLT_MM(rposIzq + 100, rposSup + 60, new RepString(fp_cuerpo_titulo, "CUIT: " + exchClie.CUIT));


                    pagina.AddLT_MM(rposIzq + 2, rposSup + 70, new RepString(fp_encpie, "Condición de venta: " + exchClie.DescripcionCondPago));



                    fp_titulo.bBold = false;
                    fp_folio.bBold = true;

                    fp_encpie.bBold = false;


                    // PIE



                    // si tiene mas de una pagina, el pie solo va en la ultima
                    if (pagina.iPageNo.Equals(this.reporte.iPageCount))
                    {
                        fp_encpie.bBold = false;

                        pagina.AddLT_MM(rposDer - 60, rposInf - 54, new RepString(fp_cuerpo_titulo, "Subtotal:"));
                        pagina.AddRT_MM(rposDer - 2, rposInf - 54, new RepString(fp_cuerpo_titulo, lSubTotal.ToString("N", lN2)));

                        pagina.AddLT_MM(rposDer - 60, rposInf - 50, new RepString(fp_cuerpo_titulo, "Descuentos:"));
                        pagina.AddRT_MM(rposDer - 2, rposInf - 50, new RepString(fp_cuerpo_titulo,
                            (Exc.Bonificacion1 + Exc.Bonificacion2 + Exc.Bonificacion3 + Exc.Bonificacion4 + Exc.Bonificacion5).ToString
                            ("N", lN2)));

                        int ultReng = 46;
                        int nImp = 0;

                        if (exchCF.Discrimina)
                        {
                            Exc.Param.grdImpuestos.ToList().ForEach(imp =>
                            {

                                ultReng = 46 - (nImp * 4);

                                pagina.AddLT_MM(rposDer - 60, rposInf - ultReng,
                                    new RepString(fp_cuerpo_titulo, imp.DescripcionImpuestos));

                                pagina.AddRT_MM(rposDer - 2, rposInf - ultReng,
                                    new RepString(fp_cuerpo_titulo, imp.Importe.ToString("N", lN2)));


                            });
                        }

                        pagina.AddLT_MM(rposDer - 60, rposInf - ultReng + 4,
                            new RepString(fp_cuerpo_titulo, "Total:"));
                        pagina.AddRT_MM(rposDer - 2, rposInf - ultReng + 4, new RepString(fp_cuerpo_titulo,
                            Exc.Importe.ToString("N", lN2)));

                        if (Exc.Param.venMovimientosFiscal.Rows.Count > 0)
                        {
                            pagina.AddLT_MM(rposIzq + 2, rposInf - ultReng,
                                new RepString(fp_Mediana, "CAE: " + Exc.Param.venMovimientosFiscal[0].ClaveFiscal));
                            //pagina.AddLT_MM(rposIzq + 2, rposInf - ultReng + 12,
                            //    new RepString(fp_codigoBarra, Exc.Param.venMovimientosFiscal[0].ClaveFiscal));
                            pagina.AddLT_MM(rposIzq + 2, rposInf - ultReng + 4,
                                new RepString(fp_Mediana, "Fecha Vto.: " + Exc.Param.venMovimientosFiscal[0].Fecha.ToString("dd/MM/yyyy")));

                            // Calculo el código de barra //

                            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
                            //codigo.IncludeLabel = true;
                            //codigo.Width = 79;
                            string lBarras = ExcEmp.Cuit.Replace("-", "");
                            lBarras += Exc.Param.venMovimientosFiscal[0].Comprobante_Id.ToString("0#");
                            lBarras += Exc.SucursalEmpr;
                            lBarras += Exc.Param.venMovimientosFiscal[0].ClaveFiscal;
                            lBarras += Exc.Param.venMovimientosFiscal[0].Fecha.ToString("yyyy/MM/dd").Replace("/", "");
                            lBarras = GeneralidadesFEAdv.Varios.StrToI2of5Orig(lBarras);

                            Image img = codigo.Encode(BarcodeLib.TYPE.Interleaved2of5, lBarras);
                            //Image img = codigo.Encode(BarcodeLib.TYPE.Interleaved2of5, "3065076008101000467481989666396201712118");
                            var ms = new MemoryStream();
                            img.Save(ms, ImageFormat.Jpeg);

                            pagina.AddLT_MM(rposIzq + 30, rposInf - ultReng, new RepImageMM(ms, 80, 10));
                            pagina.AddLT_MM(rposIzq + 45, rposInf - ultReng + 12, new RepString(fp_Mediana, lBarras));

                        }


                        llm = new ListLayoutManager(this.reporte);
                        llm.rContainerHeightMM = 15;
                        colTexto = new ListLayoutManager.ColumnMM(llm, 130);
                        colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;
                        llm.container_CreateMM(pagina, rposIzq + 2, rposInf - 55);
                        llm.NewRow();
                        fp_encpie.bBold = true;
                        colTexto.Add(new RepString(fp_encpie, "Son " + Exc.DescripcionMonedas + ": " +
                            GeneralidadesFEAdv.Varios.NroALetra(Exc.Importe, false)));
                        fp_encpie.bBold = false;
                        llm.Commit();
                        llm.Close();

                        pagina.AddLT_MM(rposIzq + 1, rposInf - ultReng + 20,
                            new RepString(fp_Mediana, "Transferencia bancaria CBU 0720000720000002581954 Bco.Santader Río"));

                        //string lObs = "";
                        if (Exc.Observaciones != "")
                        {
                            llm = new ListLayoutManager(this.reporte);
                            llm.rContainerHeightMM = 45;
                            colTexto = new ListLayoutManager.ColumnMM(llm, 130);
                            colTexto.cellDef.textMode = TableLayoutManager.TextMode.MultiLine;
                            llm.container_CreateMM(pagina, rposIzq + 2, rposInf - 20);
                            llm.NewRow();
                            colTexto.Add(new RepString(fp_mini, Exc.Observaciones));
                            llm.Commit();
                            llm.Close();
                        }

                    }


                    //RECUADROS, LINEAS
                    //	Rectangulo general
                    pagina.AddMM(rposIzq, rposInf - 0.5, new RepRectMM(lapiz, rposDer - rposIzq, rposInf - rposSup));

                    // Cuadradito de la Letra de la factura //
                    pagina.AddMM(rposIzq + (rposDer - rposIzq) / 2 - 7, rposSup + 13.5, new RepLineMM(lapiz, 0, 14));
                    pagina.AddMM(rposIzq + (rposDer - rposIzq) / 2 + 7, rposSup + 13.5, new RepLineMM(lapiz, 0, 14));
                    pagina.AddMM(rposIzq + (rposDer - rposIzq) / 2 - 7, rposSup + 13.5, new RepLineMM(lapiz, 14, 0));
                    pagina.AddMM(rposIzq + (rposDer - rposIzq) / 2, rposSup + 13.5, new RepLineMM(lapiz, 0, -31.5));
                    if (Exc.Param.venMovimientosFiscal.Rows.Count > 0)
                    {
                        pagina.AddLT_MM(rposIzq + (rposDer - rposIzq) / 2 - 2, rposSup + 3,
                            new RepString(fp_titulo, Exc.Param.venMovimientosFiscal[0].Letra));
                        pagina.AddLT_MM(rposIzq + (rposDer - rposIzq) / 2 - 5.5, rposSup + 9,
                            new RepString(fp_Mediana, "Código: " + Exc.Param.venMovimientosFiscal[0].Comprobante_Id.ToString("00#")));
                    }

                    pagina.AddLT_MM(rposIzq + 120, rposSup + 3,
                        new RepString(fp_titulo, Exc.SucursalEmpr + " - " + Exc.Segmento1N.ToString("0000000#")));

                    pagina.AddLT_MM(rposIzq + 120, rposSup + 13,
                        new RepString(fp_titulo, Recurso.GetString(exchVTM.Descripcion)));

                    //  Lineas
                    // H1
                    pagina.AddMM(rposIzq, rposSup + 45, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    // H2
                    pagina.AddMM(rposIzq, rposSup + 65, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    //H3
                    pagina.AddMM(rposIzq, rposSup + 81, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    //H4
                    pagina.AddMM(rposIzq, rposInf - 30, new RepLineMM(lapiz, rposDer - rposIzq, 0));
                    //V1

                }



            }
            return this.reporte;
        }

        private void Tabla_NuevaPagina(object oSender, TableLayoutManager.NewContainerEventArgs ea)
        {
            // Nueva pagina
            Page pagina = new Page(this.reporte);
            this.reporte.page_Cur.rHeightMM = rLargo;
            this.reporte.page_Cur.rWidthMM = rAncho;
            // Agrego la tabla
            this.reporte.page_Cur.AddMM(rposIzq, rposSup + rAltoEnc + rMargenEnc, ea.container);
        }

    }
}
