using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venClieContacto
    {


        public static venClieContactoDS Datos(long /*0*/pCliente_Id, int /*1*/pSucursal, int /*2*/pNroContacto, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal, new Generalidades.NullableInt(/*2*/pNroContacto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venClieContactoDatos", parametros);

            string[] camposTabla0 = { "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venClieContactoDS dsTipado = new venClieContactoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pCliente_Id, int /*1*/pSucursal, int /*2*/pNroContacto, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal, new Generalidades.NullableInt(/*2*/pNroContacto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venClieContactoEliminar", parametros);
        }




        public static void Guardar(long /*0*/pCliente_Id, int /*1*/pSucursal, int /*2*/pNroContacto, string /*3*/pNombre, string /*4*/pPuesto, string /*5*/pEmail, string /*6*/pTelefono, string /*7*/pInterno, string /*8*/pMovil, bool /*9*/pEnviaFacturas, bool /*10*/pEnviaRecibo, bool /*11*/pEnviaPedido, string /*12*/pObservaciones, bool /*13*/pInactivo, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal, /*2*/pNroContacto, /*3*/pNombre, /*4*/pPuesto, /*5*/pEmail, /*6*/pTelefono, /*7*/pInterno, /*8*/pMovil, /*9*/pEnviaFacturas, /*10*/pEnviaRecibo, /*11*/pEnviaPedido, new Generalidades.NullableString(/*12*/pObservaciones), /*13*/pInactivo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venClieContactoGuardar", parametros);
        }






    }
}
