using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using System.Data;
namespace TesoreriaFEEventos
{
    public class tesFlujoFondo
    {

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesFlujoFondoDS ValidarTipoDeFila(TesoreriaCommon.tesFlujoFondoDS pCommonDS,
                TesoreriaCommon.tesFlujoFondoDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            if (pCommonDSNoPost.Flujo[0].Tipo != "C")
                Generalidades.qFunctionalException.GenerarExcepcion("No_Se_Puede_Editar_Este_Renglon");

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string TipoFila(TesoreriaCommon.tesFlujoFondoDS pCommonDS, TesoreriaCommon.tesFlujoFondoDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string lRetorno = pCommonDSNoPost.Flujo[0].Tipo;

            return lRetorno;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesFlujoFondoDS CalcularTotClientes(TesoreriaCommon.tesFlujoFondoDS pCommonDS, TesoreriaCommon.tesFlujoFondoDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            if (pCommonDSNoPost.Flujo[0].Tipo == "C")
            {
                pCommonDSNoPost.Flujo[0].SaldoAnterior = 0;
                pCommonDSNoPost.Flujo[0].Columna01 = 0;
                pCommonDSNoPost.Flujo[0].Columna02 = 0;
                pCommonDSNoPost.Flujo[0].Columna03 = 0;
                pCommonDSNoPost.Flujo[0].Columna04 = 0;
                pCommonDSNoPost.Flujo[0].Columna05 = 0;
                pCommonDSNoPost.Flujo[0].Columna06 = 0;
                pCommonDSNoPost.Flujo[0].Columna07 = 0;
                pCommonDSNoPost.Flujo[0].Columna08 = 0;
                pCommonDSNoPost.Flujo[0].Columna09 = 0;
                pCommonDSNoPost.Flujo[0].Columna10 = 0;
                pCommonDSNoPost.Flujo[0].Columna11 = 0;
                pCommonDSNoPost.Flujo[0].Columna12 = 0;
                pCommonDSNoPost.Flujo[0].Total = 0;
                foreach (var ren in pCommonDSNoPost.Clientes)
                {
                    pCommonDSNoPost.Flujo[0].SaldoAnterior += ren.SaldoAnterior;
                    pCommonDSNoPost.Flujo[0].Columna01 += ren.Columna01;
                    pCommonDSNoPost.Flujo[0].Columna02 += ren.Columna02;
                    pCommonDSNoPost.Flujo[0].Columna03 += ren.Columna03;
                    pCommonDSNoPost.Flujo[0].Columna04 += ren.Columna04;
                    pCommonDSNoPost.Flujo[0].Columna05 += ren.Columna05;
                    pCommonDSNoPost.Flujo[0].Columna06 += ren.Columna06;
                    pCommonDSNoPost.Flujo[0].Columna07 += ren.Columna07;
                    pCommonDSNoPost.Flujo[0].Columna08 += ren.Columna08;
                    pCommonDSNoPost.Flujo[0].Columna09 += ren.Columna09;
                    pCommonDSNoPost.Flujo[0].Columna10 += ren.Columna10;
                    pCommonDSNoPost.Flujo[0].Columna11 += ren.Columna11;
                    pCommonDSNoPost.Flujo[0].Columna12 += ren.Columna12;
                    pCommonDSNoPost.Flujo[0].Total += ren.SaldoAnterior +
                            ren.Columna01 + ren.Columna02 + ren.Columna03 +
                            ren.Columna04 + ren.Columna05 + ren.Columna06 +
                            ren.Columna07 + ren.Columna08 + ren.Columna09 +
                            ren.Columna10 + ren.Columna11 + ren.Columna12;

                }

            }
            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesFlujoFondoDS CalcularTotProveedores(TesoreriaCommon.tesFlujoFondoDS pCommonDS, TesoreriaCommon.tesFlujoFondoDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            if (pCommonDSNoPost.Flujo[0].Tipo == "P")
            {
                pCommonDSNoPost.Flujo[0].SaldoAnterior = 0;
                pCommonDSNoPost.Flujo[0].Columna01 = 0;
                pCommonDSNoPost.Flujo[0].Columna02 = 0;
                pCommonDSNoPost.Flujo[0].Columna03 = 0;
                pCommonDSNoPost.Flujo[0].Columna04 = 0;
                pCommonDSNoPost.Flujo[0].Columna05 = 0;
                pCommonDSNoPost.Flujo[0].Columna06 = 0;
                pCommonDSNoPost.Flujo[0].Columna07 = 0;
                pCommonDSNoPost.Flujo[0].Columna08 = 0;
                pCommonDSNoPost.Flujo[0].Columna09 = 0;
                pCommonDSNoPost.Flujo[0].Columna10 = 0;
                pCommonDSNoPost.Flujo[0].Columna11 = 0;
                pCommonDSNoPost.Flujo[0].Columna12 = 0;
                pCommonDSNoPost.Flujo[0].Total = 0;
                foreach (var ren in pCommonDSNoPost.Proveedores)
                {
                    pCommonDSNoPost.Flujo[0].SaldoAnterior += ren.SaldoAnterior;
                    pCommonDSNoPost.Flujo[0].Columna01 += ren.Columna01;
                    pCommonDSNoPost.Flujo[0].Columna02 += ren.Columna02;
                    pCommonDSNoPost.Flujo[0].Columna03 += ren.Columna03;
                    pCommonDSNoPost.Flujo[0].Columna04 += ren.Columna04;
                    pCommonDSNoPost.Flujo[0].Columna05 += ren.Columna05;
                    pCommonDSNoPost.Flujo[0].Columna06 += ren.Columna06;
                    pCommonDSNoPost.Flujo[0].Columna07 += ren.Columna07;
                    pCommonDSNoPost.Flujo[0].Columna08 += ren.Columna08;
                    pCommonDSNoPost.Flujo[0].Columna09 += ren.Columna09;
                    pCommonDSNoPost.Flujo[0].Columna10 += ren.Columna10;
                    pCommonDSNoPost.Flujo[0].Columna11 += ren.Columna11;
                    pCommonDSNoPost.Flujo[0].Columna12 += ren.Columna12;
                    pCommonDSNoPost.Flujo[0].Total += ren.SaldoAnterior +
                            ren.Columna01 + ren.Columna02 + ren.Columna03 +
                            ren.Columna04 + ren.Columna05 + ren.Columna06 +
                            ren.Columna07 + ren.Columna08 + ren.Columna09 +
                            ren.Columna10 + ren.Columna11 + ren.Columna12;

                }

            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_CondicionEdicionGrilla]
        public bool Editable(TesoreriaCommon.tesFlujoFondoDS Exch, TesoreriaCommon.tesFlujoFondoDS exchNoPost,
                int pIndice, Command cmd)
        {

            if (Exch.Flujo[pIndice].Tipo == "C" || Exch.Flujo[pIndice].Tipo == "P" ||
                    Exch.Flujo[pIndice].Tipo == "OI" || Exch.Flujo[pIndice].Tipo == "OE"
                    || Exch.Flujo[pIndice].Tipo == "CT")
                return true;

            return false;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesFlujoFondoDS CalcularTotCheques(TesoreriaCommon.tesFlujoFondoDS pCommonDS, TesoreriaCommon.tesFlujoFondoDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            if (pCommonDSNoPost.Flujo[0].Tipo == "CT")
            {
                pCommonDSNoPost.Flujo[0].SaldoAnterior = 0;
                pCommonDSNoPost.Flujo[0].Columna01 = 0;
                pCommonDSNoPost.Flujo[0].Columna02 = 0;
                pCommonDSNoPost.Flujo[0].Columna03 = 0;
                pCommonDSNoPost.Flujo[0].Columna04 = 0;
                pCommonDSNoPost.Flujo[0].Columna05 = 0;
                pCommonDSNoPost.Flujo[0].Columna06 = 0;
                pCommonDSNoPost.Flujo[0].Columna07 = 0;
                pCommonDSNoPost.Flujo[0].Columna08 = 0;
                pCommonDSNoPost.Flujo[0].Columna09 = 0;
                pCommonDSNoPost.Flujo[0].Columna10 = 0;
                pCommonDSNoPost.Flujo[0].Columna11 = 0;
                pCommonDSNoPost.Flujo[0].Columna12 = 0;
                pCommonDSNoPost.Flujo[0].Total = 0;
                foreach (var ren in pCommonDSNoPost.Cheques)
                {
                    pCommonDSNoPost.Flujo[0].SaldoAnterior += ren.SaldoAnterior;
                    pCommonDSNoPost.Flujo[0].Columna01 += ren.Columna01;
                    pCommonDSNoPost.Flujo[0].Columna02 += ren.Columna02;
                    pCommonDSNoPost.Flujo[0].Columna03 += ren.Columna03;
                    pCommonDSNoPost.Flujo[0].Columna04 += ren.Columna04;
                    pCommonDSNoPost.Flujo[0].Columna05 += ren.Columna05;
                    pCommonDSNoPost.Flujo[0].Columna06 += ren.Columna06;
                    pCommonDSNoPost.Flujo[0].Columna07 += ren.Columna07;
                    pCommonDSNoPost.Flujo[0].Columna08 += ren.Columna08;
                    pCommonDSNoPost.Flujo[0].Columna09 += ren.Columna09;
                    pCommonDSNoPost.Flujo[0].Columna10 += ren.Columna10;
                    pCommonDSNoPost.Flujo[0].Columna11 += ren.Columna11;
                    pCommonDSNoPost.Flujo[0].Columna12 += ren.Columna12;
                    pCommonDSNoPost.Flujo[0].Total += ren.SaldoAnterior +
                            ren.Columna01 + ren.Columna02 + ren.Columna03 +
                            ren.Columna04 + ren.Columna05 + ren.Columna06 +
                            ren.Columna07 + ren.Columna08 + ren.Columna09 +
                            ren.Columna10 + ren.Columna11 + ren.Columna12;

                }

            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(TesoreriaCommon.tesFlujoFondoDS pCommonDS, Command cmd)
        {
            string lRetorno = "Segmento_Id|" + pCommonDS.Principal[0].Segmento_Id + "@" +
                "Segmento1C|" + pCommonDS.Principal[0].Segmento1C + "@" +
                "Segmento2C|" + pCommonDS.Principal[0].Segmento2C + "@" +
                "Segmento3C|" + pCommonDS.Principal[0].Segmento3C + "@" +
                "Segmento4C|" + pCommonDS.Principal[0].Segmento4C + "@" +
                "Segmento1N|" + pCommonDS.Principal[0].Segmento1N.ToString() + "@" +
                "Segmento2N|" + pCommonDS.Principal[0].Segmento2N.ToString() + "@" +
                "Segmento3N|" + pCommonDS.Principal[0].Segmento3N.ToString() + "@" +
                "Segmento4N|" + pCommonDS.Principal[0].Segmento4N.ToString() + "@" +
                "Fecha|" + pCommonDS.Principal[0].Fecha.ToString() + '@' +
                "Periodo|" + pCommonDS.Principal[0].Periodo;

            ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
            return lRetorno;
        }

        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet LlenarReport(string pParametros, Framework.Core.Command cmd)
        {
            DataSet lRetorno = new DataSet();
            string[] lPar = pParametros.Split('@');
            TesoreriaExchange.tesFlujoFondoActionExchange eFF = new TesoreriaExchange.tesFlujoFondoActionExchange(TesoreriaExchange.tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Calcular)
            {
                Segmento_Id = lPar[0].Split('|')[1],
                Segmento1C = lPar[1].Split('|')[1],
                Segmento2C = lPar[2].Split('|')[1],
                Segmento3C = lPar[3].Split('|')[1],
                Segmento4C = lPar[4].Split('|')[1],
                Segmento1N = Convert.ToInt32(lPar[5].Split('|')[1]),
                Segmento2N = Convert.ToInt32(lPar[6].Split('|')[1]),
                Segmento3N = Convert.ToInt32(lPar[7].Split('|')[1]),
                Segmento4N = Convert.ToInt32(lPar[8].Split('|')[1]),
                Fecha = Convert.ToDateTime(lPar[9].Split('|')[1]),
                Periodo = lPar[10].Split('|')[1]
            };
            eFF.FechaDesde = eFF.Fecha;
            eFF = new TesoreriaExchange.tesFlujoFondoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eFF, cmd));
            if (!eFF.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("El_Movimiento_No_Existe");

            lRetorno.Tables.Add("Principal");
            lRetorno.Tables["Principal"].Columns.Add("Segmento_Id", typeof(string));
            lRetorno.Tables["Principal"].Columns.Add("Segmento1C", typeof(string));
            lRetorno.Tables["Principal"].Columns.Add("Segmento2C", typeof(string));
            lRetorno.Tables["Principal"].Columns.Add("Segmento3C", typeof(string));
            lRetorno.Tables["Principal"].Columns.Add("Segmento4C", typeof(string));
            lRetorno.Tables["Principal"].Columns.Add("Segmento1N", typeof(Int32));
            lRetorno.Tables["Principal"].Columns.Add("Segmento2N", typeof(Int32));
            lRetorno.Tables["Principal"].Columns.Add("Segmento3N", typeof(Int32));
            lRetorno.Tables["Principal"].Columns.Add("Segmento4N", typeof(Int32));
            lRetorno.Tables["Principal"].Columns.Add("Fecha", typeof(DateTime));
            lRetorno.Tables["Principal"].Columns.Add("Periodo", typeof(string));
            lRetorno.Tables["Principal"].Columns.Add("SegmentoSTR", typeof(string));

            string lSegmentoStr = GeneralesValidacion.genSegmentos.SegmentoStr(
                    eFF.Segmento_Id, eFF.Segmento1C, eFF.Segmento2C, eFF.Segmento3C,
                    eFF.Segmento4C, eFF.Segmento1N, eFF.Segmento2N, eFF.Segmento3N,
                    eFF.Segmento4N, cmd).SegmentoSTR;

            lRetorno.Tables["Principal"].Rows.Add(new object[] { eFF.Segmento_Id,
                eFF.Segmento1C,eFF.Segmento2C, eFF.Segmento3C, eFF.Segmento4C,
                eFF.Segmento1N, eFF.Segmento2N, eFF.Segmento3N, eFF.Segmento4N,
                eFF.Fecha, eFF.Periodo, lSegmentoStr});

            lRetorno.Tables.Add("Flujo");
            lRetorno.Tables["Flujo"].Merge(eFF.Param.Flujo, true);

            lRetorno.Tables.Add("Titulos");
            lRetorno.Tables["Titulos"].Merge(eFF.Param.Titulos, true);
            lRetorno.AcceptChanges();
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXls(TesoreriaCommon.tesFlujoFondoDS pCommonDS, Command cmd)
        {

            DataSet lRes = new DataSet();

            lRes.Tables.Add("Flujo");
            lRes.Tables["Flujo"].Merge(pCommonDS.Flujo);
            lRes.Tables["Flujo"].Columns.Remove("Codigo");
            lRes.Tables["Flujo"].Columns.Remove("Tipo");


            int n = 13;
            if (pCommonDS.Principal[0].Periodo == "D")
            {
                // QUITO LAS COLUMNAS 8 A 12
                for (int i = 8; i < 13; i++)
                {
                    lRes.Tables["Flujo"].Columns.Remove("Columna" + i.ToString("00"));
                }
                n = 8;
            }
            if (pCommonDS.Principal[0].Periodo == "S")
            {
                // QUITO LAS COLUMNAS 9 A 12
                for (int i = 9; i < 13; i++)
                {
                    lRes.Tables["Flujo"].Columns.Remove("Columna" + i.ToString());
                }
                n = 9;
            }
            for (int j = 0; j < lRes.Tables["Flujo"].Rows.Count; j++)
            {
                for (int i = 1; i < n; i++)
                {

                    lRes.Tables["Flujo"].Rows[j]["Columna" + i.ToString("00")] =
                            Math.Round(Convert.ToDecimal(lRes.Tables["Flujo"].Rows[j]["Columna" + i.ToString("00")]), 2);
                }
                lRes.Tables["Flujo"].Rows[j]["Total"] =
                        Math.Round(Convert.ToDecimal(lRes.Tables["Flujo"].Rows[j]["Total"]));
                lRes.Tables["Flujo"].Rows[j]["SaldoAnterior"] =
                        Math.Round(Convert.ToDecimal(lRes.Tables["Flujo"].Rows[j]["SaldoAnterior"]));
            }

            
            for (int i = 1; i < n; i++)
            {
                lRes.Tables["Flujo"].Columns["Columna" + i.ToString("00")].ColumnName =
                        pCommonDS.Titulos[0]["Col"+i.ToString("00")].ToString();
            }
            

            return Generalidades.Archivos.DataTableAXLSxaDownload("FlujoFondo.xlsx", lRes.Tables["Flujo"],
                cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id);


        }

    }
}
