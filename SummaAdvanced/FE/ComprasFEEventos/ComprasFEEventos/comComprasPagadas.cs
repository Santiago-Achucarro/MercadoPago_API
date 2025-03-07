using Framework.Core;
using System;

namespace ComprasFEEventos
{
    class comComprasPagadas
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarTxtDiot(ComprasCommon.PagadasDSDS ds, Framework.Core.Command cmd)
        {
            DateTime lDateTime = GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd);

            ComprasExchange.comComprasPagadasActionExchange eTxt = new ComprasExchange.comComprasPagadasActionExchange(ComprasExchange.comComprasPagadasActionEnum.EnumcomComprasPagadasAction.Guardar);
            eTxt.Param.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            eTxt.Param.Principal[0].Delete();
            eTxt.Param.AcceptChanges();
            eTxt = new ComprasExchange.comComprasPagadasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eTxt, cmd));

            return Generalidades.Archivos.ConvertirADatasetDownload("txt", "Diot" + lDateTime.Year.ToString() + lDateTime.Month.ToString("00") + ".txt", false, "txt", eTxt.Text);


        }

        ///Si no es invocado desde eventos de grilla
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string ObtenerParamsReporte(ComprasCommon.PagadasDSDS Exch, Command cmd)
        {
            string lRetorno = "FechaDesde|" + Exch.Principal[0].FechaDesde + "@FechaHasta|" + Exch.Principal[0].FechaHasta;
            ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
            return lRetorno;
        }
    }
}
