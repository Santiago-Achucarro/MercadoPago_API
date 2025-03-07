using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conCuadro1Filas
    {
        public static conCuadro1FilasDS Datos(int /*0*/pCuadro1Fila_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuadro1Fila_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conCuadro1FilasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conCuadro1FilasDS dsTipado = new conCuadro1FilasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pCuadro1Fila_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pCuadro1Fila_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conCuadro1FilasEliminar", parametros);
        }

        public static int Guardar(int /*0*/pCuadro1Fila_Id, int /*1*/pCuadro1Fila_Id_Nuevo, string /*2*/pDescripcion, 
            int /*3*/pEmpresa_Id, bool /*4*/pInactivo, int /*5*/pUsuario_Id, bool /*6*/pPosteado, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuadro1Fila_Id, /*1*/pCuadro1Fila_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pInactivo, /*5*/pUsuario_Id, /*6*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("conCuadro1FilasGuardar", parametros));
        }
    }
}
