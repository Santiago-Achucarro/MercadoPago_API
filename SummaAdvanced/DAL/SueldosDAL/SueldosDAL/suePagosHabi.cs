using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class suePagosHabi
    {
        public static suePagosHabiDS Datos(long /*0*/psueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePagosHabiDatos", parametros);

            string[] camposTabla0 = { "tesMovimientos", "FechaHabilitacion", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePagosHabiDS dsTipado = new suePagosHabiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/psueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePagosHabiEliminar", parametros);
        }

        public static void Guardar(long /*0*/psueLiquidacion, long /*1*/ptesMovimientos, DateTime /*2*/pFechaHabilitacion, decimal /*3*/pImporte, int /*4*/pUsuario_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/new Generalidades.NullableInt64(ptesMovimientos), /*2*/new Generalidades.NullableDate(pFechaHabilitacion), /*3*/pImporte, new Generalidades.NullableInt(/*4*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePagosHabiGuardar", parametros);
        }

        public static suePagosHabiPendDS PendDatos(int /*0*/Empresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePagosHabiPendDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Usuario_Id", "DescripcionUsuario", "Marca", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Marca", "tesMovimientos", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            suePagosHabiPendDS dsTipado = new suePagosHabiPendDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Liquidaciones.TableName, dsTipado.Empleados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void AsignarTesMovimientos(long /*0*/psueLiquidacion, long /*1*/pTesmMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion,  new Generalidades.NullableInt64(/*1*/pTesmMovimientos) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePagosHabiAsignarTesMovimientos", parametros);
        }



    }
}
