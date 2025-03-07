using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovpAnexoCont
    {
        public static comMovpAnexoContDS Datos(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovpAnexoContDatos", parametros);

            comMovpAnexoContDS dsTipado = new comMovpAnexoContDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovpAnexoContEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, int /*1*/pconRenglon, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pconRenglon, /*2*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovpAnexoContGuardar", parametros);
        }


    }
}
