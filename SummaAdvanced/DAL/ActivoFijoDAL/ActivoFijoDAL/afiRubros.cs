using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    

public class afiRubros
    {

        public static AfiRubrosDS Datos(string /*0*/pRubro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiRubrosDatos", parametros);

            string[] camposTabla0 = { "PTodasEmpresas", "Empresa_Id", "CtaValorOrigen", "DescripcionCtaValorOrigen", "CtaAmortAcum_Id", "DescripcionCtaAmortAcum_Id", "CtaAmortizacion_Id", "DescripcionCtaAmortizacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            AfiRubrosDS dsTipado = new AfiRubrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pRubro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("AfiRubrosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pRubro_Id, string /*1*/pRubro_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, int /*4*/pVidaUtil, int /*5*/pVidaUtilFiscal, string /*6*/pCtaValorOrigen_Id, string /*7*/pCtaAmortAcum_Id, string /*8*/pCtaAmortizacion_Id, string /*9*/pTipo, short /*10*/pDigitos, int /*11*/pUsuario_Id, bool /*12*/pPosteado, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Id, /*1*/pRubro_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pVidaUtil, /*5*/pVidaUtilFiscal, new Generalidades.NullableString(/*6*/pCtaValorOrigen_Id), new Generalidades.NullableString(/*7*/pCtaAmortAcum_Id), new Generalidades.NullableString(/*8*/pCtaAmortizacion_Id), /*9*/pTipo, /*10*/pDigitos, /*11*/pUsuario_Id, /*12*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("AfiRubrosGuardar", parametros);
        }

        public static AfiRubrosDS CuentaDatos(string /*0*/pCuenta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiRubrosCuentaDatos", parametros);

            string[] camposTabla0 = { "PTodasEmpresas", "Empresa_Id", "CtaValorOrigen", "DescripcionCtaValorOrigen", "CtaAmortAcum_Id", "DescripcionCtaAmortAcum_Id", "CtaAmortizacion_Id", "DescripcionCtaAmortizacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            AfiRubrosDS dsTipado = new AfiRubrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
