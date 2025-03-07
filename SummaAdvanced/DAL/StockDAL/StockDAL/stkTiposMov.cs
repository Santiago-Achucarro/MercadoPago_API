using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkTiposMov
    {
        public static stkTiposMovDS Datos(string /*0*/pTipoMov, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoMov };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkTiposMovDatos", parametros);

            stkTiposMovDS dsTipado = new stkTiposMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipoMov, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoMov };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkTiposMovEliminar", parametros);
        }


        public static void Guardar(string /*0*/pTipoMov, string /*2*/pDescripcion, short /*3*/pSigno, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoMov,  /*1*/pDescripcion, /*2*/pSigno };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkTiposMovGuardar", parametros);
        }

    }
}
