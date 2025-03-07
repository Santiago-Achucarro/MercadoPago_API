using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovDetalle
    {
        public static comMovDetalleDS Datos(long /*0*/pcomMovProv, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovDetalleDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuenta", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id", "DescripcionBaseDistri" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovDetalleDS dsTipado = new comMovDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovDetalleEliminar", parametros);
        }
        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pRenglon, string /*2*/pDetalle, decimal /*3*/pImporte, string /*4*/pCuenta_id, string /*5*/pCentro1_Id, string /*6*/pCentro2_Id, string /*7*/pBase_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglon, /*2*/pDetalle, /*3*/pImporte, new Generalidades.NullableString(/*4*/pCuenta_id), new Generalidades.NullableString(/*5*/pCentro1_Id), new Generalidades.NullableString(/*6*/pCentro2_Id), new Generalidades.NullableString(/*7*/pBase_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovDetalleGuardar", parametros);
        }




    }
}
