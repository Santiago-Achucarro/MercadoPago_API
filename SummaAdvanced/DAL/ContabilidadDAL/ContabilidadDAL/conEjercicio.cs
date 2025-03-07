using ContabilidadCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContabilidadDAL
{
    public class conEjercicio
    {
        public static conEjercicioDS Datos(short /*0*/pEjercicio, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEjercicio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conEjercicioDatos", parametros);

            conEjercicioDS dsTipado = new conEjercicioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(short /*0*/pEjercicio, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableShort(/*0*/pEjercicio) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conEjercicioEliminar", parametros);
        }

        public static void Guardar(short /*0*/pEjercicio, DateTime /*1*/pFecha, int /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEjercicio, /*1*/pFecha, /*2*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conEjercicioGuardar", parametros);

        }

        public static conEjercicioPeriodoDS DatosPeriodo(short /*0*/pEjercicio, int /*1*/pEmpresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEjercicio, /*1*/pEmpresa };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("conEjercicioPeriodoDatos", parametros);

            string[] camposTabla0 = { "MesInicioEjercicio", "CantPeriodos", "Ejercicios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conEjercicioPeriodoDS dsTipado = new conEjercicioPeriodoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdPeriodos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conEjercicioPeriodoDS Ejercicios(int /*0*/pEmpresa, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("conEjercicioPeriodos", parametros);

            string[] camposTabla0 = { "MesInicioEjercicio", "CantPeriodos", "Ejercicios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conEjercicioPeriodoDS dsTipado = new conEjercicioPeriodoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdPeriodos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
