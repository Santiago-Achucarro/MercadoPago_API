using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCondPagoCuotas
    {
        public static VenCondPagoCuotasDS Datos(string /*0*/pCondPagoCli_id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPagoCli_id, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("VenCondPagoCuotasDatos", parametros);

            string[] camposTabla0 = { "Dias" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            VenCondPagoCuotasDS dsTipado = new VenCondPagoCuotasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pCondPagoCli_id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPagoCli_id, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("VenCondPagoCuotasEliminar", parametros);
        }
        public static void Guardar(int /*0*/pCondPagoCli_id, int /*1*/pRenglon, int /*2*/pDias, decimal /*3*/pPorcentaje, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPagoCli_id, /*1*/pRenglon, new Generalidades.NullableInt(/*2*/pDias), /*3*/pPorcentaje };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("VenCondPagoCuotasGuardar", parametros);
        }
    }
}
