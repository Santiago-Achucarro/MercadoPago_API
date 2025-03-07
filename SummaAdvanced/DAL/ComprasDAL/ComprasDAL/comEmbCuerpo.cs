using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comEmbCuerpo
    {
        public static comEmbCuerpoDS Datos(Int64 /*0*/pcomEmbarques, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, new Generalidades.NullableInt(/*1*/pcomOrdenComp), new Generalidades.NullableInt(/*2*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbCuerpoDatos", parametros);

            //string[] camposTabla0 = { "SegmentoStr" };
            //Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comEmbCuerpoDS dsTipado = new comEmbCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pcomEmbarques, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, new Generalidades.NullableInt(/*1*/pcomOrdenComp),
                new Generalidades.NullableInt(/*2*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEmbCuerpoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomEmbarques, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, 
            decimal /*3*/pCantidad, decimal /*4*/pCantidadOriginal, decimal /*5*/pCantidadRecibida, 
            decimal /*6*/pCantidadFacturada, decimal /*7*/pPrecioCalculadoOriginal, decimal /*8*/pPrecioCalculado,
            int /*9*/pRenglonDebe, int /*10*/pRenglonHaber, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pcomOrdenComp, /*2*/pRenglon_OC,
                /*3*/pCantidad, /*4*/pCantidadOriginal, /*5*/pCantidadRecibida, /*6*/pCantidadFacturada,
                /*7*/pPrecioCalculadoOriginal, /*8*/pPrecioCalculado, /*9*/pRenglonDebe, /*10*/pRenglonHaber };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbCuerpoGuardar", parametros);
        }

        public static void Recibir(long /*0*/pcomEmbarques, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, 
            decimal /*3*/pCantidad, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pcomOrdenComp, /*2*/pRenglon_OC, /*3*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbCuerpoRecibir", parametros);
        }

        public static void Facturar(long /*0*/pcomEmbarques, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, 
            decimal /*3*/pCantidad, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pcomOrdenComp, /*2*/pRenglon_OC, /*3*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbCuerpoFacturar", parametros);
        }
    }
}
