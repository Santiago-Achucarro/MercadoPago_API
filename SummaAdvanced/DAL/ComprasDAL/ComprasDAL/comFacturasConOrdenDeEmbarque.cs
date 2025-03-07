using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;

namespace ComprasDAL
{
    public class comFacturasConOrdenDeEmbarque
    {

        public static comFacturasConOrdenDeEmbarqueDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_Id_EMB, int /*11*/pSegmento1N_EMB, int /*12*/pSegmento2N_EMB, int /*13*/pSegmento3N_EMB, int /*14*/pSegmento4N_EMB, string /*15*/pSegmento1C_EMB, string /*16*/pSegmento2C_EMB, string /*17*/pSegmento3C_EMB, string /*18*/pSegmento4C_EMB, string /*19*/pProveed_id, string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_Id_EMB, /*11*/pSegmento1N_EMB, /*12*/pSegmento2N_EMB, /*13*/pSegmento3N_EMB, /*14*/pSegmento4N_EMB, /*15*/pSegmento1C_EMB, /*16*/pSegmento2C_EMB, /*17*/pSegmento3C_EMB, /*18*/pSegmento4C_EMB, new Generalidades.NullableString(/*19*/pProveed_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comFacturasConOrdenDeEmbarque", parametros);

            string[] camposTabla0 = { "Tipomov", "Observaciones", "TipoCtaProv", "DescripcionProveedoresTipoPasivo", "Origen_Id", "DescripcionOrCredFisc", "CondPago_Id", "DescripcionConPago", "CondFiscal_Id", "DescripcionCondFiscal", "FechaFiscal", "ClaveFiscal", "VieneDeFiscal", "TipoCompFE", "DescripcionTipoCompFE", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "FechaVencimiento", "Cierre", "RenglonDtoFin" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "comMovProv", "Cantidad", "CantidadForm", "CantidadPendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            comFacturasConOrdenDeEmbarqueDS dsTipado = new comFacturasConOrdenDeEmbarqueDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Embarque.TableName, dsTipado.Cuerpo.TableName, dsTipado.Gastos.TableName, dsTipado.Impuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Cuotas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
