using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;


namespace ContabilidadDAL
{
    public class conInfDefCuentas
    {

        public static conInfDefCuentasDS Datos(string /*0*/pInforme_Id, int /*1*/pFila, string /*2*/pCuentaDesde, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, new Generalidades.NullableInt(/*1*/pFila), new Generalidades.NullableString(/*2*/pCuentaDesde) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conInfDefCuentasDatos", parametros);

            conInfDefCuentasDS dsTipado = new conInfDefCuentasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pInforme_Id, int /*1*/pFila, string /*2*/pCuentaDesde, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, /*1*/new Generalidades.NullableInt( pFila), new Generalidades.NullableString(/*2*/pCuentaDesde) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conInfDefCuentasEliminar", parametros);
        }

        public static void Guardar(int /*0*/pInforme_Id, int /*1*/pFila, string /*2*/pCuentaDesde, string /*3*/pCuentaHasta, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, /*1*/pFila, /*2*/pCuentaDesde, /*3*/pCuentaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conInfDefCuentasInsertar", parametros);
        }


    }
}
