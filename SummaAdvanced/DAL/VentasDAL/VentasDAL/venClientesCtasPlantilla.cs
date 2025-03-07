using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venClientesCtasPlantilla
    {
        public static venClientesCtasPlantillaDS Datos(string /*0*/pPlantilla_Id, string /*1*/pMoneda_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id, /*1*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venClientesCtasPlantillaDatos", parametros);
            string[] camposTabla0 = { "CuentaDxVtas", "CtaFactAnticipo", "CtaAnticipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venClientesCtasPlantillaDS dsTipado = new venClientesCtasPlantillaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pPlantilla_Id, string /*1*/pMoneda_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id, new Generalidades.NullableString(/*1*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venClientesCtasPlantillaEliminar", parametros);
        }

        public static void Guardar(string /*0*/pPlantilla_Id, string /*1*/pMoneda_Id, string /*2*/pCuentaDxVtas, string /*3*/pCtaFactAnticipo,
            string /*4*/pCtaAnticipo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id, /*1*/pMoneda_Id, new Generalidades.NullableString(/*2*/pCuentaDxVtas),
                new Generalidades.NullableString(/*3*/pCtaFactAnticipo), new Generalidades.NullableString(/*4*/pCtaAnticipo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venClientesCtasPlantillaGuardar", parametros);
        }
    }
}
