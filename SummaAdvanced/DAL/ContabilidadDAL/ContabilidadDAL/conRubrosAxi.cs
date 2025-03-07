using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conRubrosAxi
    {

        public static conRubrosAxiDS Datos(int /*0*/pRubroAxi_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroAxi_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conRubrosAxiDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conRubrosAxiDS dsTipado = new conRubrosAxiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pRubroAxi_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroAxi_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conRubrosAxiEliminar", parametros);
        }

        public static void Guardar(int /*0*/pRubroAxi_Id, int /*1*/pRubroAxi_Id_Nueva, string /*2*/pDescripcion, string /*3*/pRubro_Id, int /*4*/pEmpresa_Id, bool /*5*/pPosteado, bool /*6*/pInactivo, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroAxi_Id, /*1*/pRubroAxi_Id_Nueva, /*2*/pDescripcion, /*3*/pRubro_Id,
                new Generalidades.NullableInt(/*4*/pEmpresa_Id), /*5*/pPosteado, /*6*/pInactivo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conRubrosAxiGuardar", parametros);
        }



    }
}
