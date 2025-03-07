using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCTLink
    {

        public static tesCTlinkDS Datos(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCTlinkDatos", parametros);

            string[] camposTabla0 = { "tesCheqTerceros", "numCheque" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCTlinkDS dsTipado = new tesCTlinkDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCTlinkEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/pEstado_Id, short /*3*/pSecuencia, int /*4*/ptesCheqTerceros, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon, /*2*/pEstado_Id, /*3*/pSecuencia, /*4*/ptesCheqTerceros };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCTlinkGuardar", parametros);
        }

        public static tesCTlinkDS DatosXSecuencia(int /*0*/ptesCheqTerceros, short /*1*/pSecuencia, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqTerceros, pSecuencia };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCTlinkDatosXSecuencia", parametros);

            string[] camposTabla0 = { "tesCheqTerceros", "numCheque" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCTlinkDS dsTipado = new tesCTlinkDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
