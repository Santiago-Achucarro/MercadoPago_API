using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using TesoreriaCommon;
using System.Data;

namespace TesoreriaDAL
{
    public class tesAISaldos
    {

        public static tesAISaldosDS Datos(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesAISaldosDatos", parametros);

            string[] camposTabla1 = { "Chequera_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Cliente_Id", "DescripcionClientes" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            tesAISaldosDS dsTipado = new tesAISaldosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cheques.TableName, dsTipado.Depositos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesAISaldosEliminar", parametros);
        }


        public static void Guardar(string /*0*/pCartera_Id, int /*1*/pEmpresa_Id, decimal /*2*/pSaldoInicial, decimal /*3*/pCambio, int /*4*/pUsuario_Id, bool /*5*/pConfirmado, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa_Id, /*2*/pSaldoInicial, /*3*/pCambio, /*4*/pUsuario_Id, /*5*/pConfirmado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesAISaldosGuardar", parametros);
        }



        public static void EliminarCheques(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesAISaldosEliminarCheques", parametros);
        }




    }
}
