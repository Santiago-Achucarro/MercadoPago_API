using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using interfaceDAAB;
using System.Data;

namespace StockDAL
{
    public class stkExistenciaUbi
    {
        public static stkExistenciaUbiDS Datos(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pDeposito_Id, string /*3*/pUbicacion_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, new Generalidades.NullableString(/*2*/pDeposito_Id), new Generalidades.NullableString(/*3*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaUbiDatos", parametros);

            stkExistenciaUbiDS dsTipado = new stkExistenciaUbiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Sumar(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pDeposito_Id, string /*3*/pUbicacion_Id, decimal /*4*/pCantidad, decimal /*5*/pCantidadReservada, decimal /*6*/pCantidadAlterna, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, /*2*/pDeposito_Id, /*3*/pUbicacion_Id, /*4*/pCantidad, /*5*/pCantidadReservada, /*6*/pCantidadAlterna };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkExistenciaUbiSumar", parametros);
        }




    }
}
