using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comFacturasVariasOCActionEnum
        {            public enum EnumcomFacturasVariasOCAction
            {
                Guardar,Datos,Eliminar,CalcularTotales,CalcularTotalImp,SubirXML,AsignarFecha,CalcularImpuesto,Adjuntos
        }
        public static string GetAccioncomFacturasVariasOCAction(comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.Guardar: lRetorno = "comFacturasVariasOCGuardar"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.Datos: lRetorno = "comFacturasVariasOCDevolverDatos"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.Eliminar: lRetorno = "comFacturasVariasOCEliminar"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.CalcularTotales: lRetorno = "comFacturasVariasOCCalcularTotales"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.CalcularTotalImp: lRetorno = "comFacturasVariasOCCalcularTotalImp"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.SubirXML: lRetorno = "comFacturasVariasOCSubirXML"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.AsignarFecha: lRetorno = "comFacturasVariasOCAsignarFecha"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.CalcularImpuesto: lRetorno = "comFacturasVariasOCCalcularImpuesto"; break;
                case comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.Adjuntos: lRetorno = "comFacturasVariasOCAdjuntos"; break;
            }
            return lRetorno;
        }


        public static ComprasExchange.comMovProvDatosConStockActionExchange ToExcConStock(ComprasExchange.comFacturasVariasOCActionExchange req)
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
            Exc.Param.DescuentoFin.Merge(req.Param.DescuentoFin);
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

            Exc.Param.AcceptChanges();
            return (Exc);

        }

        public static ComprasExchange.comFacturasVariasOCActionExchange FromExcConStock(ComprasExchange.comMovProvDatosConStockActionExchange req,
               ComprasExchange.comFacturasVariasOCActionExchange Exc)
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

            Exc.Param.DescuentoFin.Clear();
            Exc.Param.DescuentoFin.Merge(req.Param.DescuentoFin);

            // Cuerpo es Distinto pero me quedo con el que vino

            Exc.Param.AcceptChanges();
            return (Exc);

        }
    }
}
