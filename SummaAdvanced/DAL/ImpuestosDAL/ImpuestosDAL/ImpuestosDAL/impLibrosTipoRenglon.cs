using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
 public   class impLibrosTipoRenglon
    {

        public static impLibrosTiposRenglonDS Datos(string /*0*/pTipoRenglon, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impLibrosTiposRenglonDatos", parametros);

            impLibrosTiposRenglonDS dsTipado = new impLibrosTiposRenglonDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pTipoRenglon, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTipoRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impLibrosTiposRenglonEliminar", parametros);
        }



        public static void Guardar(string /*0*/pTipoRenglon, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoRenglon, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impLibrosTiposRenglonGuardar", parametros);
        }





    }
}
