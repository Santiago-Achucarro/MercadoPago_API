using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comRIMemo
    {
        public static comRIMemoDS Datos(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, new Generalidades.NullableInt(/*1*/pRenglon_RI) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comRIMemoDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "SubCategoria_Id", "DescripcionSubCategorias", "Detalle", "Categoria_Id", "DescripcionCategoria" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comRIMemoDS dsTipado = new comRIMemoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, new Generalidades.NullableInt(/*1*/pRenglon_RI) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comRIMemoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/pSubCategoria_Id, string /*3*/pDetalle, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pRenglon_RI, new Generalidades.NullableString(/*2*/pSubCategoria_Id), new Generalidades.NullableString(/*3*/pDetalle) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRIMemoGuardar", parametros);
        }

    }
}
