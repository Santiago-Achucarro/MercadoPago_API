using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venListasPrecBoniRec
    {
        public static venListasPrecBoniRecDS Datos(string /*0*/pListaPrecio_Id, short /*1*/pNroBonifRecargo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pNroBonifRecargo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venListasPrecBoniRecDatos", parametros);

            string[] camposTabla0 = { "CtaBonificacion", "DescripcionCtaBonif", "CtaRecargo", "DescripcionCtaRecargo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venListasPrecBoniRecDS dsTipado = new venListasPrecBoniRecDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pListaPrecio_id, short /*1*/pNroBonifRecargo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_id, new Generalidades.NullableShort(/*1*/pNroBonifRecargo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venListasPrecBoniRecEliminar", parametros);
        }

        public static void Guardar(int /*0*/pListaPrecio_Id, short /*1*/pNroBonifRecargo, string /*2*/pNombre, string /*3*/pFormula, bool /*4*/pUsaCtasProducto, string /*5*/pCtaBonificacion, string /*6*/pCtaRecargo, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pNroBonifRecargo, /*2*/pNombre, /*3*/pFormula, /*4*/pUsaCtasProducto, /*5*/pCtaBonificacion, /*6*/pCtaRecargo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venListasPrecBoniRecGuardar", parametros);
        }
    }
}
