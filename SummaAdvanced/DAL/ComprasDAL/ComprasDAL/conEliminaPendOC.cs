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
    public class conEliminaPendOC
    {
        public static comEliminaPendOCDS Datos(int /*0*/pcomOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEliminaPendOCDatos", parametros);

            string[] camposTabla0 = { "Empresa_id", "FechaRegistro", "Moneda_id", "DescripcionMoneda", "Cambio", "CambioMonedaOriginal", "Anulado", "Observaciones", "Posteado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comEliminaPendOCDS dsTipado = new comEliminaPendOCDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Guardar(int /*0*/pcomOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEliminaPendOCDatos", parametros);
        }
        public static void Eliminar(int /*0*/pcomOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEliminaPendOCEliminar", parametros);
        }
      }
}
