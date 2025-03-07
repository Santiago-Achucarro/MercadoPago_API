using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comOrigenesFiscales
    {
        public static comOrigenesFiscalesDS Datos(short /*0*/pOrigen_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrigen_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrigenesFiscalesDatos", parametros);

            string[] camposTabla0 = { "Dominio_Id", "DescripcionDominios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comOrigenesFiscalesDS dsTipado = new comOrigenesFiscalesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(short /*0*/pOrigen_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableShort(/*0*/pOrigen_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOrigenesFiscalesEliminar", parametros);
        }



        public static int Guardar(short /*0*/pOrigen_Id, short /*1*/pOrigen_Id_Nuevo, string /*2*/pDescripcion, 
            string /*3*/pDominio_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrigen_Id, /*1*/pOrigen_Id_Nuevo, /*2*/pDescripcion,
                new Generalidades.NullableString(/*3*/pDominio_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comOrigenesFiscalesGuardar", parametros);
        }





    }
}
