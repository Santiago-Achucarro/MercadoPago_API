using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAdjuntos
    {
        public static genAdjuntosDS Datos(string /*0*/pTabla_Id, long /*1*/pIdentity_Id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pIdentity_Id, /*2*/ pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAdjuntosDatos", parametros);

            string[] camposTabla0 = { "ArchivoBase64", "Estado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAdjuntosDS dsTipado = new genAdjuntosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);

        }


        public static void Eliminar(string /*0*/pTabla_Id, long /*1*/pIdentity_Id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pIdentity_Id, new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genAdjuntosEliminar", parametros);
        }


        public static void Guardar(string /*0*/pTabla_Id, long /*1*/pIdentity_Id, int /*1*/pRenglon,
                                    string /*3*/pGuid, string /*4*/pNombreArchivo, string /*5*/pExtension, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pIdentity_Id, /*2*/pRenglon, /*3*/pGuid, /*4*/pNombreArchivo, /*5*/pExtension };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genAdjuntosGuardar", parametros);
        }


    }
}
