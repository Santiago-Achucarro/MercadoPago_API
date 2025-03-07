using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;
namespace ComprasDAL
{
    public class comEmbGastoMovProv
    {
        public static comEmbGastoMovProvDS Datos(long /*0*/pcomMovProv, int /*1*/pcomRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pcomRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbGastoMovProvDatos", parametros);

            comEmbGastoMovProvDS dsTipado = new comEmbGastoMovProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pcomRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pcomRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEmbGastoMovProvEliminar", parametros);
        }

        public static void Insertar(long /*0*/pcomMovProv, int /*1*/pcomRenglon, long /*2*/pcomEmbarques, int /*3*/pRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pcomRenglon, /*2*/pcomEmbarques, /*3*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbGastoMovProvInsertar", parametros);
        }



    }
}
