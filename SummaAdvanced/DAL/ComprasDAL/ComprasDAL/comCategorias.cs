using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comCategorias
    {
        public static comCategoriasDS Datos(string /*0*/pCategoria_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comCategoriasDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas", "Usuario_Id", "DescripcionUsuario", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comCategoriasDS dsTipado = new comCategoriasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.SubCategorias.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCategoria_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCategoria_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comCategoriasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCategoria_Id, string /*1*/pCategoria_Id_Nuevo, string /*2*/pDescripcion, string /*3*/pCuenta_Id, bool /*4*/pInactivo, bool /*5*/pPosteado, int /*6*/pUsuario_Id, int /*7*/pEmpresa_Id, bool /*8*/pPTodasEmpresas, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, /*1*/pCategoria_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableString(/*3*/pCuenta_Id), /*4*/pInactivo, /*5*/pPosteado, new Generalidades.NullableInt(/*6*/pUsuario_Id), new Generalidades.NullableInt(/*7*/pEmpresa_Id), /*8*/pPTodasEmpresas };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comCategoriasGuardar", parametros);
        }

    }
}
