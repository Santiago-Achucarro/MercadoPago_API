using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockExchange;
using StockCommon;

namespace StockExchange
{
    public class stkMoviCuerpoWrapper
    {
        public static stkMoviCabeDatosSalidasRemitoActionExchange stkSalidasRemitoAgregarRenglon(
         stkMoviCabeDatosSalidasRemitoActionExchange exch, Int32 pRenglonReferencia,
         string pDeposito_Id, string pProducto_Id, string pMedida_Id,
         decimal pFactor, decimal pCantidadForm, decimal pPrecioOriginal, string pMedidaAlterna,
         decimal pCantidadAlternaForm, string pObservaciones, decimal pDescuento, string pCuentaDebe, string pCentro1Debe,
         string pCentro2Debe, string pCuentaHaber, string pCentro1Haber, string pCentro2Haber)
        {
            stkMoviCabeDatosSalidasRemitoDS.grdMoviCuerpoRow dr;
            dr = exch.Param.grdMoviCuerpo.NewgrdMoviCuerpoRow();

            dr.RenglonReferencia = pRenglonReferencia;
            dr.Deposito_Id = pDeposito_Id;
            dr.Producto_Id = pProducto_Id;
            dr.Medida_Id = pMedida_Id;
            dr.Factor = pFactor;
            dr.CantidadForm = pCantidadForm;
            dr.PrecioOriginal = pPrecioOriginal;
            dr.MedidaAlterna = pMedidaAlterna;
            dr.CantidadAlternaForm = pCantidadAlternaForm;
            dr.Observaciones = pObservaciones;
            dr.Descuento = pDescuento;
            dr.CuentaDebe = pCuentaDebe;
            dr.Centro1Debe = pCentro1Debe;
            dr.Centro2Debe = pCentro2Debe;
            dr.CuentaHaber = pCuentaHaber;
            dr.Centro1Haber = pCentro1Haber;
            dr.Centro2Haber = pCentro2Haber;

            dr.Renglon = 0;
            dr.Fecha = DateTime.Now;
            dr.DescripcionDepositos = "";
            dr.DescripcionProductos = "";
            dr.DescripcionUniMed = "";
            dr.Cantidad = 0;
            dr.CostoUnitario = 0;
            dr.DescripcionMedidaAlterna = "";
            dr.conRenglonDebe = 0;
            dr.DescripcionCuentaDebe = "";
            dr.DescripcionCentro1Debe = "";
            dr.DescripcionCentro2Debe = "";
            dr.ClaseDebe = "";
            dr.ImporteContableDebe = 0;
            dr.conRenglonHaber = 0;
            dr.DescripcionCuentaHaber = "";
            dr.DescripcionCentro1Haber = "";
            dr.DescripcionCentro2Haber = "";
            dr.ClaseHaber = "";
            dr.ImporteContableHaber = 0;


            exch.Param.grdMoviCuerpo.AddgrdMoviCuerpoRow(dr);

            return exch;

        }

        public static stkMoviCabeActionExchange stkMoviCabeAgregarRenglon(
            stkMoviCabeActionExchange exch, Int32 pRenglonReferencia,
            string pDeposito_Id, string pProducto_Id, string pMedida_Id,
            decimal pFactor, decimal pCantidadForm, decimal pPrecioOriginal, string pMedidaAlterna,
            decimal pCantidadAlternaForm, string pObservaciones, decimal pDescuento, string pCuentaDebe, string pCentro1Debe,
            string pCentro2Debe, string pCuentaHaber, string pCentro1Haber, string pCentro2Haber)
        {
            stkMoviCabeDS.grdCuerpoRow dr;
            dr = exch.Param.grdCuerpo.NewgrdCuerpoRow();

            dr.RenglonReferencia = pRenglonReferencia;
            dr.Deposito_Id = pDeposito_Id;
            dr.Producto_Id = pProducto_Id;
            dr.Medida_Id = pMedida_Id;
            dr.Factor = pFactor;
            dr.CantidadForm = pCantidadForm;
            dr.PrecioOriginal = pPrecioOriginal;
            dr.MedidaAlterna = pMedidaAlterna;
            dr.CantidadAlternaForm = pCantidadAlternaForm;
            dr.Observaciones = pObservaciones;
            dr.Descuento = pDescuento;
            dr.CuentaDebe = pCuentaDebe;
            dr.Centro1Debe = pCentro1Debe;
            dr.Centro2Debe = pCentro2Debe;
            dr.CuentaHaber = pCuentaHaber;
            dr.Centro1Haber = pCentro1Haber;
            dr.Centro2Haber = pCentro2Haber;

            dr.Renglon = 0;
            dr.Fecha = DateTime.Now;
            dr.DescripcionDepositos = "";
            dr.DescripcionProductos = "";
            dr.DescripcionUniMed = "";
            dr.Cantidad = 0;
            dr.CostoUnitario = 0;
            dr.DescripcionMedidaAlterna = "";
            dr.conRenglonDebe = 0;
            dr.DescripcionCuentaDebe = "";
            dr.DescripcionCentro1Debe = "";
            dr.DescripcionCentro2Debe = "";
            dr.ClaseDebe = "";
            dr.ImporteContableDebe = 0;
            dr.conRenglonHaber = 0;
            dr.DescripcionCuentaHaber = "";
            dr.DescripcionCentro1Haber = "";
            dr.DescripcionCentro2Haber = "";
            dr.ClaseHaber = "";
            dr.ImporteContableHaber = 0;


            exch.Param.grdCuerpo.AddgrdCuerpoRow(dr);

            return exch;

        }
    }
}
