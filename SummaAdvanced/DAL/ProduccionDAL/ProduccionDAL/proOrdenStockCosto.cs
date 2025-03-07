using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using interfaceDAAB;
using ProduccionCommon;


namespace ProduccionDAL
{
    public class proOrdenStockCosto
    {

        public static proOrdenStockCostoDS Datos(long /*0*/pproMovCierreOrden, long /*1*/pstkMoviCabe, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pstkMoviCabe, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenStockCostoDatos", parametros);

            proOrdenStockCostoDS dsTipado = new proOrdenStockCostoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pproMovCierreOrden, long /*1*/pstkMoviCabe, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pstkMoviCabe, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenStockCostoEliminar", parametros);
        }

        public static void Insertar(long /*0*/pproMovCierreOrden, long /*1*/pstkMoviCabe, int /*2*/pRenglon, decimal /*3*/pPorcentajeCosto, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pstkMoviCabe, /*2*/pRenglon, /*3*/pPorcentajeCosto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenStockCostoInsertar", parametros);
        }



    }
}
