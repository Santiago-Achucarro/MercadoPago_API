using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;


namespace VentasDAL
{
    public class venEsquemaAutoReng
    {
        public static venEsquemaAutoRengDS Datos(string /*0*/pEsquemaAuto_Id, int /*1*/pOrden, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id, new Generalidades.NullableInt(/*1*/pOrden) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venEsquemaAutoRengDatos", parametros);

            string[] camposTabla0 = { "NivelAuto_Id", "DescripcioncomNivelesAuto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venEsquemaAutoRengDS dsTipado = new venEsquemaAutoRengDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pEsquemaAuto_Id, int /*1*/pOrden, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id, new Generalidades.NullableInt(/*1*/pOrden) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venEsquemaAutoRengEliminar", parametros);
        }
        public static void Guardar(string /*0*/pEsquemaAuto_Id, int /*1*/pOrden, string /*2*/pNivelAuto_Id, string /*3*/pFormula, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEsquemaAuto_Id, /*1*/pOrden, /*2*/pNivelAuto_Id, /*3*/pFormula };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venEsquemaAutoRengGuardar", parametros);
        }





    }
}
