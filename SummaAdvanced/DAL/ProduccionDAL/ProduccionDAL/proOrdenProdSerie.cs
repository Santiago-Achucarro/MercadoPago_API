using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proOrdenProdSerie
    {
        public static proOrdenProdSerieDS Datos(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenProdSerieDatos", parametros);

            proOrdenProdSerieDS dsTipado = new proOrdenProdSerieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenProdSerieEliminar", parametros);
        }


        public static void Guardar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/pSerie, decimal /*3*/pCantidad, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon, /*2*/pSerie, /*3*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenProdSerieGuardar", parametros);
        }



    }

}
