using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TatianaCommon;

namespace TatianaDAL
{
    public class espProductosTalleColor
    {
        public static espProductosColorTalleTestDS Datos(string /*0*/pProducto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("espProductosColorTalleTestDatos", parametros);

            espProductosColorTalleTestDS dsTipado = new espProductosColorTalleTestDS();
            string[] nombreTablas = { dsTipado.TalleColor.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("espProductosColorTalleTestEliminar", parametros);
        }
        public static void Guardar(string /*0*/pProducto_Id, string /*1*/pColor_Id, string /*2*/pTalle_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pColor_Id, /*2*/pTalle_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("espProductosColorTalleTestGuardar", parametros);
        }




    }
}
