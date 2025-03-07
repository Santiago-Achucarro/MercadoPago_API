using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proRecetas
    {
        public static proRecetasDS Datos(string /*0*/pReceta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proRecetasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "CtroProd_Id", "descripcionCentroProd", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDeposito", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Recurso_Id", "DescripcionRecurso" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            proRecetasDS dsTipado = new proRecetasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Productos.TableName, dsTipado.Recursos.TableName, dsTipado.Trabajo3.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pReceta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pReceta_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proRecetasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pReceta_Id, string /*1*/pReceta_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pCtroProd_Id, decimal /*5*/pTamBatch, bool /*6*/pAgrupa, bool /*7*/pCorte, bool /*8*/pInactivo, bool /*9*/pPosteado, int /*10*/pUsuario_Id, DateTime /*11*/pFechaModificacion, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, /*1*/pReceta_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pCtroProd_Id), /*5*/pTamBatch, /*6*/pAgrupa, /*7*/pCorte, /*8*/pInactivo, /*9*/pPosteado, new Generalidades.NullableInt(/*10*/pUsuario_Id), /*11*/pFechaModificacion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("proRecetasGuardar", parametros));
        }

        public static void CambiarProducto(string /*0*/ProductoOriginal, string /*1*/ProductoNuevo, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ProductoOriginal, /*1*/ProductoNuevo, /*2*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proRecetasCambioProductoGuardar", parametros);
        }

    }
}
