using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venMovCSImpuestos
    {
        public static venMovCSImpuestosDS Datos(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/pImpuesto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, 
                    new Generalidades.NullableInt(/*1*/pRenglonCuerpo), 
                new Generalidades.NullableString(/*2*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovCSImpuestosDatos", parametros);

            venMovCSImpuestosDS dsTipado = new venMovCSImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/pImpuesto_Id, 
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pRenglonCuerpo),
                new Generalidades.NullableString(/*2*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovCSImpuestosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/pImpuesto_Id, 
            decimal /*3*/pImporte, decimal /*4*/pImporteMonedaNac, decimal /*5*/pPorcentaje, decimal /*6*/pBaseImponible,
            decimal /*7*/pBaseImponibleMonedaNac, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pImpuesto_Id,
                /*3*/pImporte, /*4*/pImporteMonedaNac, /*5*/pPorcentaje, /*6*/pBaseImponible, /*7*/pBaseImponibleMonedaNac };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovCSImpuestosGuardar", parametros);
        }
    }
}
