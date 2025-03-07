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
    public class comProveedoresTipoPasivo
    {
        public static comProveedoresTipoPasivoDS Datos(int /*0*/pTipoCtaProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoCtaProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProveedoresTipoPasivoDatos", parametros);

            comProveedoresTipoPasivoDS dsTipado = new comProveedoresTipoPasivoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pTipoCtaProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pTipoCtaProv) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProveedoresTipoPasivoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pTipoCtaProv, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoCtaProv, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProveedoresTipoPasivoGuardar", parametros);
        }




    }
}
