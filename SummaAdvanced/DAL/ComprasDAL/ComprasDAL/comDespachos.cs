using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comDespachos
    {
        public static comDespachosDS Datos(string /*0*/pDespacho_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDespacho_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comDespachosDatos", parametros);

            string[] camposTabla0 = { "Origen", "Aduana", "Fecha", "Aduana_Id", "Anio", "Patente", "Pedimento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comDespachosDS dsTipado = new comDespachosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pDespacho_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDespacho_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comDespachosEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pDespacho_Id, string /*2*/pDespacho_Id_Nuevo, string /*3*/pOrigen, string /*4*/pAduana, DateTime /*5*/pFecha, int /*6*/pUsuario_Id, string /*7*/pAduana_Id, string /*8*/pAnio, string /*9*/pPatente, decimal /*10*/pPedimento, decimal /*11*/pCambio, string /*12*/pMoneda_Id, bool /*13*/pTomaCambioTes, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pDespacho_Id, /*2*/pDespacho_Id_Nuevo, new Generalidades.NullableString(/*3*/pOrigen), new Generalidades.NullableString(/*4*/pAduana), new Generalidades.NullableDate(/*5*/pFecha), /*6*/pUsuario_Id, new Generalidades.NullableString(/*7*/pAduana_Id), new Generalidades.NullableString(/*8*/pAnio), new Generalidades.NullableString(/*9*/pPatente), /*10*/pPedimento, /*11*/pCambio, /*12*/pMoneda_Id, /*13*/pTomaCambioTes };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("comDespachosGuardar", parametros));
        }





    }
}
