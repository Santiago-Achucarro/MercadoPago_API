using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkSerieVencimiento
    {
        public static stkSerieVencimientoDS Datos(string /*0*/pProducto_Id, string /*1*/pSerie, int /*2*/pEmpresa_Id, 
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pSerie, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkSerieVencimientoDatos", parametros);

            stkSerieVencimientoDS dsTipado = new stkSerieVencimientoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/pSerie, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pSerie, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkSerieVencimientoEliminar", parametros);
        }

        public static void Guardar(string /*0*/pProducto_Id, string /*1*/pSerie, DateTime /*2*/pVencimiento, 
            int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pSerie, /*2*/pVencimiento, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkSerieVencimientoGuardar", parametros);
        }
    }
}
