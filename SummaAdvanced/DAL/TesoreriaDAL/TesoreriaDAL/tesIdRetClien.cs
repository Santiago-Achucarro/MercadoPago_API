using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdRetClien
    {
        public static tesIdRetClienDS Datos(string /*0*/pCartera_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesIdRetClienDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas", "Cuenta_Id", "DescripcionCuentas", "Moneda_Id",
                "DescripcionMonedas", "UsuarioAmo", "DescripcionUsuarioAmo", "CtaValEnTransito", "DescripcionCtaValEnTransito",
                "TipoImpuesto", "DescripcionTipoImpuesto","FormaDePagoP" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesIdRetClienDS dsTipado = new tesIdRetClienDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pCartera_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesIdRetClienEliminar", parametros);
        }

        public static void Guardar(string /*0*/pCartera_Id, bool /*1*/pvaSubDiarioVta, int /*2*/pTipoImpuesto, 
            decimal /*3*/pNroResSicore, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pvaSubDiarioVta, /*2*/pTipoImpuesto, /*3*/pNroResSicore };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesIdRetClienGuardar", parametros);
        }
    }
}
