using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;

namespace SueldosDAL
{
    public class sueMovCont
    {

        public static sueMovContDS Datos(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, string /*3*/pCuenta_Id, string /*4*/pCentro1_Id, string /*5*/pCentro2_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pLegajo), new Generalidades.NullableInt(/*2*/pConcepto_Id), new Generalidades.NullableString(/*3*/pCuenta_Id), new Generalidades.NullableString(/*4*/pCentro1_Id), new Generalidades.NullableString(/*5*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueMovContDatos", parametros);

            sueMovContDS dsTipado = new sueMovContDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, string /*3*/pCuenta_Id, string /*4*/pCentro1_Id, string /*5*/pCentro2_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, new Generalidades.NullableInt(/*1*/pLegajo), new Generalidades.NullableInt(/*2*/pConcepto_Id), new Generalidades.NullableString(/*3*/pCuenta_Id), new Generalidades.NullableString(/*4*/pCentro1_Id), new Generalidades.NullableString(/*5*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueMovContEliminar", parametros);
        }

        public static void Guardar(long /*0*/psueLiquidacion, int /*1*/pLegajo, int /*2*/pConcepto_Id, string /*3*/pCuenta_Id, string /*4*/pCentro1_Id, string /*5*/pCentro2_Id, decimal /*6*/pImporte, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pLegajo, /*2*/pConcepto_Id, /*3*/pCuenta_Id, /*4*/pCentro1_Id, /*5*/pCentro2_Id, /*6*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueMovContGuardar", parametros);
        }


    }
}
