using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comRICuerpo
    {
        public static void Eliminar(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, new Generalidades.NullableInt(/*1*/pRenglon_RI) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comRICuerpoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, DateTime /*2*/pFechaNecesidad, decimal /*3*/pCantidad, decimal /*4*/pPrecio, decimal /*5*/pCantidadRecibida, string /*6*/pObservaciones, bool /*7*/pPendiente, string /*8*/pCuenta_Id, string /*9*/pCentro1_Id, string /*10*/pCentro2_Id, string /*11*/pMedida_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pRenglon_RI, /*2*/pFechaNecesidad, /*3*/pCantidad, /*4*/pPrecio, /*5*/pCantidadRecibida, new Generalidades.NullableString(/*6*/pObservaciones), /*7*/pPendiente, new Generalidades.NullableString(/*8*/pCuenta_Id), new Generalidades.NullableString(/*9*/pCentro1_Id), new Generalidades.NullableString(/*10*/pCentro2_Id), new Generalidades.NullableString(/*11*/pMedida_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRICuerpoGuardar", parametros);
        }

        public static comRICuerpoDS Datos(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pRenglon_RI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comRICuerpoDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comRICuerpoDS dsTipado = new comRICuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Recibir(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pRenglon_RI, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRICuerpoRecibir", parametros);
        }



    }
}
