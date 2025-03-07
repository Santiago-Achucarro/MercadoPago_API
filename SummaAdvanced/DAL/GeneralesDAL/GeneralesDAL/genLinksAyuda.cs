using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GeneralesCommon;
using interfaceDAAB;

namespace GeneralesDAL
{
    public class genLinksAyuda
    {
        public static genLinksAyudaDS Datos(string /*0*/pCodigoLnk, string /*1*/pDominio_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCodigoLnk, /*1*/pDominio_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genLinksAyudaDatos", parametros);

            genLinksAyudaDS dsTipado = new genLinksAyudaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCodigoLnk, string /*1*/pDominio_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCodigoLnk), new Generalidades.NullableString(/*1*/pDominio_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genLinksAyudaEliminar", parametros);
        }

        public static void Guardar(string /*0*/pCodigoLnk, string /*1*/pDominio_Id, string /*2*/pDescripcion, string /*3*/pLink, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCodigoLnk, /*1*/pDominio_Id, /*2*/pDescripcion, /*3*/pLink };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genLinksAyudaGuardar", parametros);
        }



        public static genLinksAyudaTodosDS DatosTodos(string /*1*/ pAuxiliar)
        {

            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genLinksAyudaDatosTodos", parametros);

            genLinksAyudaTodosDS dsTipado = new genLinksAyudaTodosDS();

            dsTipado.LinksAyuda.Merge(ds.Tables[0]);
            return (dsTipado);
        }

    }
}
