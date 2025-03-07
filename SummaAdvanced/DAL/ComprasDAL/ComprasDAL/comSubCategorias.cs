using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comSubCategorias
    {
        public static comSubCategoriasDS Datos(string /*0*/pSubCategoria_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubCategoria_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comSubCategoriasDatos", parametros);

            string[] camposTabla0 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comSubCategoriasDS dsTipado = new comSubCategoriasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCategoria_Id, string /*1*/pSubCategoria_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, new Generalidades.NullableString(/*1*/pSubCategoria_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comSubCategoriasEliminar", parametros);
        }

        public static void Guardar(string /*0*/pSubCategoria_Id, string /*1*/pSubCategoria_Id_Nuevo, string /*2*/pDescripcion, string /*3*/pCategoria_Id, string /*4*/pCentro1_Id, string /*5*/pCentro2_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubCategoria_Id, /*1*/pSubCategoria_Id_Nuevo, /*2*/pDescripcion, /*3*/pCategoria_Id, new Generalidades.NullableString(/*4*/pCentro1_Id), new Generalidades.NullableString(/*5*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comSubCategoriasGuardar", parametros);
        }


    }
}
