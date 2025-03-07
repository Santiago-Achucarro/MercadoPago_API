using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;
namespace VentasDAL
{
    public class venMovimientosFiscalINE
    {

        public static venMovimientosFiscalINEDS Datos(long /*0*/pvenMovimientos, string /*1*/pClaveIdentidad, decimal /*2*/pidContabilidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pClaveIdentidad, /*2*/pidContabilidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosFiscalINEDatos", parametros);

            string[] camposTabla0 = { "Ambito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientosFiscalINEDS dsTipado = new venMovimientosFiscalINEDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/pClaveIdentidad, decimal /*2*/pidContabilidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableString(/*1*/pClaveIdentidad), /*2*/pidContabilidad };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosFiscalINEEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, string /*1*/pClaveIdentidad, decimal /*2*/pidContabilidad, string /*3*/pAmbito, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pClaveIdentidad, /*2*/pidContabilidad, new Generalidades.NullableString(/*3*/pAmbito) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosFiscalINEGuardar", parametros);
        }



    }
}
