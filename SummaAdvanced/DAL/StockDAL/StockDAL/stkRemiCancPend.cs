using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using StockCommon;
using interfaceDAAB;

namespace StockDAL
{
    public class stkRemiCancPend
    {
        public static void UsuarioElimina(long /*0*/pstkMoviCabe, int /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkEliminaRemiPendGuardar", parametros);
        }
        public static stkRemiCancPendDS DatosCancPend(DateTime /*0*/pFechaHasta, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkRemiCancPend", parametros);

            string[] camposTabla0 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkRemiCancPendDS dsTipado = new stkRemiCancPendDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
