using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using interfaceDAAB;
using System.Data;

namespace StockDAL
{
    public class stkMoviCRevaluo
    {
        public static stkMoviCRevaluoDS Datos(long /*0*/pstkMoviCabeReva, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabeReva };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCRevaluoDatos", parametros);

            stkMoviCRevaluoDS dsTipado = new stkMoviCRevaluoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabeReva, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabeReva };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviCRevaluoEliminar", parametros);
        }
        public static void Insertar(long /*0*/pstkMoviCabeReva, long /*1*/pAsiento_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabeReva, /*1*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCRevaluoInsertar", parametros);
        }


        public static stkMoviCRevaluoDS DatosCabe(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCRevaluoDatosCabe", parametros);

            stkMoviCRevaluoDS dsTipado = new stkMoviCRevaluoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }

}
