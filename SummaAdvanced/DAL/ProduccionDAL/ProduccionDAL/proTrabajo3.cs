using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proTrabajo3
    {
        public static proTrabajo3DS Datos(string /*0*/pTrabajo3_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTrabajo3_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proTrabajo3Datos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Cuenta_Id", "DescripcionCuentas", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Proveed_Id", "DescripcionProveed", "Moneda_Id", "DescripcionMoneda", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDeposito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            proTrabajo3DS dsTipado = new proTrabajo3DS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Trabajo3Prov.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pTrabajo3_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTrabajo3_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proTrabajo3Eliminar", parametros);
        }

        public static int Guardar(string /*0*/pTrabajo3_Id, string /*1*/pTrabajo3_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pCuenta_Id, bool /*5*/pInactivo, bool /*6*/pPosteado, int /*7*/pUsuario_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTrabajo3_Id, /*1*/pTrabajo3_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pCuenta_Id), /*5*/pInactivo, /*6*/pPosteado, new Generalidades.NullableInt(/*7*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("proTrabajo3Guardar", parametros);
        }

    }
}
