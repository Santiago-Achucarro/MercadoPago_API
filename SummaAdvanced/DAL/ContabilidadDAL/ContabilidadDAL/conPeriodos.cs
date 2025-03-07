using ContabilidadCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContabilidadDAL
{
    public class conPeriodos
    {
        public static conPeriodosDS Datos(int pEmpresa_Id, short /*0*/pEjercicio, short /*1*/pPeriodo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, /*0*/pEjercicio, /*1*/pPeriodo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conPeriodosDatos", parametros);

            conPeriodosDS dsTipado = new conPeriodosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conPeriodosDS DatosFecha(int pEmpresa_Id, DateTime /*0*/pFecha, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, /*0*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conPeriodosDatosFecha", parametros);

            conPeriodosDS dsTipado = new conPeriodosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int pEmpresa_Id, short /*0*/pEjercicio, short /*1*/pPeriodo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, /*0*/pEjercicio, new Generalidades.NullableShort(/*1*/pPeriodo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conPeriodosEliminar", parametros);
        }

        public static void Guardar(int pEmpresa_Id, short /*0*/pEjercicio, short /*1*/pPeriodo, DateTime /*2*/pFecha_Desde, DateTime /*3*/pFecha_Hasta, string /*4*/pEstado, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, /*0*/pEjercicio, /*1*/pPeriodo, /*2*/pFecha_Desde, /*3*/pFecha_Hasta, /*4*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conPeriodosGuardar", parametros);
        }

        public static void CambiarEstado(int /*0*/pEmpresa_Id, short /*1*/pEjercicio, short /*2*/pPeriodo, string /*3*/pEstado, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pEjercicio, /*2*/pPeriodo, /*3*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conPeriodosCambiarEstado", parametros);
        }


    }
}
