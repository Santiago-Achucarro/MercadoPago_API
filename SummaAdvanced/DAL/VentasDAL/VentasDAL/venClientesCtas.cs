using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venClientesCtas
    {
        public static venClientesCtasDS Datos(string /*0*/pCliente_Id, string /*1*/pMoneda_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venClientesCtasDatos", parametros);
            string[] camposTabla0 = { "CuentaDxVtas", "CtaFactAnticipo", "CtaAnticipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venClientesCtasDS dsTipado = new venClientesCtasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pCliente_Id, string /*1*/pMoneda_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, new Generalidades.NullableString(/*1*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venClientesCtasEliminar", parametros);
        }
        public static void Guardar(long /*0*/pCliente_Id, string /*1*/pMoneda_Id, string /*2*/pCuentaDxVtas, string /*3*/pCtaFactAnticipo, string /*4*/pCtaAnticipo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pMoneda_Id, 
                    /*2*/new Generalidades.NullableString(pCuentaDxVtas), /*3*/new Generalidades.NullableString(pCtaFactAnticipo), /*4*/ new Generalidades.NullableString(pCtaAnticipo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venClientesCtasGuardar", parametros);
        }






    }
}
