using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkMoviCuerpoReva
    {
        public static stkMoviCuerpoRevaDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCuerpoRevaDatos", parametros);

            string[] camposTabla0 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkMoviCuerpoRevaDS dsTipado = new stkMoviCuerpoRevaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviCuerpoRevaEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pProducto_Id, decimal /*3*/pPUC_Actual,
            decimal /*4*/pPUC_Anterior, decimal /*5*/pPPP_Actual, decimal /*6*/pPPP_Anterior, decimal /*7*/pSTD_Actual,
            decimal /*8*/pSTD_Anterior, decimal /*9*/pImporteAjuste, decimal /*10*/pImporteAjusteCosto, decimal /*11*/pCantidad, 
            string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pProducto_Id, /*3*/pPUC_Actual, /*4*/pPUC_Anterior,
                /*5*/pPPP_Actual, /*6*/pPPP_Anterior, /*7*/pSTD_Actual, /*8*/pSTD_Anterior, /*9*/pImporteAjuste,
                /*10*/pImporteAjusteCosto, /*11*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCuerpoRevaGuardar", parametros);
        }
    }
}
