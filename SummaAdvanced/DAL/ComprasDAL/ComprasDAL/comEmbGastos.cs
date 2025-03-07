using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comEmbGastos
    {
        public static comEmbGastosDS Datos(Int64 /*0*/pcomEmbarques, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbGastosDatos", parametros);

            comEmbGastosDS dsTipado = new comEmbGastosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(Int64 /*0*/pcomEmbarques, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEmbGastosEliminar", parametros);
        }

        public static void Guardar(Int64 /*0*/pcomEmbarques, int /*1*/pRenglon, string /*2*/pDetalle, 
            decimal /*3*/pImporteOriginal, decimal /*4*/pImporte, string /*5*/pMoneda_Id, string /*6*/pCantidadImporte,
            string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pRenglon, /*2*/pDetalle, /*3*/pImporteOriginal,
                /*4*/pImporte, /*5*/pMoneda_Id, /*6*/pCantidadImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbGastosGuardar", parametros);
        }
    }
}
