using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comTipoPermiRI
    {
        public static comTipoPermiRIDS Datos(string /*0*/pTipoPermiRI_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoPermiRI_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comTipoPermiRIDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "EsquemaAuto_Id", "DescripcionEsquemaAuto", "UsuarioAutoriz", "DescripcionUsuarioAutoriz", "Usuario_Id", "DescripcionUsuario", "Reporte_Id", "DescripcionReporte" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comTipoPermiRIDS dsTipado = new comTipoPermiRIDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipoPermiRI_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTipoPermiRI_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comTipoPermiRIEliminar", parametros);
        }

        public static int Guardar(string /*0*/pTipoPermiRI_Id, string /*1*/pTipoPermiRI_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pEsquemaAuto_Id, string /*5*/pTipoCuerpo, string /*6*/pReporte_Id, string /*7*/pTipoRI, string /*8*/pUsuarioAutorizado_Id, bool /*9*/pInactivo, bool /*10*/pPosteado, int /*11*/pUsuario_Id, bool /*12*/pGeneraOC, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoPermiRI_Id, /*1*/pTipoPermiRI_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pEsquemaAuto_Id), /*5*/pTipoCuerpo, new Generalidades.NullableString(/*6*/pReporte_Id), /*7*/pTipoRI, new Generalidades.NullableString(/*8*/pUsuarioAutorizado_Id), /*9*/pInactivo, /*10*/pPosteado, new Generalidades.NullableInt(/*11*/pUsuario_Id), /*12*/pGeneraOC };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comTipoPermiRIGuardar", parametros);
        }

    }
}
