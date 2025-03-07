using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comHabilitarPagos
    {
    
      public static comHabilitarPagosDS Datos(string /*0*/pProveed_Id, string /*1*/pMoneda_Id, bool /*2*/pSoloHabilitados, int /*3*/pEmpresa_Id, DateTime /*4*/pFechaPago, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pMoneda_Id, /*2*/pSoloHabilitados, /*3*/pEmpresa_Id, new Generalidades.NullableDate(/*4*/pFechaPago) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comHabilitarPagosDatos", parametros);

            string[] camposTabla0 = { "SoloHabilitados", "FechaPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "SaldoOri", "FechaHabilitacion", "ImporteHabilitado", "tesMovimientos", "CambioPago", "Importe1", "Importe2", "Importe3" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "FechaPago", "tesMovimientos", "comEmbarques", "Empresa_Id", "Segmento_Id", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comHabilitarPagosDS dsTipado = new comHabilitarPagosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.PagosHabilitados.TableName, dsTipado.PagosAnticipo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






    }
}
