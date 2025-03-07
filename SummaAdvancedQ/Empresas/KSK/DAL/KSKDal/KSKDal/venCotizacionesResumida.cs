using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using KSKCommon;
using System.Data;

namespace KSKDAL
{
    public class venCotizacionesResumida
    {
        public static espVenCotizacionResumidaDS Datos(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("espVenCotizacionResumidaDatos", parametros);

            espVenCotizacionResumidaDS dsTipado = new espVenCotizacionResumidaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("espVenCotizacionResumidaEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenCotizaciones, decimal /*1*/pCantidad, string /*2*/pMedida_Id, string /*3*/pLeyenda, decimal /*4*/pValorUnitario, string /*5*/pClaveFiscal, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones, /*1*/pCantidad, /*2*/pMedida_Id, /*3*/pLeyenda, /*4*/pValorUnitario, /*5*/pClaveFiscal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("espVenCotizacionResumidaGuardar", parametros);
        }


    }
}
