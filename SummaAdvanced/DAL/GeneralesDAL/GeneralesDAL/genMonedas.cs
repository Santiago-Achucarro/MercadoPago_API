using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genMonedas
    {
        public static genMonedasDS Datos(string /*0*/pMoneda_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMonedasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CodigoFiscal", "CtaFactaRecibir",
                "DescripcionCtaFactaRecibir", "CtaFactaRecibirImp", "DescripcionCtaFactaRecibirImp" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genMonedasDS dsTipado = new genMonedasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pMoneda_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genMonedasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pMoneda_Id, string /*1*/pMoneda_Id_Nuevo, int /*2*/pEmpresa_Id, 
            string /*3*/pDescripcion, string /*4*/pSimbolo, string /*5*/pCodigoFiscal, string /*6*/pCtaFactaRecibir, 
            string /*7*/pCtaFactaRecibirImp, Int32 pCantidadDigitos, bool /*8*/pInactivo, int /*9*/pUsuario_Id, 
            bool /*10*/pPosteado, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMoneda_Id, /*1*/pMoneda_Id_Nuevo,
                new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pSimbolo, /*5*/pCodigoFiscal,
                /*6*/pCtaFactaRecibir, /*7*/pCtaFactaRecibirImp, pCantidadDigitos, /*8*/pInactivo, /*9*/pUsuario_Id, /*10*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("genMonedasGuardar", parametros));
        }


        public static genMonedasDatosCierreDS DatosCierre(DateTime /*0*/Fecha, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Fecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMonedasDatosCierre", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genMonedasDatosCierreDS dsTipado = new genMonedasDatosCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.TipoCambio.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static genMonedasDS DatosFiscal(string /*0*/pMonedaFiscal, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMonedaFiscal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMonedasDatosFiscal", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CodigoFiscal", "CtaFactaRecibir",
                "DescripcionCtaFactaRecibir", "CtaFactaRecibirImp", "DescripcionCtaFactaRecibirImp" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genMonedasDS dsTipado = new genMonedasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
