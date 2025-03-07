using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venMovSSImpuestos
    {
        public static venMovSSImpuestosDS Datos(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/pImpuesto_Id,
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon,
                new Generalidades.NullableString(/*2*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovSSImpuestosDatos", parametros);

            venMovSSImpuestosDS dsTipado = new venMovSSImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/pImpuesto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon,
                new Generalidades.NullableString(/*2*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovSSImpuestosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/pImpuesto_Id, 
            decimal /*3*/pImporte, decimal /*4*/pImporteMonedaNac, decimal /*5*/pPorcentaje, decimal /*6*/pBaseImponible, 
            decimal /*7*/pBaseImponibleMonedaNac, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon, /*2*/pImpuesto_Id, 
                /*3*/pImporte, /*4*/pImporteMonedaNac, /*5*/pPorcentaje, /*6*/pBaseImponible, /*7*/pBaseImponibleMonedaNac };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovSSImpuestosGuardar", parametros);
        }
    }
}
