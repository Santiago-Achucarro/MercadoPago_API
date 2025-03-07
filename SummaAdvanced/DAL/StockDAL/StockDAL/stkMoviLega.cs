using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockDAL
{
    public class stkMoviLega
    {
        public static stkMoviLegaDS Datos(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkMoviLegaDatos", parametros);

            stkMoviLegaDS dsTipado = new stkMoviLegaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviLegaEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pLegajo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pLegajo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviLegaGuardar", parametros);
        }




    }
}
