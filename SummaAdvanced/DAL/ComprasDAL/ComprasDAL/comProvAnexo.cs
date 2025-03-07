using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comProvAnexo
    {
        public static comProvAnexoDS Datos(string /*0*/pCuit, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuit };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProvAnexoDatos", parametros);

            string[] camposTabla0 = { "Provincia_Id", "DescripcionProvincias", "CondFiscal_Id", "DescripcionCondFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comProvAnexoDS dsTipado = new comProvAnexoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pgenEntidades, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProvAnexoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pgenEntidades, string /*1*/pRazonSocial, string /*2*/pDireccion1, string /*3*/pDireccion2, string /*4*/pLocalidad, string /*5*/pCod_Postal, string /*6*/pProvincia_Id, string /*7*/pCondFiscal_Id, int /*8*/pUsuario_Id, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pRazonSocial, /*2*/pDireccion1, /*3*/pDireccion2, /*4*/pLocalidad, /*5*/pCod_Postal, new Generalidades.NullableString(/*6*/pProvincia_Id), new Generalidades.NullableString(/*7*/pCondFiscal_Id), /*8*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProvAnexoGuardar", parametros);
        }





    }
}
