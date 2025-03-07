using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProduccionCommon;
using interfaceDAAB;
namespace ProduccionDAL
{
    public class proProgramaOrden
    {
        public static proProgramaOrdenDS Datos(int /*0*/pproProgramas, int /*1*/pRenglon, int /*2*/pproOrden, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pproProgramas), new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableInt(/*2*/pproOrden) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramaOrdenDatos", parametros);

            proProgramaOrdenDS dsTipado = new proProgramaOrdenDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pproProgramas, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proProgramaOrdenEliminar", parametros);
        }

        public static void Insertar(int /*0*/pproProgramas, int /*1*/pRenglon, int /*2*/pproOrden, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas, /*1*/pRenglon, /*2*/pproOrden };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProgramaOrdenInsertar", parametros);
        }




    }
}
