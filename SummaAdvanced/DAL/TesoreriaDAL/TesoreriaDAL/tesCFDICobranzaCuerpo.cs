using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCFDICobranzaCuerpo
    {
        public static TesCFDICobranzaCuerpoDS Datos(int /*0*/pTesCFDICobranza, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ new Generalidades.NullableInt64(pTesCFDICobranza), /*1*/new Generalidades.NullableInt64(ptesMovimientos) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("TesCFDICobranzaCuerpoDatos", parametros);

            TesCFDICobranzaCuerpoDS dsTipado = new TesCFDICobranzaCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pTesCFDICobranza, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesCFDICobranza, /*1*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("TesCFDICobranzaCuerpoEliminar", parametros);
        }


        public static void Guardar(int /*0*/pTesCFDICobranza, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesCFDICobranza, /*1*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("TesCFDICobranzaCuerpoGuardar", parametros);
        }




    }
}
