using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesT3PromocionesCuotas
    {
        public static void Eliminar(int /*0*/pPromocion_Id, int /*1*/pCuota, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPromocion_Id, new Generalidades.NullableInt(/*1*/pCuota) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesT3PromocionesCuotasEliminar", parametros);
        }

        public static void Guardar(int /*0*/ptesT3Promociones, int /*1*/pCuota, decimal /*2*/pCoeficiente, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesT3Promociones, /*1*/pCuota, /*2*/pCoeficiente };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesT3PromocionesCuotasGuardar", parametros);
        }

        public static tesT3PromocionesCuotasDS CalcularCuotas(int /*0*/pPromocion_Id, decimal /*1*/pTotal, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPromocion_Id, /*1*/pTotal };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesT3PromocionesCuotasCalcularCuotas", parametros);

            string[] camposTabla0 = { "ValorCuota", "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesT3PromocionesCuotasDS dsTipado = new tesT3PromocionesCuotasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
