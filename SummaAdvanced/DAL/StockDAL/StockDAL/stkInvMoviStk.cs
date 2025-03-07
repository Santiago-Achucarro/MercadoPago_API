using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkInvMoviStk
    {
        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pstkInventarios, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pstkInventarios };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkInvMoviStkInsertar", parametros);
        }
        public static stkInvMoviStkDS Datos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkInvMoviStkDatos", parametros);

            string[] camposTabla1 = { "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkInvMoviStkDS dsTipado = new stkInvMoviStkDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static stkAFechaDS AFecha(int /*0*/pstkInventrios, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventrios };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkAFecha", parametros);

            string[] camposTabla2 = { "Serie", "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            stkAFechaDS dsTipado = new stkAFechaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Despachos.TableName, dsTipado.Series.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
