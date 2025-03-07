using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ComprasCommon;
using interfaceDAAB;

namespace ComprasDAL
{
    public class comMovProvEmb
    {
        public static comMovProvEmbDS Datos(long /*0*/pcomMovProv, long /*0*/pcomMovEmbarques, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt64(pcomMovEmbarques) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvEmbDatos", parametros);

            comMovProvEmbDS dsTipado = new comMovProvEmbDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomMovProv, long /*0*/pcomMovEmbarques, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt64(pcomMovEmbarques) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovProvEmbEliminar", parametros);
        }

        public static void Insertar(long /*0*/pcomEmbarques, long /*1*/pcomMovProv, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvEmbInsertar", parametros);
        }

        public static comMovProvEmbDatosFullDS DatosFull(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvEmbDatosFull", parametros);

            string[] camposTabla0 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovProvEmbDatosFullDS dsTipado = new comMovProvEmbDatosFullDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
