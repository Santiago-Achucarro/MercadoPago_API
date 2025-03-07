using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;
namespace ComprasDAL
{
    public class comListaNegraMX
    {
        public static comListaNegraMXDS Datos(string /*0*/pRFC, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRFC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comListaNegraMXDatos", parametros);

            comListaNegraMXDS dsTipado = new comListaNegraMXDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar( string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comListaNegraMXEliminar", parametros);
        }

        public static void Guardar(string /*0*/pRFC, string /*1*/pRazonSocial, string /*2*/pSituacion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRFC, /*1*/pRazonSocial, /*2*/pSituacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comListaNegraMXInsertar", parametros);
        }



    }
}
