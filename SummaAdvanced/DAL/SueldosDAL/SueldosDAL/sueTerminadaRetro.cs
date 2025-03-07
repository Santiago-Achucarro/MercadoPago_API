using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using SueldosCommon;


namespace SueldosDAL
{
    public class sueTerminadaRetro
    {


        public static sueTerminadaRetroDS Datos(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, int /*3*/pAnioRetro, int /*4*/pMesRetro, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id, /*3*/pAnioRetro, /*4*/pMesRetro };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueTerminadaRetroDatos", parametros);

            sueTerminadaRetroDS dsTipado = new sueTerminadaRetroDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, int /*3*/pAnioRetro, int /*4*/pMesRetro, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pLegajo), new Generalidades.NullableInt(/*2*/pConcepto_Id), new Generalidades.NullableInt(/*3*/pAnioRetro), new Generalidades.NullableInt(/*4*/pMesRetro) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTerminadaRetroEliminar", parametros);
        }

        public static void Guardar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, int /*3*/pAnioRetro, int /*4*/pMesRetro, decimal /*5*/pImporte, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id, /*3*/pAnioRetro, /*4*/pMesRetro, /*5*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueTerminadaRetroGuardar", parametros);
        }



    }
}
