using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comLibros
    {
        public static comLIbrosDS Datos(string /*0*/pLibro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLibro_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comLIbrosDatos", parametros);

            string[] camposTabla0 = { "PTodasLasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            comLIbrosDS dsTipado = new comLIbrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Columnas.TableName, dsTipado.Impuestos.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pLibro_Id, string /*2*/pLibro_Id_Nuevo, string /*3*/pDescripcion, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pEmpresa_Id), /*1*/pLibro_Id, /*2*/pLibro_Id_Nuevo, /*3*/pDescripcion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comLIbrosGuardar", parametros);
        }




        public static void Eliminar(string /*0*/pLibro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLibro_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comLIbrosEliminar", parametros);
        }







    }
}
