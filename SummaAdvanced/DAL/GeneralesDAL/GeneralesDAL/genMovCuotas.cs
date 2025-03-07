using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genMovCuotas
    {
        public static genMovCuotasDS Datos(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, new Generalidades.NullableShort(/*1*/pCuotaNro) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMovCuotasDatos", parametros);

            genMovCuotasDS dsTipado = new genMovCuotasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, new Generalidades.NullableShort(/*1*/pCuotaNro) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genMovCuotasEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, DateTime /*2*/pFechaVencimiento, decimal /*3*/pImporte, decimal /*4*/pSaldo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pCuotaNro, /*2*/pFechaVencimiento, /*3*/pImporte, /*4*/pSaldo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genMovCuotasGuardar", parametros);
        }

        public static void Aplicar(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, decimal /*2*/pImporte, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pCuotaNro, /*2*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genMovCuotasAplicar", parametros);
        }

    }
}
