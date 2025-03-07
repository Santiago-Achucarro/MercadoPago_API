using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comOCMovProv
    {
        public static comOcMovProvDS Datos(int /*0*/pcomOrdenComp, long /*1*/pcomMovProv, bool /*2*/pAnticipoNC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pcomMovProv, /*2*/pAnticipoNC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOcMovProvDatos", parametros);

            comOcMovProvDS dsTipado = new comOcMovProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pcomOrdenComp, long /*1*/pcomMovProv, bool /*2*/pAnticipoNC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pcomMovProv, new Generalidades.NullableBool(/*2*/pAnticipoNC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOcMovProvEliminar", parametros);
        }
        public static void Guardar(int /*0*/pcomOrdenComp, long /*1*/pcomMovProv, bool /*2*/pAnticipoNC, decimal /*3*/pImporte, decimal /*4*/pPorcentaje, bool /*5*/pDadoRestado, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pcomMovProv, /*2*/pAnticipoNC, /*3*/pImporte, /*4*/pPorcentaje, /*5*/pDadoRestado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOcMovProvGuardar", parametros);
        }
    }
}
