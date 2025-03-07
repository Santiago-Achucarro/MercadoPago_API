using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;

namespace SueldosDAL
{
   public class sueArchivosTxt
    {
        public static sueArchivosTxtDS Datos(string /*0*/pArchivo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueArchivosTxtDatos", parametros);

            string[] camposTabla0 = { "Res1Archivo_Id", "Res1Descripcion", "Res2Archivo_Id", "Res2Descripcion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Formato" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            sueArchivosTxtDS dsTipado = new sueArchivosTxtDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pArchivo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueArchivosTxtEliminar", parametros);
        }

        public static int Guardar(string /*0*/pArchivo_Id, string /*1*/pDescripcion, string /*2*/pResumen1Archivo_Id, string /*3*/pPosicionResumen1, string /*4*/pResumen2Archivo_Id, string /*5*/pPosicionResumen2, int /*6*/pUsuario_Id, int /*7*/pEmpresa_Id, bool /*8*/pInactivo, bool /*9*/pPosteado, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id, /*1*/pDescripcion, new Generalidades.NullableString(/*2*/pResumen1Archivo_Id), /*3*/pPosicionResumen1, new Generalidades.NullableString(/*4*/pResumen2Archivo_Id), /*5*/pPosicionResumen2, /*6*/pUsuario_Id, new Generalidades.NullableInt(/*7*/pEmpresa_Id), /*8*/pInactivo, /*9*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueArchivosTxtGuardar", parametros);
        }





    }
}
