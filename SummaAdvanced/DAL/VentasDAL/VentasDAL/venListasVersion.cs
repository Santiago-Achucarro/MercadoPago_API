using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venListasVersion
    {
        public static venListasVersionDS Datos(string /*0*/pListaPrecio_Id, int /*1*/pVersion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pVersion };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venListasVersionDatos", parametros);

            venListasVersionDS dsTipado = new venListasVersionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pListaPrecio_Id, int /*1*/pVersion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, new Generalidades.NullableInt(/*1*/pVersion) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venListasVersionEliminar", parametros);
        }

        public static void Guardar(string /*0*/pListaPrecio_Id, int /*1*/pVersion, DateTime /*2*/pVigenciaDesde, DateTime /*3*/pVigenciaHasta, int /*4*/pUsuario_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pVersion, /*2*/pVigenciaDesde, /*3*/pVigenciaHasta, /*4*/pUsuario_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venListasVersionGuardar", parametros);
        }




    }
}
