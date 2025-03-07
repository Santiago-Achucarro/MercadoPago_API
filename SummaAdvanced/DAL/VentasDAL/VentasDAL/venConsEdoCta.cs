using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using VentasCommon;
using System.Data;

namespace VentasDAL
{
    public class venConsEdoCta
    {
        public static VenConsEdoCtaDS Datos(string /*0*/Cliente_Id, int /*1*/Sucursal, string /*2*/Moneda_Id, 
            bool /*3*/Pendiente, DateTime /*4*/FechaDesde, DateTime /*5*/FechaHasta, int /*6*/Empresa_Id, 
            bool /*7*/SoloEstaMoneda, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Cliente_Id, new Generalidades.NullableInt(/*1*/Sucursal),
                /*2*/Moneda_Id, /*3*/Pendiente, /*4*/FechaDesde, /*5*/FechaHasta, /*6*/Empresa_Id, /*7*/SoloEstaMoneda };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("VenConsEdoCta", parametros);

            string[] camposTabla0 = { "MonedaCtaCte", "LimiteCredito", "Pendiente", "FechaDesde", "FechaHasta",
                "Sucursal", "SoloEstaMoneda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Fecha", "Segmento", "FechaVencimiento", "Debe", "Haber", "Saldo", "SucCliente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Saldo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            VenConsEdoCtaDS dsTipado = new VenConsEdoCtaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Saldo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
