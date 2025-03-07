using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class suePagosHabiPorEmpleado
    {
        public static suePagosHabiPorEmpleadoDS Datos(long /*0*/psueLiquidacion, int /*1*/pSecuencia, int /*2*/pLegajo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pSecuencia), new Generalidades.NullableInt(/*2*/pLegajo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePagosHabiPorEmpleadoDatos", parametros);

            string[] camposTabla0 = { "Marca", "tesMovimientos", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePagosHabiPorEmpleadoDS dsTipado = new suePagosHabiPorEmpleadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/psueLiquidacion, int /*1*/pSecuencia, int /*2*/pLegajo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pSecuencia), new Generalidades.NullableInt(/*2*/pLegajo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePagosHabiPorEmpleadoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pSecuencia, int /*1*/pLegajo, long /*2*/psueLiquidacion, long /*3*/ptesMovimientos, DateTime /*4*/pFechaHabilitacion, decimal /*5*/pImporte, int /*6*/pUsuario_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSecuencia, /*1*/pLegajo, /*2*/psueLiquidacion, /*3*/new Generalidades.NullableInt64(ptesMovimientos), /*4*/new Generalidades.NullableDate(pFechaHabilitacion), /*5*/pImporte, new Generalidades.NullableInt(/*6*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePagosHabiPorEmpleadoGuardar", parametros);
        }

        public static suePagosHabiPorEmpleadoPendDS PendDatos(long /*0*/psueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePagosHabiPorEmpleadoPendDatos", parametros);

            string[] camposTabla1 = { "Marca", "Importe", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            suePagosHabiPorEmpleadoPendDS dsTipado = new suePagosHabiPorEmpleadoPendDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Empleados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

      



    }
}
