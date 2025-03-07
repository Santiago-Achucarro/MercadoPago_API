using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class suePersTipoPago
    {
        public static suePersTipoPagoDS Datos(long /*0*/pLegajo, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePersTipoPagoDatos", parametros);

            string[] camposTabla0 = { "TipoPago_Id", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePersTipoPagoDS dsTipado = new suePersTipoPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableDate(/*1*/pFechaDesde) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePersTipoPagoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/pTipoPago_Id, int /*4*/pUsuario_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFechaDesde, /*2*/pFechaHasta, new Generalidades.NullableString(/*3*/pTipoPago_Id), new Generalidades.NullableInt(/*4*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePersTipoPagoGuardar", parametros);
        }

    }
}
