using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
  public class impFormulas
    {
        public static impFormulasDS Datos(string /*0*/pImpuesto_Id, short /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impFormulasDatos", parametros);

            impFormulasDS dsTipado = new impFormulasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pImpuesto_Id, short /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id, new Generalidades.NullableShort(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impFormulasEliminar", parametros);
        }




        public static void Guardar(string /*0*/pImpuesto_Id, short /*1*/pRenglon, string /*2*/pCuenta_Id, string /*3*/pDetalle, string /*4*/pDebeHaberAmbos, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id, /*1*/pRenglon, /*2*/pCuenta_Id, /*3*/pDetalle, /*4*/pDebeHaberAmbos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impFormulasGuardar", parametros);
        }








    }
}
