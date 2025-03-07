using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovpAnexoDetalle
    {
        public static comMovpAnexoDetalleDS Datos(long /*0*/pAsiento_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovpAnexoDetalleDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id", "DescripcionBaseDistri" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovpAnexoDetalleDS dsTipado = new comMovpAnexoDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pAsiento_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovpAnexoDetalleEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, int /*1*/pRenglon, decimal /*2*/pImporte, string /*3*/pCuenta_Id, string /*4*/pCentro1_Id, string /*5*/pCentro2_Id, string /*6*/pBase_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pRenglon, /*2*/pImporte, new Generalidades.NullableString(/*3*/pCuenta_Id), new Generalidades.NullableString(/*4*/pCentro1_Id), new Generalidades.NullableString(/*5*/pCentro2_Id), new Generalidades.NullableString(/*6*/pBase_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovpAnexoDetalleGuardar", parametros);
        }



    }
}
