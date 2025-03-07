using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public  class comCFDISatPago
    {
        public static comCFDISatPagoDS Datos(string /*0*/pUUID, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUUID, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comCFDISatPagoDatos", parametros);

            comCFDISatPagoDS dsTipado = new comCFDISatPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pUUID, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUUID, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comCFDISatPagoEliminar", parametros);
        }

        public static void Guardar(string /*0*/pUUID, int /*1*/pRenglon, string /*2*/pUUIDR, decimal /*3*/pMonto, string /*4*/pMoneda, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUUID, /*1*/pRenglon, /*2*/pUUIDR, /*3*/pMonto, /*4*/pMoneda };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comCFDISatPagoGuardar", parametros);
        }


    }
}
