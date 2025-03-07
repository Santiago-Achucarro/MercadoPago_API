using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ComprasCommon;
using interfaceDAAB;


namespace ComprasDAL
{
  public  class comHabilitarPagosMasivos
    {
        public static comHabilitarPagosMasivosDS Datos(string /*0*/pProveed_IdDesde, string /*1*/pProveed_IdHasta, string /*2*/pMoneda_Id, DateTime /*3*/pFechaHasta, int /*4*/pEmpresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_IdDesde, /*1*/pProveed_IdHasta, /*2*/pMoneda_Id, /*3*/pFechaHasta, /*4*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comHabilitarPagosMasivosDatos", parametros);

            string[] camposTabla0 = { "ProveedorDesde", "ProveedorHasta", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "SaldoOri", "ImporteHabilitado", "tesMovimientos", "CambioPago", "Importe1", "Importe2", "Importe3" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comHabilitarPagosMasivosDS dsTipado = new comHabilitarPagosMasivosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.PagosHabilitados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
