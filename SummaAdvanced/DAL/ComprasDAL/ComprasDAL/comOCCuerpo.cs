using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comOCCuerpo
    {
        public static comOCCuerpoDS Datos(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, new Generalidades.NullableInt(/*1*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comOCCuerpoDatos", parametros);

            string[] camposTabla0 = { "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOCCuerpoDS dsTipado = new comOCCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






        public static void Eliminar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, new Generalidades.NullableInt(/*1*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOCCuerpoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, decimal /*2*/pCantidad, decimal /*3*/pCantidad_Recibida, decimal /*4*/pCantidad_Embarcada, decimal /*5*/pCantidad_Facturada, DateTime /*6*/pFecha_Entrega, decimal /*7*/pPrecio, bool /*8*/pPendiente, decimal /*9*/pCantidad_Creditos, string /*10*/pMedida_Id, string /*11*/pCentro1_Id, string /*12*/pCentro2_Id, decimal /*13*/pCantidadConsignada, string /*14*/pObservaciones, string /*15*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pCantidad, /*3*/pCantidad_Recibida, /*4*/pCantidad_Embarcada, /*5*/pCantidad_Facturada, /*6*/pFecha_Entrega, /*7*/pPrecio, /*8*/pPendiente, /*9*/pCantidad_Creditos, new Generalidades.NullableString(/*10*/pMedida_Id), new Generalidades.NullableString(/*11*/pCentro1_Id), new Generalidades.NullableString(/*12*/pCentro2_Id), /*13*/pCantidadConsignada, new Generalidades.NullableString(/*14*/pObservaciones) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoGuardar", parametros);
        }




        public static void Recibir(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoRecibir", parametros);
        }

        public static void Embarcar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoEmbarcar", parametros);
        }

        public static void Facturar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoFacturar", parametros);
        }

        public static void Creditos(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoCeditos", parametros);
        }


        public static void Consignar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoConsignar", parametros);
        }

        public static void ActuPendiente(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, bool /*2*/pPendiente, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pPendiente };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoActuPendiente", parametros);
        }

        public static void ActuFecha(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, DateTime /*2*/pFecha_Entrega, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pFecha_Entrega };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCCuerpoActuFecha", parametros);
        }




    }
}
