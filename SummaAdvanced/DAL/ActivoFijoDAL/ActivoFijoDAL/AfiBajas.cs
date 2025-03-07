using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    public class AfiBajas
    {
        public static AfiBajasDS Datos(string /*0*/pActivoFijo_Id, int /*1*/pEmpresa_Id, string /*2*/pSegmento_Id, string /*3*/pSegmento1C, string /*4*/pSegmento2C, string /*5*/pSegmento3C, string /*6*/pSegmento4C, int /*7*/pSegmento1N, int /*8*/pSegmento2N, int /*9*/pSegmento3N, int /*10*/pSegmento4N, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pEmpresa_Id, /*2*/pSegmento_Id, /*3*/pSegmento1C, /*4*/pSegmento2C, /*5*/pSegmento3C, /*6*/pSegmento4C, /*7*/pSegmento1N, /*8*/pSegmento2N, /*9*/pSegmento3N, /*10*/pSegmento4N };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("AfiBajasDatos", parametros);

            string[] camposTabla0 = { "FechaBaja", "Rubro_Id", "DescripcionRubros", "CtaValorOrigen_Id", "DescripcionCuentasOrigen", "CtaAmortAcum_Id", "DescripcionCtaAmortAcum_Id", "CtaAmortizacion", "DescripcionCtaAmortizacion", "Usuario_Id", "DescripcionUsuario", "TieneMovimientos", "AsientoOrigen", "RenglonOrigen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "Responsable_Id", "DescripcionResponsable" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla6 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            AfiBajasDS dsTipado = new AfiBajasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Centros.TableName, dsTipado.Responsables.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Adjuntos.TableName, dsTipado.Baja.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







        public static void Eliminar(long /*0*/pconAsientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("AfiBajasEliminar", parametros);
        }

        public static void Guardar(long /*0*/pconAsientos, string /*1*/pCausa, decimal /*2*/pCantidad, decimal /*3*/pMonto, decimal /*4*/pMontoFiscal, decimal /*5*/pMontoDepreciacion, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableString(/*1*/pCausa), /*2*/pCantidad, /*3*/pMonto, /*4*/pMontoFiscal, /*5*/pMontoDepreciacion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AfiBajasGuardar", parametros);
        }



    }
}
