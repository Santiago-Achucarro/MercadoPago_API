using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proCentroProductivo
    {
        public static proCentroProductivoDS Datos(string /*0*/pCtroProd_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCtroProd_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proCentroProductivoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Usuario_Id", "CtaProdProceso", "DescripcionCtaProdProceso" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            proCentroProductivoDS dsTipado = new proCentroProductivoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pCtroProd_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCtroProd_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proCentroProductivoEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCtroProd_Id, string /*1*/pCtroProd_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pCentro1_Id, string /*5*/pCentro2_Id, bool /*6*/pInactivo, bool /*7*/pPosteado, int /*8*/pUsuario_Id, string /*9*/pCtaProdProceso, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCtroProd_Id, /*1*/pCtroProd_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pCentro1_Id), new Generalidades.NullableString(/*5*/pCentro2_Id), /*6*/pInactivo, /*7*/pPosteado, new Generalidades.NullableInt(/*8*/pUsuario_Id), new Generalidades.NullableString(/*9*/pCtaProdProceso) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("proCentroProductivoGuardar", parametros);
        }


    }
}
