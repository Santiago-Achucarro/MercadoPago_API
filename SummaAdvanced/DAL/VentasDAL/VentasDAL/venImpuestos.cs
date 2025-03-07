using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venImpuestos
    {
        public static venImpuestosDS Datos(string /*0*/pImpuesto_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venImpuestosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "TipoImpuesto", "DescripcionTipoImpuesto", "CodigoFiscal", "Fecha_Hasta",
                "CtaReversion", "DescripcionCtaReversion", "Cuenta_Id", "DescripcionCuentas", "CtaDifCambio", "DescripcionCtaDifCambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venImpuestosDS dsTipado = new venImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pImpuesto_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pImpuesto_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venImpuestosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pImpuesto_id, string /*1*/pImpuesto_id_Nuevo, int /*2*/pEmpresa_Id, 
            string /*3*/pDescripcion, int /*4*/pTipoImpuesto, string /*5*/pCodigoFiscal, bool /*6*/pUsaFormula, 
            string /*7*/pFormulacalc, decimal /*8*/pPorcentaje, DateTime /*9*/pFecha_Desde, DateTime /*10*/pFecha_Hasta, 
            string /*11*/pDepende_de, bool /*12*/pPorVencimiento, string /*13*/pCtaReversion, string /*14*/pCuenta_id, 
            string /*15*/pCtaDifCambio, bool /*16*/pImpuestoXProducto, bool /*17*/pInactivo, int /*18*/pUsuario_Id, 
            bool /*19*/pPosteado, string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImpuesto_id, /*1*/pImpuesto_id_Nuevo,
                new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion,
                new Generalidades.NullableInt(/*4*/pTipoImpuesto), new Generalidades.NullableString(/*5*/pCodigoFiscal),
                /*6*/pUsaFormula, /*7*/pFormulacalc, /*8*/pPorcentaje, /*9*/pFecha_Desde,
                new Generalidades.NullableDate( /*10*/pFecha_Hasta), /*11*/pDepende_de, /*12*/pPorVencimiento,
                new Generalidades.NullableString(/*13*/pCtaReversion), new Generalidades.NullableString(/*14*/pCuenta_id),
                new Generalidades.NullableString(/*15*/pCtaDifCambio), /*16*/pImpuestoXProducto, /*17*/pInactivo, /*18*/pUsuario_Id,
                /*19*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venImpuestosGuardar", parametros));
        }
    }
}
