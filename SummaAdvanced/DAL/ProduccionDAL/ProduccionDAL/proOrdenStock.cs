using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proOrdenStock
    {

        public static proOrdenStockDS Datos(long /*0*/pproMovCierreOrden, long /*1*/pstkMoviCabe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenStockDatos", parametros);

            proOrdenStockDS dsTipado = new proOrdenStockDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pproMovCierreOrden, long /*1*/pstkMoviCabe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenStockEliminar", parametros);
        }

        public static void Insertar(long /*0*/pproMovCierreOrden, long /*1*/pstkMoviCabe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenStockInsertar", parametros);
        }


    }
}
