using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SueldosCommon;
using System.Data;
using interfaceDAAB;

namespace SueldosDAL
{
    public class sueConcDescuento
    {

        public static sueConcDescuentoDS Datos(int /*0*/pLegajo, int /*1*/pConcepto_Id, long /*2*/psueLiquidacion, int /*3*/psueConcAcum, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pConcepto_Id, /*2*/psueLiquidacion, /*3*/psueConcAcum };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueConcDescuentoDatos", parametros);

            sueConcDescuentoDS dsTipado = new sueConcDescuentoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pLegajo, int /*1*/pConcepto_Id, long /*2*/psueLiquidacion, int /*3*/psueConcAcum, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableInt(/*1*/pConcepto_Id), /*2*/psueLiquidacion, new Generalidades.NullableInt(/*3*/psueConcAcum) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConcDescuentoEliminar", parametros);
        }



        public static void Guardar(int /*0*/pLegajo, int /*1*/pConcepto_Id, long /*2*/psueLiquidacion, int /*3*/psueConcAcum, decimal /*4*/pMonto, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pConcepto_Id, /*2*/psueLiquidacion, /*3*/psueConcAcum, /*4*/pMonto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConcDescuentoGuardar", parametros);
        }




    }
}
