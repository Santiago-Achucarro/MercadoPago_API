using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;


namespace SueldosDAL
{
    public class sueArchivosTxtCuerpo
    {
        public static sueArchivosTxtCuerpoDS Datos(string /*0*/pArchivo_Id, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id, /*1*/new Generalidades.NullableInt( pColumna) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueArchivosTxtCuerpoDatos", parametros);

            string[] camposTabla0 = { "Formato" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueArchivosTxtCuerpoDS dsTipado = new sueArchivosTxtCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pArchivo_Id, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id, new Generalidades.NullableInt(/*1*/pColumna) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueArchivosTxtCuerpoEliminar", parametros);
        }

        public static void Guardar(string /*0*/pArchivo_Id, int /*1*/pColumna, string /*2*/pFormula, string /*3*/pTipo, short /*4*/pLongitud, short /*5*/pDecimales, string /*6*/pRelleno, string /*7*/pDescripcion, short /*8*/pOrden, string /*9*/pFormato, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id, /*1*/pColumna, /*2*/pFormula, /*3*/pTipo, /*4*/pLongitud, /*5*/pDecimales, /*6*/pRelleno, /*7*/pDescripcion, /*8*/pOrden, new Generalidades.NullableString(/*9*/pFormato) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueArchivosTxtCuerpoGuardar", parametros);
        }


    }
}
