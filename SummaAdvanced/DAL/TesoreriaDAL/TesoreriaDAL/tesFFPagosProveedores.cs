using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
namespace TesoreriaDAL
{
    public class tesFFPagosProveedores
    {
        public static tesFFPagosProvedoresDS Datos(long /*0*/ptesFlujoFondo, DateTime /*1*/pFecha, string /*2*/pProveed_Id, string /*3*/pMoneda_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesFlujoFondo, /*1*/pFecha, /*2*/pProveed_Id, /*3*/pMoneda_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesFFPagosProvedoresDatos", parametros);

            tesFFPagosProvedoresDS dsTipado = new tesFFPagosProvedoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/ptesFlujoFondo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesFlujoFondo, /*1*/pFechaDesde, /*2*/pFechaHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesFFPagosProvedoresEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesFlujoFondo, DateTime /*1*/pFecha, string /*2*/pProveed_Id, string /*3*/pMoneda_Id, decimal /*4*/pMonto, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesFlujoFondo, /*1*/pFecha, /*2*/pProveed_Id, /*3*/pMoneda_Id, /*4*/pMonto };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesFFPagosProvedoresGuardar", parametros);
        }






    }
}
