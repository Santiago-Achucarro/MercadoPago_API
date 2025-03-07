using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdentifica
    {
        public static tesIdentificaDS Datos(string /*0*/pCartera_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesIdentificaDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas", "Cuenta_Id", "DescripcionCuentas", "Moneda_Id", "DescripcionMonedas", "UsuarioAmo", "DescripcionUsuarioAmo", "CtaValEnTransito", "DescripcionCtaValEnTransito", "FormaDePagoP", "OrdenPtoVta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesIdentificaDS dsTipado = new tesIdentificaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pCartera_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCartera_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesIdentificaEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCartera_Id, string /*1*/pCartera_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pTipoCartera, string /*4*/pDescripcion, string /*5*/pCuenta_Id, string /*6*/pCentro1_Id, string /*7*/pCentro2_Id, string /*8*/pMoneda_Id, string /*9*/pUsuarioAmo, bool /*10*/pModiCent1, bool /*11*/pModiCent2, string /*12*/pCtaValEnTransito, decimal /*13*/pReservado, bool /*14*/pVaAlCashFlow, bool /*15*/pInactivo, int /*16*/pUsuario_Id, bool /*17*/pPosteado, string /*18*/pFormaDePagoP, int /*19*/pOrdenPtoVta, string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pCartera_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pTipoCartera, /*4*/pDescripcion, new Generalidades.NullableString(/*5*/pCuenta_Id), /*6*/pCentro1_Id, /*7*/pCentro2_Id, new Generalidades.NullableString(/*8*/pMoneda_Id), new Generalidades.NullableString(/*9*/pUsuarioAmo), /*10*/pModiCent1, /*11*/pModiCent2, new Generalidades.NullableString(/*12*/pCtaValEnTransito), /*13*/pReservado, /*14*/pVaAlCashFlow, /*15*/pInactivo, /*16*/pUsuario_Id, /*17*/pPosteado, /*18*/pFormaDePagoP, new Generalidades.NullableInt(/*19*/pOrdenPtoVta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("tesIdentificaGuardar", parametros));
        }

        public static tesIdentificaPVDS TraerMediosPago(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesIdentificaPV", parametros);

            string[] camposTabla0 = { "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesIdentificaPVDS dsTipado = new tesIdentificaPVDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
