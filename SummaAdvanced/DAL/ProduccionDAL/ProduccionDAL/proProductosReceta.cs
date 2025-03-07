using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proProductosReceta
    {
        public static proProductosRecetaDS Datos(string /*0*/pProducto_Id, string /*1*/pReceta_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pProducto_Id), new Generalidades.NullableString(/*1*/pReceta_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProductosRecetaDatos", parametros);

            string[] camposTabla0 = { "Principal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proProductosRecetaDS dsTipado = new proProductosRecetaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/pReceta_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pReceta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proProductosRecetaEliminar", parametros);
        }

        public static void Guardar(string /*0*/pProducto_Id, string /*1*/pReceta_Id, bool /*2*/pPrincipal, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pReceta_Id, new Generalidades.NullableBool(/*2*/pPrincipal) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProductosRecetaGuardar", parametros);
        }


    }
}
