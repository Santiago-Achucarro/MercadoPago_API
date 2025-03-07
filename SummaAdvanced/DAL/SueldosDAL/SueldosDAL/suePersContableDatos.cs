using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
   public  class suePersContableDatos
    {
        public static suePersContableDatosDS Datos(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo,  /*1*/pFechaDesde };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePersContableDatosDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePersContableDatosDS dsTipado = new suePersContableDatosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableDate( /*1*/pFechaDesde) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePersContableDatosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, string /*2*/pCuenta_Id, string /*3*/pCentro1_Id, string /*4*/pCentro2_Id, decimal /*5*/pPorcentaje, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFechaDesde, /*2*/pCuenta_Id, /*3*/pCentro1_Id, /*4*/pCentro2_Id, /*5*/pPorcentaje };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePersContableDatosGuardar", parametros);
        }

    }
}
