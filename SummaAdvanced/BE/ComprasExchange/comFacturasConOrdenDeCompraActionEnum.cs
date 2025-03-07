using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 17 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comFacturasConOrdenDeCompraActionEnum
        {            public enum EnumcomFacturasConOrdenDeCompraAction
            {
                Guardar,Datos, Eliminar,CalcularTotales, CalcularTotalImp, SubirXML, AsignarFecha, CalcularImpuesto, MarcarTodas,
                    AsignarCambio, Adjuntos
        }
        public static string GetAccioncomFacturasConOrdenDeCompraAction(comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.Guardar: lRetorno = "comFacturasConOrdenDeCompraGuardar"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.Datos: lRetorno = "comFacturasConOrdenDeCompraDevolverDatos"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.Eliminar: lRetorno = "comFacturasConOrdenDeCompraEliminar"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.CalcularTotales: lRetorno = "comFacturasConOrdenDeCompraCalcularTotales"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.CalcularTotalImp: lRetorno = "comFacturasConOrdenDeCompraCalcularTotalImp"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.SubirXML: lRetorno = "comFacturasConOrdenDeCompraSubirXML"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.AsignarFecha: lRetorno = "comFacturasConOrdenDeCompraAsignarFecha"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.CalcularImpuesto: lRetorno = "comFacturasConOrdenDeCompraCalcularImpuesto"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.MarcarTodas:lRetorno = "comFacturasConOrdenDeCompraMarcarTodas"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.AsignarCambio: lRetorno = "comFacturasConOrdenDeCompraAsignarCambio"; break;
                case comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.Adjuntos: lRetorno = "comFacturasConOrdenDeCompraAdjuntos"; break;

            }
            return lRetorno;
        }

        public static ComprasExchange.comMovProvDatosConStockActionExchange ToExcConStock(ComprasExchange.comFacturasConOrdenDeCompraActionExchange req)
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
                        ren.Cantidad, ren.CantidadForm,ren.CostoUnitario,
                        ren.PrecioOriginal, "", "", 0, "",
                        0, 0, "", "", "", "", "", "", "", 0, 0, "", "", "", "", "", "", "", 0, "");

            }
            
            Exc.Param.AcceptChanges();
            return (Exc);

        }

        public static ComprasExchange.comFacturasConOrdenDeCompraActionExchange FromExcConStock(ComprasExchange.comMovProvDatosConStockActionExchange req,
               ComprasExchange.comFacturasConOrdenDeCompraActionExchange Exc)
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
