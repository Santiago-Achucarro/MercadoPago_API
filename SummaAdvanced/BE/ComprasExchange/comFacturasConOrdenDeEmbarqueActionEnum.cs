using System;
/// Generado por QBI viernes, 16 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comFacturasConOrdenDeEmbarqueActionEnum
    {
        public enum EnumcomFacturasConOrdenDeEmbarqueAction
        {
            Guardar, Datos, Eliminar, CalcularTotales, CalcularTotalImp, SubirXML, AsignarFecha, CalcularImpuesto, MarcarTodas, ObtenerCambio, Adjuntos
        }
        public static string GetAccioncomFacturasConOrdenDeEmbarqueAction(comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.Guardar: lRetorno = "comFacturasConOrdenDeEmbarqueGuardar"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.Datos: lRetorno = "comFacturasConOrdenDeEmbarqueDevolverDatos"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.Eliminar: lRetorno = "comFacturasConOrdenDeEmbarqueEliminar"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.CalcularTotales: lRetorno = "comFacturasConOrdenDeEmbarqueCalcularTotales"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.CalcularTotalImp: lRetorno = "comFacturasConOrdenDeEmbarqueCalcularTotalImp"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.SubirXML: lRetorno = "comFacturasConOrdenDeEmbarqueSubirXML"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.AsignarFecha: lRetorno = "comFacturasConOrdenDeEmbarqueAsignarFecha"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.CalcularImpuesto: lRetorno = "comFacturasConOrdenDeEmbarqueCalcularImpuesto"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.MarcarTodas: lRetorno = "comFacturasConOrdenDeEmbarqueMarcarTodas"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.ObtenerCambio: lRetorno = "comFacturasConOrdenDeEmbarqueObtenerCambio"; break;
                case comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.Adjuntos: lRetorno = "comFacturasConOrdenDeEmbarqueAdjuntos"; break;


            }
            return lRetorno;
        }


        public static ComprasExchange.comMovProvDatosConStockActionExchange ToExcConStock(ComprasExchange.comFacturasConOrdenDeEmbarqueActionExchange req)
        {
            ComprasExchange.comMovProvDatosConStockActionExchange Exc = new comMovProvDatosConStockActionExchange();

            // Principal es igual
            Exc.Param.Principal.Merge(req.Param.Principal);
            Exc.Param.Principal[0].Delete();
            // Impuestos es Igual
            Exc.Param.grdImpuestos.Merge(req.Param.Impuestos);
            // Cuotas es Igual 
            Exc.Param.grdCuotas.Merge(req.Param.Cuotas);
            // Atributos Generales es Igual
            Exc.Param.genAtributosGenerales.Merge(req.Param.genAtributosGenerales);
            // Cuerpo es Distinto
            foreach (var ren in req.Param.Cuerpo)
            {
                Exc.Param.grdCuerpo.AddgrdCuerpoRow(0, ren.Renglon, ren.RenglonReferencia,
                        DateTime.Now, "", "", ren.Producto_Id, ren.DescripcionProductos,
                        ren.Medida_Id, ren.DescripcionUniMed, ren.Factor,
                        ren.Cantidad, ren.CantidadForm, ren.CostoUnitario,
                        ren.PrecioOriginal, "", "", 0, "",
                        0, 0, "", "", "", "", "", "", "", 0, 0, "", "", "", "", "", "", "", 0, "");

            }

            foreach (var ren in req.Param.Gastos)
            {
                Exc.Param.grdCuerpo.AddgrdCuerpoRow(0, ren.Renglon, 0,
                    DateTime.Now, "", "", "", ren.Detalle,
                    "", "", 1,
                    1, 1, ren.Monto,
                    ren.Monto, "", "", 0, "",
                    0, 0, "", "", "", "", "", "", "", 0, 0, "", "", "", "", "", "", "", 0, "");


            }

            Exc.Param.AcceptChanges();
            return (Exc);

        }

        public static ComprasExchange.comFacturasConOrdenDeEmbarqueActionExchange FromExcConStock(ComprasExchange.comMovProvDatosConStockActionExchange req,
               ComprasExchange.comFacturasConOrdenDeEmbarqueActionExchange Exc)
        {


            // Principal es igual
            Exc.Param.Principal.Merge(req.Param.Principal);
            Exc.Param.Principal[0].Delete();
            // Impuestos es Igual
            Exc.Param.Impuestos.Clear();
            Exc.Param.Impuestos.Merge(req.Param.grdImpuestos);
            // Cuotas es Igual 
            Exc.Param.Cuotas.Clear();
            Exc.Param.Cuotas.Merge(req.Param.grdCuotas);
            // Atributos Generales es Igual
            Exc.Param.genAtributosGenerales.Clear();
            Exc.Param.genAtributosGenerales.Merge(req.Param.genAtributosGenerales);

            // Cuerpo es Distinto pero me quedo con el que vino

            Exc.Param.AcceptChanges();
            return (Exc);

        }
    }
}
