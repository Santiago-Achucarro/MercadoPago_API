using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueCategorias
    {
        public static int Guardar(string /*0*/pCategoria_Id, string /*1*/pCategoria_Id_Nuevo, string /*2*/pDescripcion, string /*3*/pPeriodo_Id, bool /*4*/pInactivo, bool /*5*/pPosteado, int /*6*/pUsuario_Id, int /*7*/pEmpresa_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, /*1*/pCategoria_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableString(/*3*/pPeriodo_Id), /*4*/pInactivo, /*5*/pPosteado, new Generalidades.NullableInt(/*6*/pUsuario_Id), new Generalidades.NullableInt(/*7*/pEmpresa_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueCategoriasGuardar", parametros);
        }

        public static void Eliminar(string /*0*/pCategoria_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCategoria_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueCategoriasEliminar", parametros);
        }

        public static sueCategoriasDS Datos(string /*0*/pCategoria_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueCategoriasDatos", parametros);

            string[] camposTabla0 = { "Periodo_Id", "DescripcionPeriodicidad", "Usuario_Id", "Empresa_Id", "PTodasEmpresas", "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Categoria_Id", "DescripcionCategoria", "Fecha_Desde", "Usuario_Id", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            sueCategoriasDS dsTipado = new sueCategoriasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
