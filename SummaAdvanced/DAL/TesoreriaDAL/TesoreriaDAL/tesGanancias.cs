using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesGanancias
    {
        public static tesGananciasDS Datos(int /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesGananciasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            tesGananciasDS dsTipado = new tesGananciasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pTabla_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesGananciasEliminar", parametros);
        }
        public static int Guardar(int /*0*/pTabla_Id, int /*1*/pTabla_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, bool /*4*/pInactivo, int /*5*/pUsuario_Id, bool /*6*/pPosteado, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pTabla_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pInactivo, /*5*/pUsuario_Id, /*6*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesGananciasGuardar", parametros);
        }
    }
}
