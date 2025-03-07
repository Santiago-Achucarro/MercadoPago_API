using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proRecursos
    {
        public static proRecursosDS Datos(string /*0*/pRecurso_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRecurso_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proRecursosDatos", parametros);

            string[] camposTabla0 = { "Medida_Id", "DescripcionUniMed", "Empresa_Id", "PTodasEmpresas", "Cuenta_Id", "DescripcionCuenta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            proRecursosDS dsTipado = new proRecursosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.SubRecursos.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pRecurso_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pRecurso_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proRecursosEliminar", parametros);
        }

        public static int  Guardar(string /*0*/pRecurso_Id, string /*1*/pRecurso_Id_Nueva, string /*2*/pDescripcion, string /*3*/pUnidad_Id, decimal /*4*/pCapacidad, decimal /*5*/pCosto, bool /*6*/pUsaSubRecurso, bool /*7*/pInactivo, bool /*8*/pPosteado, int /*9*/pEmpresa_Id, int /*10*/pUsuario_Id, string /*11*/pCuenta_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRecurso_Id, /*1*/pRecurso_Id_Nueva, /*2*/pDescripcion, new Generalidades.NullableString(/*3*/pUnidad_Id), /*4*/pCapacidad, /*5*/pCosto, /*6*/pUsaSubRecurso, /*7*/pInactivo, /*8*/pPosteado, new Generalidades.NullableInt(/*9*/pEmpresa_Id), /*10*/pUsuario_Id, new Generalidades.NullableString(/*11*/pCuenta_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("proRecursosGuardar", parametros);
        }




    }
}
