using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;
namespace VentasDAL
{
    public class venMovImpTraslado
    {
        public static venMovImpTrasladoDS Datos(long /*0*/pAsiento_Id, int /*1*/pRenglonDebe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglonDebe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovImpTrasladoDatos", parametros);

            string[] camposTabla0 = { "Asiento_Id", "RenglonDebe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "RenglonHaber", "venMovimientos", "tesMovimientos", "Banco_Id", "DescripcionIdBancoPropio", "RenDifCambio", "Cliente_ Id","RazonSocial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venMovImpTrasladoDS dsTipado = new venMovImpTrasladoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pAsiento_Id, int /*1*/pRenglonDebe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, new Generalidades.NullableInt(/*1*/pRenglonDebe) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovImpTrasladoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, int /*1*/pRenglonDebe, int /*2*/pRenglonHaber, long /*3*/pvenMovimientos, long /*4*/ptesMovimientos, string /*5*/pImpuesto_Id, string /*6*/pCliente_Id, string /*7*/pCartera_Id, string /*8*/pBanco_Id, decimal /*9*/pBaseImponible, decimal /*10*/pMonto, decimal /*11*/pTotalCobro, decimal /*12*/pDifCambio, int /*13*/pRenDifCambio, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglonDebe, new Generalidades.NullableInt(/*2*/pRenglonHaber), new Generalidades.NullableInt64(/*3*/pvenMovimientos), 
                    /*4*/ptesMovimientos, /*5*/pImpuesto_Id, new Generalidades.NullableString(/*6*/pCliente_Id), /*7*/pCartera_Id, new Generalidades.NullableString(/*8*/pBanco_Id), /*9*/pBaseImponible, /*10*/pMonto, /*11*/pTotalCobro, /*12*/pDifCambio, new Generalidades.NullableInt(/*13*/pRenDifCambio) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovImpTrasladoGuardar", parametros);
        }



    }
}
