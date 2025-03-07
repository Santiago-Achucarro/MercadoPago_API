using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ComprasCommon;
using System.Data;
namespace ComprasDAL
{
    public class comRemiPendFact
    {

        public static comRemiPendFactDS Datos(long /*0*/pcomMovProv, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglonCuerpo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comRemiPendFactDatos", parametros);

            string[] camposTabla0 = { "stkMoviCabe", "Renglon" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comRemiPendFactDS dsTipado = new comRemiPendFactDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pRenglonCuerpo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comRemiPendFactEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pRenglonCuerpo, long /*2*/pstkMoviCabe, int /*3*/pRenglon, decimal /*4*/pCantidadFacturado, decimal /*5*/pPrecioFacturado, decimal /*6*/pCantidadOriginalFact, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglonCuerpo, /*2*/pstkMoviCabe, new Generalidades.NullableInt(/*3*/pRenglon), /*4*/pCantidadFacturado, /*5*/pPrecioFacturado, /*6*/pCantidadOriginalFact };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRemiPendFactGuardar", parametros);
        }


    }
}
