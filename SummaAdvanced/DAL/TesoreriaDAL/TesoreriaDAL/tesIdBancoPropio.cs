using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdBancoPropio
    {
        public static tesIdBancoPropioDS Datos(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, new Generalidades.NullableInt(/*1*/pEmpresa_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesIdBancoPropioDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas", "Cuenta_Id", "DescripcionCuentas", "Moneda_Id", "DescripcionMonedas", "UsuarioAmo", "DescripcionUsuarioAmo", "CtaValEnTransito", "DescripcionCtaValEnTransito", "ChequeraPredeter", "DescripcionBancos", "CtaContDiferido", "DescripcionCtaContDiferido", "RepoCheq_Id", "TituloRepoCheq", "RepoCheqDif_Id", "TituloRepoCheqDif", "FormaDePagoP", "OrdenPtoVta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesIdBancoPropioDS dsTipado = new tesIdBancoPropioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pCartera_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesIdBancoPropioEliminar", parametros);
        }
        public static void Guardar(string /*0*/pCartera_Id, int /*1*/pChequeraPredeter, string /*2*/pBanco_Id, int /*3*/pCantRenglones, string /*4*/pnumCuenta, string /*5*/pCtaContDiferido, decimal /*6*/pMaximoLibrado, decimal /*7*/pValorComision, decimal /*8*/pLimCredVtaCheques, decimal /*9*/pCtaCorto, int /*10*/pFormulario_Id, string /*11*/pReferencia, string /*12*/pRepoCheq_Id, string /*13*/pRepoCheq_IdDif, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, new Generalidades.NullableInt(/*1*/pChequeraPredeter), /*2*/pBanco_Id, /*3*/pCantRenglones, /*4*/pnumCuenta, new Generalidades.NullableString(/*5*/pCtaContDiferido), /*6*/pMaximoLibrado, /*7*/pValorComision, /*8*/pLimCredVtaCheques, /*9*/pCtaCorto, /*10*/pFormulario_Id, /*11*/pReferencia, new Generalidades.NullableString(/*12*/pRepoCheq_Id), new Generalidades.NullableString(/*13*/pRepoCheq_IdDif) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesIdBancoPropioGuardar", parametros);
        }


    }
}
