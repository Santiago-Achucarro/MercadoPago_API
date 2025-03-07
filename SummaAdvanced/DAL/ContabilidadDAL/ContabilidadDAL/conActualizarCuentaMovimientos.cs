using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conActualizarCuentaMovimientos
    {
        public static conActualizarCuentasMovimientosDS Datos(string /*0*/pCuentaARemplazar, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, int /*3*/pEmpresa_Id, string /*4*/pCuentaRemplazo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuentaARemplazar, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pEmpresa_Id, /*4*/pCuentaRemplazo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("conActualizarCuentasMovimientosDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Remplazo", "DescripcionCuenta_Remplazo", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "Centro1_Id", "DescripcionCentro1", "conCentro2", "DescripcionCentro2", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conActualizarCuentasMovimientosDS dsTipado = new conActualizarCuentasMovimientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Guardar(string /*0*/pCuentaARemplazar, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, int /*3*/pEmpresa_Id, string /*4*/pCuentaRemplazo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuentaARemplazar, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pEmpresa_Id, /*4*/pCuentaRemplazo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conActualizarCuentasMovimientosGuardar", parametros);
        }


    }
}
