using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comConPago
    {
        public static comConPagoDS Datos(string /*0*/pCondPago_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPago_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comConPagoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id"};
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comConPagoDS dsTipado = new comConPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCondPago_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCondPago_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comConPagoEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCondPago_Id, string /*1*/pCondPago_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pDesde, int /*5*/pDias, int /*6*/pCantidadCuotas, bool /*7*/pAplicaFactCredito, bool /*8*/pAdmiteFactPagoAdel, bool /*9*/pInactivo, int /*10*/pUsuario_Id, bool /*11*/pPosteado, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPago_Id, /*1*/pCondPago_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pDesde, /*5*/pDias, /*6*/pCantidadCuotas, /*7*/pAplicaFactCredito, /*8*/pAdmiteFactPagoAdel, /*9*/pInactivo, /*10*/pUsuario_Id, /*11*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comConPagoGuardar", parametros);
        }



    }

}

