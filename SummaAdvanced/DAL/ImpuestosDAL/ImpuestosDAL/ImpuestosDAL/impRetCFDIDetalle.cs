using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impRetCFDIDetalle
    {
        public static impRetCFDIDetalleDS Datos(int /*0*/pimpRetencionesCFDI, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIDetalleDatos", parametros);

            impRetCFDIDetalleDS dsTipado = new impRetCFDIDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pimpRetencionesCFDI, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIDetalleEliminar", parametros);
        }


        public static void Guardar(int /*0*/pimpRetencionesCFDI, int /*1*/pRenglon, decimal /*2*/pBaseRet, string /*3*/pTipoImpuesto, decimal /*4*/pmontoRet, string /*5*/pTipoPagoRet, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pRenglon, /*2*/pBaseRet, /*3*/pTipoImpuesto, /*4*/pmontoRet, /*5*/pTipoPagoRet };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIDetalleGuardar", parametros);
        }


    }
}
