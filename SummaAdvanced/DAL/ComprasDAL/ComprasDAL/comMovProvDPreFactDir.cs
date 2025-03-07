using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovProvDPreFactDir
    {

        public static comMovProvDPreFactDirDS Datos(long /*0*/pcomMovProv, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvDPreFactDirDatos", parametros);

            string[] camposTabla0 = { "stkMoviCabe", "RenglonStk" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovProvDPreFactDirDS dsTipado = new comMovProvDPreFactDirDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovProvDPreFactDirEliminar", parametros);
        }

        public static void Insertar(long /*0*/pcomMovProv, int /*1*/pRenglon, long /*2*/pstkMoviCabe, int /*3*/pRenglonStk, decimal /*4*/pCantidadOriginal, decimal /*5*/pCantidad, decimal /*6*/pDescuento, decimal /*7*/pMonto, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglon, /*2*/pstkMoviCabe, /*3*/pRenglonStk, /*4*/pCantidadOriginal, /*5*/pCantidad, /*6*/pDescuento, /*7*/pMonto };

            //Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvDPreFactDirInsertar", parametros);
        }


    }
}
