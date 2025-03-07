using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proTrabajo3Prov
    {
        public static proTrabajo3ProvDS Datos(string /*0*/pTrabajo3_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTrabajo3_Id, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proTrabajo3ProvDatos", parametros);

            string[] camposTabla0 = { "Proveed_Id", "DescripcionProveed", "Moneda_Id", "DescripcionMoneda", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDeposito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proTrabajo3ProvDS dsTipado = new proTrabajo3ProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pTrabajo3_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTrabajo3_Id, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proTrabajo3ProvEliminar", parametros);
        }

        public static void Guardar(string /*0*/pTrabajo3_Id, int /*1*/pRenglon, string /*2*/pProveedor_Id, string /*3*/pMoneda_Id, decimal /*4*/pPrecio, string /*5*/pMedida_Id, decimal /*6*/pCantidad, bool /*7*/pPredeterminado, string /*8*/pDeposito_Id, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTrabajo3_Id, /*1*/pRenglon, new Generalidades.NullableString(/*2*/pProveedor_Id), new Generalidades.NullableString(/*3*/pMoneda_Id), /*4*/pPrecio, new Generalidades.NullableString(/*5*/pMedida_Id), /*6*/pCantidad, /*7*/pPredeterminado, /*8*/pDeposito_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proTrabajo3ProvGuardar", parametros);
        }



    }
}