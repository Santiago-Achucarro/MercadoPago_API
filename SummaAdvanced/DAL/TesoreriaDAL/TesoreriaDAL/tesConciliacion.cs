using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
using interfaceDAAB;
using System.Data;

namespace TesoreriaDAL
{
    public class tesConciliacion
    {
        public static tesConciliacionDS Datos(int /*0*/Empresa_Id, DateTime /*1*/FechaHasta, string /*2*/Cartera_Id, int /*3*/NumeroConc, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/FechaHasta, /*2*/Cartera_Id, /*3*/NumeroConc };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesConciliacionDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "FechaHasta", "NumeroConc" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento_Str", "Renglon", "Monto", "Saldo", "Chequera_Id", "numCheque", "FechaVencimiento", "TipoChequera", "Observaciones", "aLaOrden", "Marca", "PorCheque" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Renglon", "Cliente_Id", "RazonSocial", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Marca", "Cheque" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            tesConciliacionDS dsTipado = new tesConciliacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Cheques.TableName, dsTipado.NoEstan.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pNumeroConc, DateTime /*3*/pFechaConciliacion, decimal /*4*/pExtractoCierre, decimal /*5*/pExtractoApertura, decimal /*6*/pContableApertura, decimal /*7*/pContableCierre, bool /*8*/pPosteado, int /*9*/pUsuario_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pNumeroConc, /*3*/pFechaConciliacion, /*4*/pExtractoCierre, /*5*/pExtractoApertura, /*6*/pContableApertura, /*7*/pContableCierre, /*8*/pPosteado, /*9*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesConciliacionGuardar", parametros);
        }

        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pNumeroConc, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, new Generalidades.NullableInt(/*2*/pNumeroConc) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesConciliacionEliminar", parametros);
        }

        public static void Desmarcar(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pNumeroConc, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pNumeroConc };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesConciliacionDesmarcar", parametros);
        }






    }
}
