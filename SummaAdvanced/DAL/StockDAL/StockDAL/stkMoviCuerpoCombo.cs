using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkMoviCuerpoCombo
    {

        public static stkMoviCuerpoComboDS Datos(long /*0*/pstkMoviCabeComponente, int /*1*/pRenglonComponente, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabeComponente, new Generalidades.NullableInt(/*1*/pRenglonComponente) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCuerpoComboDatos", parametros);

            string[] camposTabla0 = { "stkMoviCabe", "Renglon" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkMoviCuerpoComboDS dsTipado = new stkMoviCuerpoComboDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabeComponente, int /*1*/pRenglonComponente, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabeComponente, new Generalidades.NullableInt(/*1*/pRenglonComponente) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviCuerpoComboEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabeComponente, int /*1*/pRenglonComponente, long /*2*/pstkMoviCabe, int /*3*/pRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabeComponente, /*1*/pRenglonComponente, /*2*/pstkMoviCabe, /*3*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCuerpoComboGuardar", parametros);
        }


        public static stkMoviCuerpoComboDS OrigenDatos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCuerpoOrigenDatos", parametros);

            string[] camposTabla0 = { "stkMoviCabe", "Renglon" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkMoviCuerpoComboDS dsTipado = new stkMoviCuerpoComboDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
