using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;
namespace ProduccionDAL
{
    public class proMovCierreTrabajos3
    {
        public static proMovCierreTrabajos3DS Datos(long /*0*/pproMovCierreOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proMovCierreTrabajos3Datos", parametros);

            proMovCierreTrabajos3DS dsTipado = new proMovCierreTrabajos3DS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pproMovCierreOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proMovCierreTrabajos3Eliminar", parametros);
        }

        public static void Insertar(long /*0*/pproMovCierreOrden, int /*1*/pRenglon, string /*2*/pTrabajo3_Id, decimal /*3*/pCantidad, string /*4*/pMoneda_Id, string /*5*/pProveed_Id, decimal /*6*/pPrecio, decimal /*7*/pPrecioOriginal, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pRenglon, /*2*/pTrabajo3_Id, /*3*/pCantidad, /*4*/pMoneda_Id, /*5*/pProveed_Id, /*6*/pPrecio, /*7*/pPrecioOriginal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proMovCierreTrabajos3Insertar", parametros);
        }






    }
}
