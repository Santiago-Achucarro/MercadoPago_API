using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venRepaPedi
    {
        public static venRepaPediDS Datos(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepaPediDatos", parametros);

            venRepaPediDS dsTipado = new venRepaPediDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, 
            string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep),
                new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venRepaPediEliminar", parametros);
        }
        public static void Guardar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, decimal /*4*/pCantidadForm, decimal /*5*/pCantidadAlternaForm, bool /*6*/pRemitido, bool /*7*/pFacturado, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep, /*2*/pvenPedidos, /*3*/pRenglon_Pe, /*4*/pCantidadForm, /*5*/pCantidadAlternaForm, /*6*/pRemitido, /*7*/pFacturado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediGuardar", parametros);
        }



        public static void MarcarFacturado(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, 
            int /*3*/pRenglon_Pe, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep, /*2*/pvenPedidos, /*3*/pRenglon_Pe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediMarcarFacturado", parametros);
        }

        public static void MarcarRemitido(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, 
            int /*3*/pRenglon_Pe, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep, /*2*/pvenPedidos, /*3*/pRenglon_Pe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediMarcarRemitido", parametros);
        }


        public static venRepaPediDS RepXPed(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepaPediRepXPed", parametros);

            venRepaPediDS dsTipado = new venRepaPediDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void DesMarcarFacturado(int /*0*/pvenReparto, int /*1*/pvenPedidos, int /*2*/pRenglon_Pe, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pvenPedidos, /*2*/pRenglon_Pe };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediDesMarcarFacturado", parametros);
        }

        public static void DesMarcarRemitido(int /*0*/pvenReparto, int /*1*/pvenPedidos, int /*2*/pRenglon_Pe, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pvenPedidos, /*2*/pRenglon_Pe };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediDesMarcarRemitido", parametros);
        }
    }
}
