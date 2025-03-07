using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using System.Data;
using SueldosExchange;
using System.Collections;

namespace SueldosFEEventos
{
    public class sueInfDefinibles
    {
        [Generalidades.QFuncion_ObtenerNombreReporte]
        public string Reporte(SueldosCommon.sueInfDefiniblesImpresionDS Exch, Command cmd)
        {
            return "";
        }

        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet Datos(string pParametros, Framework.Core.Command cmd)
        {

            string[] lparametros = pParametros.Split('@');

            string pInforme_Id = lparametros[1].Split('|')[1];
            int pAnio = Convert.ToInt32(lparametros[2].Split('|')[1]);
            int pMes = Convert.ToInt32(lparametros[3].Split('|')[1]);
            int pQuincena = Convert.ToInt32(lparametros[4].Split('|')[1]);
            int pVez = Convert.ToInt32(lparametros[5].Split('|')[1]);
            int pSemana = Convert.ToInt32(lparametros[6].Split('|')[1]);
            int pDecena = Convert.ToInt32(lparametros[7].Split('|')[1]);
            string pGenerarBy = lparametros[8].Split('|')[1];
            DateTime pFechaDesde = Convert.ToDateTime(lparametros[9].Split('|')[1]);
            DateTime pFechaHasta = Convert.ToDateTime(lparametros[10].Split('|')[1]);
            int pLegajoDesde = Convert.ToInt32(lparametros[11].Split('|')[1]);
            int pLegajoHasta = Convert.ToInt32(lparametros[12].Split('|')[1]);
            string pConvenioDesde = lparametros[13].Split('|')[1];
            string pConvenioHasta = lparametros[14].Split('|')[1];
            string pSucursalDesde = lparametros[15].Split('|')[1];
            string pSucursalHasta = lparametros[16].Split('|')[1];
            string pCentro1Desde = lparametros[17].Split('|')[1];
            string pCentro1Hasta = lparametros[18].Split('|')[1];
            string pCentro2Desde = lparametros[19].Split('|')[1];
            string pCentro2Hasta = lparametros[20].Split('|')[1];
            string pSegmento_Id = lparametros[21].Split('|')[1];
            int pSegmento1N = Convert.ToInt32(lparametros[22].Split('|')[1]);
            int pSegmento2N = Convert.ToInt32(lparametros[23].Split('|')[1]);
            int pSegmento3N = Convert.ToInt32(lparametros[24].Split('|')[1]);
            int pSegmento4N = Convert.ToInt32(lparametros[25].Split('|')[1]);
            string pSegmento1C = lparametros[26].Split('|')[1];
            string pSegmento2C = lparametros[27].Split('|')[1];
            string pSegmento3C = lparametros[28].Split('|')[1];
            string pSegmento4C = lparametros[29].Split('|')[1];
            string pSegmentoStr = lparametros[29].Split('|')[1];

            DataTable dataTable = new DataTable("Resultado");
            dataTable.Columns.Add("Legajo", typeof(System.Int32));
            dataTable.Columns.Add("Nombre", typeof(System.String));

            // Traigo la estuctura del Reporte
            SueldosExchange.sueInfDefiniblesActionExchange eRepo = new sueInfDefiniblesActionExchange(sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction.Datos)
            {
                Informe_Id = pInforme_Id
            };
            eRepo = new sueInfDefiniblesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepo, cmd));
            if (!eRepo.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("El_Informe_<0>_No_Existe", new object[] { pInforme_Id });
            //Genero mi tabla en la que regreso los datos

            int nCol = 1;
            foreach (var col in eRepo.Param.Formulas)
            {
                switch (col.Tipo)
                {
                    case "C":
                        dataTable.Columns.Add(GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo), typeof(System.String));
                        break;
                    case "N":
                        if (col.Formato.ToLower() == "i")
                            dataTable.Columns.Add(GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo), typeof(System.Int32));
                        else
                            dataTable.Columns.Add(GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo), typeof(System.Decimal));
                        break;
                    case "L":
                        dataTable.Columns.Add(GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo), typeof(System.Boolean));
                        break;
                    case "D":
                    case "F":
                        dataTable.Columns.Add(GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo), typeof(System.DateTime));
                        break;
                }
                nCol++;
            }

            var eMoneda = GeneralesValidacion.genMonedas.Existe(cmd.MonedaBase, cmd);

            // tarigo los empleados que Participan en el reporte
            SueldosCommon.sueInfDefEmpleadosDS lDsE =
            SueldosDAL.sueInfDefinibles.DatosEmpleados(pAnio, pMes, pQuincena, pVez, pSemana, pDecena, pGenerarBy, pFechaDesde, pFechaHasta, pLegajoDesde, pLegajoHasta, pSucursalDesde, pSucursalHasta, pConvenioDesde, pConvenioHasta, pCentro1Desde, pCentro1Hasta, pCentro2Desde, pCentro2Hasta, cmd.Empresa_Id, cmd.ConnectionString);

            
            SueldosExchange.sueLiquidacionActionExchange eliq = new sueLiquidacionActionExchange(sueLiquidacionActionEnum.EnumsueLiquidacionAction.Datos)
            {
                Segmento_Id = pSegmento_Id,
                Segmento1N = pSegmento1N,
                Segmento2N = pSegmento2N,
                Segmento3N = pSegmento3N,
                Segmento4N = pSegmento4N,
                Segmento1C = pSegmento1C,
                Segmento2C = pSegmento2C,
                Segmento3C = pSegmento3C,
                Segmento4C = pSegmento4C
            };
            eliq = new sueLiquidacionActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eliq, cmd));
            if (!eliq.Existe)
            {
                // Tengo que calcular la FechaFinal para usarla para traer los datos de Personal a determinada fecha //
                if (pMes != 0)
                {
                    eliq.FechaFinal = new DateTime(pAnio, pMes, 1).AddMonths(1).AddDays(-1);
                }
                else
                    eliq.FechaFinal = new DateTime(pAnio, 12, 31);

                // Tengo que volver a asignar los parciales que vinieron de la pantalla y que se blanqearon porque no existía la liquidación //
                eliq.Anio = pAnio;
                eliq.Mes = pMes;
                eliq.Quincena = pQuincena;
                eliq.Vez = pVez;
                eliq.Semana = pSemana;
                eliq.Decena = pDecena;

                pSegmentoStr = GeneralesValidacion.genSegmentos.SegmentoStr(pSegmento_Id, pSegmento1C, pSegmento2C, pSegmento3C, pSegmento4C, pSegmento1N, pSegmento2N, pSegmento3N, pSegmento4N, cmd).SegmentoSTR;
            }


            foreach (var empele in lDsE.Principal)
            {
                bool lAgrego = true;
                //var row = dataTable.Rows.Add();
                DataRow row = dataTable.NewRow();
                row[0] = empele.Legajo;
                row[1] = empele.Nombres + (String.IsNullOrEmpty(empele.ApellidoPaterno) ? "" : "," + empele.ApellidoPaterno) +
                        (String.IsNullOrEmpty(empele.ApellidoMaterno) ? "" : "," + empele.ApellidoMaterno);

                SueldosExchange.suePersonalActionExchange eEmple = new suePersonalActionExchange(suePersonalActionEnum.EnumsuePersonalAction.Datos)
                {
                    Legajo = empele.Legajo,
                    Fecha = eliq.FechaFinal
                };
                eEmple = new suePersonalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eEmple, cmd));

                decimal[] variables = new decimal[100];

                for (int i = 0; i < variables.Length; i++)
                {
                    variables[i] = 0;
                }

                Hashtable ArrobaVariables = new Hashtable();

                SueldosCommon.sueConcDescuentoDS sueConcDescuentoDS = new SueldosCommon.sueConcDescuentoDS();

                nCol = 1;
                foreach (var col in eRepo.Param.Formulas)
                {


                    SueldosExchange.sueConceptosActionExchange eConcepto = new sueConceptosActionExchange(sueConceptosActionEnum.EnumsueConceptosAction.Datos)
                    {
                        Concepto_Id = 0,
                        Formula = col.Formula
                    };

                    var sueFormulas = new SueldosValidacion.sueFormulas(eliq, eEmple, new sueConceptosActionExchange(), ref variables, ref sueConcDescuentoDS, eRepo, row, ref ArrobaVariables, cmd);


                    switch (col.Tipo)
                    {
                        case "C":

                            string lResc = sueFormulas.EjecutarC("SUELEXICO", col.Formula, cmd);
                            row[GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo)] = lResc;
                            if (lResc.Trim() == "" && col.CheckCero)
                            {
                                lAgrego = false;
                                break;
                            }
                            break;
                        case "N":
                            decimal lResn = Generalidades.Auxiliares.Redondear(sueFormulas.EjecutarN("SUELEXICO", col.Formula, cmd), eMoneda.CantidadDigitos);
                            row[GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo)] = lResn;
                            if (lResn == 0 && col.CheckCero)
                            {
                                lAgrego = false;
                                break;
                            }
                            break;
                        case "L":
                            bool lResl = sueFormulas.EjecutarL("SUELEXICO", col.Formula, cmd);
                            row[GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo)] = lResl;
                            lAgrego = !(!lResl && col.CheckCero);
                            if (!lAgrego)
                                break;
                            break;
                        case "D":
                        case "F":
                            DateTime lResF = sueFormulas.EjecutarF("SUELEXICO", col.Formula, cmd);
                            row[GeneralidadesFEAdv.Varios.QuitarCaracteres(col.Titulo)] = lResF;
                            if (lResF == Generalidades.Nulls.NullDate && col.CheckCero)
                            {
                                lAgrego = false;
                                break;
                            }
                            break;
                    }
                    nCol++;
                }

                if (lAgrego)
                    dataTable.Rows.Add(row);

            }
            dataTable.AcceptChanges();

            //eRepo = new SueldosExchange.sueInfDefiniblesImpresionActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepo, cmd));
            DataSet lRes = new DataSet();
            DataTable lTitulos = new DataTable("Titulos");
            lTitulos.Columns.Add("Titulo", typeof(System.String));
            lTitulos.Columns.Add("SegmentoStr", typeof(System.String));
            lTitulos.Columns.Add("Informe_Id", typeof(System.String));
            lTitulos.Rows.Add();
            lTitulos.Rows[0]["Titulo"] = eRepo.Descripcion;
            lTitulos.Rows[0]["SegmentoStr"] = pSegmentoStr;
            lTitulos.Rows[0]["Informe_Id"] = eRepo.Informe_Id;
            lRes.Tables.Add(dataTable);
            lRes.Tables.Add(lTitulos);
            lRes.AcceptChanges();
            return lRes;
        }
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(SueldosCommon.sueInfDefiniblesImpresionDS exch, Command cmd)
        {

            
            var lSegmento = GeneralesValidacion.genSegmentos.SegmentoStr(exch.Principal[0].Segmento_Id,
                    exch.Principal[0].Segmento1C, exch.Principal[0].Segmento2C, exch.Principal[0].Segmento3C,
                    exch.Principal[0].Segmento4C, exch.Principal[0].Segmento1N, exch.Principal[0].Segmento2N,
                    exch.Principal[0].Segmento3N, exch.Principal[0].Segmento4N, cmd);
            /*
            return
                   "SegmentoSrt|" + lSegento.SegmentoSTR +
                   "@Informe_Id|" + exch.Principal[0].Informe_Id +
                   "@Empresa_Id|" + cmd.Empresa_Id.ToString() +
                   "@Segmento_Id|" + exch.Principal[0].Segmento_Id +
                   "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
                   "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
                   "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
                   "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
                   "@Segmento1C|" + exch.Principal[0].Segmento1C +
                   "@Segmento2C|" + exch.Principal[0].Segmento2C +
                   "@Segmento3C|" + exch.Principal[0].Segmento3C +
                   "@Segmento4C|" + exch.Principal[0].Segmento4C +
                   "@LegajoDesde|" + exch.Principal[0].LegajoDesde.ToString() +
                   "@LegajoHasta|" + exch.Principal[0].LegajoHasta.ToString() +
                   "@ConvenioDesde|" + exch.Principal[0].ConvenioDesde +
                   "@ConvenioHasta|" + exch.Principal[0].ConvenioHasta +
                   "@SucursalDesde|" + exch.Principal[0].SucursalDesde +
                   "@SucursalHasta|" + exch.Principal[0].SucursalHasta +
                   "@Centro1Desde|" + exch.Principal[0].Centro1Desde +
                   "@Centro1Hasta|" + exch.Principal[0].Centro1Hasta +
                   "@Centro2Desde|" + exch.Principal[0].Centro2Desde +
                   "@Centro2Hasta|" + exch.Principal[0].Centro2Hasta;
            */

            return "@Informe_Id|" + exch.Principal[0].Informe_Id +
                    "@Anio|" + exch.Principal[0].Anio.ToString() +
                    "@Mes|" + exch.Principal[0].Mes.ToString() +
                    "@Quincena|" + exch.Principal[0].Quincena.ToString() +
                    "@Vez|" + exch.Principal[0].Vez.ToString() +
                    "@Semana|" + exch.Principal[0].Semana.ToString() +
                    "@Decena|" + exch.Principal[0].Decena.ToString() +
                    "@GenerarBy|" + exch.Principal[0].GenerarBy +
                    "@FechaDesde|" + exch.Principal[0].FechaDesde.ToString() +
                    "@FechaHasta|" + exch.Principal[0].FechaHasta.ToString() +
                    "@LegajoDesde|" + exch.Principal[0].LegajoDesde.ToString() +
                    "@LegajoHasta|" + exch.Principal[0].LegajoHasta.ToString() +
                    "@ConvenioDesde|" + exch.Principal[0].ConvenioDesde +
                    "@ConvenioHasta|" + exch.Principal[0].ConvenioHasta +
                    "@SucursalDesde|" + exch.Principal[0].SucursalDesde +
                    "@SucursalHasta|" + exch.Principal[0].SucursalHasta +
                    "@Centro1Desde|" + exch.Principal[0].Centro1Desde +
                    "@Centro1Hasta|" + exch.Principal[0].Centro1Hasta +
                    "@Centro2Desde|" + exch.Principal[0].Centro2Desde +
                    "@Centro2Hasta|" + exch.Principal[0].Centro2Hasta +
                    "@Segmento_Id|" + exch.Principal[0].Segmento_Id +
                    "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
                    "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
                    "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
                    "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
                    "@Segmento1C|" + exch.Principal[0].Segmento1C +
                    "@Segmento2C|" + exch.Principal[0].Segmento2C +
                    "@Segmento3C|" + exch.Principal[0].Segmento3C +
                    "@Segmento4C|" + exch.Principal[0].Segmento4C +
                    "@SegmentoStr|" + lSegmento;

        }
        [Generalidades.QFuncion_ObtenerXMLReporte]
        public Generalidades.XMLReporteDS Xml(string pParametros, Framework.Core.Command cmd)
        {

            SueldosExchange.sueGenerarInfDefiniblesActionExchange eRepo = new SueldosExchange.sueGenerarInfDefiniblesActionExchange(SueldosExchange.sueGenerarInfDefiniblesActionEnum.EnumsueGenerarInfDefiniblesAction.Datos)
            {
                Informe_Id = pParametros.Split('@')[1].Split('|')[1]

            };
            eRepo = new SueldosExchange.sueGenerarInfDefiniblesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepo, cmd));

            string lTamanioPagina = eRepo.TamanioHoja;
            decimal lAltoPagina = 0;
            decimal lAnchoPagina = 0;
            GeneralesExchange.genTamanioHojaActionExchange eTam = new GeneralesExchange.genTamanioHojaActionExchange(GeneralesExchange.genTamanioHojaActionEnum.EnumgenTamanioHojaAction.Datos)
            {
                TamanioHoja = lTamanioPagina
            };
            eTam = new GeneralesExchange.genTamanioHojaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eTam, cmd));
            if (eTam.Existe)
            {
                if (!eRepo.Horizontal)
                {
                    lAltoPagina = eRepo.Um == "in" ? eTam.AltoIn : eTam.Altocm;
                    lAnchoPagina = eRepo.Um == "in" ? eTam.AnchoIn : eTam.Anchicm;
                }
                else
                {
                    lAltoPagina = eRepo.Um == "in" ? eTam.AnchoIn : eTam.Anchicm;
                    lAnchoPagina = eRepo.Um == "in" ? eTam.AltoIn : eTam.Altocm;
                }
                lTamanioPagina = eTam.Descripcion;
            }

            return Generalidades.Archivos.ConvertirADatasetXMLRpt(lTamanioPagina, (int)lAltoPagina, (int)lAnchoPagina, eRepo.NombreArchivo);

        }


        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXls(SueldosCommon.sueInfDefiniblesImpresionDS Exch, Command cmd)
        {

            string lParmetros = Parametros(Exch, cmd);
            DataSet dataSet = Datos(lParmetros, cmd);
            return Generalidades.Archivos.DataSetAXLSxaDownload(Exch.Principal[0].DescripcionInforme + ".xlsx", dataSet,
                    cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id);

        }

        [Generalidades.QFuncion_AccionFE]
        public SueldosCommon.sueInfDefiniblesImpresionDS VezActiva(SueldosCommon.sueInfDefiniblesImpresionDS pCommonDS, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Anio == 0)
            {
                SueldosCommon.sueInfDefiniblesImpresionDS res = new SueldosCommon.sueInfDefiniblesImpresionDS();
                res.Merge(SueldosValidacion.sueVezActiva.Asignar(new Framework.Core.Exchange("", pCommonDS), cmd).RawDataSet, false, System.Data.MissingSchemaAction.Ignore);
                return res;
            }
            else
                return pCommonDS;
        }
    }
}
