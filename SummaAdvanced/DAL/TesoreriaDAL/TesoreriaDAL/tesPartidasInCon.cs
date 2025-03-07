using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesPartidasInCon
    {
        public static tesPartidasInConDS Datos(string /*0*/pCartera_Id, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesPartidasInConDatos", parametros);

            string[] camposTabla0 = { "Cartera_Id", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Debe_Haber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesPartidasInConDS dsTipado = new tesPartidasInConDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pCartera_Id, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, int /*3*/pComprobante, int /*4*/pEmpresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pFechaDesde, /*2*/pFechaHasta, new Generalidades.NullableInt(/*3*/pComprobante), /*4*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesPartidasInConEliminar", parametros);
        }


        public static void Insertar(string /*0*/pCartera_Id, DateTime /*1*/pFecha, int /*2*/pComprobante, string /*3*/pDebeHaber, decimal /*4*/pImporte, int /*5*/pEmpresa_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pFecha, /*2*/pComprobante, /*3*/pDebeHaber, /*4*/pImporte, /*5*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesPartidasInConInsertar", parametros);
        }


    }
}
