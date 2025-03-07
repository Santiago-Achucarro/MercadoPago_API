using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;
namespace VentasDAL
{
    public class venMovimientosCRExpMx
    {
        public static venMovimientosCRExpMxDS Datos(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosCRExpMxDatos", parametros);

            venMovimientosCRExpMxDS dsTipado = new venMovimientosCRExpMxDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pRenglonCuerpo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosCRExpMxEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, decimal /*2*/pCantidadAduana, string /*3*/pUnidadAduana, decimal /*4*/pValorUnitarioAduana, decimal /*5*/pValorDolares, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pCantidadAduana, /*3*/pUnidadAduana, /*4*/pValorUnitarioAduana, /*5*/pValorDolares };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosCRExpMxGuardar", parametros);
        }


    }
}
