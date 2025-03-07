using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comImpuestos
    {
        public static comImpuestosDS Datos(string /*0*/pImpuesto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comImpuestosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "CtaDebe", "DescripcionCtaDebe", "CtaHaber", "DescripcionCtaHaber",
                        "CtaReversion", "DescripcionCtaReversion" };

            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comImpuestosDS dsTipado = new comImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pImpuesto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comImpuestosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pImpuesto_Id, string /*1*/pImpuesto_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, int /*4*/pTipoImpuesto, string /*5*/pFormulacalc, string /*6*/pCtaDebe, string /*7*/pCtaHaber, string /*8*/pCtaReversion, decimal /*9*/pPorcentaje, DateTime /*10*/pFecha_Desde, DateTime /*11*/pFecha_Hasta, string /*12*/pDepende_de, bool /*13*/pVaAlCosto, bool /*14*/pPorAcreditacion,  bool /*16*/pInactivo, int /*17*/pUsuario_Id, bool /*18*/pPosteado, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id, /*1*/pImpuesto_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pTipoImpuesto, /*5*/pFormulacalc, new Generalidades.NullableString(/*6*/pCtaDebe), new Generalidades.NullableString(/*7*/pCtaHaber), new Generalidades.NullableString(/*8*/pCtaReversion), /*9*/pPorcentaje, /*10*/pFecha_Desde, /*11*/pFecha_Hasta, /*12*/pDepende_de, /*13*/pVaAlCosto, /*14*/pPorAcreditacion,  /*16*/pInactivo, /*17*/pUsuario_Id, /*18*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comImpuestosGuardar", parametros);
        }

        public static comImpuestosDS DatosPorTipo(int /*0*/pTipo, decimal /*1*/pPorcentaje, DateTime /*2*/pFecha, int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipo, /*1*/pPorcentaje, /*2*/pFecha, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comImpuestosPorTipoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CtaDebe", "DescripcionCtaDebe", "CtaHaber", "DescripcionCtaHaber", "CtaReversion", "DescripcionCtaReversion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comImpuestosDS dsTipado = new comImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
