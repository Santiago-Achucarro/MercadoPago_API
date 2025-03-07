using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesRengConcilEsp
    {
        public static tesRengConcilEspDS Datos(int /*0*/pEmpresa_Id, string /*1*/ptesIdentifica, int /*2*/pNumeroConc, long /*3*/ptesMovimientos, int /*4*/pconRenglon, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/ptesIdentifica, /*2*/pNumeroConc, /*3*/ptesMovimientos, /*4*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRengConcilEspDatos", parametros);

            tesRengConcilEspDS dsTipado = new tesRengConcilEspDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/ptesIdentifica, int /*2*/pNumeroConc, long /*3*/ptesMovimientos, int /*4*/pconRenglon, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/ptesIdentifica, /*2*/pNumeroConc, /*3*/ptesMovimientos, /*4*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesRengConcilEspEliminar", parametros);
        }
        public static void Guardar(int /*0*/pEmpresa_Id, string /*1*/ptesIdentifica, int /*2*/pNumeroConc, long /*3*/ptesMovimientos, int /*4*/pconRenglon, decimal /*5*/pImporte, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/ptesIdentifica, /*2*/pNumeroConc, /*3*/ptesMovimientos, /*4*/pconRenglon, /*5*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesRengConcilEspInsertar", parametros);
        }

        public static tesRengConcilEspMovDS DatosMov(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRengConcilEspMovDatos", parametros);

            tesRengConcilEspMovDS dsTipado = new tesRengConcilEspMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
