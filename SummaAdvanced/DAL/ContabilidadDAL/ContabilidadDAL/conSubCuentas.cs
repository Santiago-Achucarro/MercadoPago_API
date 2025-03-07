using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conSubCuentas
    {
        public static conSubCuentasDS Datos(string /*0*/pSubCuenta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conSubCuentasDatos", parametros);

            string[] camposTabla0 = { "PTodasEmpresas", "Empresa_Id", "Base_Id", "DescripcionBaseDistri", "Cuadro1Fila_Id", "DescripcionCuadro1Filas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conSubCuentasDS dsTipado = new conSubCuentasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







        public static void Eliminar(string /*1*/pSubCuenta_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*1*/pSubCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conSubCuentasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pSubCuenta_Id, string /*1*/pSubCuenta_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion,
            int /*4*/pCuadro1Fila_Id, string /*5*/pBase_Id, bool /*6*/pAjustable, bool /*7*/pInactivo, int /*8*/pUsuario_Id, bool /*9*/pPosteado,
            string /*10*/pDescription, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubCuenta_Id, /*1*/pSubCuenta_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id),
                /*3*/pDescripcion, /*4*/pCuadro1Fila_Id, new Generalidades.NullableString(/*5*/pBase_Id), /*6*/pAjustable, /*7*/pInactivo,
                /*8*/pUsuario_Id, /*9*/pPosteado, /*10*/pDescription };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("conSubCuentasGuardar", parametros);
        }


    }
}
