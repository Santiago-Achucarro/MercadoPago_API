using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueTerminada
    {
        public static sueTerminadaDS Datos(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pLegajo), new Generalidades.NullableInt(/*2*/pConcepto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueTerminadaDatos", parametros);

            sueTerminadaDS dsTipado = new sueTerminadaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pLegajo), new Generalidades.NullableInt(/*2*/pConcepto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTerminadaEliminar", parametros);
        }

        public static void Guardar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, decimal /*3*/pDato, decimal /*4*/pDato2, decimal /*5*/pImporte, short /*6*/pSigno, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id, /*3*/pDato, /*4*/pDato2, /*5*/pImporte, /*6*/pSigno };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueTerminadaGuardar", parametros);
        }


    }
}
