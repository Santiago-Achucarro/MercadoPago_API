using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;

namespace SueldosDAL
{
    public class sueDatoRetro
    {
        public static void Guardar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, short /*3*/pAnioRetro, short /*4*/pMesRetro, decimal /*5*/pDato, decimal /*6*/pDato2, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id, /*3*/pAnioRetro, /*4*/pMesRetro, /*5*/pDato, /*6*/pDato2 };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueDatoRetroGuardar", parametros);
        }

        public static void Eliminar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, short /*3*/pAnioRetro, short /*4*/pMesRetro, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id, new Generalidades.NullableShort(/*3*/pAnioRetro), new Generalidades.NullableShort(/*4*/pMesRetro) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueDatoRetroEliminar", parametros);
        }

        public static sueDatoRetroDS Datos(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueDatoRetroDatos", parametros);

            sueDatoRetroDS dsTipado = new sueDatoRetroDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
