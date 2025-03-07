using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
using System.Data;
using interfaceDAAB;

namespace TesoreriaDAL
{
    public class tesCausasRechazo
    {

        public static tesCausasRechazoDS Datos(string /*0*/pCausa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCausa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCausasRechazoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "ParaTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesCausasRechazoDS dsTipado = new tesCausasRechazoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static int Guardar(string /*0*/pCausa_Id, string /*1*/pCausa_Id_Nueva, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, int /*4*/pUsuario_Id, bool /*5*/pPosteado, bool /*6*/pInactivo, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCausa_Id, /*1*/pCausa_Id_Nueva, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pUsuario_Id, /*5*/pPosteado, /*6*/pInactivo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesCausasRechazoGuardar", parametros);
        }



        public static void Eliminar(string /*0*/pCausa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCausa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCausasRechazoEliminar", parametros);
        }






    }
}
