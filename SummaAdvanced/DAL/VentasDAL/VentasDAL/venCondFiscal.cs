using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCondFiscal
    {
        public static venCondFiscalDS Datos(string /*0*/pCondFisc_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFisc_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCondFiscalDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CodigoFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "CodigoFiscal", "Fecha_Hasta", "CtaReversion", "Cuenta_Id", "CtaDifCambio", "CodigoFiscalTipo", "Juris_Id",
                "Referencia01", "Referencia02", "Referencia03", "Referencia04", "Referencia05", "Referencia06", "Referencia07", "Referencia08",
                "Referencia09", "Referencia10" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venCondFiscalDS dsTipado = new venCondFiscalDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdImpuestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCondFisc_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCondFisc_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCondFiscalEliminar", parametros);
        }
        public static int Guardar(string /*0*/pCondFisc_id, string /*1*/pCondFisc_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, 
            string /*4*/pLetra, bool /*5*/pAplicaFactCredito, string /*6*/pLetra_Rf, bool /*7*/pDiscrimina, bool /*8*/pFacturaElectronica, 
            string /*9*/pCodigoFiscal, bool /*10*/pInactivo, int /*11*/pUsuario_Id, bool /*12*/pPosteado, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFisc_id, /*1*/pCondFisc_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id),
                /*3*/pDescripcion, /*4*/pLetra, /*5*/pAplicaFactCredito, /*6*/pLetra_Rf, /*7*/pDiscrimina, /*8*/pFacturaElectronica,
                new Generalidades.NullableString(/*9*/pCodigoFiscal), /*10*/pInactivo, /*11*/pUsuario_Id, /*12*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venCondFiscalGuardar", parametros);
        }
    }
}
