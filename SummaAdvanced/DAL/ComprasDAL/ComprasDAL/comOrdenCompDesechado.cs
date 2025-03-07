using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comOrdenCompDesechado
    {
        public static comOrdenCompDesechadoDS Datos(int /*0*/pcomOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompDesechadoDatos", parametros);

            comOrdenCompDesechadoDS dsTipado = new comOrdenCompDesechadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pcomOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOrdenCompDesechadoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pcomOrdenComp, int /*1*/pUsuario_Id, DateTime /*2*/pFecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pUsuario_Id, /*2*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOrdenCompDesechadoGuardar", parametros);
        }




    }
}
