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
    public class suePuestos
    {
        public static suePuestosDS Datos(string /*0*/pPuesto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePuestosDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "Empresa_Id", "PTodasEmpresas", "RiesgoPuesto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            suePuestosDS dsTipado = new suePuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pPuesto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePuestosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pPuesto_Id, string /*1*/pPuesto_Id_Nueva, string /*2*/pDescripcion, bool /*3*/pInactivo, bool /*4*/pPosteado, int /*5*/pUsuario_Id, int /*6*/pEmpresa_Id, string /*7*/pRiesgoPuesto, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPuesto_Id, /*1*/pPuesto_Id_Nueva, /*2*/pDescripcion, /*3*/pInactivo, /*4*/pPosteado, new Generalidades.NullableInt(/*5*/pUsuario_Id), /*6*/new Generalidades.NullableInt(pEmpresa_Id), new Generalidades.NullableString(/*7*/pRiesgoPuesto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("suePuestosGuardar", parametros);
        }



    }
}
