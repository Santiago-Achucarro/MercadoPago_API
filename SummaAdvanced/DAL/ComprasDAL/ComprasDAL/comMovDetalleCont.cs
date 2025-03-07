using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovDetalleCont
    {
        public static comMovDetalleContDS Datos(long /*0*/pcomMovProv, int /*1*/pRenglon, int /*2*/pconRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableInt(/*2*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovDetalleContDatos", parametros);

            comMovDetalleContDS dsTipado = new comMovDetalleContDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pRenglon, int /*2*/pconRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableInt(/*2*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovDetalleContEliminar", parametros);
        }

        public static void Insertar(long /*0*/pcomMovProv, int /*1*/pRenglon, int /*2*/pconRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglon, /*2*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovDetalleContInsertar", parametros);
        }






    }
}
