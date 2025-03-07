using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TestCommon;

namespace TestDal
{
    public class espvenCondFiscImpTest
    {
        public static espvenCondFiscImpTestDS Datos(int /*0*/pvenCondFiscal, string /*1*/pvenImpuestos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCondFiscal, new Generalidades.NullableString(/*1*/pvenImpuestos) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("espvenCondFiscImpTestDatos", parametros);

            espvenCondFiscImpTestDS dsTipado = new espvenCondFiscImpTestDS();
            string[] nombreTablas = { dsTipado.grdImpuestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Guardar(int /*0*/pvenCondFiscal, string /*1*/pvenImpuestos, string /*2*/pObservacion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCondFiscal, /*1*/pvenImpuestos, /*2*/pObservacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("espvenCondFiscImpTestGuardar", parametros);
        }

        public static void Eliminar(int /*0*/pvenCondFiscal, string /*1*/pvenImpuestos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCondFiscal, new Generalidades.NullableString(/*1*/pvenImpuestos) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("espvenCondFiscImpTestEliminar", parametros);
        }


    }
}
