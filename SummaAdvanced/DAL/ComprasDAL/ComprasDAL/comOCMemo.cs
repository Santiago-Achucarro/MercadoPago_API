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
    public class comOCMemo
    {
        public static comOCMemoDS Datos(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOCMemoDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOCMemoDS dsTipado = new comOCMemoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/ new Generalidades.NullableInt(pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOCMemoEliminar", parametros);
        }
        public static void Guardar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/pDetalle, string /*3*/pCuenta_Id, 
            string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pDetalle,
                new Generalidades.NullableString(/*3*/pCuenta_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCMemoGuardar", parametros);
        }
    }
}
