using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesBPlink
    {
        public static tesBPlinkDS Datos(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesBPlinkDatos", parametros);

            tesBPlinkDS dsTipado = new tesBPlinkDS();
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

            oiDAAB.eliminar("tesBPlinkEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/pEstado_Id, short /*3*/pSecuencia, int /*4*/ptesCheqProp, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon, /*2*/pEstado_Id, /*3*/pSecuencia, /*4*/ptesCheqProp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesBPlinkGuardar", parametros);
        }


        public static tesBPlinkDS DatosXSecuencia(int pEmpresa_Id, string pCartera_Id, int pChequera_Id, int pnumCheque,
            short pSecuencia, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, pCartera_Id, pChequera_Id, pnumCheque, pSecuencia };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesBPlinkDatosXSecuencia", parametros);

            tesBPlinkDS dsTipado = new tesBPlinkDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
