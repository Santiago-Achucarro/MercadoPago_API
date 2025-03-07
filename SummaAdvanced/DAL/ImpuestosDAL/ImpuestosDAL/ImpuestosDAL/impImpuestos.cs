using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
 public class impImpuestos
    {
        public static impImpuestosDS Datos(string /*0*/pImpuesto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impImpuestosDatos", parametros);

            string[] camposTabla0 = { "CuentaHaber", "DescripcionCuentaHaber", "CuentaDebe", "DescripcionCuentaDebe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            impImpuestosDS dsTipado = new impImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Formulas.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pImpuesto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impImpuestosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pImpuesto_Id, string /*1*/pDescripcion, bool /*2*/pPosteado, bool /*3*/pInactivo, string /*4*/pTipoVencimiento, short /*5*/pDiaMesVence, short /*6*/pAvisarNDias, DateTime /*7*/pProximoVencimiento, string /*8*/pCtaHaber_Id, string /*9*/pCtaDebe_Id, bool /*10*/pPagoAnticipado, bool /*11*/pSePaga, bool /*12*/pVaAlCashFlow, DateTime /*13*/pLiquidadoHasta, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_Id, /*1*/pDescripcion, /*2*/pPosteado, /*3*/pInactivo, /*4*/pTipoVencimiento, /*5*/pDiaMesVence, /*6*/pAvisarNDias, /*7*/pProximoVencimiento, new Generalidades.NullableString(/*8*/pCtaHaber_Id), new Generalidades.NullableString(/*9*/pCtaDebe_Id), /*10*/pPagoAnticipado, /*11*/pSePaga, /*12*/pVaAlCashFlow, /*13*/pLiquidadoHasta };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("impImpuestosGuardar", parametros));
        }





    }
}
